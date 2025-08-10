using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraReports.UI;
using IKIDMagfaSMSClientWin;
using IsoDoc.Domain.Dtos;
using IsoDoc.Domain.Dtos.Res;
using IsoDoc.Domain.Entities;
using IsoDoc.Domain.Enums;
using IsoDoc.Domain.Interfaces.Services;
using IsoDoc.Domain.Models;
using IsoDocApp.Enums;
using IsoDocApp.Extensions;
using IsoDocApp.Helpers;
using IsoDocApp.ManageDocRequests;
using IsoDocApp.Models;
using IsoDocApp.Reports;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
        private MagfaSMSClient smsClient;
        private NewDocConfirmationResDto docConfirmation;
        private string userPersonCode = "";
        private bool showDocRequests = false;
        private List<NewDocConfirmationResDto> docConfirmations;
        private DocRequest selectedDocReq;
        private List<DocSignerResDto> docSigners;
        private DocRequestPeople receiverUser;
        private List<DocRequestPeople> receiverUsersList;
        public FrmManageDocReqs(IManageDocReqsService manageDocReqsService, IDocRequestAttachmentsService docRequestAttachmentsService, IPersonelyService personelyService, IDocConfirmationService docConfirmationService)
        {
            InitializeComponent();

            this.manageDocReqsService = manageDocReqsService;
            this.personelyService = personelyService;
            this.docRequestAttachmentsService = docRequestAttachmentsService;
            this.docConfirmationService = docConfirmationService;
            this.smsClient = new MagfaSMSClient(Constants.SMSConfig);
        }

        private async void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var frmNewDocReq = new FrmNewDocReq(manageDocReqsService, personelyService, smsClient);
            var result = frmNewDocReq.ShowDialog();


            if (result == DialogResult.OK)
            {
                //RibbonPage selectedPage = ribbonControl1.Pages[1];
                //ribbonControl1.SelectedPage = selectedPage;

                await FilterDocRequests(new FilterDocRequests { CreatorPersonCode = userInfo.PersonCode, Active = true });
            }



        }
        private async void FrmManageDocReqs_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            userName = SystemInformation.UserName;

            cmbReceiverUser.Properties.DisplayMember = "Name";
            cmbReceiverUser.Properties.ValueMember = "PersonCode";

            tabReqChatRoom.PageEnabled = true;

            userPersonCode = await personelyService.GetUserPersonCodeByLoginName(userName);
            userInfo = await personelyService.GetUserInfoByPersonCode(userPersonCode);

            // RibbonPage selectedPage = ribbonControl1.Pages[0];
            // ribbonControl1.SelectedPage = selectedPage;
            //if(userInfo != null)
            //GetUserDocRequests();

            

            if (userInfo != null && (userInfo.CodeEdare == "SI000" || userInfo.CodeEdare == "SI300" || userInfo.UpperCode == "SI300" || userInfo.PersonCode.IsDeveloper()))
            {
                tabAllDocRequests.Visible = true;
                btnExecRegulation.Enabled = true;
                //mnuConfirmDoc.Enabled = true;
                //tabDeletedRequests.Visible = true;
            }
            else
                tabAllDocRequests.Visible = false;

            isAdmin = AdminTypes.GetAdminTypes().Any(x => x == ((AdminType)Convert.ToInt32(userInfo.PostTypeID)));
            if (isAdmin || (userInfo != null && userInfo.PersonCode.IsDeveloper()))
                tabDeletedRequests.Visible = true;
            else
                tabDeletedRequests.Visible = false;

           await FilterDocRequests(new FilterDocRequests { CreatorPersonCode = userInfo.PersonCode, Active = true });



            //RibbonPage page1 = new RibbonPage("Tab 1");
            //RibbonPage page2 = new RibbonPage("Tab 2");
            //ribbonControl2.Pages.Add(page1);
            //ribbonControl2.Pages.Add(page2);

            // ribbonControl2.AllowMinimizeRibbon = true;
        }
        private async Task FilterDocRequests(FilterDocRequests filter)
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
                cmbReceiverUser.Properties.DataSource = null;

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

                    //SetTimeLineTabsTitle(selectedDocReq);

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


                        await GetDocConfirmSigners(docConfirmation.Id, docId);
                    }
                    else
                    {
                        confirmationSigners.Items.Clear();
                        docSigners?.Clear();
                    }
                    var docReqMessages = await manageDocReqsService.GetDocRequestAllChatMessagesAsync(docId);
                    SetChatMessages(docReqMessages, MessageTypes.All);
                    receiverUsersList = await GetDocRequestPeopleAsync(docId);
                    cmbReceiverUser.Properties.DataSource = receiverUsersList;
                    //else if (selectedDocReq.DocRequestStatus == DocRequestStatus.Completed && docConfirmation == null)
                    //{
                    //    //mnuConfirmDoc.Enabled = false;
                    //    confirmationSigners.Items.Clear();
                    //    docSigners.Clear();
                    //}
                   // if(sdf)
                }
                else
                {
                    var docConfirmation = docConfirmations.Where(x => x.Id == int.Parse(idValue.ToString())).FirstOrDefault();
                    var docRequest = await manageDocReqsService.GetDocRequest(docConfirmation.DocReqId);
                    var docReqHasAttachments = await manageDocReqsService.HasAttachmentsAsync(docRequest.Id);
                    if(docReqHasAttachments)
                        btnShowAttachments.Enabled = true;

                    //SetTimeLineTabsTitle(docRequest);

                    await GetDocReqSteps(docRequest.Id, docRequest.DocRequestStatus, GetDocRequestStatusDsc(docRequest));
                    await GetDocConfirmSigners(docConfirmation.Id, docRequest.Id);

                    receiverUsersList = await GetDocRequestPeopleAsync(docRequest.Id);
                    cmbReceiverUser.Properties.DataSource = receiverUsersList;

                    var docReqMessages = await manageDocReqsService.GetDocRequestAllChatMessagesAsync(docRequest.Id);
                    SetChatMessages(docReqMessages, MessageTypes.All);
                }






            }
            else
            {
                SetBottomBarControlEnabled(false);
            }


        }
        private void SetBottomBarControlEnabled(bool enabled)
        {
            btnShowAttachments.Enabled = enabled;
            btnAddAttachment.Enabled = enabled;
            btnForwardDocReq.Enabled = enabled;
            btnAddAttachment.Enabled = enabled;
            btnPrintConfirmationDoc.Enabled = enabled;
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
        private async Task<bool> GetDocConfirmSigners(int docConfirmId, int docReqId)
        {
            //ShowProgressBar(true);
            docSigners = await docConfirmationService.GetDocConfirmationSignersAsync(docConfirmId);

            UpdateDocSignersStepsTimeLine();
            if (ribbonControl1.SelectedPage == tabReceivedRequests && docSigners.Any(x => x.PersonCode == userInfo.PersonCode && !x.IsSigned))
                btnConfirm.Enabled = true;
            else
                btnConfirm.Enabled = false;

            btnPrintConfirmationDoc.Enabled = true;
            var lastSigner = docSigners.LastOrDefault();
            if(lastSigner != null && !lastSigner.IsCanceled)
            {
                if (userInfo.CodeEdare == "SI000" || userInfo.PersonCode.IsDeveloper())
                    btnCancelSigning.Visible = true;
            }
            
            //ShowProgressBar(false);
            return true;
        }

        private async Task<List<DocRequestPeople>> GetDocRequestPeopleAsync(int docReqId)
        {
            var docReqPeople = await manageDocReqsService.GetDocRequestActivePeopleAsync(docReqId);
            var docSignersReceiverUsers = new List<DocRequestPeople>();
            if (docSigners != null && docSigners.Count > 0)
            {
                docSignersReceiverUsers = docSigners.Select(signer => new DocRequestPeople { PersonCode = signer.PersonCode, Name = signer.Name, Post = signer.Post }).ToList();
            }
            var docPeople = docReqPeople.Select(people => new DocRequestPeople { PersonCode = people.PersonCode, Name = people.Name, Post = people.Post }).ToList();
            var receiverUsersList =
                docSignersReceiverUsers
                .Concat(docPeople)
                .GroupBy(u => u.PersonCode)
                .Select(g => g.First())
                .ToList();

            var userItself = receiverUsersList.Where(x => x.PersonCode == userInfo.PersonCode).FirstOrDefault();
            if (userItself != null)
                receiverUsersList.Remove(userItself);

            return receiverUsersList;
        }
        private async void UpdateDocSignersStepsTimeLine()
        {
            confirmationSigners.Items.Clear();
            var steps = await StepsProgressBarHelper.GetDocConfirmationSignersSteps(docSigners);
            foreach (var step in steps)
            {
                confirmationSigners.Items.Add(step);
            }
        }
        private async void btnDownloadAttachment_Click(object sender, EventArgs e)
        {
            RibbonPage selectedPage = ribbonControl1.SelectedPage;
            if (userDocReqs.Count > 0)
            {
                var docReqId = int.Parse(GridViewHelper.GetGridViewCellValue(gridView1, "Id").ToString());

                var frmManageAttachments = new FrmManageAttachments(docRequestAttachmentsService, docReqId);
                var result = frmManageAttachments.ShowDialog();


                if (result == DialogResult.OK)
                {
                   await FilterDocRequests(new FilterDocRequests { ReceiverPersonCode = userInfo.PersonCode, DocRequestStatus = DocRequestStatus.InProgress, Active = true });
                }
            }
            else if (docConfirmations != null && docConfirmations.Count > 0)
            {
                var docConfirmId = int.Parse(GridViewHelper.GetGridViewCellValue(gridView1, "Id").ToString(),0);
                if(docConfirmId != 0)
                {
                    var docConfirmation = docConfirmations.Where(x => x.Id == docConfirmId).FirstOrDefault();
                    var frmManageAttachments = new FrmManageAttachments(docRequestAttachmentsService, docConfirmation.DocReqId);
                    frmManageAttachments.ShowDialog();
                }
                
            }


        }

        private async void ribbonControl1_SelectedPageChanged(object sender, EventArgs e)
        {
            await GetDocRequests();
        }
        private async Task GetDocRequests()
        {
            SetBottomBarControlEnabled(false);
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
                            await FilterDocRequests(new FilterDocRequests { ReceiverPersonCode = userInfo.PersonCode, DocRequestStatus = DocRequestStatus.InProgress, Active = true });


                            //btnForwardDocReq.Enabled = true;
                            //btnAddAttachment.Enabled = true;


                        }
                        //ToggleConfirmationButtonsState(false);
                        break;
                    case "tabSentRequests":
                        if (userInfo != null)
                        {
                            //docReqSteps.Items.Clear();
                            await FilterDocRequests(new FilterDocRequests { CreatorPersonCode = userInfo.PersonCode, Active = true });
                            //btnForwardDocReq.Enabled = false;
                            //btnAddAttachment.Enabled = false;

                        }
                        //ToggleConfirmationButtonsState(false);
                        break;
                    case "tabForwardedDocRequests":
                        if (userInfo != null)
                        {
                            //docReqSteps.Items.Clear();
                            await FilterDocRequests(new FilterDocRequests { SenderPersonCode = userInfo.PersonCode, Active = true });
                            //btnForwardDocReq.Enabled = false;
                            //btnAddAttachment.Enabled = false;

                        }
                        //ToggleConfirmationButtonsState(false);

                        break;

                    case "tabAllDocRequests":
                        if (userInfo != null && (userInfo.DepartCode == "SI000" || userInfo.CodeEdare == "SI300" || userInfo.UpperCode == "SI300" || userInfo.PersonCode.IsDeveloper()))
                        {
                            //docReqSteps.Items.Clear();
                            await FilterDocRequests(new FilterDocRequests { });
                            //btnForwardDocReq.Enabled = false;
                            //btnAddAttachment.Enabled = false;

                        }
                        //ToggleConfirmationButtonsState(false);

                        break;
                    case "tabDeletedRequests":
                        if (userInfo != null && (userInfo.DepartCode == "SI000" || userInfo.CodeEdare == "SI300" || userInfo.UpperCode == "SI300" || isAdmin || userInfo.PersonCode.IsDeveloper()))
                        {

                            //docReqSteps.Items.Clear();
                            await FilterDocRequests(new FilterDocRequests { ReceiverPersonCode = userInfo.PersonCode, Active = false });
                        }
                        //ToggleConfirmationButtonsState(false);

                        break;
                }
            }
        }

        private async void btnForwardDocReq_Click(object sender, EventArgs e)
        {
           await ForwardDocRequest();
        }
        private void ToggleConfirmationButtonsState(bool state)
        {
            btnConfirm.Enabled = state;
            btnPrintConfirmationDoc.Enabled = state;
        }
        private async void btnReload_Click(object sender, EventArgs e)
        {
           await Reload();
        }
        
        private void gridView1_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            GridView view = sender as GridView;
            string status = "";
            if (showDocRequests)
            {
                if (e.Column.FieldName == "DocRequestStatus") // Replace "Status" with your column's field name
                {
                    // Get the value of the cell
                     status = view.GetRowCellValue(e.RowHandle, "DocRequestStatus").ToString();
                }
            }
            else
            {
                if (e.Column.FieldName == "ConfirmationStatus")
                {
                     status = view.GetRowCellValue(e.RowHandle, "ConfirmationStatus").ToString();
                }
            }

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

        private async void gridView1_DoubleClick(object sender, EventArgs e)
        {
            await ForwardDocRequest();
        }

        private async Task ForwardDocRequest()
        {

            RibbonPage selectedPage = ribbonControl1.SelectedPage;
            if (selectedPage.Name == tabReceivedRequests.Name && userDocReqs.Count > 0)
            {
                var docReqId = int.Parse(GridViewHelper.GetGridViewCellValue(gridView1, "Id").ToString());
                var lastDocReqStepId = selectedDocReqSteps.Last().Id;
                var docRequest = userDocReqs.Where(x => x.Id == docReqId).FirstOrDefault();

                var frmForwardDocReq = new FrmForwardDocReq(manageDocReqsService, personelyService, docReqId, lastDocReqStepId, docRequest.DocRequestStatus, GetDocRequestStatusDsc(docRequest), smsClient);
                var result = frmForwardDocReq.ShowDialog();


                if (result == DialogResult.OK)
                {
                    await FilterDocRequests(new FilterDocRequests { ReceiverPersonCode = userInfo.PersonCode, DocRequestStatus = DocRequestStatus.InProgress, Active = true });
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
            await Reload();
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
                await Reload();

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
                await Reload();

            }
        }

        private async void mnuEnableReq_Click(object sender, EventArgs e)
        {
            var docReqId = int.Parse(GridViewHelper.GetGridViewCellValue(gridView1, "Id").ToString());


            ShowProgressBar(true);
            await manageDocReqsService.UpdateDocRequestStatus(docReqId, DocRequestStatus.InProgress, "", userInfo.PersonCode);
            await manageDocReqsService.SetDocRequestActive(docReqId, "", true);
            await Reload();

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
                    if (userInfo.CodeEdare == "SI300" || userInfo.UpperCode == "SI300" || userInfo.PersonCode.IsDeveloper()) // if user is sys office emp or developer
                    {

                        // Show the ContextMenuStrip at the mouse position
                        contextMenuStrip2.Show(grdUserDocRequests, e.Location);
                        mnuCancelReq.Enabled = true;
                        //else if (e.Button == MouseButtons.Right && selectedPage.Name == "tabAllDocRequests" && SysOfficeAdmins.GetSysOfficeAdmins().Contains(Convert.ToInt32(userInfo.DepartID)))
                        //{
                        //    ContextMenuStrip1.Show(grdUserDocRequests, e.Location);

                        //}
                    }
                    else if (userInfo.CodeEdare == "SI000" || userInfo.PersonCode.IsDeveloper()) //if user is sys dep admin
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

                if (selectedPage.Name == tabAllDocRequests.Name && e.Button == MouseButtons.Right && userInfo != null && (userInfo.CodeEdare == "SI000" || userInfo.CodeEdare == "SI300" || userInfo.UpperCode == "SI300" || userInfo.PersonCode.IsDeveloper()))
                {
                    contextMenuStrip2.Show(grdUserDocRequests, e.Location);
                    if (selectedDocReq.DocRequestStatus == DocRequestStatus.Completed)
                    {
                        var idValue = GridViewHelper.GetGridViewCellValue(gridView1,"Id");

                        var docId = idValue != null ? int.Parse(idValue.ToString()) : 0;
                        var docConfirmation = await docConfirmationService.GetDocConfirmationByDocReqIdAsync(docId);
                        var docConfirmSigners = await docConfirmationService.GetDocConfirmationSignersAsync(docConfirmation.Id);
                        if (docConfirmSigners.Count == 0 || docConfirmSigners.Last().IsCanceled)
                        {
                            mnuConfirmDoc.Enabled = true;

                        }
                    }
                        
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
                var docReqAttachment = AttachmentsHelper.AttachFile(Constants.DocReqAttachmentFileTypes, false)?.MapToDocRequestAttachment(docReqId);
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

        private async void mnuConfirmDoc_Click(object sender, EventArgs e)
        {
            var docReqId = int.Parse(GridViewHelper.GetGridViewCellValue(gridView1, "Id").ToString());

            var docConfirmation = await docConfirmationService.GetDocConfirmationByDocReqIdAsync(docReqId);
            if (docConfirmation != null)
            {
                var frmNewDocReq = new FrmConfirmNewDoc(personelyService, manageDocReqsService, docConfirmationService, smsClient, docReqId,docConfirmation.Id);
                var result  = frmNewDocReq.ShowDialog();
                if (result == DialogResult.OK)
                {
                    docSigners = await docConfirmationService.GetDocConfirmationSignersAsync(docConfirmation.Id);
                    UpdateDocSignersStepsTimeLine();
                }
            }
            else
            {
                var frmNewDocReq = new FrmConfirmNewDoc(personelyService, manageDocReqsService, docConfirmationService, smsClient, docReqId);
                var result = frmNewDocReq.ShowDialog();
                if (result == DialogResult.OK)
                {
                    docSigners = await docConfirmationService.GetDocConfirmationSignersAsync(docConfirmation.Id);
                    UpdateDocSignersStepsTimeLine();
                }
            }
           
          
       
        }

        private async void btnShowDocConfirmations_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            await LoadDocConfirmations();
        }

        private void ClearGridView()
        {
            grdUserDocRequests.DataSource = null;
            if (gridView1.Columns.Count > 0)
            {
                gridView1.Columns.Clear();
            }
        }
        private async Task LoadDocConfirmations()
        {
            ClearGridView();
            showDocRequests = false;
            docConfirmations = await docConfirmationService.GetUserDocConfirmationsAsync(userPersonCode);
            grdUserDocRequests.DataSource = docConfirmations;

            gridView1.Columns["Id"].BestFit();
            //gridView1.Columns["ReviewNo"].BestFit();
            gridView1.Columns["DocCode"].BestFit();

            //btnForwardDocReq.Enabled = false;
            //btnAddAttachment.Enabled = false;
        }
        private async void btnShowDocReqs_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (userInfo != null)
            {
                // docReqSteps.Items.Clear();
                await FilterDocRequests(new FilterDocRequests { ReceiverPersonCode = userInfo.PersonCode, DocRequestStatus = DocRequestStatus.InProgress, Active = true });


                //btnForwardDocReq.Enabled = true;
                //btnAddAttachment.Enabled = true;


                //btnForwardDocReq.Enabled = true;
                //btnAddAttachment.Enabled = true;
            }

        }

        private void timeLineTabsContainer_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
        {

            if (timeLineTabsContainer.SelectedTabPage == tabDocConfirmTimeLine && (docSigners != null && docSigners.Count == 0))
            {
                //confirmationSigners.Items.Clear();
                btnPrintConfirmationDoc.Enabled = false;
                //if (ribbonControl1.SelectedPage == tabReceivedRequests)
                //    btnConfirm.Enabled = true;
                //else
                //    btnConfirm.Enabled = false;
            }
            else
                btnPrintConfirmationDoc.Enabled = true;

        }

        private async void btnConfirm_Click(object sender, EventArgs e)
        {
            ShowProgressBar(true);

            var docConfirmId = int.Parse(GridViewHelper.GetGridViewCellValue(gridView1, "Id").ToString());

            var docConfirmation = docConfirmations.Where(x => x.Id == docConfirmId).FirstOrDefault();

            var docSigner = docSigners.Where(x => x.PersonCode == userInfo.PersonCode && !x.IsSigned).First();

            var result = await docConfirmationService.SignDocConfirmationAsync(docSigner.Id);
            if (result)
            {
                btnConfirm.Enabled = false;
                docSigner.IsSigned = true;
                docSigner.SigningDate = DateTime.Now.ToPersianDateTime();

                toastNotificationsManager1.ShowNotification(toastNotificationsManager1.Notifications[1]);

                var nextDocSigner = docSigners.Where(x => x.SigningOrder > docSigner.SigningOrder).FirstOrDefault();

                if (nextDocSigner != null)
                {
                    nextDocSigner.SignRequestSentDate = DateTime.Now.ToPersianDateTime();
                    nextDocSigner.Active = true;

                    await docConfirmationService.UpdateSendSignRequestDate(nextDocSigner.Id, nextDocSigner.PersonCode);

                    var nextSignerUserInfo = await personelyService.GetUserInfoByPersonCode(nextDocSigner.PersonCode);
                    var mobile = nextSignerUserInfo.Mobile;
                    var text = $"{StringResources.NewSignDocReqSent} \n {StringResources.IKID}";

                    smsClient.SendSMS(mobile, text);
                }
                UpdateDocSignersStepsTimeLine();

            }
            else
            {
                toastNotificationsManager1.ShowNotification(toastNotificationsManager1.Notifications[2]);

            }
            ShowProgressBar(false);
        }

        private async void btnPrintConfirmationDoc_Click(object sender, EventArgs e)
        {
            // Create report instance
            if(docSigners != null)
            {
                ShowProgressBar(true);
                btnPrintConfirmationDoc.Enabled = false;
                string confirmDate = null;
                var newSigners = new List<DocSignerResDto>();
                if (docSigners.Any(x => x.IsCanceled))
                {
                    var canceledSigner = docSigners.Where(x => x.IsCanceled).First();

                    var isCanceledIndex = docSigners.IndexOf(canceledSigner);
                    newSigners = docSigners.Skip(isCanceledIndex + 1).ToList();
                }
                else
                    newSigners = docSigners;


                foreach (var signer in newSigners)
                {
                    if (signer.IsSigned)
                    {
                        var signerSignature = await personelyService.GetPersonSignature(signer.PersonCode);
                        signer.Signature = signerSignature.FileContent;
                    }


                }
                var lastSigner = newSigners.OrderByDescending(x => x.SigningOrder).FirstOrDefault();
                if (lastSigner != null && lastSigner.IsSigned)
                    confirmDate = lastSigner.SigningDate;

                var docConfirmId = int.Parse(GridViewHelper.GetGridViewCellValue(gridView1, "Id").ToString());

                var docConfirmation = docConfirmations.Where(x => x.Id == docConfirmId).FirstOrDefault();

                XtraReport report = new RptNewDocConfirmation();

                // Create data source
                //var reportData = new NewDocConfirmationReport(docConfirmation, docSigners);
                var newDocConfirmationReport = new NewDocConfirmationReport(docConfirmation, newSigners)
                {
                    UserName = $"{userInfo.FirstName} {userInfo.LastName} - {userInfo.Posttxt}",
                    PersonCode = userInfo.PersonCode,
                    Environment = Environment.MachineName,
                    IpAddress = Utils.GetIpAddress(),
                    IpPCName = $"{Environment.MachineName} - {Utils.GetIpAddress()}",
                    ConfirmDate = confirmDate != null ? confirmDate : StringResources.NotConfirmed,
                };
                var reportData = new List<NewDocConfirmationReport>
                {
                    newDocConfirmationReport
                };
                // Assign data source
                report.DataSource = reportData;

                // Show the report
                using (ReportPrintTool printTool = new ReportPrintTool(report))
                {
                    printTool.ShowPreviewDialog();
                }

                ShowProgressBar(false);
                btnPrintConfirmationDoc.Enabled = true;
            }
            
        }

        private void SetChatMessages(List<DocRequestChatMessage> chatMessages, MessageTypes messageType)
        {

            gridControl1.DataSource = null;
            var messages = chatMessages.Select(msg =>
                             new ChatMessage
                             {
                                 SenderUser = $"{StringResources.Sender} {msg.SenderUserFullName} - {msg.SenderUserPost}",
                                 ReceiverUser = $"{StringResources.Receiver} {msg.ReceiverUserFullName} - {msg.ReceiverUserPost}",
                                 Message = msg.Message,
                                 SendDateTime = $"{msg.CreatedAt.FormatPersianDate()}"
                             }
                         ).ToList();

            if (messages.Count > 0)
            {
                gridControl1.Visible = true;
                pcChatMsg.Visible = false;
                gridControl1.DataSource = messages;

            }
            else
            {
                gridControl1.Visible = false;
                pcChatMsg.Visible = true;
                switch (messageType)
                {
                    case MessageTypes.All:
                        lblChatMessage.Text = StringResources.NoMessageInRoom;
                        break;
                    case MessageTypes.Sent:
                        lblChatMessage.Text = StringResources.NoMessageSent;
                        break;

                    case MessageTypes.Received:
                        lblChatMessage.Text = StringResources.NoMessageReceived;
                        break;
                }
            }
        }

        private async void btnAllMessages_Click(object sender, EventArgs e)
        {

            await GetAllMessagesAsync();
        }


        private async void btnSentMessages_Click(object sender, EventArgs e)
        {
            int rowHandle = gridView1.FocusedRowHandle;

            if (rowHandle >= 0)
            {
                btnSentMessages.Appearance.BackColor = Color.SteelBlue;
                btnReceivedMessages.Appearance.BackColor = Color.WhiteSmoke;
                btnAllMessages.Appearance.BackColor = Color.WhiteSmoke;
                ShowChatLoading(true);

                if (showDocRequests)
                {
                    var docReqId = int.Parse(GridViewHelper.GetGridViewCellValue(gridView1, "Id").ToString());
                    var docReqMessages = await manageDocReqsService
                        .GetDocRequestUserSentChatMessagesAsync(docReqId, userInfo.PersonCode);
                    SetChatMessages(docReqMessages, MessageTypes.Sent);
                }
                else
                {
                    var docConfirmationId = int.Parse(GridViewHelper.GetGridViewCellValue(gridView1, "Id").ToString());
                    var docConfirmation = docConfirmations.Where(x => x.Id == docConfirmationId).FirstOrDefault();
                    var docRequest = await manageDocReqsService.GetDocRequest(docConfirmation.DocReqId);

                    var docReqMessages = await manageDocReqsService
                        .GetDocRequestUserSentChatMessagesAsync(docRequest.Id, userInfo.PersonCode);

                    SetChatMessages(docReqMessages, MessageTypes.Sent);

                }
                ShowChatLoading(false);
            }


        }

        private async void btnReceivedMessages_Click_1(object sender, EventArgs e)
        {

            


        }
        private async Task GetAllMessagesAsync()
        {
            btnSentMessages.Appearance.BackColor = Color.WhiteSmoke;
            btnReceivedMessages.Appearance.BackColor = Color.WhiteSmoke;
            btnAllMessages.Appearance.BackColor = Color.SteelBlue;
            ShowChatLoading(true);

            if (showDocRequests)
            {
                var docReqId = int.Parse(GridViewHelper.GetGridViewCellValue(gridView1, "Id").ToString());
                var docReqMessages = await manageDocReqsService
                    .GetDocRequestAllChatMessagesAsync(docReqId);
                SetChatMessages(docReqMessages, MessageTypes.All);
            }
            else
            {
                var docConfirmationId = int.Parse(GridViewHelper.GetGridViewCellValue(gridView1, "Id").ToString());
                var docConfirmation = docConfirmations.Where(x => x.Id == docConfirmationId).FirstOrDefault();
                var docRequest = await manageDocReqsService.GetDocRequest(docConfirmation.DocReqId);

                var docReqMessages = await manageDocReqsService
                    .GetDocRequestAllChatMessagesAsync(docRequest.Id);
                SetChatMessages(docReqMessages, MessageTypes.All);

            }
            ShowChatLoading(false);
        }
        private void ShowChatLoading(bool isLoading)
        {
            pcChatLoading.Visible = isLoading;
            btnSendMessage.Enabled = !isLoading;

        }

        private async void btnSendMessage_Click(object sender, EventArgs e)
        {
            var frmMsgBox = new FrmMessageBox();

            if (Validators.ValidateControls<BaseEdit>(cmbReceiverUser, txtMessage))
            {
                var docReqId = 0;
                if (showDocRequests)
                {
                    docReqId = int.Parse(GridViewHelper.GetGridViewCellValue(gridView1, "Id").ToString());

                }
                else
                {
                    var docConfirmationId = int.Parse(GridViewHelper.GetGridViewCellValue(gridView1, "Id").ToString());
                    var docConfirmation = docConfirmations.Where(x => x.Id == docConfirmationId).FirstOrDefault();
                    docReqId = docConfirmation.DocReqId;
                }

                var newMessage = new DocRequestChatMessage
                {
                    DocRequestId = docReqId,
                    SenderUserPersonCode = userInfo.PersonCode,
                    SenderUserFullName = $"{userInfo.FirstName} {userInfo.LastName}",
                    SenderUserPost = userInfo.Posttxt,
                    ReceiverUserPersonCode = receiverUser.PersonCode,
                    ReceiverUserFullName = receiverUser.Name,
                    ReceiverUserPost = receiverUser.Post,
                    Message = txtMessage.Text,
                    CreatedBy = userInfo.PersonCode,
                    ModifiedBy = userInfo.PersonCode,
                };

                ShowChatLoading(true);
                await manageDocReqsService.SendMessageAsync(newMessage);
                ShowChatLoading(false);

                await GetAllMessagesAsync();

                var receiverUserInfo = await personelyService.GetUserInfoByPersonCode(receiverUser.PersonCode);
                var mobile = receiverUserInfo.Mobile;
                var text = $"{StringResources.NewDocReqMessageReceived1} {docReqId} {StringResources.NewDocReqMessageReceived2} \n {StringResources.IKID}";

                smsClient.SendSMS(mobile, text);

            }

        }

        private void cmbReceiverUser_EditValueChanged(object sender, EventArgs e)
        {
            receiverUser = receiverUsersList.Where(x => x.PersonCode.ToString() == cmbReceiverUser.EditValue.ToString()).FirstOrDefault();

        }

        private async void btnCancelSigning_Click(object sender, EventArgs e)
        {
            var frmMsgBox = new FrmMessageBox();

            frmMsgBox.SetMessageOptions(new CustomMessageBoxOptions()
            {
                Title = StringResources.EnterCancelSigningReason,
                ShowCancelButton = true,
                ShowConfirmButton = true,
                IsInputBox = true,
                ConfirmButtonText = StringResources.Confirm,
                CancelButtonText = StringResources.Cancel,
                DevExpressIconId = "cancel",
                DevExpressImageType = (int)DevExpress.Utils.Design.ImageType.Colored
            });
            var result = frmMsgBox.ShowDialog();
            if (result == DialogResult.OK)
            {

                ShowProgressBar(true);
                var newDocSigner = new NewDocSignerDto
                {
                    PersonCode = userInfo.PersonCode,
                    Name = $"{userInfo.FirstName} {userInfo.LastName}",
                    Post = userInfo.Posttxt,
                    SigningOrder = docSigners.Last().SigningOrder + 1,
                    IsSigned = false,
                    IsCanceled = true,
                    CancelReason = frmMsgBox.InputText,
                    SignRequestSentDate = DateTime.Now.ToPersianDateTime(),
                    CreatorUserPersonCode = userInfo.PersonCode
                };
                newDocSigner.Active = newDocSigner.SigningOrder == 0 ? true : false;


                if (showDocRequests)
                {
                    var docReqId = int.Parse(GridViewHelper.GetGridViewCellValue(gridView1, "Id").ToString());
                    var docConfirm = await docConfirmationService.GetDocConfirmationByDocReqIdAsync(docReqId);
                    newDocSigner.NewDocConfirmationId = docConfirm.Id;


                }
                else
                {
                    var docConfirmationId = int.Parse(GridViewHelper.GetGridViewCellValue(gridView1, "Id").ToString());
                    var docConfirmation = docConfirmations.Where(x => x.Id == docConfirmationId).FirstOrDefault();
                    newDocSigner.NewDocConfirmationId = docConfirmation.Id;

                }
                await docConfirmationService.AddNewDocSignersAsync(newDocSigner);

                //var isCanceled = docConfirmationService.CancelDocSigning(docConfirmId, frmMsgBox.InputText, userInfo.PersonCode);
                ShowProgressBar(false);
                toastNotificationsManager1.ShowNotification(toastNotificationsManager1.Notifications[3]);
                var newDocSignerResDto = new DocSignerResDto
                {
                    NewDocConfirmationId = newDocSigner.NewDocConfirmationId,
                    PersonCode = newDocSigner.PersonCode,
                    Name = newDocSigner.Name,
                    Post = newDocSigner.Post,
                    IsCanceled = true,
                    CancelReason = frmMsgBox.InputText,
                };
                docSigners.Add(newDocSignerResDto);
                UpdateDocSignersStepsTimeLine();
                btnCancelSigning.Enabled = false;
            }
            
        }
        private async Task Reload()
        {
            if (showDocRequests)
            {
                await GetDocRequests();

            }
            else
            {
                await LoadDocConfirmations();
            }
        }

        private async void btnReceivedMessages_Click(object sender, EventArgs e)
        {
            int rowHandle = gridView1.FocusedRowHandle;

            if (rowHandle >= 0)
            {
                btnSentMessages.Appearance.BackColor = Color.WhiteSmoke;
                btnReceivedMessages.Appearance.BackColor = Color.SteelBlue;
                btnAllMessages.Appearance.BackColor = Color.WhiteSmoke;
                ShowChatLoading(true);

                if (showDocRequests)
                {
                    var docReqId = int.Parse(GridViewHelper.GetGridViewCellValue(gridView1, "Id").ToString());
                    var docReqMessages = await manageDocReqsService
                        .GetDocRequestUserReceivedChatMessagesAsync(docReqId, userInfo.PersonCode);
                    SetChatMessages(docReqMessages, MessageTypes.Received);
                }
                else
                {
                    var docConfirmationId = int.Parse(GridViewHelper.GetGridViewCellValue(gridView1, "Id").ToString());
                    var docConfirmation = docConfirmations.Where(x => x.Id == docConfirmationId).FirstOrDefault();
                    var docRequest = await manageDocReqsService.GetDocRequest(docConfirmation.DocReqId);

                    var docReqMessages = await manageDocReqsService
                        .GetDocRequestUserReceivedChatMessagesAsync(docRequest.Id, userInfo.PersonCode);

                    SetChatMessages(docReqMessages, MessageTypes.Received);

                }
                ShowChatLoading(false);
            }
        }
    }

}
