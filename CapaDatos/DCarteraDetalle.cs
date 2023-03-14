using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DCarteraDetalle
    {
        public DataTable InsertarDetalleGestion(int idcartera, int id_seguimiento,  string persona, string dni, string parentesco, string edad,string observacion,decimal monto,string fecha_por_gestionar, string uregistro, string pcregistro, string usuario)
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection Sqlcon = new SqlConnection();

            try
            {
                Sqlcon = Conexion.getInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("Gestion.GestionCartera", Sqlcon);
                comando.CommandTimeout = 3000;
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@buscar", SqlDbType.Int).Value = 4;
                comando.Parameters.Add("@id_cartera", SqlDbType.Int).Value = idcartera;
                comando.Parameters.Add("@id_seguimiento", SqlDbType.VarChar).Value = id_seguimiento;
                comando.Parameters.Add("@persona", SqlDbType.VarChar).Value = persona;
                comando.Parameters.Add("@dni", SqlDbType.VarChar).Value = dni;
                comando.Parameters.Add("@parentesco", SqlDbType.VarChar).Value = parentesco;
                comando.Parameters.Add("@edad", SqlDbType.VarChar).Value = edad;
                //comando.Parameters.Add("@fecha_pag", SqlDbType.VarChar).Value = fecha_pag;
                comando.Parameters.Add("@observacion", SqlDbType.VarChar).Value = observacion;
                comando.Parameters.Add("@monto", SqlDbType.Decimal).Value = monto;
                comando.Parameters.Add("@fecha_por_gestionar", SqlDbType.VarChar).Value = fecha_por_gestionar;
                comando.Parameters.Add("@uregistro", SqlDbType.VarChar).Value = uregistro;
                comando.Parameters.Add("@pcregistro", SqlDbType.VarChar).Value = pcregistro;
                comando.Parameters.Add("@usuario", SqlDbType.VarChar).Value = usuario;

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
        public DataTable ActualizarCarteraSeguimiento(int id_cartera, int id_seguimiento, DateTime fecha_actualizada, decimal monto, string fecha_por_gestionar)
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection Sqlcon = new SqlConnection();

            try
            {
                Sqlcon = Conexion.getInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("Gestion.GestionCartera", Sqlcon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@buscar", SqlDbType.Int).Value = 8;
                comando.Parameters.Add("@id_cartera", SqlDbType.Int).Value = id_cartera;
                comando.Parameters.Add("@id_seguimiento", SqlDbType.Int).Value = id_seguimiento;
                comando.Parameters.Add("@fecha_actualizada", SqlDbType.DateTime).Value = fecha_actualizada;
                comando.Parameters.Add("@monto", SqlDbType.Decimal).Value = monto;
                comando.Parameters.Add("@fecha_por_gestionar", SqlDbType.VarChar).Value = fecha_por_gestionar;

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

        public DataTable CargarDetalleCarteraCabecera(int id_cartera, string usuario)
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection Sqlcon = new SqlConnection();

            try
            {
                Sqlcon = Conexion.getInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("Gestion.GestionCartera", Sqlcon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@buscar", SqlDbType.Int).Value = 17;
                comando.Parameters.Add("@id_cartera", SqlDbType.Int).Value = id_cartera;
                comando.Parameters.Add("@usuario", SqlDbType.VarChar).Value = usuario;


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

        public DataTable CargarDetalleCarteraDetalle(int id_detalle_cartera)
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection Sqlcon = new SqlConnection();

            try
            {
                Sqlcon = Conexion.getInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("Gestion.GestionCartera", Sqlcon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@buscar", SqlDbType.Int).Value = 18;
                comando.Parameters.Add("@id_detalle_cartera", SqlDbType.Int).Value = id_detalle_cartera;

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
        public string ActualizarEstadoCartera(int id_estado , int id_cartera)
        {
            string Rpta = "";

            SqlConnection Sqlcon = new SqlConnection();

            try
            {
                Sqlcon = Conexion.getInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("Gestion.GestionCartera", Sqlcon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandTimeout = 2600;
                comando.Parameters.Add("@buscar", SqlDbType.Int).Value = 19;
                comando.Parameters.Add("@id_estado", SqlDbType.VarChar).Value = id_estado;
                comando.Parameters.Add("@id_cartera", SqlDbType.VarChar).Value = id_cartera;

                Sqlcon.Open();
                Rpta = comando.ExecuteNonQuery() == 1 ? "OK" : "NO SE PUDO ACTUALIZAR";

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
    }
}
