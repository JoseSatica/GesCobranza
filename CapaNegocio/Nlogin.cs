using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidades;


namespace CapaNegocio
{
    public class Nlogin
    {
        public static DataTable Login (string usuario, string password)
        {
            DLogin Datos = new DLogin();
            return Datos.Login(usuario, password);
        }
        
    }
}
