using Negocio.ui.main_window;
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

        private void btnInsertarMercancia_Click(object sender, EventArgs e)
        {
            //Ocultar y mostrar forms
            InsertarForm insertarForm = new InsertarForm();
            insertarForm.Show();
        }

        private void btnDesactivar_Click(object sender, EventArgs e)
        {
            //Ocultar y mostrar forms
            DesactivarForm desactivarForm = new DesactivarForm();
            desactivarForm.Show();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void Inventario_Form_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (e.CloseReason == CloseReason.UserClosing)
            {
                // Cierra todos los formularios abiertos
                foreach (Form form in Application.OpenForms)
                {
                    if (form != this) // Evita cerrar el formulario actual (Form2)
                    {
                        form.Close();
                    }
                }

                Application.Exit(); // Cierra la aplicación
            }
        }
    }
}
