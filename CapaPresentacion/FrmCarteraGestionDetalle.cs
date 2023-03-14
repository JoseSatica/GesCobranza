using CapaNegocio;
using System;
using System.Data;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmCarteraGestionDetalle : Form
    {
        public FrmCarteraGestionDetalle()
        {
            InitializeComponent();
        }
        DataTable comboSeguimiento;
        string seguimiento = Variables.deta_seguimiento.Trim();
        string validarSeguimiento;
        string validarObservacion;
        int actualizaIdSeguimiento;
        private DataTable TablaEnvio;
        decimal monto;
        private void FrmCarteraGestionDetalle_Load(object sender, EventArgs e)
        {
            //LblNomPc.Text = Environment.MachineName.ToString();
            //LblNomUsua.Text = Environment.UserName.ToString();
            cargarComboSeguimiento();
            LblNomContri.Text = Variables.nombre_contri.ToUpper();
            LblCodContri.Text = Variables.codigo.ToUpper();
        }
        private void cargarComboSeguimiento()
        {
            comboSeguimiento = NVerCartera.CargarComboSeguimientos();
            foreach (DataRow fila in comboSeguimiento.Rows)
            {
                CbxSeguimiento.Items.Add(fila["deta_seguimiento"].ToString().Trim());
            }
        }
        private void validarContorles()
        {
            validarSeguimiento = "";
            validarObservacion = "";

            if (CbxSeguimiento.Text.Trim() == seguimiento || CbxSeguimiento.Text == "" || CbxSeguimiento.Text.Trim() == "Inicio")
            {
                EpSeguimiento.SetError(CbxSeguimiento, "DEBE SELECCIONAR UN SEGUIMIENTO DIFERENTE AL ACTUAL");

            }
            else
            {
                validarSeguimiento = "OK";
                EpSeguimiento.Clear();
            }

            if (string.IsNullOrEmpty(TxtObserNoti.Text.Trim()))
            {
                EpObservacion.SetError(TxtObserNoti, "DEBE INGRESAR UNA OBSERVACION");
            }
            else
            {
                validarObservacion = "OK";
                EpObservacion.Clear();
            }
        }
        private async void BtnGrabar_Click(object sender, EventArgs e)
        {
           // string fecha = (DtpFechPagNoti.Checked) ? DtpFechPagNoti.Text : "";
            string fecha_por_gestionar = (DtpPorGestionar.Checked) ? DtpPorGestionar.Text : "";

            validarContorles();
            if (validarSeguimiento == "OK" && validarObservacion == "OK")
            {
                DialogResult resultado = MessageBox.Show("¿DESEA ACTUALIZAR SU GESTION?", "SISTEMA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {


                    try
                    {
                        Task Tarea = new Task(CompararMonto);
                        Tarea.Start();
                        PtbLoad.Visible = true;
                        await Tarea;
                        using (TransactionScope transacion = new TransactionScope())
                        {
                            NCarteraDetalle.InsertarDetalleGestion(Variables.id_cartera, actualizaIdSeguimiento, TxtNomPersNoti.Text, TxtDniPersNoti.Text.Trim(), TxtParentPersNoti.Text.Trim(), TxtEdadPersNoti.Text.Trim(), TxtObserNoti.Text, monto, fecha_por_gestionar, Environment.UserName.ToString(), Environment.MachineName.ToString(), Variables.cod_usuario);
                            NCarteraDetalle.ActualizarCarteraSeguimiento(Variables.id_cartera, actualizaIdSeguimiento, DateTime.Now, monto, fecha_por_gestionar);
                            cambiarEstado();
                            transacion.Complete();
                            PtbLoad.Visible = false;
                            MessageBox.Show("SE ACTUALIZO CORRECTAMENTE", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            limpiar();
                        }                       
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("SE PRODUJO EL SIGUIENTE ERROR:\n" + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }

        }
        private void CompararMonto()
        {
            try
            {
                TablaEnvio = NGestion.CalcularDeuda(Variables.codigo, "", "", "", "", "", "0");
                int contador = 0;
                monto = 0;
                foreach (DataRow row in TablaEnvio.Rows)
                {
                    monto += decimal.Round(((Convert.ToDecimal(TablaEnvio.Rows[contador][14]) + Convert.ToDecimal(TablaEnvio.Rows[contador][12])) + Convert.ToDecimal(TablaEnvio.Rows[contador][16])) - Convert.ToDecimal(TablaEnvio.Rows[contador][30]), 2);
                    contador++;
                }

                TablaEnvio.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("SE PRODUJO EL SIGUIENTE ERROR: \n" + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cambiarEstado()
        {
            if (seguimiento.Trim() == "Sin Respuesta")
            {
                NCarteraDetalle.ActualizarEstadoCartera(7, Variables.id_cartera);
            }
            else
            {
                NCarteraDetalle.ActualizarEstadoCartera(2, Variables.id_cartera);
            }
        }
        private void limpiar()
        {
            TxtNomPersNoti.Text = "";
            TxtDniPersNoti.Text = "";
            TxtEdadPersNoti.Text = "";
            TxtParentPersNoti.Text = "";
            TxtObserNoti.Text = "";
            CbxSeguimiento.Text = "";
            EpObservacion.Clear();
            EpSeguimiento.Clear();
            TxtNomPersNoti.Focus();
           //DtpFechPagNoti.Checked = false;
            DtpPorGestionar.Checked = false;

        }
        //public event EventHandler eventoLlamarVerCartera;
        private void BtnSalir_Click(object sender, EventArgs e)
        {
            //eventoLlamarVerCartera?.Invoke(this, EventArgs.Empty);

            //Panel panel = this.Owner.Controls.Find("PanelFormularios", true).FirstOrDefault() as Panel;
            //FrmVerCartera frm = new FrmVerCartera();            
            //panel.Controls.Add(frm);
            //frm.TopLevel = false;
            //frm.Dock = DockStyle.Fill;
            //frm.BringToFront();
            //frm.Show();
            //this.Close();

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }



        private void FrmCarteraGestionDetalle_Shown(object sender, EventArgs e)
        {
            LblNomContri.Text = Variables.nombre_contri;
            LblCodContri.Text = Variables.codigo;
            // LblGestor.Text = Variables.cod_usuario;

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void CbxSeguimiento_SelectedValueChanged(object sender, EventArgs e)
        {
            foreach (DataRow item in comboSeguimiento.Rows)
            {
                if (CbxSeguimiento.Text == item["deta_seguimiento"].ToString().Trim())
                {
                    actualizaIdSeguimiento = Convert.ToInt32(item["id_seguimiento"].ToString());
                }
            }
        }

        private void gbxPersona_MouseHover(object sender, EventArgs e)
        {
            TipAyuda.AutoPopDelay = 5000;
            TipAyuda.InitialDelay = 4000;
            TipAyuda.SetToolTip(this.gbxPersona, "DATOS DE LA PERSONA DIFERENTE AL CONTIBUYENTE, QUE ESTABA EN LA GESTION");
            TipAyuda.Hide(gbxPersona);
        }

        private void lblSeguimiento_MouseHover(object sender, EventArgs e)
        {
            TipAyuda.AutoPopDelay = 5000;
            TipAyuda.InitialDelay = 4000;
            TipAyuda.SetToolTip(this.lblSeguimiento, "MUESTRA LA LISTA DE LOS SEGUIMIENTOS QUE DEBE HABER REALIZADO EL GESTOR");
            TipAyuda.Hide(lblSeguimiento);
        }

        private void lblFechaPorGestionar_MouseHover(object sender, EventArgs e)
        {
            TipAyuda.AutoPopDelay = 5000;
            TipAyuda.InitialDelay = 4000;
            TipAyuda.SetToolTip(this.lblFechaPorGestionar, "EL GESTOR PUEDE ASIGNAR UNA FECHA COMO RECORDATORIO PARA HACER SUS GESTIONES");
            TipAyuda.Hide(lblFechaPorGestionar);
        }

        private void lblObservacion_MouseHover(object sender, EventArgs e)
        {
            TipAyuda.AutoPopDelay = 5000;
            TipAyuda.InitialDelay = 4000;
            TipAyuda.SetToolTip(this.lblObservacion, "EL GESTOR DEBE ESCRIBIR LAS OBSERVACIONES QUE ENCUENTRE RESPECTO A LA GESTION QUE REALIZO");
            TipAyuda.Hide(lblObservacion);
        }

        private void BtnGrabar_MouseHover(object sender, EventArgs e)
        {
            TipAyuda.SetToolTip(this.BtnGrabar, "BOTON QUE PERMITIRA ACTUALIZAR LA GESTION REALIZADA POR EL GESTOR Y GUARDAR REGISTRO DE ELLO");
        }
    }
}
