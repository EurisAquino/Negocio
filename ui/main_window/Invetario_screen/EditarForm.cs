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
            }
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

    }
}
