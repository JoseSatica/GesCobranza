using CapaNegocio;
using DevComponents.DotNetBar.Controls;
using System;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmReporteCartera : Form
    {
        public FrmReporteCartera()
        {
            InitializeComponent();
        }
        private string usuario;
        private DataTable comboGestor;
        private string codigo;
        private string nombre;
        private string appaterno;
        private string apmaterno;
        private string estado;
        private string seguimiento;
        private DateTime fechaini;
        private DateTime fechafin;
        private DataTable comboSeguimiento;
        private DataTable comboEstado;
        private DataTable tablita = new DataTable();


        private void FrmReporteCartera_Load(object sender, EventArgs e)
        {
            this.MinimumSize = this.MaximumSize = this.Size;
            
            cargarComboGestores();
            cargarComboEstado();
            cargarComboSeguimiento();
            verificarJefe();
        }
        private void verificarJefe()
        {
            if (Variables.tipo_usuario == "JEFE")
            {
                LblGestor.Visible = true;
                CbxGestores.Enabled = true;
                CbxGestores.Visible = true;
                usuario = "";
            }
            else
            {
                usuario = Variables.cod_usuario;
            }
        }
        private void cargarComboGestores()
        {
            comboGestor = NVerCartera.CargarDGVGestores();
            CbxGestores.DataSource = comboGestor;
            CbxGestores.DisplayMember = "gestor";
            CbxGestores.ValueMember = "gestor";
        }
        private void cargarComboSeguimiento()
        {
            comboSeguimiento = NVerCartera.CargarComboSeguimientos();
            foreach (DataRow fila in comboSeguimiento.Rows)
            {
                CbxSeguimiento.Items.Add(fila["deta_seguimiento"].ToString().Trim());
            }
        }
        private void cargarComboEstado()
        {
            comboEstado = NVerCartera.CargarComboEstados();
            foreach (DataRow fila in comboEstado.Rows)
            {
                CbxEstado.Items.Add(fila["deta_estado"].ToString().Trim());
            }
        }
        private void ocultarColumnas()
        {
            foreach (DataGridViewColumn item in DgvCartera.Columns)
            {
                if (item.HeaderCell.Value.ToString() == "ROW" || item.HeaderCell.Value.ToString() == "id_detalle_cartera" || item.HeaderCell.Value.ToString() == "id_cartera" || item.HeaderCell.Value.ToString() == "id_seguimiento" || item.HeaderCell.Value.ToString() == "num_doc")
                {
                    item.Visible = false;
                }
            }
        }

        private void BtnReporte_Click(object sender, EventArgs e)
        {
            try
            {
                Reporte.FrmReporteCartera frm = new Reporte.FrmReporteCartera();
                frm.ShowDialog();
                limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"SE PRODUJO UN ERROR: \n{ex}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
        
        private async void BtnBuscar_Click(object sender, EventArgs e)
        {
            
            //if (DgvCartera.RowCount > 0)
            //{
            //    DgvCartera.Columns.Clear();
            //}
            try
            {
                DgvCartera.VirtualMode = true;
                variables();
                // Ejecuta la consulta en un hilo separado para evitar congelar la UI
                ptbLoad3.Visible = true;
                tablita = await Task.Run(() =>
                    NReporte.ReporteGestionCartera(codigo, estado, seguimiento, nombre, appaterno, apmaterno, usuario, fechaini, fechafin)
                );
                DgvCartera.Enabled = false;
                DgvCartera.SuspendLayout();
                DgvCartera.Invoke(new Action(() =>
                {
                    DgvCartera.DataSource = tablita;
                }));
                //DgvCartera.DataSource = tablita;
                DgvCartera.ResumeLayout();
                DgvCartera.Enabled = true;
                BtnReporte.Enabled = true;
                ptbLoad3.Visible = false;
                MessageBox.Show("LISTO", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //Task<DataTable> Tarea = new Task<DataTable>(BuscarCartera);
                //Tarea.Start();
                //ptbLoad3.Visible = true;
                //DgvCartera.SuspendLayout();
                //DgvCartera.DataSource =  await Tarea;
                //ocultarColumnas();
                //DgvCartera.ResumeLayout();
                //MessageBox.Show("LISTO","SISTEMA",MessageBoxButtons.OK,MessageBoxIcon.Information);
                //BtnReporte.Enabled = true;
                //ptbLoad3.Visible = false;

                Variables.gestor = usuario;
                Variables.codigo = codigo;
                Variables.nombre_contri = nombre;
                Variables.ap_paterno = appaterno;
                Variables.ap_materno = apmaterno;
                Variables.deta_estado = estado;
                Variables.deta_seguimiento = seguimiento;
                Variables.fechaini = Convert.ToDateTime(DtpIni.Value);
                Variables.fechafin = Convert.ToDateTime(DtpFin.Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"SE PRODUJO UN ERROR: \n{ex}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
        private DataTable BuscarCartera()
        {
            DataTable tabla = NReporte.ReporteGestionCartera(codigo, estado, seguimiento, nombre, appaterno, apmaterno, usuario, fechaini, fechafin);
            return tabla;
             
        }

        private void limpiar()
        {
            TxtCodigo.Text = "";
            TxtNombre.Text = "";
            TxtApPaterno.Text = "";
            TxtApMaterno.Text = "";
            CbxEstado.Text = "";
            CbxSeguimiento.Text = "";
            CbxGestores.Text = (Variables.tipo_usuario == "JEFE") ? "" : Variables.cod_usuario;
            TxtCodigo.Focus();
        }
        private void variables()
        {
            codigo = TxtCodigo.Text.Trim();
            nombre = TxtNombre.Text.Trim();
            appaterno = TxtApPaterno.Text.Trim();
            apmaterno = TxtApMaterno.Text.Trim();
            estado = CbxEstado.Text;
            seguimiento = CbxSeguimiento.Text;
            usuario = (Variables.tipo_usuario == "JEFE") ? CbxGestores.SelectedValue.ToString() : Variables.cod_usuario;
            fechaini = Convert.ToDateTime(DtpIni.Value);
            fechafin = Convert.ToDateTime(DtpFin.Value);
        }

        private void DgvCartera_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CbxEstado_SelectedValueChanged(object sender, EventArgs e)
        {
            if (CbxEstado.SelectedIndex == 0)
            {
                CbxEstado.SelectedIndex = -1;
            }
        }

        private void CbxSeguimiento_SelectedValueChanged(object sender, EventArgs e)
        {
            if (CbxSeguimiento.SelectedIndex == 0)
            {
                CbxSeguimiento.SelectedIndex = -1;
            }
        }

        private void CbxGestores_SelectedValueChanged(object sender, EventArgs e)
        {
            //if (CbxGestores.SelectedIndex == 0)
            //{
            //    CbxGestores.SelectedIndex = -1;
            //}
        }
    }
}
