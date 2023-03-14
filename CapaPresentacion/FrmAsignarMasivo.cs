using CapaNegocio;
using System;
using System.Data;
using System.IO;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmAsignarMasivo : Form
    {
        public FrmAsignarMasivo()
        {
            InitializeComponent();
        }
        private DataTable TablaCodigos;
        private string ruta;
        private string extension;
        private DataTable comboGestor;
        private int id_gestor;
        private int id_gestor_antiguo;
        private int id_gestor_nuevo;
        private string cod_gestor;
        private DataTable comboGestorAntiguo;
        private DataTable comboGestorNuevo;

        private void FrmAsignarMasivo_Load(object sender, EventArgs e)
        {
            cargarComboGestores();
            cargarComboGestoresAntiguo();
            cargarComboGestoresNuevo();
        }
        private void cargarComboGestores()
        {
            comboGestor = NVerCartera.CargarComboGestores();
            foreach (DataRow fila in comboGestor.Rows)
            {
                CbxGestores.Items.Add(fila["cod_gestor"].ToString().Trim());
            }
        }
        private void cargarComboGestoresAntiguo()
        {
            comboGestorAntiguo = NVerCartera.CargarComboGestores();
            foreach (DataRow fila in comboGestorAntiguo.Rows)
            {
                cbxGestorAntiguoCambiar.Items.Add(fila["cod_gestor"].ToString().Trim());
            }
        }
        private void cargarComboGestoresNuevo()
        {
            comboGestorNuevo = NVerCartera.CargarComboGestores();
            foreach (DataRow fila in comboGestorNuevo.Rows)
            {
                cbxGestorNuevoCambiar.Items.Add(fila["cod_gestor"].ToString().Trim());
            }
        }
        private void BtnArchivo_Click(object sender, EventArgs e)
        {
            OpFileBuscarArchivo.InitialDirectory = "C:\\"; //Users\\jmozo\\Downloads"; //"D:\\";
            OpFileBuscarArchivo.Filter = "Archivos de texto (*.txt)|*.txt|Archivos CSV (*.csv)|*.csv|Archivos de Excel (*.xlsx)|*.xlsx";
            OpFileBuscarArchivo.FilterIndex = 2;
            OpFileBuscarArchivo.RestoreDirectory = true;

            if (OpFileBuscarArchivo.ShowDialog() == DialogResult.OK)
            {
                LblRuta.Text = OpFileBuscarArchivo.FileName;
                extension = Path.GetExtension(OpFileBuscarArchivo.FileName);
                ruta = LblRuta.Text.Remove(0, 3);
                prueba.Columns.Clear();
            }
            // OBTENER IP
            Lblp.Text = ObtenerIp();
            //------ VALIDAR -----
            if (LblRuta.Text != "Ruta")
            {
                BtnCargarArchivo.Enabled = true;
            }
            LblRuta.Visible = true;
        }

        private string ObtenerIp()
        {
            IPHostEntry host;
            string localIP = "";
            host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily.ToString() == "InterNetwork")
                {
                    localIP = ip.ToString();
                }
            }
            return localIP;
        }

        private void BtnCargarArchivo_Click(object sender, EventArgs e)
        {
            try
            {
                TablaCodigos = NAsignarMasivo.SubirArchivoCodigoMasivo(Lblp.Text.Trim(), ruta.Trim());

                if (TablaCodigos.Rows.Count > 0)
                {
                    prueba.DataSource = TablaCodigos;
                    CbxGestores.Enabled = true;
                    BtnEnviarCartera.Enabled = true;
                    LblNumRegistro.Text = prueba.Rows.Count.ToString();
                    LblNumRegistro.Visible = true;
                    LblRuta.Visible = true;
                    LblNumReTxt.Visible = true;
                    MessageBox.Show("EL ARCHIVO CARGO CORRECTAMENTE", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"HUBO UN ERROR AL SUBIR EL ARCHIVO: \n{ex}", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private async void BtnEnviarCartera_Click(object sender, EventArgs e)
        {
            Task Tarea = new Task(EnviarCartera);
            PtbLoad.Visible = true;
            Tarea.Start();
            await Tarea;
            PtbLoad.Visible = false;
            MessageBox.Show("TERMINO EL ENVIO", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LblRuta.Visible = false;
            LblNumRegistro.Visible = false;
            LblRuta.Visible = false;
            prueba.Columns.Clear();
        }

        private void EnviarCartera()
        {
            string vercodigo;
            try
            {
                if (cod_gestor != "" && prueba.RowCount > 1)
                {
                    foreach (DataGridViewRow fila in prueba.Rows)
                    {
                        string codigo = fila.Cells["codigo"].Value.ToString().Trim();
                        codigo = codigo.Replace("\"", "");
                        codigo = codigo.PadLeft(7, '0');
                        string existe = NAsignarMasivo.ExisteCodigo(codigo);
                        if (existe == "1")
                        {
                            //MessageBox.Show("YA EXISTE ESTE REGISTRO EN LA CARTERA,  CON EL CODIGO: " + codigo, "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            continue;
                        }
                        else
                        {
                            //vercodigo = codigo; //para ver el codigo que da error
                            if ( NAsignarMasivo.EnviarMonto(codigo).Rows.Count <= 0)
                            {
                                continue;
                            }
                            decimal suma = Convert.ToDecimal(NAsignarMasivo.EnviarMonto(codigo).Rows[0]["suma"].ToString());
                            int id = Convert.ToInt32(NAsignarMasivo.EnviarCartera(id_gestor, codigo, 1, 1, suma).Rows[0]["id"].ToString());
                            NCarteraDetalle.InsertarDetalleGestion(id, 1, "", "", "", "", "INICIO DE TRAMITE", suma, "", Environment.UserName.ToString(), Environment.MachineName.ToString(), Variables.cod_usuario);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                
                MessageBox.Show($"SE PRODUJO EL SIGUIENTE ERROR: \n{ex}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            //if (CbxGestores.InvokeRequired)
            //{
            //    CbxGestores.Invoke(new MethodInvoker(() =>
            //    {
            //        // PONER LO DE AFUERA ACA.
            //    }));
            //}
        }

        private void CbxGestores_SelectedValueChanged(object sender, EventArgs e)
        {
            foreach (DataRow item in comboGestor.Rows)
            {
                if (CbxGestores.Text == item["cod_gestor"].ToString())
                {
                    id_gestor = Convert.ToInt32(item["id_gestor"].ToString());
                    cod_gestor = CbxGestores.Text;
                }
            }
        }
        private void BtnArchivo_MouseHover(object sender, EventArgs e)
        {
            TipAyuda.AutoPopDelay = 4000;
            TipAyuda.InitialDelay = 4000;
            TipAyuda.SetToolTip(this.BtnArchivo, "PERMITE SELECCIONAR EL ARCHIVO .CSV QUE SERA CARGADO");
            TipAyuda.Hide(BtnArchivo);
        }

        private void BtnCargarArchivo_MouseHover(object sender, EventArgs e)
        {
            TipAyuda.AutoPopDelay = 4000;
            TipAyuda.InitialDelay = 4000;
            TipAyuda.SetToolTip(this.BtnCargarArchivo, "CARGAR LA INFORMACION DEL .CSV SELECCIONADA A LA TABLA");
            TipAyuda.Hide(BtnCargarArchivo);
        }

        private void BtnEnviarCartera_MouseHover(object sender, EventArgs e)
        {
            TipAyuda.AutoPopDelay = 4000;
            TipAyuda.InitialDelay = 4000;
            TipAyuda.SetToolTip(this.BtnEnviarCartera, "ENVIA LA INFORMACION DEL CONTRIBUYENTE A LA CARTERA DEL GESTOR SELECCIONADO");
            TipAyuda.Hide(BtnEnviarCartera);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void BtnCambiarCartera_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbxGestorAntiguoCambiar.Text != cbxGestorNuevoCambiar.Text)
                {
                    DialogResult resultado = MessageBox.Show("¿DESEA ASIGNARLE TODA LA CARTERA AL GESTOR NUEVO?", "SISTEMA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (resultado == DialogResult.Yes)
                    {
                        NAsignarMasivo.CambiarDeCartera(id_gestor_nuevo, id_gestor_antiguo);
                        MessageBox.Show("SE REALIZO EL CAMBIO CORRECTAMENTE","SISTEMA",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("DEBE ELEGIR OTRO GESTOR DIFERENTE", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"SE PRODUJO UN ERROR: \n{ex}","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Stop);
            }
        }

        private void cbxGestorAntiguoCambiar_SelectedValueChanged(object sender, EventArgs e)
        {
            foreach (DataRow item in comboGestorAntiguo.Rows)
            {
                if (cbxGestorAntiguoCambiar.Text == item["cod_gestor"].ToString())
                {
                    id_gestor_antiguo = Convert.ToInt32(item["id_gestor"].ToString());
                }
            }
        }

        private void cbxGestorNuevoCambiar_SelectedValueChanged(object sender, EventArgs e)
        {
            foreach (DataRow item in comboGestorNuevo.Rows)
            {
                if (cbxGestorNuevoCambiar.Text == item["cod_gestor"].ToString())
                {
                    id_gestor_nuevo = Convert.ToInt32(item["id_gestor"].ToString());
                }
            }
        }
    }
}
