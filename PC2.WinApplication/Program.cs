using Microsoft.Extensions.DependencyInjection;
using PC2.WinApplication.Forms;
using PC2.WinApplication.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PC2.WinApplication
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var service = ConfigureService.Collection(new ServiceCollection());
            var prov = service.BuildServiceProvider();
            var form = prov.GetRequiredService<frmPrincipal>();

            Application.Run(form);
        }
    }
}
