using CapaNegocio;
using System;
using System.Data;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmVerCartera : Form
    {
        public FrmVerCartera()
        {
            InitializeComponent();
        }
        public DataTable TablaEnvio;
        public DataTable Tablita;
        private DataTable comboSeguimiento;
        private DataTable comboEstado;
        private DataTable comboGestor;
        private DataTable Cartera;
        private string usuario;
        DateTimePicker dtpfechacambio = new DateTimePicker();
        int rowIndex;
        private string codigo;
        private string estado;
        private string seguimiento;
        private string nombre;
        private string paterno;
        private string materno;
        private string gestor;
        DateTime dtpini;
        DateTime dtpfin;
        private void FrmVerCartera_Load(object sender, EventArgs e)
        {
            //this.MinimumSize = this.MaximumSize = this.Size;
            cargarComboGestores();
            cargarComboSeguimiento();
            cargarComboEstado();
            
            dtpfechacambio.Format = DateTimePickerFormat.Short;
            dtpfechacambio.Width = 100;
            //dtpfechacambio.ValueChanged += dtpfechacambio_ValueChanged;
            eDITARFECHAAGESTIONARToolStripMenuItem.DropDown.Items.Add(new ToolStripControlHost(dtpfechacambio));
            
        }

        private void dtpfechacambio_ValueChanged(object sender, EventArgs e)
        {            
            string fechaSeleccionada = dtpfechacambio.Text;
            int idcartera = Convert.ToInt32(DgvCartera.Rows[rowIndex].Cells["id_cartera"].Value.ToString());
            string codigo = DgvCartera.Rows[rowIndex].Cells["Codigo"].Value.ToString();
            int iddetallecartera = Convert.ToInt32(DgvCartera.Rows[rowIndex].Cells["id_detalle_cartera"].Value.ToString());
            NVerCartera.ActualizarFechaAGestionar(iddetallecartera,idcartera, fechaSeleccionada);
            cargarDgvCartera();
            pintarFilas();
        }
        private void verificarJefe()
        {
            if (Variables.tipo_usuario == "JEFE")
            {
                LblGestor.Visible = true;
                CbxGestores.Enabled = true;
                CbxGestores.Visible = true;
                BtnAsignarGestor.Enabled = true;
                usuario = "";
            }
            else
            {
                usuario = Variables.cod_usuario;
            }
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
        private void cargarComboGestores()
        {
            comboGestor = NVerCartera.CargarComboGestores();
            foreach (DataRow fila in comboGestor.Rows)
            {
                CbxGestores.Items.Add(fila["cod_gestor"].ToString().Trim());
            }
        }
        private void cargarDgvCartera()
        {            
            Cartera = NVerCartera.CargarCartera(usuario);
        }
        private async void BtnBuscar_Click(object sender, EventArgs e)
        {          
            try
            {
                //Cartera.Rows.Clear();
                codigo = TxtCodigo.Text.Trim();
                estado = CbxEstado.Text.Trim();
                seguimiento = CbxSeguimiento.Text.Trim();
                nombre = TxtNombre.Text.Trim();
                paterno = TxtApPaterno.Text.Trim();
                materno = TxtApMaterno.Text.Trim();
                gestor = (Variables.tipo_usuario == "JEFE") ? CbxGestores.Text : Variables.cod_usuario;
                dtpini = Convert.ToDateTime(DtpIni.Value);
                dtpfin = Convert.ToDateTime(DtpFin.Value);
                Task tarea = new Task(buscarCartera);
                PtbLoad.Visible = true;
                tarea.Start();                
                await tarea;
                DgvCartera.DataSource = Cartera;
                ocultarColumnas();
                pintarFilas();
                MessageBox.Show("LISTO", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                PtbLoad.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"SE PRODUJO EL SIGUIENTE ERROR: \n{ex}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }       
        private void buscarCartera()
        {
            if (Cartera != null )
            {
                Cartera.Rows.Clear();
            }
            if (PtbLoad.InvokeRequired)
            {
                PtbLoad.Invoke(new MethodInvoker(() =>
                {                                        
                    Cartera = NVerCartera.BuscarCartera(codigo, estado, seguimiento, nombre, paterno, materno, gestor, dtpini, dtpfin);                    
                }));
            }
        }
        private void Limpiar()
        {
            TxtCodigo.Text = "";
            TxtNombre.Text = "";
            TxtApPaterno.Text = "";
            TxtApMaterno.Text = "";
            CbxEstado.Text = "";
            CbxSeguimiento.Text = "";
            CbxGestores.Text = (Variables.tipo_usuario == "JEFE") ? "" : Variables.cod_usuario;           
            TxtCodigo.Focus();
            //cargarDgvCartera();
            DgvCartera.Columns.Clear();
            //ocultarColumnas();
            //pintarFilas();
        }

        private void DgvCartera_Sorted(object sender, EventArgs e)
        {
            ocultarColumnas();
            pintarFilas();
        }
        private void pintarFilas()
        {
            foreach (DataGridViewRow fila in DgvCartera.Rows)
            {
                if (fila.Cells["Fecha_A_Gestionar"].Value.ToString().Trim() != "")
                {
                    DateTime fechaGestion = Convert.ToDateTime(fila.Cells["Fecha_A_Gestionar"].Value.ToString().Trim()).Date;
                    
                    if (fechaGestion >= DateTime.Now.Date.AddDays(-5))
                    {
                        fila.DefaultCellStyle.ForeColor = Color.ForestGreen;
                        fila.DefaultCellStyle.SelectionBackColor = Color.ForestGreen;
                    }
                    if (fechaGestion == DateTime.Now.Date)
                    {
                        fila.DefaultCellStyle.ForeColor = Color.RoyalBlue;
                        fila.DefaultCellStyle.SelectionBackColor = Color.RoyalBlue;
                    }
                    if (fechaGestion < DateTime.Now.Date)
                    {
                        fila.DefaultCellStyle.ForeColor = Color.Crimson;
                        fila.DefaultCellStyle.SelectionBackColor = Color.Crimson;
                    }
                }                
            }
        }

        private void CompararMonto()
        {
            try
            {
                foreach (DataGridViewRow item in DgvCartera.SelectedRows)
                {

                    int id = Convert.ToInt32(item.Cells["id_cartera"].Value.ToString());
                    string codigo = item.Cells["Codigo"].Value.ToString().Trim();
                    decimal montoCartera = Convert.ToDecimal(item.Cells["Monto"].Value.ToString().Trim());
                    string fecha_por_gestionar = item.Cells["Fecha_A_Gestionar"].Value.ToString().Trim();

                    TablaEnvio = NGestion.CalcularDeuda(codigo, "", "", "", "", "", "0");
                    int contador = 0;
                    decimal monto = 0;
                    foreach (DataRow row in TablaEnvio.Rows)
                    {
                        monto += decimal.Round(((Convert.ToDecimal(TablaEnvio.Rows[contador][14]) + Convert.ToDecimal(TablaEnvio.Rows[contador][12])) + Convert.ToDecimal(TablaEnvio.Rows[contador][16])) - Convert.ToDecimal(TablaEnvio.Rows[contador][30]), 2);
                        contador++;
                    }

                    if (montoCartera != monto)
                    {
                        DialogResult Rpta = MessageBox.Show("SE ENCONTRO VARIACION EN: " + codigo + "\n\n" + "EL MONTO DE LA CARTERA: " + montoCartera + " NO ES IGUAL AL MONTO DE LA DEUDA ACTUAL: " + monto + "\n\n" + "¿DESEA ACTUALIZAR ESTE CONTRIBUYENTE CON LA DEUDA ACTUAL?", "SISTEMA", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        if (Rpta == DialogResult.Yes)
                        {
                            //NVerCartera.ActualizarMontoRefrescar(id, monto);
                            NCarteraDetalle.ActualizarCarteraSeguimiento(id,6,DateTime.Now,monto,fecha_por_gestionar);
                            NCarteraDetalle.ActualizarEstadoCartera(2,id);
                            NCarteraDetalle.InsertarDetalleGestion(id,6,"","","","","POR ACTUALIZACION DE MONTO",monto,fecha_por_gestionar, Environment.UserName.ToString(), Environment.MachineName.ToString(), Variables.cod_usuario);
                            MessageBox.Show("SE ACTUALIZO CORRECTAMENTE EL CODIGO: " + codigo + ", CON EL MONTO " + monto, "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            cargarDgvCartera();
                        }
                    }
                    TablaEnvio.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SE PRODUJO EL SIGUIENTE ERROR: \n" + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
           
        private void ocultarColumnas()
        {
            foreach (DataGridViewColumn item in DgvCartera.Columns)
            {
                if (item.HeaderCell.Value.ToString() == "id_detalle_cartera"||item.HeaderCell.Value.ToString() == "id_cartera" || item.HeaderCell.Value.ToString() == "id_seguimiento" || item.HeaderCell.Value.ToString() == "num_doc")
                {
                    item.Visible = false;
                }
            }
        }

        public event EventHandler BotonBPresionado;
        private void BtnActuaGest_Click_1(object sender, EventArgs e)
        {
            try
            {
                string validar = DgvCartera.CurrentRow.Cells["Estado"].Value.ToString().Trim();
                if (validar != "Terminado" && validar != "Cambio de Gestor")
                {
                    Variables.codigo = DgvCartera.CurrentRow.Cells["Codigo"].Value.ToString().Trim();
                    Variables.nombre_contri = DgvCartera.CurrentRow.Cells["Contribuyente"].Value.ToString().Trim();
                    Variables.id_cartera = Convert.ToInt32(DgvCartera.CurrentRow.Cells["id_cartera"].Value.ToString().Trim());
                    Variables.deta_seguimiento = DgvCartera.CurrentRow.Cells["Seguimiento"].Value.ToString().Trim();
                    Variables.id_seguimiento = Convert.ToInt32(DgvCartera.CurrentRow.Cells["id_seguimiento"].Value.ToString().Trim());
                    Variables.gestor = DgvCartera.CurrentRow.Cells["Gestor"].Value.ToString().Trim();
                    Variables.monto = DgvCartera.CurrentRow.Cells["Monto"].Value.ToString().Trim();

                    BotonBPresionado?.Invoke(this, EventArgs.Empty);
                }
                else
                {
                    MessageBox.Show("ESTA GESTION YA SE TERMINO O CAMBIO DE PROPIETARIO", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"SE PRODUJO EL SIGUIENTE ERROR: \n{ex}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void BtnAsignarGestor_Click_1(object sender, EventArgs e)
        {
            Variables.id_cartera = Convert.ToInt32(DgvCartera.CurrentRow.Cells["id_cartera"].Value.ToString().Trim());
            Variables.codigo = DgvCartera.CurrentRow.Cells["Codigo"].Value.ToString().Trim();
            Variables.gestor = DgvCartera.CurrentRow.Cells["Gestor"].Value.ToString().Trim();
            Variables.nombre_contri = DgvCartera.CurrentRow.Cells["Contribuyente"].Value.ToString().Trim();
            Variables.monto = DgvCartera.CurrentRow.Cells["Monto"].Value.ToString().Trim();
            FrmActualizarJefe frm = new FrmActualizarJefe();
            frm.Show();
        }
        public event EventHandler LlamarDetalleCartera;
        private void BtnDetalleGestion_Click_1(object sender, EventArgs e)
        {
            Variables.id_cartera = Convert.ToInt32(DgvCartera.CurrentRow.Cells["id_cartera"].Value.ToString());
            Variables.codigo = DgvCartera.CurrentRow.Cells["Codigo"].Value.ToString();
            Variables.nombre_contri = DgvCartera.CurrentRow.Cells["Contribuyente"].Value.ToString();
            Variables.monto = DgvCartera.CurrentRow.Cells["Monto"].Value.ToString();
            Variables.gestor = DgvCartera.CurrentRow.Cells["Gestor"].Value.ToString().Trim();
            Variables.fecha_por_gestionar = DgvCartera.CurrentRow.Cells["Fecha_A_Gestionar"].Value.ToString().Trim();

            LlamarDetalleCartera?.Invoke(this, EventArgs.Empty);
        }
        public event EventHandler LlamarDetalleDeuda;
        private void BtnVerDeuda_Click_1(object sender, EventArgs e)
        {
            try
            {
                Variables.codigo = DgvCartera.CurrentRow.Cells["Codigo"].Value.ToString();
                Variables.nombre_contri = DgvCartera.CurrentRow.Cells["Contribuyente"].Value.ToString();
                Variables.id_cartera = Convert.ToInt32(DgvCartera.CurrentRow.Cells["id_cartera"].Value.ToString());
                Variables.deta_seguimiento = DgvCartera.CurrentRow.Cells["Seguimiento"].Value.ToString();
                Variables.id_seguimiento = Convert.ToInt32(DgvCartera.CurrentRow.Cells["id_seguimiento"].Value.ToString());
                Variables.dni = DgvCartera.CurrentRow.Cells["num_doc"].Value.ToString();
                
                LlamarDetalleDeuda?.Invoke(this, EventArgs.Empty);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"SE PRODUJO EL SIGUIENTE ERROR: \n{ex}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private  void FrmVerCartera_Shown(object sender, EventArgs e)
        {
            verificarJefe();
            //Task tarea = new Task(cargarDgvCartera);
            //tarea.Start();
            //PtbLoad.Visible = true;
            //await tarea;
            //await Task.Run(() => cargarDgvCartera());
            //DgvCartera.DataSource = Cartera;
            //MessageBox.Show("LISTO");
            //PtbLoad.Visible = false;
            //cargarDgvCartera();
            //ocultarColumnas();
            //pintarFilas();
        }

        private void BtnLimpiar_Click_1(object sender, EventArgs e)
        {
            Limpiar();
        }
        private void FrmCartera_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private async void BtnRefrescar_Click_1(object sender, EventArgs e)
        {
            Task Tarea = new Task(CompararMonto);
            Tarea.Start();
            PtbLoad.Visible = true;
            await Tarea;
            PtbLoad.Visible = false;
        }

        private void DgvCartera_Sorted_1(object sender, EventArgs e)
        {
            ocultarColumnas();
            pintarFilas();
        }

        private void groupBox1_MouseHover(object sender, EventArgs e)
        {
            TipAyuda.AutoPopDelay = 5000;
            TipAyuda.InitialDelay = 4000;
            TipAyuda.SetToolTip(this.groupBox1, "FECHA DE ACTUALIZACION DEL REGISTRO");
            TipAyuda.Hide(groupBox1);
        }

        private void BtnRefrescar_MouseHover(object sender, EventArgs e)
        {
            TipAyuda.AutoPopDelay = 5000;
            TipAyuda.InitialDelay = 4000;
            TipAyuda.SetToolTip(this.BtnRefrescar, "PERMITE ACTUALIZAR EL CAMPO MONTO AL(LOS) REGISTRO(S) SELECCIONADO(S), CON EL ACTUAL SI ES QUE HUBIESE UNA VARIACION");
            TipAyuda.Hide(BtnRefrescar);
        }

        private void BtnDetalleGestion_MouseHover(object sender, EventArgs e)
        {
            TipAyuda.AutoPopDelay = 5000;
            TipAyuda.InitialDelay = 4000;
            TipAyuda.SetToolTip(this.BtnDetalleGestion, "PERMITE VISUALIZAR A DETALLE LOS REGISTROS QUE SE HICIERON A ESA GESTION");
            TipAyuda.Hide(BtnDetalleGestion);

        }

        private void BtnVerDeuda_MouseHover(object sender, EventArgs e)
        {
            TipAyuda.AutoPopDelay = 5000;
            TipAyuda.InitialDelay = 4000;
            TipAyuda.SetToolTip(this.BtnVerDeuda, "PERMITE VISUALIZAR EL DETALLE DE LA DEUDA DE LA GESTION");
            TipAyuda.Hide(BtnVerDeuda);

        }

        private void BtnActuaGest_MouseHover(object sender, EventArgs e)
        {
            TipAyuda.AutoPopDelay = 5000;
            TipAyuda.InitialDelay = 4000;
            TipAyuda.SetToolTip(this.BtnActuaGest, "PERMITE INGRESAR AL FORMULARIO EN EL CUAL SE PODRA ACTUALIZAR EL SEGUIMIENTO DE LA GESTION");
            TipAyuda.Hide(BtnActuaGest);
        }

        private void BtnAsignarGestor_MouseHover(object sender, EventArgs e)
        {
            TipAyuda.AutoPopDelay = 5000;
            TipAyuda.InitialDelay = 4000;
            TipAyuda.SetToolTip(this.BtnAsignarGestor, "PERMITE CAMBIAR DE GESTOR AL CONTRIBUYENTE SELECCIONADO");
            TipAyuda.Hide(BtnAsignarGestor);
        }

        private void DgvCartera_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var hitTest = DgvCartera.HitTest(e.X, e.Y);
                if (hitTest.Type == DataGridViewHitTestType.Cell && hitTest.Type != DataGridViewHitTestType.ColumnHeader)
                {
                    DgvCartera.ClearSelection();

                    DgvCartera.Rows[hitTest.RowIndex].Selected = true;
                    DgvCartera.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    rowIndex = DgvCartera.HitTest(e.X, e.Y).RowIndex;
                    if (rowIndex != -1)
                    {
                        //Seleccionar toda la fila
                        DgvCartera.Rows[rowIndex].Selected = true;
                    }

                    CmsMenuOpciones.Enabled = true;
                    CmsMenuOpciones.ShowItemToolTips = true;
                    CmsMenuOpciones.Visible = true;
                    CmsMenuOpciones.Show(DgvCartera, e.Location);
                    dtpfechacambio.ValueChanged += dtpfechacambio_ValueChanged;

                }
                else //if (hitTest.Type == DataGridViewHitTestType.ColumnHeader)
                {
                    CmsMenuOpciones.Enabled = false;
                    CmsMenuOpciones.ShowItemToolTips = false;
                  
                }
            }
        }

        private void eDITARFECHAAGESTIONARToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
