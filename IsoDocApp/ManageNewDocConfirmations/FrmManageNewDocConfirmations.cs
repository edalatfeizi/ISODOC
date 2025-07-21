using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraGrid.Columns;
using IKIDMagfaSMSClientWin;
using IsoDoc.Domain.Dtos;
using IsoDoc.Domain.Dtos.Res;
using IsoDoc.Domain.Entities;
using IsoDoc.Domain.Enums;
using IsoDoc.Domain.Interfaces.Services;
using IsoDoc.Domain.Models;
using IsoDocApp.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
        private List<DocSignerResDto> docSigners = new List<DocSignerResDto>();
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

            docConfirms = await docConfirmationService.GetUserDocConfirmationsAsync(userPersonCode);
            gridDocConfirms.DataSource = docConfirms;

            gridView1.Columns["Id"].BestFit();
            //gridView1.Columns["ReviewNo"].BestFit();
            gridView1.Columns["DocCode"].BestFit();
            //gridView1.Columns["DocTitle"].BestFit();
            //gridView1.Columns["ReviewText"].BestFit();



        }
        private void ShowProgressBar(bool visibility)
        {
            loading.Visible = visibility;
        }
        private void btnAddNewConfirmDoc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }

        private void ribbonControl1_SelectedPageChanged(object sender, EventArgs e)
        {
            GetDocConfirmations();
        }
        private async void GetDocConfirmations()
        {
            RibbonPage selectedPage = ribbonControl1.SelectedPage;
            if (selectedPage != null)
            {
                //docReqSteps.Items.Clear();
                gridDocConfirms.DataSource = null;
                // Check which page was clicked using the Name or Text property
                switch (selectedPage.Name)
                {
                    case "tabReceivedRequests":
                        if (userInfo != null)
                        {
                            // docReqSteps.Items.Clear();
                            ShowProgressBar(true);
                            docConfirms = await docConfirmationService.GetUserDocConfirmationsAsync(userInfo.PersonCode);
                            gridDocConfirms.DataSource = docConfirms;

                            btnForwardDocReq.Enabled = true;
                            btnAddAttachment.Enabled = true;

                            ShowDocConfirmations(true);
                            ShowProgressBar(false);

                        }

                        break;
                    case "tabAllRequests":
                        if (userInfo != null)
                        {
                            //docReqSteps.Items.Clear();
                            ShowProgressBar(true);

                            docConfirms = await docConfirmationService.GetAllDocConfirmationsAsync();
                            gridDocConfirms.DataSource = docConfirms;
                            btnForwardDocReq.Enabled = false;
                            btnAddAttachment.Enabled = false;

                            ShowDocConfirmations(true);
                            ShowProgressBar(false);

                        }

                        break;
                    case "tabNewDocConfirmation":
                        ShowDocConfirmations(false);
                        break;

                }
            }
        }

        private void ShowDocConfirmations(bool visibility)
        {
            gridDocConfirms.Visible = visibility;
            panelStates.Visible = visibility;
            panelOperations.Visible = visibility;
            confirmationSigners.Visible = visibility;
        }

        private async void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            int rowHandle = gridView1.FocusedRowHandle;
            if (rowHandle >= 0)
            {
                var idValue = gridView1.GetRowCellValue(rowHandle, "Id");
                var docConfirmId = idValue != null ? int.Parse(idValue.ToString()) : 0;
                var docConfirm = docConfirms.Where(x => x.Id == docConfirmId).FirstOrDefault();


                await GetDocConfirmSigners(docConfirmId);
                //var attachment = GridViewHelper.GetGridViewCellValue(gridView1, "HasAttachments");
                //var hasAttachments = attachment != null ? attachment.ToString() : null;
                //if (!string.IsNullOrEmpty(hasAttachments) && hasAttachments.ToString() == "دارد")
                //    btnShowAttachments.Enabled = true;
                //else
                //    btnShowAttachments.Enabled = false;

            }
        }

        private async Task<bool> GetDocConfirmSigners(int docConfirmId)
        {
            ShowProgressBar(true);
            confirmationSigners.Items.Clear();
            docSigners = await docConfirmationService.GetDocConfirmationSignersAsync(docConfirmId);

            var steps = await StepsProgressBarHelper.GetDocConfirmationSignersSteps(docSigners);
            foreach (var step in steps)
            {
                confirmationSigners.Items.Add(step);
            }

            ShowProgressBar(false);
            return true;
        }
    }
}