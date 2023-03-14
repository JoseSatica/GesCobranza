using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class NAsignarMasivo
    {
        public static DataTable SubirArchivoCodigoMasivo(string ip, string ruta)
        {
            DAsignarMasivo Datos = new DAsignarMasivo();
            return Datos.SubirArchivoCodigoMasivo(ip, ruta);
        }
        public static string ExisteCodigo(string codigo)
        {
            DAsignarMasivo Datos = new DAsignarMasivo();
            return Datos.ExisteCodigo(codigo);
        }

        public static DataTable EnviarMonto(string codigo)
        {
            DAsignarMasivo Datos = new DAsignarMasivo();
            return Datos.EnviarMonto(codigo);
        }
        public static DataTable EnviarCartera(int id_gestor, string codigo, int id_seguimiento, int id_estado, decimal monto)
        {
            DAsignarMasivo Datos = new DAsignarMasivo();
            return Datos.EnviarCartera(id_gestor,codigo,id_seguimiento, id_estado, monto);
        }
        public static string CambiarDeCartera(int id_gestor, int id_gestor_antiguo)
        {
            DAsignarMasivo Datos = new DAsignarMasivo();
            return Datos.CambiarDeCartera(id_gestor, id_gestor_antiguo);
        }
    }
}
