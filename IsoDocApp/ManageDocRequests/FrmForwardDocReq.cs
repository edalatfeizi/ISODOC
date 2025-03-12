using DevExpress.XtraEditors;
using IsoDoc.Domain.Entities;
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

        public FrmForwardDocReq(IManageDocReqsService manageDocReqsService, IPersonelyService personelyService,/* IDocRequestStepsService docRequestStepsService,*/ int docReqId, int lastDocReqStepId)
        {
            this.manageDocReqsService = manageDocReqsService;
            this.personelyService = personelyService;
            this.docRequestStepsService = docRequestStepsService;

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

            var steps = await DocRequestsHelper.GetDocRequestProgressBarSteps(selectedDocReqSteps);
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
            userInfo = await personelyService.GetUserInfo(userName);

            userColleagues = await personelyService.GetUserColleagues(userInfo.CodeEdare, userInfo.UpperCode);
            cmbUserColleagues.Properties.DataSource = userColleagues;

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

            receiverUserInfo = await personelyService.GetUserInfo(person.CardNumber);
        }
    }
}