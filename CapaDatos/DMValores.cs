using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidades;

namespace CapaDatos
{
    public class DMValores
    {
       
        public DataTable CargarTipoValor(ENCargo_Notificacion oEntidad, int Opcion)
        {
            // no va dice le ing
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection Sqlcon = new SqlConnection();
                          
            try
            {
                Sqlcon = Conexion.getInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("rentas.pa_dvalores", Sqlcon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@busc", SqlDbType.Int).Value = Opcion;


                Sqlcon.Open();
                Resultado = comando.ExecuteReader();
                Tabla.Load(Resultado);

                return Tabla;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex}");
                throw ex;
            }
            finally
            {
                if (Sqlcon.State == ConnectionState.Open) Sqlcon.Close();
            }
        }
        public DataTable CargarDatosValor(ENMValores oentidad, int Opcion)
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection Sqlcon = new SqlConnection();
            
            try
            {
                Sqlcon = Conexion.getInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("[Rentas].[sp_mvalores]", Sqlcon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@msquery", SqlDbType.Int).Value = Opcion;
                comando.Parameters.Add("@id_valor", SqlDbType.VarChar).Value = oentidad.ID_VALOR;
                comando.Parameters.Add("@ano_val", SqlDbType.VarChar).Value = oentidad.ANO_VAL;
                comando.Parameters.Add("@num_val", SqlDbType.VarChar).Value = oentidad.NUM_VAL;

                Sqlcon.Open();
                Resultado = comando.ExecuteReader();
                Tabla.Load(Resultado);
                return Tabla;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex}");
                throw ex;
            }
            finally
            {
                if (Sqlcon.State == ConnectionState.Open) Sqlcon.Close();
            }

            //return default;
        }

        public DataTable CargarDetalleValor(ENMValores oentidad, int Opcion)
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection Sqlcon = new SqlConnection();

            try
            {
                Sqlcon = Conexion.getInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("[Rentas].[sp_dvalores]", Sqlcon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@msquery", SqlDbType.Int).Value = Opcion;
                comando.Parameters.Add("@id_valor", SqlDbType.VarChar).Value = oentidad.ID_VALOR;
                comando.Parameters.Add("@ano_val", SqlDbType.VarChar).Value = oentidad.ANO_VAL;
                comando.Parameters.Add("@num_val", SqlDbType.VarChar).Value = oentidad.NUM_VAL;

                Sqlcon.Open();
                Resultado = comando.ExecuteReader();
                Tabla.Load(Resultado);
                return Tabla;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex}");
                throw ex;
            }
            finally
            {
                if (Sqlcon.State == ConnectionState.Open) Sqlcon.Close();
            }

           
        }

        public DataTable ListarValores(ENMValores oentidad, int Opcion)
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection Sqlcon = new SqlConnection();

            try
            {
                Sqlcon = Conexion.getInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("Rentas.SP_Consultadocu", Sqlcon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@msquery", SqlDbType.Int).Value = Opcion;
                comando.Parameters.Add("@codigo", SqlDbType.Int).Value = oentidad.CODIGO;            

                Sqlcon.Open();
                Resultado = comando.ExecuteReader();
                Tabla.Load(Resultado);
                return Tabla;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex}");
                throw ex;
            }
            finally
            {
                if (Sqlcon.State == ConnectionState.Open) Sqlcon.Close();
            }            
        }
        public DataTable ListarDetalleValor(ENMValores oentidad, int Opcion)
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection Sqlcon = new SqlConnection();

            try
            {
                Sqlcon = Conexion.getInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("[Rentas].[SP_dvalores]", Sqlcon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@msquery", SqlDbType.Int).Value = Opcion;
                comando.Parameters.Add("@id_valor", SqlDbType.Int).Value = oentidad.ID_VALOR;
                comando.Parameters.Add("@ano_val", SqlDbType.Int).Value = oentidad.ANO_VAL;
                comando.Parameters.Add("@num_val", SqlDbType.Int).Value = oentidad.NUM_VAL;

                Sqlcon.Open();
                Resultado = comando.ExecuteReader();
                Tabla.Load(Resultado);
                return Tabla;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex}");
                throw ex;
            }
            finally
            {
                if (Sqlcon.State == ConnectionState.Open) Sqlcon.Close();
            }
            
        }
        public DataTable ListarDetalleCta(ENMValores oentidad, int Opcion)
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection Sqlcon = new SqlConnection();

            try
            {
                Sqlcon = Conexion.getInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("[Rentas].[SP_dvalores]", Sqlcon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@msquery", SqlDbType.Int).Value = Opcion;
                comando.Parameters.Add("@id_valor", SqlDbType.Int).Value = oentidad.ID_VALOR;
                comando.Parameters.Add("@ano_val", SqlDbType.Int).Value = oentidad.ANO_VAL;
                comando.Parameters.Add("@num_val", SqlDbType.Int).Value = oentidad.NUM_VAL;
                comando.Parameters.Add("@codigo", SqlDbType.Int).Value = oentidad.CODIGO;

                Sqlcon.Open();
                Resultado = comando.ExecuteReader();
                Tabla.Load(Resultado);
                return Tabla;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex}");
                throw ex;
            }
            finally
            {
                if (Sqlcon.State == ConnectionState.Open) Sqlcon.Close();
            }
            
        }
        public DataTable VerificarPagosValor(string codigo, string anno_valor,string tipo_rec, string periodo)
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection Sqlcon = new SqlConnection();

            try
            {
                Sqlcon = Conexion.getInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("Gestion.GestionCartera", Sqlcon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@buscar", SqlDbType.Int).Value = 28;
                comando.Parameters.Add("@codigo", SqlDbType.VarChar).Value = codigo;
                comando.Parameters.Add("@anno_valor", SqlDbType.VarChar).Value = anno_valor;
                comando.Parameters.Add("@rec_tipo", SqlDbType.VarChar).Value = tipo_rec;
                comando.Parameters.Add("@periodo", SqlDbType.VarChar).Value = periodo;

                Sqlcon.Open();
                Resultado = comando.ExecuteReader();
                Tabla.Load(Resultado);
                return Tabla;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex}");
                throw ex;
            }
            finally
            {
                if (Sqlcon.State == ConnectionState.Open) Sqlcon.Close();
            }


        }
    }
}
