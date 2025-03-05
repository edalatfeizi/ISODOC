using DevExpress.XtraEditors;
using IsoDoc.Domain.Entities;
using IsoDoc.Domain.Interfaces.Services;
using IsoDoc.Domain.Models;
using IsoDocApp.ManageDocRequests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        public  FrmManageDocReqs(IManageDocReqsService manageDocReqsService, IPersonelyService personelyService)
        {
            this.manageDocReqsService = manageDocReqsService;   
            this.personelyService = personelyService;
            InitializeComponent();

        }

        private async void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var frmNewDocReq = new FrmNewDocReq(manageDocReqsService,personelyService);  
            var result = frmNewDocReq.ShowDialog();

        
            if (result == DialogResult.OK)
            {
                GetUserDocRequests();

            }

          

        }

        private async void FrmManageDocReqs_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            var userName = SystemInformation.UserName.ToString();
            userInfo = await personelyService.GetUserInfo(userName);

            GetUserDocRequests();

         
        }
        private async void GetUserDocRequests(bool active = true)
        {
            ShowProgressBar(true);

            userDocReqs = await manageDocReqsService.GetAll(userInfo.PersonCode,active);
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
            }
        }

        private async void GetDocReqSteps(int docReqId)
        {
            ShowProgressBar(true);
            docReqSteps.Items.Clear();
            
            var docRequestSteps = await manageDocReqsService.GetDocRequestSteps(docReqId);
            foreach (var docReqStep in docRequestSteps)
            {
                // Create a new StepItem for each task
                StepProgressBarItem stepItem = new StepProgressBarItem();
                stepItem.ContentBlock2.Caption = $"{docReqStep.SenderUserFullName} - {docReqStep.SenderUserPost}";
                stepItem.ContentBlock2.Description = $"{docReqStep.Description}";
                stepItem.State = StepProgressBarItemState.Active;
                // Add the StepItem to the StepProgressBar
                docReqSteps.Items.Add(stepItem);
            }

            StepProgressBarItem lastStep = new StepProgressBarItem();
            lastStep.ContentBlock2.Caption = $"{docRequestSteps[docRequestSteps.Count -1].ReceiverUserFullName} - {docRequestSteps[docRequestSteps.Count - 1].ReceiverUserPost}";
            lastStep.State = StepProgressBarItemState.Inactive;

            docReqSteps.Items.Add(lastStep);

            ShowProgressBar(false);

        }
    }
}
