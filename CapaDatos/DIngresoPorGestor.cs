using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DIngresoPorGestor
    {
        public DataTable VerIngresoPorGestor(string usuario, DateTime fechaini, DateTime fechafin)
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection Sqlcon = new SqlConnection();

            try
            {
                Sqlcon = Conexion.getInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("Gestion.GestionCartera", Sqlcon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@buscar", SqlDbType.Int).Value = 16;
                comando.Parameters.Add("@usuario", SqlDbType.VarChar).Value = usuario;
                comando.Parameters.Add("@fechaini", SqlDbType.DateTime).Value = fechaini;
                comando.Parameters.Add("@fechafin", SqlDbType.DateTime).Value = fechafin;

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
