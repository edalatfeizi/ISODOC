using DevExpress.DataAccess.Native.EntityFramework;
using DevExpress.Images;
using DevExpress.XtraEditors;
using IKIDMagfaSMSClientWin;
using IsoDoc.Domain.Entities;
using IsoDoc.Domain.Enums;
using IsoDoc.Domain.Interfaces.Services;
using IsoDoc.Domain.Models;
using IsoDocApp.Enums;
using IsoDocApp.Extensions;
using IsoDocApp.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace IsoDocApp.ManageDocRequests
{
    public partial class FrmNewDocReq : DevExpress.XtraEditors.XtraForm
    {
        private readonly IManageDocReqsService manageDocReqsService;
        private readonly IPersonelyService personelyService;
        private Person userInfo;
        private Person userManagerInfo;
        private List<Department> departments;
        private List<Document> documents;
        private List<DocType> docTypes;
        private DocRequest newDocReq = new DocRequest();
        private DocRequestStep docRequestStep;
        private List<DocRequestAttachment> docReqAttachments;
        private List<Colleague> userColleagues;
        private Colleague receiverColleague;
        private int lastDocReqId = 0;
        private MagfaSMSClient smsClient;
        public FrmNewDocReq(IManageDocReqsService manageDocReqsService, IPersonelyService personelyService, MagfaSMSClient magfaSMSClient)
        {
            this.manageDocReqsService = manageDocReqsService;
            this.personelyService = personelyService;
            this.smsClient = magfaSMSClient;    
            InitializeComponent();
        }

        private async void FrmNewDocReq_Load(object sender, EventArgs e)
        {

            SetupControls();
            lastDocReqId = await manageDocReqsService.GetLastDocReqId();
            txtNewDocReqId.Text = $"{lastDocReqId + 1}";

            var userName = SystemInformation.UserName;
            //userName = "3038";
            var userPersonCode = "";
            userPersonCode = await personelyService.GetUserPersonCodeByLoginName(userName);
            userInfo = await personelyService.GetUserInfoByPersonCode(userPersonCode);
            //userManagerInfo = await personelyService.GetUserManager(userInfo.UpperCode);
            //if(userManagerInfo == null)
            // userManagerInfo = await personelyService.GetUserManager(userInfo.DepartCode);

            departments = await personelyService.GetDepartments();
            cmbDeps.Properties.DataSource = departments;

            //documents = await manageDocReqsService.GetDocuments("B1100");
            //cmbDocs.Properties.DataSource = documents;

            docTypes = await manageDocReqsService.GetDocTypes();
            //departments.ForEach(x => x.MDepartName.Trim());

            //cmbUserColleagues.Properties.DataSource = userColleagues;

            //set user dep name as default dep name
            cmbDeps.EditValue = departments.FirstOrDefault(x => x.MDepartCode == userInfo.DepartCode).MDepartCode;

            cmbDocOwnerDep.Properties.DataSource = departments;
            cmbDocTypes.Properties.DataSource = docTypes;

      
            userColleagues = await personelyService.GetUserColleagues(userInfo.CodeEdare, userInfo.UpperCode);
   
            // if user is a boss and his/her dep has no admin, PostTypeID 50 and 4 is reserved for an office boss and supervisor
            if (int.Parse(userInfo.PostTypeID) == (int)PostTypes.OfficeSupervisor ||
                int.Parse(userInfo.PostTypeID) == (int)PostTypes.Boss
                && !userColleagues.Any(x => x.CodeEdare == userInfo.UpperCode))
            {
                var admins = await personelyService.GetUserColleagues(null, null, false, true);
                userColleagues.AddRange(admins);
            }
            if (userColleagues.Count == 0) // incase if user has no direct colleagues like boss or he/she has no employees  
                userColleagues = await personelyService.GetUserColleagues("", userInfo.DepartCode);

            var isAdmin = UserHelper.CheckIsAdmin(userInfo.PostTypeID);
            if (userInfo.CodeEdare == Constants.SysAdminCode || userInfo.CodeEdare == Constants.SysOfficeCode || userInfo.UpperCode == Constants.SysOfficeCode || userInfo.PersonCode.IsDeveloper()) // if user is sys office employee or sys dep admin
            {
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

            panel.Enabled = true;
            ShowProgressBar(false);


        }
      
        private void SetupControls()
        {
            cmbDeps.Properties.DisplayMember = "MDepartName";
            cmbDeps.Properties.ValueMember = "MDepartCode";

            cmbDocOwnerDep.Properties.DisplayMember = "MDepartName";
            cmbDocOwnerDep.Properties.ValueMember = "MDepartCode";

            cmbDocs.Properties.DisplayMember = "DocumentName";
            cmbDocs.Properties.ValueMember = "DocumentCode";

           // cmbDocs.Properties. = false;
            cmbDocs.Properties.ImmediatePopup = true;
           

            cmbDocTypes.Properties.DisplayMember = "DocName";
            cmbDocTypes.Properties.ValueMember = "DocId";


            cmbUserColleagues.Properties.DisplayMember = "Name";
            cmbUserColleagues.Properties.ValueMember = "PersonCode";

            var reqTypes = new List<string>() { StringResources.Create, StringResources.Change, StringResources.Delete };
            cmbReqTypes.Properties.DataSource = reqTypes;

            var keepDurations = new List<string>() { StringResources._3Month, StringResources._6Month, StringResources._1Year, StringResources._2Year, StringResources._3Year, StringResources._5Year, StringResources._10Year };
            cmbKeepDurations.Properties.DataSource = keepDurations;


        }
        private void AttachFile()
        {
            docReqAttachments = AttachmentsHelper.AttachFiles(Constants.DocReqAttachmentFileTypes, false)?.MapToDocRequestAttachments(0);
            btnFileName.Visible = true;

            foreach (var attachment in docReqAttachments)
            {
                btnFileName.Text += $" {attachment.Name}";

            }
            if (docReqAttachments.Count > 0)
            {
                ToggleAttachFileButtonView("cancel", StringResources.DeleteAttachedFile);

            }

        }

        private void ShowProgressBar(bool isVisible)
        {
            progressBar.Visible = isVisible;
        }
        private void ShowProgressBar(bool isVisible, string message)
        {
            progressBar.Visible = isVisible;
            progressBar.Text = message;
        }
        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ToggleAttachFileButtonView(string iconId, string buttonText)
        {
            btnAttachFile.ImageOptions.Image = ImageResourceCache.Default.GetImageById(iconId, DevExpress.Utils.Design.ImageSize.Size32x32, DevExpress.Utils.Design.ImageType.Colored);
            btnAttachFile.Text = buttonText;
        }

        private void pbAttachFile_EditValueChanged(object sender, EventArgs e)
        {
          AttachFile();
          
        }

        private void btnAttachFile_Click(object sender, EventArgs e)
        {
            if (docReqAttachments != null)
            {
                docReqAttachments = null;
                btnFileName.Visible = false;
                ToggleAttachFileButtonView("attachment", StringResources.AttachFile);

            }
            else
            {
                AttachFile();

            }


        }

        private void btnFileName_Click(object sender, EventArgs e)
        {

        }

        private void pbAttachFile_Click(object sender, EventArgs e)
        {
            AttachFile();

        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            var frmMsgBox = new FrmMessageBox();

            try
            {

                if (!string.IsNullOrEmpty(cmbReqTypes.EditValue.ToString()))
                {
                    if (cmbReqTypes.EditValue.ToString() == StringResources.Create && Validators.ValidateControls<BaseEdit>(cmbReqTypes, cmbUserColleagues, txtTitle, txtReason, cmbDocOwnerDep, cmbDocTypes, cmbKeepDurations))
                    {
                        if (CheckAttachment())
                            AddNewDocRequest(DocRequestType.Create);
                    }
                    else if (cmbReqTypes.EditValue.ToString() == StringResources.Change && Validators.ValidateControls<BaseEdit>(cmbReqTypes, cmbUserColleagues, cmbDocOwnerDep, cmbDocs, txtReason, txtChanges))
                    {
                        if (CheckAttachment())
                            AddNewDocRequest(DocRequestType.Update);
                    }
                    else if (cmbReqTypes.EditValue.ToString() == StringResources.Delete && Validators.ValidateControls<BaseEdit>(cmbReqTypes, cmbUserColleagues, cmbDocOwnerDep, cmbDocs, txtReason))
                    {
                        AddNewDocRequest(DocRequestType.Delete);

                    }
                }
            }
            catch (Exception ex)
            {
                ShowProgressBar(false);

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
        private async void AddNewDocRequest(DocRequestType docRequestType)
        {
            var newDocReq = new DocRequest
            {
                DocRequestType = docRequestType,
                CreateReason = txtReason.Text.Trim(),
                ChangeSummary = txtChanges.Text.Trim(),
                DocOwnerDep = cmbDocOwnerDep.Text.Trim(),
                DocCode = !string.IsNullOrEmpty(cmbDocs.Text) ? documents.Where(x => x.DocumentName == cmbDocs.Text).First().DocumentCode : "",
                DocId = !string.IsNullOrEmpty(cmbDocs.Text) ? documents.Where(x => x.DocumentName == cmbDocs.Text).First().DocId : 0,
                DocType = cmbDocTypes.Text.Trim(),
                KeepDuration = cmbKeepDurations.Text.Trim(),
                DocRequestStatus = DocRequestStatus.InProgress,
                CreatorDep = cmbDeps.Text.Trim(),
                CreatedBy = userInfo.PersonCode,
                ModifiedBy = userInfo.PersonCode,


            };
            var desc = "";
            switch (docRequestType)
            {
                case DocRequestType.Create:

                    newDocReq.Title = $"{StringResources.NewCreateDocReq} {StringResources.WithTitle} : {txtTitle.Text.Trim()}";
                    newDocReq.ChangeSummary = "";
                    newDocReq.DocCode = "";

                    desc = $"{StringResources.NewCreateDocReq} {StringResources.For} {StringResources.Dep} : {cmbDocOwnerDep.Text} {StringResources.WithTitle} : {txtTitle.Text}";
                    break;
                case DocRequestType.Update:

                    newDocReq.Title = $"{StringResources.ChangeDocReq} {StringResources.WithTitle} : {cmbDocs.Text}";
                    newDocReq.DocType = "";
                    newDocReq.KeepDuration = "";

                    desc = $"{StringResources.ChangeDocReq} {StringResources.For} {StringResources.Dep} : {cmbDocOwnerDep.Text} {StringResources.WithTitle} : {cmbDocs.Text}";

                    break;
                case DocRequestType.Delete:
                    newDocReq.Title = $"{StringResources.DeleteDocReq} {StringResources.WithTitle} : {cmbDocs.Text}";
                    newDocReq.ChangeSummary = "";
                    newDocReq.DocType = "";
                    newDocReq.KeepDuration = "";

                    desc = $"{StringResources.DeleteDocReq} {StringResources.For}  {StringResources.Dep}  : {cmbDocOwnerDep.Text} {StringResources.WithTitle} : {cmbDocs.Text}";

                    break;
            }
            ShowProgressBar(true);
            var docReq = await manageDocReqsService.CreateNewDocRequest(newDocReq);

            docRequestStep = new DocRequestStep
            {
                DocRequestId = docReq.Id,
                SenderUserPersonCode = userInfo.PersonCode,
                SenderUserPost = userInfo.Posttxt,
                SenderUserFullName = $"{userInfo.FirstName} {userInfo.LastName}",

                ReceiverUserPersonCode = receiverColleague.PersonCode,
                ReceiverUserPost = receiverColleague.Posttxt,
                ReceiverUserFullName = $"{receiverColleague.Name}",
                Description = desc,

                CreatedBy = userInfo.PersonCode,
                ModifiedBy = userInfo.PersonCode,
            };

            var docReqStep = await manageDocReqsService.AddNewDocRequestStepAsync(docRequestStep);
            foreach (var attachment in docReqAttachments)
            {
                attachment.DocRequestId = docReq.Id;
                attachment.CreatedBy = userInfo.PersonCode;
                attachment.ModifiedBy = userInfo.PersonCode;

                await manageDocReqsService.AttachFileAsync(attachment);
            }

            ShowProgressBar(false);

            //toastNotificationsManager1.ShowNotification()
            //if receiver is a top manager or one of sys office staffs then notify them via an sms  
            if (UserHelper.CheckIsAdmin(receiverColleague.PostTypeID) || receiverColleague.CodeEdare == "SI300" || receiverColleague.UpperCode == "SI300") 
            {
                smsClient.SendSMS(receiverColleague.Mobile, $"{StringResources.NewRequestSent} \n {StringResources.IKID}");

            }

            toastNotificationsManager1.ShowNotification(toastNotificationsManager1.Notifications[0]);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private bool CheckAttachment()
        {
            if (docReqAttachments == null && docReqAttachments.Count == 0)
            {
                var frmMsgBox = new FrmMessageBox();
                frmMsgBox.SetMessageOptions(new CustomMessageBoxOptions()
                {
                    Title = StringResources.ErrorProccessingData,
                    Message = $"{StringResources.ErrorAttachFile}",
                    ConfirmButtonText = StringResources.Confirm,
                    DevExpressIconId = "cancel",
                    DevExpressImageType = (int)DevExpress.Utils.Design.ImageType.Colored
                });
                frmMsgBox.ShowDialog();
                return false;
            }
            return true;
        }
        private void cmbReqTypes_EditValueChanged(object sender, EventArgs e)
        {
            //newDocReq.DocRequestType = (DocRequestType)cmbReqTypes.ItemIndex;
            cmbDocOwnerDep.Enabled = true;
            btnSave.Enabled = true;
            if (cmbReqTypes.EditValue.ToString() == StringResources.Create)
            {
                txtChanges.Enabled = false;
                txtReason.Enabled = true;
                cmbDocs.Enabled = false;
                txtTitle.Enabled = true;
                cmbDocTypes.Enabled = true;
                //cmbKeepDurations.Enabled = true;
                pbAttachFile.Enabled = true;
                btnAttachFile.Enabled = true;
            }
            else if (cmbReqTypes.EditValue.ToString() == StringResources.Delete)
            {
                //cmbDocs.Enabled = true;
                txtChanges.Enabled = false;
                txtReason.Enabled = true;

                txtTitle.Enabled = false;
                cmbDocTypes.Enabled = false;
                cmbKeepDurations.Enabled = false;

                pbAttachFile.Enabled = false;
                btnAttachFile.Enabled = false;

            }
            else //Change
            {
                txtChanges.Enabled = true;
                txtReason.Enabled = true;
                txtTitle.Enabled = false;
                cmbDocTypes.Enabled = false;
                cmbKeepDurations.Enabled = false;

                pbAttachFile.Enabled = true;
                btnAttachFile.Enabled = true;
            }
        }

        private void cmbDocs_EditValueChanged(object sender, EventArgs e)
        {
            //newDocReq.Title = cmbDocs.EditValue.ToString();
        }

        private void cmbDocTypes_EditValueChanged(object sender, EventArgs e)
        {
            var docType = docTypes.Where(x => x.DocId.ToString() == cmbDocTypes.EditValue.ToString()).FirstOrDefault();
            if (docType != null)
            {
                if (docType.KeepDurationRequired)
                    cmbKeepDurations.Enabled = true;
                else
                    cmbKeepDurations.Enabled = false;
            }

        }

        private async void cmbDocOwnerDep_EditValueChanged(object sender, EventArgs e)
        {

            //newDocReq.DocRequestType = (DocRequestType)cmbReqTypes.ItemIndex;
            if (cmbReqTypes.EditValue.ToString() == StringResources.Change || cmbReqTypes.EditValue.ToString() == StringResources.Delete)
            {
                cmbDocs.Enabled = true;
                //filter docs by dep
                ShowProgressBar(true);
                var dep = departments.Where(x => x.MDepartCode.ToString() == cmbDocOwnerDep.EditValue.ToString()).FirstOrDefault();

                documents = await manageDocReqsService.GetDocuments(dep.MDepartCode);
                
                foreach (var doc in documents)
                {
                    doc.DocumentName = doc.DocumentName.NormalizePersian();
                }
                cmbDocs.Properties.DataSource = documents;

                //cmbDocs.Properties.Columns["RowNumber"].Width = 50;
                //cmbDocs.Properties.Columns["DocId"].Width = 70;
                //cmbDocs.Properties.Columns["DocumentCode"].Width = 80;

                ShowProgressBar(false);

                //newDocReq.
            }
            else
                cmbDocs.Enabled = false;

        }

        private void cmbUserColleagues_EditValueChanged(object sender, EventArgs e)
        {
            receiverColleague = userColleagues.Where(x => x.PersonCode.ToString() == cmbUserColleagues.EditValue.ToString()).FirstOrDefault();


        }
    }
}