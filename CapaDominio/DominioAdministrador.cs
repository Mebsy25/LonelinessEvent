using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaDominio
{
    public class DominioAdministrador
    {
        DatosAdministrador datosAdmin = new DatosAdministrador();
        public bool LoginUser(string usuario, string pass)
        {
            return datosAdmin.Login(usuario, pass);
        }
    }
}
