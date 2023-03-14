using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocio
{
    public class NVerIngresoPorGestor
    {
        public static DataTable VerIngresoPorGestor(string usuario, DateTime fechaini, DateTime fechafin)
        {
            DIngresoPorGestor Datos = new DIngresoPorGestor();
            return Datos.VerIngresoPorGestor(usuario, fechaini, fechafin);
        }
    }
}
