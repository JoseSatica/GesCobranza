using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class NCarteraDetalle
    {
        public static DataTable InsertarDetalleGestion( int idcartera, int id_seguimiento,  string persona, string dni, string parentesco, string edad, string observacion, decimal monto, string fecha_por_gestionar, string uregistro, string pcregistro, string usuario)
        {
            DCarteraDetalle Datos = new DCarteraDetalle();
            return Datos.InsertarDetalleGestion( idcartera,id_seguimiento,persona,dni,parentesco,edad,observacion,monto,fecha_por_gestionar,uregistro,pcregistro,usuario);
        }
        public static DataTable ActualizarCarteraSeguimiento(int id_cartera, int id_seguimiento, DateTime fecha_actualizada,decimal monto, string fecha_por_gestionar)
        {
            DCarteraDetalle Datos = new DCarteraDetalle();
            return Datos.ActualizarCarteraSeguimiento(id_cartera, id_seguimiento, fecha_actualizada,monto,fecha_por_gestionar);
        }

        public static DataTable CargarDetalleCarteraCabecera(int id_cartera, string usuario)
        {
            DCarteraDetalle Datos = new DCarteraDetalle();
            return Datos.CargarDetalleCarteraCabecera(id_cartera, usuario);
        }
        public static DataTable CargarDetalleCarteraDetalle(int id_detalle_cartera)
        {
            DCarteraDetalle Datos = new DCarteraDetalle();
            return Datos.CargarDetalleCarteraDetalle(id_detalle_cartera);
        }
        public static string ActualizarEstadoCartera(int id_estado, int id_cartera)
        {
            DCarteraDetalle Datos = new DCarteraDetalle();
            return Datos.ActualizarEstadoCartera(id_estado, id_cartera);
        }
    }
}
