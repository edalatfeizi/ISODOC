using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using IsoDoc.Domain.Entities;
using IsoDoc.Domain.Enums;
using IsoDoc.Domain.Interfaces.Services;
using IsoDoc.Domain.Models;
using IsoDocApp.Helpers;
using IsoDocApp.ManageDocRequests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
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
        private List<DocRequest> userDocReqs = new List<DocRequest>();
        private Person userInfo;
        private string userName = "";
        private bool isAdmin = false;
        private List<DocRequestStep> selectedDocReqSteps = new List<DocRequestStep>();
        public FrmManageDocReqs(IManageDocReqsService manageDocReqsService, IDocRequestAttachmentsService docRequestAttachmentsService, IPersonelyService personelyService)
        {
            this.manageDocReqsService = manageDocReqsService;
            this.personelyService = personelyService;
            this.docRequestAttachmentsService = docRequestAttachmentsService;
            InitializeComponent();

        }

        private async void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var frmNewDocReq = new FrmNewDocReq(manageDocReqsService, personelyService);
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
            userName = SystemInformation.UserName.ToString();
            //userName = "3015";

            userInfo = await personelyService.GetUserInfoByCardNumber(userName);
            // RibbonPage selectedPage = ribbonControl1.Pages[0];
            // ribbonControl1.SelectedPage = selectedPage;
            //if(userInfo != null)
            //GetUserDocRequests();

            if (userInfo != null && (userInfo.CardNumber == "3910" || userInfo.CodeEdare == "SI000" || userInfo.CodeEdare == "SI300" || userInfo.UpperCode == "SI300"))
            {
                tabAllDocRequests.Visible = true;
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

        }
        private async void FilterDocRequests(FilterDocRequests filter)
        {
            ShowProgressBar(true);


            userDocReqs = await manageDocReqsService.FilterDocRequests(filter);
            grdUserDocRequests.DataSource = userDocReqs;
            //gridView1.Columns("DocumentCode").BestFit()

            ShowProgressBar(false);
        }
        private void ShowProgressBar(bool isVisible)
        {
            progressBar.Visible = isVisible;
        }

        private async void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            int rowHandle = gridView1.FocusedRowHandle;
            if (rowHandle >= 0)
            {
                var idValue = gridView1.GetRowCellValue(rowHandle, "Id");
                var docId = idValue != null ? int.Parse(idValue.ToString()) : 0;
                var docRequest = userDocReqs.Where(x => x.Id == docId).FirstOrDefault();


                await GetDocReqSteps(docId, docRequest.DocRequestStatus, GetDocRequestStatusDsc(docRequest));
                var attachment = GridViewHelper.GetGridViewCellValue(gridView1, "HasAttachments");
                var hasAttachments = attachment != null ? attachment.ToString() : null;
                if (!string.IsNullOrEmpty(hasAttachments) && hasAttachments.ToString() == "دارد")
                    btnShowAttachments.Enabled = true;
                else
                    btnShowAttachments.Enabled = false;

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

            var steps = await DocRequestsHelper.GetDocRequestProgressBarSteps(selectedDocReqSteps, docRequestStatus, docReqStatusDsc);
            foreach (var step in steps)
            {
                docReqSteps.Items.Add(step);
            }

            ShowProgressBar(false);
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
                docReqSteps.Items.Clear();
                grdUserDocRequests.DataSource = null;
                // Check which page was clicked using the Name or Text property
                switch (selectedPage.Name)
                {
                    case "tabReceivedRequests":
                        if (userInfo != null)
                        {
                            // docReqSteps.Items.Clear();
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

                var frmForwardDocReq = new FrmForwardDocReq(manageDocReqsService, personelyService, docReqId, lastDocReqStepId, docRequest.DocRequestStatus, GetDocRequestStatusDsc(docRequest));
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
            var result = await manageDocReqsService.UpdateDocRequestStatus(docReqId, DocRequestStatus.Completed, "");
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
                var result = await manageDocReqsService.UpdateDocRequestStatus(docReqId, DocRequestStatus.Canceled, cancelReason);
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
                await manageDocReqsService.UpdateDocRequestStatus(docReqId, DocRequestStatus.Deleted, "");
                await manageDocReqsService.SetDocRequestActive(docReqId, deleteReason, false);
                btnReload.PerformClick();

            }
        }

        private async void mnuEnableReq_Click(object sender, EventArgs e)
        {
            var docReqId = int.Parse(GridViewHelper.GetGridViewCellValue(gridView1, "Id").ToString());


            ShowProgressBar(true);
            await manageDocReqsService.UpdateDocRequestStatus(docReqId, DocRequestStatus.InProgress, "");
            await manageDocReqsService.SetDocRequestActive(docReqId, "", true);
            btnReload.PerformClick();

        }

        private async void gridView1_MouseUp(object sender, MouseEventArgs e)
        {
            //GridView view = sender as GridView;

            // Get the row handle under the mouse pointer
            //int rowHandle = view.CalcHitInfo(e.Location).RowHandle;

            // Check if the row handle is valid (not the group row or empty space)
            if (userDocReqs.Count > 0)
            {
                RibbonPage selectedPage = ribbonControl1.SelectedPage;

                if (selectedPage.Name == "tabReceivedRequests" && e.Button == MouseButtons.Right)
                {
                    if (isAdmin)
                    {
                        var docReqId = int.Parse(GridViewHelper.GetGridViewCellValue(gridView1, "Id").ToString());
                        var docReq = await manageDocReqsService.GetDocRequest(docReqId);
                        var creatorUser = await personelyService.GetUserInfoByPersonCode(docReq.CreatedBy);

                        if (userInfo.DepartCode == creatorUser.DepartCode)
                        {
                            contextMenuStrip2.Show(grdUserDocRequests, e.Location);
                            mnuDeleteReq.Enabled = true;
                            mnuEnableReq.Enabled = false;

                        }

                    }
                    if (userInfo.CodeEdare == "SI300" || userInfo.UpperCode == "SI300") // if user is sys office emp
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
            }


        }

        private async void btnAddAttachment_Click(object sender, EventArgs e)
        {
            RibbonPage selectedPage = ribbonControl1.SelectedPage;
            if (selectedPage.Name == tabReceivedRequests.Name && userDocReqs.Count > 0)
            {
                var docReqId = int.Parse(GridViewHelper.GetGridViewCellValue(gridView1, "Id").ToString());
                var docReqAttachment = AttachmentsHelper.AttachFile();
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
    }
}
