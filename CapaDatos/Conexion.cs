using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Data.SqlClient;
using System.Threading.Tasks;

namespace CapaDatos
{
    public abstract class Conexion
    {
        private readonly string connectionString;
        public Conexion()
        {
            connectionString = @"Server=.\SQLEXPRESS;Database=loneliness_events;Integrated Security=True;TrustServerCertificate = True";
        }

        protected SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
