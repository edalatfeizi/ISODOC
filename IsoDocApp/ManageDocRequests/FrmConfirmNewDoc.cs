using DevExpress.Utils.Extensions;
using DevExpress.XtraEditors;
using IsoDoc.Domain.Interfaces.Services;
using IsoDoc.Domain.Models;
using IsoDoc.Domain.Services;
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
        private List<Person> employees = new List<Person>();
        public FrmConfirmNewDoc(IPersonelyService personelyService)
        {
            InitializeComponent();
            this.personelyService = personelyService;
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
            teCreators.Properties.Tokens.Clear();
            teAcceptor.Properties.Tokens.Clear();
            teConfirmers.Properties.Tokens.Clear();
            employees = await personelyService.GetAllEmployees();
            foreach (Person employee in employees)
            {
                teCreators.Properties.Tokens.AddToken($"{employee.FirstName} {employee.LastName} - {employee.Posttxt}", employee.PersonCode);
                teAcceptor.Properties.Tokens.AddToken($"{employee.FirstName} {employee.LastName} - {employee.Posttxt}", employee.PersonCode);
                teConfirmers.Properties.Tokens.AddToken($"{employee.FirstName} {employee.LastName} - {employee.Posttxt}", employee.PersonCode);

            }

            //tokenEdit1.RightToLeft = RightToLeft.Yes;
            //tokenEdit1.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            //tokenEdit1.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;

            //teConfirmers.Properties.Tokens.AddToken("TEST1", "TEST1");

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var personCodes = teConfirmers.SelectedItems.Select(x => x.Value).ToList();
            Console.WriteLine(personCodes.Count);
        }
    }
}