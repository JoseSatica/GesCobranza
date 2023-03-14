using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DAsignarMasivo
    {
        public DataTable SubirArchivoCodigoMasivo(string ip, string ruta)
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection Sqlcon = new SqlConnection();

            try
            {
                Sqlcon = Conexion.getInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("Gestion.GestionCartera", Sqlcon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@buscar", SqlDbType.Int).Value = 9;
                comando.Parameters.Add("@ip", SqlDbType.Char).Value = ip;
                comando.Parameters.Add("@ruta", SqlDbType.Char).Value = ruta;
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
        public string ExisteCodigo(string Codigo)
        {
            string Rpta = "";

            SqlConnection Sqlcon = new SqlConnection();

            try
            {
                Sqlcon = Conexion.getInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("Gestion.GestionCartera", Sqlcon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandTimeout = 300;
                comando.Parameters.Add("@buscar", SqlDbType.Int).Value = 10;
                comando.Parameters.Add("@codigo", SqlDbType.Char).Value = Codigo;
                SqlParameter parExiste = new SqlParameter();
                parExiste.ParameterName = "@existe";
                parExiste.SqlDbType = SqlDbType.Int;
                parExiste.Direction = ParameterDirection.Output;
                comando.Parameters.Add(parExiste);
                Sqlcon.Open();
                comando.ExecuteNonQuery();
                Rpta = Convert.ToString(parExiste.Value);

            }
            catch (Exception ex)
            {
                Rpta = ex.Message;
            }
            finally
            {
                if (Sqlcon.State == ConnectionState.Open) Sqlcon.Close();
            }
            return Rpta;
        }
        public DataTable EnviarMonto(string codigo)
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection Sqlcon = new SqlConnection();

            try
            {
                Sqlcon = Conexion.getInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("Gestion.GestionCartera", Sqlcon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandTimeout = 5000;
                comando.Parameters.Add("@buscar", SqlDbType.VarChar).Value = 11;
                comando.Parameters.Add("@codigo", SqlDbType.VarChar).Value = codigo;                

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
        public DataTable EnviarCartera(int id_gestor, string codigo, int id_seguimiento, int id_estado, decimal monto )
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection Sqlcon = new SqlConnection();

            try
            {
                Sqlcon = Conexion.getInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("Gestion.GestionCartera", Sqlcon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandTimeout = 3600;
                comando.Parameters.Add("@buscar", SqlDbType.Int).Value = 12;
                comando.Parameters.Add("@id_gestor", SqlDbType.Int).Value = id_gestor;
                comando.Parameters.Add("@codigo", SqlDbType.VarChar).Value = codigo;
                comando.Parameters.Add("@id_seguimiento", SqlDbType.Int).Value = id_seguimiento;
                comando.Parameters.Add("@id_estado", SqlDbType.Int).Value = id_estado;
                comando.Parameters.Add("@monto", SqlDbType.Decimal).Value = monto;

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
        public string CambiarDeCartera(int id_gestor, int id_gestor_antiguo)
        {
            string Rpta = "";

            SqlConnection Sqlcon = new SqlConnection();

            try
            {
                Sqlcon = Conexion.getInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("Gestion.GestionCartera", Sqlcon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandTimeout = 300;
                comando.Parameters.Add("@buscar", SqlDbType.Int).Value = 23;
                comando.Parameters.Add("@id_gestor", SqlDbType.Int).Value = id_gestor;
                comando.Parameters.Add("@id_gestor_antiguo", SqlDbType.Int).Value = id_gestor_antiguo;

                Sqlcon.Open();
                Rpta = comando.ExecuteNonQuery() >= 1 ? "OK" : "NO SE PUDO ACTUALIZAR";
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (Sqlcon.State == ConnectionState.Open) Sqlcon.Close();
            }
            return Rpta;
        }
    }
}
