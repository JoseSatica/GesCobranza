using CapaDatos;
using System;
using System.Data;

namespace CapaNegocio
{
    public class NReporte
    {
        public static DataTable ReporteGestionCartera(string codigo, string deta_estado, string deta_seguimiento, string nombre_contri, string ap_paterno, string ap_materno, string usuario, DateTime fechaini, DateTime fechafin)
        {
            DReporte Datos = new DReporte();
            return Datos.ReporteGestionCartera(codigo, deta_estado, deta_seguimiento, nombre_contri, ap_paterno, ap_materno, usuario, fechaini, fechafin);
        }
        public static DataTable ObtenerPlantilla(int id)
        {
            DReporte Datos = new DReporte();
            return Datos.ObtenerPlantilla(id);
        }
    }
}
