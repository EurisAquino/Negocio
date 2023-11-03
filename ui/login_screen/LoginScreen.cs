using Negocio.ui.main_window;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

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
                main.ShowDialog();
                this.Close();
            }
        }
    }
}
    