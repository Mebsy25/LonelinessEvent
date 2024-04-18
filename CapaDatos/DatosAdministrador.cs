using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DatosAdministrador:Conexion
    {
        public bool Login(string usuario, string pass)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM Administradores WHERE usuario=@usuario and pass=@pass";
                    command.Parameters.AddWithValue("@usuario", usuario);
                    command.Parameters.AddWithValue("@pass", pass);
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        //while (reader.Read())
                        //{
                        //    UserLoginCache.rut = reader.GetString(0);
                        //    UserLoginCache.nombre = reader.GetString(3);
                        //    UserLoginCache.tipo = reader.GetString(4);
                        //}
                        return true;
                    }
                    else
                        return false;

                }
            }
        }
    }
}
