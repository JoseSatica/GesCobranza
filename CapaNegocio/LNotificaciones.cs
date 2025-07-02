using CapaDatos;
using CapaEntidades;
using System;
using System.Data;

namespace CapaNegocio
{
    public class LNotificaciones
    {
        public static string GrabarCargoNotificacion(ENCargo_Notificacion oentidad, int Opcion)
        {
            DCargoNotificacion Datos = new DCargoNotificacion();
            return Datos.GrabarCargoNotificacion(oentidad, Opcion);
        }
        public static string GrabarCargo(ENCargo_Notificacion oentidad)
        {
            DCargoNotificacion Datos = new DCargoNotificacion();
            return Datos.GrabarCargo(oentidad);
        }
        public static string ActualizarCargoNotificacion(ENCargo_Notificacion oentidad, int Opcion)
        {
            DCargoNotificacion Datos = new DCargoNotificacion();
            return Datos.ActualizarCargoNotificacion(oentidad, Opcion);
        }
        public static DataTable ListarCargoNotificacion(ENCargo_Notificacion oentidad, int Opcion)
        {
            DCargoNotificacion Datos = new DCargoNotificacion();
            return Datos.ListarCargoNotificacion(oentidad,Opcion);
        }
        public static DataTable listado_notificacion( int Opcion)
        {
            DCargoNotificacion Datos = new DCargoNotificacion();
            return Datos.listado_notificacion( Opcion);
        }
        public static DataTable print_notificacion(int Opcion, DateTime desde, DateTime hasta)
        {
            DCargoNotificacion Datos = new DCargoNotificacion();
            return Datos.print_notificacion(Opcion, desde,hasta);
        }       
        public static string anular_notificacion(ENCargo_Notificacion oEntidad, int Opcion)
        {
            DCargoNotificacion Datos = new DCargoNotificacion();
            return Datos.anular_notificacion(oEntidad, Opcion);
        }
        public static DataTable Dias_Habiles(DateTime desde, DateTime hasta)
        {
            DCargoNotificacion Datos = new DCargoNotificacion();
            return Datos.Dias_Habiles(desde, hasta);
        }
        public static DataTable ValidarRG(string nro_res, string anno_res)
        {
            DCargoNotificacion Datos = new DCargoNotificacion();
            return Datos.ValidarRG(nro_res, anno_res);
        }
        public static DataTable InsertarCabeceraLote(string info_coactivo,string num_lote, string anno_lote, string uregistro, string pcregistro)
        {
            DCargoNotificacion Datos = new DCargoNotificacion();
            return Datos.InsertarCabeceraLote(info_coactivo,num_lote,anno_lote, uregistro, pcregistro);
        }
        public static DataTable InsertarDetalleLote(int id_nuevo_lote, int id_tbl, string estado_lote, string obsv_lote, string num_tramite_lote)
        {
            DCargoNotificacion Datos = new DCargoNotificacion();
            return Datos.InsertarDetalleLote(id_nuevo_lote, id_tbl, estado_lote, obsv_lote, num_tramite_lote);
        }
        public static DataTable InsertarMovimientoLote(int id_nuevo_lote, int esta_movi, string remitente, string destinatario, DateTime fecha_actulizacion)
        {
            DCargoNotificacion Datos = new DCargoNotificacion();
            return Datos.InsertarMovimientoLote(id_nuevo_lote, esta_movi, remitente, destinatario, fecha_actulizacion);
        }
        public static string ActualizarEstadoCargo(int id_tbl, string estado_cargo)
        {
            DCargoNotificacion Datos = new DCargoNotificacion();
            return Datos.ActualizarEstadoCargo(id_tbl,estado_cargo);
        }
        public static DataTable MostrarBandejaLegal()
        {
            DCargoNotificacion Datos = new DCargoNotificacion();
            return Datos.MostrarBandejaLegal();
        }
        public static DataTable MostrarDetalleLote(int id_lotec)
        {
            DCargoNotificacion Datos = new DCargoNotificacion();
            return Datos.MostrarDetalleLote(id_lotec);
        }
        public static string AnularCargoLote(int id_loted)
        {
            DCargoNotificacion Datos = new DCargoNotificacion();
            return Datos.AnularCargoLote(id_loted);
        }
        public static  DataTable CargarComboEstadoLote()
        {
            DCargoNotificacion Datos = new DCargoNotificacion();
            return Datos.CargarComboEstadoLote();
        }
        public static DataTable BuscarLotes(string area_destinatario,string num_lote, string anno_lote, string estado_detalle, string documento, DateTime fechaini, DateTime fechafin, int rowini, int rowfin)
        {
            DCargoNotificacion Datos = new DCargoNotificacion();
            return Datos.BuscarLotes(area_destinatario,num_lote, anno_lote,estado_detalle,documento,fechaini,fechafin,rowini,rowfin);
        }
        public static DataTable BuscarLotesContador(string area_destinatario,string num_lote, string anno_lote, string estado_detalle, string documento, DateTime fechaini, DateTime fechafin)
        {
            DCargoNotificacion Datos = new DCargoNotificacion();
            return Datos.BuscarLotesContador(area_destinatario, num_lote, anno_lote, estado_detalle, documento, fechaini, fechafin);
        }
        public static string ActualizarEstadoBandeja(int id_estado, int id_lote_movi)
        {
            DCargoNotificacion Datos = new DCargoNotificacion();
            return Datos.ActualizarEstadoBandeja(id_estado,id_lote_movi);
        }

    }
}
