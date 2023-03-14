using CapaNegocio;
using System;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CapaPresentacion
{
    public partial class FrmGesDeuda : Form
    {
        public int IdUsuario;
        public string Cod_Usuario;
        public string Nombre_Usuario;
        public string Dni_Usuario;
        public string Area;
        public string Tipo_Usuario;
        public string Clave;


        public int InicioPag = 1;

        public FrmGesDeuda()
        {
            InitializeComponent();
        }

        private void FrmGesDeuda_Load(object sender, EventArgs e)
        {

            CheckForIllegalCrossThreadCalls = false;
            TxtCodContri.Focus();
            RbCodigo.Focus();

        }
        

        private void BuscarContriCod()
        {
            //DgvGestion.DataSource = NGestion.BuscarContriCodi(TxtCodContri.Text.Trim());
        }

        private void BuscarContriDoc()
        {
          //  DgvGestion.DataSource = NGestion.BuscarContriDoc(TxtDniContri.Text.Trim());
        }

        ///////////////////                  VARIABLE           ////////////////////////////////////////

        public string cadena;
        public DataTable tabla;
        public DataTable tabcontar;
        public string Cantidad;
        public decimal TotalPaginas;
        public int Inicio = 1;
        public int Final = 20;


        ///////////////////////////            BOTON BUSCAR                ////////////////////////////////////

        private async void BtnBuscarContribuyente_Click(object sender, EventArgs e)
        {
            if (RbCodigo.Checked.Equals(true))
            {
                BuscarContriCod();
                lblNroPag.Visible = false;
                lblTotalPag.Visible = false;
                lblde.Visible = false;
                BtnAtras.Visible = false;
                BtnSiguiente.Visible = false;
            }

            if (RbNombre.Checked.Equals(true))
            {

                lblNroPag.Text = "1";
                BtnAtras.Enabled = false;
                InicioPag = 1;
                Inicio = 1;
                Final = 20;

                try
                {
                    Task<DataTable> Tarea = new Task<DataTable>(BuscarNomAsin);
                    Tarea.Start();
                    DgvGestion.DataSource = await Tarea;

                    Task tarea2 = new Task(ContadorNom);
                    tarea2.Start();
                    await tarea2;
                    Paginacion();
                    MessageBox.Show("LISTO!", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Se produjo el siguiente error:\n" + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (RbDocu.Checked.Equals(true))
            {
                lblNroPag.Visible = false;
                lblTotalPag.Visible = false;
                lblde.Visible = false;
                BtnAtras.Visible = false;
                BtnSiguiente.Visible = false;
                BuscarContriDoc();
            }

            if (RbDirecc.Checked.Equals(true))
            {
                lblNroPag.Text = "1";
                BtnAtras.Enabled = false;
                InicioPag = 1;
                Inicio = 1;
                Final = 20;

                try
                {
                    Task<DataTable> Tarea = new Task<DataTable>(BuscarDirrAsin);
                    Tarea.Start();
                    DgvGestion.DataSource = await Tarea;

                    Task tarea2 = new Task(ContadorDirr);
                    tarea2.Start();
                    await tarea2;
                    Paginacion();
                    MessageBox.Show("LISTO!", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Se produjo el siguiente error:\n" + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            BtnMostrar.Enabled = true;
        }

        //-------------- METODOS PARA USAR CON "TASK" -------------
        private DataTable BuscarNomAsin()
        {
            try
            {
               // tabla = NGestion.BuscarContriNom(Inicio, Final, TxtNombre.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se produjo un error: " + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tabla;
        }
        private void ContadorNom()
        {
           // tabcontar = NGestion.ContriNomCount(TxtApellidoPaterno.Text);
        }

        private DataTable BuscarDirrAsin()
        {
            try
            {
               // tabla = NGestion.BuscarContriDirecc(Inicio, Final, TxtCodPredio.Text.Trim(), CboAnio.Text.Trim(), TxtNomVia.Text.Trim(), TxtNomUrb.Text.Trim(), TxtNum.Text.Trim(), TxtDpto.Text.Trim(), TxtMza.Text.Trim(), TxtLote.Text.Trim(), TxtSubLote.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se produjo un error: " + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return tabla;
        }
        private void ContadorDirr()
        {
           // tabcontar = NGestion.BuscarContriDireccCount(TxtCodPredio.Text.Trim(), CboAnio.Text.Trim(), TxtNomVia.Text.Trim(), TxtNomUrb.Text.Trim(), TxtNum.Text.Trim(), TxtDpto.Text.Trim(), TxtMza.Text.Trim(), TxtLote.Text.Trim(), TxtSubLote.Text.Trim());
        }
        private void Paginacion()
        {
            BtnBuscarContribuyente.Enabled = true;
            lblNroPag.Visible = true;
            lblTotalPag.Visible = true;
            lblde.Visible = true;
            BtnAtras.Visible = true;
            BtnSiguiente.Visible = true;

            if (lblNroPag.Text == lblTotalPag.Text)
            {
                BtnSiguiente.Enabled = false;
            }
            else
            {
                BtnSiguiente.Enabled = true;
            }

            if (lblNroPag.Text == "1")
            {
                BtnAtras.Enabled = false;
            }
            else
            {
                BtnAtras.Enabled = true;
            }

            //----
            Cantidad = tabcontar.Rows[0][0].ToString();
            TotalPaginas = Convert.ToDecimal(Cantidad) / 20;
            lblTotalPag.Text = Convert.ToString(Math.Ceiling(TotalPaginas));
        }
        //-----------------------------------------------------------

        //////////////////////////         VALIDAR CAMBIO DE RADIOBUTTOM        ////////////////////////////////////
        #region
        private void RbDocu_CheckedChanged(object sender, EventArgs e)
        {
            if (RbDocu.Checked.Equals(true))
            {
                lblNroPag.Visible = false;
                lblTotalPag.Visible = false;
                lblde.Visible = false;
                BtnAtras.Visible = false;
                BtnSiguiente.Visible = false;
                TxtDniContri.Focus();
                TxtDniContri.Visible = true;
                LblDoc.Visible = true;
            }
            else
            {
                TxtDniContri.Visible = false;
                TxtDniContri.Text = "";
                LblDoc.Visible = false;
                DgvGestion.DataSource = null;
                DgvGestion.Rows.Clear();
                DgvGestion.Refresh();

            }
        }

        private void RbCodigo_CheckedChanged(object sender, EventArgs e)
        {
            if (RbCodigo.Checked.Equals(true))
            {
                lblNroPag.Visible = false;
                lblTotalPag.Visible = false;
                lblde.Visible = false;
                BtnAtras.Visible = false;
                BtnSiguiente.Visible = false;
                TxtCodContri.Focus();
                TxtCodContri.Visible = true;
                LblCodigo.Visible = true;
            }
            else
            {
                TxtCodContri.Visible = false;
                TxtCodContri.Text = "";
                LblCodigo.Visible = false;
                DgvGestion.DataSource = null;
                DgvGestion.Rows.Clear();
                DgvGestion.Refresh();
            }
        }

        private void RbNombre_CheckedChanged(object sender, EventArgs e)
        {
            if (RbNombre.Checked.Equals(true))
            {
                lblNroPag.Visible = false;
                lblTotalPag.Visible = false;
                lblde.Visible = false;
                BtnAtras.Visible = false;
                BtnSiguiente.Visible = false;

                TxtNombre.Focus();
                TxtNombre.Visible = true;
                LblNom.Visible = true;
                TxtApellidoPaterno.Visible = true;
                TxtApellidoMaterno.Visible = true;
                LblPaterno.Visible = true;
                LblMaterno.Visible = true;
            }
            else
            {
                lblNroPag.Visible = false;
                lblTotalPag.Visible = false;
                lblde.Visible = false;
                BtnAtras.Visible = false;
                BtnSiguiente.Visible = false;

                TxtNombre.Focus();
                TxtNombre.Visible = false;
                LblNom.Visible = false;
                TxtApellidoPaterno.Visible = false;
                TxtApellidoMaterno.Visible = false;
                LblPaterno.Visible = false;
                LblMaterno.Visible = false;
                DgvGestion.DataSource = null;
                DgvGestion.Rows.Clear();
                DgvGestion.Refresh();

            }
        }

        private void RbDirecc_CheckedChanged(object sender, EventArgs e)
        {
            if (RbDirecc.Checked.Equals(true))
            {
                TxtCodPredio.Focus();
                TxtCodPredio.Visible = true;
                CboAnio.Visible = true;
                TxtNomVia.Visible = true;
                TxtNomUrb.Visible = true;
                TxtNum.Visible = true;
                TxtDpto.Visible = true;
                TxtMza.Visible = true;
                TxtLote.Visible = true;
                TxtSubLote.Visible = true;
                LblCodPred.Visible = true;
                LblAnio.Visible = true;
                LblNomVia.Visible = true;
                LblNomUrb.Visible = true;
                LblNum.Visible = true;
                LblDpto.Visible = true;
                LblMza.Visible = true;
                LblLote.Visible = true;
                LblSubLote.Visible = true;

                lblNroPag.Visible = false;
                lblTotalPag.Visible = false;
                lblde.Visible = false;
                BtnAtras.Visible = false;
                BtnSiguiente.Visible = false;


            }
            else
            {
                TxtCodPredio.Text = "";
                TxtCodPredio.Visible = false;
                CboAnio.Visible = false;
                TxtNomVia.Visible = false;
                TxtNomUrb.Visible = false;
                TxtNum.Visible = false;
                TxtDpto.Visible = false;
                TxtMza.Visible = false;
                TxtLote.Visible = false;
                TxtSubLote.Visible = false;
                LblCodPred.Visible = false;
                LblAnio.Visible = false;
                LblNomVia.Visible = false;
                LblNomUrb.Visible = false;
                LblNum.Visible = false;
                LblDpto.Visible = false;
                LblMza.Visible = false;
                LblLote.Visible = false;
                LblSubLote.Visible = false;
                DgvGestion.DataSource = null;
                DgvGestion.Rows.Clear();
                DgvGestion.Refresh();
            }
        }
        #endregion

        ////////////////////                   BOTON SIGUIENTE            ///////////////////////////////////////////////////////
        private async void BtnSiguiente_Click(object sender, EventArgs e)
        {
            Final += 20;
            Inicio += 20;
            try
            {
                InicioPag += 1;
                lblNroPag.Text = Convert.ToString(InicioPag);

                if (RbNombre.Checked.Equals(true))
                {
                    try
                    {
                        Task<DataTable> Tarea = new Task<DataTable>(BuscarNomAsin);
                        Tarea.Start();
                        DgvGestion.DataSource = await Tarea;

                        Task tarea2 = new Task(ContadorNom);
                        tarea2.Start();
                        await tarea2;
                        Paginacion();
                        //MessageBox.Show("LISTO!", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Se produjo el siguiente error:\n" + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                if (RbDirecc.Checked.Equals(true))
                {
                    try
                    {
                        Task<DataTable> Tarea = new Task<DataTable>(BuscarDirrAsin);
                        Tarea.Start();
                        DgvGestion.DataSource = await Tarea;

                        Task tarea2 = new Task(ContadorDirr);
                        tarea2.Start();
                        await tarea2;
                        Paginacion();
                        //MessageBox.Show("LISTO!", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //InicioPag += 1;
                        //lblNroPag.Text = Convert.ToString(InicioPag);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Se produjo el siguiente error:\n" + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se produjo un error: " + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /////////////////////                  BOTON ATRAS            ///////////////////////////////////////////////////////
        private async void BtnAtras_Click(object sender, EventArgs e)
        {
            Final -= 20;
            Inicio -= 20;
            try
            {
                InicioPag -= 1;
                lblNroPag.Text = Convert.ToString(InicioPag);

                if (RbDirecc.Checked.Equals(true))
                {
                    try
                    {
                        Task<DataTable> Tarea = new Task<DataTable>(BuscarDirrAsin);
                        Tarea.Start();
                        DgvGestion.DataSource = await Tarea;

                        Task tarea2 = new Task(ContadorDirr);
                        tarea2.Start();
                        await tarea2;
                        Paginacion();
                        //MessageBox.Show("LISTO!", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Se produjo el siguiente error:\n" + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                if (RbNombre.Checked.Equals(true))
                {
                    try
                    {
                        Task<DataTable> Tarea = new Task<DataTable>(BuscarNomAsin);
                        Tarea.Start();
                        DgvGestion.DataSource = await Tarea;

                        Task tarea2 = new Task(ContadorNom);
                        tarea2.Start();
                        await tarea2;
                        Paginacion();
                        //MessageBox.Show("LISTO!", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //InicioPag -= 1;
                        //lblNroPag.Text = Convert.ToString(InicioPag);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Se produjo el siguiente error:\n" + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se produjo un error: " + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        ////////////////////////////           BOTON MOSTRAR            ///////////////////////////////////////////////////////

        private void BtnMostrar_Click(object sender, EventArgs e)
        {

            //if (RbCodigo.Checked || RbDocu.Checked || RbNombre.Checked)
            //{
            //    Variables.Codigo = Convert.ToString(DgvGestion.CurrentRow.Cells["Codigo"].Value);
            //    Variables.NomContri = Convert.ToString(DgvGestion.CurrentRow.Cells["Nombre"].Value);
            //    Variables.DniContri = Convert.ToString(DgvGestion.CurrentRow.Cells["Documento"].Value);
            //    Variables.DirecConti = Convert.ToString(DgvGestion.CurrentRow.Cells["dirfiscal"].Value);
            //}
            //else
            //{
            //    Variables.Codigo = Convert.ToString(DgvGestion.CurrentRow.Cells["Codigo"].Value);
            //    Variables.NomContri = Convert.ToString(DgvGestion.CurrentRow.Cells["Nombre"].Value);
            //    //frm.documento = Convert.ToString(DgvGestion.CurrentRow.Cells["Documento"].Value);
            //    Variables.DirecConti = Convert.ToString(DgvGestion.CurrentRow.Cells["dirfiscal"].Value);
            //}
            //FrmDeclaJura frm = new FrmDeclaJura();
            //frm.Show();
           

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void FrmGesDeuda_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
    }



}
