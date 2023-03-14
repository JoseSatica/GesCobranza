using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DMantenimiento
    {
        public DataTable CargarComboUsuario()
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection Sqlcon = new SqlConnection();

            try
            {
                Sqlcon = Conexion.getInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("Gestion.GestionCartera", Sqlcon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandTimeout = 2600;
                comando.Parameters.Add("@buscar", SqlDbType.Int).Value = 13;
                
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
        public string AgregarTablaGestor(string id_usuario)
        {
            string Rpta = "";

            SqlConnection Sqlcon = new SqlConnection();

            try
            {
                Sqlcon = Conexion.getInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("Gestion.GestionCartera", Sqlcon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandTimeout = 2600;
                comando.Parameters.Add("@buscar", SqlDbType.Int).Value = 14;
                comando.Parameters.Add("@id_usuario", SqlDbType.VarChar).Value = id_usuario;

                Sqlcon.Open();
                Rpta = comando.ExecuteNonQuery() >= 1 ? "OK" : "NO SE PUDO ACTUALIZAR";

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
        public string DarQuitarPermiso(string permiso, int id_gestor)
        {
            string Rpta = "";

            SqlConnection Sqlcon = new SqlConnection();

            try
            {
                Sqlcon = Conexion.getInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("Gestion.GestionCartera", Sqlcon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandTimeout = 2600;
                comando.Parameters.Add("@buscar", SqlDbType.Int).Value = 15;
                comando.Parameters.Add("@permiso", SqlDbType.VarChar).Value = permiso;
                comando.Parameters.Add("@id_gestor", SqlDbType.Int).Value = id_gestor;

                Sqlcon.Open();
                Rpta = comando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo actualizar ";

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
        public string EliminarTablaGestor(string id_usuario)
        {
            string Rpta = "";

            SqlConnection Sqlcon = new SqlConnection();

            try
            {
                Sqlcon = Conexion.getInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("Gestion.GestionCartera", Sqlcon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandTimeout = 2600;
                comando.Parameters.Add("@buscar", SqlDbType.Int).Value = 21;
                comando.Parameters.Add("@id_usuario", SqlDbType.VarChar).Value = id_usuario;

                Sqlcon.Open();
                Rpta = comando.ExecuteNonQuery() >= 1 ? "OK" : "NO SE PUDO ACTUALIZAR";

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
        public DataTable CargarUsuariosCobranzas()
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection Sqlcon = new SqlConnection();

            try
            {
                Sqlcon = Conexion.getInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("Gestion.GestionCartera", Sqlcon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandTimeout = 2600;
                comando.Parameters.Add("@buscar", SqlDbType.Int).Value = 22;

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
