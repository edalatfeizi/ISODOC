using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using IsoDoc.Domain.Entities;
using IsoDoc.Domain.Enums;
using IsoDoc.Domain.Interfaces.Services;
using IsoDoc.Domain.Models;
using IsoDocApp.ManageDocRequests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IsoDocApp
{
    public partial class FrmManageDocReqs : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private readonly IManageDocReqsService manageDocReqsService;
        private readonly IPersonelyService personelyService;
        private List<DocRequest> userDocReqs = new List<DocRequest>();
        private Person userInfo;
        private string userName = "";
        private List<DocRequestStep> selectedDocReqSteps = new List<DocRequestStep>();
        public FrmManageDocReqs(IManageDocReqsService manageDocReqsService, IPersonelyService personelyService)
        {
            this.manageDocReqsService = manageDocReqsService;
            this.personelyService = personelyService;
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
            //userName = "1270";

            userInfo = await personelyService.GetUserInfo(userName);
            // RibbonPage selectedPage = ribbonControl1.Pages[0];
            // ribbonControl1.SelectedPage = selectedPage;
            //if(userInfo != null)
            //GetUserDocRequests();

            if (userInfo != null && (userInfo.CardNumber == "3910" || userInfo.DepartCode == "SI000" || userInfo.CodeEdare == "SI300" || userInfo.UpperCode == "SI300"))
            {
                tabAllDocRequests.Visible = true;
            }
            else
                tabAllDocRequests.Visible = false;

            FilterDocRequests(new FilterDocRequests { CreatorPersonCode = userInfo.PersonCode, Active = true });

        }
        private async void FilterDocRequests(FilterDocRequests filter)
        {
            ShowProgressBar(true);


            userDocReqs = await manageDocReqsService.FilterDocRequests(filter);
            grdUserDocRequests.DataSource = userDocReqs;

            ShowProgressBar(false);
        }
        private void ShowProgressBar(bool isVisible)
        {
            progressBar.Visible = isVisible;
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            int rowHandle = gridView1.FocusedRowHandle;
            if (rowHandle >= 0)
            {
                var idValue = gridView1.GetRowCellValue(rowHandle, "Id");
                var docId = idValue != null ? int.Parse(idValue.ToString()) : 0;
                GetDocReqSteps(docId);
                var attachment = GetGridViewCellValue("HasAttachments");
                var hasAttachments = attachment != null ? attachment.ToString() : null;
                if (!string.IsNullOrEmpty(hasAttachments) && hasAttachments.ToString() == "دارد")
                    btnDownloadAttachment.Enabled = true;
                else
                    btnDownloadAttachment.Enabled = false;

            }
        }

        private async void GetDocReqSteps(int docReqId)
        {
            ShowProgressBar(true);
            docReqSteps.Items.Clear();
            selectedDocReqSteps = await manageDocReqsService.GetDocRequestSteps(docReqId);

            var steps = await DocRequestsHelper.GetDocRequestProgressBarSteps(selectedDocReqSteps);
            foreach (var step in steps)
            {
                docReqSteps.Items.Add(step);
            }

            ShowProgressBar(false);

        }


        private async void DownloadAttachment()
        {
            var docReqId = int.Parse(GetGridViewCellValue("Id").ToString());
            var attachment = await manageDocReqsService.GetDocRequestAttachment(docReqId);

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.FileName = $"{attachment.Name}"; // File type filter
            saveFileDialog.Filter = "All Files (*.*)|*.*"; // File type filter
            saveFileDialog.Title = "ذخیره فایل پیوست"; // Dialog title
            saveFileDialog.DefaultExt = attachment.ContentType; // Default file extension
            saveFileDialog.AddExtension = true; // Automatically add the file extension

            // Show the dialog and check if the user clicked "OK"
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Get the selected file path
                string filePath = saveFileDialog.FileName;

                try
                {
                    // Save the byte array to the selected file path
                    File.WriteAllBytes(filePath, attachment.FileContent);

                    toastNotificationsManager1.ShowNotification(toastNotificationsManager1.Notifications[0]);

                }
                catch (Exception ex)
                {
                    var frmMsgBox = new FrmMessageBox();

                    frmMsgBox.SetMessageOptions(new CustomMessageBoxOptions()
                    {
                        Title = StringResources.ErrorProccessingData,
                        Message = $"{ex.Message} \n {ex.InnerException}",
                        ConfirmButtonText = StringResources.Confirm,
                        DevExpressIconId = "cancel",
                        DevExpressImageType = (int)DevExpress.Utils.Design.ImageType.Colored
                    });
                    frmMsgBox.ShowDialog();
                }
            }
        }

        private object GetGridViewCellValue(string columnName)
        {
            int rowHandle = gridView1.FocusedRowHandle;

            if (rowHandle >= 0)
            {
                var value = gridView1.GetRowCellValue(rowHandle, columnName);
                return value;
            }
            return null;
        }

        private void btnDownloadAttachment_Click(object sender, EventArgs e)
        {
            DownloadAttachment();

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
                // Check which page was clicked using the Name or Text property
                switch (selectedPage.Name)
                {
                    case "tabReceivedRequests":
                        if (userInfo != null)
                        {
                            // docReqSteps.Items.Clear();
                            FilterDocRequests(new FilterDocRequests { ReceiverPersonCode = userInfo.PersonCode, Active = true });
                            btnForwardDocReq.Enabled = true;
                        }

                        break;
                    case "tabSentRequests":
                        if (userInfo != null)
                        {
                            //docReqSteps.Items.Clear();
                            FilterDocRequests(new FilterDocRequests { CreatorPersonCode = userInfo.PersonCode, Active = true });
                            btnForwardDocReq.Enabled = false;

                        }

                        break;
                    case "tabForwardedDocRequests":
                        if (userInfo != null)
                        {
                            //docReqSteps.Items.Clear();
                            FilterDocRequests(new FilterDocRequests { SenderPersonCode = userInfo.PersonCode, Active = true });
                            btnForwardDocReq.Enabled = false;

                        }
                        break;

                    case "tabAllDocRequests":
                        if (userInfo != null && (userInfo.DepartCode == "SI000" || userInfo.CodeEdare == "SI300" || userInfo.UpperCode == "SI300"))
                        {
                            //docReqSteps.Items.Clear();
                            FilterDocRequests(new FilterDocRequests { Active = true });
                            btnForwardDocReq.Enabled = false;

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
            if (selectedPage.Name == "tabReceivedRequests" && userDocReqs.Count > 0)
            {
                var docReqId = int.Parse(GetGridViewCellValue("Id").ToString());
                var lastDocReqStepId = selectedDocReqSteps.Last().Id;

                var frmForwardDocReq = new FrmForwardDocReq(manageDocReqsService, personelyService, docReqId, lastDocReqStepId);
                var result = frmForwardDocReq.ShowDialog();


                if (result == DialogResult.OK)
                {
                    FilterDocRequests(new FilterDocRequests { ReceiverPersonCode = userInfo.PersonCode, Active = true });
                }
            }

        }

        private void gridView1_MouseDown(object sender, MouseEventArgs e)
        {
            //GridView view = sender as GridView;

            // Get the row handle under the mouse pointer
            //int rowHandle = view.CalcHitInfo(e.Location).RowHandle;

            // Check if the row handle is valid (not the group row or empty space)
            RibbonPage selectedPage = ribbonControl1.SelectedPage;
            var isAdmin = AdminTypes.GetAdminTypes().Any(x => x == ((AdminType)Convert.ToInt32(userInfo.PostTypeID)));
            if (userInfo.DepartCode == "SI000" || userInfo.CodeEdare == "SI300" || userInfo.UpperCode == "SI300") // if user is sys dep admin
            {
                if (selectedPage.Name == "tabReceivedRequests")
                {
                    if (e.Button == MouseButtons.Right)
                    {
                        // Show the ContextMenuStrip at the mouse position
                        ContextMenuStrip1.Show(grdUserDocRequests, e.Location);
                    }
                }
                //else if (e.Button == MouseButtons.Right && selectedPage.Name == "tabAllDocRequests" && SysOfficeAdmins.GetSysOfficeAdmins().Contains(Convert.ToInt32(userInfo.DepartID)))
                //{
                //    ContextMenuStrip1.Show(grdUserDocRequests, e.Location);

                //}
            }
          

        }

        private async void mnuSetDocReqCompleted_Click(object sender, EventArgs e)
        {
            var docReqId = int.Parse(GetGridViewCellValue("Id").ToString());
            ShowProgressBar(true);
            var result = await manageDocReqsService.UpdateDocRequestStatus(docReqId, DocRequestStatus.Completed, "");
            FilterDocRequests(new FilterDocRequests { Active = true });

        }

        private async void mnuSetDocReqCanceled_Click(object sender, EventArgs e)
        {
            var docReqId = int.Parse(GetGridViewCellValue("Id").ToString());
            string cancelReason = XtraInputBox.Show(StringResources.EnterCancelReason, StringResources.CancelReason, "");

            // Check if the user clicked OK and the input is not empty
            if (!string.IsNullOrEmpty(cancelReason))
            {
                ShowProgressBar(true);
                var result = await manageDocReqsService.UpdateDocRequestStatus(docReqId, DocRequestStatus.Canceled, cancelReason);
                FilterDocRequests(new FilterDocRequests { Active = true });
            }


        }
    }
}
