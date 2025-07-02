using System;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DReporte
    {
        public DataTable ReporteGestionCartera(string codigo, string deta_estado, string deta_seguimiento, string nombre_contri, string ap_paterno, string ap_materno, string usuario, DateTime fechaini, DateTime fechafin) // , int rowini, int rowfin
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection Sqlcon = new SqlConnection();

            try
            {
                Sqlcon = Conexion.getInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("Reports.ReporteGestionCartera", Sqlcon);
                comando.CommandTimeout = 6000;
                comando.CommandType = CommandType.StoredProcedure;
                //comando.Parameters.Add("@buscar", SqlDbType.Int).Value = 3;
                comando.Parameters.Add("@codigo", SqlDbType.VarChar).Value = codigo;
                comando.Parameters.Add("@deta_estado", SqlDbType.VarChar).Value = deta_estado;
                comando.Parameters.Add("@deta_seguimiento", SqlDbType.VarChar).Value = deta_seguimiento;
                comando.Parameters.Add("@nombre_contri", SqlDbType.VarChar).Value = nombre_contri;
                comando.Parameters.Add("@ap_paterno", SqlDbType.VarChar).Value = ap_paterno;
                comando.Parameters.Add("@ap_materno", SqlDbType.VarChar).Value = ap_materno;
                comando.Parameters.Add("@usuario", SqlDbType.VarChar).Value = usuario;
                comando.Parameters.Add("@fechaini", SqlDbType.DateTime).Value = fechaini;
                comando.Parameters.Add("@fechafin", SqlDbType.DateTime).Value = fechafin;
                //comando.Parameters.Add("@inicio", SqlDbType.Int).Value = rowini;
                //comando.Parameters.Add("@final", SqlDbType.Int).Value = rowfin;
                Sqlcon.Open();
                Resultado = comando.ExecuteReader();
                Tabla.Load(Resultado);

                return Tabla;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (Sqlcon.State == ConnectionState.Open) Sqlcon.Close();
            }
        }

        public DataTable ObtenerPlantilla(int id) // , int rowini, int rowfin
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection Sqlcon = new SqlConnection();

            try
            {
                Sqlcon = Conexion.getInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("Gestion.GestionCartera", Sqlcon);
                comando.CommandTimeout = 5000;
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@buscar", SqlDbType.Int).Value = 43;
                comando.Parameters.Add("@id_cartera", SqlDbType.Int).Value = id;

                //comando.Parameters.Add("@inicio", SqlDbType.Int).Value = rowini;
                //comando.Parameters.Add("@final", SqlDbType.Int).Value = rowfin;
                Sqlcon.Open();
                Resultado = comando.ExecuteReader();
                Tabla.Load(Resultado);

                return Tabla;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (Sqlcon.State == ConnectionState.Open) Sqlcon.Close();
            }
        }
    }
}
