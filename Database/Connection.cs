using Amazon.Runtime.Documents;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThirdParty.Json.LitJson;

namespace Negocio
{
    public class Connection
    {
        private SqlConnection conexion = new SqlConnection("Server=EURISAQUINO;Database=BusinessAPP;Trusted_Connection=True;");

        public SqlConnection openConexion()
        {
            if (conexion.State == ConnectionState.Closed)
                conexion.Open();
            return conexion;
        }

        public SqlConnection closeConexion()
        {
            if (conexion.State == ConnectionState.Open)
                conexion.Close();
            return conexion;
        }
    }
}
