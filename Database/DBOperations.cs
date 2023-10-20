using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Net.PeerToPeer.Collaboration;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using System.Text.RegularExpressions;
using System.Windows.Controls;

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

        public List<string> MostrarArts(List<string> list)
        {
            SqlCommand cmd = new SqlCommand("SELECT nombreArticulo FROM Articulos", connection.openConexion());

            connection.openConexion();

            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while(dr.Read())
                {
                    list.Add(dr.GetString(0));
                }
            }
            connection.closeConexion();

            return list;
        }

        public void  EditarArticulos(string codigoArticulo, string nombreArticulo, int cantidad, string familia, string unidadMedida, decimal precioCompra, decimal margenBeneficio, decimal precioVenta, DateTime fechaCreacion)
        {

            connection.openConexion();

            string date = fechaCreacion.ToString();
            date = date.Replace("a.", "A");
            date = date.Replace("m.", "M");
            date = date.Replace("p.", "P");

            date = Regex.Replace(date, @"\sA\sM", " AM");
            date = Regex.Replace(date, @"\sP\sM", " PM");

            command.Connection = connection.openConexion();
            command.CommandText = "EditarArticulos";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@codigoArticulo", codigoArticulo);
            command.Parameters.AddWithValue("@nombreArticulo", nombreArticulo);
            command.Parameters.AddWithValue("@cantidad", cantidad);
            command.Parameters.AddWithValue("@familia", familia);
            command.Parameters.AddWithValue("@unidadMedida", unidadMedida);
            command.Parameters.AddWithValue("@precioCompra", precioCompra);
            command.Parameters.AddWithValue("@margenBeneficio", margenBeneficio);
            command.Parameters.AddWithValue("@precioVenta", precioVenta);
            command.Parameters.AddWithValue("@fechaCreacion", Convert.ToDateTime(date));
            command.ExecuteNonQuery();
            command.Parameters.Clear();
            connection.closeConexion();

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

        //Insertar cotizaciones
        public void InsertCotizaciones(string nombre, string cedularnc, string articulo, decimal cantidad, decimal precioVenta, decimal descuento, decimal itbis, DateTime fechaCotizacion, string @codigoCotizacion)
        {
            command.Connection = connection.openConexion();
            command.CommandText = "InsertarCotizaciones";
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@nombre", nombre);
            command.Parameters.AddWithValue("@cedularnc", cedularnc);
            command.Parameters.AddWithValue("@articulo", articulo);
            command.Parameters.AddWithValue("@cantidad", cantidad);
            command.Parameters.AddWithValue("@precioVenta", precioVenta);
            command.Parameters.AddWithValue("@descuento", descuento);
            command.Parameters.AddWithValue("@itbis", itbis);
            command.Parameters.AddWithValue("@fechaCotizacion", fechaCotizacion);
            command.Parameters.AddWithValue("@codigoCotizacion", codigoCotizacion);

            command.ExecuteNonQuery();
            command.Parameters.Clear();
            connection.closeConexion();
        }

        public DataTable MostrarCotizaciones(DataTable dt)
        {

            connection.openConexion();

            string sql = "EXEC MostrarCotizaciones;";
            SqlCommand cmd = new SqlCommand(sql, connection.openConexion());
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);

            connection.closeConexion();

            return dt;

        }
    }
}
