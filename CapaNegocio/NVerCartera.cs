using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class NVerCartera
    {
        public static DataTable CargarComboSeguimientos()
        {
            DVerCartera Datos = new DVerCartera();
            return Datos.CargarComboSeguimientos();
        }
        public static DataTable CargarComboEstados()
        {
            DVerCartera Datos = new DVerCartera();
            return Datos.CargarComboEstados();
        }
        public static DataTable CargarComboGestores()
        {
            DVerCartera Datos = new DVerCartera();
            return Datos.CargarComboGestores();
        }
        public static DataTable CargarCartera(string usuario)
        {
            DVerCartera Datos = new DVerCartera();
            return Datos.CargarCartera(usuario);
        }
        public static DataTable BuscarCartera(string codigo, string deta_estado, string deta_seguimiento, string nombre_contri, string ap_paterno, string ap_materno, string usuario, DateTime fechaini, DateTime fechafin)
        {
            DVerCartera Datos = new DVerCartera();
            return Datos.BuscarCartera(codigo, deta_estado, deta_seguimiento, nombre_contri, ap_paterno, ap_materno, usuario, fechaini, fechafin);
        }
        public static string ActualizarMontoRefrescar(int id_cartera, decimal monto)
        {
            DVerCartera Datos = new DVerCartera();
            return Datos.ActualizarMontoRefrescar(id_cartera, monto);
        }
        public static string ActualizarFechaAGestionar(int id_detalle_cartera,int id_cartera, string fecha_a_gestionar)
        {
            DVerCartera Datos = new DVerCartera();
            return Datos.ActualizarFechaAGestionar(id_detalle_cartera,id_cartera, fecha_a_gestionar);
        }
    }
}
