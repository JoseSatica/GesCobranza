using CapaEntidades;
using System;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DCargoNotificacion
    {
        public string GrabarCargoNotificacion(ENCargo_Notificacion oentidad, int Opcion)
        {
            string Rpta = "";

            SqlConnection Sqlcon = new SqlConnection();

            try
            {
                Sqlcon = Conexion.getInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("notificacion.sp_cargos_notificacion", Sqlcon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@busc", SqlDbType.Int).Value = Opcion;
                comando.Parameters.Add("@codigo", SqlDbType.VarChar, 7).Value = oentidad.CODIGO;
                comando.Parameters.Add("@id_valor", SqlDbType.VarChar, 2).Value = oentidad.ID_VALOR;
                comando.Parameters.Add("@num_valor", SqlDbType.VarChar, 20).Value = oentidad.NUM_VALOR;
                comando.Parameters.Add("@ano_valor", SqlDbType.Char, 4).Value = oentidad.ANO_VALOR;
                comando.Parameters.Add("@num_cargo", SqlDbType.VarChar, 20).Value = oentidad.NUM_CARGO;
                comando.Parameters.Add("@ano_cargo", SqlDbType.Char, 4).Value = oentidad.ANO_CARGO;
                comando.Parameters.Add("@id_notificador", SqlDbType.Int).Value = oentidad.ID_NOTIFICADOR;
                comando.Parameters.Add("@c_fachada", SqlDbType.VarChar, 50).Value = oentidad.C_FACHADA;
                comando.Parameters.Add("@flg_situacion", SqlDbType.Int).Value = oentidad.FLG_SITUACION;
                comando.Parameters.Add("@id_parentesco", SqlDbType.VarChar, 2).Value = oentidad.ID_PARENTESCO;
                comando.Parameters.Add("@nombre", SqlDbType.VarChar, 200).Value = oentidad.NOMBRE;
                comando.Parameters.Add("@direc_fiscal", SqlDbType.VarChar, 200).Value = oentidad.DIREC_FISCAL;
                comando.Parameters.Add("@observacion", SqlDbType.VarChar, 300).Value = oentidad.OBSERVACION;
                comando.Parameters.Add("@n_suministro", SqlDbType.VarChar, 20).Value = oentidad.N_SUMINISTRO;
                comando.Parameters.Add("@usuario_reg", SqlDbType.VarChar, 20).Value = oentidad.USUARIO_REG;
                comando.Parameters.Add("@estacion_reg", SqlDbType.VarChar, 20).Value = oentidad.ESTACION_REG;
                comando.Parameters.Add("@monto", SqlDbType.Decimal).Value = oentidad.MONTO;
                comando.Parameters.Add("@f_visita1", SqlDbType.Date).Value = oentidad.F_VISITA1;
                comando.Parameters.Add("@f_visita2", SqlDbType.Date).Value = oentidad.F_VISITA2;
                comando.Parameters.Add("@h_visita1", SqlDbType.VarChar, 10).Value = oentidad.H_VISITA1;
                comando.Parameters.Add("@h_visita2", SqlDbType.VarChar, 10).Value = oentidad.H_VISITA2;
                comando.Parameters.Add("@nro_visita", SqlDbType.Int).Value = oentidad.NRO_VISITA; // pide int // se cambio a int
                comando.Parameters.Add("@f_notifica", SqlDbType.Date).Value = oentidad.F_NOTIFICA;
                comando.Parameters.Add("@nro_documento", SqlDbType.VarChar, 15).Value = oentidad.NRO_DOCUMENTO;
                comando.Parameters.Add("@id_firma", SqlDbType.Int).Value = oentidad.ID_FIRMA;
                comando.Parameters.Add("@f_cedulon", SqlDbType.Date).Value = oentidad.F_CEDULON;
                comando.Parameters.Add("@h_cedulon", SqlDbType.VarChar, 10).Value = oentidad.H_CEDULON;
                comando.Parameters.Add("@dir_cedulon", SqlDbType.VarChar, 250).Value = oentidad.DIR_CEDULON;
                comando.Parameters.Add("@n_pisos", SqlDbType.VarChar).Value = oentidad.N_PISOS;
                comando.Parameters.Add("@derivar_drft", SqlDbType.Int).Value = oentidad.DERIVAR_DRFT; // pide int // se cambio a int
                comando.Parameters.Add("@estado", SqlDbType.Int).Value = oentidad.ESTADO; // pide int // se cambio a int
                comando.Parameters.Add("@usuario_act", SqlDbType.VarChar, 10).Value = oentidad.USUARIO_ACT;
                comando.Parameters.Add("@fecha_act", SqlDbType.Date).Value = oentidad.FECHA_ACT;
                comando.Parameters.Add("@estacion_act", SqlDbType.VarChar, 25).Value = oentidad.ESTACION_ACT;
                comando.Parameters.Add("@otros", SqlDbType.VarChar, 300).Value = oentidad.OTRO_CEDULON;
                comando.Parameters.Add("@parentesco_detalle", SqlDbType.VarChar, 50).Value = oentidad.PARENTESCO_DETALLE;

                Sqlcon.Open();
                Rpta = comando.ExecuteNonQuery() >= 1 ? "OK" : "ERROR";
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
        public string GrabarCargo(ENCargo_Notificacion oentidad)
        {
            string Rpta = "";

            SqlConnection Sqlcon = new SqlConnection();

            try
            {
                Sqlcon = Conexion.getInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("notificacion.sp_cargos_notificacion", Sqlcon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@busc", SqlDbType.VarChar, 4).Value = 2;
                comando.Parameters.Add("@ano_cargo", SqlDbType.VarChar, 20).Value = oentidad.ANO_CARGO;
                comando.Parameters.Add("@num_cargo", SqlDbType.VarChar, 20).Value = oentidad.NUM_CARGO;
                comando.Parameters.Add("@id_valor", SqlDbType.VarChar, 2).Value = oentidad.ID_VALOR;
                comando.Parameters.Add("@num_valor", SqlDbType.VarChar, 20).Value = oentidad.NUM_VALOR;
                comando.Parameters.Add("@ano_valor", SqlDbType.VarChar, 20).Value = oentidad.ANO_VALOR;
                comando.Parameters.Add("@codigo", SqlDbType.VarChar, 20).Value = oentidad.CODIGO;
                comando.Parameters.Add("@id_notificador", SqlDbType.VarChar, 20).Value = oentidad.ID_NOTIFICADOR;
                comando.Parameters.Add("@f_notifica", SqlDbType.Date).Value = oentidad.F_NOTIFICA;
                comando.Parameters.Add("@f_visita1", SqlDbType.Date).Value = oentidad.F_VISITA1;
                comando.Parameters.Add("@f_visita2", SqlDbType.Date).Value = oentidad.F_VISITA2;
                comando.Parameters.Add("@f_cedulon", SqlDbType.Date).Value = oentidad.F_CEDULON;
                comando.Parameters.Add("@h_visita1", SqlDbType.VarChar, 10).Value = oentidad.H_VISITA1;
                comando.Parameters.Add("@h_visita2", SqlDbType.VarChar, 10).Value = oentidad.H_VISITA2;
                comando.Parameters.Add("@h_cedulon", SqlDbType.VarChar, 10).Value = oentidad.H_CEDULON;
                comando.Parameters.Add("@n_pisos", SqlDbType.VarChar, 2).Value = oentidad.N_PISOS;
                comando.Parameters.Add("@c_fachada", SqlDbType.VarChar, 60).Value = oentidad.C_FACHADA;
                comando.Parameters.Add("@id_parentesco", SqlDbType.VarChar, 10).Value = oentidad.ID_PARENTESCO;
                comando.Parameters.Add("@nombre", SqlDbType.VarChar, 250).Value = oentidad.NOMBRE;
                comando.Parameters.Add("@nro_documento", SqlDbType.VarChar, 15).Value = oentidad.NRO_DOCUMENTO;
                comando.Parameters.Add("@direc_fiscal", SqlDbType.VarChar, 250).Value = oentidad.DIREC_FISCAL;
                comando.Parameters.Add("@nro_visita", SqlDbType.VarChar, 15).Value = oentidad.NRO_VISITA;
                comando.Parameters.Add("@flg_situacion", SqlDbType.VarChar, 250).Value = oentidad.FLG_SITUACION;
                comando.Parameters.Add("@id_firma", SqlDbType.VarChar, 15).Value = oentidad.ID_FIRMA;
                comando.Parameters.Add("@dir_cedulon", SqlDbType.VarChar, 250).Value = oentidad.DIR_CEDULON;
                comando.Parameters.Add("@n_suministro", SqlDbType.VarChar, 15).Value = oentidad.N_SUMINISTRO;
                comando.Parameters.Add("@observacion", SqlDbType.VarChar, 250).Value = oentidad.OBSERVACION;
                comando.Parameters.Add("@derivar_drft", SqlDbType.Int).Value = oentidad.DERIVAR_DRFT;

                comando.Parameters.Add("@estado", SqlDbType.VarChar, 1).Value = oentidad.ESTADO;
                comando.Parameters.Add("@usuario_act", SqlDbType.VarChar, 25).Value = oentidad.USUARIO_ACT;
                comando.Parameters.Add("@estacion_act", SqlDbType.VarChar, 25).Value = oentidad.ESTACION_ACT;
                comando.Parameters.Add("@estacion_reg", SqlDbType.VarChar, 25).Value = oentidad.ESTACION_REG;
                comando.Parameters.Add("@usuario_reg", SqlDbType.VarChar, 250).Value = oentidad.USUARIO_REG;
                comando.Parameters.Add("@monto", SqlDbType.Decimal).Value = oentidad.MONTO;
                comando.Parameters.Add("@fecha_act", SqlDbType.Date).Value = oentidad.FECHA_ACT;
                comando.Parameters.Add("@otros", SqlDbType.VarChar, 300).Value = oentidad.OTRO_CEDULON;

                Sqlcon.Open();
                Rpta = comando.ExecuteNonQuery() == 1 ? "OK" : "NO SE PUDO ACTUALIZAR";
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
        public string ActualizarCargoNotificacion(ENCargo_Notificacion oentidad, int Opcion)
        {
            string Rpta = "";

            SqlConnection Sqlcon = new SqlConnection();

            try
            {
                Sqlcon = Conexion.getInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("notificacion.sp_cargos_notificacion", Sqlcon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@busc", SqlDbType.VarChar, 4).Value = Opcion;
                comando.Parameters.Add("@codigo", SqlDbType.VarChar, 7).Value = oentidad.CODIGO;
                comando.Parameters.Add("@id_valor", SqlDbType.VarChar, 2).Value = oentidad.ID_VALOR;
                comando.Parameters.Add("@num_valor", SqlDbType.VarChar, 20).Value = oentidad.NUM_VALOR;
                comando.Parameters.Add("@ano_valor", SqlDbType.Char, 4).Value = oentidad.ANO_VALOR;
                comando.Parameters.Add("@num_cargo", SqlDbType.VarChar, 20).Value = oentidad.NUM_CARGO;
                comando.Parameters.Add("@ano_cargo", SqlDbType.Char, 4).Value = oentidad.ANO_CARGO;
                comando.Parameters.Add("@id_notificador", SqlDbType.VarChar, 20).Value = oentidad.ID_NOTIFICADOR;
                comando.Parameters.Add("@c_fachada", SqlDbType.VarChar, 50).Value = oentidad.C_FACHADA;
                comando.Parameters.Add("@flg_situacion", SqlDbType.VarChar, 1).Value = oentidad.FLG_SITUACION;
                comando.Parameters.Add("@id_parentesco", SqlDbType.VarChar, 2).Value = oentidad.ID_PARENTESCO;
                comando.Parameters.Add("@nombre", SqlDbType.VarChar, 200).Value = oentidad.NOMBRE;
                comando.Parameters.Add("@direc_fiscal", SqlDbType.VarChar, 200).Value = oentidad.DIREC_FISCAL;
                comando.Parameters.Add("@observacion", SqlDbType.VarChar, 20).Value = oentidad.OBSERVACION;
                comando.Parameters.Add("@n_suministro", SqlDbType.VarChar, 20).Value = oentidad.N_SUMINISTRO;
                comando.Parameters.Add("@usuario_reg", SqlDbType.VarChar, 20).Value = oentidad.USUARIO_REG;
                comando.Parameters.Add("@estacion_reg", SqlDbType.VarChar, 20).Value = oentidad.ESTACION_REG;
                comando.Parameters.Add("@monto", SqlDbType.Float).Value = oentidad.MONTO;
                comando.Parameters.Add("@f_visita1", SqlDbType.Date).Value = oentidad.F_VISITA1;
                comando.Parameters.Add("@f_visita2", SqlDbType.Date).Value = oentidad.F_VISITA2;
                comando.Parameters.Add("@h_visita1", SqlDbType.VarChar, 10).Value = oentidad.H_VISITA1;
                comando.Parameters.Add("@h_visita2", SqlDbType.VarChar, 10).Value = oentidad.H_VISITA2;
                comando.Parameters.Add("@nro_visita", SqlDbType.Int).Value = oentidad.NRO_VISITA;
                comando.Parameters.Add("@f_notifica", SqlDbType.Date).Value = oentidad.F_NOTIFICA;
                comando.Parameters.Add("@nro_documento", SqlDbType.VarChar, 15).Value = oentidad.NRO_DOCUMENTO;
                comando.Parameters.Add("@id_firma", SqlDbType.Int).Value = oentidad.ID_FIRMA;
                comando.Parameters.Add("@f_cedulon", SqlDbType.Date).Value = oentidad.F_CEDULON;
                comando.Parameters.Add("@h_cedulon", SqlDbType.VarChar, 10).Value = oentidad.H_CEDULON;
                comando.Parameters.Add("@dir_cedulon", SqlDbType.VarChar, 250).Value = oentidad.DIR_CEDULON;
                comando.Parameters.Add("@n_pisos", SqlDbType.Int).Value = oentidad.N_PISOS;
                comando.Parameters.Add("@derivar_drft", SqlDbType.Int).Value = oentidad.DERIVAR_DRFT;
                comando.Parameters.Add("@estado", SqlDbType.Int).Value = oentidad.ESTADO;
                comando.Parameters.Add("@usuario_act", SqlDbType.VarChar, 10).Value = oentidad.USUARIO_ACT;
                comando.Parameters.Add("@fecha_act", SqlDbType.DateTime).Value = oentidad.FECHA_ACT;
                comando.Parameters.Add("@estacion_act", SqlDbType.VarChar, 25).Value = oentidad.ESTACION_ACT;
                comando.Parameters.Add("@otros", SqlDbType.VarChar, 300).Value = oentidad.OTRO_CEDULON;

                Sqlcon.Open();
                Rpta = comando.ExecuteNonQuery() == 1 ? "OK" : "NO SE PUDO ACTUALIZAR";
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
        public DataTable ListarCargoNotificacion(ENCargo_Notificacion oentidad, int Opcion)
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection Sqlcon = new SqlConnection();

            try
            {
                Sqlcon = Conexion.getInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("notificacion.sp_cargos_notificacion", Sqlcon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@busc", SqlDbType.Int).Value = Opcion;
                comando.Parameters.Add("@codigo", SqlDbType.VarChar, 7).Value = oentidad.CODIGO;
                comando.Parameters.Add("@ano_cargo", SqlDbType.VarChar, 4).Value = oentidad.ANO_CARGO;
                comando.Parameters.Add("@num_cargo", SqlDbType.Int, 7).Value = Convert.ToInt32(oentidad.NUM_CARGO);
                comando.Parameters.Add("@ano_valor", SqlDbType.VarChar, 4).Value = oentidad.ANO_VALOR;
                comando.Parameters.Add("@num_valor", SqlDbType.VarChar, 7).Value = oentidad.NUM_VALOR;
                comando.Parameters.Add("@id_valor", SqlDbType.VarChar, 2).Value = oentidad.ID_VALOR;

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
        public DataTable listado_notificacion(int Opcion)
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection Sqlcon = new SqlConnection();

            try
            {
                Sqlcon = Conexion.getInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("[notificacion].[sp_Cargos_Notificacion]", Sqlcon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@busc", SqlDbType.Int).Value = Opcion;

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
        public DataTable call_notificacion(ENCargo_Notificacion oEntidad, int Opcion)
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection Sqlcon = new SqlConnection();

            try
            {
                Sqlcon = Conexion.getInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("[notificacion].[sp_Cargos_Notificacion]", Sqlcon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@busc", SqlDbType.Int).Value = Opcion;
                //comando.Parameters.Add("@codigo", SqlDbType.VarChar, 7).Value = oentidad.CODIGO;
                //comando.Parameters.Add("@ano_cargo", SqlDbType.VarChar, 4).Value = oentidad.ANO_CARGO;
                //comando.Parameters.Add("@num_cargo", SqlDbType.Int, 7).Value = Convert.ToInt32(oentidad.NUM_CARGO);
                comando.Parameters.Add("@ano_valor", SqlDbType.VarChar, 4).Value = oEntidad.ANO_VALOR;
                comando.Parameters.Add("@num_valor", SqlDbType.VarChar, 7).Value = oEntidad.NUM_VALOR;
                comando.Parameters.Add("@id_valor", SqlDbType.VarChar, 2).Value = oEntidad.ID_VALOR;

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
        public DataTable print_notificacion(int Opcion, DateTime desde, DateTime hasta)
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection Sqlcon = new SqlConnection();

            try
            {
                Sqlcon = Conexion.getInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("[notificacion].[sp_Cargos_Notificacion]", Sqlcon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@busc", SqlDbType.Int).Value = Opcion;
                comando.Parameters.Add("@desde", SqlDbType.DateTime).Value = desde;
                comando.Parameters.Add("@hasta", SqlDbType.DateTime).Value = hasta;

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

        public string anular_notificacion(ENCargo_Notificacion oEntidad, int Opcion)
        {
            string Rpta = "";

            SqlConnection Sqlcon = new SqlConnection();

            try
            {
                Sqlcon = Conexion.getInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("[notificacion].[sp_Cargos_Notificacion]", Sqlcon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@busc", SqlDbType.Int).Value = Opcion;
                //comando.Parameters.Add("@num_cargo", SqlDbType.VarChar).Value = oEntidad.NUM_CARGO;
                //comando.Parameters.Add("@ano_cargo", SqlDbType.VarChar).Value = oEntidad.ANO_CARGO;
                comando.Parameters.Add("@num_valor", SqlDbType.VarChar).Value = oEntidad.NUM_VALOR;
                comando.Parameters.Add("@ano_valor", SqlDbType.VarChar).Value = oEntidad.ANO_VALOR;
                //comando.Parameters.Add("@observacion", SqlDbType.VarChar).Value = oEntidad.OBSERVACION;
                comando.Parameters.Add("@nombre_usua", SqlDbType.VarChar).Value = oEntidad.NOMBRE;

                Sqlcon.Open();
                Rpta = comando.ExecuteNonQuery() >= 1 ? "OK" : "ERROR";
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
        public DataTable Dias_Habiles(DateTime desde, DateTime hasta)
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection Sqlcon = new SqlConnection();

            try
            {
                Sqlcon = Conexion.getInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("Gestion.GestionCartera", Sqlcon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@buscar", SqlDbType.Int).Value = 27;
                comando.Parameters.Add("@fechaini", SqlDbType.DateTime).Value = desde;
                comando.Parameters.Add("@fechafin", SqlDbType.DateTime).Value = hasta;

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
        public DataTable ValidarRG(string nro_res, string anno_res)
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection Sqlcon = new SqlConnection();

            try
            {
                Sqlcon = Conexion.getInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("Gestion.GestionCartera", Sqlcon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@buscar", SqlDbType.Int).Value = 29;
                comando.Parameters.Add("@nro_res", SqlDbType.VarChar).Value = nro_res;
                comando.Parameters.Add("@anno_res", SqlDbType.VarChar).Value = @anno_res;

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
        public DataTable InsertarCabeceraLote(string info_coactivo, string num_lote, string anno_lote, string uregistro, string pcregistro)
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection Sqlcon = new SqlConnection();

            try
            {
                Sqlcon = Conexion.getInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("Gestion.GestionCartera", Sqlcon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@buscar", SqlDbType.Int).Value = 32;
                comando.Parameters.Add("@info_coactivo", SqlDbType.VarChar).Value = info_coactivo;
                comando.Parameters.Add("@num_lote", SqlDbType.VarChar).Value = num_lote;
                comando.Parameters.Add("@anno_lote", SqlDbType.VarChar).Value = anno_lote;
                comando.Parameters.Add("@uregistro", SqlDbType.VarChar).Value = uregistro;
                comando.Parameters.Add("@pcregistro", SqlDbType.VarChar).Value = pcregistro;

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
        public DataTable InsertarDetalleLote(int id_nuevo_lote, int id_tbl, string estado_lote, string obsv_lote, string num_tramite_lote)
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection Sqlcon = new SqlConnection();

            try
            {
                Sqlcon = Conexion.getInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("Gestion.GestionCartera", Sqlcon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@buscar", SqlDbType.Int).Value = 33;
                comando.Parameters.Add("@id_nuevo_lote", SqlDbType.Int).Value = id_nuevo_lote;
                comando.Parameters.Add("@id_tbl", SqlDbType.Int).Value = id_tbl;
                comando.Parameters.Add("@estado_lote", SqlDbType.Int).Value = estado_lote;
                comando.Parameters.Add("@obsv_lote", SqlDbType.VarChar).Value = obsv_lote;
                comando.Parameters.Add("@num_tramite_lote", SqlDbType.VarChar).Value = num_tramite_lote;

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

        public DataTable InsertarMovimientoLote(int id_nuevo_lote, int esta_movi, string remitente, string destinatario, DateTime fecha_actulizacion)
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection Sqlcon = new SqlConnection();

            try
            {
                Sqlcon = Conexion.getInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("Gestion.GestionCartera", Sqlcon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@buscar", SqlDbType.Int).Value = 34;
                comando.Parameters.Add("@id_nuevo_lote", SqlDbType.Int).Value = id_nuevo_lote;
                comando.Parameters.Add("@estado_movi", SqlDbType.Int).Value = esta_movi;
                comando.Parameters.Add("@area_remitente", SqlDbType.VarChar).Value = remitente;
                comando.Parameters.Add("@area_destinatario", SqlDbType.VarChar).Value = destinatario;
                comando.Parameters.Add("@fecha_actualizada", SqlDbType.VarChar).Value = fecha_actulizacion;

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
        public string ActualizarEstadoCargo(int id_tbl, string estado_cargo)
        {
            string Rpta = "";

            SqlConnection Sqlcon = new SqlConnection();

            try
            {
                Sqlcon = Conexion.getInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("Gestion.GestionCartera", Sqlcon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@buscar", SqlDbType.Int).Value = 35;
                comando.Parameters.Add("@id_tbl", SqlDbType.Int).Value = id_tbl;
                comando.Parameters.Add("@estado_cargo", SqlDbType.VarChar).Value = estado_cargo;

                Sqlcon.Open();
                Rpta = comando.ExecuteNonQuery() >= 1 ? "OK" : "ERROR";
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
        public DataTable MostrarBandejaLegal()
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection Sqlcon = new SqlConnection();

            try
            {
                Sqlcon = Conexion.getInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("Gestion.GestionCartera", Sqlcon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@buscar", SqlDbType.Int).Value = 36;

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
        public DataTable MostrarDetalleLote(int id_lotec)
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection Sqlcon = new SqlConnection();

            try
            {
                Sqlcon = Conexion.getInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("Gestion.GestionCartera", Sqlcon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@buscar", SqlDbType.Int).Value = 37;
                comando.Parameters.Add("@id_lotec", SqlDbType.Int).Value = id_lotec;

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
        public string AnularCargoLote(int id_loted)
        {
            string Rpta = "";

            SqlConnection Sqlcon = new SqlConnection();

            try
            {
                Sqlcon = Conexion.getInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("Gestion.GestionCartera", Sqlcon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@buscar", SqlDbType.Int).Value = 38;
                comando.Parameters.Add("@id_loted", SqlDbType.Int).Value = id_loted;


                Sqlcon.Open();
                Rpta = comando.ExecuteNonQuery() >= 1 ? "OK" : "ERROR";
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
        public DataTable BuscarLotes(string area_destinatario,string num_lote, string anno_lote, string estado_detalle, string documento, DateTime fechaini, DateTime fechafin, int rowini, int rowfin)
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection Sqlcon = new SqlConnection();

            try
            {
                Sqlcon = Conexion.getInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("Gestion.GestionCartera", Sqlcon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@buscar", SqlDbType.Int).Value = 39;
                comando.Parameters.Add("@area_destinatario", SqlDbType.VarChar).Value = area_destinatario;
                comando.Parameters.Add("@num_lote", SqlDbType.VarChar).Value = num_lote;
                comando.Parameters.Add("@anno_lote", SqlDbType.VarChar).Value = anno_lote;
                comando.Parameters.Add("@estado_lote_deta", SqlDbType.VarChar).Value = estado_detalle;
                comando.Parameters.Add("@info_coactivo", SqlDbType.VarChar).Value = documento;
                comando.Parameters.Add("@fechaini", SqlDbType.DateTime).Value = fechaini;
                comando.Parameters.Add("@fechafin", SqlDbType.DateTime).Value = fechafin;
                comando.Parameters.Add("@inicio", SqlDbType.Int).Value = rowini;
                comando.Parameters.Add("@final", SqlDbType.Int).Value = rowfin;

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
        public DataTable BuscarLotesContador(string area_destinatario,string num_lote, string anno_lote, string estado_detalle, string documento, DateTime fechaini, DateTime fechafin)
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection Sqlcon = new SqlConnection();

            try
            {
                Sqlcon = Conexion.getInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("Gestion.GestionCartera", Sqlcon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@buscar", SqlDbType.Int).Value = 40;
                comando.Parameters.Add("@area_destinatario", SqlDbType.VarChar).Value = area_destinatario;
                comando.Parameters.Add("@num_lote", SqlDbType.VarChar).Value = num_lote;
                comando.Parameters.Add("@anno_lote", SqlDbType.VarChar).Value = anno_lote;
                comando.Parameters.Add("@estado_lote_deta", SqlDbType.VarChar).Value = estado_detalle;
                comando.Parameters.Add("@info_coactivo", SqlDbType.VarChar).Value = documento;
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
        public DataTable CargarComboEstadoLote()
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection Sqlcon = new SqlConnection();

            try
            {
                Sqlcon = Conexion.getInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("Gestion.GestionCartera", Sqlcon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@buscar", SqlDbType.Int).Value = 41;

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
        public string ActualizarEstadoBandeja(int id_estado, int id_lote_movi)
        {
            string Rpta = "";

            SqlConnection Sqlcon = new SqlConnection();

            try
            {
                Sqlcon = Conexion.getInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("Gestion.GestionCartera", Sqlcon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@buscar", SqlDbType.Int).Value = 42;
                comando.Parameters.Add("@id_estado", SqlDbType.Int).Value = id_estado;
                comando.Parameters.Add("@id_lote_movi", SqlDbType.Int).Value = id_lote_movi;

                Sqlcon.Open();
                Rpta = comando.ExecuteNonQuery() >= 1 ? "OK" : "ERROR";
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
