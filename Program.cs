using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Bson;
using MongoDB.Driver;
using ThirdParty.Json.LitJson;

namespace Negocio
{
    internal static class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            var connection = new Connection();

            var json = new BsonDocument {
                { "client_ID", 00002 },
                { "Nombre","Frandy" },
                { "Apellidos","Aquino Ulloa" },
                { "Telefono","8298389495" },
                { "Sexo","Masculino" },
                { "Correo","frandi13@gmail.com" },
                { "Lugar Nacimiento","Republica Dominicana" },
                { "Direccion","Ensanche Isabelita" }
                };

            connection.insertData(json);
            
        }   
    }
}
