using System;
using System.Data;
using System.Transactions;
using System.Windows.Forms;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class FrmCrearLote : Form
    {
        int FlagValidarTextBoxs;
        public FrmCrearLote()
        {
            InitializeComponent();
        }

        private void FrmCrearLote_Load(object sender, EventArgs e)
        {
            this.MinimumSize = this.MaximumSize = this.Size;
            CargarDgv();
           
        }
        private void CargarDgv()
        {
            if (Variables.envio_legal != null)
            {
                dgvLote.DataSource = Variables.envio_legal;
                FormatoColumna();
                OcultarColumnas();
            }
        }
        private void OcultarColumnas()
        {
            foreach (DataGridViewColumn item in dgvLote.Columns)
            {
                if (item.HeaderCell.Value.ToString() == "ID_TBL" || item.HeaderCell.Value.ToString() == "num_valor" || item.HeaderCell.Value.ToString() == "ano_valor" || item.HeaderCell.Value.ToString() == "id_valor" || item.HeaderCell.Value.ToString() == "num_cargo" || item.HeaderCell.Value.ToString() == "ano_cargo")
                {
                    item.Visible = false;
                }
            }
        }
        private void FormatoColumna()
        {
            dgvLote.Columns["Nro"].Width = 30;
            dgvLote.Columns["Codigo"].Width = 50;
            dgvLote.Columns["Nro Cargo"].Width = 70;
            dgvLote.Columns["Monto"].Width = 70;
            dgvLote.Columns["Fec. Notifica"].Width = 85;

        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            OpFileBuscarArchivo.InitialDirectory = "C:\\"; //Users\\jmozo\\Downloads"; //"D:\\";
            OpFileBuscarArchivo.Filter = "Archivos de texto (*.txt)|*.txt|Archivos CSV (*.csv)|*.csv|Archivos de Excel (*.xlsx)|*.xlsx|Documentos de Word (*.docx)|*.docx|Documentos de Word antiguos (*.doc)|*.doc|Archivos PDF (*.pdf)|*.pdf";
            OpFileBuscarArchivo.FilterIndex = 4;
            OpFileBuscarArchivo.RestoreDirectory = true;

            if (OpFileBuscarArchivo.ShowDialog() == DialogResult.OK)
            {
                TxtDocumento.Text = OpFileBuscarArchivo.SafeFileName;               
            }
        }

        private void BtnCrearLote_Click(object sender, EventArgs e)
        {
            int id_lote;
            EpValidar.Clear();
            ValidarTextBoxs();
            if (dgvLote.RowCount > 0 && FlagValidarTextBoxs == 0)
            {
                DialogResult respuesta = MessageBox.Show("¿DESEA CREAR EL LOTE PARA SU REVISION EN EL AREA LEGAL?", "SISTEMA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (respuesta == DialogResult.Yes)
                {
                    using (TransactionScope scope = new TransactionScope())
                    {
                        try
                        {
                            string veri = LNotificaciones.InsertarCabeceraLote(TxtDocumento.Text.Trim(), TxtNro.Text.Trim(), TxtAnno.Text.Trim(), Variables.cod_usuario, Environment.MachineName).Rows[0][0].ToString();
                            if (veri != "EXISTE")
                            {
                                id_lote = Convert.ToInt32(veri);
                                foreach (DataGridViewRow row in dgvLote.Rows)
                                {
                                    int id = Convert.ToInt32(row.Cells["ID_TBL"].Value.ToString());
                                    LNotificaciones.InsertarDetalleLote(id_lote, id, "1", "", "");
                                    LNotificaciones.ActualizarEstadoCargo(id, "2");
                                }
                                LNotificaciones.InsertarMovimientoLote(id_lote, 1, "4002", "2001", DateTime.Now);
                                scope.Complete();
                                MessageBox.Show("SE ENVIO CORRECTAMENTE A LEGAL", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("YA EXISTE EL NUMERO Y AÑO DEL DOCUMENTO, POR FAVOR VERIFIQUE","SISTEMA",MessageBoxButtons.OK,MessageBoxIcon.Stop);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"SE PRODUJO UN ERROR:\n{ex}","SISTEMA",MessageBoxButtons.OK,MessageBoxIcon.Stop);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("SE ENCONTRARON ERRORES VERIFICAR LOS CAMPOS","SISTEMA",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }
        private void ValidarTextBoxs()
        {
            FlagValidarTextBoxs = 0;
            if (string.IsNullOrEmpty(TxtNro.Text))
            {
                EpValidar.SetError(TxtNro, "DEBE AGREGAR UN VALOR VALIDO PARA EL NUMERO DEL DOCUMENTO");
                FlagValidarTextBoxs = 1;
            }
            if (string.IsNullOrEmpty(TxtAnno.Text))
            {
                EpValidar.SetError(TxtAnno, "DEBE AGREGAR UN VALOR VALIDO PARA EL AÑO DEL DOCUMENTO");
                FlagValidarTextBoxs = 1;
            }
            if (string.IsNullOrEmpty(TxtDocumento.Text))
            {
                EpValidar.SetError(TxtDocumento, "DEBE SELECCIONAR UN DOCUMENTO");
                FlagValidarTextBoxs = 1;
            }
        }
        private void TxtNro_Leave(object sender, EventArgs e)
        {
            if (TxtNro.Text.Trim().Length > 0 && TxtNro.Text.Trim().Length < 7)
            {
                //int E1 = Convert.ToInt32(TxtValor.Text.Trim());
                TxtNro.Text = TxtNro.Text.PadLeft(7, '0');
            }
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
    }
}
