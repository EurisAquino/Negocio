using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Negocio.ui.main_window.Cotizacion_screen
{
    public class NumericTextBoxColumn : DataGridViewTextBoxColumn
    {
        public NumericTextBoxColumn()
        {
            this.CellTemplate = new NumericCell();
        }
    }

    public class NumericCell : DataGridViewTextBoxCell
    {
        public NumericCell()
        {
        }

        public override Type EditType
        {
            get { return typeof(NumericEditingControl); }
        }

        public override Type ValueType
        {
            get { return typeof(decimal); }
        }
    }

    class NumericEditingControl : DataGridViewTextBoxEditingControl
    {
        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            base.OnKeyPress(e);

            // Permite números, teclas de control y el símbolo "$"
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '$')
            {
                e.Handled = true;
            }
        }
    }
}
