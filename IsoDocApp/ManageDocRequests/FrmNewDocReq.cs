using DevExpress.XtraEditors;
using IsoDoc.Domain.Interfaces.Services;
using IsoDoc.Domain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IsoDocApp.ManageDocRequests
{
    public partial class FrmNewDocReq : DevExpress.XtraEditors.XtraForm
    {
        private readonly IManageDocReqsService manageDocReqsService;
        private readonly IPersonelyService personelyService;
        private Person userInfo;
        private List<Department> departments;
        public FrmNewDocReq(IManageDocReqsService manageDocReqsService, IPersonelyService personelyService)
        {
            this.manageDocReqsService = manageDocReqsService;
            this.personelyService = personelyService;   
            InitializeComponent();
        }

        private async void FrmNewDocReq_Load(object sender, EventArgs e)
        {
            var maxReqId = await manageDocReqsService.GetLastDocReqId();
            txtNewDocReqId.Text = $"{maxReqId + 1}";

            var userName = SystemInformation.UserName.ToString();
            userInfo = await personelyService.GetUserInfo(userName);
            departments = await personelyService.GetDepartments();

            cmbDeps.Properties.DataSource = departments;
        }

        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SetUserData()
        {
        //var dtUserInfo = Bus_NewDocRequest.GetUserInfo(userName)
        //var userPersonCode = dtUserInfo.DefaultView.Item(0).Item("PersonCode")
        //var userDepartCode = dtUserInfo.DefaultView.Item(0).Item("DepartCode")
        //var
        //var userFirstName = dtUserInfo.DefaultView.Item(0).Item("FirstName")
        //var userLastName = dtUserInfo.DefaultView.Item(0).Item("LastName")
        //var
        //var depName = dtUserInfo.DefaultView.Item(0).Item("NameVahed")
        //var userDepCode = dtUserInfo.DefaultView.Item(0).Item("DepartCode").ToString().Trim()
        //cmbDeps.SelectedValue = userDepCode
        }
    }
}