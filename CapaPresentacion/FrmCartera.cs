using System;
using System.Configuration;
using System.Windows.Forms;
using System.Drawing;
using System.Linq;

namespace CapaPresentacion
{
    public partial class FrmCartera : Form{
        public string tipos { get; set; }

        public FrmCartera(){
            InitializeComponent();
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        public string cnnstr = ConfigurationManager.AppSettings["BDSISTEMA"];
        private void FrmCartera_Load(object sender, EventArgs e){
            this.MinimumSize = this.MaximumSize = this.Size;
            LblUsuarioNom.Text = Variables.nom_usuario;
            LblArea.Text = Variables.area_usuario;
            resolucionAviso();
            verificarJefe();
        }
        private void verificarJefe(){
            if (Variables.tipo_usuario == "JEFE"){
                BtnAsignarMasivo.Enabled = true;
                BtnMantenimiento.Enabled = true;
                BtnIngresosxGestor.Enabled = true;
                BtnReporte.Enabled = true;
                BtnListaNotificaciones.Enabled = true;
                //btnProgramarGestion.Enabled = true;
            }
        }
        private void resolucionAviso(){
            int screenWidth = Screen.PrimaryScreen.Bounds.Width;
            int screenHeight = Screen.PrimaryScreen.Bounds.Height;
            if (screenWidth < 1366 && screenHeight < 768){
                MessageBox.Show($"LA RESOLUCION DE SU PANTALLA({screenWidth}x{screenHeight}), PUEDE OCASIONAR PROBLEMAS A LA HORA DE USAR EL APLICATIVO.\nPOR FAVOR USE UNA RESOLUCION DE PANTALLA MINIMA DE 1600x900", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private Form FormActivo = null;
        private void PintarBoton(Button boton){
            boton.BackColor = Color.FromArgb(178, 0, 125);
            foreach (Button otroBoton in this.PanelOpciones.Controls.OfType<Button>()){
                if (otroBoton != boton){
                    otroBoton.BackColor = Color.FromArgb(107, 173, 201);
                }
            }
        }
        private void AbrirFormulariosHijos(Form FormHijo){
            if (FormActivo != FormHijo && !PanelFormularios.Controls.Contains(FormHijo)){
                //FormActivo.Close();
                FormActivo = FormHijo;
                FormHijo.TopLevel = false;
                FormHijo.FormBorderStyle = FormBorderStyle.None;
                PanelFormularios.Controls.Add(FormHijo);
                PanelFormularios.Tag = FormHijo;
                FormHijo.Height = Variables.height_panel;
                FormHijo.Width = Variables.withd_panel;
                //FormHijo.Dock = DockStyle.Fill;
                FormHijo.BringToFront();
                FormHijo.Show();
            }
            else{
                FormHijo.BringToFront();
            }
        }

        FrmVerCartera verCartera = new FrmVerCartera();
        //FrmListadoCargos ListadoCargos = new FrmListadoCargos(); 
        private void BtnCartera_Click_1(object sender, EventArgs e){
            PintarBoton(BtnCartera);
            if (FormActivo != verCartera && !PanelFormularios.Controls.Contains(verCartera)){
                AbrirFormulariosHijos(verCartera);
                verCartera.TopLevel = false;
                verCartera.Dock = DockStyle.Fill;
                verCartera.BotonBPresionado += FormA_BotonBPresionado;
                verCartera.LlamarDetalleDeuda += MostrarDetalleDeuda;
                verCartera.LlamarDetalleCartera += MostrarDetalleCartera;
            }
            else{
                verCartera.BringToFront();
            }           
        }
        private void FormA_BotonBPresionado(object sender, EventArgs e){
            FrmCarteraGestionDetalle formB = new FrmCarteraGestionDetalle();
            formB.TopLevel = false;
            PanelFormularios.Controls.Add(formB);
            PanelFormularios.Tag = formB;
            formB.AutoSize = true;
            formB.Dock = DockStyle.Fill;
            formB.BringToFront();
            formB.Show();
        }
        private void MostrarDetalleDeuda(object sender, EventArgs e){
            FrmDeclaJura frmDetalleDeuda = new FrmDeclaJura();
            frmDetalleDeuda.TopLevel = false;
            frmDetalleDeuda.Dock = DockStyle.Fill;
            PanelFormularios.Controls.Add(frmDetalleDeuda);
            PanelFormularios.Tag = frmDetalleDeuda;
            frmDetalleDeuda.tipos = verCartera.tipos;
            frmDetalleDeuda.BringToFront();
            frmDetalleDeuda.Show();
        }
        private void MostrarDetalleCartera(object sender, EventArgs e){
            FrmCarteraDetalle carteraDetalle = new FrmCarteraDetalle();
            carteraDetalle.TopLevel = false;
            PanelFormularios.Controls.Add(carteraDetalle);
            PanelFormularios.Tag = carteraDetalle;
            carteraDetalle.Dock = DockStyle.Fill;
            carteraDetalle.BringToFront();
            carteraDetalle.Show();
        }
        private void BtnBuscarContri_Click_1(object sender, EventArgs e){
            PintarBoton(BtnBuscarContri);
            AbrirFormulariosHijos(new FrmGesDeuda());
        }
        private void BtnIngresosxGestor_Click_1(object sender, EventArgs e){
            PintarBoton(BtnIngresosxGestor);
            AbrirFormulariosHijos(new FrmIngresoxGestor());
        }
        FrmAsignarMasivo AsignarMasivo = new FrmAsignarMasivo();
        private void BtnAsignarMasivo_Click_1(object sender, EventArgs e){
            if (Variables.tipo_usuario == "JEFE") {
                PintarBoton(BtnAsignarMasivo);
                // AbrirFormulariosHijos(new FrmAsignarMasivo());            
                if (FormActivo != verCartera && !PanelFormularios.Controls.Contains(AsignarMasivo)) {
                    AbrirFormulariosHijos(AsignarMasivo);
                    AsignarMasivo.TopLevel = false;
                    AsignarMasivo.Dock = DockStyle.Fill;
                } else {
                    AsignarMasivo.BringToFront();
                }
            } else {
                MessageBox.Show("No tiene acceso al módulo");
            }
        }
        private void FrmCartera_FormClosing(object sender, FormClosingEventArgs e){
            Application.Exit();
        }
        private void BtnActualizarGestion_Click(object sender, EventArgs e){
            AbrirFormulariosHijos(new FrmCarteraGestionDetalle());
        }

        private void BtnMantenimiento_Click(object sender, EventArgs e){
            PintarBoton(BtnMantenimiento);
            AbrirFormulariosHijos(new FrmMantenimiento());
        }
        private void BtnReporte_Click(object sender, EventArgs e){
            PintarBoton(BtnReporte);
            AbrirFormulariosHijos(new FrmReporteCartera());
        }
        FrmListadoCargos ListadoCargos = new FrmListadoCargos();
        private void BtnListaNotificaciones_Click(object sender, EventArgs e){
            PintarBoton(BtnListaNotificaciones);
            if (FormActivo != ListadoCargos && !PanelFormularios.Controls.Contains(ListadoCargos)){                
                AbrirFormulariosHijos(ListadoCargos);
                ListadoCargos.Visible = true;
                ListadoCargos.TopLevel = false;
                ListadoCargos.Dock = DockStyle.Fill;
                ListadoCargos.LlamarCargoNotificacionesNuevo += MostrarCargoNotificacionesNuevo;
                ListadoCargos.LlamarCargoNotificacionesActualizar += MostrarCargoNotificacionesActualizar;
                ListadoCargos.LlamarReporte += MostrarReporte;
            }
            else{
                ListadoCargos.Visible = true;
                ListadoCargos.BringToFront();
            }
        }
        private void MostrarCargoNotificacionesNuevo(object sender, EventArgs e){
            frmCargoNotificaciones.OpcionFormulario = "Nuevo";
            frmCargoNotificaciones CargoNotificaciones = new frmCargoNotificaciones();
            CargoNotificaciones.TopLevel = false;
            CargoNotificaciones.Dock = DockStyle.Fill;
            PanelFormularios.Controls.Add(CargoNotificaciones);
            PanelFormularios.Tag = CargoNotificaciones;
            CargoNotificaciones.BringToFront();
            CargoNotificaciones.Show();
        }
        private void MostrarCargoNotificacionesActualizar(object sender, EventArgs e){
            frmCargoNotificaciones.OpcionFormulario = "Actualizar";
            frmCargoNotificaciones CargoNotificaciones = new frmCargoNotificaciones();
            CargoNotificaciones.TopLevel = false;
            CargoNotificaciones.Dock = DockStyle.Fill;
            PanelFormularios.Controls.Add(CargoNotificaciones);
            PanelFormularios.Tag = CargoNotificaciones;
            CargoNotificaciones.BringToFront();
            CargoNotificaciones.BtnGrabar.Text = "ACTUALIZAR";
            CargoNotificaciones.Show();
        }
        private void MostrarReporte(object sender, EventArgs e){
            //frmCargoNotificaciones.OpcionFormulario = "Actualizar";                    
            FrmReporteCargos reporteCargos = new FrmReporteCargos();
            reporteCargos.TopLevel = false;
            //reporteCargos.Dock = DockStyle.Fill;
            PanelFormularios.Controls.Add(reporteCargos);
            PanelFormularios.Tag = reporteCargos;
            reporteCargos.BringToFront();
            //CargoNotificaciones.BtnGrabar.Text = "ACTUALIZAR";
            reporteCargos.Show();
        }
        private void FrmCartera_Shown(object sender, EventArgs e){
            Variables.height_panel = PanelFormularios.Height;
            Variables.withd_panel = PanelFormularios.Width;
        }

        private void BtnBandejaLegal_Click(object sender, EventArgs e){
            PintarBoton(BtnBandejaLegal);
            AbrirFormulariosHijos(new FrmBandeja());
        }
    }
}