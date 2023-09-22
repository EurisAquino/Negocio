using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Negocio
{
    public class DBOperations
    {
        private Connection connection = new Connection();

        SqlDataReader read;
        DataTable table = new DataTable();
        SqlCommand command = new SqlCommand();

        public DataTable Show()
        {
            command.Connection = connection.openConexion();
            command.CommandText = "MostrarClientes";
            command.CommandType = CommandType.StoredProcedure;
            read = command.ExecuteReader();
            table.Load(read);
            connection.closeConexion();
            return table;
        }

        //Insertar datos en la tabla Clientes
        public void Insert(string nombres, string apellidos, string edad)
        {
            command.Connection = connection.openConexion();
            command.CommandText = "InsetarClientes";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@nombres", nombres);
            command.Parameters.AddWithValue("@apellidos", apellidos);
            command.Parameters.AddWithValue("@edad", edad);
            command.ExecuteNonQuery();
            command.Parameters.Clear();
            connection.closeConexion();
        }
        
        public void Update(string nombres, string apellidos, string edad)
        {
            command.Connection = connection.openConexion();
            command.CommandText = "EditarClientes";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@nombres", nombres);
            command.Parameters.AddWithValue("@apellidos", apellidos);
            command.Parameters.AddWithValue("@edad", edad);
            command.ExecuteNonQuery();
            command.Parameters.Clear();
            connection.closeConexion();
        }
        
        public void Delete(int idCliente)
        {
            command.Connection = connection.openConexion();
            command.CommandText = "EliminarCliente";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@idpro", idCliente);
            command.ExecuteNonQuery();
            command.Parameters.Clear();
            connection.closeConexion();
        }
    }
}
