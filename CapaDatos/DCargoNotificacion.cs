using CapaEntidades;
using System;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DCargoNotificacion
    {
        public string GrabarCargoNotificacion(ENCargo_Notificacion oentidad)
        {
            string Rpta = "";

            SqlConnection Sqlcon = new SqlConnection();

            try
            {
                Sqlcon = Conexion.getInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("notificacion.sp_cargos_notificacion", Sqlcon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@busc", SqlDbType.Int).Value = 2;
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
                comando.Parameters.Add("@fecha_act", SqlDbType.Date).Value = oentidad.FECHA_ACT;
                comando.Parameters.Add("@estacion_act", SqlDbType.VarChar, 25).Value = oentidad.ESTACION_ACT;

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
        public string ActualizarCargoNotificacion(ENCargo_Notificacion oentidad)
        {
            string Rpta = "";

            SqlConnection Sqlcon = new SqlConnection();

            try
            {
                Sqlcon = Conexion.getInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("notificacion.sp_cargos_notificacion", Sqlcon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@busc", SqlDbType.VarChar, 4).Value = 6;
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
        public DataTable ListarCargoNotificacion(ENCargo_Notificacion oentidad)
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection Sqlcon = new SqlConnection();

            try
            {
                Sqlcon = Conexion.getInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("notificacion.sp_cargos_notificacion", Sqlcon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@busc", SqlDbType.Int).Value = 5;
                comando.Parameters.Add("@codigo", SqlDbType.VarChar, 7).Value = oentidad.CODIGO;
                comando.Parameters.Add("@ano_cargo", SqlDbType.VarChar, 4).Value = oentidad.ANO_CARGO;
                comando.Parameters.Add("@num_cargo", SqlDbType.VarChar, 7).Value = oentidad.NUM_CARGO;
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

    }
}
