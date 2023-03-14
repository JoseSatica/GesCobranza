using CapaDatos;
using System;
using System.Data;

namespace CapaNegocio
{
    public class NGestion
    {
    
        public static DataTable CargarPrediosChkl(string Codigo)
        {
            DGestion Datos = new DGestion();
            return Datos.CargarPrediosChkl(Codigo);
        }
        public static DataTable CargarPeriodosChkl(string Codigo)
        {
            DGestion Datos = new DGestion();
            return Datos.CargarPeriodosChkl(Codigo);
        }
        public static DataTable CargarAnnosChkl(string Codigo)
        {
            DGestion Datos = new DGestion();
            return Datos.CargarAnnosChkl(Codigo);
        }
        public static DataTable CargarVehiculoChkl(string Codigo)
        {
            DGestion Datos = new DGestion();
            return Datos.CargarVehiculoChkl(Codigo);
        }
        public static DataTable CargarFraccChkl(string codigo)
        {
            DGestion Datos = new DGestion();
            return Datos.CargarFraccChkl(codigo);
        }

        public static DataTable CalcularDeuda(string codigo, string anios, string tipos, string tiporec, string periodo, string predio, string estado)
        {
            DGestion Datos = new DGestion();
            return Datos.CalcularDeuda(codigo, anios, tipos, tiporec, periodo, predio, estado);
        }


      
    }
}
