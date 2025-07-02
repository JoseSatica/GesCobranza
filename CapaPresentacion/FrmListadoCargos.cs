using CapaEntidades;
using CapaNegocio;
using LibreriaSAT;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmListadoCargos : Form
    {

        public string OpcionFormulario;
        private DataTable dt;
        private ENCargo_Notificacion oEntidad = new ENCargo_Notificacion();
        private int _existeEntrega;
        private DataTable dtDetalle;
        private string _resultadoPago;
        private DataTable tablaenvio;
        public FrmListadoCargos()
        {
            InitializeComponent();
        }

        private void FrmListadoCargos_Load(object sender, EventArgs e)
        {
            ActivaPaneles("Cargo");
            LlamarCargos();
            ListarCargos();
        }
        public event EventHandler LlamarCargoNotificacionesNuevo;
        private void BtnNuevoCargo_Click(object sender, EventArgs e)
        {
            LlamarCargoNotificacionesNuevo?.Invoke(this, EventArgs.Empty);
        }
        public event EventHandler LlamarCargoNotificacionesActualizar;
        private void BtnActualizarCargo_Click(object sender, EventArgs e)
        {
            if (this.LVListadoValores.Items.Count > 0 && this.LVListadoValores.SelectedItems.Count > 0)
            {
                if (_existeEntrega == 0)
                {
                    MessageBox.Show("YA SE ENTREGO LA NOTIFICACION, NO PUEDE SEGUIR ACTUALIZANDO EL SEGUIMIENTO", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                var selected = this.LVListadoValores.SelectedItems[0];
                frmCargoNotificaciones.ArregloCargo[0] = selected.SubItems[1].Text;
                frmCargoNotificaciones.ArregloCargo[1] = selected.SubItems[11].Text;
                frmCargoNotificaciones.ArregloCargo[2] = selected.SubItems[12].Text;
                frmCargoNotificaciones.ArregloCargo[3] = selected.SubItems[10].Text;
                frmCargoNotificaciones.ArregloCargo[4] = selected.SubItems[8].Text;
                frmCargoNotificaciones.ArregloCargo[5] = selected.SubItems[9].Text;
                frmCargoNotificaciones.OpcionFormulario = "Actualizar";

                LlamarCargoNotificacionesActualizar?.Invoke(this, EventArgs.Empty);
                ListarCargos();
                PintarFilasLoad();
            }
            else
            {
                MessageBox.Show("DEBE SELECCIONAR UN REGISTRO", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnAnularCargo_Click(object sender, EventArgs e)
        {
            try
            {
                int Opcion = 9;
                DialogResult resultado = MessageBox.Show("¿DESEA ANULAR EL VALOR?", "SISTEMA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {
                    foreach (ListViewItem item in LVListadoValores.CheckedItems)
                    {
                        oEntidad.NUM_VALOR = item.SubItems[8].Text.Trim();
                        oEntidad.ANO_VALOR = item.SubItems[9].Text.Trim();
                        oEntidad.NOMBRE = Variables.cod_usuario;
                        if (item.Checked)
                        {
                            string cadena = LNotificaciones.anular_notificacion(oEntidad, Opcion);
                        }
                    }
                    ListarCargos();
                    LimpiarDetalle();
                    MessageBox.Show("SE ANULARON LOS CARGOS CORRECTAMENTE", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }             
            }
            catch (Exception ex)
            {
                MessageBox.Show($"OCURRIO UN ERROR:\n {ex}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void BtnBuscaCargo_Click(object sender, EventArgs e)
        {
            if (this.TxtCargo.Text.Trim().Equals("") & this.TxtAnnoCargo.Text.Trim().Equals(""))
            {
                MessageBox.Show("DEBE INGRESAR LOS DATOS COMPLETOS PARA CONTINUAR", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.TxtCargo.Select();
            }
            else
            {
                ValidarValor("Cargo");
                PintarFilasLoad();
                LimpiarDetalle();
            }
        }
        private void BtnBuscaValor_Click(object sender, EventArgs e)
        {
            if (this.TxtValor.Text.Trim().Equals("") & this.TxtAnnovalor.Text.Trim().Equals(""))
            {
                MessageBox.Show("DEBE INGRESAR LOS DATOS COMPLETOS PARA CONTINUAR", "Revisar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.TxtCargo.Select();
            }
            else
            {
                ValidarValor("Valor");
                PintarFilasLoad();
                LimpiarDetalle();
            }
        }

        public void ListarCargos()
        {
            this.LVListadoValores.Items.Clear();
            this.LVListadoValores.FullRowSelect = true;

            dt = LNotificaciones.listado_notificacion(5);
            foreach (DataRow row in dt.Rows)
            {
                // Crear un objeto ListViewItem con los datos del registro
                ListViewItem item = new ListViewItem(row["ROW"].ToString());
                item.SubItems.Add(row["Codigo"].ToString());
                item.SubItems.Add(row["Contribuyente"].ToString());
                item.SubItems.Add(row["Cargo"].ToString());
                item.SubItems.Add(row["Notificador"].ToString());
                // item.SubItems.Add(row("firma").ToString())
                // item.SubItems.Add(row("parentesco").ToString())
                item.SubItems.Add(row["Valor"].ToString());
                // item.SubItems.Add(row("observacion").ToString())
                item.SubItems.Add(row["Monto"].ToString());
                item.SubItems.Add(Convert.ToString(row["F_Notifica"]));
                item.SubItems.Add(Convert.ToString(row["num_valor"]));
                item.SubItems.Add(Convert.ToString(row["ano_valor"]));
                item.SubItems.Add(Convert.ToString(row["id_valor"]));
                item.SubItems.Add(Convert.ToString(row["num_CARGO"]));
                item.SubItems.Add(Convert.ToString(row["ano_cargo"]));
                item.SubItems.Add(Convert.ToString(row["ID_TBL"]));
                item.SubItems.Add(Convert.ToString(row["fecha_vencimiento"]));


                // Agregar el objeto ListViewItem al ListView
                this.LVListadoValores.Items.Add(item);

            }
            PintarFilasLoad();

        }
        public void LlamarDetalleCargo(ENCargo_Notificacion oEntidad) // llena el campo de los detalles de la notificacion
        {
            var dtTemp = new DataTable();

            dtTemp = LNotificaciones.ListarCargoNotificacion(oEntidad, 8);
            if (dtTemp.Rows.Count > 0)
            {
                this.Txt_Id.Text = dtTemp.Rows[0]["ID_TBL"].ToString();
                this.Txt_ColorFachada.Text = dtTemp.Rows[0]["c_fachada"].ToString();
                this.Txt_Derivar.Text = (dtTemp.Rows[0]["derivar_drft"].ToString() == "1") ? "Sí" : "No";
                this.Txt_DireccionCedulon.Text = dtTemp.Rows[0]["dir_cedulon"].ToString();
                this.Txt_DireccionRecepcion.Text = dtTemp.Rows[0]["direc_fiscal"].ToString();
                this.Txt_DocumentoRecepcion.Text = dtTemp.Rows[0]["nro_documento"].ToString();
                this.Txt_Estado.Text = (dtTemp.Rows[0]["estado"].ToString() == "1") ? "Activo" : "Anulado";
                this.Txt_FActualiza.Text = (dtTemp.Rows[0]["fecha_act"].ToString() == "01/01/1900 00:00:00") ? "" : dtTemp.Rows[0]["fecha_act"].ToString();
                this.Txt_FCedulon.Text = (dtTemp.Rows[0]["f_cedulon"].ToString() == "01/01/1900 00:00:00") ? "" : dtTemp.Rows[0]["f_cedulon"].ToString();
                this.Txt_Firma.Text = (dtTemp.Rows[0]["id_firma"].ToString() == "1") ? "Sí" : "No";
                this.Txt_FNotifica.Text = (dtTemp.Rows[0]["f_notifica"].ToString() == "01/01/1900 00:00:00") ? "" : dtTemp.Rows[0]["f_notifica"].ToString();
                this.Txt_FRegistro.Text = (dtTemp.Rows[0]["fecha_reg"].ToString() == "01/01/1900 00:00:00") ? "" : dtTemp.Rows[0]["fecha_reg"].ToString();
                this.Txt_FVisita1.Text = (dtTemp.Rows[0]["f_visita1"].ToString() == "01/01/1900 00:00:00") ? "" : dtTemp.Rows[0]["f_visita1"].ToString();
                this.Txt_FVisita2.Text = (dtTemp.Rows[0]["f_visita2"].ToString() == "01/01/1900 00:00:00") ? "" : dtTemp.Rows[0]["f_visita2"].ToString();
                this.Txt_HCedulon.Text = dtTemp.Rows[0]["h_cedulon"].ToString();
                this.Txt_HVisita1.Text = dtTemp.Rows[0]["h_visita1"].ToString();
                this.Txt_HVisita2.Text = dtTemp.Rows[0]["h_visita2"].ToString();
                this.Txt_NombreRecepcion.Text = dtTemp.Rows[0]["nombre"].ToString();
                this.Txt_Notificador.Text = (mTemporal.EjecutaEscalar("SELECT descripcion from dbo.ma_m_autoridad_municipal WHERE FLAG=1 and codigo_autoridad = " + dtTemp.Rows[0]["id_notificador"].ToString())).ToString();
                this.Txt_NroPisos.Text = dtTemp.Rows[0]["n_pisos"].ToString();
                this.Txt_NroSuministro.Text = dtTemp.Rows[0]["n_suministro"].ToString();
                this.Txt_NroVisita.Text = (dtTemp.Rows[0]["nro_visita"].ToString() == "1") ? "Primera" : "Segunda";
                this.Txt_Observación.Text = dtTemp.Rows[0]["observacion"].ToString();
                this.Txt_PcActualiza.Text = dtTemp.Rows[0]["estacion_act"].ToString();
                this.Txt_PcRegistro.Text = dtTemp.Rows[0]["estacion_reg"].ToString();
                this.Txt_Parentesco.Text = (string.IsNullOrEmpty(Txt_Parentesco.Text)) ? "" : mTemporal.EjecutaEscalar("select descripcion from rentas.rc_tipo_relacion WHERE estado_id = 1 and tipo_relacion_id =" + dtTemp.Rows[0]["id_parentesco"].ToString());
                this.Txt_Situacion.Text = (dtTemp.Rows[0]["flg_situacion"].ToString() == "0") ? "Sí estuvo Presente" : (dtTemp.Rows[0]["flg_situacion"].ToString() == "1") ? "No estuvo Presente" : ((dtTemp.Rows[0]["flg_situacion"].ToString() == "2") ?"No se ubicó la Dirección":"No se Ubico al Propietario");
                this.Txt_UActualiza.Text = dtTemp.Rows[0]["usuario_act"].ToString();
                this.Txt_URegistro.Text = dtTemp.Rows[0]["usuario_reg"].ToString();
                _existeEntrega = Convert.ToInt32(dtTemp.Rows[0]["flg_situacion"].ToString());
            }
        }
        private void LlamarCargos()
        {
            mTemporal.LlenaChoice(this.CmbTipoValor, "SELECT id_valor, nomb_val FROM Contenedor.TblTipo_valor WHERE estado = '1' and anno_gen = year(getdate()) ORDER BY 1", "Contenedor.TblTipo_valor");
            dt = LNotificaciones.listado_notificacion(5);
        }
        private void ActivaPaneles(string Opcion)
        {
            switch (Opcion ?? "")
            {
                case "Cargo":
                    {
                        PanelCargo.Show();
                        PanelValor.Hide();
                        CmbTipoValor.SelectedIndex = -1;
                        TxtValor.Text = "";
                        TxtAnnovalor.Text = "";
                        break;
                    }
                case "Valor":
                    {
                        PanelValor.Show();
                        PanelCargo.Hide();
                        TxtCargo.Text = "";
                        TxtAnnoCargo.Text = "";
                        break;
                    }
            }
        }
        public void ValidarValor(string Criterio)
        {
            int Opcion;
            var oEntidad = new ENCargo_Notificacion();
            var oLogica = new LNotificaciones();
            DataTable dt;

            if (Criterio == "Cargo")
            {
                Opcion = 3;
                oEntidad.NUM_CARGO = this.TxtCargo.Text;
                oEntidad.ANO_CARGO = this.TxtAnnoCargo.Text;
            }
            else
            {
                Opcion = 3;
                oEntidad.ID_VALOR = this.CmbTipoValor.SelectedValue.ToString();
                oEntidad.NUM_VALOR = this.TxtValor.Text;
                oEntidad.ANO_VALOR = this.TxtAnnovalor.Text;
            }

            dt = LNotificaciones.ListarCargoNotificacion(oEntidad, Opcion);
            this.LVListadoValores.Items.Clear();
            this.LVListadoValores.FullRowSelect = true;
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    // Crear un objeto ListViewItem con los datos del registro
                    var item = new ListViewItem(row["ROW"].ToString());
                    item.SubItems.Add(row["Codigo"].ToString());
                    item.SubItems.Add(row["Contribuyente"].ToString());
                    item.SubItems.Add(row["Cargo"].ToString());
                    item.SubItems.Add(row["Notificador"].ToString());
                    // item.SubItems.Add(row("firma").ToString())
                    // item.SubItems.Add(row("parentesco").ToString())
                    item.SubItems.Add(row["Valor"].ToString());
                    // item.SubItems.Add(row("observacion").ToString())
                    item.SubItems.Add(row["Monto"].ToString());
                    item.SubItems.Add(Convert.ToString(row["F_Notifica"]));
                    item.SubItems.Add(Convert.ToString(row["num_valor"]));
                    item.SubItems.Add(Convert.ToString(row["ano_valor"]));
                    item.SubItems.Add(Convert.ToString(row["id_valor"]));
                    item.SubItems.Add(Convert.ToString(row["num_CARGO"]));
                    item.SubItems.Add(Convert.ToString(row["ano_cargo"]));

                    // Agregar el objeto ListViewItem al ListView
                    this.LVListadoValores.Items.Add(item);
                    PintarFilasLoad();
                }
            }
            else
            {
                MessageBox.Show("NO EXISTE EL VALOR INGRESADO, VERIFIQUE LOS DATOS", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
        private void TxtAnnovalor_KeyPress(object sender, KeyPressEventArgs e)
        {
            FuncionesGlobales.SoloEnteros(sender, (KeyPressEventArgs)e);
        }

        private void TxtAnnoCargo_KeyPress(object sender, KeyPressEventArgs e)
        {
            FuncionesGlobales.SoloEnteros(sender, (KeyPressEventArgs)e);

        }

        private void LVListadoValores_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (this.LVListadoValores.SelectedItems.Count > 0)
            {
                var selected = this.LVListadoValores.SelectedItems[0];
                PintarFilasSelect();
                oEntidad.ID_VALOR = selected.SubItems[10].Text;
                oEntidad.ANO_VALOR = selected.SubItems[9].Text;
                oEntidad.NUM_VALOR = selected.SubItems[8].Text;
                oEntidad.ANO_CARGO = selected.SubItems[11].Text;
                oEntidad.NUM_CARGO = selected.SubItems[12].Text;
                oEntidad.NOMBRE = Variables.cod_usuario;
                Variables.id_valor = oEntidad.ID_VALOR;
                Variables.ano_valor = oEntidad.ANO_VALOR;
                Variables.num_valor = oEntidad.NUM_VALOR;
                Variables.ano_cargo = oEntidad.ANO_CARGO;
                Variables.num_cargo = oEntidad.NUM_CARGO;
                LlamarDetalleCargo(oEntidad);
                //PintarFilasLoad();
            }
        }
        private void TxtValor_Leave(object sender, EventArgs e)
        {
            if (TxtValor.Text.Trim().Length > 0 && TxtValor.Text.Trim().Length < 7)
            {
                //int E1 = Convert.ToInt32(TxtValor.Text.Trim());
                TxtValor.Text = TxtValor.Text.PadLeft(7, '0');
            }
        }
        private void BtnCargoPanel_Click(object sender, EventArgs e)
        {
            ActivaPaneles("Cargo");
        }
        private void buttonX1_Click(object sender, EventArgs e)
        {
            ActivaPaneles("Valor");
        }

        public event EventHandler LlamarReporte;
        private void BtnReporte_Click(object sender, EventArgs e)
        {
            LlamarReporte?.Invoke(this, EventArgs.Empty);
        }
        public void LimpiarDetalle()
        {
            Txt_Id.Text = "";
            Txt_ColorFachada.Text = "";
            Txt_Derivar.Text = "";
            Txt_DireccionCedulon.Text = "";
            Txt_DireccionRecepcion.Text = "";
            Txt_DocumentoRecepcion.Text = "";
            Txt_Estado.Text = "";
            Txt_FNotifica.Text = "";
            Txt_FCedulon.Text = "";
            Txt_Firma.Text = "";
            Txt_FRegistro.Text = "";
            Txt_FVisita1.Text = "";
            Txt_FVisita2.Text = "";
            Txt_HCedulon.Text = "";
            Txt_HVisita1.Text = "";
            Txt_HVisita2.Text = "";
            Txt_NombreRecepcion.Text = "";
            Txt_Notificador.Text = "";
            Txt_NroPisos.Text = "";
            Txt_NroSuministro.Text = "";
            Txt_NroVisita.Text = "";
            Txt_Observación.Text = "";
            Txt_PcActualiza.Text = "";
            Txt_PcRegistro.Text = "";
            Txt_Parentesco.Text = "";
            Txt_Situacion.Text = "";
            Txt_UActualiza.Text = "";
            Txt_URegistro.Text = "";


        }
        private void btnRefrescarValor_Click(object sender, EventArgs e)
        {
            TxtValor.Text = "";
            TxtValor.Focus();
            TxtAnnovalor.Text = "";
            ChkSelectValor.CheckState = CheckState.Unchecked;
            LimpiarDetalle();
            ListarCargos();
            PintarFilasLoad();
            PintarFilasSelect();
        }
        private void btnRefrescarCargo_Click(object sender, EventArgs e)
        {
            TxtCargo.Text = "";
            TxtCargo.Focus();
            TxtAnnoCargo.Text = "";
            LimpiarDetalle();
            ListarCargos();
        }
        private void PintarFilasLoad()
        {
            DateTime fecha;
            foreach (ListViewItem item in LVListadoValores.Items)
            {
                fecha = (item.SubItems[14].Text == "")?DateTime.Now : Convert.ToDateTime(item.SubItems[14].Text.ToString());

                if (DateTime.Now > fecha)
                {
                    item.BackColor = Color.FromArgb(178, 0, 125);
                    item.ForeColor = Color.FromArgb(255, 255, 255);

                    foreach (ListViewItem.ListViewSubItem subitem in item.SubItems)
                    {
                        subitem.BackColor = Color.FromArgb(178, 0, 125);
                        subitem.ForeColor = Color.FromArgb(255, 255, 255);
                    }
                }
                else if (DateTime.Now >= fecha.AddDays(-5) && DateTime.Now <= fecha)
                {
                    item.BackColor = Color.LimeGreen;
                    item.ForeColor = Color.FromArgb(255, 255, 255);

                    foreach (ListViewItem.ListViewSubItem subitem in item.SubItems)
                    {
                        subitem.BackColor = Color.LimeGreen;
                        subitem.ForeColor = Color.FromArgb(255, 255, 255);
                    }
                }
            }
        }
        private void PintarFilasSelect()
        {
            DateTime fecha;
            foreach (ListViewItem item in LVListadoValores.Items)
            {
                fecha = (item.SubItems[14].Text == "") ? DateTime.Now : Convert.ToDateTime(item.SubItems[14].Text.ToString());

                if (DateTime.Now > fecha)
                {
                    item.BackColor = Color.FromArgb(178, 0, 125);
                    item.ForeColor = Color.FromArgb(255, 255, 255);

                    foreach (ListViewItem.ListViewSubItem subitem in item.SubItems)
                    {
                        subitem.BackColor = Color.FromArgb(178, 0, 125);
                        subitem.ForeColor = Color.FromArgb(255, 255, 255);
                    }
                }
            }
        }
        private void BtnPrepararEnvio_Click(object sender, EventArgs e)
        {
            try
            {
                int fechavenc = 1;
                if (LVListadoValores.CheckedItems.Count > 0)
                {                   
                    foreach (ListViewItem  item in LVListadoValores.CheckedItems)
                    {
                        if (Convert.ToDateTime(item.SubItems[14].Text).Date > DateTime.Now.Date)
                        {
                            item.BackColor = Color.FromArgb(147, 183, 255);
                            item.ForeColor = Color.FromArgb(255, 255, 255);
                            foreach (ListViewItem.ListViewSubItem subitem in item.SubItems)
                            {
                                subitem.BackColor = Color.FromArgb(147, 183, 255);
                                subitem.ForeColor = Color.FromArgb(255, 255, 255);
                            }
                            fechavenc = 0;
                        }                      
                    }
                    if (fechavenc == 1)
                    {
                        ExistePagos();
                    }
                    else
                    {
                        MessageBox.Show("HAY ITEMS QUE AUN NO VENCE SU PLAZO PARA ENVIAR A COACTIVO","SISTEMA",MessageBoxButtons.OK,MessageBoxIcon.Stop);
                    }
                }
                else
                {
                    MessageBox.Show("SE DEBE SELECCIONAR AL MENOS UN CARGO PARA PODER PREPARAR EL ENVIO","SISTEMNA",MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"SE PRODUJO EL SIGUIENTE ERROR:\n{ex}","SISTEMA",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
        }
        private void ExistePagos()
        {
            var oEntidad = new ENMValores();
            int Opcion = 4;
            string orden = "";
            string codigo = "";
            string valor = "";
            int flag = 0;
            int pintar = 0;
            DataTable dtenvio = new DataTable();
            // Agregar columnas al DataTable
            foreach (ColumnHeader column in LVListadoValores.Columns)
            {
                dtenvio.Columns.Add(column.Text);
            }

            foreach (ListViewItem item in LVListadoValores.CheckedItems)
            {
                pintar = 0;
                oEntidad.ID_VALOR = item.SubItems[10].Text.ToString();
                oEntidad.NUM_VAL = item.SubItems[8].Text.ToString();
                oEntidad.ANO_VAL = item.SubItems[9].Text.ToString();
                orden = item.SubItems[0].Text.ToString();
                dtDetalle = LMValores.CargarDetalleValor(oEntidad, Opcion);
                codigo = item.SubItems[1].Text.ToString();
                valor = item.SubItems[5].Text.ToString();

                foreach (DataRow fila in dtDetalle.Rows)
                {
                    if (fila["periodo"].ToString().Trim() != "")
                    {
                        string anno_valor = item.SubItems[9].Text.ToString();//fila["anno"].ToString().Trim();
                        string tipo_rec = fila["tipo_rec"].ToString().Trim();
                        string periodo = fila["periodo"].ToString().Trim();
                        DataTable dtPago = LMValores.VerificarPagosValor(codigo, anno_valor, tipo_rec, periodo);
                        _resultadoPago = dtPago.Rows[0][0].ToString();
                        if (_resultadoPago == "PAGO")
                        {
                            item.Checked = false;
                            flag = 1;
                            pintar = 1;
                        }
                    }
                }
                if (pintar == 1)
                {
                    item.BackColor = Color.FromArgb(251, 34, 26);
                    item.ForeColor = Color.FromArgb(255, 255, 255);
                    foreach (ListViewItem.ListViewSubItem subitem in item.SubItems)
                    {
                        subitem.BackColor = Color.FromArgb(251, 34, 26);
                        subitem.ForeColor = Color.FromArgb(255, 255, 255);
                    }
                    //break;
                }
                else
                {
                    // Recorrer cada fila del ListView y agregar una nueva fila al DataTable
                    DataRow row = dtenvio.NewRow();
                    for (int i = 0; i < LVListadoValores.Columns.Count; i++)
                    {
                        row[i] = item.SubItems[i].Text;
                    }
                    dtenvio.Rows.Add(row);
                    Variables.envio_legal = dtenvio;
                }
            }
            if (flag == 1)
            {
                MessageBox.Show($"SE DETECTO PAGOS REVISAR ITEMS Y VOLVER A ENVIAR", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                FrmCrearLote frm = new FrmCrearLote();
                frm.ShowDialog();
            }
        }


        private void ChkSelectValor_MouseHover(object sender, EventArgs e)
        {

            TipAyuda.AutoPopDelay = 5000;
            TipAyuda.InitialDelay = 1000;
            //TipAyuda.SetToolTip(this.ChkSelectValor, "ACTIVAR PARA SELECCIONAR TODOS LOS ITEMS EN ESTADO ENVIAR A COACTIVO");
            TipAyuda.Hide(ChkSelectValor);
        }
        private void ChkSelectValor_CheckedChanged(object sender, EventArgs e)
        {
            DateTime fecha;
           
            foreach (ListViewItem item in LVListadoValores.Items)
            {
                fecha = (item.SubItems[14].Text == "") ? DateTime.Now : Convert.ToDateTime(item.SubItems[14].Text.ToString());

                if (DateTime.Now > fecha && ChkSelectValor.Checked == true)
                {
                    item.Checked = true;
                }
                if (DateTime.Now > fecha && ChkSelectValor.Checked == false)
                {
                    item.Checked = false;
                }
            }
        }
    }
}
