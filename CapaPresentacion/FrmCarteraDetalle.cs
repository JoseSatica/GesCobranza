using CapaNegocio;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmCarteraDetalle : Form
    {
        public FrmCarteraDetalle()
        {
            InitializeComponent();
        }
        
        private void FrmCarteraDetalle_Load(object sender, EventArgs e)
        {
            LblCodigo.Text = Variables.codigo.ToUpper() ;
            LblMonto.Text = Variables.monto.ToUpper();
            LblNombre.Text = Variables.nombre_contri.ToUpper();
            
        }
        private void cargarDgvCarteraDetalle()
        {
            DgvCarteraDetalle.DataSource = NCarteraDetalle.CargarDetalleCarteraCabecera(Variables.id_cartera, Variables.gestor);
        }       
       
        private void OcultarColumna()
        {
            foreach (DataGridViewColumn item in DgvCarteraDetalle.Columns)
            {
                if (item.HeaderCell.Value.ToString() == "id_detalle_cartera" || item.HeaderCell.Value.ToString() == "id_cartera" 
                    || item.HeaderCell.Value.ToString() == "num_doc" || item.HeaderCell.Value.ToString() == "id_seguimiento"
                    || item.HeaderCell.Value.ToString() == "Telefono" || item.HeaderCell.Value.ToString() == "Correo")
                {
                    item.Visible = false;
                }
            }
        }

        private void PintarFilas()
        {
            //DgvCartera.Columns[0].HeaderText = "Gestor"; 
            if (DgvCarteraDetalle.Rows.Count > 0)
            {
                DgvCarteraDetalle.RowHeadersVisible = false;
                DgvCarteraDetalle.Columns["tipo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                DgvCarteraDetalle.Columns["tipo"].Width = 60;
                DgvCarteraDetalle.Columns["tipo"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;

                DgvCarteraDetalle.Columns["codigo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                DgvCarteraDetalle.Columns["codigo"].Width = 80;
                DgvCarteraDetalle.Columns["codigo"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;

                DgvCarteraDetalle.Columns["Contribuyente"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                DgvCarteraDetalle.Columns["Contribuyente"].Width = 320;
                DgvCarteraDetalle.Columns["Contribuyente"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                DgvCarteraDetalle.Columns["Contribuyente"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;

                DgvCarteraDetalle.Columns["Monto"].Width = 80;
                DgvCarteraDetalle.Columns["Monto"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                DgvCarteraDetalle.Columns["Monto"].DefaultCellStyle.Format = "N2";

                DgvCarteraDetalle.Columns["seguimiento"].Width = 180;
                DgvCarteraDetalle.Columns["seguimiento"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                DgvCarteraDetalle.Columns["seguimiento"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;

                DgvCarteraDetalle.Columns["fecha"].Width = 120;
                DgvCarteraDetalle.Columns["fecha"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;

                DgvCarteraDetalle.Columns["fecha_a_gestionar"].Width = 180;
                DgvCarteraDetalle.Columns["fecha_a_gestionar"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;

                //DgvCarteraDetalle.Columns["telefono"].Width = 120;
                //DgvCarteraDetalle.Columns["telefono"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                //DgvCarteraDetalle.Columns["telefono"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;

                //DgvCarteraDetalle.Columns["correo"].Width = 180;
                //DgvCarteraDetalle.Columns["correo"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                //DgvCarteraDetalle.Columns["correo"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;


                //DgvCartera.Columns["ROW"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }            
        }
        private void DgvCarteraDetalle_Sorted(object sender, EventArgs e)
        {
            OcultarColumna();
            PintarFilas();
        }

        private void DgvCarteraDetalle_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (DgvCarteraDetalle.CurrentRow != null)
                {
                    int id_detalle_cartera = Convert.ToInt32(DgvCarteraDetalle.CurrentRow.Cells["id_detalle_cartera"].Value.ToString());
                    DataTable detalleCartera = NCarteraDetalle.CargarDetalleCarteraDetalle(id_detalle_cartera);
                    TxtNomPersNoti.Text = detalleCartera.Rows[0]["persona"].ToString();
                    TxtDniPersNoti.Text = detalleCartera.Rows[0]["dni"].ToString();
                    TxtEdadPersNoti.Text = detalleCartera.Rows[0]["edad"].ToString();
                    TxtParentPersNoti.Text = detalleCartera.Rows[0]["parentesco"].ToString();                                      
                    TxtObserNoti.Text = detalleCartera.Rows[0]["observacion"].ToString();                 
                    TxtFechaPorGestionar.Text = detalleCartera.Rows[0]["fecha_por_gestionar"].ToString();
                    TxtCorreo.Text = detalleCartera.Rows[0]["correo"].ToString();
                    TxtFono.Text = detalleCartera.Rows[0]["telefono"].ToString();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"SE PRODUJO EL SIGUIENTE ERROR: \n{ex}","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void FrmCarteraDetalle_Shown(object sender, EventArgs e)
        {
            cargarDgvCarteraDetalle();
            OcultarColumna();
            PintarFilas();

        }


        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Close();
        }
    }
}
