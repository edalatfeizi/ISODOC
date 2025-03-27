using DevExpress.DataAccess.Native.EntityFramework;
using DevExpress.Images;
using DevExpress.XtraEditors;
using IsoDoc.Domain.Entities;
using IsoDoc.Domain.Interfaces.Services;
using IsoDoc.Domain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using IsoDoc.Domain.Enums;
using IsoDocApp.Helpers;
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
        private DocRequestAttachment docReqAttachment;
        private List<Colleague> userColleagues;
        private Colleague receiverColleague;
        private int lastDocReqId = 0;
        public FrmNewDocReq(IManageDocReqsService manageDocReqsService, IPersonelyService personelyService)
        {
            this.manageDocReqsService = manageDocReqsService;
            this.personelyService = personelyService;
            InitializeComponent();
        }

        private async void FrmNewDocReq_Load(object sender, EventArgs e)
        {
            SetupControls();
            lastDocReqId = await manageDocReqsService.GetLastDocReqId();
            txtNewDocReqId.Text = $"{lastDocReqId + 1}";

            var userName = SystemInformation.UserName.ToString();
            userName = "3821";
            userInfo = await personelyService.GetUserInfoByCardNumber(userName);
            //userManagerInfo = await personelyService.GetUserManager(userInfo.UpperCode);
            //if(userManagerInfo == null)
               // userManagerInfo = await personelyService.GetUserManager(userInfo.DepartCode);

            departments = await personelyService.GetDepartments();
            //documents = await manageDocReqsService.GetDocuments("B1100");
            //cmbDocs.Properties.DataSource = documents;

            docTypes = await manageDocReqsService.GetDocTypes();
            //departments.ForEach(x => x.MDepartName.Trim());

            cmbDeps.Properties.DataSource = departments;
            //cmbUserColleagues.Properties.DataSource = userColleagues;

            //set user dep name as default dep name
            cmbDeps.EditValue = departments.FirstOrDefault(x => x.MDepartCode == userInfo.DepartCode).MDepartCode;

            cmbDocOwnerDep.Properties.DataSource = departments;
            cmbDocTypes.Properties.DataSource = docTypes;

            userColleagues = await personelyService.GetUserColleagues(userInfo.CodeEdare, userInfo.UpperCode);
            if(userColleagues.Count == 0) // incase if user has no direct colleagues like boss or he/she has no employees  
                userColleagues = await personelyService.GetUserColleagues("", userInfo.DepartCode);

            var isAdmin = AdminTypes.GetAdminTypes().Any(x => x == ((AdminType)Convert.ToInt32(userInfo.PostTypeID)));
            if (userInfo.DepartCode == "SI000" || userInfo.CodeEdare == "SI300" || userInfo.UpperCode == "SI300") // if user is sys dep admin
            {
                var admins = await personelyService.GetUserColleagues(null, null, true);
                userColleagues.AddRange(admins);
            }
            else if (isAdmin)
            {
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

            cmbDocTypes.Properties.DisplayMember = "DocName";
            cmbDocTypes.Properties.ValueMember = "DocId";

            cmbUserColleagues.Properties.DisplayMember = "Name";
            cmbUserColleagues.Properties.ValueMember = "PersonCode";

            var reqTypes = new List<string>() { StringResources.Create, StringResources.Change, StringResources.Delete };
            cmbReqTypes.Properties.DataSource = reqTypes;

            var keepDurations = new List<string>() { StringResources._3Month, StringResources._6Month, StringResources._1Year, StringResources._2Year, StringResources._3Year, StringResources._5Year, StringResources._10Year };
            cmbKeepDurations.Properties.DataSource = keepDurations;


        }
        private bool AttachFile()
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Word Files|*.docx;*.doc|Excel Files|*.xlsx;*.xls|PDF Files|*.pdf";
                openFileDialog.Title = "فایل پیوست مورد نظر را انتخاب کنید";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                    var file = File.ReadAllBytes(filePath);
                    string fileExtension = Path.GetExtension(filePath);

                    btnFileName.Visible = true;
                    btnFileName.Text = openFileDialog.SafeFileName;
                    ToggleAttachFileButtonView("cancel", StringResources.DeleteAttachedFile);
                    docReqAttachment = new DocRequestAttachment
                    {
                        Name = openFileDialog.SafeFileName,
                        ContentType = fileExtension,
                        Size = file.Length,
                        FileContent = file
                    };

                    return true;
                }
                else
                {
                    return false;
                }
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
            if (docReqAttachment != null)
            {
                docReqAttachment = null;
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
                    if (cmbReqTypes.EditValue.ToString() == StringResources.Create && Validators.ValidateControls<BaseEdit>(cmbReqTypes,cmbUserColleagues, txtTitle, txtReason, cmbDocOwnerDep, cmbDocTypes, cmbKeepDurations))
                    {
                        if(CheckAttachment())
                            AddNewDocRequest(DocRequestType.Create);
                    }
                    else if (cmbReqTypes.EditValue.ToString() == StringResources.Change && Validators.ValidateControls<BaseEdit>(cmbReqTypes, cmbUserColleagues, cmbDocOwnerDep, cmbDocs, txtReason, txtChanges ))
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

                    desc = $"{StringResources.NewCreateDocReq} {StringResources.For} {StringResources.Dep} {cmbDocOwnerDep.Text} {StringResources.WithTitle} : {txtTitle.Text}";
                    break;
                case DocRequestType.Update:

                    newDocReq.Title = $"{StringResources.ChangeDocReq} {StringResources.WithTitle} : {cmbDocs.Text}";
                    newDocReq.DocType = "";
                    newDocReq.KeepDuration = "";

                    desc = $"{StringResources.ChangeDocReq} {StringResources.For} {StringResources.Dep} {cmbDocOwnerDep.Text} {StringResources.WithTitle} : {cmbDocs.Text}";

                    break;
                case DocRequestType.Delete:
                    newDocReq.Title = $"{StringResources.DeleteDocReq} {StringResources.WithTitle} : {cmbDocs.Text}";
                    newDocReq.ChangeSummary = "";
                    newDocReq.DocType = "";
                    newDocReq.KeepDuration = "";

                    desc = $"{StringResources.DeleteDocReq} {StringResources.For} {StringResources.Dep} {cmbDocOwnerDep.Text} {StringResources.WithTitle} : {cmbDocs.Text}";

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
                ReceiverUserPost = receiverColleague.Post,
                ReceiverUserFullName = $"{receiverColleague.Name}",
                Description = desc,

                CreatedBy = userInfo.PersonCode,
                ModifiedBy = userInfo.PersonCode,
            };

            var docReqStep = await manageDocReqsService.AddNewDocRequestStepAsync(docRequestStep);

            if (docReqAttachment != null)
            {
                docReqAttachment.DocRequestId = docReq.Id;
                docReqAttachment.CreatedBy = userInfo.PersonCode;
                docReqAttachment.ModifiedBy = userInfo.PersonCode;

                await manageDocReqsService.AttachFileAsync(docReqAttachment);
            }
            ShowProgressBar(false);
            //TODO: send sms to receiver user

            //toastNotificationsManager1.ShowNotification()
            toastNotificationsManager1.ShowNotification(toastNotificationsManager1.Notifications[0]);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
   
        private bool CheckAttachment()
        {
            if (docReqAttachment == null)
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
                cmbDocs.Properties.DataSource = documents;
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