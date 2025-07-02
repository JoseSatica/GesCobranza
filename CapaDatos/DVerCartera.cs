using System;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos{
    public class DVerCartera{
        public DataTable CargarComboSeguimientos(){
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection Sqlcon = new SqlConnection();
            try{
                Sqlcon = Conexion.getInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("Gestion.GestionCartera", Sqlcon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@buscar", SqlDbType.Int).Value = 5;
                Sqlcon.Open();
                Resultado = comando.ExecuteReader();
                Tabla.Load(Resultado);
                return Tabla;
            }
            catch (Exception ex){
                throw ex;
            }
            finally{
                if (Sqlcon.State == ConnectionState.Open) Sqlcon.Close();
            }
        }
        public DataTable CargarComboEstados(){
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection Sqlcon = new SqlConnection();
            try{
                Sqlcon = Conexion.getInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("Gestion.GestionCartera", Sqlcon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@buscar", SqlDbType.Int).Value = 6;
                Sqlcon.Open();
                Resultado = comando.ExecuteReader();
                Tabla.Load(Resultado);
                return Tabla;
            }
            catch (Exception ex){
                throw ex;
            }
            finally{
                if (Sqlcon.State == ConnectionState.Open) Sqlcon.Close();
            }
        }
        public DataTable CargarDGVGestores(){
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection Sqlcon = new SqlConnection();
            try{
                Sqlcon = Conexion.getInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("Gestion.GestionCartera", Sqlcon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@buscar", SqlDbType.Int).Value = 7;
                Sqlcon.Open();
                Resultado = comando.ExecuteReader();
                Tabla.Load(Resultado);
                return Tabla;
            }
            catch (Exception ex){
                throw ex;
            }
            finally{
                if (Sqlcon.State == ConnectionState.Open) Sqlcon.Close();
            }
        }
        public DataTable CargarCartera(string usuario, int rowini, int rowfin){
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection Sqlcon = new SqlConnection();
            try{
                Sqlcon = Conexion.getInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("Gestion.GestionCartera", Sqlcon);
                comando.CommandTimeout = 5000;
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@buscar", SqlDbType.Int).Value = 2;
                comando.Parameters.Add("@usuario", SqlDbType.VarChar).Value = usuario;
                comando.Parameters.Add("@inicio", SqlDbType.Int).Value = rowini;
                comando.Parameters.Add("@final", SqlDbType.Int).Value = rowfin;
                Sqlcon.Open();
                Resultado = comando.ExecuteReader();
                Tabla.Load(Resultado);
                return Tabla;
            }
            catch (Exception ex){
                throw ex;
            }
            finally{
                if (Sqlcon.State == ConnectionState.Open) Sqlcon.Close();
            }
        }

        public DataTable BuscarCartera(string codigo, string deta_estado, string deta_seguimiento, string nombre_contri, string ap_paterno, string ap_materno, string usuario, DateTime fechaini, DateTime fechafin, int rowini, int rowfin){
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection Sqlcon = new SqlConnection();
            try{
                Sqlcon = Conexion.getInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("Gestion.GestionCartera", Sqlcon);
                comando.CommandTimeout = 5000;
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@buscar", SqlDbType.Int).Value = 3;
                comando.Parameters.Add("@codigo", SqlDbType.VarChar).Value = codigo;
                comando.Parameters.Add("@deta_estado", SqlDbType.VarChar).Value = deta_estado;
                comando.Parameters.Add("@deta_seguimiento", SqlDbType.VarChar).Value = deta_seguimiento;
                comando.Parameters.Add("@nombre_contri", SqlDbType.VarChar).Value = nombre_contri;
                comando.Parameters.Add("@ap_paterno", SqlDbType.VarChar).Value = ap_paterno;
                comando.Parameters.Add("@ap_materno", SqlDbType.VarChar).Value = ap_materno;
                comando.Parameters.Add("@usuario", SqlDbType.VarChar).Value = usuario;
                comando.Parameters.Add("@fechaini", SqlDbType.DateTime).Value = fechaini;
                comando.Parameters.Add("@fechafin", SqlDbType.DateTime).Value = fechafin;
                comando.Parameters.Add("@inicio", SqlDbType.Int).Value = rowini;
                comando.Parameters.Add("@final", SqlDbType.Int).Value = rowfin;
                //comando.Parameters.Add("@opc", SqlDbType.Int).Value = opc;
                //comando.Parameters.Add("@direccion", SqlDbType.VarChar).Value = direccion;
                Sqlcon.Open();
                Resultado = comando.ExecuteReader();
                Tabla.Load(Resultado);
                return Tabla;
            }
            catch (Exception ex){
                throw ex;
            }
            finally{
                if (Sqlcon.State == ConnectionState.Open) Sqlcon.Close();
            }
        }
        public string ActualizarMontoRefrescar(int id_cartera, decimal monto){
            string Rpta = "";
            SqlConnection Sqlcon = new SqlConnection();
            try{
                Sqlcon = Conexion.getInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("Gestion.GestionCartera", Sqlcon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@buscar", SqlDbType.Int).Value = 20;
                comando.Parameters.Add("@id_cartera", SqlDbType.VarChar).Value = id_cartera;
                comando.Parameters.Add("@monto", SqlDbType.Decimal).Value = monto;
                Sqlcon.Open();
                Rpta = comando.ExecuteNonQuery() == 1 ? "OK" : "NO SE PUDO ACTUALIZAR";
            }
            catch (Exception ex){
                throw ex;
            }
            finally{
                if (Sqlcon.State == ConnectionState.Open) Sqlcon.Close();
            }
            return Rpta;
        }
        public string ActualizarFechaAGestionar(int id_cartera, string fecha_a_gestionar){
            string Rpta = "";
            SqlConnection Sqlcon = new SqlConnection();
            try{
                Sqlcon = Conexion.getInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("Gestion.GestionCartera", Sqlcon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@buscar", SqlDbType.Int).Value = 13;
                comando.Parameters.Add("@id_cartera", SqlDbType.Int).Value = id_cartera;
                comando.Parameters.Add("@fecha_por_gestionar", SqlDbType.VarChar).Value = fecha_a_gestionar;
                Sqlcon.Open();
                Rpta = comando.ExecuteNonQuery() == 1 ? "OK" : "NO SE PUDO ACTUALIZAR";
            }
            catch (Exception ex){
                throw ex;
            }
            finally{
                if (Sqlcon.State == ConnectionState.Open) Sqlcon.Close();
            }
            return Rpta;
        }
        public DataTable MostrarProgramacion(string usuario, string fecha_por_gestionar){
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection Sqlcon = new SqlConnection();
            try{
                Sqlcon = Conexion.getInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("Gestion.GestionCartera", Sqlcon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@buscar", SqlDbType.Int).Value = 24;
                comando.Parameters.Add("@usuario", SqlDbType.VarChar).Value = usuario;
                comando.Parameters.Add("@fecha_por_gestionar", SqlDbType.VarChar).Value = fecha_por_gestionar;
                Sqlcon.Open();
                Resultado = comando.ExecuteReader();
                Tabla.Load(Resultado);
                return Tabla;
            }
            catch (Exception ex){
                throw ex;
            }
            finally{
                if (Sqlcon.State == ConnectionState.Open) Sqlcon.Close();
            }
        }
        public DataTable ContadorPaginas(string codigo, string deta_estado, string deta_seguimiento, string nombre_contri, string ap_paterno, string ap_materno, string usuario, DateTime fechaini, DateTime fechafin){
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection Sqlcon = new SqlConnection();
            try{
                Sqlcon = Conexion.getInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("Gestion.GestionCartera", Sqlcon);
                comando.CommandTimeout = 5000;
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@buscar", SqlDbType.Int).Value = 26;
                comando.Parameters.Add("@codigo", SqlDbType.VarChar).Value = codigo;
                comando.Parameters.Add("@deta_estado", SqlDbType.VarChar).Value = deta_estado;
                comando.Parameters.Add("@deta_seguimiento", SqlDbType.VarChar).Value = deta_seguimiento;
                comando.Parameters.Add("@nombre_contri", SqlDbType.VarChar).Value = nombre_contri;
                comando.Parameters.Add("@ap_paterno", SqlDbType.VarChar).Value = ap_paterno;
                comando.Parameters.Add("@ap_materno", SqlDbType.VarChar).Value = ap_materno;
                comando.Parameters.Add("@usuario", SqlDbType.VarChar).Value = usuario;
                comando.Parameters.Add("@fechaini", SqlDbType.DateTime).Value = fechaini;
                comando.Parameters.Add("@fechafin", SqlDbType.DateTime).Value = fechafin;
                //comando.Parameters.Add("@opc", SqlDbType.Int).Value = opc;
                //comando.Parameters.Add("@direccion", SqlDbType.VarChar).Value = direccion;
                Sqlcon.Open();
                Resultado = comando.ExecuteReader();
                Tabla.Load(Resultado);
                return Tabla;
            }
            catch (Exception ex){
                throw ex;
            }
            finally{
                if (Sqlcon.State == ConnectionState.Open) Sqlcon.Close();
            }
        }
        public DataTable BuscarCarteraPorPredio( string usuario,string cod_urba, string id_via, string nro,string dpto,string mza,string lte,string sublte, int rowini, int rowfin){
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection Sqlcon = new SqlConnection();
            try{
                Sqlcon = Conexion.getInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("Gestion.GestionCartera", Sqlcon);
                comando.CommandTimeout = 5000;
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@buscar", SqlDbType.Int).Value = 30;
                comando.Parameters.Add("@usuario", SqlDbType.VarChar).Value = usuario;                
                //comando.Parameters.Add("@fechaini", SqlDbType.DateTime).Value = fechaini;
                //comando.Parameters.Add("@fechafin", SqlDbType.DateTime).Value = fechafin;
                comando.Parameters.Add("@cod_urb", SqlDbType.VarChar).Value = cod_urba;
                comando.Parameters.Add("@id_via", SqlDbType.VarChar).Value = id_via;
                comando.Parameters.Add("@nro", SqlDbType.VarChar).Value = nro;
                comando.Parameters.Add("@dpto", SqlDbType.VarChar).Value = dpto;
                comando.Parameters.Add("@Mza", SqlDbType.VarChar).Value = mza;
                comando.Parameters.Add("@Lte", SqlDbType.VarChar).Value = lte;
                comando.Parameters.Add("@SubLte", SqlDbType.VarChar).Value = sublte;
                comando.Parameters.Add("@inicio", SqlDbType.Int).Value = rowini;
                comando.Parameters.Add("@final", SqlDbType.Int).Value = rowfin;
                Sqlcon.Open();
                Resultado = comando.ExecuteReader();
                Tabla.Load(Resultado);
                return Tabla;
            }
            catch (Exception ex){
                throw ex;
            }
            finally{
                if (Sqlcon.State == ConnectionState.Open) Sqlcon.Close();
            }
        }
        public DataTable BuscarCarteraPorPredioContador(string usuario, string cod_urba, string id_via, string nro, string dpto, string mza, string lte, string sublte){
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection Sqlcon = new SqlConnection();
            try{
                Sqlcon = Conexion.getInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("Gestion.GestionCartera", Sqlcon);
                comando.CommandTimeout = 5000;
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@buscar", SqlDbType.Int).Value = 31;
                comando.Parameters.Add("@usuario", SqlDbType.VarChar).Value = usuario;
                //comando.Parameters.Add("@fechaini", SqlDbType.DateTime).Value = fechaini;
                //comando.Parameters.Add("@fechafin", SqlDbType.DateTime).Value = fechafin;
                comando.Parameters.Add("@cod_urb", SqlDbType.VarChar).Value = cod_urba;
                comando.Parameters.Add("@id_via", SqlDbType.VarChar).Value = id_via;
                comando.Parameters.Add("@nro", SqlDbType.VarChar).Value = nro;
                comando.Parameters.Add("@dpto", SqlDbType.VarChar).Value = dpto;
                comando.Parameters.Add("@Mza", SqlDbType.VarChar).Value = mza;
                comando.Parameters.Add("@Lte", SqlDbType.VarChar).Value = lte;
                comando.Parameters.Add("@SubLte", SqlDbType.VarChar).Value = sublte;
                Sqlcon.Open();
                Resultado = comando.ExecuteReader();
                Tabla.Load(Resultado);
                return Tabla;
            }
            catch (Exception ex){
                throw ex;
            }
            finally{
                if (Sqlcon.State == ConnectionState.Open) Sqlcon.Close();
            }
        }
    }
}
