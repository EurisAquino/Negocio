using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Negocio.ui.main_window.usuarios_screen
{
    public partial class usuarioForm : Form
    {
        public usuarioForm()
        {
            InitializeComponent();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {
            agregarUsuario agregarUsuario = new agregarUsuario();
            agregarUsuario.Show();
        }

        private void btnModificarUsuario_Click(object sender, EventArgs e)
        {
           modificarUsuario modificarUsuario = new modificarUsuario();
            modificarUsuario.Show();

        }
    }
}
