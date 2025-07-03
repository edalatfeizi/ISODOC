using DevExpress.Utils.Extensions;
using DevExpress.XtraEditors;
using IsoDoc.Domain.Interfaces.Services;
using IsoDoc.Domain.Models;
using IsoDoc.Domain.Services;
using IsoDocApp.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
    }
}