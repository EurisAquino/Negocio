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
            if (lbxArticulos.SelectedItem.ToString() == "" || txtCantidad.Value == 0 || txtcedularnc.Text == "" || txtITBIS.Value == 0 || txtNombre.Text == "" || txtprecioVenta.Value == 0)
            {
                MessageBox.Show("Debe rellenar todos los campos para registrar una cotizacion", "Mensaje de validacion");
            }
            else { 
                DBOperations op = new DBOperations();

                op.InsertCotizaciones(txtNombre.Text, txtcedularnc.Text, lbxArticulos.SelectedItem.ToString(), txtCantidad.Value, txtprecioVenta.Value, txtDescuento.Value, txtITBIS.Value, txtfechaCotizacion.Value, "TEST");

                txtNombre.Text = "";
                txtcedularnc.Text = "";
                txtCantidad.Value = 0;
                txtprecioVenta.Value = 0;
                txtDescuento.Value = 0;
                txtITBIS.Value = 0;
                txtfechaCotizacion.Value = DateTime.Now;
            }
        }

        private void cotizacionForm_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'businessAPPDataSet2.Cotizaciones' Puede moverla o quitarla según sea necesario.
            DBOperations op = new DBOperations();

            List<string> lista = new List<string>();

            lista = op.MostrarArts(lista);

            lbxArticulos.DataSource = lista;

            op.MostrarCotizaciones(this.businessAPPDataSet2.Cotizaciones);

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Console.WriteLine(lbxArticulos.SelectedItem.ToString());
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            DBOperations op = new DBOperations();
            this.businessAPPDataSet2.Cotizaciones.Clear();
            op.MostrarCotizaciones(this.businessAPPDataSet2.Cotizaciones);
        }
    }
}
