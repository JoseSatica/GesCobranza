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
                if (item.HeaderCell.Value.ToString() == "id_detalle_cartera" || item.HeaderCell.Value.ToString() == "id_cartera" || item.HeaderCell.Value.ToString() == "num_doc" || item.HeaderCell.Value.ToString() == "id_seguimiento")
                {
                    item.Visible = false;
                }
            }
        }
       
        private void DgvCarteraDetalle_Sorted(object sender, EventArgs e)
        {
            OcultarColumna();
            //Pintar();
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
        
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void TxtFechaPagNoti_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
