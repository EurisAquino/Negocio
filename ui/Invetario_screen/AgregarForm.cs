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
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Ocultar y mostrar Forms
            Inventario_Form inventario = new Inventario_Form();
            inventario.Show();
            this.Hide();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //Variable de DBOperations
            DBOperations op = new DBOperations();

            //Insertar articulo a la base de datos
            op.InsertArticulo(txtCodigo.Text.ToUpper(), txtNombre.Text.ToUpper(), ((int)numCantidad.Value), txtFamilia.Text.ToUpper(), txtUnidad.Text.ToUpper(), ((decimal)numPrecioCompra.Value), ((decimal)numMargen.Value), ((decimal)numPrecioVenta.Value), dateFecha.Value);
        }
    }
}
