using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Negocio.ui.main_window.Cotizacion_screen
{
    public partial class cotizacionForm : Form
    {
        public cotizacionForm()
        {
            InitializeComponent();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            crearCotizacion crearCotizacion = new crearCotizacion();
            crearCotizacion.ShowDialog();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

        }
    }
}
