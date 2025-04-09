using DevExpress.XtraEditors;
using IsoDoc.Domain.Entities;
using IsoDoc.Domain.Interfaces.Services;
using IsoDoc.Domain.Models;
using IsoDoc.Domain.Services;
using IsoDocApp.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IsoDocApp
{
    public partial class FrmSearch : DevExpress.XtraEditors.XtraForm
    {
        private readonly IDocsService docsService;
        private readonly IPersonelyService personelyService;
        private List<SearchResult> result = new List<SearchResult>();
        private Person userInfo;
        private string userName = "";
        private bool isAdmin = false;
        public FrmSearch( IDocsService docsService, IPersonelyService personelyService)
        {
            this.docsService = docsService;
            this.personelyService = personelyService;
            InitializeComponent();

        }
        private async void FrmSearch_Load(object sender, EventArgs e)
        {
            txtSearch.Height = 32;
            txtSearch.MinimumSize = new Size(320, 36);
            txtSearch.MaximumSize = new Size(320, 36);


            userName = SystemInformation.UserName.ToString();
            //userName = "3015";

            userInfo = await personelyService.GetUserInfoByCardNumber(userName);

            if(userInfo.CodeEdare == "SI300" || userInfo.UpperCode == "SI300")
                isAdmin = true;

        }

        private void txtSearch_EditValueChanged(object sender, EventArgs e)
        {
            Search();
        }

        private async void Search()
        {
            result = await docsService.FilterDocs(isAdmin,txtSearch.Text.Trim(),userInfo.DepartID);

            grdSearchResult.DataSource = result;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            Search();
        }

        private void btnShowDoc_Click(object sender, EventArgs e)
        {

        }
        private void ShowDoc()
        {
            var docTypeID = GridViewHelper.GetGridViewCellValue(gridView1, "DocTypeID").ToString();
            var mainId = GridViewHelper.GetGridViewCellValue(gridView1, "MainId").ToString();
            //try
            //{
            //    if (docTypeID == "1" && mainId != "-1")
            //    {
            //        var frmPdf = new IsoDoc
            //    }

            //}
            //catch (Exception ex)
            //{

            //    throw;
            //}
       
        }
    }
}