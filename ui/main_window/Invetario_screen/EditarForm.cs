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
    public partial class EditarForm : Form
    {
        public EditarForm()
        {
            InitializeComponent();
        }

        private void EditarForm_Load(object sender, EventArgs e)
        {
            //Nada por ahora
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            DBOperations op = new DBOperations();
            this.businessAPPDataSet1.Articulos.Clear();
            op.BuscarArticulos(this.businessAPPDataSet1.Articulos, txtCodigoArticulo.Text);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            for (int i = 0; i < this.businessAPPDataSet1.Articulos.Rows.Count; i++)
            {
                txtCodArticulo.Text = this.businessAPPDataSet1.Articulos.Rows[i]["codigoArticulo"].ToString();
                txtNombreArticulo.Text = this.businessAPPDataSet1.Articulos.Rows[i]["nombreArticulo"].ToString();
                txtCantidad.Text = this.businessAPPDataSet1.Articulos.Rows[i]["cantidad"].ToString();
                txtFamilia.Text = this.businessAPPDataSet1.Articulos.Rows[i]["familia"].ToString();
                txtUnidadMedida.Text = this.businessAPPDataSet1.Articulos.Rows[i]["unidadMedida"].ToString();
                txtPrecioCompra.Text = this.businessAPPDataSet1.Articulos.Rows[i]["precioCompra"].ToString();
                txtMargenBenificio.Text = this.businessAPPDataSet1.Articulos.Rows[i]["margenBeneficio"].ToString();
                txtPrecioVenta.Text = this.businessAPPDataSet1.Articulos.Rows[i]["precioVenta"].ToString();
                txtFechaCreacion.Text = this.businessAPPDataSet1.Articulos.Rows[i]["fechaCreacion"].ToString();
            }
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            DBOperations op = new DBOperations();
            op.EditarArticulos(txtCodArticulo.Text, txtNombreArticulo.Text, Convert.ToInt16(txtCantidad.Text), txtFamilia.Text, txtUnidadMedida.Text, Convert.ToDecimal(txtPrecioCompra.Text), Convert.ToDecimal(txtMargenBenificio.Text), Convert.ToDecimal(txtPrecioVenta.Text), Convert.ToDateTime(txtFechaCreacion.Text));
            txtCodArticulo.Text = "";
            txtNombreArticulo.Text = "";
            txtCantidad.Text = "";
            txtFamilia.Text = "";
            txtUnidadMedida.Text = "";
            txtPrecioCompra.Text = "";
            txtMargenBenificio.Text = "";
            txtPrecioVenta.Text = "";
            txtFechaCreacion.Text = "";
        }
    }
}
