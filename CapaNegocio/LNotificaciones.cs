using CapaDatos;
using CapaEntidades;
using System.Data;

namespace CapaNegocio
{
    public class LNotificaciones
    {
        public static string GrabarCargoNotificacion(ENCargo_Notificacion oentidad)
        {
            DCargoNotificacion Datos = new DCargoNotificacion();
            return Datos.GrabarCargoNotificacion(oentidad);
        }
        public static string GrabarCargo(ENCargo_Notificacion oentidad)
        {
            DCargoNotificacion Datos = new DCargoNotificacion();
            return Datos.GrabarCargo(oentidad);
        }
        public static string ActualizarCargoNotificacion(ENCargo_Notificacion oentidad)
        {
            DCargoNotificacion Datos = new DCargoNotificacion();
            return Datos.ActualizarCargoNotificacion(oentidad);
        }
        public static DataTable ListarCargoNotificacion(ENCargo_Notificacion oentidad)
        {
            DCargoNotificacion Datos = new DCargoNotificacion();
            return Datos.ListarCargoNotificacion(oentidad);
        }
    }
}
