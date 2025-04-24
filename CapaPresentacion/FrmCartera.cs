using System;
using System.Windows.Forms;


namespace CapaPresentacion
{
    public partial class FrmCartera : Form
    {
        public FrmCartera()
        {
            InitializeComponent();
        }


        private void FrmCartera_Load(object sender, EventArgs e)
        {
            this.MinimumSize = this.MaximumSize = this.Size;
            LblUsuarioNom.Text = Variables.nom_usuario;
            LblArea.Text = Variables.area_usuario;
            resolucionAviso();
            verificarJefe();
        }
        private void verificarJefe()
        {
            if (Variables.tipo_usuario == "JEFE")
            {
                BtnAsignarMasivo.Enabled = true;
                BtnMantenimiento.Enabled = true;
                BtnIngresosxGestor.Enabled = true;
                BtnReporte.Enabled = true;
                BtnNotificaciones.Enabled = true;
                BtnCargoNotificaciones.Enabled = true;
                //btnProgramarGestion.Enabled = true;
            }
        }
        private void resolucionAviso()
        {
            int screenWidth = Screen.PrimaryScreen.Bounds.Width;
            int screenHeight = Screen.PrimaryScreen.Bounds.Height;
            if (screenWidth < 1600 && screenHeight < 900)
            {
                MessageBox.Show($"LA RESOLUCION DE SU PANTALLA({screenWidth}x{screenHeight}), PUEDE OCASIONAR PROBLEMAS A LA HORA DE USAR EL APLICATIVO.\nPOR FAVOR USE UNA RESOLUCION DE PANTALLA MINIMA DE 1600x900", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private Form FormActivo = null;
        private void AbrirFormulariosHijos(Form FormHijo)
        {
            if (FormActivo != null)

                //FormActivo.Close();
                FormActivo = FormHijo;
            FormHijo.TopLevel = false;
            FormHijo.FormBorderStyle = FormBorderStyle.None;
            FormHijo.Dock = DockStyle.Fill;
            PanelFormularios.Controls.Add(FormHijo);
            PanelFormularios.Tag = FormHijo;
            FormHijo.BringToFront();
            FormHijo.Show();


        }

        FrmVerCartera verCartera = new FrmVerCartera();
        private void BtnCartera_Click_1(object sender, EventArgs e)
        {
            
            AbrirFormulariosHijos(verCartera);
            verCartera.TopLevel = false;
            verCartera.Dock = DockStyle.Fill;

            verCartera.BotonBPresionado += FormA_BotonBPresionado;
            verCartera.LlamarDetalleDeuda += MostrarDetalleDeuda;
            verCartera.LlamarDetalleCartera += MostrarDetalleCartera;

        }
        private void FormA_BotonBPresionado(object sender, EventArgs e)
        {
            FrmCarteraGestionDetalle formB = new FrmCarteraGestionDetalle();
            formB.TopLevel = false;
            PanelFormularios.Controls.Add(formB);
            PanelFormularios.Tag = formB;
            formB.Dock = DockStyle.Fill;
            formB.BringToFront();
            formB.Show();
        }
        private void MostrarDetalleDeuda(object sender, EventArgs e)
        {
            FrmDeclaJura frmDetalleDeuda = new FrmDeclaJura();
            frmDetalleDeuda.TopLevel = false;
            frmDetalleDeuda.Dock = DockStyle.Fill;
            PanelFormularios.Controls.Add(frmDetalleDeuda);
            PanelFormularios.Tag = frmDetalleDeuda;
            frmDetalleDeuda.BringToFront();
            frmDetalleDeuda.Show();
        }

        private void MostrarDetalleCartera(object sender, EventArgs e)
        {
            FrmCarteraDetalle carteraDetalle = new FrmCarteraDetalle();
            carteraDetalle.TopLevel = false;
            PanelFormularios.Controls.Add(carteraDetalle);
            PanelFormularios.Tag = carteraDetalle;
            carteraDetalle.Dock = DockStyle.Fill;
            carteraDetalle.BringToFront();
            carteraDetalle.Show();
        }

        private void BtnBuscarContri_Click_1(object sender, EventArgs e)
        {
            AbrirFormulariosHijos(new FrmGesDeuda());
        }

        private void BtnIngresosxGestor_Click_1(object sender, EventArgs e)
        {
            AbrirFormulariosHijos(new FrmIngresoxGestor());
        }

        private void BtnAsignarMasivo_Click_1(object sender, EventArgs e)
        {
            AbrirFormulariosHijos(new FrmAsignarMasivo());
        }

        private void FrmCartera_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void BtnActualizarGestion_Click(object sender, EventArgs e)
        {
            AbrirFormulariosHijos(new FrmCarteraGestionDetalle());
        }

        private void BtnMantenimiento_Click(object sender, EventArgs e)
        {
            AbrirFormulariosHijos(new FrmMantenimiento());
        }

        private void BtnReporte_Click(object sender, EventArgs e)
        {
            AbrirFormulariosHijos(new FrmReporteCartera());
        }

        private void BtnNotificaciones_Click(object sender, EventArgs e)
        {
            AbrirFormulariosHijos(new FrmNotificacion());

        }

        private void BtnCargoNotificaciones_Click(object sender, EventArgs e)
        {
            AbrirFormulariosHijos(new frmCargoNotificaciones());

        }
    }
}