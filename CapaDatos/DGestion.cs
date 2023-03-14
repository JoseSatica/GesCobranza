using System;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DGestion
    {
        
        public DataTable CargarPrediosChkl(string Codigo)
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection Sqlcon = new SqlConnection();

            try
            {
                Sqlcon = Conexion.getInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("store_caja_framework", Sqlcon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@msquery", SqlDbType.Int).Value = 15;
                comando.Parameters.Add("@codigo", SqlDbType.VarChar).Value = Codigo;


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
        public DataTable CargarPeriodosChkl(string Codigo)
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection Sqlcon = new SqlConnection();

            try
            {
                Sqlcon = Conexion.getInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("store_caja_framework", Sqlcon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@msquery", SqlDbType.Int).Value = 5;
                comando.Parameters.Add("@codigo", SqlDbType.VarChar).Value = Codigo;


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
        public DataTable CargarAnnosChkl(string Codigo)
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection Sqlcon = new SqlConnection();

            try
            {
                Sqlcon = Conexion.getInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("store_caja_framework", Sqlcon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@msquery", SqlDbType.Int).Value = 6;
                comando.Parameters.Add("@codigo", SqlDbType.VarChar).Value = Codigo;


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
        public DataTable CargarVehiculoChkl(string Codigo)
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection Sqlcon = new SqlConnection();

            try
            {
                Sqlcon = Conexion.getInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("store_caja_framework", Sqlcon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@msquery", SqlDbType.Int).Value = 20;
                comando.Parameters.Add("@codigo", SqlDbType.VarChar).Value = Codigo;


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
        public DataTable CargarFraccChkl(string codigo)
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection Sqlcon = new SqlConnection();

            try
            {
                Sqlcon = Conexion.getInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("store_caja_framework", Sqlcon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@msquery", SqlDbType.Int).Value = 21;
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

        public DataTable CalcularDeuda(string codigo, string anios, string tipos, string tiporec, string periodo, string predio, string estado)
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection Sqlcon = new SqlConnection();

            try
            {
                Sqlcon = Conexion.getInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("Caja.sp_EstCta_Rentas_2021", Sqlcon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandTimeout = 4000;
                comando.Parameters.Add("@criterio", SqlDbType.VarChar).Value = '0';
                comando.Parameters.Add("@codigo", SqlDbType.VarChar).Value = codigo;
                comando.Parameters.Add("@annos", SqlDbType.VarChar).Value = anios;
                comando.Parameters.Add("@tipos", SqlDbType.VarChar).Value = tipos;
                comando.Parameters.Add("@tiporec", SqlDbType.VarChar).Value = tiporec;
                comando.Parameters.Add("@perio", SqlDbType.VarChar).Value = periodo;
                comando.Parameters.Add("@predio", SqlDbType.VarChar).Value = predio;
                comando.Parameters.Add("@estado", SqlDbType.VarChar).Value = estado;

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
