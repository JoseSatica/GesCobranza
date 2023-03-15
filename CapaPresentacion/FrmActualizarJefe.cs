using CapaNegocio;
using System;
using System.Data;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmActualizarJefe : Form
    {
        private DataTable comboGestor;
        private int id_gestor;
        private DataTable TablaEnvio;
        private decimal monto;

        public FrmActualizarJefe()
        {
            InitializeComponent();
        }

        private void FrmActualizarJefe_Load(object sender, EventArgs e)
        {
            this.MinimumSize = this.MaximumSize = this.Size;

            LblContri.Text = Variables.nombre_contri.ToUpper();
            LblCodContri.Text = Variables.codigo.ToUpper();
            LblCodGestor.Text = Variables.gestor.ToUpper();
            LblMonto.Text = Variables.monto.ToUpper();
            cargarComboGestores();
        }
        private void cargarComboGestores()
        {
            comboGestor = NVerCartera.CargarComboGestores();
            foreach (DataRow fila in comboGestor.Rows)
            {
                if (fila["cod_gestor"].ToString() != Variables.gestor && Convert.ToInt32(fila["permiso"].ToString()) == 1)
                {
                    CbxGestorNuevo.Items.Add(fila["cod_gestor"].ToString().Trim());
                }
            }
        }

        private async void BtnActualizarCartera_Click(object sender, EventArgs e)
        {

            try
            {

                if ((LblCodGestor.Text.Trim() != CbxGestorNuevo.Text.Trim()) && CbxGestorNuevo.Text != "")
                {
                    DialogResult Resultado = MessageBox.Show($"EL NUEVO GESTOR TOMARA LA GESTION DESDE EL INICIO, CON EL MONTO ACTUALIZADO \n\n¿ESTAS SEGURO DE ASIGNAR ESTA GESTION AL NUEVO GESTOR?", "SISTEMA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (Resultado == DialogResult.Yes)
                    {
                        Task Tarea = new Task(CompararMonto);
                        Tarea.Start();
                        PtbLoad.Visible = true;
                        await Tarea;
                        using (TransactionScope transaccion = new TransactionScope())
                        {
                            NCarteraDetalle.ActualizarEstadoCartera(4, Variables.id_cartera);
                            NAsignarMasivo.EnviarCartera(id_gestor, Variables.codigo, 1, 1, monto);
                            PtbLoad.Visible = false;
                            MessageBox.Show("SE ACTUALIZO CORRECTAMENTE", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            transaccion.Complete();
                        }
                    }                    
                }
                else
                {
                    MessageBox.Show("NO SE PUEDE ACTUALIZAR, ELIGE UN GESTOR", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("HUBO UN ERROR: " + ex, "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }


        private void CbxGestorNuevo_SelectedValueChanged_1(object sender, EventArgs e)
        {
            foreach (DataRow item in comboGestor.Rows)
            {
                if (CbxGestorNuevo.Text.Trim() == item["cod_gestor"].ToString().Trim())
                {
                    id_gestor = Convert.ToInt32(item["id_gestor"].ToString().Trim());
                }
            }
            if (CbxGestorNuevo.SelectedIndex == 0)
            {
                CbxGestorNuevo.SelectedIndex = -1;
            }
        }
    }
}
