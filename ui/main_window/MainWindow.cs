using Negocio.ui.Invetario_screen;
using Negocio.ui.main_window.Cotizacion_screen;
using Negocio.ui.main_window.usuarios_screen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Negocio.ui.main_window
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {

            Inventario_Form inventario = new Inventario_Form();
            inventario.ShowDialog();

        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            usuarioForm usuarioForm = new usuarioForm();
            usuarioForm.ShowDialog();
        }

        private void btnCotizaciones_Click(object sender, EventArgs e)
        {
            cotizacionForm cotizacionForm = new cotizacionForm();
            cotizacionForm.ShowDialog();
   
        }
    }
}
