using DevExpress.XtraEditors;
using IsoDoc.Domain.Interfaces.Services;
using IsoDoc.Domain.Models;
using IsoDocApp.Helpers;
using IsoDocApp.ManageNewDocConfirmations;
using IsoDocApp.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IsoDocApp.ManageSignatures
{
    public partial class FrmManageSignatures : DevExpress.XtraEditors.XtraForm
    {
        private readonly IPersonelyService personelyService;
        private List<Colleague> employees = new List<Colleague>();

        public FrmManageSignatures(IPersonelyService personelyService)
        {
            InitializeComponent();
            this.personelyService = personelyService;
        }

        private async void FrmManageSignatures_Load(object sender, EventArgs e)
        {
            employees.Clear();
            employees = await personelyService.GetAllEmployees();
            gridUsers.DataSource = employees;
        }

        private async void grdUsers_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            var signature = GridViewHelper.GetGridViewCellValue(grdUsers, "HasSignature");
            var hasSignature = signature != null ? signature.ToString() : null;
            if (!string.IsNullOrEmpty(hasSignature) && hasSignature.ToString() == "دارد")
            {

                var personCode = GridViewHelper.GetGridViewCellValue(grdUsers, "PersonCode");

                var personSignature = await personelyService.GetPersonSignature(personCode.ToString());
                using (MemoryStream ms = new MemoryStream(personSignature.FileContent))
                {
                    Image img = Image.FromStream(ms);
                    peSignature.Image = img;
                }
                btnAddSignature.Enabled = false;
                btnDeleteSignature.Enabled = true;
            }
            else
            {
                peSignature.Image = Resources.Businessman_signing_contract1;
                btnAddSignature.Enabled = true;
                btnDeleteSignature.Enabled = false;
            }
        }

        private void btnAddSignature_Click(object sender, EventArgs e)
        {
            var personCode = GridViewHelper.GetGridViewCellValue(grdUsers, "PersonCode").ToString();

            var frmNewDocReq = new FrmAddUserSignature(personelyService, personCode);
            var result = frmNewDocReq.ShowDialog();

        }

        private async void btnDeleteSignature_Click(object sender, EventArgs e)
        {
            var signature = GridViewHelper.GetGridViewCellValue(grdUsers, "HasSignature");
            var hasSignature = signature != null ? signature.ToString() : null;
            if (!string.IsNullOrEmpty(hasSignature) && hasSignature.ToString() == "دارد")
            {

                var personCode = GridViewHelper.GetGridViewCellValue(grdUsers, "PersonCode");

                var isDeleted = await personelyService.DeletePersonSignature(personCode.ToString());
                if (isDeleted)
                {
                    btnDeleteSignature.Enabled = false;
                    btnAddSignature.Enabled = true;

                    peSignature.Image = Resources.Businessman_signing_contract1;

                }
            }
           
        }
     
    }
}