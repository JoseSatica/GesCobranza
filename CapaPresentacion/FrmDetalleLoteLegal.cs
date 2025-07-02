using CapaNegocio;
using System;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmDetalleLoteLegal : Form
    {
        public FrmDetalleLoteLegal()
        {
            InitializeComponent();
        }



        private void FrmDetalleLoteLegal_Load(object sender, EventArgs e)
        {
            this.MinimumSize = this.MaximumSize = this.Size;
            dgvLote.DataSource = LNotificaciones.MostrarDetalleLote(Variables.id_lotec);
            LblLoteNombre.Text = Variables.lote_nombre;
            FormatoDgv();
            OcultarColumna();
            SeleccionarObservados();
        }
        private void FormatoDgv()
        {
            dgvLote.Columns["id_loted"].Visible = false;
            dgvLote.Columns["id_lotec"].Visible = false;
            dgvLote.Columns["ID_TBL"].Visible = false;
            dgvLote.Columns["Código"].ReadOnly = true;            
            //dgvLote.Columns["Eliminar"].DisplayIndex = 6;
            //dgvLote.Columns["Seleccionar"].ReadOnly = false;
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void OcultarColumna()
        {
            foreach (DataGridViewColumn item in dgvLote.Columns)
            {
                if (item.HeaderText == "Observacion" )
                {
                    item.Visible = false;
                }
            }
        }
        private void SeleccionarObservados()
        {

            //foreach (DataGridViewRow row in dgvLote.Rows)
            //{
            //    if (row.Cells["Estado"].Value.ToString() == "Observado")
            //    {
            //        row.Cells["Seleccionar"].Value = true;
            //    }
            //}
        }
        private void dgvLote_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            // Verificar si se está editando la columna de tipo CheckBox
            if (dgvLote.Columns[e.ColumnIndex] is DataGridViewCheckBoxColumn)
            {
                // Permitir la edición de la columna de tipo CheckBox
                dgvLote.Columns[e.ColumnIndex].ReadOnly = false;
            }
            else
            {
                // Bloquear la edición de todas las demás columnas
                e.Cancel = true;
            }
        }
        private void dgvLote_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvLote.CurrentRow != null && dgvLote.CurrentRow.Cells["Observacion"].Value != null)
            {
                TxtObservacion.Text = dgvLote.CurrentRow.Cells["Observacion"].Value.ToString();
            }                
        }
        private void BtnRetirar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("SEGURO QUE DESEA ANULAR LOS CARGOS OBSERVADOS", "SISTEMA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                foreach (DataGridViewRow item in dgvLote.Rows)
                {
                    if (item.Cells["Estado"].Value.ToString() == "Observado")
                    {
                        int id_loted = Convert.ToInt32(item.Cells["id_loted"].Value.ToString());
                        int idcargo = Convert.ToInt32(item.Cells["ID_TBL"].Value.ToString());
                        LNotificaciones.AnularCargoLote(id_loted);
                        LNotificaciones.ActualizarEstadoCargo(idcargo, "1"); // se pone en estado 1 por el momento aun falta saber como tratan las observaciones
                    }
                }
                dgvLote.DataSource = LNotificaciones.MostrarDetalleLote(Variables.id_lotec);
            }
        }
    }
}
