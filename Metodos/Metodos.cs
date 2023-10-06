using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Negocio.Metodos
{
    internal class Metodos
    {
        //Funcion para validar los campos vacios
        public Boolean Validaciones(string user, string password) {

            //Variables
            Boolean flag = false;

            //Validacion
            if (user == "" || password == ""){
                MessageBox.Show("Usuario/Contrasaña vacio/a", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (user != "admin" || password != "admin"){
                MessageBox.Show("Usuario/contraseña Incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else{
                flag = true;
            }
            //Retorno
            if (flag == true) {
                return true;
            }
            else{
                return false;
            }
        }
    } 
}
