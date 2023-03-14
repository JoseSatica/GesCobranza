using CapaNegocio;
using System;
using System.Data;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void BtnAcceder_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable Tabla = new DataTable();
                Tabla = Nlogin.Login(TxtCodUsuario.Text.Trim(), TxtClave.Text.Trim());
                string mensaje = Tabla.Rows[0]["MENSAJE"].ToString();
                
                if (mensaje == "JEFE" || mensaje == "PERMISO")
                {
                    string nombre_usuario = Tabla.Rows[0]["nom_usuario"].ToString();
                    string area_usuario = Tabla.Rows[0]["nom_area"].ToString();
                    string id_usuario = Tabla.Rows[0]["id_usuario"].ToString();
                    string cod_usuario = Tabla.Rows[0]["usuario"].ToString();                 
                    Variables.tipo_usuario = mensaje;
                    Variables.nom_usuario = nombre_usuario;
                    Variables.area_usuario = area_usuario;
                    Variables.id_usuario = id_usuario;
                    Variables.cod_usuario = cod_usuario;
                    FrmCartera frm = new FrmCartera();
                    this.Hide();
                    frm.Show();
                }
                else
                {
                    MessageBox.Show("LA CLAVE O USUARIO NO SON VALIDOS", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
