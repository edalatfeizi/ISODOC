using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using IKIDMagfaSMSClientWin;
using IsoDoc.Domain.Dtos.Res;
using IsoDoc.Domain.Entities;
using IsoDoc.Domain.Enums;
using IsoDoc.Domain.Interfaces.Repositories;
using IsoDoc.Domain.Interfaces.Services;
using IsoDoc.Domain.Models;
using IsoDocApp.Extensions;
using IsoDocApp.Helpers;
using IsoDocApp.ManageDocRequests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IsoDocApp
{
    public partial class FrmManageDocReqs : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private readonly IManageDocReqsService manageDocReqsService;
        private readonly IPersonelyService personelyService;
        private readonly IDocRequestAttachmentsService docRequestAttachmentsService;
        private readonly IDocConfirmationService docConfirmationService;

        private List<DocRequest> userDocReqs = new List<DocRequest>();
        private Person userInfo;
        private string userName = "";
        private bool isAdmin = false;
        private List<DocRequestStep> selectedDocReqSteps = new List<DocRequestStep>();
        private MagfaSMSClient magfaSMSClient;
        private NewDocConfirmationResDto docConfirmation;
        private string userPersonCode = "";
        private bool showDocRequests = false;
        private List<NewDocConfirmationResDto> docConfirmations;
        private DocRequest selectedDocReq;
        private List<DocSignerResDto> docSigners;
        public FrmManageDocReqs(IManageDocReqsService manageDocReqsService, IDocRequestAttachmentsService docRequestAttachmentsService, IPersonelyService personelyService, IDocConfirmationService docConfirmationService)
        {
            this.manageDocReqsService = manageDocReqsService;
            this.personelyService = personelyService;
            this.docRequestAttachmentsService = docRequestAttachmentsService;
            this.docConfirmationService = docConfirmationService;
            this.magfaSMSClient = new MagfaSMSClient(Constants.SMSConfig);
            InitializeComponent();

        }

        private async void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var frmNewDocReq = new FrmNewDocReq(manageDocReqsService, personelyService, magfaSMSClient);
            var result = frmNewDocReq.ShowDialog();


            if (result == DialogResult.OK)
            {
                //RibbonPage selectedPage = ribbonControl1.Pages[1];
                //ribbonControl1.SelectedPage = selectedPage;

                FilterDocRequests(new FilterDocRequests { CreatorPersonCode = userInfo.PersonCode, Active = true });
            }



        }
        private async void FrmManageDocReqs_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            userName = SystemInformation.UserName;
            if (Program.DebugMode)
                userName = "3910";


            userPersonCode = await personelyService.GetUserPersonCodeByLoginName(userName);
            userInfo = await personelyService.GetUserInfoByPersonCode(userPersonCode);

            // RibbonPage selectedPage = ribbonControl1.Pages[0];
            // ribbonControl1.SelectedPage = selectedPage;
            //if(userInfo != null)
            //GetUserDocRequests();

            if (userInfo != null && (userInfo.CardNumber == "3910" || userInfo.CodeEdare == "SI000" || userInfo.CodeEdare == "SI300" || userInfo.UpperCode == "SI300"))
            {
                tabAllDocRequests.Visible = true;
                btnExecRegulation.Enabled = true;
                //mnuConfirmDoc.Enabled = true;
                //tabDeletedRequests.Visible = true;
            }
            else
                tabAllDocRequests.Visible = false;

            isAdmin = AdminTypes.GetAdminTypes().Any(x => x == ((AdminType)Convert.ToInt32(userInfo.PostTypeID)));
            if (isAdmin || (userInfo != null && (userInfo.CardNumber == "3910" || userInfo.CodeEdare == "SI000")))
                tabDeletedRequests.Visible = true;
            else
                tabDeletedRequests.Visible = false;

            FilterDocRequests(new FilterDocRequests { CreatorPersonCode = userInfo.PersonCode, Active = true });



            //RibbonPage page1 = new RibbonPage("Tab 1");
            //RibbonPage page2 = new RibbonPage("Tab 2");
            //ribbonControl2.Pages.Add(page1);
            //ribbonControl2.Pages.Add(page2);

            // ribbonControl2.AllowMinimizeRibbon = true;
        }
        private async void FilterDocRequests(FilterDocRequests filter)
        {
            ShowProgressBar(true);
            ClearGridView();
            showDocRequests = true;
            userDocReqs = await manageDocReqsService.FilterDocRequests(filter);
            grdUserDocRequests.DataSource = userDocReqs;
            //gridView1.Columns("DocumentCode").BestFit()

            ShowProgressBar(false);
        }
        private void ShowProgressBar(bool visibility)
        {
            loading.Visible = visibility;
        }

        private async void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {

            int rowHandle = gridView1.FocusedRowHandle;
            if (rowHandle >= 0)
            {
                if (timeLineTabsContainer.SelectedTabPage == tabDocConfirmTimeLine)
                {
                    btnPrintConfirmationDoc.Enabled = false;
                    btnConfirm.Enabled = false;
                    confirmationSigners.Items.Clear();

                }

                var idValue = gridView1.GetRowCellValue(rowHandle, "Id");

                if (showDocRequests)
                {
                    var docId = idValue != null ? int.Parse(idValue.ToString()) : 0;
                    selectedDocReq = userDocReqs.Where(x => x.Id == docId).FirstOrDefault();

                    SetTimeLineTabsTitle(selectedDocReq);

                    await GetDocReqSteps(selectedDocReq.Id, selectedDocReq.DocRequestStatus, GetDocRequestStatusDsc(selectedDocReq));
                    var attachment = GridViewHelper.GetGridViewCellValue(gridView1, "HasAttachments");
                    var hasAttachments = attachment != null ? attachment.ToString() : null;
                    if (!string.IsNullOrEmpty(hasAttachments) && hasAttachments.ToString() == "دارد")
                        btnShowAttachments.Enabled = true;
                    else
                        btnShowAttachments.Enabled = false;

                    docConfirmation = await docConfirmationService.GetDocConfirmationByDocReqIdAsync(docId);
                    if (selectedDocReq.DocRequestStatus == DocRequestStatus.Completed && docConfirmation != null)
                    {
                        mnuConfirmDoc.Enabled = false;
                        await GetDocConfirmSigners(docConfirmation.Id);
                    }
                    else
                    {
                        confirmationSigners.Items.Clear();
                        docSigners?.Clear();
                    }


                    //else if (selectedDocReq.DocRequestStatus == DocRequestStatus.Completed && docConfirmation == null)
                    //{
                    //    //mnuConfirmDoc.Enabled = false;
                    //    confirmationSigners.Items.Clear();
                    //    docSigners.Clear();
                    //}
                }
                else
                {
                    var docConfirmation = docConfirmations.Where(x => x.Id == int.Parse(idValue.ToString())).FirstOrDefault();
                    var docRequest = await manageDocReqsService.GetDocRequest(docConfirmation.DocReqId);

                    SetTimeLineTabsTitle(docRequest);

                    await GetDocReqSteps(docRequest.Id, docRequest.DocRequestStatus, GetDocRequestStatusDsc(docRequest));
                    await GetDocConfirmSigners(docConfirmation.Id);

                }






            }


        }
        private void SetTimeLineTabsTitle(DocRequest docRequest)
        {
            switch (docRequest.DocRequestType)
            {
                case DocRequestType.Create:
                    tabDocReqTimeLine.Text = $"{StringResources.TimeLine} {StringResources.NewCreateDocReq}";
                    break;
                case DocRequestType.Update:
                    tabDocReqTimeLine.Text = $"{StringResources.TimeLine} {StringResources.ChangeDocReq}";
                    break;
                case DocRequestType.Delete:
                    tabDocReqTimeLine.Text = $"{StringResources.TimeLine} {StringResources.DeleteDocReq}";
                    break;
                default:
                    break;
            }
        }
        private string GetDocRequestStatusDsc(DocRequest docRequest)
        {
            var docStatusDsc = "";
            switch (docRequest.DocRequestStatus)
            {
                case DocRequestStatus.Canceled:
                    docStatusDsc = docRequest.CancelDesc;
                    break;
                case DocRequestStatus.Deleted:
                    docStatusDsc = docRequest.DeleteDesc;
                    break;

            }

            return docStatusDsc;
        }
        private async Task<bool> GetDocReqSteps(int docReqId, DocRequestStatus docRequestStatus, string docReqStatusDsc)
        {
            ShowProgressBar(true);
            docReqSteps.Items.Clear();
            selectedDocReqSteps = await manageDocReqsService.GetDocRequestSteps(docReqId);

            var steps = await StepsProgressBarHelper.GetDocRequestProgressBarSteps(selectedDocReqSteps, docRequestStatus, docReqStatusDsc);
            foreach (var step in steps)
            {
                docReqSteps.Items.Add(step);
            }

            ShowProgressBar(false);
            return true;
        }
        private async Task<bool> GetDocConfirmSigners(int docConfirmId)
        {
            //ShowProgressBar(true);
            confirmationSigners.Items.Clear();
            docSigners = await docConfirmationService.GetDocConfirmationSignersAsync(docConfirmId);

            var steps = await StepsProgressBarHelper.GetDocConfirmationSignersSteps(docSigners);
            foreach (var step in steps)
            {
                confirmationSigners.Items.Add(step);
            }

            btnPrintConfirmationDoc.Enabled = true;
            btnConfirm.Enabled = true;


            //ShowProgressBar(false);
            return true;
        }
        private void btnDownloadAttachment_Click(object sender, EventArgs e)
        {
            RibbonPage selectedPage = ribbonControl1.SelectedPage;
            if (userDocReqs.Count > 0)
            {
                var docReqId = int.Parse(GridViewHelper.GetGridViewCellValue(gridView1, "Id").ToString());

                var frmManageAttachments = new FrmManageAttachments(docRequestAttachmentsService, docReqId);
                var result = frmManageAttachments.ShowDialog();


                if (result == DialogResult.OK)
                {
                    FilterDocRequests(new FilterDocRequests { ReceiverPersonCode = userInfo.PersonCode, DocRequestStatus = DocRequestStatus.InProgress, Active = true });
                }
            }

        }

        private void ribbonControl1_SelectedPageChanged(object sender, EventArgs e)
        {
            GetDocRequests();
        }
        private void GetDocRequests()
        {
            RibbonPage selectedPage = ribbonControl1.SelectedPage;
            if (selectedPage != null)
            {
                //docReqSteps.Items.Clear();
                confirmationSigners.Items.Clear();
                docReqSteps.Items.Clear();
                grdUserDocRequests.DataSource = null;
                // Check which page was clicked using the Name or Text property
                switch (selectedPage.Name)
                {
                    case "tabReceivedRequests":
                        if (userInfo != null)
                        {
                            docReqSteps.Items.Clear();
                            FilterDocRequests(new FilterDocRequests { ReceiverPersonCode = userInfo.PersonCode, DocRequestStatus = DocRequestStatus.InProgress, Active = true });


                            btnForwardDocReq.Enabled = true;
                            btnAddAttachment.Enabled = true;


                        }

                        break;
                    case "tabSentRequests":
                        if (userInfo != null)
                        {
                            //docReqSteps.Items.Clear();
                            FilterDocRequests(new FilterDocRequests { CreatorPersonCode = userInfo.PersonCode, Active = true });
                            btnForwardDocReq.Enabled = false;
                            btnAddAttachment.Enabled = false;

                        }

                        break;
                    case "tabForwardedDocRequests":
                        if (userInfo != null)
                        {
                            //docReqSteps.Items.Clear();
                            FilterDocRequests(new FilterDocRequests { SenderPersonCode = userInfo.PersonCode, Active = true });
                            btnForwardDocReq.Enabled = false;
                            btnAddAttachment.Enabled = false;

                        }
                        break;

                    case "tabAllDocRequests":
                        if (userInfo != null && (userInfo.DepartCode == "SI000" || userInfo.CodeEdare == "SI300" || userInfo.UpperCode == "SI300"))
                        {
                            //docReqSteps.Items.Clear();
                            FilterDocRequests(new FilterDocRequests { });
                            btnForwardDocReq.Enabled = false;
                            btnAddAttachment.Enabled = false;

                        }
                        break;
                    case "tabDeletedRequests":
                        if (userInfo != null && (userInfo.DepartCode == "SI000" || userInfo.CodeEdare == "SI300" || userInfo.UpperCode == "SI300" || isAdmin))
                        {

                            //docReqSteps.Items.Clear();
                            FilterDocRequests(new FilterDocRequests { ReceiverPersonCode = userInfo.PersonCode, Active = false });
                        }
                        break;
                }
            }
        }

        private void btnForwardDocReq_Click(object sender, EventArgs e)
        {
            ForwardDocRequest();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            GetDocRequests();
        }

        private void gridView1_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            if (showDocRequests)
            {
                GridView view = sender as GridView;

                if (e.Column.FieldName == "DocRequestStatus") // Replace "Status" with your column's field name
                {
                    // Get the value of the cell
                    string status = view.GetRowCellValue(e.RowHandle, "DocRequestStatus").ToString();
                    if (status == DocRequestStatus.InProgress.ToString())
                    {
                        e.Appearance.BackColor = Color.Gold;
                    }
                    else if (status == DocRequestStatus.Completed.ToString())
                    {
                        e.Appearance.BackColor = Color.YellowGreen;
                    }
                    else if (status == DocRequestStatus.Canceled.ToString())
                    {
                        e.Appearance.BackColor = Color.Lavender;
                    }
                    else if (status == DocRequestStatus.Deleted.ToString())
                    {
                        e.Appearance.BackColor = Color.Salmon;
                    }
                }
            }

        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            ForwardDocRequest();
        }

        private void ForwardDocRequest()
        {

            RibbonPage selectedPage = ribbonControl1.SelectedPage;
            if (selectedPage.Name == tabReceivedRequests.Name && userDocReqs.Count > 0)
            {
                var docReqId = int.Parse(GridViewHelper.GetGridViewCellValue(gridView1, "Id").ToString());
                var lastDocReqStepId = selectedDocReqSteps.Last().Id;
                var docRequest = userDocReqs.Where(x => x.Id == docReqId).FirstOrDefault();

                var frmForwardDocReq = new FrmForwardDocReq(manageDocReqsService, personelyService, docReqId, lastDocReqStepId, docRequest.DocRequestStatus, GetDocRequestStatusDsc(docRequest), magfaSMSClient);
                var result = frmForwardDocReq.ShowDialog();


                if (result == DialogResult.OK)
                {
                    FilterDocRequests(new FilterDocRequests { ReceiverPersonCode = userInfo.PersonCode, DocRequestStatus = DocRequestStatus.InProgress, Active = true });
                }
            }

        }

        private async void gridView1_MouseDown(object sender, MouseEventArgs e)
        {




        }


        private async void mnuCompleteReq_Click(object sender, EventArgs e)
        {
            var docReqId = int.Parse(GridViewHelper.GetGridViewCellValue(gridView1, "Id").ToString());
            ShowProgressBar(true);
            var result = await manageDocReqsService.UpdateDocRequestStatus(docReqId, DocRequestStatus.Completed, "", userInfo.PersonCode);
            btnReload.PerformClick();
        }

        private async void mnuCancelReq_Click(object sender, EventArgs e)
        {
            var docReqId = int.Parse(GridViewHelper.GetGridViewCellValue(gridView1, "Id").ToString());
            string cancelReason = XtraInputBox.Show(StringResources.EnterCancelReason, StringResources.CancelReason, "");

            // Check if the user clicked OK and the input is not empty
            if (!string.IsNullOrEmpty(cancelReason))
            {
                ShowProgressBar(true);
                var result = await manageDocReqsService.UpdateDocRequestStatus(docReqId, DocRequestStatus.Canceled, cancelReason, userInfo.PersonCode);
                btnReload.PerformClick();

            }
        }

        private async void mnuDeleteReq_Click(object sender, EventArgs e)
        {
            var docReqId = int.Parse(GridViewHelper.GetGridViewCellValue(gridView1, "Id").ToString());
            string deleteReason = XtraInputBox.Show(StringResources.EnterDeleteReason, StringResources.DeleteRequest, "");

            // Check if the user clicked OK and the input is not empty
            if (!string.IsNullOrEmpty(deleteReason))
            {
                ShowProgressBar(true);
                await manageDocReqsService.UpdateDocRequestStatus(docReqId, DocRequestStatus.Deleted, "", userInfo.PersonCode);
                await manageDocReqsService.SetDocRequestActive(docReqId, deleteReason, false);
                btnReload.PerformClick();

            }
        }

        private async void mnuEnableReq_Click(object sender, EventArgs e)
        {
            var docReqId = int.Parse(GridViewHelper.GetGridViewCellValue(gridView1, "Id").ToString());


            ShowProgressBar(true);
            await manageDocReqsService.UpdateDocRequestStatus(docReqId, DocRequestStatus.InProgress, "", userInfo.PersonCode);
            await manageDocReqsService.SetDocRequestActive(docReqId, "", true);
            btnReload.PerformClick();

        }

        private async void gridView1_MouseUp(object sender, MouseEventArgs e)
        {
            if (userDocReqs.Count > 0)
            {
                //var docReqId = int.Parse(GridViewHelper.GetGridViewCellValue(gridView1, "Id").ToString());
                //var docReq = await manageDocReqsService.GetDocRequest(docReqId);

                RibbonPage selectedPage = ribbonControl1.SelectedPage;

                if (selectedPage.Name == "tabReceivedRequests" && e.Button == MouseButtons.Right)
                {
                    if (isAdmin)
                    {
                        var creatorUser = await personelyService.GetUserInfoByPersonCode(selectedDocReq.CreatedBy);

                        if (userInfo.DepartCode == creatorUser.DepartCode)
                        {
                            contextMenuStrip2.Show(grdUserDocRequests, e.Location);
                            mnuDeleteReq.Enabled = true;
                            mnuEnableReq.Enabled = false;

                        }

                    }
                    if (userInfo.CodeEdare == "SI300" || userInfo.UpperCode == "SI300") // if user is sys office emp or developer
                    {

                        // Show the ContextMenuStrip at the mouse position
                        contextMenuStrip2.Show(grdUserDocRequests, e.Location);
                        mnuCancelReq.Enabled = true;
                        //else if (e.Button == MouseButtons.Right && selectedPage.Name == "tabAllDocRequests" && SysOfficeAdmins.GetSysOfficeAdmins().Contains(Convert.ToInt32(userInfo.DepartID)))
                        //{
                        //    ContextMenuStrip1.Show(grdUserDocRequests, e.Location);

                        //}
                    }
                    else if (userInfo.CodeEdare == "SI000") //if user is sys dep admin
                    {

                        // Show the ContextMenuStrip at the mouse position
                        contextMenuStrip2.Show(grdUserDocRequests, e.Location);
                        if (selectedPage.Name == tabReceivedRequests.Name)
                            mnuCompleteReq.Enabled = true;

                    }
                }

                if (isAdmin && selectedPage.Name == tabDeletedRequests.Name && e.Button == MouseButtons.Right)
                {
                    contextMenuStrip2.Show(grdUserDocRequests, e.Location);
                    mnuDeleteReq.Enabled = false;
                    mnuEnableReq.Enabled = true;
                }

                if (selectedPage.Name == tabAllDocRequests.Name && e.Button == MouseButtons.Right && userInfo != null && (userInfo.CardNumber == "3910" || userInfo.CodeEdare == "SI000" || userInfo.CodeEdare == "SI300" || userInfo.UpperCode == "SI300"))
                {
                    contextMenuStrip2.Show(grdUserDocRequests, e.Location);
                    if (selectedDocReq.DocRequestStatus == DocRequestStatus.Completed)
                        mnuConfirmDoc.Enabled = true;
                    else
                    {
                        mnuConfirmDoc.Enabled = false;

                    }

                }
                //if(userInfo.CodeEdare == "SI300" || userInfo.UpperCode == "SI300" || userInfo.CodeEdare == "SI000" || userInfo.)
            }



        }

        private async void btnAddAttachment_Click(object sender, EventArgs e)
        {
            RibbonPage selectedPage = ribbonControl1.SelectedPage;
            if (selectedPage.Name == tabReceivedRequests.Name && userDocReqs.Count > 0)
            {
                var docReqId = int.Parse(GridViewHelper.GetGridViewCellValue(gridView1, "Id").ToString());
                var docReqAttachment =  AttachmentsHelper.AttachFile(Constants.DocReqAttachmentFileTypes, false)?.MapToDocRequestAttachment(docReqId);
                if (docReqAttachment != null)
                {
                    docReqAttachment.DocRequestId = docReqId;
                    docReqAttachment.CreatedBy = userInfo.PersonCode;
                    docReqAttachment.ModifiedBy = userInfo.PersonCode;
                    ShowProgressBar(true);
                    await manageDocReqsService.AttachFileAsync(docReqAttachment);
                    ShowProgressBar(false);
                    toastNotificationsManager1.ShowNotification(toastNotificationsManager1.Notifications[0]);

                }
            }

        }


        private void btnExecRegulation_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var frmExecReq = new FrmExecuteRegulationPermission();
            var result = frmExecReq.ShowDialog();
        }

        private void ribbonControl2_SelectedPageChanged(object sender, EventArgs e)
        {
            //if (ribbonControl2.SelectedPage != null)
            //{
            //    foreach (RibbonPageGroup group in ribbonControl2.SelectedPage.Groups)
            //    {
            //        group.Visible = false; // Hide the group
            //    }
            //}
        }

        private void mnuConfirmDoc_Click(object sender, EventArgs e)
        {
            var docReqId = int.Parse(GridViewHelper.GetGridViewCellValue(gridView1, "Id").ToString());
            var frmNewDocReq = new FrmConfirmNewDoc(personelyService, manageDocReqsService, docConfirmationService, magfaSMSClient, docReqId);
            var result = frmNewDocReq.ShowDialog();
        }

        private async void btnShowDocConfirmations_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ClearGridView();
            showDocRequests = false;
            docConfirmations = await docConfirmationService.GetUserDocConfirmationsAsync(userPersonCode);
            grdUserDocRequests.DataSource = docConfirmations;

            gridView1.Columns["Id"].BestFit();
            //gridView1.Columns["ReviewNo"].BestFit();
            gridView1.Columns["DocCode"].BestFit();
        }

        private void ClearGridView()
        {
            grdUserDocRequests.DataSource = null;
            if (gridView1.Columns.Count > 0)
            {
                gridView1.Columns.Clear();
            }
        }

        private void btnShowDocReqs_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (userInfo != null)
            {
                // docReqSteps.Items.Clear();
                FilterDocRequests(new FilterDocRequests { ReceiverPersonCode = userInfo.PersonCode, DocRequestStatus = DocRequestStatus.InProgress, Active = true });


                btnForwardDocReq.Enabled = true;
                btnAddAttachment.Enabled = true;


            }
        }

        private void timeLineTabsContainer_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
        {

            if (timeLineTabsContainer.SelectedTabPage == tabDocConfirmTimeLine && (docSigners != null && docSigners.Count == 0))
            {
                confirmationSigners.Items.Clear();
                btnPrintConfirmationDoc.Enabled = false;
                if(ribbonControl1.SelectedPage == tabReceivedRequests)
                    btnConfirm.Enabled = true;
                else
                    btnConfirm.Enabled = false;
            }
        }
    }
}
