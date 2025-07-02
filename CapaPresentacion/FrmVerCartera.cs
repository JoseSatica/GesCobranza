using CapaNegocio;
using DevComponents.DotNetBar.Controls;
using System;
using System.Data;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmVerCartera : Form{
        public FrmVerCartera(){
            InitializeComponent();
        }
        public string tipos {  get; set; }
        public DataTable TablaEnvio;public DataTable Tablita;private DataTable comboSeguimiento;
        private DataTable comboEstado;private DataTable comboGestor;private DataTable Cartera;
        private string usuario;
        DateTimePicker dtpfechacambio = new DateTimePicker();
        int rowIndex;
        private string codigo;private string estado;private string seguimiento;private string nombre;
        private string paterno;private string materno;private string gestor;
        DateTime dtpini;DateTime dtpfin;
        private int paginicio = 1;private int pagtotal = 20;private int rowini = 1;private int rowfin = 20;
        //private int opc = 0;
        private string via;private string urb;private string nro;private string dpto;private string mza;private string lte;private string sublte;
        private int BuscoPredio = 0;private int BuscoNormal = 0;private int actualizomonto = 0;

        private void FrmVerCartera_Load(object sender, EventArgs e){
            //this.MinimumSize = this.MaximumSize = this.Size;
            //this.Height = Variables.height_panel;
            //this.Width = Variables.withd_panel;
            PtbLoad.IsRunning = true;
            SuspendLayout();
            RbCodigo.Checked = true;
            cargarComboGestores();
            cargarComboSeguimiento();
            cargarComboEstado();

            dtpfechacambio.Format = DateTimePickerFormat.Short;
            dtpfechacambio.Width = 100;
            //dtpfechacambio.ShowCheckBox = true;
            eDITARFECHAAGESTIONARToolStripMenuItem.DropDown.Items.Add(new ToolStripControlHost(dtpfechacambio));
            ResumeLayout();

        }
        private void dtpfechacambio_ValueChanged(object sender, EventArgs e){
            string fechaSeleccionada = dtpfechacambio.Text;
            int idcartera = Convert.ToInt32(DgvCartera.Rows[rowIndex].Cells["id_cartera"].Value.ToString());
            NVerCartera.ActualizarFechaAGestionar(idcartera, fechaSeleccionada);
            pintarFilas();

        }        
        private void verificarJefe(){
            if (Variables.tipo_usuario == "JEFE"){
                LblGestor.Visible = true;
                CbxGestores.Enabled = true;
                CbxGestores.Visible = true;
                BtnAsignarGestor.Enabled = true;
                usuario = "";
                CmsMenuOpciones.Items["aNULARToolStripMenuItem"].Enabled = true;
            }
            else{
                usuario = Variables.cod_usuario;
            }
        }
        private void cargarComboSeguimiento(){
            comboSeguimiento = NVerCartera.CargarComboSeguimientos();
            foreach (DataRow fila in comboSeguimiento.Rows){
                CbxSeguimiento.Items.Add(fila["deta_seguimiento"].ToString().Trim());
            }
        }
        private void cargarComboEstado(){
            comboEstado = NVerCartera.CargarComboEstados();
            foreach (DataRow fila in comboEstado.Rows){
                CbxEstado.Items.Add(fila["deta_estado"].ToString().Trim());
            }
        }
        private void cargarComboGestores(){
            comboGestor = NVerCartera.CargarDGVGestores();
            CbxGestores.DataSource = comboGestor;
            CbxGestores.DisplayMember = "gestor";
            CbxGestores.ValueMember = "gestor";
            
        }
        private void cargarDgvCartera(){
            if (DgvCartera.InvokeRequired){
                DgvCartera.Invoke(new Action(() => DgvCartera.DataSource = Cartera));
                DgvCartera.RowHeadersVisible = false;
            }
            else{
                DgvCartera.DataSource = Cartera;
            }
        }
        private async void BtnBuscar_Click(object sender, EventArgs e){
            try{
                DgvCartera.DataSource = null;
                DgvCartera.Rows.Clear();

                rowini = 1;
                rowfin = 20;
                paginicio = 1;
                lblpaginicio.Text = "1";
                lblpagtotal.Text = "20";
                PanelPaginador.Visible = true;
                if (Cartera != null){
                    Cartera.Rows.Clear();
                }
                if (RbDireccion.Checked == false){
                    codigo = TxtCodigo.Text.Trim();
                    estado = CbxEstado.Text.Trim();
                    seguimiento = CbxSeguimiento.Text.Trim();
                    nombre = TxtNombre.Text.Trim();
                    paterno = TxtApPaterno.Text.Trim();
                    materno = TxtApMaterno.Text.Trim();
                    gestor = (Variables.tipo_usuario == "JEFE") ? CbxGestores.SelectedValue.ToString() : Variables.cod_usuario;
                    dtpini = Convert.ToDateTime(DtpIni.Value);
                    dtpfin = Convert.ToDateTime(DtpFin.Value);
                    Paginador();
                    // Acá se realiza el proceso de cargar datos en el datatable
                    Task Buscar = new Task(buscarCartera);
                    PtbLoad.Visible = true;
                    Buscar.Start();
                    await Buscar;
                    //
                    DgvCartera.DataSource = Cartera;

                    if (DgvCartera.Rows.Count > 0){
                        ocultarColumnas();
                        pintarFilas();
                    }
                    //MessageBox.Show("LISTO", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    PtbLoad.Visible = false;
                    BuscoNormal = 1;
                    BuscoPredio = 0;
                }
                else{
                    usuario = (Variables.tipo_usuario == "JEFE") ? CbxGestores.Text : Variables.cod_usuario;
                    via = TxtVia.Text.Trim();
                    urb = TxtUrb.Text.Trim();
                    nro = TxtNro.Text.Trim();
                    dpto = TxtDpto.Text.Trim();
                    mza = TxtMza.Text.Trim();
                    lte = TxtLte.Text.Trim();
                    sublte = TxtSubLte.Text.Trim();
                    PaginadorPredio();
                    Task Buscar1 = new Task(buscarCartera);
                    PtbLoad.Visible = true;
                    Buscar1.Start();
                    await Buscar1;
                    DgvCartera.DataSource = Cartera;
                    if (DgvCartera.Rows.Count > 0){
                        ocultarColumnas();
                        pintarFilas();
                    }
                    //MessageBox.Show("LISTO", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    PtbLoad.Visible = false;
                    BuscoNormal = 0;
                    BuscoPredio = 1;
                }
            }
            catch (Exception ex){
                MessageBox.Show($"SE PRODUJO EL SIGUIENTE ERROR: \n{ex}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
        private void buscarCartera(){
            if (RbDireccion.Checked == false){
                Cartera = NVerCartera.BuscarCartera(codigo, estado, seguimiento, nombre, paterno, materno, gestor, dtpini, dtpfin, rowini, rowfin);
            }
            else{
                Cartera = NVerCartera.BuscarCarteraPorPredio(usuario, urb, via, nro, dpto, mza, lte, sublte, rowini, rowfin);
            }

        }
        private void Limpiar(){
            TxtCodigo.Text = "";TxtNombre.Text = "";TxtApPaterno.Text = "";TxtApMaterno.Text = "";
            CbxEstado.Text = "";CbxSeguimiento.Text = "";TxtUrb.Text = "";TxtVia.Text = "";
            TxtNro.Text = "";TxtDpto.Text = "";TxtMza.Text = "";TxtLte.Text = "";TxtSubLte.Text = "";
            CbxGestores.Text = (Variables.tipo_usuario == "JEFE") ? "" : Variables.cod_usuario;
            TxtCodigo.Focus();
            DgvCartera.Columns.Clear();
        }
        private void pintarFilas(){
            //DgvCartera.Columns[0].HeaderText = "Gestor"; 
            if (DgvCartera.Rows.Count > 0) {
                DgvCartera.RowHeadersVisible = false;
                DgvCartera.Columns["Orden"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                DgvCartera.Columns["Orden"].DisplayIndex = 0;
                DgvCartera.Columns["Orden"].Width = 40;
                DgvCartera.Columns["Orden"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;

                DgvCartera.Columns["Contribuyente"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                DgvCartera.Columns["Contribuyente"].Width = 320;
                DgvCartera.Columns["Contribuyente"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                DgvCartera.Columns["Contribuyente"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;

                DgvCartera.Columns["Direccion"].Width= 370;
                DgvCartera.Columns["Direccion"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                DgvCartera.Columns["Direccion"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;

                DgvCartera.Columns["Monto"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                DgvCartera.Columns["Monto"].DefaultCellStyle.Format = "N2";

                //DgvCartera.Columns["ROW"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            foreach (DataGridViewRow fila in DgvCartera.Rows){
                fila.Cells["Orden"].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                fila.Cells["Monto"].Style.Alignment = DataGridViewContentAlignment.MiddleRight;
                if (fila.Cells["Fecha_A_Gestionar"].Value.ToString().Trim() != "" && fila.Cells["Seguimiento"].Value.ToString().Trim() != "NO EXISTE"){
                    DateTime fechaGestion = Convert.ToDateTime(fila.Cells["Fecha_A_Gestionar"].Value.ToString().Trim()).Date;

                    if (fechaGestion >= DateTime.Now.Date.AddDays(-5)){
                        fila.DefaultCellStyle.ForeColor = Color.ForestGreen;
                        fila.DefaultCellStyle.SelectionBackColor = Color.ForestGreen;
                    }
                    if (fechaGestion == DateTime.Now.Date){
                        fila.DefaultCellStyle.ForeColor = Color.SlateBlue;
                        fila.DefaultCellStyle.SelectionBackColor = Color.SlateBlue;
                    }
                    if (fechaGestion < DateTime.Now.Date){
                        fila.DefaultCellStyle.ForeColor = Color.Crimson;
                        fila.DefaultCellStyle.SelectionBackColor = Color.Crimson;
                    }
                }
                else if (fila.Cells["Seguimiento"].Value.ToString().Trim() == "NO EXISTE"){
                    fila.DefaultCellStyle.ForeColor = Color.DimGray;
                    fila.DefaultCellStyle.SelectionBackColor = Color.DimGray;
                }
            }
        }
        private void CompararMonto(){
            try{
                foreach (DataGridViewRow item in DgvCartera.SelectedRows){
                    int id = Convert.ToInt32(item.Cells["id_cartera"].Value.ToString());
                    string codigo = item.Cells["Codigo"].Value.ToString().Trim();
                    decimal montoCartera = Convert.ToDecimal(item.Cells["Monto"].Value.ToString().Trim());
                    string fecha_por_gestionar = item.Cells["Fecha_A_Gestionar"].Value.ToString().Trim();
                    TablaEnvio = NGestion.CalcularDeuda(codigo, "", "*02.30*,*02.01*,*00.16*,*30.02*,*30.03*,*30.04*,*30.82*,*25.04*,*11.00*,*02.30*,*00.38*,*00.30*,*25.10*,**", "", "", "", "0");
                    int contador = 0;
                    decimal monto = 0;
                    foreach (DataRow row in TablaEnvio.Rows){
                        monto += decimal.Round(((Convert.ToDecimal(TablaEnvio.Rows[contador][14]) + Convert.ToDecimal(TablaEnvio.Rows[contador][12])) + Convert.ToDecimal(TablaEnvio.Rows[contador][16])) - Convert.ToDecimal(TablaEnvio.Rows[contador][30]), 2);
                        contador++;
                    }
                    if (montoCartera != monto){
                        //DialogResult Rpta = MessageBox.Show("SE ENCONTRO VARIACION DE LA DEUDA PARA EL CODIGO: " + codigo + "\n\n" + "EL MONTO DE LA CARTERA: " + montoCartera + " NO ES IGUAL AL MONTO DE LA DEUDA ACTUAL: " + monto + "\n\n" + "¿DESEA ACTUALIZAR ESTE CONTRIBUYENTE CON LA DEUDA ACTUAL?", "SISTEMA", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        //if (Rpta == DialogResult.Yes){
                            ////NVerCartera.ActualizarMontoRefrescar(id, monto);
                            NCarteraDetalle.ActualizarCarteraSeguimiento(id, 6, DateTime.Now, monto, fecha_por_gestionar);
                            NCarteraDetalle.ActualizarEstadoCartera(2, id);
                            NCarteraDetalle.InsertarDetalleGestion(id, 6, "", "", "", "", "POR ACTUALIZACION DE MONTO", monto, fecha_por_gestionar, Environment.UserName.ToString(), Environment.MachineName.ToString(), Variables.cod_usuario,"","");
                        //MessageBox.Show("SE ACTUALIZO CORRECTAMENTE EL CODIGO: " + codigo + ", CON EL MONTO " + monto, "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //cargarDgvCartera();
                        //}
                        actualizomonto = 1;
                    }
                    TablaEnvio.Clear();
                }
            }
            catch (Exception ex){
                MessageBox.Show("SE PRODUJO EL SIGUIENTE ERROR: \n" + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ocultarColumnas(){
            foreach (DataGridViewColumn item in DgvCartera.Columns){
                if (//item.HeaderCell.Value.ToString() == "ROW" || 
                    item.HeaderCell.Value.ToString() == "id_detalle_cartera" || item.HeaderCell.Value.ToString() == "id_cartera" || item.HeaderCell.Value.ToString() == "id_seguimiento" || item.HeaderCell.Value.ToString() == "num_doc"){
                    item.Visible = false;
                }
            }
        }
        public event EventHandler BotonBPresionado;
        private void BtnActuaGest_Click_1(object sender, EventArgs e){
            try{
                string validar = (DgvCartera.Rows.Count > 0) ? DgvCartera.CurrentRow.Cells["Estado"].Value.ToString().Trim() : "";
                if (DgvCartera.SelectedRows.Count > 0){
                    if (validar != "Terminado" && validar != "Cambio de Gestor"){
                        Variables.codigo = DgvCartera.CurrentRow.Cells["Codigo"].Value.ToString().Trim();
                        Variables.nombre_contri = DgvCartera.CurrentRow.Cells["Contribuyente"].Value.ToString().Trim();
                        Variables.id_cartera = Convert.ToInt32(DgvCartera.CurrentRow.Cells["id_cartera"].Value.ToString().Trim());
                        Variables.deta_seguimiento = DgvCartera.CurrentRow.Cells["Seguimiento"].Value.ToString().Trim();
                        Variables.id_seguimiento = Convert.ToInt32(DgvCartera.CurrentRow.Cells["id_seguimiento"].Value.ToString().Trim());
                        Variables.gestor = DgvCartera.CurrentRow.Cells["Gestor"].Value.ToString().Trim();
                        Variables.monto = DgvCartera.CurrentRow.Cells["Monto"].Value.ToString().Trim();
                        BotonBPresionado?.Invoke(this, EventArgs.Empty);
                    }
                    else{
                        MessageBox.Show("ESTA GESTION YA SE TERMINO O CAMBIO DE PROPIETARIO", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else{
                    MessageBox.Show("NO HAY UN REGISTRO SELECCIONADO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            catch (Exception ex){
                MessageBox.Show($"SE PRODUJO EL SIGUIENTE ERROR: \n{ex}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
        private void BtnAsignarGestor_Click_1(object sender, EventArgs e){
            if (DgvCartera.SelectedRows.Count > 0){
                Variables.id_cartera = Convert.ToInt32(DgvCartera.CurrentRow.Cells["id_cartera"].Value.ToString().Trim());
                Variables.codigo = DgvCartera.CurrentRow.Cells["Codigo"].Value.ToString().Trim();
                Variables.gestor = DgvCartera.CurrentRow.Cells["Gestor"].Value.ToString().Trim();
                Variables.nombre_contri = DgvCartera.CurrentRow.Cells["Contribuyente"].Value.ToString().Trim();
                Variables.monto = DgvCartera.CurrentRow.Cells["Monto"].Value.ToString().Trim();
                FrmActualizarJefe frm = new FrmActualizarJefe();
                frm.Show();
            }
            else{
                MessageBox.Show("NO HAY UN REGISTRO SELECCIONADO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
        public event EventHandler LlamarDetalleCartera;
        private void BtnDetalleGestion_Click_1(object sender, EventArgs e){
            if (DgvCartera.SelectedRows.Count > 0){
                Variables.id_cartera = Convert.ToInt32(DgvCartera.CurrentRow.Cells["id_cartera"].Value.ToString());
                Variables.codigo = DgvCartera.CurrentRow.Cells["Codigo"].Value.ToString();
                Variables.nombre_contri = DgvCartera.CurrentRow.Cells["Contribuyente"].Value.ToString();
                Variables.monto = DgvCartera.CurrentRow.Cells["Monto"].Value.ToString();
                Variables.gestor = DgvCartera.CurrentRow.Cells["Gestor"].Value.ToString().Trim();
                Variables.fecha_por_gestionar = DgvCartera.CurrentRow.Cells["Fecha_A_Gestionar"].Value.ToString().Trim();
                LlamarDetalleCartera?.Invoke(this, EventArgs.Empty);
            }
            else{
                MessageBox.Show("NO HAY UN REGISTRO SELECCIONADO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
        public event EventHandler LlamarDetalleDeuda;
        private void BtnVerDeuda_Click_1(object sender, EventArgs e){
            try{
                if (DgvCartera.SelectedRows.Count > 0){
                    SuspendLayout();
                    Variables.codigo = DgvCartera.CurrentRow.Cells["Codigo"].Value.ToString();
                    Variables.nombre_contri = DgvCartera.CurrentRow.Cells["Contribuyente"].Value.ToString();
                    Variables.id_cartera = Convert.ToInt32(DgvCartera.CurrentRow.Cells["id_cartera"].Value.ToString());
                    Variables.deta_seguimiento = DgvCartera.CurrentRow.Cells["Seguimiento"].Value.ToString();
                    Variables.id_seguimiento = Convert.ToInt32(DgvCartera.CurrentRow.Cells["id_seguimiento"].Value.ToString());
                    Variables.dni = DgvCartera.CurrentRow.Cells["num_doc"].Value.ToString();
                    tipos = "*02.30*,*02.01*,*00.16*,*30.02*,*30.03*,*30.04*,*30.82*,*25.04*,*11.00*,*02.30*,*00.38*,*00.30*,*25.10*,**";
                    LlamarDetalleDeuda?.Invoke(this, EventArgs.Empty);
                    ResumeLayout();
                }
                else{
                    MessageBox.Show("NO HAY UN REGISTRO SELECCIONADO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            catch (Exception ex){
                MessageBox.Show($"SE PRODUJO EL SIGUIENTE ERROR: \n{ex}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
        private void FrmVerCartera_Shown(object sender, EventArgs e){
            aNULARToolStripMenuItem.Enabled = false;
            verificarJefe();
            this.Height = Variables.height_panel;
            this.Width = Variables.withd_panel;

        }
        private void BtnLimpiar_Click_1(object sender, EventArgs e){
            Limpiar();
        }
        private void FrmCartera_FormClosed(object sender, FormClosedEventArgs e){
            Application.Exit();
        }
        private async void BtnRefrescar_Click_1(object sender, EventArgs e){
            if (MessageBox.Show("¿Desea actualizar la información de las deudas?","",MessageBoxButtons.YesNo,MessageBoxIcon.Information) == DialogResult.Yes){
                Task Tarea = new Task(CompararMonto);
                Tarea.Start();
                PtbLoad.Visible = true;
                await Tarea;
                if (actualizomonto == 1){
                    MessageBox.Show("SE ACTUALIZO CORRECTAMENTE EL MONTO ", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                PtbLoad.Visible = false;
            }

        }
        private void BtnRefrescar_MouseHover(object sender, EventArgs e){
            TipAyuda.AutoPopDelay = 5000;TipAyuda.InitialDelay = 500;
            TipAyuda.SetToolTip(this.BtnRefrescar, "PERMITE ACTUALIZAR EL CAMPO MONTO AL(LOS) REGISTRO(S) SELECCIONADO(S), CON EL ACTUAL SI ES QUE HUBIESE UNA VARIACION");
            TipAyuda.Hide(BtnRefrescar);
        }
        private void BtnDetalleGestion_MouseHover(object sender, EventArgs e){
            TipAyuda.AutoPopDelay = 5000;TipAyuda.InitialDelay = 500;
            TipAyuda.SetToolTip(this.BtnDetalleGestion, "PERMITE VISUALIZAR A DETALLE LOS REGISTROS QUE SE HICIERON A ESA GESTION");
            TipAyuda.Hide(BtnDetalleGestion);
        }
        private void BtnVerDeuda_MouseHover(object sender, EventArgs e){
            TipAyuda.AutoPopDelay = 5000;TipAyuda.InitialDelay = 500;
            TipAyuda.SetToolTip(this.BtnVerDeuda, "PERMITE VISUALIZAR EL DETALLE DE LA DEUDA DE LA GESTION");
            TipAyuda.Hide(BtnVerDeuda);
        }
        private void BtnActuaGest_MouseHover(object sender, EventArgs e){
            TipAyuda.AutoPopDelay = 5000;TipAyuda.InitialDelay = 500;
            TipAyuda.SetToolTip(this.BtnActuaGest, "PERMITE INGRESAR AL FORMULARIO EN EL CUAL SE PODRA ACTUALIZAR EL SEGUIMIENTO DE LA GESTION");
            TipAyuda.Hide(BtnActuaGest);
        }
        private void BtnAsignarGestor_MouseHover(object sender, EventArgs e){
            TipAyuda.AutoPopDelay = 5000;TipAyuda.InitialDelay = 500;
            TipAyuda.SetToolTip(this.BtnAsignarGestor, "PERMITE CAMBIAR DE GESTOR AL CONTRIBUYENTE SELECCIONADO");
            TipAyuda.Hide(BtnAsignarGestor);
        }
        private void CbxEstado_SelectedValueChanged(object sender, EventArgs e){
            if (CbxEstado.SelectedIndex == 0){
                CbxEstado.SelectedIndex = -1;
            }
        }
        private void CbxSeguimiento_SelectedValueChanged(object sender, EventArgs e){
            if (CbxSeguimiento.SelectedIndex == 0){
                CbxSeguimiento.SelectedIndex = -1;
            }
        }
        private void CbxGestores_SelectedValueChanged(object sender, EventArgs e){
            //if (CbxGestores.SelectedIndex == 0)
            //{
            //    CbxGestores.SelectedIndex = -1;
            //}
        }
        private void btnMostrarProgramacion_Click(object sender, EventArgs e){
            try{
                string fecha_por_gestionar = Convert.ToString(DateTime.Now.ToShortDateString());
                //fecha_por_gestionar = fecha_por_gestionar.Remove(10, 9);
                gestor = (Variables.tipo_usuario == "JEFE") ? CbxGestores.SelectedValue.ToString() : Variables.cod_usuario;
                if (DgvCartera != null){DgvCartera.Columns.Clear();}
                DgvCartera.DataSource = NVerCartera.MostrarProgramacion(gestor, fecha_por_gestionar);
                ocultarColumnas();
                pintarFilas();
            }
            catch (Exception ex){
                MessageBox.Show($"SE PRODUJO UN ERROR: \n {ex}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
        private void btnMostrarProgramacion_MouseHover(object sender, EventArgs e){
            TipAyuda.AutoPopDelay = 5000;TipAyuda.InitialDelay = 500;
            TipAyuda.SetToolTip(this.btnMostrarProgramacion, "PERMITE MOSTRAR LAS GESTIONES PROGRAMADAS PARA EL DIA DE HOY");
            TipAyuda.Hide(btnMostrarProgramacion);
        }
        private void aNULARToolStripMenuItem_Click(object sender, EventArgs e){
            Variables.id_cartera = Convert.ToInt32(DgvCartera.CurrentRow.Cells["id_cartera"].Value.ToString());
            Variables.id_detalle_cartera = Convert.ToInt32(DgvCartera.CurrentRow.Cells["id_detalle_cartera"].Value.ToString());
            DialogResult result = MessageBox.Show("¿ESTA SEGURO DE QUERER ANULAR ESTA GESTION?", "SISTEMA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes){
                NCarteraDetalle.ActualizarEstadoCartera(5, Variables.id_cartera);
                NCarteraDetalle.ActualizarEstadoDetalleCartera(Variables.id_detalle_cartera, Variables.cod_usuario, Environment.UserName, Environment.MachineName);
            }
        }
        private void Paginador(){
            pagtotal = Convert.ToInt32(Math.Ceiling(Convert.ToDecimal(NVerCartera.ContadorPaginas(codigo, estado, seguimiento, nombre, paterno, materno, gestor, dtpini, dtpfin).Rows[0][0].ToString()) / 20));
            lblpagtotal.Text = (pagtotal == 0) ? "1" : pagtotal.ToString();
            lblpaginicio.Text = paginicio.ToString();
        }
        private void PaginadorPredio(){
            pagtotal = Convert.ToInt32(Math.Ceiling(Convert.ToDecimal(NVerCartera.BuscarCarteraPorPredioContador(usuario, urb, via, nro, dpto, mza, lte, sublte).Rows[0][0].ToString()) / 20));
            lblpagtotal.Text = (pagtotal == 0) ? "1" : pagtotal.ToString();
            lblpaginicio.Text = paginicio.ToString();
        }
        private async void BtnAnterior_Click(object sender, EventArgs e){
            if (paginicio != 1){
                rowini -= 20;
                rowfin -= 20;
                paginicio -= 1;
                lblpaginicio.Text = paginicio.ToString();
                BtnSiguiente.Enabled = true;
                if (BuscoNormal == 1){Cartera = NVerCartera.BuscarCartera(codigo, estado, seguimiento, nombre, paterno, materno, gestor, dtpini, dtpfin, rowini, rowfin);}
                if (BuscoPredio == 1){Cartera = NVerCartera.BuscarCarteraPorPredio(usuario, urb, via, nro, dpto, mza, lte, sublte, rowini, rowfin);}
                Task tarea = new Task(cargarDgvCartera);
                tarea.Start();
                await tarea;
                pintarFilas();
                ocultarColumnas();
            }
        }
        private async void BtnSiguiente_Click(object sender, EventArgs e){
            if (paginicio != pagtotal && pagtotal != 0){
                rowini += 20;
                rowfin += 20;
                paginicio += 1;
                lblpaginicio.Text = paginicio.ToString();
                BtnAnterior.Enabled = true;
                if (BuscoNormal == 1){Cartera = NVerCartera.BuscarCartera(codigo, estado, seguimiento, nombre, paterno, materno, gestor, dtpini, dtpfin, rowini, rowfin);}
                if (BuscoPredio == 1){Cartera = NVerCartera.BuscarCarteraPorPredio(usuario, urb, via, nro, dpto, mza, lte, sublte, rowini, rowfin);}
                Task tarea2 = new Task(cargarDgvCartera);
                tarea2.Start();
                await tarea2;
                pintarFilas();
                ocultarColumnas();
            }
        }
        private void RbCodigo_CheckedChanged(object sender, EventArgs e){
            if (RbCodigo.Checked == true){
                PanelCodigo.Visible = true;PanelNombres.Visible = false;PanelDireccion.Visible = false;PanelFiltros.Visible = true;
                TxtNombre.Text = "";TxtApPaterno.Text = "";TxtApMaterno.Text = "";
                TxtUrb.Text = "";TxtVia.Text = "";TxtNro.Text = "";TxtMza.Text = "";TxtLte.Text = "";TxtSubLte.Text = "";
                TxtCodigo.Focus();
                PanelCodigo.BringToFront();
            }
        }
        private void RbNombres_CheckedChanged(object sender, EventArgs e){
            if (RbNombres.Checked == true){
                PanelCodigo.Visible = false;PanelDireccion.Visible = false;PanelNombres.Visible = true;PanelFiltros.Visible = true;
                TxtCodigo.Text = "";TxtUrb.Text = "";TxtVia.Text = "";TxtNro.Text = "";TxtMza.Text = "";TxtLte.Text = "";
                TxtNombre.Focus();
                PanelCodigo.SendToBack();
                PanelDireccion.SendToBack();
                PanelNombres.BringToFront();
            }
        }
        private void RbDireccion_CheckedChanged(object sender, EventArgs e){
            if (RbDireccion.Checked == true){
                PanelCodigo.Visible = false;PanelNombres.Visible = false;PanelDireccion.Visible = true;PanelFiltros.Visible = false;
                TxtCodigo.Text = "";TxtNombre.Text = "";TxtApPaterno.Text = "";TxtApMaterno.Text = "";
                TxtUrb.Focus();
                PanelDireccion.BringToFront();
            }
        }
        private void DgvCartera_MouseDown_1(object sender, MouseEventArgs e){
            if (e.Button == MouseButtons.Right){
                var hitTest = DgvCartera.HitTest(e.X, e.Y);
                if (hitTest.Type == DataGridViewHitTestType.Cell && hitTest.Type != DataGridViewHitTestType.ColumnHeader){
                    DgvCartera.ClearSelection();
                    DgvCartera.Rows[hitTest.RowIndex].Selected = true;
                    DgvCartera.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    rowIndex = DgvCartera.HitTest(e.X, e.Y).RowIndex;
                    if (rowIndex != -1){
                        //Seleccionar toda la fila
                        DgvCartera.Rows[rowIndex].Selected = true;
                    }

                    CmsMenuOpciones.Enabled = true;
                    CmsMenuOpciones.ShowItemToolTips = true;
                    CmsMenuOpciones.Visible = true;
                    CmsMenuOpciones.Show(DgvCartera, e.Location);
                    //dtpfechacambio.ValueChanged += dtpfechacambio_ValueChanged;
                    dtpfechacambio.CloseUp += Dtpfechacambio_CloseUp;
                } else {  //if (hitTest.Type == DataGridViewHitTestType.ColumnHeader)
                    CmsMenuOpciones.Enabled = false;
                    CmsMenuOpciones.ShowItemToolTips = false;
                }
            }
        }
        private void Dtpfechacambio_CloseUp(object sender, EventArgs e){
            string fechaSeleccionada = dtpfechacambio.Text;
            int idcartera = Convert.ToInt32(DgvCartera.Rows[rowIndex].Cells["id_cartera"].Value.ToString());
            NVerCartera.ActualizarFechaAGestionar(idcartera, fechaSeleccionada);
            pintarFilas();
        }
        private void DgvCartera_Sorted(object sender, EventArgs e){
            ocultarColumnas();
            pintarFilas();
        }
        private void eDITARFECHAAGESTIONARToolStripMenuItem_Click(object sender, EventArgs e){

        }
        private void TxtCodigo_Leave(object sender, EventArgs e){
            if (!string.IsNullOrEmpty(TxtCodigo.Text)){
                TxtCodigo.Text.PadLeft(7, '0');
            }
        }
    }
}