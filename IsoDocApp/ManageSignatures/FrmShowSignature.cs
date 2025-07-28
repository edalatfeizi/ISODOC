using DevExpress.XtraEditors;
using IsoDoc.Domain.Interfaces.Services;
using IsoDoc.Domain.Models;
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
    public partial class FrmShowSignature : DevExpress.XtraEditors.XtraForm
    {
        private readonly IPersonelyService personelyService;
        private string personCode = "";
        public FrmShowSignature(IPersonelyService personelyService, string personCode)
        {
            InitializeComponent();
            this.personelyService = personelyService;
            this.personCode = personCode;
        }

        private async void FrmShowSignature_Load(object sender, EventArgs e)
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