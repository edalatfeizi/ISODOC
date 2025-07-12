using DevExpress.XtraEditors;
using IKIDMagfaSMSClientWin;
using IsoDoc.Domain.Interfaces.Services;
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
    public partial class FrmManageNewDocConfirmations : DevExpress.XtraEditors.XtraForm
    {
        private readonly IPersonelyService personelyService;
        private readonly IManageDocReqsService manageDocReqsService;
        private readonly IDocConfirmationService docConfirmationService;
        public FrmManageNewDocConfirmations(IPersonelyService personelyService, IManageDocReqsService manageDocReqsService, IDocConfirmationService docConfirmationService)
        {
            InitializeComponent();
            this.personelyService = personelyService;
            this.manageDocReqsService = manageDocReqsService;
            this.docConfirmationService = docConfirmationService;
        }

        private void FrmManageNewDocConfirmations_Load(object sender, EventArgs e)
        {

        }
    }
}