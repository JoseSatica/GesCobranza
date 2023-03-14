using System;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public  class DLogin

    {
        public DataTable Login( string usuario, string password)
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection Sqlcon = new SqlConnection();

            try
            {
                Sqlcon = Conexion.getInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("Gestion.GestionCartera", Sqlcon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@buscar", SqlDbType.Int).Value = 1;
                comando.Parameters.Add("@usuario", SqlDbType.VarChar).Value = usuario;
                comando.Parameters.Add("@password", SqlDbType.VarChar).Value = password;
                Sqlcon.Open();
                Resultado = comando.ExecuteReader();
                Tabla.Load(Resultado);
                return Tabla;
            }
            catch (Exception ex)
            {
                return null;
                throw ex;
            }
            finally
            {
                if (Sqlcon.State == ConnectionState.Open) Sqlcon.Close();
            }
        }
       
    }
}
