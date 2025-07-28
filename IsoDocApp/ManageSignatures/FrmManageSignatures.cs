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
            LoadData();

        }

        private async void grdUsers_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            var signature = GridViewHelper.GetGridViewCellValue(grdUsers, "HasSignature");
            var hasSignature = signature != null ? signature.ToString() : null;
            if (!string.IsNullOrEmpty(hasSignature) && hasSignature.ToString() == "دارد")
            {

                var personCode = GridViewHelper.GetGridViewCellValue(grdUsers, "PersonCode");

                await GetSignature(personCode.ToString());

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

        private async void btnAddSignature_Click(object sender, EventArgs e)
        {
            var personCode = GridViewHelper.GetGridViewCellValue(grdUsers, "PersonCode").ToString();

            var frmNewDocReq = new FrmAddUserSignature(personelyService, personCode);
            var result = frmNewDocReq.ShowDialog();
            if (result == DialogResult.OK)
            {

                var emp = employees.Where(x => x.PersonCode == personCode).First();
                emp.HasSignature = StringResources.Has;
                gridUsers.RefreshDataSource();

                await GetSignature(personCode);
            }


        }

        private async void btnDeleteSignature_Click(object sender, EventArgs e)
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
                    btnDeleteSignature.Enabled = false;
                    btnAddSignature.Enabled = true;

                    peSignature.Image = Resources.Businessman_signing_contract1;

                    var emp = employees.Where(x => x.PersonCode == personCode).First();
                    emp.HasSignature = StringResources.HasNot;
                    gridUsers.RefreshDataSource();

                }
            }


        }
        private async void LoadData()
        {
            employees.Clear();
            employees = await personelyService.GetAllEmployees();
            gridUsers.DataSource = employees;
        }

        private async Task GetSignature(string personCode)
        {
            var personSignature = await personelyService.GetPersonSignature(personCode.ToString());
            using (MemoryStream ms = new MemoryStream(personSignature.FileContent))
            {
                Image img = Image.FromStream(ms);
                peSignature.Image = img;
            }
        }
    }
}