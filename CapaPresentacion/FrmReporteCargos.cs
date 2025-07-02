using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidades;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class FrmReporteCargos : Form
    {
        public string OpcionFormulario;
        private DataTable dt;
        private ENCargo_Notificacion oEntidad = new ENCargo_Notificacion();
        private LNotificaciones ologica = new LNotificaciones();
        public FrmReporteCargos()
        {
            InitializeComponent();
        }

        private void FrmReporteCargos_Load(object sender, EventArgs e)
        {
            DTIFInicial.Text = DateTime.Now.ToString();
            DTIFIFinal.Text = DateTime.Now.ToShortDateString();
        }

        private void BtnProcesar_Click(object sender, EventArgs e)
        {
            ListarCargos();
        }

        private void ListarCargos()
        {
            DateTime ffini, ffinal;
            this.LVListadoValores.Items.Clear();
            this.LVListadoValores.FullRowSelect = true;
            ffini  = Convert.ToDateTime(DTIFInicial.Value);
            ffinal = Convert.ToDateTime(DTIFIFinal.Value);
            dt = LNotificaciones.print_notificacion( 7, ffini, ffinal);
            if (dt.Rows.Count > 0)
            {
                dtg.DataSource = dt;
                foreach (DataRow row in dt.Rows)
                {
                    // Crear un objeto ListViewItem con los datos del registro
                    var item = new ListViewItem(row["Row"].ToString());
                    item.SubItems.Add(row["Codigo"].ToString());
                    item.SubItems.Add(row["Contribuyente"].ToString());
                    item.SubItems.Add(row["Cargo"].ToString());
                    item.SubItems.Add(row["Notificador"].ToString());
                    item.SubItems.Add(row["Valor"].ToString());
                    item.SubItems.Add(row["Monto"].ToString());
                    item.SubItems.Add(Convert.ToString(row["F_Notifica"]));
                    item.SubItems.Add(row["Firma"].ToString());
                    item.SubItems.Add(row["Parentesco"].ToString());
                    //item.SubItems.Add(row["num_valor"].ToString());
                    //item.SubItems.Add(row["ano_valor"].ToString());
                    //item.SubItems.Add(row["id_valor"].ToString());
                    //item.SubItems.Add(row["num_CARGO"].ToString());
                    //item.SubItems.Add(row["ano_cargo"].ToString());

                    // Agregar el objeto ListViewItem al ListView
                    this.LVListadoValores.Items.Add(item);
                }
            }
            else
            {
                MessageBox.Show("NO HAY REGISTROS","SISTEMA",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }            
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnImprimir_Click(object sender, EventArgs e)
        {            
            if (LVListadoValores.Items.Count > 1)
            {
                Variables.fechaini = Convert.ToDateTime(DTIFInicial.Value);
                Variables.fechafin = Convert.ToDateTime(DTIFIFinal.Value);
                Reporte.FrmReporteNotificaciones frm = new Reporte.FrmReporteNotificaciones();
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("NO HAY ELEMENTOS PARA REALIZAR EL REPORTE","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
        }
    }
}
