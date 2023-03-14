using CapaNegocio;
using System;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmIngresoxGestor : Form
    {
        public FrmIngresoxGestor()
        {
            InitializeComponent();
        }
        DataTable comboGestores;
        private void FrmIngresoxGestor_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            cargarComboGestores();
        }
        private void cargarComboGestores()
        {
            comboGestores = NVerCartera.CargarComboGestores();
            foreach (DataRow item in comboGestores.Rows)
            {
                if (comboGestores.Rows.Count > 0)
                {
                    CbxGestor.Items.Add(item["cod_gestor"].ToString().Trim());
                }
            }
        }

        private async void BtnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                Task<DataTable> Tarea = new Task<DataTable>(IngresoxGestor);
                
                Tarea.Start();
                PicBoxLoad.Visible = true;
                DgvMostrarIngreso.DataSource = await Tarea;                                
                CalcularDetalle();
                MessageBox.Show("LISTO!", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                PicBoxLoad.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"SE PRODUJO EL SUIGUIENTE ERROR:\n {ex}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private DataTable IngresoxGestor()
        {
            DataTable tabla = NVerIngresoPorGestor.VerIngresoPorGestor(CbxGestor.Text.Trim(), Convert.ToDateTime(DtpFechaini.Value), Convert.ToDateTime(DtpFechafin.Value));
            return tabla;
        }
        private void CalcularDetalle()
        {

            DataTable Ingresos = (DataTable)(DgvMostrarIngreso.DataSource);


            var VerIngresos = from fila in Ingresos.AsEnumerable()
                              group fila by fila.Field<string>("gestor") into grupo
                              select grupo;

            int contador = 0;
            decimal total = 0;
            decimal sumatotal = 0;
            DgvMostrarIngresoDetalle.Rows.Clear();

            foreach (var grupo in VerIngresos)
            {
                string gestor = grupo.Key;

                foreach (var detallegrupo in grupo)
                {
                    total = detallegrupo.Field<decimal>("Total");
                    sumatotal += total;
                }
                sumatotal.ToString();
                DgvMostrarIngresoDetalle.Rows.Insert(contador, gestor, Convert.ToString(sumatotal));
                contador++;
                sumatotal = 0;
            }

        }

        private void BtnBuscar_MouseHover(object sender, EventArgs e)
        {
            TipAyuda.InitialDelay = 4000;
            TipAyuda.AutoPopDelay = 4000;
            TipAyuda.SetToolTip(this.BtnBuscar, "REALIZARA LA BUSQUEDA CON LOS CRITERIOS DE FECHA Y GESTOR SELECCIONADOS");
            TipAyuda.Hide(BtnBuscar);
        }
    }
}
