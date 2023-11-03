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
    public partial class crearCotizacion : Form
    {
        public crearCotizacion()
        {
            InitializeComponent();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void crearCotizacion_Load(object sender, EventArgs e)
        {
            // Crea una instancia de la columna personalizada
            NumericTextBoxColumn numericColumn1 = new NumericTextBoxColumn();
            numericColumn1.HeaderText = "Valor Unitario"; // Cambia el encabezado de la columna si es necesario
            dataCotizacion.Columns.Add(numericColumn1);
            NumericTextBoxColumn numericColumn2 = new NumericTextBoxColumn();
            numericColumn2.HeaderText = "Valor Total"; // Cambia el encabezado de la columna si es necesario
            dataCotizacion.Columns.Add(numericColumn2);
        }

        private void dataCotizacion_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4 || e.ColumnIndex == 5 && e.RowIndex >= 0)
            {
                // Obtener el valor actual de la celda
                string currentValue = dataCotizacion.Rows[e.RowIndex].Cells[e.ColumnIndex].Value as string;

                if (currentValue != null)
                {
                    // Verificar si el valor no comienza con "$" y si es numérico
                    if (!currentValue.StartsWith("$") && decimal.TryParse(currentValue, out decimal numericValue))
                    {
                        // Agregar el símbolo "$" al valor
                        dataCotizacion.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = "$" + numericValue.ToString("N2");
                    }
                }
            }
        }

        private void dataCotizacion_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0 && (e.ColumnIndex == 4 || e.ColumnIndex == 5))
            {
                if (e.Value != null && !e.Value.ToString().StartsWith("$") && decimal.TryParse(e.Value.ToString(), out decimal numericValue))
                {
                    // Formatear el valor con el símbolo "$"
                    e.Value = string.Format("${0:N2}", numericValue);
                    e.FormattingApplied = true;
                }
            }
        }

        private void txtImporte_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void txtDescuentos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void txtSubtotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void txtITBIS_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void txtTotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void txtImporte_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtImporte.Text))
            {
                if (decimal.TryParse(txtImporte.Text, out decimal numericValue))
                {
                    // Formatear el valor con ".00"
                    txtImporte.Text = string.Format("$         {0:N2}", numericValue);
                }
            }
        }

        private void txtDescuentos_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtDescuentos.Text))
            {
                if (decimal.TryParse(txtDescuentos.Text, out decimal numericValue))
                {
                    // Formatear el valor con ".00"
                    txtDescuentos.Text = string.Format("$         {0:N2}", numericValue);
                }
            }
        }

        private void txtSubtotal_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtSubtotal.Text))
            {
                if (decimal.TryParse(txtSubtotal.Text, out decimal numericValue))
                {
                    // Formatear el valor con ".00"
                    txtSubtotal.Text = string.Format("$         {0:N2}", numericValue);
                }
            }
        }

        private void txtITBIS_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtITBIS.Text))
            {
                if (decimal.TryParse(txtITBIS.Text, out decimal numericValue))
                {
                    // Formatear el valor con ".00"
                    txtITBIS.Text = string.Format("$         {0:N2}", numericValue);
                }
            }
        }

        private void txtTotal_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtTotal.Text))
            {
                if (decimal.TryParse(txtTotal.Text, out decimal numericValue))
                {
                    // Formatear el valor con ".00"
                    txtTotal.Text = string.Format("$         {0:N2}", numericValue);
                }
            }
        }
    }
}
