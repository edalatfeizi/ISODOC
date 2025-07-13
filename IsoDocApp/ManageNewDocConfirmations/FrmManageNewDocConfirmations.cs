using IKIDMagfaSMSClientWin;
using IsoDoc.Domain.Dtos;
using IsoDoc.Domain.Dtos.Res;
using IsoDoc.Domain.Entities;
using IsoDoc.Domain.Enums;
using IsoDoc.Domain.Interfaces.Services;
using IsoDoc.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace IsoDocApp.ManageDocRequests
{
    public partial class FrmManageNewDocConfirmations : DevExpress.XtraEditors.XtraForm
    {
        private readonly IPersonelyService personelyService;
        private readonly IManageDocReqsService manageDocReqsService;
        private readonly IDocConfirmationService docConfirmationService;
        private readonly MagfaSMSClient smsClient;
        private List<NewDocConfirmationResDto> docConfirms = new List<NewDocConfirmationResDto>();
        private Person userInfo;
        private string userName = "";
        private bool isAdmin = false;
        public FrmManageNewDocConfirmations(IPersonelyService personelyService, IManageDocReqsService manageDocReqsService, IDocConfirmationService docConfirmationService)
        {
            InitializeComponent();
            this.personelyService = personelyService;
            this.manageDocReqsService = manageDocReqsService;
            this.docConfirmationService = docConfirmationService;
            this.smsClient = new MagfaSMSClient(Constants.SMSConfig);

        }

        private async void FrmManageNewDocConfirmations_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            userName = SystemInformation.UserName;
            if (Program.DebugMode)
                userName = "3910";

            var userPersonCode = "";
            userPersonCode = await personelyService.GetUserPersonCodeByLoginName(userName);
            userInfo = await personelyService.GetUserInfoByPersonCode(userPersonCode);

            // RibbonPage selectedPage = ribbonControl1.Pages[0];
            // ribbonControl1.SelectedPage = selectedPage;
            //if(userInfo != null)
            //GetUserDocRequests();

            if (userInfo != null && (userInfo.CardNumber == "3910" || userInfo.CodeEdare == "SI000" || userInfo.CodeEdare == "SI300" || userInfo.UpperCode == "SI300"))
            {
                tabAllRequests.Visible = true;
                tabNewDocConfirmation.Visible = true;
                //tabDeletedRequests.Visible = true;
            }

            //isAdmin = AdminTypes.GetAdminTypes().Any(x => x == ((AdminType)Convert.ToInt32(userInfo.PostTypeID)));
            //if (isAdmin || (userInfo != null && (userInfo.CardNumber == "3910" || userInfo.CodeEdare == "SI000")))
            //    tabDeletedRequests.Visible = true;
            //else
            //    tabDeletedRequests.Visible = false;
            //FilterDocRequests(new FilterDocRequests { CreatorPersonCode = userInfo.PersonCode, Active = true });

            docConfirms = await docConfirmationService.GetAllDocConfirmations();
            gridDocConfirms.DataSource = docConfirms;
        }

        private void btnAddNewConfirmDoc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var frmNewDocReq = new FrmConfirmNewDoc(personelyService, manageDocReqsService, docConfirmationService, smsClient);
            var result = frmNewDocReq.ShowDialog();
        }
    }
}