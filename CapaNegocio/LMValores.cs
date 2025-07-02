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
    public class LMValores
    {
        //private Datos.DMValores DMValores = new Datos.DMValores();
        // Private DNotificadores As New Datos.DNotificadores
        public DataTable CargarTipoValor(ENCargo_Notificacion oEntidad, int opcion)
        {
            DMValores DMValores = new DMValores();
            return DMValores.CargarTipoValor(oEntidad, opcion);
        }

        public static DataTable CargarDatosValor(ENMValores oEntidad, int Opcion)
        {
            DMValores DMValores = new DMValores();
            return DMValores.CargarDatosValor(oEntidad, Opcion);
        }

        public static DataTable CargarDetalleValor(ENMValores oEntidad, int Opcion)
        {
            DMValores DMValores = new DMValores();
            return DMValores.CargarDetalleValor(oEntidad, Opcion);
        }
        public static DataTable ListarValores(ENMValores oEntidad, int Opcion)
        {
            DMValores DMValores = new DMValores();
            return DMValores.ListarValores(oEntidad, Opcion);
        }
        public static DataTable ListarDetalleValor(ENMValores oEntidad, int Opcion)
        {
            DMValores DMValores = new DMValores();
            return DMValores.ListarDetalleValor(oEntidad, Opcion);
        }
        public static DataTable ListarDetalleCta(ENMValores oEntidad, int Opcion)
        {
            DMValores DMValores = new DMValores();
            return DMValores.ListarDetalleCta(oEntidad, Opcion);
        }
        public static DataTable VerificarPagosValor(string codigo, string anno_valor, string tipo_rec, string periodo)
        {
            DMValores DMValores = new DMValores();
            return DMValores.VerificarPagosValor(codigo,anno_valor,tipo_rec,periodo);
        }
    }
}
