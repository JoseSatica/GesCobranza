using CapaEntidades;
using CapaNegocio;
using LibreriaSAT;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;


namespace CapaPresentacion
{
    public partial class frmCargoNotificaciones : Form
    {
        private DataTable odtdetalle = new DataTable(), odttable = new DataTable();
        public static string OpcionFormulario;
        public static string[] ArregloCargo = new string[7];

        private int _resultadoValor = 1;
        private int _resultadoValidarPestañas = 1;
        private int _resultadoValidarCombo = 1;
        int _resultadoValidarDatosCargo = 1;
        private string _resultadoPago = "";
        public frmCargoNotificaciones()
        {
            InitializeComponent();
        }

        private void frmCargoNotificaciones_Load(object sender, EventArgs e)
        {
            BtnGrabar.Enabled = false;
            TxtAnnoValor.Text = "";
            TxtNroValor.Text = "";
            CmbTipoValor.SelectedIndex = -1;
            STCDatos.Enabled = false;
            CargarCombos();
            //int indice = CmbNotificador.FindStringExact(Variables.cod_usuario);
            //if (indice != -1)
            //{
            //    CmbNotificador.SelectedIndex = indice;
            //}
            var regex = new Regex(Variables.cod_usuario, RegexOptions.IgnoreCase);
            var itemEncontrado = CmbNotificador.Items.Cast<DataRowView>().FirstOrDefault(item => regex.IsMatch(item[CmbNotificador.DisplayMember].ToString()));
            if (itemEncontrado != null)
            {
                CmbNotificador.SelectedItem = itemEncontrado;
                CmbNotificador.Enabled = false;
                
            }
            
            CmbTipoValor.Select();
            if (OpcionFormulario == "Actualizar")
            {
                Llamardatos();
            }
            else
            {
                DTIFechaNotificacion.Text = Convert.ToString(DateTime.Now.Date);
                DTIFechaProxVisita.Value = DateTime.Now.Date;//"01/01/1900";
                DTIFechaVisita.Text = DateTime.Now.Date.ToString();
                //DTIFechaVisita.Text = Convert.ToString(DateTime.Now.Date); ;//"01/01/1900";
                DTIFNotificacionCedulon.Text = Convert.ToString(DateTime.Now.Date);//"01/01/1900";                
            }
        }
        public void Llamardatos()
        {
            var oEntidad = new ENCargo_Notificacion();
            oEntidad.CODIGO = ArregloCargo[0];
            oEntidad.NUM_CARGO = ArregloCargo[1];
            oEntidad.ANO_CARGO = ArregloCargo[2];
            oEntidad.ID_VALOR = ArregloCargo[3];
            oEntidad.NUM_VALOR = ArregloCargo[4];
            oEntidad.ANO_VALOR = ArregloCargo[5];
            // LLamamos los datos del Cargo de Notificación para su actualización
            odttable = LNotificaciones.ListarCargoNotificacion(oEntidad, 8);
            if (odttable.Rows.Count > 0)
            {
                this.CmbTipoValor.SelectedValue = odttable.Rows[0]["id_valor"].ToString();
                this.TxtAnnoCargo.Text = odttable.Rows[0]["ano_cargo"].ToString();
                this.TxtAnnoValor.Text = odttable.Rows[0]["ano_valor"].ToString();
                this.TxtNroCargo.Text = odttable.Rows[0]["num_cargo"].ToString();
                this.TxtNroValor.Text = odttable.Rows[0]["num_valor"].ToString();
                this.TxtMonto.Text = odttable.Rows[0]["Monto"].ToString();
                this.CmbNotificador.SelectedValue = odttable.Rows[0]["id_notificador"].ToString();
                this.cmbParentesco.SelectedValue = odttable.Rows[0]["id_parentesco"].ToString();
                this.TxtCodigoValor.Text = odttable.Rows[0]["codigo"].ToString();
                this.TxtDocumentoValor.Text = odttable.Rows[0]["nro_documento"].ToString();
                this.TxtDocIdentidadRecepcion.Text = odttable.Rows[0]["nro_documento"].ToString();
                this.TxtNroPisos.Text = odttable.Rows[0]["n_pisos"].ToString();
                this.TxtColorCedulon.Text = odttable.Rows[0]["c_fachada"].ToString();
                this.TxtNombreRecepcion.Text = odttable.Rows[0]["nombre"].ToString();
                this.TxtDireccionRecepcion.Text = odttable.Rows[0]["direc_fiscal"].ToString();
                this.TxtNroSuministro.Text = odttable.Rows[0]["n_suministro"].ToString();
                this.DTIFechaNotificacion.Value = Convert.ToDateTime(odttable.Rows[0]["f_notifica"].ToString()); // preguntar a vaez si es solo fecha
                this.DTIFechaVisita.Value = Convert.ToDateTime(odttable.Rows[0]["f_visita1"].ToString()); // preguntar a vaez si es solo fecha
                this.DTIFechaProxVisita.Value = Convert.ToDateTime(odttable.Rows[0]["f_visita2"]);// preguntar a vaez si es solo fecha
                this.DTIFechaNotificacion.Value = Convert.ToDateTime(odttable.Rows[0]["f_notifica"].ToString());// preguntar a vaez si es solo fecha
                this.TxtHoraVisita.Text = odttable.Rows[0]["h_visita1"].ToString();
                this.TxtHoraProximaVisita.Text = odttable.Rows[0]["h_visita2"].ToString();
                this.DTIFNotificacionCedulon.Value = Convert.ToDateTime(odttable.Rows[0]["f_cedulon"].ToString());// preguntar a vaez si es solo fecha
                this.CmbVisita.SelectedIndex = (int)Math.Round(Convert.ToDouble(odttable.Rows[0]["nro_visita"].ToString()) - 1d);
                this.CmbSituacion.SelectedIndex = Convert.ToInt32(odttable.Rows[0]["flg_situacion"].ToString());
                this.CmbFirma.SelectedIndex = (int)Math.Round(Convert.ToDouble(odttable.Rows[0]["id_firma"].ToString()) - 1d);
                this.BtnValidar.PerformClick();
            }
            else
            {
                MessageBox.Show("NO SE ENCONTRARON CARGOS DE NOTIFICACION", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        public void CargarCombos()
        {
            mTemporal.LlenaChoice(this.CmbTipoValor, "SELECT id_valor, nomb_val FROM Contenedor.TblTipo_valor WHERE estado = '1' and anno_gen = year(getdate()) ORDER BY 2", "Contenedor.TblTipo_valor");
            mTemporal.LlenaChoice(this.cmbParentesco, "select tipo_relacion_id,descripcion from rentas.rc_tipo_relacion WHERE estado_id = 1 ORDER BY 2", "rentas.rc_tipo_relacion");
            mTemporal.LlenaChoice(this.CmbNotificador, "SELECT codigo_autoridad,codigo_area from dbo.ma_m_autoridad_municipal WHERE FLAG=1 order by descripcion", "dbo.ma_m_autoridad_municipal"); //SELECT codigo_autoridad,codigo_area+'-'+descripcion from dbo.ma_m_autoridad_municipal WHERE FLAG=1 order by descripcion
        }
        public void LimpiarControles()
        {
            if (this.BtnGrabar.Text == "GRABAR")
            {
                this.cmbParentesco.SelectedItem = (object)-1;
                // TxtAnnovalor.Text = ""
                this.TxtColorCedulon.Text = "";
                this.TxtDireccionCedulon.Text = "";
                this.TxtDireccionRecepcion.Text = "";
                this.TxtDocIdentidadRecepcion.Text = "";
                this.TxtNombreRecepcion.Text = "";
                this.TxtNroSuministro.Text = "";
                // TxtNroValor.Text = ""
                this.DTIFechaNotificacion.Text = Convert.ToString(DateTime.Now.Date);
                this.DTIFechaProxVisita.Text = Convert.ToString(DateTime.Now.Date);
                this.DTIFechaVisita.Text = Convert.ToString(DateTime.Now.Date);
                this.DTIFNotificacionCedulon.Text = Convert.ToString(DateTime.Now.Date);
                this.TxtHoraEntregaCedulon.Text = "";
                this.TxtHoraProximaVisita.Text = "";
                this.TxtHoraVisita.Text = "";
                this.TxtNroPisos.Text = "";
                this.ChkDerivar.Checked = false;
                this.TxtObservacioNoUbica.Text = "";
                this.TxtObservacionRecepcion.Text = "";
                this.CmbNoUbica.SelectedIndex = -1;
                this.TxtParentesco_Detalle.Text = "";

            }
            if (this.BtnGrabar.Text == "ACTUALIZAR")
            {
                this.CmbTipoValor.Enabled = false;
                this.TxtAnnoCargo.Enabled = false;
                this.TxtAnnoValor.Enabled = false;
                this.TxtNroCargo.Enabled = false;
                this.TxtNroValor.Enabled = false;
                this.TxtMonto.Enabled = false;
                CmbNotificador.Enabled = false;

            }
        }
        public void ActivaRadios(int Pestaña)
        {
            this.STCDatos.Enabled = true;
            if (Pestaña == 0)
            {
                this.STIRecepcion.Enabled = true;
                this.STIRAviso.Enabled = false;
                this.STIRCedulon.Enabled = false;
                this.STIRActa.Enabled = false;
                this.STIRNoUbica.Enabled = false;
                this.STCDatos.SelectedTabIndex = Pestaña;
            }
            if (Pestaña == 1)
            {
                this.STIRecepcion.Enabled = false;
                this.STIRAviso.Enabled = true;
                this.STIRCedulon.Enabled = false;
                this.STIRActa.Enabled = false;
                this.STIRNoUbica.Enabled = false;
                this.STCDatos.SelectedTabIndex = Pestaña;
            }
            if (Pestaña == 2)
            {
                this.STIRecepcion.Enabled = false;
                this.STIRAviso.Enabled = false;
                this.STIRCedulon.Enabled = false;
                this.STIRActa.Enabled = true;
                this.STIRNoUbica.Enabled = false;
                this.STCDatos.SelectedTabIndex = Pestaña;

            }
            if (Pestaña == 3)
            {
                this.STIRecepcion.Enabled = false;
                this.STIRAviso.Enabled = false;
                this.STIRCedulon.Enabled = true;
                this.STIRActa.Enabled = false;
                this.STIRNoUbica.Enabled = false;
                this.STCDatos.SelectedTabIndex = Pestaña;
                STIRCedulon.Focus();
                STIRCedulon.Expanded = true;
            }
            if (Pestaña == 4)
            {
                this.STIRecepcion.Enabled = false;
                this.STIRAviso.Enabled = false;
                this.STIRCedulon.Enabled = false;
                this.STIRActa.Enabled = false;
                this.STIRNoUbica.Enabled = true;
                this.STCDatos.SelectedTabIndex = Pestaña;                
            }
        }

        public void ValidaDatosDetalleError()
        {
            int cmbvisita = 1, cmbsituacion = 1, txtnombrerecepcion = 1, cmbparentesco = 1, txtdireccionrecepcion = 1, txtidentidadrecepcion = 1, dtifechanotificacion = 1,
                dtifechanotificacionmayor = 1, dtifechavisita = 1, dtifechavisitamayor = 1, dtifechaproxima = 1, dtifechaproximamenor = 1, dtifechanotificacioncedulon = 1,
                dtifechanotificacioncedulonmayor = 1, txthoraentregacedulon = 1, txtdireccioncedulon = 1, txtnropisos = 1, txtcolorcedulon = 1, txtnrosuministro = 1;
            errorProvider1.Clear();
            _resultadoValor = 1;
            _resultadoValidarPestañas = 1;
            _resultadoValidarCombo = 1;
            validarErrorValor();
            if (CmbVisita.SelectedIndex == -1)
            {
                errorProvider1.SetError(CmbVisita, "DEBE ELEGIR UN NUMERO DE VISITA");
                cmbvisita = 0;
            }
            if (CmbSituacion.SelectedIndex == -1)
            {
                errorProvider1.SetError(CmbSituacion, "DEBE ELEGIR UNA SITUACION");
                cmbsituacion = 0;
            }
            _resultadoValidarCombo = (cmbvisita == 1 && cmbsituacion == 1) ? 1 : 0;
            if (STIRecepcion.IsSelected)
            {
                if (string.IsNullOrEmpty(TxtNombreRecepcion.Text))
                {
                    errorProvider1.SetError(TxtNombreRecepcion, "DEBE INGRESAR EL NOMBRE DE LA PERSONA QUE RECEPCIONA");
                    txtnombrerecepcion = 0;
                }
                if (string.IsNullOrEmpty(cmbParentesco.Text))
                {
                    errorProvider1.SetError(cmbParentesco, "DEBE INGRESAR EL PARENTESCO DE LA PERSONA QUE RECEPCIONA");
                    cmbparentesco = 0;
                }
                if (string.IsNullOrEmpty(TxtDireccionRecepcion.Text))
                {
                    errorProvider1.SetError(TxtDireccionRecepcion, "DEBE INGRESAR LA DIRECCION DE LA PERSONA QUE RECEPCIONA");
                    txtdireccionrecepcion = 0;
                }
                if (string.IsNullOrEmpty(TxtDocIdentidadRecepcion.Text))
                {
                    errorProvider1.SetError(TxtDocIdentidadRecepcion, "DEBE INGRESAR EL DNI DE LA PERSONA QUE RECEPCIONA");
                    txtidentidadrecepcion = 0;
                }
                if (string.IsNullOrEmpty(DTIFechaNotificacion.Text))
                {
                    errorProvider1.SetError(DTIFechaNotificacion, "DEBE INGRESAR LA FECHA QUE SE NOTIFICO");
                    dtifechanotificacion = 0;
                }
                if (DTIFechaNotificacion.Value > DateTime.Now)
                {
                    errorProvider1.SetError(DTIFechaNotificacion, "LA FECHA DE NOTIFICACION NO PUEDE SER MAYOR A LA ACTUAL");
                    dtifechanotificacionmayor = 0;
                }
                if (string.IsNullOrEmpty(TxtParentesco_Detalle.Text))
                {
                    errorProvider1.SetError(TxtParentesco_Detalle, "SE DEBE INGRESAR EL TIPO DE PARENTESCO \"OTROS\"");
                    cmbparentesco = 0;
                }
                _resultadoValidarPestañas = (txtnombrerecepcion == 1 && cmbparentesco == 1 && txtdireccionrecepcion == 1 && txtidentidadrecepcion == 1 && dtifechanotificacion == 1 && dtifechanotificacionmayor == 1) ? 1 : 0;

            }
            if (STIRAviso.IsSelected)
            {
                if (string.IsNullOrEmpty(DTIFechaVisita.Text))
                {
                    errorProvider1.SetError(DTIFechaVisita, "DEBE INGRESAR LA FECHA DE VISITA");
                    dtifechavisita = 0;
                }
                if (DTIFechaVisita.Value > DateTime.Now)
                {
                    errorProvider1.SetError(DTIFechaVisita, "LA FECHA DE VISITA NO PUEDE SER MAYOR A LA FECHA ACTUAL");
                    dtifechavisitamayor = 0;
                }
                if (string.IsNullOrEmpty(DTIFechaProxVisita.Text))
                {
                    errorProvider1.SetError(DTIFechaProxVisita, "DEBE INGRESAR LA FECHA DE LA PROXIMA VISITA");
                    dtifechaproxima = 0;
                }
                if (DTIFechaProxVisita.Value < DateTime.Now)
                {
                    errorProvider1.SetError(DTIFechaProxVisita, "LA FECHA DE LA PROXIMA VISITA NO DEBE SER MENOR A LA FECHA ACTUAL");
                    dtifechaproximamenor = 0;
                }
                _resultadoValidarPestañas = (dtifechavisita == 1 && dtifechavisitamayor == 1 && dtifechaproxima == 1 && dtifechaproximamenor == 1) ? 1 : 0;
            }
            if (STIRCedulon.IsSelected)
            {
                if (string.IsNullOrEmpty(DTIFNotificacionCedulon.Text))
                {
                    errorProvider1.SetError(DTIFNotificacionCedulon, "DEBE INGRESAR LA FECHA DE NOTIFICAICON DEL CEDULON");
                    dtifechanotificacioncedulon = 0;
                }
                if (Convert.ToDateTime(this.DTIFNotificacionCedulon.Text) > DateTime.Now)
                {
                    errorProvider1.SetError(DTIFechaNotificacion, "LA FECHA DE NOTIFICACION DEL CEDULON DEBE SER MAYOR A LA FECHA ACTUAL");
                    dtifechanotificacioncedulonmayor = 0;
                }
                if (TxtHoraEntregaCedulon.Text == "  :")
                {
                    errorProvider1.SetError(TxtHoraEntregaCedulon, "DEBE INGRESAR LA HORA DE ENTREGA DEL CARGO");
                    txthoraentregacedulon = 0;
                }
                if (string.IsNullOrEmpty(TxtDireccionCedulon.Text))
                {
                    errorProvider1.SetError(TxtDireccionCedulon, "DEBE INGRESAR LA DIRECCION DEL CARGO");
                    txtdireccioncedulon = 0;
                }
                if (string.IsNullOrEmpty(TxtNroPisos.Text))
                {
                    errorProvider1.SetError(TxtNroPisos, "DEBE INGRESAR EL NUMERO DE PISOS");
                    txtnropisos = 0;
                }
                if (string.IsNullOrEmpty(TxtColorCedulon.Text))
                {
                    errorProvider1.SetError(TxtColorCedulon, "DEBE INGRESAR EL COLOR DE LA FACHADA");
                    txtcolorcedulon = 0;
                }
                if (string.IsNullOrEmpty(TxtNroSuministro.Text))
                {
                    errorProvider1.SetError(TxtNroSuministro, "DEBE INGRESAR EL NUMERO DE SUMINISTRO");
                    txtnrosuministro = 0;
                }
                _resultadoValidarPestañas = (dtifechanotificacioncedulon == 1 && dtifechanotificacioncedulonmayor == 1 && txthoraentregacedulon == 1 && txtdireccioncedulon == 1 && txtnropisos == 1 && txtcolorcedulon == 1 && txtnrosuministro == 1) ? 1 : 0;
            }
        }

        private void BtnGrabar_Click(object sender, EventArgs e)
        {
            int _nrocargo = 1, _annocargo = 1;
            ValidaDatosDetalleError();
            if (CmbNotificador.SelectedIndex == -1)
            {
                errorProvider1.SetError(CmbNotificador, "DEBE SELECCIONAR UN NOTIFICADOR");
            }
            if (string.IsNullOrEmpty(TxtNroCargo.Text))
            {
                errorProvider1.SetError(TxtNroCargo, "DEBE INGRESAR UN NUMERO DE CARGO");
                _nrocargo = 0;
            }
            if (string.IsNullOrEmpty(TxtAnnoCargo.Text))
            {
                errorProvider1.SetError(TxtAnnoCargo, "DEBE INGRESAR EL AÑO DEL CARGO");
                _annocargo = 0;
            }
            _resultadoValidarDatosCargo = (_nrocargo == 1 && _annocargo == 1) ? 1 : 0;

            string valor = CmbTipoValor.SelectedValue.ToString();
            if (valor != "16")
            {
                if (_resultadoValor == 1 && _resultadoValidarPestañas == 1 && _resultadoValidarCombo == 1 && CmbNotificador.SelectedIndex != -1 && _resultadoValidarDatosCargo == 1)
                {
                    if (this.BtnGrabar.Text == "GRABAR")
                    {
                        Grabar();
                    }
                    else if (this.BtnGrabar.Text == "ACTUALIZAR")
                    {
                        Actualizar();
                    }
                }
            }
            else
            {
                if (_resultadoValor == 1 &&  CmbNotificador.SelectedIndex != -1 && _resultadoValidarDatosCargo == 1)
                {
                    if (this.BtnGrabar.Text == "GRABAR")
                    {
                        Grabar();
                    }                   
                }
            }
            
            //this.BtnGrabar.Enabled = false;
        }
        public void Grabar()
        {

            DialogResult resp = MessageBox.Show("¿DESEA REGISTRAR EL CARGO DE NOTIFICACION?", "SISTEMA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resp == DialogResult.Yes)
            {
                var oEntidad = new ENCargo_Notificacion();
                int opcion;
                oEntidad.CODIGO = TxtCodigoValor.Text;
                oEntidad.ID_VALOR = CmbTipoValor.SelectedValue.ToString();
                oEntidad.NUM_VALOR = TxtNroValor.Text;
                oEntidad.ANO_VALOR = TxtAnnoValor.Text;
                oEntidad.NUM_CARGO = TxtNroCargo.Text;
                oEntidad.ANO_CARGO = TxtAnnoCargo.Text;

                oEntidad.ID_NOTIFICADOR = CmbNotificador.SelectedValue.ToString(); // se valido para que siempre elijan un notificador
                oEntidad.F_NOTIFICA = (!STIRecepcion.IsSelected) ? DateTime.Now.ToString() : DTIFechaNotificacion.Text; // es string
                oEntidad.F_VISITA1 = (!STIRAviso.IsSelected) ? Convert.ToDateTime("01/01/1900").Date : Convert.ToDateTime(DTIFechaVisita.Text).Date; // sugerir que sea tipo string el campo en la tabla
                oEntidad.F_VISITA2 = (!STIRAviso.IsSelected) ? Convert.ToDateTime("01/01/1900").Date : Convert.ToDateTime(DTIFechaProxVisita.Text).Date;
                oEntidad.F_CEDULON = (!STIRCedulon.IsSelected) ? Convert.ToDateTime("01/01/1900").Date : Convert.ToDateTime(DTIFNotificacionCedulon.Text).Date;
                oEntidad.H_VISITA1 = (!STIRAviso.IsSelected) ? "" : TxtHoraVisita.Text;
                oEntidad.H_VISITA2 = (!STIRAviso.IsSelected) ? "" : TxtHoraProximaVisita.Text;
                oEntidad.H_CEDULON = (!STIRCedulon.IsSelected) ? "" : TxtHoraEntregaCedulon.Text;

                oEntidad.N_PISOS = (!STIRCedulon.IsSelected) ? "" : TxtNroPisos.Text;
                oEntidad.C_FACHADA = (!STIRCedulon.IsSelected) ? "" : TxtColorCedulon.Text;
                oEntidad.ID_PARENTESCO = (!STIRecepcion.IsSelected) ? "" : cmbParentesco.SelectedValue.ToString();
                oEntidad.NOMBRE = (!STIRecepcion.IsSelected) ? "" : TxtNombreRecepcion.Text;
                oEntidad.NRO_DOCUMENTO = (!STIRecepcion.IsSelected) ? "" : TxtDocIdentidadRecepcion.Text;
                oEntidad.DIREC_FISCAL = (!STIRecepcion.IsSelected) ? "" : TxtDireccionRecepcion.Text;
                oEntidad.NRO_VISITA = CmbVisita.SelectedIndex + 1; // se podria poner priemra o segunda
                oEntidad.FLG_SITUACION = CmbSituacion.SelectedIndex.ToString();
                oEntidad.ID_FIRMA = (CmbFirma.SelectedIndex == -1) ? 0 : CmbFirma.SelectedIndex; // se podria poner que elija entre "si" y "no" ya que esta en duro
                oEntidad.DIR_CEDULON = TxtDireccionCedulon.Text;
                oEntidad.N_SUMINISTRO = TxtNroSuministro.Text;
                oEntidad.OBSERVACION = (STIRecepcion.IsSelected)? TxtObservacionRecepcion.Text.Trim(): ((STIRNoUbica.IsSelected)? CmbNoUbica.Text+": "+TxtObservacioNoUbica.Text.Trim() : "");
                oEntidad.DERIVAR_DRFT = (ChkDerivar.Checked == true) ? 1 : 0;
                oEntidad.ESTADO = 1;
                oEntidad.USUARIO_ACT = "";// jmozo
                oEntidad.FECHA_ACT = Convert.ToDateTime("01/01/1900").Date;
                oEntidad.ESTACION_REG = Environment.MachineName.ToString();
                oEntidad.USUARIO_REG = Environment.UserName.ToString();//FuncionesGlobales.Usuario; //no devuelve nada
                oEntidad.MONTO = (string.IsNullOrEmpty(TxtMonto.Text.Trim())) ? Convert.ToDecimal(0.00): Convert.ToDecimal(TxtMonto.Text);
                oEntidad.OTRO_CEDULON = (!STIRCedulon.IsSelected) ? "" : txtOtroCedulon.Text;
                oEntidad.PARENTESCO_DETALLE = TxtParentesco_Detalle.Text.Trim();

                opcion = 2;
                string resultado = LNotificaciones.GrabarCargoNotificacion(oEntidad, opcion);
                if (resultado == "OK")
                {
                    MessageBox.Show("SE GRABO CORRECTAMENTE", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("SE PRODUJO UN ERROR", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public void Actualizar()
        {

            DialogResult resp = MessageBox.Show("¿DESEA ACTUALZIAR EL CARGO DE NOTIFICACION?", "SISTEMA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resp == DialogResult.Yes)
            {
                var oEntidad = new ENCargo_Notificacion();
                var oLogica = new LNotificaciones();
                var dt = new DataTable();
                int opcion;
                oEntidad.CODIGO = TxtCodigoValor.Text;
                oEntidad.ID_VALOR = Convert.ToString(CmbTipoValor.SelectedValue);
                oEntidad.NUM_VALOR = TxtNroValor.Text;
                oEntidad.ANO_VALOR = TxtAnnoValor.Text;
                oEntidad.NUM_CARGO = TxtNroCargo.Text;
                oEntidad.ANO_CARGO = TxtAnnoCargo.Text;

                oEntidad.ID_NOTIFICADOR = Convert.ToString(CmbNotificador.SelectedValue);
                oEntidad.F_NOTIFICA = DTIFechaNotificacion.Text;
                oEntidad.F_VISITA1 = Convert.ToDateTime(DTIFechaVisita.Text);
                oEntidad.F_VISITA2 = Convert.ToDateTime(DTIFechaProxVisita.Text);
                oEntidad.F_CEDULON = Convert.ToDateTime(DTIFNotificacionCedulon.Text);
                oEntidad.H_VISITA1 = TxtHoraVisita.Text;
                oEntidad.H_VISITA2 = TxtHoraProximaVisita.Text;
                oEntidad.H_CEDULON = TxtHoraEntregaCedulon.Text;

                oEntidad.N_PISOS = TxtNroPisos.Text;
                oEntidad.C_FACHADA = TxtColorCedulon.Text;
                oEntidad.ID_PARENTESCO = Convert.ToString(cmbParentesco.SelectedValue);
                oEntidad.NOMBRE = TxtNombreRecepcion.Text;
                oEntidad.NRO_DOCUMENTO = TxtDocIdentidadRecepcion.Text;
                oEntidad.DIREC_FISCAL = TxtDireccionRecepcion.Text;
                oEntidad.NRO_VISITA = CmbVisita.SelectedIndex + 1;
                oEntidad.FLG_SITUACION = CmbSituacion.SelectedIndex.ToString();
                oEntidad.ID_FIRMA = (CmbFirma.SelectedIndex == -1) ? 0 : CmbFirma.SelectedIndex;
                oEntidad.DIR_CEDULON = TxtDireccionCedulon.Text;
                oEntidad.N_SUMINISTRO = TxtNroSuministro.Text;
                oEntidad.OBSERVACION = "";
                oEntidad.DERIVAR_DRFT = (ChkDerivar.Checked == true) ? 1 : 0;
                oEntidad.ESTADO = 1;
                oEntidad.USUARIO_ACT = Variables.cod_usuario;
                oEntidad.FECHA_ACT = DateTime.Now;
                oEntidad.ESTACION_ACT = Environment.MachineName.ToString();
                oEntidad.MONTO = Convert.ToDecimal(TxtMonto.Text);
                oEntidad.OTRO_CEDULON = (!STIRCedulon.IsSelected) ? "" : TxtNroPisos.Text;

                opcion = 6;
                string resultado = LNotificaciones.ActualizarCargoNotificacion(oEntidad, opcion);
                if (resultado == "1")
                {
                    MessageBox.Show("ACTUALIZACION EXITOSA", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("HUBO UN ERROR", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
        private void BtnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿ESTAS SEGURO DE SALIR?", "SISTEMA", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
        private void TxtAnnoValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            FuncionesGlobales.SoloEnteros(sender, (KeyPressEventArgs)e);
        }

        private void TxtAnnoCargo_KeyPress(object sender, KeyPressEventArgs e)
        {
            FuncionesGlobales.SoloEnteros(sender, (KeyPressEventArgs)e);
        }

        private void TxtNroCargo_KeyPress(object sender, KeyPressEventArgs e)
        {
            FuncionesGlobales.SoloEnteros(sender, (KeyPressEventArgs)e);
        }
        private void TxtNroValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            FuncionesGlobales.SoloEnteros(sender, (KeyPressEventArgs)e);
        }
        private void BtnValidar_Click(object sender, EventArgs e)
        {
            //BtnGrabar.Enabled = true;
            errorProvider1.Clear();
            validarErrorValor();
            if (_resultadoValor == 1)
            {
                string valor = CmbTipoValor.SelectedValue.ToString();
                if (valor == "16")
                {
                    ValidarRG();
                }
                else
                {
                    ValidarValor();
                }               
            }
        }
        public void validarErrorValor()
        {
            int cmbtipovalor = 1, txtnrovalor = 1, txtannovalor = 1;
            if (CmbTipoValor.SelectedIndex == -1)
            {
                errorProvider1.SetError(CmbTipoValor, "DEBE ELEGIR UN TIPO DE VALOR");
                cmbtipovalor = 0;
            }
            if (string.IsNullOrEmpty(TxtNroValor.Text))
            {
                errorProvider1.SetError(TxtNroValor, "DEBE ESCRIBIR EL NUMERO DE VALOR");
                txtnrovalor = 0;
            }
            if (string.IsNullOrEmpty(TxtAnnoValor.Text))
            {
                errorProvider1.SetError(TxtAnnoValor, "DEBE ESCRIBIR UN AÑO VALIDO");
            }
            _resultadoValor = (cmbtipovalor == 1 && txtnrovalor == 1 && txtannovalor == 1) ? 1 : 0;
        }
        public void ValidarValor()
        {
            int Opcion;
            var oEntidad = new ENMValores();
            //var oLogica = new SIGRentas.Logica.LMValores();
            DataTable dtTemp;

            oEntidad.ID_VALOR = Convert.ToString(this.CmbTipoValor.SelectedValue);
            oEntidad.NUM_VAL = this.TxtNroValor.Text;
            oEntidad.ANO_VAL = this.TxtAnnoValor.Text;
            Opcion = 9;

            odttable = LMValores.CargarDatosValor(oEntidad, Opcion);

            if (odttable.Rows.Count > 0)
            {
                dtTemp = mTemporal.EjecutaSelect($"Select imp_reaj+costo_emis+mora Total FROM Rentas.dvalores WHERE id_valor = {CmbTipoValor.SelectedValue} and num_val = {TxtNroValor.Text} and ano_val = {TxtAnnoValor.Text} ", "TBAuxiliar");
                if (dtTemp.Rows.Count > 0)
                {
                    this.TxtMonto.Text = dtTemp.Rows[0]["Total"].ToString();
                }                
                Opcion = 4;

                this.TxtCodigoValor.Text = odttable.Rows[0]["codigo"].ToString().Trim();
                this.TxtNombreValor.Text = odttable.Rows[0]["Nombre"].ToString().Trim();
                this.TxtDireccionValor.Text = odttable.Rows[0]["Direccion"].ToString().Trim();
                this.TxtDocumentoValor.Text = odttable.Rows[0]["documento"].ToString().Trim();
                odtdetalle = LMValores.CargarDetalleValor(oEntidad, Opcion);
                if (odtdetalle.Rows.Count > 0)
                {
                    this.ObjectListView1.Refresh();
                    this.ObjectListView1.SetObjects(GetDetalle());
                    this.ObjectListView1.Sort(this.OlvColumn1, SortOrder.Ascending);
                    this.ObjectListView1.ShowGroups = false;
                    this.ObjectListView1.BuildList();

                    this.BtnGrabar.Enabled = true;
                    TxtNroCargo.Text = TxtNroValor.Text;
                    TxtAnnoCargo.Text = TxtAnnoValor.Text;
                    TxtNroCargo.ReadOnly = true;
                    TxtAnnoCargo.ReadOnly = true;
                    ExistePagos();
                    if (_resultadoPago == "PAGO")
                    {
                        MessageBox.Show("SE ENCONTRO PAGOS REALIZADOS EN EL VALOR, VERIFICAR", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        BtnGrabar.Enabled = false;
                    }
                    else
                    {
                        BtnGrabar.Enabled = true;
                    }
                }
                else
                {
                    ObjectListView1.Items.Clear();
                    MessageBox.Show("NO HAY UN VALOR CREADO","SISTEMA",MessageBoxButtons.OK,MessageBoxIcon.Stop);
                    BtnGrabar.Enabled = false;
                }                
            }
            else
            {
                MessageBox.Show("NO EXISTE EL VALOR INGRESADO, VERIFIQUE DE NUEVO", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                this.BtnGrabar.Enabled = false;
            }
        }
        private void ExistePagos()
        {
            string codigo = odttable.Rows[0]["codigo"].ToString().Trim();

            foreach (DataRow fila in odtdetalle.Rows)
            {
                if (fila["periodo"].ToString().Trim() != "")
                {
                    string anno_valor = TxtAnnoValor.Text;//fila["anno"].ToString().Trim();
                    string tipo_rec = fila["tipo_rec"].ToString().Trim();
                    string periodo = fila["periodo"].ToString().Trim();
                    DataTable dtPago = LMValores.VerificarPagosValor(codigo, anno_valor, tipo_rec, periodo);
                    _resultadoPago = dtPago.Rows[0][0].ToString();
                    if (_resultadoPago == "PAGO")
                    {
                        break;
                    }
                }

            }
        }
        private List<ENDetalleValor> GetDetalle()
        {
            var list = new List<ENDetalleValor>();
            double Total;
            if (odtdetalle != null)
            {
                for (int i = 0, loopTo = odtdetalle.Rows.Count - 1; i <= loopTo; i++)
                {
                    if (Convert.ToBoolean(Operators.ConditionalCompareObjectGreater(odtdetalle.Rows[i][1], 0, false)))
                    {
                        Total = Convert.ToDouble(odtdetalle.Rows[i][12]);

                        list.Add(new ENDetalleValor(Convert.ToString(odtdetalle.Rows[i][2]), Convert.ToString(odtdetalle.Rows[i][7]), odtdetalle.Rows[i][3].ToString(), Convert.ToString(odtdetalle.Rows[i][8]), Convert.ToString(odtdetalle.Rows[i][9]), Convert.ToDouble(odtdetalle.Rows[i][11]).ToString("####0.00"), Convert.ToDouble(odtdetalle.Rows[i][10]).ToString("####0.00"), Convert.ToDouble(odtdetalle.Rows[i][12]).ToString("####0.00")));
                    }
                }
            }
            return list;
        }
        private void TxtCopyNombre_Click(object sender, EventArgs e)
        {
            this.TxtNombreRecepcion.Text = this.TxtNombreValor.Text;
            this.TxtDocIdentidadRecepcion.Text = this.TxtDocumentoValor.Text;
        }
        private void TxtCopyDireccion_Click(object sender, EventArgs e)
        {
            this.TxtDireccionRecepcion.Text = this.TxtDireccionValor.Text;
        }
        private void TxtAnnoValor_TextChanged(object sender, EventArgs e)
        {
            //FuncionesGlobales.SoloEnteros(sender, (KeyPressEventArgs)e); // manda error si pongo solo fecha
        }
        private void TxtAnnoCargo_TextChanged(object sender, EventArgs e)
        {
            //FuncionesGlobales.SoloEnteros(sender, (KeyPressEventArgs)e);
        }
        private void TxtNroValor_Leave(object sender, EventArgs e)
        {
            if (TxtNroValor.Text.Trim().Length > 0 && TxtNroValor.Text.Trim().Length < 7)
            {

                TxtNroValor.Text = TxtNroValor.Text.PadLeft(7, '0');
            }
        }



        private void CmbTipoValor_SelectedValueChanged(object sender, EventArgs e)
        {
            string valor = CmbTipoValor.SelectedValue.ToString();
            if (valor == "16")
            {
                lblnumvalor.Text = "Nro Resolución";
                lblannovalor.Text = "Año Resolución";
                lblnotificador.Visible = false;
                lblmonto.Visible = false;
                TxtMonto.Visible = false;
                PanelDetalleValor.Visible = false;
                PnlVisitas.Visible = false;
                PanelPestañas.Visible = false;

            }
            else
            {
                lblnumvalor.Text = "Nro Valor";
                lblannovalor.Text = "Año Valor";
                lblnotificador.Visible = true;
                lblmonto.Visible = true;
                TxtMonto.Visible = true;
                PanelDetalleValor.Visible = true;
                PnlVisitas.Visible = true;
                PanelPestañas.Visible = true;
            }
        }
        private void ValidarRG()
        {
            string numvalor = TxtNroValor.Text.TrimStart('0');
            DataTable dtRG = LNotificaciones.ValidarRG(numvalor, TxtAnnoValor.Text.Trim());
            if (dtRG.Rows[0]["EXISTE"].ToString() == "EXISTE")
            {
                TxtNroCargo.Text = TxtNroValor.Text; //dtRG.Rows[0]["res_nro_resolucion"].ToString();
                TxtAnnoCargo.Text = TxtAnnoValor.Text.Trim(); //Convert.ToDateTime(dtRG.Rows[0]["res_fec_resolucion"].ToString()).Year.ToString();
                BtnGrabar.Enabled = true;
            }
            else
            {
                
                MessageBox.Show("EL VALOR INGRESADO NO EXISTE","SISTEMA",MessageBoxButtons.OK,MessageBoxIcon.Stop);
                BtnGrabar.Enabled = false;
            }            
        }

        private void cmbParentesco_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmbParentesco.Text == "Otro")
            {
                TxtParentesco_Detalle.Visible = true;
                TxtParentesco_Detalle.Text = "";             
            }
            else
            {
                TxtParentesco_Detalle.Text = cmbParentesco.Text;
                TxtParentesco_Detalle.Visible = false;
            }
        }

       

        private void CmbSituacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            BtnGrabar.Enabled = true;
            if (this.CmbSituacion.SelectedIndex == 0)
            {
                if (CmbVisita.SelectedIndex != -1)
                {
                    LimpiarControles();
                    ActivaRadios(0);
                }
            }
            if (this.CmbSituacion.SelectedIndex == 1)
            {
                LimpiarControles();
                if (CmbVisita.Text.Trim() == "Primera")
                {
                    LimpiarControles();
                    ActivaRadios(3);
                }
                if (CmbVisita.Text.Trim() == "Segunda")
                {
                    LimpiarControles();
                    ActivaRadios(3); // cedulon
                }
            }
            if (this.CmbSituacion.SelectedIndex == 2)
            {
                if (CmbVisita.SelectedIndex != -1)
                {
                    LimpiarControles();
                    ActivaRadios(2); // acta de registro
                }
            }
            if (CmbSituacion.SelectedIndex == 3)
            {
                LimpiarControles();
                ActivaRadios(4);
            }
        }
    }
}
