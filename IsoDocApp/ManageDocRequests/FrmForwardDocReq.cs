using DevExpress.XtraEditors;
using IsoDoc.Domain.Entities;
using IsoDoc.Domain.Enums;
using IsoDoc.Domain.Interfaces.Repositories;
using IsoDoc.Domain.Interfaces.Services;
using IsoDoc.Domain.Models;
using IsoDocApp.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IsoDocApp.ManageDocRequests
{
    public partial class FrmForwardDocReq : DevExpress.XtraEditors.XtraForm
    {
        private readonly IManageDocReqsService manageDocReqsService;
        private readonly IPersonelyService personelyService;
        private readonly IDocRequestStepsService docRequestStepsService;
        private int docReqId = 0;
        private int lastDocReqStepId = 0;
        private List<Colleague> userColleagues;
        private Person userInfo;
        private Person receiverUserInfo;
        private List<DocRequestStep> selectedDocReqSteps = new List<DocRequestStep>();
        private bool isAdmin = false;
        private DocRequestStatus requestStatus;
        private string docReqStatusDsc = "";
        public FrmForwardDocReq(IManageDocReqsService manageDocReqsService, IPersonelyService personelyService,/* IDocRequestStepsService docRequestStepsService,*/ int docReqId, int lastDocReqStepId, DocRequestStatus docRequestStatus, string docReqStatusDsc)
        {
            this.manageDocReqsService = manageDocReqsService;
            this.personelyService = personelyService;
            this.docRequestStepsService = docRequestStepsService;
            this.requestStatus = docRequestStatus;
            this.docReqStatusDsc = docReqStatusDsc;
            this.docReqId = docReqId;
            this.lastDocReqStepId = lastDocReqStepId;

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

            var steps = await DocRequestsHelper.GetDocRequestProgressBarSteps(selectedDocReqSteps, requestStatus, docReqStatusDsc);
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

            var userName = SystemInformation.UserName.ToString();
            //userName = "3864";
            userInfo = await personelyService.GetUserInfoByCardNumber(userName);

            userColleagues = await personelyService.GetUserColleagues(userInfo.CodeEdare, userInfo.UpperCode);
            isAdmin = AdminTypes.GetAdminTypes().Any(x => x == ((AdminType)Convert.ToInt32(userInfo.PostTypeID)));
            if (userInfo.CodeEdare == "SI000" || userInfo.CodeEdare == "SI300" || userInfo.UpperCode == "SI300") // if user is sys dep admin
            {
                var admins = await personelyService.GetUserColleagues(null, null, true);
                userColleagues.AddRange(admins);
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
            var frmMsgBox = new FrmMessageBox();

            try
            {
                if (Validators.ValidateControls<BaseEdit>(cmbUserColleagues, txtDocReqStepDesc))
                {

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
                    var result = await manageDocReqsService.SetDocRequestStepApproved(docReqId, userInfo.PersonCode);
                    await manageDocReqsService.AddNewDocRequestStepAsync(newStep);

                    toastNotificationsManager1.ShowNotification(toastNotificationsManager1.Notifications[0]);

                    DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                ShowProgressBar(false);

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

        }

        private async void cmbUserColleagues_EditValueChanged(object sender, System.EventArgs e)
        {
            var personCode = cmbUserColleagues.EditValue.ToString();

            var person = userColleagues.Where(x => x.PersonCode == personCode).First();

            receiverUserInfo = await personelyService.GetUserInfoByCardNumber(person.CardNumber);
        }
    }
}