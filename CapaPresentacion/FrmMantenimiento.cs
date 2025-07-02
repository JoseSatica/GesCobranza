using CapaNegocio;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace CapaPresentacion{
    public partial class FrmMantenimiento : Form{
        public FrmMantenimiento(){
            InitializeComponent();
        }
        DataTable usuarios;
        string id_usuario;
        private void FrmMantenimiento_Load(object sender, EventArgs e){
            CargarDgvGestores();

        }
        private void CargarDgvGestores(){
            DgvGestores.DataSource = null;
            DgvGestores.DataSource = NVerCartera.CargarDGVGestores();
            DgvGestores.Refresh();
            CargarComboUsuario();
        }
        private void CargarComboUsuario(){
            usuarios = NMantenimiento.CargarUsuariosCobranzas();
            if (usuarios.Rows.Count > 0){
                CbxUsuarios.DataSource = null;
                CbxUsuarios.BindingContext = new BindingContext();
                CbxUsuarios.BeginUpdate();
                CbxUsuarios.SuspendLayout();
                CbxUsuarios.Items.Clear();
                CbxUsuarios.ResumeLayout();
                CbxUsuarios.EndUpdate();
                CbxUsuarios.Refresh();
                CbxUsuarios.DataSource = usuarios;
                CbxUsuarios.DisplayMember = "gestor";
                CbxUsuarios.ValueMember = "gestor";
            }
            else{
                CbxUsuarios.DataSource = null;
                CbxUsuarios.BindingContext = new BindingContext();
                CbxUsuarios.BeginUpdate();
                CbxUsuarios.SuspendLayout();
                CbxUsuarios.Items.Clear();
                CbxUsuarios.ResumeLayout();
                CbxUsuarios.EndUpdate();
                CbxUsuarios.Refresh();
            }          
        }
        private void BtnAgregar_Click(object sender, EventArgs e){
            try{
                if (CbxUsuarios.Text != ""){
                    if (DgvGestores.SelectedRows.Count > 0){
                        id_usuario = CbxUsuarios.SelectedValue.ToString();
                        NMantenimiento.AgregarTablaGestor(id_usuario);
                        CargarDgvGestores();
                        CargarComboUsuario();
                        MessageBox.Show("SE AGREGO CORRECTAMENTE EL USUARIO COMO GESTOR", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);                        
                    }
                }
                else{
                    MessageBox.Show("DEBE ELEGIR UN GESTOR", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            catch (Exception ex){
                MessageBox.Show($"SE PRODUJO EL SIGUIENTE ERROR: \n{ex}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
        private void FrmMantenimiento_Shown(object sender, EventArgs e){
            CargarComboUsuario();
            //ocultarColumnas();
            //pintarFilas();
        }
        private void ocultarColumnas(){
            foreach (DataGridViewColumn item in DgvGestores.Columns){
                if (item.HeaderText == "id_gestor" || item.HeaderText == "permiso"){
                    item.Visible = false;
                }
            }
        }
        private void pintarFilas(){
            foreach (DataGridViewRow fila in DgvGestores.Rows){
                if (fila.Cells["permiso"].Value.ToString().Trim() == "0"){
                    fila.DefaultCellStyle.ForeColor = Color.Crimson;
                    fila.DefaultCellStyle.SelectionBackColor = Color.Crimson;
                }
                if (fila.Cells["permiso"].Value.ToString().Trim() == "1"){
                    fila.DefaultCellStyle.ForeColor = Color.Black;
                    fila.DefaultCellStyle.SelectionBackColor = Color.DodgerBlue;
                }
            }
        }
        private void BtnDarPermiso_Click(object sender, EventArgs e){
            try{
                int id_gestor = Convert.ToInt32(DgvGestores.CurrentRow.Cells["id_gestor"].Value.ToString().Trim());
                NMantenimiento.DarQuitarPermiso("1", id_gestor);
                MessageBox.Show($"SE DIO PERMISO", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex){
                MessageBox.Show($"SE PRODUJO EL SIGUIENTE ERROR: \n {ex}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            CargarDgvGestores();
            //ocultarColumnas();
            //pintarFilas();
        }
        private void BtnQuitarPermiso_Click(object sender, EventArgs e){
            try{
                int id_gestor = Convert.ToInt32(DgvGestores.CurrentRow.Cells["id_gestor"].Value.ToString().Trim());
                NMantenimiento.DarQuitarPermiso("0", id_gestor);
                MessageBox.Show($"SE QUITO PERMISO", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex){
                MessageBox.Show($"SE PRODUJO EL SIGUIENTE ERROR: \n {ex}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            CargarDgvGestores();
            //ocultarColumnas();
            //pintarFilas();
        }
        private void DgvGestores_Sorted(object sender, EventArgs e){
            //ocultarColumnas();
            //pintarFilas();
        }
        private void BtnEliminar_Click(object sender, EventArgs e){
            try{
                if (DgvGestores.SelectedRows.Count > 0){
                    string id_usuario_dgv = DgvGestores.CurrentRow.Cells["gestor"].Value.ToString();
                    NMantenimiento.EliminarTablaGestor(id_usuario_dgv);
                    CargarDgvGestores();
                    CargarComboUsuario();
                    MessageBox.Show("SE ELIMINO CORRECTAMENTE EL USUARIO COMO GESTOR", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);                    
                }
                else{
                    MessageBox.Show("DEBE SELECCIONAR UN GESTOR", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            catch (Exception ex){
                MessageBox.Show($"SE PRODUJO EL SIGUIENTE ERROR: \n{ex}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
        private void CbxUsuarios_SelectedValueChanged_1(object sender, EventArgs e){
        }
    }
}