using Negocio.ui.Invetario_screen;
using Negocio.ui.login_screen;
using Negocio.ui.main_window;
using Negocio.ui.main_window.Cotizacion_screen;
using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThirdParty.Json.LitJson;

namespace Negocio
{
    internal static class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new crearCotizacion());
            
        }   
    }
}
