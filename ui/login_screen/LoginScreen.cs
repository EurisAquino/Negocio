using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Negocio.ui.login_screen
{
    public partial class LoginScreen : Form
    {
        public LoginScreen()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Ingrese su usuario por favor:");
            }
            else if (textBox1.Text == "admin")
            {

            }
            else
            {
                MessageBox.Show("Usuario Incorrecto","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (textBox2.Text  == "")
            {
                MessageBox.Show("Ingrese su contraseña por favor:");
            }
            else if (textBox2.Text == "admin")
            {
                
            }
            else
            {
                MessageBox.Show("Contraseña Incorrecta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }

}
    