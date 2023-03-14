using System;
using System.Data.SqlClient;

namespace CapaDatos
{
    class Conexion
    {
        private string Base;
        private string Servidor;
        private string Usuario;
        private string Clave;
        private bool Seguridad;
        private static Conexion con = null;

        private Conexion()
        {
            this.Base = "BASE_SIGMUN";
            this.Servidor = "192.168.3.206";   //"LAPTOP-JV0UUFQO\\SQLEXPRESS";
            this.Usuario = "sa";
            this.Clave = "Satica2023$$";
            this.Seguridad = false;

        }

        public SqlConnection CrearConexion()
        {
            SqlConnection Cadena = new SqlConnection();
            try
            {
                Cadena.ConnectionString = "Server=" + this.Servidor + "; Database=" + this.Base + ";";
                if (this.Seguridad)
                {
                    Cadena.ConnectionString = Cadena.ConnectionString + "Integrated Security = SSPI";
                }
                else
                {
                    Cadena.ConnectionString = Cadena.ConnectionString + "User Id=" + this.Usuario + "; Password=" + this.Clave + ";";
                }
            }
            catch (Exception ex)
            {
                // return null;

                throw ex;
#pragma warning disable CS0162 // Se detectó código inaccesible
                Cadena = null;
#pragma warning restore CS0162 // Se detectó código inaccesible

            }
            return Cadena;
        }
        public static Conexion getInstancia()
        {
            if (con == null)
            {
                con = new Conexion();
            }
            return con;

        }
    }
}
