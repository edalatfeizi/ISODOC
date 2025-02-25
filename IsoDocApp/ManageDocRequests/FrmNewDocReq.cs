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
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using IsoDoc.Domain.Enums;
namespace IsoDocApp.ManageDocRequests
{
    public partial class FrmNewDocReq : DevExpress.XtraEditors.XtraForm
    {
        private readonly IManageDocReqsService manageDocReqsService;
        private readonly IPersonelyService personelyService;
        private Person userInfo;
        private List<Department> departments;
        private List<Document> documents;
        private DocRequest newDocReq = new DocRequest();
        private byte[] attachedFile;
        private string fileExt = "";
        public FrmNewDocReq(IManageDocReqsService manageDocReqsService, IPersonelyService personelyService)
        {
            this.manageDocReqsService = manageDocReqsService;
            this.personelyService = personelyService;
            InitializeComponent();
        }

        private async void FrmNewDocReq_Load(object sender, EventArgs e)
        {
            SetupControls();
            var maxReqId = await manageDocReqsService.GetLastDocReqId();
            txtNewDocReqId.Text = $"{maxReqId + 1}";

            var userName = SystemInformation.UserName.ToString();
            userInfo = await personelyService.GetUserInfo(userName);
            departments = await personelyService.GetDepartments();
            documents = await manageDocReqsService.GetDocuments();
            //departments.ForEach(x => x.MDepartName.Trim());

            cmbDeps.Properties.DataSource = departments;
            cmbDeps.EditValue = departments.FirstOrDefault(x => x.MDepartCode == userInfo.DepartCode).MDepartCode;

            cmbDocOwnerDep.Properties.DataSource = departments;
            cmbDocs.Properties.DataSource = documents;

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

            var reqTypes = new List<string>() { StringResources.Create, StringResources.Change, StringResources.Delete};
            cmbReqTypes.Properties.DataSource = reqTypes;

            var keepDurations = new List<string>() { StringResources._3Month, StringResources._6Month, StringResources._1Year, StringResources._2Year, StringResources._3Year, StringResources._5Year,StringResources._10Year };
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
                    attachedFile = File.ReadAllBytes(filePath);
                    string fileExtension = Path.GetExtension(filePath);
                    // Optionally, store the extension in your docRequest object
                    fileExt = fileExtension;

                    btnFileName.Visible = true;
                    btnFileName.Text = openFileDialog.SafeFileName;

                    ToggleAttachFileButtonView("cancel", StringResources.DeleteAttachedFile);
             
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
        private void ShowProgressBar(bool isVisible,string message)
        {
            progressBar.Visible = isVisible;
            progressBar.Text = message;
        }
        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ToggleAttachFileButtonView(string iconId,string buttonText)
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
            if (attachedFile != null)
            {
                attachedFile = null;
                fileExt = "";
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            var frmMsgBox = new FrmMessageBox();
            var messageBoxOptions = new CustomMessageBoxOptions();
            if (newDocReq.DocRequestType == DocRequestType.Create && string.IsNullOrEmpty(txtReason.Text))
            {
                messageBoxOptions.Title = StringResources.EmptyValues;
                messageBoxOptions.Message = StringResources.FillAllValues;
                messageBoxOptions.ConfirmButtonText = StringResources.Confirm;
                messageBoxOptions.DevExpressIconId = "warning";
                messageBoxOptions.DevExpressImageType = (int)DevExpress.Utils.Design.ImageType.Colored;
            }

            frmMsgBox.SetMessageOptions(messageBoxOptions);
            frmMsgBox.ShowDialog();
 
        }

        private void cmbReqTypes_EditValueChanged(object sender, EventArgs e)
        {
            newDocReq.DocRequestType = (DocRequestType)cmbReqTypes.ItemIndex;
            if (cmbReqTypes.EditValue.ToString() == StringResources.Create)
            {
                txtChanges.Enabled = false;
                cmbDocs.Enabled = false;
                txtTitle.Enabled = true;
                cmbKeepDurations.Enabled = true;
            }
            else
            {
                cmbDocs.Enabled = true;
                txtChanges.Enabled = true;
                txtTitle.Enabled = false;
                cmbKeepDurations.Enabled = false;
            }
        }

        private void cmbDocs_EditValueChanged(object sender, EventArgs e)
        {
            newDocReq.Title = cmbDocs.EditValue.ToString();
        }
    }
}