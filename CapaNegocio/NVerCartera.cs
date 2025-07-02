using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio{
    public class NVerCartera{
        public static DataTable CargarComboSeguimientos(){
            DVerCartera Datos = new DVerCartera();
            return Datos.CargarComboSeguimientos();
        }
        public static DataTable CargarComboEstados(){
            DVerCartera Datos = new DVerCartera();
            return Datos.CargarComboEstados();
        }
        public static DataTable CargarDGVGestores(){
            DVerCartera Datos = new DVerCartera();
            return Datos.CargarDGVGestores();
        }
        public static DataTable CargarCartera(string usuario, int rowini, int rowfin){
            DVerCartera Datos = new DVerCartera();
            return Datos.CargarCartera(usuario,rowini,rowfin);
        }
        public static DataTable BuscarCartera(string codigo, string deta_estado, string deta_seguimiento, string nombre_contri, string ap_paterno, string ap_materno, string usuario, DateTime fechaini, DateTime fechafin, int rowini, int rowfin){
            DVerCartera Datos = new DVerCartera();
            return Datos.BuscarCartera(codigo, deta_estado, deta_seguimiento, nombre_contri, ap_paterno, ap_materno, usuario, fechaini, fechafin,rowini, rowfin);
        }
        public static string ActualizarMontoRefrescar(int id_cartera, decimal monto){
            DVerCartera Datos = new DVerCartera();
            return Datos.ActualizarMontoRefrescar(id_cartera, monto);
        }
        public static string ActualizarFechaAGestionar(int id_cartera, string fecha_a_gestionar){
            DVerCartera Datos = new DVerCartera();
            return Datos.ActualizarFechaAGestionar(id_cartera, fecha_a_gestionar);
        }
        public static DataTable MostrarProgramacion(string usuario, string fecha_por_gestionar){
            DVerCartera Datos = new DVerCartera();
            return Datos.MostrarProgramacion(usuario, fecha_por_gestionar);
        }
        public static DataTable ContadorPaginas(string codigo, string deta_estado, string deta_seguimiento, string nombre_contri, string ap_paterno, string ap_materno, string usuario, DateTime fechaini, DateTime fechafin){
            DVerCartera Datos = new DVerCartera();
            return Datos.ContadorPaginas(codigo,deta_estado,deta_seguimiento,nombre_contri,ap_paterno,ap_materno,usuario,fechaini,fechafin);
        }
        public static DataTable BuscarCarteraPorPredio(string usuario, string cod_urba, string id_via, string nro, string dpto, string mza, string lte, string sublte, int rowini, int rowfin){
            DVerCartera Datos = new DVerCartera();
            return Datos.BuscarCarteraPorPredio(usuario,  cod_urba, id_via, nro, dpto, mza, lte, sublte, rowini, rowfin);
        }
        public static DataTable BuscarCarteraPorPredioContador(string usuario, string cod_urba, string id_via, string nro, string dpto, string mza, string lte, string sublte){
            DVerCartera Datos = new DVerCartera();
            return Datos.BuscarCarteraPorPredioContador(usuario, cod_urba, id_via, nro, dpto, mza, lte, sublte);
        }
    }
}
