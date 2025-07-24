using DevExpress.XtraEditors;
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

namespace IsoDocApp.ManageNewDocConfirmations
{
    public partial class FrmAddUserSignature : DevExpress.XtraEditors.XtraForm
    {
        private readonly IPersonelyService personelyService;
        private readonly string personCode;
        public FrmAddUserSignature(IPersonelyService personelyService, string personCode)
        {
            this.personelyService = personelyService;
            this.personCode = personCode;   

            InitializeComponent();

        }
    }
}