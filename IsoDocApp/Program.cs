using DevExpress.Skins;
using DevExpress.UserSkins;
using DevExpress.XtraWaitForm;
using IKIDCSHelper.Models;
using IsoDoc.Domain.Interfaces.Repositories;
using IsoDoc.Domain.Interfaces.Services;
using IsoDoc.Domain.Services;
using IsoDoc.Infrastructure.Repositories;
using IsoDocApp.ManageDocRequests;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IsoDocApp
{
    public static class DIContainer
    {
        public static IServiceProvider ServiceProvider { get; set; }
    }
    internal static class Program
    {
        
        public static bool DebugMode
        {
            get
            {
                #if DEBUG
                    return true;
                #else
                    return false;
                #endif
            }
        }
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static async Task Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
           
            var services = new ServiceCollection();
            var isoDocCnnStr = await GetConnectionString();
            ConfigureServices(services, isoDocCnnStr);
            IServiceProvider serviceProvider = services.BuildServiceProvider();
            DIContainer.ServiceProvider = serviceProvider;
            using (serviceProvider as IDisposable)
            {
                var frmManageDocReqs = serviceProvider.GetRequiredService<FrmManageDocReqs>();
                Application.Run(frmManageDocReqs);

            }

        }

        private static void ConfigureServices(IServiceCollection services, string connStr)
        {
            //services.AddSingleton(new SqlConnection(connStr));
            services.AddScoped<IDbConnection>(sp => new SqlConnection(connStr));

            services.AddSingleton<IManageDocReqsRepository, ManageDocReqRepository>();
            services.AddSingleton<IDocRequestAttachmentsRepository, DocRequestAttachmentsRepository>();
            services.AddSingleton<IDocsRepository, DocsRepository>();

            services.AddSingleton<IManageDocReqsService, ManageDocReqsService>();
            services.AddSingleton<IDocRequestAttachmentsService, DocRequestAttachmentsService>();
            services.AddSingleton<DocsService, DocsService>();

            services.AddSingleton<FrmManageDocReqs>();
            services.AddSingleton<FrmSearch>();
            //services.AddSingleton<FrmManageAttachments>();
            //services.AddSingleton<FrmManageDocReqsFactory>(sp => () => sp.GetRequiredService<FrmManageDocReqs>());

        }
        private static async Task<string> GetConnectionString()
        {
            List<AppConnStrDto> csList = await CSHelper.CSRepo.GetConnectionStringsAsync(Program.DebugMode, "IsoDoc");
            var isoDocCnnStr = "";
            if (csList.Count > 0)
            {
                var isoDocCS = csList.Where(c => c.Key == "SQLSRV-Isodoc_New").FirstOrDefault();
                if (isoDocCS != null)
                {
                    isoDocCnnStr = isoDocCS.Value;
                }
            }
            return isoDocCnnStr;
        }
    }
}
