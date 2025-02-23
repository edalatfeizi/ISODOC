using IsoDoc.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IsoDocApp
{
    public partial class FrmManageDocReqs : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private readonly IManageDocReqsService manageDocReqsService;

        public FrmManageDocReqs(IManageDocReqsService manageDocReqsService)
        {
            this.manageDocReqsService = manageDocReqsService;   
            InitializeComponent();

            Console.WriteLine(manageDocReqsService.GetAll());
        }
    }
}
