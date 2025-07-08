using DevExpress.Utils.Extensions;
using DevExpress.XtraEditors;
using IsoDoc.Domain.Enums;
using IsoDoc.Domain.Interfaces.Services;
using IsoDoc.Domain.Models;
using IsoDoc.Domain.Services;
using IsoDocApp.Extensions;
using IsoDocApp.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IsoDocApp.ManageDocRequests
{
    public partial class FrmConfirmNewDoc : DevExpress.XtraEditors.XtraForm
    {
        private readonly IPersonelyService personelyService;
        private readonly IManageDocReqsService manageDocReqsService;

        private List<Colleague> employees = new List<Colleague>();
        private List<Department> departments;
        private List<Document> documents;
        private List<SignerColleague> signerColleagues = new List<SignerColleague>();

        public FrmConfirmNewDoc(IPersonelyService personelyService, IManageDocReqsService manageDocReqsService)
        {
            InitializeComponent();
            this.personelyService = personelyService;
            this.manageDocReqsService = manageDocReqsService;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

        }

        private void panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private async void FrmConfirmNewDoc_Load(object sender, EventArgs e)
        {
            employees.Clear();
            SetupControls();
            departments = await personelyService.GetDepartments();
            cmbDocOwnerDep.Properties.DataSource = departments;

            employees = await personelyService.GetAllEmployees();
            cmbCreators.Properties.DataSource = employees;
            cmbConfirmers.Properties.DataSource = employees;
            cmbAcceptors.Properties.DataSource = employees;

            gridUsers.DataSource = signerColleagues;

            //teCreators.Properties.Tokens.Clear();
            //teAcceptor.Properties.Tokens.Clear();
            //teConfirmers.Properties.Tokens.Clear();
            //foreach (Person employee in employees)
            //{
            //    teCreators.Properties.Tokens.AddToken($"{employee.FirstName} {employee.LastName} - {employee.Posttxt}", employee.PersonCode);
            //    teAcceptor.Properties.Tokens.AddToken($"{employee.FirstName} {employee.LastName} - {employee.Posttxt}", employee.PersonCode);
            //    teConfirmers.Properties.Tokens.AddToken($"{employee.FirstName} {employee.LastName} - {employee.Posttxt}", employee.PersonCode);

            //}

            //tokenEdit1.RightToLeft = RightToLeft.Yes;
            //tokenEdit1.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            //tokenEdit1.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;

            //teConfirmers.Properties.Tokens.AddToken("TEST1", "TEST1");

        }
        private void SetupControls()
        {
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
        private void btnSave_Click(object sender, EventArgs e)
        {
            //var personCodes = teConfirmers.SelectedItems.Select(x => x.Value).ToList();
            //Console.WriteLine(personCodes.Count);
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
                        Mobile = selectedColleague.Mobile,
                        PostTypeID = selectedColleague.PostTypeID,
                        UpperCode = selectedColleague.UpperCode,
                        CodeEdare = selectedColleague.CodeEdare,
                        SignerColleagueType = signerColleagueType.ToString(),
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
    }
}