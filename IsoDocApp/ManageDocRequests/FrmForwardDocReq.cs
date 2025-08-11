using DevExpress.XtraEditors;
using IKIDMagfaSMSClientWin;
using IsoDoc.Domain.Entities;
using IsoDoc.Domain.Enums;
using IsoDoc.Domain.Interfaces.Repositories;
using IsoDoc.Domain.Interfaces.Services;
using IsoDoc.Domain.Models;
using IsoDocApp.Enums;
using IsoDocApp.Extensions;
using IsoDocApp.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IsoDocApp.ManageDocRequests
{
    public partial class FrmForwardDocReq : DevExpress.XtraEditors.XtraForm
    {
        private readonly IManageDocReqsService manageDocReqsService;
        private readonly IPersonelyService personelyService;
        private int docReqId = 0;
        private int lastDocReqStepId = 0;
        private List<Colleague> userColleagues;
        private Person userInfo;
        private Person receiverUserInfo;
        private List<DocRequestStep> selectedDocReqSteps = new List<DocRequestStep>();
        private bool isAdmin = false;
        private DocRequestStatus requestStatus;
        private string docReqStatusDsc = "";
        private EditOrReviewStatus editOrReviewStatus = EditOrReviewStatus.None;
        private int editOrReviewNo = 0;
        private MagfaSMSClient smsClient;
        public FrmForwardDocReq(IManageDocReqsService manageDocReqsService, IPersonelyService personelyService,/* IDocRequestStepsService docRequestStepsService,*/ int docReqId, int lastDocReqStepId, DocRequestStatus docRequestStatus, string docReqStatusDsc, MagfaSMSClient magfaSMSClient)
        {
            this.manageDocReqsService = manageDocReqsService;
            this.personelyService = personelyService;
            this.requestStatus = docRequestStatus;
            this.docReqStatusDsc = docReqStatusDsc;
            this.docReqId = docReqId;
            this.lastDocReqStepId = lastDocReqStepId;
            this.smsClient = magfaSMSClient;
            InitializeComponent();
        }

        private void ShowProgressBar(bool isVisible)
        {
            progressBar.Visible = isVisible;
        }

        private async Task GetDocReqSteps(int docReqId)
        {
            ShowProgressBar(true);
            docReqSteps.Items.Clear();
            selectedDocReqSteps = await manageDocReqsService.GetDocRequestSteps(docReqId);

            var steps = await StepsProgressBarHelper.GetDocRequestProgressBarSteps(selectedDocReqSteps, requestStatus, docReqStatusDsc);
            foreach (var step in steps)
            {
                docReqSteps.Items.Add(step);
            }

            ShowProgressBar(false);

        }

        private async void FrmForwardDocReq_Load(object sender, System.EventArgs e)
        {
            SetupControls();
            txtDocReqId.Text = docReqId.ToString();

            var userName = SystemInformation.UserName;
            
            var userPersonCode = "";
            userPersonCode = await personelyService.GetUserPersonCodeByLoginName(userName);
            userInfo = await personelyService.GetUserInfoByPersonCode(userPersonCode);

            userColleagues = await personelyService.GetUserColleagues(userInfo.CodeEdare, userInfo.UpperCode);

            // if user is a boss and his/her dep has no admin, PostTypeID 50 and 4 is reserved for an office boss and supervisor
            if (string.Equals(userInfo.PostTypeID, PostTypes.OfficeSupervisor.ToString(), StringComparison.OrdinalIgnoreCase) 
                || string.Equals(userInfo.PostTypeID, PostTypes.Boss.ToString(), StringComparison.OrdinalIgnoreCase)
                && !userColleagues.Any(x => x.CodeEdare == userInfo.UpperCode))
            {
                var admins = await personelyService.GetUserColleagues(null, null, false, true);
                userColleagues.AddRange(admins);
            }
            if (userColleagues.Count == 0) // incase if user has no direct colleagues like boss or he/she has no employees  
                userColleagues = await personelyService.GetUserColleagues("", userInfo.DepartCode);

            var isAdmin = UserHelper.CheckIsAdmin(userInfo.PostTypeID);
            if (userInfo.CodeEdare == Constants.SysAdminCode || userInfo.CodeEdare == Constants.SysOfficeCode || userInfo.UpperCode == Constants.SysOfficeCode || userInfo.PersonCode.IsDeveloper()) // if user is sys dep admin
            {
                grpEditOrReview.Enabled = true;

                var admins = await personelyService.GetUserColleagues(null, null, true);
                userColleagues.AddRange(admins);
                var unSupervisedBosses = await personelyService.GetUnSupervisedBosses();

                userColleagues.AddRange(unSupervisedBosses);
            }
            else if (isAdmin)
            {
                userColleagues = await personelyService.GetUserColleagues(userInfo.CodeEdare);

                var admins = await personelyService.GetUserColleagues(null, null, false, true);
                userColleagues.AddRange(admins);
            }

            //remove user itself from admins list
            userColleagues = userColleagues.Where(x => x.CardNumber.ToString() != userName).ToList();

            cmbUserColleagues.Properties.DataSource = userColleagues.GroupBy(c => c.PersonCode)
            .Select(g => g.First())
            .ToList();

            await GetDocReqSteps(docReqId);


        }

        private void SetupControls()
        {

            cmbUserColleagues.Properties.DisplayMember = "Name";
            cmbUserColleagues.Properties.ValueMember = "PersonCode";

        }

        private async void btnSave_Click(object sender, System.EventArgs e)
        {

            try
            {
                if (Validators.ValidateControls<BaseEdit>(cmbUserColleagues, txtDocReqStepDesc))
                {
                    ShowProgressBar(true);
                    btnSave.Enabled = false;
                    var newStep = new DocRequestStep
                    {
                        DocRequestId = docReqId,
                        SenderUserPersonCode = userInfo.PersonCode,
                        SenderUserFullName = $"{userInfo.FirstName} {userInfo.LastName}",
                        SenderUserPost = userInfo.Posttxt,

                        ReceiverUserPersonCode = receiverUserInfo.PersonCode,
                        ReceiverUserFullName = $"{receiverUserInfo.FirstName} {receiverUserInfo.LastName}",
                        ReceiverUserPost = receiverUserInfo.Posttxt,

                        Description = txtDocReqStepDesc.Text,

                        CreatedBy = userInfo.PersonCode,
                        ModifiedBy = userInfo.PersonCode
                    };
                    var editReviewNo = 0;

                    if (editOrReviewStatus != EditOrReviewStatus.None)
                    {
                        if(!string.IsNullOrEmpty(txtEditOrReviewNo.Text))
                            int.TryParse(txtEditOrReviewNo.Text, out editReviewNo);

                        if (editReviewNo >= 0)
                        {
                            var isUpdated = await manageDocReqsService.UpdateDocRequestEditOrReviewStatus(docReqId, editOrReviewStatus, Convert.ToInt32(editReviewNo));
                            if (isUpdated)
                            {
                                switch (editOrReviewStatus)
                                {
                                    case EditOrReviewStatus.DoWithEdit:
                                        newStep.Description += $"\n {StringResources.DoWithEdit} \n {StringResources.EditNo} ";
                                        break;
                                    case EditOrReviewStatus.DoWithReview:
                                        newStep.Description += $"\n {StringResources.DoWithReview} \n {StringResources.ReviewNo} ";
                                        break;
                                }
                                await AddNewDocRequestStep(newStep, editReviewNo);

                            }
                        }
                        else
                        {

                            var frmMsgBox = new FrmMessageBox();
                            var message = editOrReviewStatus == EditOrReviewStatus.DoWithEdit ? StringResources.ErrorIncorrectEditNo : StringResources.ErrorIncorrectReviewNo;
                            frmMsgBox.SetMessageOptions(new CustomMessageBoxOptions()
                            {
                                Title = StringResources.ErrorProccessingData,
                                Message = message,
                                ConfirmButtonText = StringResources.Confirm,
                                DevExpressIconId = "cancel",
                                DevExpressImageType = (int)DevExpress.Utils.Design.ImageType.Colored
                            });
                            frmMsgBox.ShowDialog();
                        }

                    }
                    if (editOrReviewStatus == EditOrReviewStatus.None)
                        await AddNewDocRequestStep(newStep, editReviewNo);


                }
            }
            catch (Exception ex)
            {

                ShowExceptionMessage(ex);
                btnSave.Enabled = true;

            }

        }
        private void ShowExceptionMessage(Exception ex)
        {
            ShowProgressBar(false);

            var frmMsgBox = new FrmMessageBox();

            frmMsgBox.SetMessageOptions(new CustomMessageBoxOptions()
            {
                Title = StringResources.ErrorProccessingData,
                Message = $"{ex.Message} \n {ex.InnerException} \n {ex.StackTrace}",
                ConfirmButtonText = StringResources.Confirm,
                DevExpressIconId = "cancel",
                DevExpressImageType = (int)DevExpress.Utils.Design.ImageType.Colored
            });
            frmMsgBox.ShowDialog();

        }
        private async Task<bool> AddNewDocRequestStep(DocRequestStep newStep,int editReviewNo)
        {
            if(editOrReviewStatus != EditOrReviewStatus.None)
                newStep.Description += editReviewNo.ToString();

            var result = await manageDocReqsService.SetDocRequestStepApproved(docReqId, userInfo.PersonCode);
            await manageDocReqsService.AddNewDocRequestStepAsync(newStep);


            if (UserHelper.CheckIsAdmin(receiverUserInfo.PostTypeID) || (receiverUserInfo.CodeEdare == Constants.SysOfficeCode || receiverUserInfo.UpperCode == Constants.SysOfficeCode) || userInfo.PersonCode.IsDeveloper())
            {
                smsClient.SendSMS(receiverUserInfo.Mobile, $"{StringResources.NewRequestSent} \n {StringResources.IKID}");

            }

            toastNotificationsManager1.ShowNotification(toastNotificationsManager1.Notifications[0]);
            ShowProgressBar(false);
            DialogResult = DialogResult.OK;
            this.Close();
            return result;
        }
        private async void cmbUserColleagues_EditValueChanged(object sender, System.EventArgs e)
        {
            var personCode = cmbUserColleagues.EditValue.ToString();

            var person = userColleagues.Where(x => x.PersonCode == personCode).First();

            receiverUserInfo = await personelyService.GetUserInfoByCardNumber(person.CardNumber);
        }

        private void rdbWithReview_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbWithReview.Checked)
                editOrReviewStatus = EditOrReviewStatus.DoWithReview;
        }

        private void rdbWithEdit_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbWithEdit.Checked)
                editOrReviewStatus = EditOrReviewStatus.DoWithEdit;
        }
    }
}