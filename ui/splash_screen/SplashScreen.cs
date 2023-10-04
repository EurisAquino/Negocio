using Negocio.ui.login_screen;
using Negocio.ui.main_window;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Negocio
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }
        int counter;
        private void splashscreen_timer_Tick(object sender, EventArgs e)
        {
            counter++;
            if (counter >= 300)
            { 
                splashscreen_timer.Enabled = false;
                this.Hide();
                LoginScreen loginScreen = new LoginScreen();
                loginScreen.Show();
                
            }
        }
    }
}
