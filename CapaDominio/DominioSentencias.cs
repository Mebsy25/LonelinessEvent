using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaDominio
{
    public class DominioSentencias
    {
        SentenciasSQL sentencias = new SentenciasSQL();

        public void RegistrarUsuario(string cod_clientes, string nombre_completo, string domicilio, int telefono)
        {
            sentencias.RegistrarUsuario(cod_clientes, nombre_completo, domicilio ,telefono);
        }
        public DataTable DataGridUsuarios()
        {
            return sentencias.DataGridUsuarios();
        }


    }
}
