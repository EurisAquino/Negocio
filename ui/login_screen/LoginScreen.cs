using Negocio.ui.main_window;
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
            //Validacion de campos
            Metodos.Metodos metodo = new Metodos.Metodos();
            var val = metodo.Validaciones(textBox1.Text, textBox2.Text);

            //Verificacion
            if (val == true)
            {
                MainWindow main = new MainWindow();
                main.Show();
                this.Close();
            }
        }
    }
}
    