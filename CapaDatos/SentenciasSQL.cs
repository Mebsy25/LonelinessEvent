using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class SentenciasSQL:Conexion
    {
        public void RegistrarUsuario(string cod_clientes, string nombre_completo , string domicilio , int telefono)
        {
            //REGISTRARCLIENTE
            var connection = GetConnection();
            connection.Open();
            var command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "REGISTRARCLIENTE";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@cod_clientes", cod_clientes);
            command.Parameters.AddWithValue("@nombre_completo", nombre_completo);
            command.Parameters.AddWithValue("@domicilio", domicilio);
            command.Parameters.AddWithValue("@telefono", telefono);
            command.ExecuteNonQuery();
            command.Parameters.Clear();

        }
        public DataTable DataGridUsuarios()
        {
            var connection = GetConnection();
            connection.Open();
            SqlDataAdapter Cgrid = new SqlDataAdapter("ObtenerClientes", connection);
            Cgrid.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dg = new DataTable();
            Cgrid.Fill(dg);
            return dg;
        }

        public void AgregarPresentador(string rut_presentador, string apellidos, DateTime fecha_comienzo)
        {
            //REGISTRARCLIENTE
            var connection = GetConnection();
            connection.Open();
            var command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "AgregarPresentador";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@rut_presentador", rut_presentador);
            command.Parameters.AddWithValue("@apellidos", apellidos);
            command.Parameters.AddWithValue("@fecha_comienzo", fecha_comienzo);
            command.ExecuteNonQuery();
            command.Parameters.Clear();
        }
        public DataTable DataGridPresentadores()
        {
            var connection = GetConnection();
            connection.Open();
            SqlDataAdapter Cgrid = new SqlDataAdapter("ObtenerPresentadores", connection);
            Cgrid.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable presentador = new DataTable();
            Cgrid.Fill(presentador);
            return presentador;
        }

        public void AgregarDisfraz(string personaje, int precio)
        {
            //REGISTRARCLIENTE
            var connection = GetConnection();
            connection.Open();
            var command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "IngresarDisfraz";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@personaje", personaje);
            command.Parameters.AddWithValue("@precio", precio);
            command.ExecuteNonQuery();
            command.Parameters.Clear();
        }
        public DataTable DataGridDisfraz()
        {
            var connection = GetConnection();
            connection.Open();
            SqlDataAdapter Cgrid = new SqlDataAdapter("ODisfraz", connection);
            Cgrid.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable presentador = new DataTable();
            Cgrid.Fill(presentador);
            return presentador;
        }
        
        public void AgregarAnimador(string rut_animador, string apellidos, int cod_disfraz)
        {
            //REGISTRARCLIENTE
            var connection = GetConnection();
            connection.Open();
            var command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "GuardarAnimador";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@rut_animador", rut_animador);
            command.Parameters.AddWithValue("@apellidos", apellidos);
            command.Parameters.AddWithValue("@cod_disfraz", cod_disfraz);
            command.ExecuteNonQuery();
            command.Parameters.Clear();
        }

        public DataTable DataGridAnimnador()
        {
            var connection = GetConnection();
            connection.Open();
            SqlDataAdapter Cgrid = new SqlDataAdapter("CargarAnimadores", connection);
            Cgrid.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable presentador = new DataTable();
            Cgrid.Fill(presentador);
            return presentador;
        }

        public DataTable ComboDisfraz()
        {
            var connection = GetConnection();
            connection.Open();
            SqlDataAdapter Cgrid = new SqlDataAdapter("CBDisfraz", connection);
            Cgrid.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable presentador = new DataTable();
            Cgrid.Fill(presentador);
            return presentador;
        }
        public DataTable ComboPresentador()
        {
            var connection = GetConnection();
            connection.Open();
            SqlDataAdapter Cgrid = new SqlDataAdapter("CargarPresentadores", connection);
            Cgrid.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable presentador = new DataTable();
            Cgrid.Fill(presentador);
            return presentador;
        }
        public DataTable ComboAnimador()
        {
            var connection = GetConnection();
            connection.Open();
            SqlDataAdapter Cgrid = new SqlDataAdapter("CargarAnimador", connection);
            Cgrid.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable presentador = new DataTable();
            Cgrid.Fill(presentador);
            return presentador;
        }

        public void IngresarEvento(string descripcion, int valor_base, string horario, int cod_presentador, int cod_animador)
        {
            //REGISTRARCLIENTE
            var connection = GetConnection();
            connection.Open();
            var command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "IngresarEvento";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@descripcion", descripcion);
            command.Parameters.AddWithValue("@valor_base", valor_base);
            command.Parameters.AddWithValue("@horario", horario);
            command.Parameters.AddWithValue("@cod_presentador", cod_presentador);
            command.Parameters.AddWithValue("@cod_animador", cod_animador);
            command.ExecuteNonQuery();
            command.Parameters.Clear();
        }

        public void IngresarEvento2(string descripcion, int valor_base, string horario, int cod_presentador)
        {
            //REGISTRARCLIENTE
            var connection = GetConnection();
            connection.Open();
            var command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "IngresarEvento2";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@descripcion", descripcion);
            command.Parameters.AddWithValue("@valor_base", valor_base);
            command.Parameters.AddWithValue("@horario", horario);
            command.Parameters.AddWithValue("@cod_presentador", cod_presentador);
            command.ExecuteNonQuery();
            command.Parameters.Clear();
        }
        public DataTable DataGrideEventos()
        {
            var connection = GetConnection();
            connection.Open();
            SqlDataAdapter Cgrid = new SqlDataAdapter("CargarEventos", connection);
            Cgrid.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable presentador = new DataTable();
            Cgrid.Fill(presentador);
            return presentador;
        }
        public DataTable ComboBoxClientes()
        {
            var connection = GetConnection();
            connection.Open();
            SqlDataAdapter Cgrid = new SqlDataAdapter("CBCLIENTES", connection);
            Cgrid.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable presentador = new DataTable();
            Cgrid.Fill(presentador);
            return presentador;
        }
        public DataTable ComboBoxEventos()
        {
            var connection = GetConnection();
            connection.Open();
            SqlDataAdapter Cgrid = new SqlDataAdapter("CBEVENTOS", connection);
            Cgrid.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable presentador = new DataTable();
            Cgrid.Fill(presentador);
            return presentador;
        }
        public void IngresarContrato(string cod_clientes, int cod_evento, string domicilio, int valor_real, string forma_de_pago)
        {
            var connection = GetConnection();
            connection.Open();
            var command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "IngresarContrato";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@cod_clientes", cod_clientes);
            command.Parameters.AddWithValue("@cod_evento", cod_evento);
            command.Parameters.AddWithValue("@domicilio", domicilio);
            command.Parameters.AddWithValue("@valor_real", valor_real);
            command.Parameters.AddWithValue("@forma_de_pago", forma_de_pago);
            command.ExecuteNonQuery();
        }
        public DataTable ObtenerContratos()
        {
            var connection = GetConnection();
            connection.Open();
            SqlDataAdapter Cgrid = new SqlDataAdapter("ObtenerContratos", connection);
            Cgrid.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable presentador = new DataTable();
            Cgrid.Fill(presentador);
            return presentador;
        }


    }
}
