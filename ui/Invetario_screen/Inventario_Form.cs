using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Negocio.ui.Invetario_screen
{
    public partial class Inventario_Form : Form
    {
        public Inventario_Form()
        {
            InitializeComponent();
        }

        DBOperations op = new DBOperations();

        private void Inventario_Form_Load(object sender, EventArgs e)
        {
            //Funcion para mostrar los datos de la tabla en el data view
            //op.MostrarArticulos(this.businessAPPDataSet1.Articulos);

        }

        private void btnAgregarArticulos_Click(object sender, EventArgs e)
        {
            //Ocultar y mostrar forms
            AgregarForm agregarForm = new AgregarForm();
            agregarForm.Show();
        }

        private void btnActualizar_Click_1(object sender, EventArgs e)
        {
            //Ocultar y mostrar forms
            EditarForm editarForm = new EditarForm();
            editarForm.Show();
        }
    }
}
