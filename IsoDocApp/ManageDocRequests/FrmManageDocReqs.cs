using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.TextEditController.Win32;
using DevExpress.XtraExport.Helpers;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraReports.UI;
using IKIDMagfaSMSClientWin;
using IsoDoc.Domain.Dtos;
using IsoDoc.Domain.Dtos.Req;
using IsoDoc.Domain.Dtos.Res;
using IsoDoc.Domain.Entities;
using IsoDoc.Domain.Enums;
using IsoDoc.Domain.Extensions;
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
using System.Security.Cryptography;
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
        private Person userInfo, sysOfficeBoss;
        private string userName = "";
        public string runAsUserPersonCode = null;
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
        private List<DocConfirmationStateChangeResDto> docConfirmCancelHistories = new List<DocConfirmationStateChangeResDto>();
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
            //userName = "3134";
            //userName = "3864";
            //userName = "3815";
            //userName = "3038";

            if (!string.IsNullOrEmpty(runAsUserPersonCode))
            {
                userName = runAsUserPersonCode;

            }

            cmbReceiverUser.Properties.DisplayMember = "Name";
            cmbReceiverUser.Properties.ValueMember = "PersonCode";

            tabReqChatRoom.PageEnabled = true;

            userPersonCode = await personelyService.GetUserPersonCodeByLoginName(userName);
            userInfo = await personelyService.GetUserInfoByPersonCode(userPersonCode);
            sysOfficeBoss = await personelyService.GetPersonByDepCode(Constants.SysOfficeCode);
            // RibbonPage selectedPage = ribbonControl1.Pages[0];
            // ribbonControl1.SelectedPage = selectedPage;
            //if(userInfo != null)
            //GetUserDocRequests();

            btnShowDocConfirmations.ImageOptions.LargeImage = Properties.Resources.signature;


            if (userInfo != null && (userInfo.CodeEdare == Constants.SysAdminCode || userInfo.CodeEdare == Constants.SysOfficeCode || userInfo.UpperCode == Constants.SysOfficeCode || userInfo.PersonCode.IsDeveloper()))
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
            if (userDocReqs != null && userDocReqs.Count > 0)
            {
                btnShowAttachments.Enabled = true;
                if (ribbonControl1.SelectedPage == tabReceivedRequests)
                {
                    btnForwardDocReq.Enabled = true;
                    btnAddAttachment.Enabled = true;
                }
                else
                {
                    btnForwardDocReq.Enabled = false;
                    btnAddAttachment.Enabled = false;
                }
            }

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

            cmbReceiverUser.Properties.DataSource = null;
            txtMessage.Text = "";
            //if (timeLineTabsContainer.SelectedTabPage == tabDocConfirmTimeLine)
            //{
            //    btnPrintConfirmationDoc.Enabled = false;
            //    btnConfirm.Enabled = false;
            //    confirmationSigners.Items.Clear();

            //}
            int rowHandle = gridView1.FocusedRowHandle;

            if (rowHandle >= 0)
            {
                var idValue = GridViewHelper.GetGridViewCellValue(gridView1, "Id");

                if (showDocRequests)
                {
                    var docId = idValue != null ? int.Parse(idValue.ToString()) : 0;
                    selectedDocReq = userDocReqs.Where(x => x.Id == docId).FirstOrDefault();

                    //SetTimeLineTabsTitle(selectedDocReq);

                    await GetDocReqSteps(selectedDocReq);
                    var attachment = GridViewHelper.GetGridViewCellValue(gridView1, "HasAttachments");
                    var hasAttachments = attachment != null ? attachment.ToString() : null;
                    if (!string.IsNullOrEmpty(hasAttachments) && hasAttachments.ToString() == "دارد")
                        btnShowAttachments.Enabled = true;
                    else
                        btnShowAttachments.Enabled = false;
                    docConfirmation = await docConfirmationService.GetDocConfirmationByDocReqIdAsync(docId);
                    if (docConfirmation != null)
                    
                        docConfirmCancelHistories = await docConfirmationService.GetDocConfirmationStateChangesAsync(docConfirmation.Id);
                

                    if (selectedDocReq.DocRequestStatus == DocRequestStatus.Completed && docConfirmation != null)
                    {

                        mnuConfirmDoc.Enabled = false;

                        await GetDocConfirmSigners(docConfirmation.Id, docId);
                    }
                    else
                    {
                        confirmationSigners.Items.Clear();
                        docSigners?.Clear();
                        //btnPrintConfirmationDoc.Enabled = false;
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
                    docConfirmation = docConfirmations.Where(x => x.Id == int.Parse(idValue.ToString())).FirstOrDefault();
                    docConfirmCancelHistories = await docConfirmationService.GetDocConfirmationStateChangesAsync(docConfirmation.Id);

                    selectedDocReq = await manageDocReqsService.GetDocRequest(docConfirmation.DocReqId);
                    var docReqHasAttachments = await manageDocReqsService.HasAttachmentsAsync(selectedDocReq.Id);
                    if (docReqHasAttachments)
                        btnShowAttachments.Enabled = true;

                    //SetTimeLineTabsTitle(docRequest);

                    await GetDocReqSteps(selectedDocReq);
                    await GetDocConfirmSigners(docConfirmation.Id, selectedDocReq.Id);

                    receiverUsersList = await GetDocRequestPeopleAsync(selectedDocReq.Id);
                    cmbReceiverUser.Properties.DataSource = receiverUsersList;

                    var docReqMessages = await manageDocReqsService.GetDocRequestAllChatMessagesAsync(selectedDocReq.Id);
                    SetChatMessages(docReqMessages, MessageTypes.All);
                }
            }



        }
        private void SetBottomBarControlEnabled(bool enabled)
        {
            btnShowAttachments.Enabled = enabled;
            btnAddAttachment.Enabled = enabled;
            btnForwardDocReq.Enabled = enabled;

            //btnAddAttachment.Enabled = enabled;
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
        private async Task<bool> GetDocReqSteps(DocRequest docRequest)
        {
            ShowProgressBar(true);
            docReqSteps.Items.Clear();
            var docSigningSteps = new List<ProcessStep>();
            var startStepTitle = "";
            var endStepTitle = "";

            switch (docRequest.DocRequestType)
            {
                case DocRequestType.Create:
                    startStepTitle = $"{StringResources.StartRequestProcess} {StringResources.CreateDoc}";
                    endStepTitle = $"{StringResources.EndRequestProcess} {StringResources.CreateDoc}";
                    break;
                case DocRequestType.Update:
                    startStepTitle = $"{StringResources.StartRequestProcess} {StringResources.UpdateDoc}";
                    endStepTitle = $"{StringResources.EndRequestProcess} {StringResources.UpdateDoc}";

                    break;
                case DocRequestType.Delete:
                    startStepTitle = $"{StringResources.StartRequestProcess} {StringResources.DeleteDoc}";
                    endStepTitle = $"{StringResources.EndRequestProcess} {StringResources.DeleteDoc}";

                    break;
            }
            var startStep = new ProcessStep
            {
                Title = startStepTitle,
                Description = $"{StringResources.DocTitle} : {docRequest.Title.Split(':')[1].Trim()} \n {StringResources.StartTime} : {docRequest.CreatedAt.FormatPersianDate()}",
                Status = ProcessStepStatus.Inactive,
            };
       
            selectedDocReqSteps = await manageDocReqsService.GetDocRequestSteps(docRequest.Id);
            var endStep = new ProcessStep
            {
                Title = endStepTitle,
                Description = docRequest.DocRequestStatus == DocRequestStatus.Completed ? $"{StringResources.EndTime} : {selectedDocReqSteps.Last().CreatedAt.FormatPersianDate()}" : "",
                Status = docRequest.DocRequestStatus == DocRequestStatus.Completed ? ProcessStepStatus.Completed : ProcessStepStatus.Inactive,
                CreatedAt = DateTime.Now.ToString(),
            };
            var docReqProcessSteps = new List<ProcessStep>();
            docReqProcessSteps.Add(startStep);
            docReqProcessSteps.AddRange(selectedDocReqSteps.MapToProcessSteps(docRequest));
            docReqProcessSteps.Add(endStep);



            var steps = await StepsProgressBarHelper.GetProcessSteps(docReqProcessSteps);
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
            if (docSigners.Count > 0)
            {

                UpdateDocSignersStepsTimeLine();
                var signer = docSigners.Where(x => x.PersonCode == userInfo.PersonCode && x.Active).FirstOrDefault();
                if (userInfo.CodeEdare == Constants.SysAdminCode || userInfo.CodeEdare == Constants.SysOfficeCode || userInfo.UpperCode == Constants.SysOfficeCode || userInfo.PersonCode.IsDeveloper())
                    btnPrintConfirmationDoc.Enabled = true;
                else if (signer != null && (signer.SignerType == StringResources.Confirmer || signer.SignerType == StringResources.Acceptor))
                    btnPrintConfirmationDoc.Enabled = true;
                else
                    btnPrintConfirmationDoc.Enabled = false;


                var userSignerIndex = docSigners.FindIndex(x => x.PersonCode == userInfo.PersonCode && !x.IsSigned && x.Active);

                var isLastSignerSigned = false;
                if (userSignerIndex == 0)
                    isLastSignerSigned = true;
                else if (userSignerIndex > 0 && ((docSigners[userSignerIndex - 1].IsSigned && docSigners[userSignerIndex - 1].Active) || !docSigners[userSignerIndex - 1].Active)) //check !docSigners[userSignerIndex - 1].Active incase if doc signing was canceled
                    isLastSignerSigned = true;

                if (ribbonControl1.SelectedPage == tabReceivedRequests && docSigners.Any(x => x.PersonCode == userInfo.PersonCode && !x.IsSigned && x.Active) && isLastSignerSigned)
                    btnConfirm.Enabled = true;
                else
                    btnConfirm.Enabled = false;
                if (docSigners.Any(x => x.PersonCode == userInfo.PersonCode))
                    btnConfirm.Visible = true;

                var lastSigner = docSigners.LastOrDefault();
                if (lastSigner != null && lastSigner.Active)
                {
                    if (userInfo.CodeEdare == Constants.SysAdminCode || userInfo.PersonCode.IsDeveloper())
                    {
                        btnCancelSigning.Visible = true;
                        btnCancelSigning.Enabled = true;
                    }
                    else
                    {
                        btnCancelSigning.Visible = false;
                        btnCancelSigning.Enabled = false;
                    }
                }
                else
                    btnCancelSigning.Visible = false;

                if (docConfirmation != null && docConfirmation.ConfirmationStatus == DocRequestStatus.Completed)
                    btnCancelSigning.Enabled = false;
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
            var docPeople = docReqPeople.Select(people => new DocRequestPeople { PersonCode = people.PersonCode, Name = people.Name, Post = people.Posttxt }).ToList();
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
            //docConfirmation = docConfirmations.Single(x=> x.Id == docConfirmId);

            //var sysStaff = new List<Person>();
            //sysStaff.Add(sysAdmin.First());
            //sysStaff.Add(sysOfficeBoss.First());
            if (docConfirmation != null)
            {
                confirmationSigners.Items.Clear();

                var docSigningSteps = new List<ProcessStep>();
                var starterPerson = await personelyService.GetUserInfoByPersonCode(docConfirmation.CreatedBy);
                if (starterPerson != null)
                {
                    var startStep = new ProcessStep
                    {
                        Title = StringResources.StartingDocSigningProcess,
                        Description = $"{StringResources.DocTitle} : {docConfirmation.DocTitle} \n {StringResources.Starter} :" +
                        $" {starterPerson.FirstName} {starterPerson.LastName} - {starterPerson.Posttxt} \n {StringResources.StartTime}" +
                        $" : {docConfirmation.CreatedAt.FormatPersianDate()}",
                        Status = ProcessStepStatus.Inactive,
                    };
                    var endStep = new ProcessStep
                    {
                        Title = StringResources.EndSigningDocProcess,
                        Description = docConfirmation.ConfirmationStatus == DocRequestStatus.Completed ? $"{StringResources.EndTime} : {docConfirmation.ModifiedAt}" : "",
                        Status = docConfirmation.ConfirmationStatus == DocRequestStatus.Completed ? ProcessStepStatus.Completed : ProcessStepStatus.Inactive,
                        CreatedAt = DateTime.Now.ToPersianDateTime()
                    };

                    docSigningSteps.AddRange(docSigners.MapToProcessSteps());
                    docSigningSteps.AddRange(docConfirmCancelHistories.MapToProcessSteps());

                    var newSteps = new List<ProcessStep>();
                    newSteps.Add(startStep);
                    newSteps.AddRange(docSigningSteps.OrderBy(x => x.CreatedAt.ToPersianDateTime()));
                    newSteps.Add(endStep);

                    var steps = await StepsProgressBarHelper.GetProcessSteps(newSteps);
                    foreach (var step in steps)
                    {
                        confirmationSigners.Items.Add(step);
                    }

                }

            }

        }
        private async void btnDownloadAttachment_Click(object sender, EventArgs e)
        {
            //RibbonPage selectedPage = ribbonControl1.SelectedPage;
            if (showDocRequests)
            {

                var frmManageAttachments = new FrmManageAttachments(docRequestAttachmentsService, selectedDocReq.Id);
                frmManageAttachments.ShowDialog();


                //if (result == DialogResult.OK)
                //{
                //   await FilterDocRequests(new FilterDocRequests { ReceiverPersonCode = userInfo.PersonCode, DocRequestStatus = DocRequestStatus.InProgress, Active = true });
                //}
            }
            else if (docConfirmations != null && docConfirmations.Count > 0)
            {
                var frmManageAttachments = new FrmManageAttachments(docRequestAttachmentsService, docConfirmation.DocReqId);
                frmManageAttachments.ShowDialog();

            }


        }

        private async void ribbonControl1_SelectedPageChanged(object sender, EventArgs e)
        {
            await GetDocRequests();
        }
        private async Task GetDocRequests()
        {
            //SetBottomBarControlEnabled(false);
            RibbonPage selectedPage = ribbonControl1.SelectedPage;
            if (selectedPage != null)
            {
                //docReqSteps.Items.Clear();
                confirmationSigners.Items.Clear();
                docReqSteps.Items.Clear();
                userDocReqs.Clear();
                grdUserDocRequests.DataSource = null;

                btnConfirm.Visible = false;
                btnCancelSigning.Visible = false;

                SetBottomBarControlEnabled(false);
                btnPrintConfirmationDoc.Enabled = false;
                // Check which page was clicked using the Name or Text property
                switch (selectedPage.Name)
                {
                    case "tabReceivedRequests":
                        if (userInfo != null)
                        {
                            await FilterDocRequests(new FilterDocRequests { ReceiverPersonCode = userInfo.PersonCode, DocRequestStatus = DocRequestStatus.InProgress, Active = true });

                            


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
                        //SetBottomBarControlEnabled(false);
                        //btnShowAttachments.Enabled = true;

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
                        //SetBottomBarControlEnabled(false);
                        //btnShowAttachments.Enabled = true;

                        break;

                    case "tabAllDocRequests":
                        if (userInfo != null && (userInfo.DepartCode == Constants.SysAdminCode || userInfo.CodeEdare == Constants.SysOfficeCode || userInfo.UpperCode == Constants.SysOfficeCode || userInfo.PersonCode.IsDeveloper()))
                        {
                            //docReqSteps.Items.Clear();
                            await FilterDocRequests(new FilterDocRequests { });
                            //btnForwardDocReq.Enabled = false;
                            //btnAddAttachment.Enabled = false;

                        }
                        //ToggleConfirmationButtonsState(false);
                        //SetBottomBarControlEnabled(false);
                        //btnShowAttachments.Enabled = true;

                        break;
                    case "tabDeletedRequests":
                        if (userInfo != null && (userInfo.DepartCode == Constants.SysAdminCode || userInfo.CodeEdare == Constants.SysOfficeCode || userInfo.UpperCode == Constants.SysOfficeCode || isAdmin || userInfo.PersonCode.IsDeveloper()))
                        {

                            //docReqSteps.Items.Clear();
                            await FilterDocRequests(new FilterDocRequests { ReceiverPersonCode = userInfo.PersonCode, Active = false });
                        }
                        //ToggleConfirmationButtonsState(false);
                        //SetBottomBarControlEnabled(false);
                        //btnShowAttachments.Enabled = true;
                        break;
                }
            }
        }

        private async void btnForwardDocReq_Click(object sender, EventArgs e)
        {
            await ForwardDocRequest();
        }
        //private void ToggleConfirmationButtonsState(bool state)
        //{
        //    btnConfirm.Enabled = state;
        //    btnPrintConfirmationDoc.Enabled = state;
        //}
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
                //var docReqId = int.Parse(GridViewHelper.GetGridViewCellValue(gridView1, "Id").ToString());
                var lastDocReqStepId = selectedDocReqSteps.Last().Id;
                //var docRequest = userDocReqs.Where(x => x.Id == docReqId).FirstOrDefault();

                var frmForwardDocReq = new FrmForwardDocReq(manageDocReqsService, personelyService, selectedDocReq.Id, lastDocReqStepId, selectedDocReq.DocRequestStatus, GetDocRequestStatusDsc(selectedDocReq), smsClient);
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
            //var docReqId = int.Parse(GridViewHelper.GetGridViewCellValue(gridView1, "Id").ToString());
            ShowProgressBar(true);
            var result = await manageDocReqsService.UpdateDocRequestStatus(selectedDocReq.Id, DocRequestStatus.Completed, "", userInfo.PersonCode);
            await Reload();
        }

        private async void mnuCancelReq_Click(object sender, EventArgs e)
        {

            var frmMsgBox = new FrmMessageBox();

            frmMsgBox.SetMessageOptions(new CustomMessageBoxOptions()
            {
                Title = StringResources.EnterCancelReason,
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
                await manageDocReqsService.UpdateDocRequestStatus(selectedDocReq.Id, DocRequestStatus.Canceled, frmMsgBox.InputText, userInfo.PersonCode);
                await Reload();
            }

        }

        private async void mnuDeleteReq_Click(object sender, EventArgs e)
        {
            //var docReqId = int.Parse(GridViewHelper.GetGridViewCellValue(gridView1, "Id").ToString());
            //string deleteReason = XtraInputBox.Show(StringResources.EnterDeleteReason, StringResources.DeleteRequest, "");

            var frmMsgBox = new FrmMessageBox();

            frmMsgBox.SetMessageOptions(new CustomMessageBoxOptions()
            {
                Title = StringResources.EnterDeleteReason,
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
                await manageDocReqsService.UpdateDocRequestStatus(selectedDocReq.Id, DocRequestStatus.Deleted, "", userInfo.PersonCode);
                await manageDocReqsService.SetDocRequestActive(selectedDocReq.Id, frmMsgBox.InputText, false);
                await Reload();
            }
        }

        private async void mnuEnableReq_Click(object sender, EventArgs e)
        {
            //var docReqId = int.Parse(GridViewHelper.GetGridViewCellValue(gridView1, "Id").ToString());


            ShowProgressBar(true);
            await manageDocReqsService.UpdateDocRequestStatus(selectedDocReq.Id, DocRequestStatus.InProgress, "", userInfo.PersonCode);
            await manageDocReqsService.SetDocRequestActive(selectedDocReq.Id, "", true);
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
                    if (userInfo.CodeEdare == Constants.SysOfficeCode || userInfo.UpperCode == Constants.SysOfficeCode || userInfo.PersonCode.IsDeveloper()) // if user is sys office emp or developer
                    {

                        // Show the ContextMenuStrip at the mouse position
                        contextMenuStrip2.Show(grdUserDocRequests, e.Location);
                        mnuCancelReq.Enabled = true;
                        //else if (e.Button == MouseButtons.Right && selectedPage.Name == "tabAllDocRequests" && SysOfficeAdmins.GetSysOfficeAdmins().Contains(Convert.ToInt32(userInfo.DepartID)))
                        //{
                        //    ContextMenuStrip1.Show(grdUserDocRequests, e.Location);

                        //}
                    }
                    else if (userInfo.CodeEdare == Constants.SysAdminCode || userInfo.PersonCode.IsDeveloper()) //if user is sys dep admin
                    {

                        // Show the ContextMenuStrip at the mouse position
                        contextMenuStrip2.Show(grdUserDocRequests, e.Location);
                        if (selectedPage.Name == tabReceivedRequests.Name)
                            mnuCompleteReq.Enabled = true;

                    }

                    if (docConfirmation != null && docConfirmation.ConfirmationStatus == DocRequestStatus.Canceled && (userInfo.CodeEdare == Constants.SysOfficeCode))
                    {
                        mnuConfirmDoc.Enabled = true;

                    }
                }

                if (isAdmin && selectedPage.Name == tabDeletedRequests.Name && e.Button == MouseButtons.Right)
                {
                    contextMenuStrip2.Show(grdUserDocRequests, e.Location);
                    mnuDeleteReq.Enabled = false;
                    mnuEnableReq.Enabled = true;
                }

                if (selectedPage.Name == tabAllDocRequests.Name && e.Button == MouseButtons.Right && userInfo != null && (userInfo.CodeEdare == Constants.SysAdminCode || userInfo.CodeEdare == Constants.SysOfficeCode || userInfo.UpperCode == Constants.SysOfficeCode || userInfo.PersonCode.IsDeveloper()))
                {
                    contextMenuStrip2.Show(grdUserDocRequests, e.Location);
                    if (selectedDocReq.DocRequestStatus == DocRequestStatus.Completed)
                    {
                        //var idValue = GridViewHelper.GetGridViewCellValue(gridView1,"Id");

                        //var docId = idValue != null ? int.Parse(idValue.ToString()) : 0;
                        //docConfirmation = await docConfirmationService.GetDocConfirmationByDocReqIdAsync(docId);
                        if (docConfirmation == null)
                            mnuConfirmDoc.Enabled = true;

                        else if (docConfirmation.ConfirmationStatus == DocRequestStatus.Canceled && (userInfo.CodeEdare == Constants.SysOfficeCode))
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
            var docReqId = showDocRequests ? selectedDocReq.Id : docConfirmation.DocReqId;
            //if (showDocRequests)
            //{
            //    if (selectedPage.Name == tabReceivedRequests.Name && userDocReqs.Count > 0)
            //    {
            //         docReqId = int.Parse(GridViewHelper.GetGridViewCellValue(gridView1, "Id").ToString());

            //    }

            //}
            //else
            //{
            //    var idValue = GridViewHelper.GetGridViewCellValue(gridView1,"Id");
            //    docConfirmation = docConfirmations.Where(x => x.Id == int.Parse(idValue.ToString())).FirstOrDefault();
            //    docReqId = docConfirmation.DocReqId;
            //}
            var docReqAttachments = AttachmentsHelper.AttachFiles(Constants.DocReqAttachmentFileTypes, false).MapToDocRequestAttachments(docReqId);
            ShowProgressBar(true);

            foreach (var attachment in docReqAttachments)
            {
                attachment.DocRequestId = docReqId;
                attachment.CreatedBy = userInfo.PersonCode;
                attachment.ModifiedBy = userInfo.PersonCode;
                await manageDocReqsService.AttachFileAsync(attachment);
                toastNotificationsManager1.ShowNotification(toastNotificationsManager1.Notifications[0]);
            }
            ShowProgressBar(false);

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
            //var docReqId = int.Parse(GridViewHelper.GetGridViewCellValue(gridView1, "Id").ToString());

            //docConfirmation = await docConfirmationService.GetDocConfirmationByDocReqIdAsync(docReqId);
            var lastDocConfirmId = docConfirmation != null ? docConfirmation.Id : 0;
            var frmNewDocReq = new FrmConfirmNewDoc(personelyService, manageDocReqsService, docConfirmationService, smsClient, selectedDocReq.Id, lastDocConfirmId);
            var result = frmNewDocReq.ShowDialog();
            if (result == DialogResult.OK)
            {
                if (showDocRequests)
                {
                    docConfirmation = await docConfirmationService.GetDocConfirmationByDocReqIdAsync(selectedDocReq.Id);
                    docSigners = await docConfirmationService.GetDocConfirmationSignersAsync(docConfirmation.Id);

                }
                else
                    docSigners = await docConfirmationService.GetDocConfirmationSignersAsync(lastDocConfirmId);

                UpdateDocSignersStepsTimeLine();
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

            if (userInfo.CodeEdare == Constants.SysOfficeCode || userInfo.UpperCode == Constants.SysOfficeCode)
            {
                docConfirmations = await docConfirmationService.GetUserDocConfirmationsAsync(userPersonCode, true);
                btnAddAttachment.Enabled = true;
            }
            else
                docConfirmations = await docConfirmationService.GetUserDocConfirmationsAsync(userPersonCode, false);

            if (docConfirmations != null && docConfirmations.Count > 0)
            {
                btnShowAttachments.Enabled = true;
                //if(ribbonControl1.SelectedPage == tabReceivedRequests)
                //{
                //    if(userInfo.CodeEdare == Constants.SysOfficeCode || user)
                //}
                //SetBottomBarControlEnabled(true);
                btnForwardDocReq.Enabled = false;
                btnAddAttachment.Enabled = false;
            }

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
                //btnPrintConfirmationDoc.Enabled = false;
                await FilterDocRequests(new FilterDocRequests { ReceiverPersonCode = userInfo.PersonCode, DocRequestStatus = DocRequestStatus.InProgress, Active = true });


                //btnForwardDocReq.Enabled = true;
                //btnAddAttachment.Enabled = true;


                //btnForwardDocReq.Enabled = true;
                //btnAddAttachment.Enabled = true;
            }

        }

        private void timeLineTabsContainer_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
        {

            // if (timeLineTabsContainer.SelectedTabPage == tabDocConfirmTimeLine && (docSigners != null && docSigners.Count == 0))
            // {
            //confirmationSigners.Items.Clear();
            // btnPrintConfirmationDoc.Enabled = false;
            //if (ribbonControl1.SelectedPage == tabReceivedRequests)
            //    btnConfirm.Enabled = true;
            //else
            //    btnConfirm.Enabled = false;
            //}
            // else
            // btnPrintConfirmationDoc.Enabled = true;

        }

        private async void btnConfirm_Click(object sender, EventArgs e)
        {
            ShowProgressBar(true);

            //var docConfirmId = int.Parse(GridViewHelper.GetGridViewCellValue(gridView1, "Id").ToString());

            //docConfirmation = docConfirmations.Where(x => x.Id == docConfirmId).FirstOrDefault();

            var docSigner = docSigners.Where(x => x.PersonCode == userInfo.PersonCode && !x.IsSigned && x.Active).First();

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
                    //nextDocSigner.Active = true;

                    await docConfirmationService.UpdateSendSignRequestDate(nextDocSigner.Id, nextDocSigner.PersonCode);

                    var nextSignerUserInfo = await personelyService.GetUserInfoByPersonCode(nextDocSigner.PersonCode);
                    var mobile = nextSignerUserInfo.Mobile;
                    var text = $"{StringResources.NewSignDocReqSent} \n {StringResources.IKID}";

                    //smsClient.SendSMS(mobile, text);
                }
                else
                    await docConfirmationService.UpdateDocConfirmStatusAsync(docConfirmation.Id, DocRequestStatus.Completed, userInfo.PersonCode);
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
            if (docConfirmation != null && (docConfirmation.ConfirmationStatus == DocRequestStatus.InProgress || docConfirmation.ConfirmationStatus == DocRequestStatus.Completed))
            {
                ShowProgressBar(true);
                btnPrintConfirmationDoc.Enabled = false;
                string confirmDate = null;
                //var newSigners = new List<DocSignerResDto>();
                //if (docConfirmation.ConfirmationStatus == DocRequestStatus.InProgress || docConfirmation.ConfirmationStatus == DocRequestStatus.Completed)
                //{
                //    var canceledSigner = docSigners.Where(x => x.IsCanceled).First();

                //    var isCanceledIndex = docSigners.IndexOf(canceledSigner);
                //    newSigners = docSigners.Skip(isCanceledIndex + 1).ToList();
                //}
                //else
                //    newSigners = docSigners;

                var signers = docSigners.Where(x => x.Active).ToList();
                foreach (var signer in signers)
                {
                    signer.SignRequestSentDate =  !string.IsNullOrEmpty(signer.SignRequestSentDate) ? signer.SignRequestSentDate.FormatPersianDate() : "";
                    signer.SigningDate = !string.IsNullOrEmpty(signer.SigningDate)  ? signer.SigningDate.FormatPersianDate() : "";
                    if (signer.IsSigned)
                    {
                       
                        var signerSignature = await personelyService.GetPersonSignature(signer.PersonCode);
                        if(signerSignature != null && signerSignature.FileContent != null)
                            signer.Signature = signerSignature.FileContent;
                    }


                }
                var lastSigner = signers.LastOrDefault();
                if (lastSigner != null && lastSigner.IsSigned)
                    confirmDate = lastSigner.SigningDate.FormatPersianDate();

                //var docConfirmId = int.Parse(GridViewHelper.GetGridViewCellValue(gridView1, "Id").ToString());

                //docConfirmation = docConfirmations.Where(x => x.Id == docConfirmId).FirstOrDefault();

                XtraReport report = new RptNewDocConfirmation();

                // Create data source
                //var reportData = new NewDocConfirmationReport(docConfirmation, docSigners);
                var newDocConfirmationReport = new NewDocConfirmationReport(docConfirmation, signers)
                {
                    UserName = $"{userInfo.FirstName} {userInfo.LastName} - {userInfo.Posttxt}",
                    PersonCode = userInfo.PersonCode,
                    Environment = Environment.MachineName,
                    IpAddress = Utils.GetIpAddress(),
                    FormName = "SI-FO-01",
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

                var docReqId = showDocRequests ? selectedDocReq.Id : docConfirmation.DocReqId;
                var docReqMessages = await manageDocReqsService.GetDocRequestUserSentChatMessagesAsync(docReqId, userInfo.PersonCode);

                SetChatMessages(docReqMessages, MessageTypes.Sent);

                ShowChatLoading(false);
            }


        }

        private async Task GetAllMessagesAsync()
        {
            btnSentMessages.Appearance.BackColor = Color.WhiteSmoke;
            btnReceivedMessages.Appearance.BackColor = Color.WhiteSmoke;
            btnAllMessages.Appearance.BackColor = Color.SteelBlue;

            ShowChatLoading(true);

            var docReqId = showDocRequests ? selectedDocReq.Id : docConfirmation.DocReqId;
            var docReqMessages = await manageDocReqsService.GetDocRequestAllChatMessagesAsync(selectedDocReq.Id);

            SetChatMessages(docReqMessages, MessageTypes.All);
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
                var docReqId = showDocRequests ? selectedDocReq.Id : docConfirmation.DocReqId;
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

                //var receiverUserInfo = await personelyService.GetUserInfoByPersonCode(receiverUser.PersonCode);
                //var mobile = receiverUserInfo.Mobile;
                //var text = $"{StringResources.NewDocReqMessageReceived1} {docReqId} {StringResources.NewDocReqMessageReceived2} \n {StringResources.IKID}";

                //smsClient.SendSMS(mobile, text);

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
                btnCancelSigning.Enabled = false;
                ShowProgressBar(true);
                var newDocConfirmCancel = new DocConfirmationStateChangeReqDto
                {
                    DocConfirmationId = docConfirmation.Id,
                    SenderUserPersonCode = userInfo.PersonCode,
                    SenderUserFullName = $"{userInfo.FirstName} {userInfo.LastName}",
                    SenderUserPost = userInfo.Posttxt,
                    ReceiverUserPersonCode = sysOfficeBoss.PersonCode,
                    ReceiverUserFullName = $"{sysOfficeBoss.FirstName} {sysOfficeBoss.LastName}",
                    ReceiverUserPost = sysOfficeBoss.Posttxt,
                    Description = frmMsgBox.InputText,
                    CreatedBy = userInfo.PersonCode,
                    ModifiedBy = userInfo.PersonCode,
                    Status = DocConfirmationStatus.Canceled
                };

                var isCanceled = await docConfirmationService.UpdateDocConfirmStatusAsync(docConfirmation.Id, DocRequestStatus.Canceled, userInfo.PersonCode);
                if (isCanceled)
                {
                    await docConfirmationService.CancelSigningAsync(docConfirmation.Id, userInfo.PersonCode);
                    var res = await docConfirmationService.AddDocConfirmationStateChangeAsync(newDocConfirmCancel);
                    docConfirmCancelHistories.Add(res);

                    //var newDocSignerResDto = new DocSignerResDto
                    //{
                    //    NewDocConfirmationId = docConfirmation.Id,
                    //    PersonCode = userInfo.PersonCode,
                    //    Name = $"{StringResources.From}: {res.SenderUserFullName} - {res.SenderUserPost} \n {StringResources.To}: {res.ReceiverUserFullName} - {res.ReceiverUserPost}",
                    //    Post = res.Description,
                    //    IsDocConfirmStateChanged = true,
                    //    CreatedAt = res.CreatedAt,
                    //};
                    //docSigners.Add(newDocSignerResDto);

                    UpdateDocSignersStepsTimeLine();
                    toastNotificationsManager1.ShowNotification(toastNotificationsManager1.Notifications[3]);
                    if (!showDocRequests) // if showing doc confirmations then reload with new state
                    {
                        docConfirmations.Where(x => x.Id == docConfirmation.Id).First().ConfirmationStatus = DocRequestStatus.Canceled;
                        gridView1.RefreshData();
                    }
                    //send signing canceled sms
                    var sysOfficeBoss = await personelyService.GetPersonByDepCode(Constants.SysOfficeCode);
                    var mobile = sysOfficeBoss.Mobile;
                    var text = $"{StringResources.DocReqSigningCanceled1}: {selectedDocReq.Id} {StringResources.DocReqSigningCanceled2} \n {StringResources.IKID}";
                    smsClient.SendSMS(mobile, text);

                }
                else
                {
                    toastNotificationsManager1.ShowNotification(toastNotificationsManager1.Notifications[4]);
                    btnCancelSigning.Enabled = true;
                }

                ShowProgressBar(false);


            }

        }

        private void timeLineTabsContainer_Click(object sender, EventArgs e)
        {

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

                var docReqId = showDocRequests ? selectedDocReq.Id : docConfirmation.DocReqId;
                var docReqMessages = await manageDocReqsService.GetDocRequestUserReceivedChatMessagesAsync(docReqId, userInfo.PersonCode);

                SetChatMessages(docReqMessages, MessageTypes.Received);
                ShowChatLoading(false);
            }
        }
    }

}
