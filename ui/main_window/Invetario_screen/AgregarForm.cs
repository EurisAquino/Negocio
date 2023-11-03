using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Negocio.ui.Invetario_screen
{
    public partial class AgregarForm : Form
    {
        public AgregarForm()
        {
            InitializeComponent();
            Inventario_Form inventario = new Inventario_Form();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Ocultar y mostrar Forms
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //Variable de DBOperations
            DBOperations op = new DBOperations();

            //Insertar articulo a la base de datos
            //  op.InsertArticulo(txtCodigo.Text.ToUpper(), txtNombre.Text.ToUpper(), txtFamilia.Text.ToUpper(), txtUnidad.Text.ToUpper(), dateFecha.Value);

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //Ocultar y mostrar Forms
            this.Close();
        }

    }
}
