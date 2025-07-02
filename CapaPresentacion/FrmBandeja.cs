using CapaNegocio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmBandeja : Form
    {
        private DataTable ComboEstado;
        private string area_destinatario = "2001";
        private int pagtotal = 20;
        private int paginicio = 1;
        private string nro;
        private string anno;
        private string estado;
        private string documento_nombre;
        private DateTime dtpini;
        private DateTime dtpfin;
        private int rowini = 1;
        private int rowfin = 20;
        private DataTable Cartera;

        public FrmBandeja()
        {
            InitializeComponent();
        }

        private void FrmBandeja_Load(object sender, EventArgs e)
        {
            //dgvLote.DataSource = LNotificaciones.MostrarBandejaLegal();
            //FormatoDgv();
            dgvLote.Columns["Ver"].Visible = false;
            CargarComboEstado();
        }
        private void CargarComboEstado()
        {
            ComboEstado = LNotificaciones.CargarComboEstadoLote();
            foreach (DataRow item in ComboEstado.Rows)
            {
                CbxEstado.Items.Add(item["estado"].ToString());
            }
        }
        private void FormatoDgv()
        {
            dgvLote.Columns["id_lotec"].Visible = false;
            dgvLote.Columns["id_lote_movi"].Visible = false;
            dgvLote.Columns["ROW"].Visible = false;
            dgvLote.Columns["Ver"].DisplayIndex = 6;
            dgvLote.Columns["Ver"].FillWeight = 100;
            dgvLote.Columns["Ver"].Width = 100;
            dgvLote.Columns["Ver"].Visible = true;
        }
        private void pintarFilas()
        {
            foreach (DataGridViewRow fila in dgvLote.Rows)
            {
                if (fila.Cells["Estado"].Value.ToString().Trim() == "RESPONDIDO")
                {
                    fila.DefaultCellStyle.ForeColor = Color.FromArgb(149, 26, 136);
                    fila.DefaultCellStyle.SelectionBackColor = Color.FromArgb(149, 26, 136);
                    fila.DefaultCellStyle.SelectionForeColor = Color.White;
                }
            }
        }
        private void dgvLote_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && dgvLote.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                Variables.id_lotec = Convert.ToInt32(dgvLote.CurrentRow.Cells["id_lotec"].Value.ToString());
                Variables.lote_nombre = dgvLote.CurrentRow.Cells["Documento"].Value.ToString();
                FrmDetalleLoteLegal frm = new FrmDetalleLoteLegal();
                frm.ShowDialog();
            }
        }
        private void SwBtnArea_ValueChanged(object sender, EventArgs e)
        {
            //area_destinatario = (SwBtnArea.Value) ? "4004" : "2001";
            if (SwBtnArea.Value)
            {
                area_destinatario = "4004";
                BtnEnviarCobranzas.Visible = true;
                BtnEnviarCoactivo.Visible = false;
            }
            else
            {
                area_destinatario = "2001";
                BtnEnviarCoactivo.Visible = true;
                BtnEnviarCobranzas.Visible = false;
            }
            List<DataGridViewColumn> columnsToRemove = new List<DataGridViewColumn>();
            if (dgvLote.RowCount > 0)
            {
                foreach (DataGridViewColumn columna in dgvLote.Columns)
                {
                    if (columna.Index != 0)
                    {
                        columnsToRemove.Add(columna);
                    }
                }
                foreach (DataGridViewColumn column in columnsToRemove)
                {
                    dgvLote.Columns.Remove(column);
                }
            }

            dgvLote.Columns["Ver"].Visible = false;
        }
        private void paginador()
        {
            pagtotal = Convert.ToInt32(Math.Ceiling(Convert.ToDecimal(LNotificaciones.BuscarLotesContador(area_destinatario, nro, anno, estado, documento_nombre, dtpini, dtpfin).Rows[0][0].ToString()) / 20));
            lblpagtotal.Text = (pagtotal == 0) ? "1" : pagtotal.ToString();
            lblpaginicio.Text = paginicio.ToString();
        }
        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            rowini = 1;
            rowfin = 20;
            paginicio = 1;
            pagtotal = 20;
            nro = (TxtNro.Text == "" || TxtNro.Text == "0000000") ? TxtNro.Text.Trim() : TxtNro.Text.PadLeft(7, '0').Trim();
            anno = TxtAnno.Text.Trim();
            estado = CbxEstado.Text.ToString();
            documento_nombre = TxtNombre.Text.Trim();
            dtpini = Convert.ToDateTime(DtpIni.Value);
            dtpfin = Convert.ToDateTime(DtpFin.Value);
            try
            {
                dgvLote.DataSource = LNotificaciones.BuscarLotes(area_destinatario, nro, anno, estado, documento_nombre, dtpini, dtpfin, rowini, rowfin);
                if (dgvLote.RowCount > 0)
                {
                    FormatoDgv();
                    paginador();
                    pintarFilas();
                    PanelPaginador.Visible = true;
                }
                else
                {
                    MessageBox.Show("NO SE ENCONTRARON RESULTADOS", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"SE PRODUJO EL SIGUIENTE ERROR:\n{ex}", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void BtnAnterior_Click(object sender, EventArgs e)
        {
            if (paginicio != 1)
            {
                rowini -= 20;
                rowfin -= 20;
                paginicio -= 1;
                lblpaginicio.Text = paginicio.ToString();
                BtnSiguiente.Enabled = true;
                dgvLote.DataSource = LNotificaciones.BuscarLotes(area_destinatario, nro, anno, estado, documento_nombre, dtpini, dtpfin, rowini, rowfin);
            }
        }
        private void BtnSiguiente_Click(object sender, EventArgs e)
        {
            if (paginicio != pagtotal && pagtotal != 0)
            {
                rowini += 20;
                rowfin += 20;
                paginicio += 1;
                lblpaginicio.Text = paginicio.ToString();
                BtnAnterior.Enabled = true;
                dgvLote.DataSource = LNotificaciones.BuscarLotes(area_destinatario, nro, anno, estado, documento_nombre, dtpini, dtpfin, rowini, rowfin);
            }
        }
        private void CbxEstado_SelectedValueChanged(object sender, EventArgs e)
        {
            if (CbxEstado.SelectedIndex == 0)
            {
                CbxEstado.SelectedIndex = -1;
            }
        }
        private void TxtNro_Leave(object sender, EventArgs e)
        {
            TxtNro.Text = (TxtNro.Text != "") ? TxtNro.Text.PadLeft(7, '0') : "";
        }
        private void TxtNro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Ignorar la tecla presionada
            }
        }
        private void TxtAnno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Ignorar la tecla presionada
            }
        }

        private void BtnEnviarCoactivo_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("DESEA ENVIAR EL CARGO SELECCIONADO A LA BANDEJA DE COACTIVO","SISTEMA",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                if (dgvLote.RowCount > 0)
                {
                    int id = Convert.ToInt32(dgvLote.CurrentRow.Cells["id_lotec"].Value.ToString());
                    int idmovi = Convert.ToInt32(dgvLote.CurrentRow.Cells["id_lote_movi"].Value.ToString());
                    try
                    {
                        LNotificaciones.InsertarMovimientoLote(id, 1, "4002", "4004", DateTime.Now);
                        LNotificaciones.ActualizarEstadoBandeja(4, idmovi);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"SE PRODUJO EL SIGUIENTE ERROR:\n{ex}", "SISTEMA");
                    }
                }
                else
                {
                    MessageBox.Show("DEBE SELECCIONAR UNA FILA", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            BtnBuscar.PerformClick();
            
        }
        private void dgvLote_Sorted(object sender, EventArgs e)
        {
            //FormatoDgv();
            pintarFilas();
        }
    }
}
