using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Net.PeerToPeer.Collaboration;

namespace Negocio
{
    public class DBOperations
    {
        private Connection connection = new Connection();

        SqlCommand command = new SqlCommand();

        //Llenar datos desde la tabla Articulos
        public DataTable MostrarArticulos(DataTable dt)
        {
            
            connection.openConexion();

            string sql = "EXEC MostrarArticulos;";
            SqlCommand cmd = new SqlCommand(sql, connection.openConexion());
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);

            connection.closeConexion();

            return dt;
            
        }

        public DataTable BuscarArticulos(DataTable dt, string codigoArticulo)
        {

            connection.openConexion();

            string sql = "EXEC BuscarArticulo @articulo =  '"+ codigoArticulo +"';";
            SqlCommand cmd = new SqlCommand(sql, connection.openConexion());
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);

            connection.closeConexion();

            return dt;

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

        public void InsertArticulo(string codigoArticulo, string nombreArticulo, int cantidad, string familia, string unidadMedida, decimal precioCompra, decimal margenBeneficio, decimal precioVenta, DateTime fechaCreacion)
        {
            command.Connection = connection.openConexion();
            command.CommandText = "insertarArticulos";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@codigoArticulo", codigoArticulo);
            command.Parameters.AddWithValue("@nombreArticulo", nombreArticulo);
            command.Parameters.AddWithValue("@cantidad", cantidad);
            command.Parameters.AddWithValue("@familia", familia);
            command.Parameters.AddWithValue("@unidadMedida", unidadMedida);
            command.Parameters.AddWithValue("@precioCompra", precioCompra);
            command.Parameters.AddWithValue("@margenBeneficio", margenBeneficio);
            command.Parameters.AddWithValue("@precioVenta", precioVenta);
            command.Parameters.AddWithValue("@fechaCreacion", fechaCreacion);
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
