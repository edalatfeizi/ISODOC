
using DevExpress.XtraEditors;
using IKIDMagfaSMSClientWin;
using IsoDoc.Domain.Dtos;
using IsoDoc.Domain.Enums;
using IsoDoc.Domain.Interfaces.Services;
using IsoDoc.Domain.Models;
using IsoDocApp.Extensions;
using IsoDocApp.Helpers;
using IsoDocApp.ManageNewDocConfirmations;
using IsoDocApp.ManageSignatures;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace IsoDocApp.ManageDocRequests
{
    public partial class FrmConfirmNewDoc : DevExpress.XtraEditors.XtraForm
    {
        private readonly IPersonelyService personelyService;
        private readonly IManageDocReqsService manageDocReqsService;
        private readonly IDocConfirmationService docConfirmationService;
        private readonly MagfaSMSClient smsClient;

        private List<Colleague> employees = new List<Colleague>();
        private List<Department> departments;
        private List<Document> documents;
        private List<SignerColleague> signerColleagues = new List<SignerColleague>();
        //private Person userInfo;
        private string userPersonCode = "";
        private int docReqId = 0;
        public FrmConfirmNewDoc(IPersonelyService personelyService, IManageDocReqsService manageDocReqsService, IDocConfirmationService docConfirmationService, MagfaSMSClient smsClient, int docReqId)
        {
            InitializeComponent();
            this.personelyService = personelyService;
            this.manageDocReqsService = manageDocReqsService;
            this.docConfirmationService = docConfirmationService;
            this.smsClient = smsClient;
            this.docReqId = docReqId;
        }

        private void panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private async void FrmConfirmNewDoc_Load(object sender, EventArgs e)
        {
            employees.Clear();
            SetupControls();

            var userName = SystemInformation.UserName.ToString();
            if (Program.DebugMode)
                userName = "3910";

            userPersonCode = await personelyService.GetUserPersonCodeByLoginName(userName);
            //userInfo = await personelyService.GetUserInfoByPersonCode(userPersonCode);


            departments = await personelyService.GetDepartments();
            cmbDocOwnerDep.Properties.DataSource = departments;

            employees = await personelyService.GetAllEmployees();
            cmbCreators.Properties.DataSource = employees;
            cmbConfirmers.Properties.DataSource = employees;
            cmbAcceptors.Properties.DataSource = employees;

            gridUsers.DataSource = signerColleagues;

        }
        private void SetupControls()
        {
            ShowProgressBar(false);

            cmbDocs.Properties.DisplayMember = "DocumentName";
            cmbDocs.Properties.ValueMember = "DocumentCode";

            // cmbDocs.Properties. = false;
            cmbDocs.Properties.ImmediatePopup = true;

            cmbDocOwnerDep.Properties.DisplayMember = "MDepartName";
            cmbDocOwnerDep.Properties.ValueMember = "MDepartCode";

            cmbCreators.Properties.DisplayMember = "Name";
            cmbCreators.Properties.ValueMember = "PersonCode";

            cmbConfirmers.Properties.DisplayMember = "Name";
            cmbConfirmers.Properties.ValueMember = "PersonCode";

            cmbAcceptors.Properties.DisplayMember = "Name";
            cmbAcceptors.Properties.ValueMember = "PersonCode";

        }

        private void ShowProgressBar(bool isVisible)
        {
            progressBar.Visible = isVisible;
        }
        private async void btnSave_Click(object sender, EventArgs e)
        {
            //var personCodes = teConfirmers.SelectedItems.Select(x => x.Value).ToList();
            //Console.WriteLine(personCodes.Count);
            try
            {
                if (Validators.ValidateControls<BaseEdit>(cmbDocOwnerDep, cmbDocs, txtReview, cmbCreators, cmbConfirmers, cmbAcceptors))
                {
                    if (signerColleagues.Count < 3)
                    {
                        ShowErrorMessage(StringResources.ErrorShouldSelectAtLeastThreePerson);
                    }
                    else if (signerColleagues.Count() >= 3)
                    {
                        if (!signerColleagues.Any(x => x.SignerColleagueType == StringResources.Creator))
                        {
                            ShowErrorMessage(StringResources.ErrorShouldSelectDocCreators);
                        }
                        else if (!signerColleagues.Any(x => x.SignerColleagueType == StringResources.Confirmer))
                        {
                            ShowErrorMessage(StringResources.ErrorShouldSelectDocConfirmers);
                        }
                        else if (!signerColleagues.Any(x => x.SignerColleagueType == StringResources.Acceptor))
                        {
                            ShowErrorMessage(StringResources.ErrorShouldSelectDocAcceptors);
                        }
                        else if (signerColleagues.Any(x => x.HasSignature == StringResources.HasNot))
                        {
                            ShowErrorMessage(StringResources.SetSignatureForAllPeople);
                        }
                        else
                        {
                            btnSave.Enabled = false;
                            ShowProgressBar(true);
                            var doc = documents.Where(x => x.DocumentCode.ToString() == cmbDocs.EditValue.ToString()).FirstOrDefault();

                            var newDocConfirmation = new NewDocConfirmationDto
                            {
                                DocReqId = docReqId,
                                DocOwnerDepCode = cmbDocOwnerDep.EditValue.ToString(),
                                DocCode = doc.DocumentCode,
                                DocTitle = doc.DocumentName,
                                ReviewNo = txtReviewNo.Text,
                                ReviewText = txtReview.Text,
                                CreatorUserPersonCode = userPersonCode
                            };

                            var newDocConfirm = await docConfirmationService.AddNewDocConfirmationAsync(newDocConfirmation);
                            foreach (var signerColleague in signerColleagues)
                            {
                                var newDocSigner = new NewDocSignerDto
                                {
                                    NewDocConfirmationId = newDocConfirm.Id,
                                    PersonCode = signerColleague.PersonCode,
                                    Name = signerColleague.Name,
                                    Post = signerColleague.Post,
                                    SigningOrder = signerColleagues.IndexOf(signerColleague),
                                    IsSigned = false,
                                    SignRequestSentDate = signerColleagues.IndexOf(signerColleague) == 0 ? DateTime.Now.ToPersianDateTime() : null,
                                    CreatorUserPersonCode = userPersonCode
                                };

                                switch (signerColleague.SignerColleagueType)
                                {
                                    case "تهیه کننده":
                                        newDocSigner.SignerType = SignerColleagueType.Creator;
                                        break;
                                    case "تایید کننده":
                                        newDocSigner.SignerType = SignerColleagueType.Confirmer;
                                        break;
                                    case "تصویب کننده":
                                        newDocSigner.SignerType = SignerColleagueType.Acceptor;
                                        break;
                                }
                                newDocSigner.Active = newDocSigner.SigningOrder == 0 ? true : false;


                                await docConfirmationService.AddNewDocSignersAsync(newDocSigner);



                            }

                            var signerUserInfo = await personelyService.GetUserInfoByPersonCode(signerColleagues[0].PersonCode);
                            smsClient.SendSMS(signerUserInfo.Mobile, $"{StringResources.NewSignDocReqSent} \n {StringResources.IKID}");

                            toastNotificationsManager1.ShowNotification(toastNotificationsManager1.Notifications[0]);

                            ShowProgressBar(false);
                            DialogResult = DialogResult.OK;
                            this.Close();
                        }
                    }



                }
            }
            catch (Exception ex)
            {

                ShowProgressBar(false);
                ShowExceptionMessage(ex);
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
        private void ShowErrorMessage(string message)
        {
            var frmMsgBox = new FrmMessageBox();

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
        private async void cmbDocOwnerDep_EditValueChanged_1(object sender, EventArgs e)
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

            ShowProgressBar(false);
        }

        private void cmbDocs_EditValueChanged(object sender, EventArgs e)
        {
            var doc = documents.Where(x => x.DocumentCode.ToString() == cmbDocs.EditValue.ToString()).FirstOrDefault();
            txtDocCode.Text = doc.DocumentCode.ToString();
        }


        private void peAddCreator_Click(object sender, EventArgs e)
        {
            AddSignerColleague(cmbCreators, SignerColleagueType.Creator);
        }

        private void peAddConfirmer_Click(object sender, EventArgs e)
        {
            AddSignerColleague(cmbConfirmers, SignerColleagueType.Confirmer);
        }

        private void peAddAcceptor_Click(object sender, EventArgs e)
        {
            AddSignerColleague(cmbAcceptors, SignerColleagueType.Acceptor);
        }


        private void AddSignerColleague(LookUpEdit cmbColleague, SignerColleagueType signerColleagueType)
        {
            if (cmbColleague.EditValue == null)
            {
                var frmMsgBox = new FrmMessageBox();

                frmMsgBox.SetMessageOptions(new CustomMessageBoxOptions()
                {
                    Title = StringResources.NoItemSelected,
                    Message = StringResources.NoPersonSelected,
                    ConfirmButtonText = StringResources.Confirm,
                    DevExpressIconId = "cancel",
                    DevExpressImageType = (int)DevExpress.Utils.Design.ImageType.Colored
                });
                frmMsgBox.ShowDialog();

            }
            else
            {
                if (signerColleagues.Any(x => x.PersonCode == cmbColleague.EditValue.ToString()))
                {
                    var frmMsgBox = new FrmMessageBox();

                    frmMsgBox.SetMessageOptions(new CustomMessageBoxOptions()
                    {
                        Title = StringResources.DuplicateItem,
                        Message = StringResources.DuplicatePerson,
                        ConfirmButtonText = StringResources.Confirm,
                        DevExpressIconId = "cancel",
                        DevExpressImageType = (int)DevExpress.Utils.Design.ImageType.Colored
                    });
                    frmMsgBox.ShowDialog();
                }
                else
                {

                    var selectedColleague = employees.Where(x => x.PersonCode == cmbColleague.EditValue.ToString()).First();
                    var signerColleague = new SignerColleague
                    {
                        PersonCode = selectedColleague.PersonCode,
                        CardNumber = selectedColleague.CardNumber,
                        Name = selectedColleague.Name,
                        Post = selectedColleague.Post,
                        HasSignature = selectedColleague.HasSignature,
                        Mobile = selectedColleague.Mobile,
                        PostTypeID = selectedColleague.PostTypeID,
                        UpperCode = selectedColleague.UpperCode,
                        CodeEdare = selectedColleague.CodeEdare,
                    };

                    switch (signerColleagueType)
                    {
                        case SignerColleagueType.Creator:
                            signerColleague.SignerColleagueType = StringResources.Creator;
                            break;
                        case SignerColleagueType.Confirmer:
                            signerColleague.SignerColleagueType = StringResources.Confirmer;
                            break;
                        case SignerColleagueType.Acceptor:
                            signerColleague.SignerColleagueType = StringResources.Acceptor;
                            break;
                    }

                    signerColleagues.Add(signerColleague);
                    //signerColleagues.Sort();
                    //signerColleagues = orderedList;
                    gridUsers.RefreshDataSource();

                    //gridUsers.Refresh();
                    CheckToToggleMoveAndDeleteButtonsState();
                }
            }


        }

        private void peMoveUp_Click(object sender, EventArgs e)
        {

            MovePersonInList(true);

        }

        private void peMoveDown_Click(object sender, EventArgs e)
        {
            MovePersonInList(false);

        }

        private void MovePersonInList(bool isMovingUp)
        {
            var selectedPersonCode = GridViewHelper.GetGridViewCellValue(grdUsers, "PersonCode").ToString();

            var signerColleague = signerColleagues.Where(x => x.PersonCode == selectedPersonCode).First();
            var signerIndex = signerColleagues.IndexOf(signerColleague);
            if (signerIndex > 0 && isMovingUp)
            {
                var prevItem = signerColleagues[signerIndex - 1];
                signerColleagues[signerIndex] = prevItem;
                signerColleagues[signerIndex - 1] = signerColleague;
                grdUsers.FocusedRowHandle = signerIndex - 1;

            }
            else if (signerIndex < signerColleagues.Count - 1 && !isMovingUp)
            {
                var nextItem = signerColleagues[signerIndex + 1];
                signerColleagues[signerIndex] = nextItem;
                signerColleagues[signerIndex + 1] = signerColleague;
                grdUsers.FocusedRowHandle = signerIndex + 1;
            }

            gridUsers.RefreshDataSource();
            CheckToToggleMoveAndDeleteButtonsState();

        }

        private void peDeleteSignerPerson_Click(object sender, EventArgs e)
        {
            if (signerColleagues.Count > 0)
            {
                var selectedPersonCode = GridViewHelper.GetGridViewCellValue(grdUsers, "PersonCode").ToString();
                var signerColleague = signerColleagues.Where(x => x.PersonCode == selectedPersonCode).First();

                signerColleagues.Remove(signerColleague);
                gridUsers.RefreshDataSource();
            }

            CheckToToggleMoveAndDeleteButtonsState();
        }
        private void CheckToToggleMoveAndDeleteButtonsState()
        {
            switch (signerColleagues.Count)
            {
                case 0:
                    peDeleteSignerPerson.Enabled = false;

                    break;
                case 1:
                    peDeleteSignerPerson.Enabled = true;
                    peMoveUp.Enabled = false;
                    peMoveDown.Enabled = false;
                    break;
                case 2:
                    peMoveUp.Enabled = true;
                    peMoveDown.Enabled = true;
                    break;
            }

        }

        private void grdUsers_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            var signature = GridViewHelper.GetGridViewCellValue(grdUsers, "HasSignature");
            var hasSignature = signature != null ? signature.ToString() : null;
            if (!string.IsNullOrEmpty(hasSignature) && hasSignature.ToString() == StringResources.Has)
            {
                mnuAddSignature.Enabled = false;
                mnuDeleteSignature.Enabled = true;
                mnuShowSignature.Enabled = true;
            }
            else
            {
                mnuAddSignature.Enabled = true;
                mnuDeleteSignature.Enabled = false;
                mnuShowSignature.Enabled = false;
            }


        }

        private void mnuAddSignature_Click(object sender, EventArgs e)
        {
            var personCode = GridViewHelper.GetGridViewCellValue(grdUsers, "PersonCode").ToString();

            var frmNewDocReq = new FrmAddUserSignature(personelyService, personCode);
            var result = frmNewDocReq.ShowDialog();
            if (result == DialogResult.OK)
            {
                var signerColleague = signerColleagues.Where(x => x.PersonCode == personCode).First();
                signerColleague.HasSignature = StringResources.Has;
                gridUsers.RefreshDataSource();

                mnuDeleteSignature.Enabled = true;
                mnuShowSignature.Enabled = true;
                mnuAddSignature.Enabled = false;
            }

        }

        private void mnuShowSignature_Click(object sender, EventArgs e)
        {
            var personCode = GridViewHelper.GetGridViewCellValue(grdUsers, "PersonCode").ToString();

            var frmShowSignature = new FrmShowSignature(personelyService, personCode);
            var result = frmShowSignature.ShowDialog();
        }

        private void grdUsers_MouseUp(object sender, MouseEventArgs e)
        {
            if (signerColleagues.Count > 0)
            {
                if (e.Button == MouseButtons.Right)
                {
                    contextMenuStrip1.Show(gridUsers, e.Location);
                }
            }
        }

        private async void mnuDeleteSignature_Click(object sender, EventArgs e)
        {
            var frmMsgBox = new FrmMessageBox();
            var empName = GridViewHelper.GetGridViewCellValue(grdUsers, "Name").ToString();

            frmMsgBox.SetMessageOptions(new CustomMessageBoxOptions()
            {
                Title = StringResources.DeleteSignature,
                Message = $"{StringResources.DeleteSignaturePrompt1} {empName}  {StringResources.DeleteSignaturePrompt2}",
                ShowCancelButton = true,
                ShowConfirmButton = true,
                ConfirmButtonText = StringResources.Yes,
                CancelButtonText = StringResources.No,
                DevExpressIconId = "cancel",
                DevExpressImageType = (int)DevExpress.Utils.Design.ImageType.Colored
            });
            var result = frmMsgBox.ShowDialog();
            if (result == DialogResult.OK)
            {
                var personCode = GridViewHelper.GetGridViewCellValue(grdUsers, "PersonCode");

                var isDeleted = await personelyService.DeletePersonSignature(personCode.ToString());
                if (isDeleted)
                {
                    var signerColleague = signerColleagues.Where(x => x.PersonCode == personCode).First();
                    signerColleague.HasSignature = StringResources.HasNot;
                    mnuDeleteSignature.Enabled = false;
                    mnuAddSignature.Enabled = true;
                    mnuShowSignature.Enabled = false;
                    gridUsers.RefreshDataSource();
                }
            }

            //else
            //{

            //}
        }
    }
}