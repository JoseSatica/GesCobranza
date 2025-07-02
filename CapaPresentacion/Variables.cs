using System;
using System.Data;

namespace CapaPresentacion
{
    public class Variables
    {
        ///------- VARIABLES DEL LOGIN ------------------
        public static string tipo_usuario;
        public static string nom_usuario;
        public static string area_usuario;
        public static string id_usuario;
        public static string cod_usuario;
        public static string usuario;

        ///------- VARIABLES DEL FRMCARTERA --------------
        public static string codigo;
        public static string nombre_contri;
        public static int id_cartera;

        ///------- VARIABLES DEL FRMVERCARTERA -----------
        public static string deta_seguimiento;
        public static string deta_estado;
        public static string ap_paterno;
        public static string ap_materno;
        public static DateTime fechaini;
        public static DateTime fechafin;
        public static string dni;
        public static string monto;
        public static string gestor;
        public static int id_gestor;
        public static string fecha_por_gestionar;


        ///------- VARIABLES DEL FRMCARTERADETALLE -------
        public static int id_detalle_cartera;
        public static int id_seguimiento;
        public static int id_estado;

        //------- VARIABLES ENTIDAD-------------------
        public static string id_valor;
        public static string num_valor;
        public static string ano_valor;
        public static string num_cargo;
        public static string ano_cargo;

        //------TAMAÑO PANEL_____________
        public static string tamaño_panel;
        public static int height_panel;
        public static int withd_panel;

        //------ TABLA DE ENVIO A LEGAL-------
        public static DataTable envio_legal;
        public static int id_lotec;
        public static string lote_nombre;


    }
}
