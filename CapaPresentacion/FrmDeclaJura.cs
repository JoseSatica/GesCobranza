using CapaNegocio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CapaPresentacion
{
    public partial class FrmDeclaJura : Form
    {
        public string codigo;
        public string nombre;
        public string documento;
        public string direccion;
        private DataTable tablachkl;
        private string cod_pred, anexo1, direcc;
        private string min, max;

        private string annomin, annomax;

        private string vehiculo, fraccionamiento;
        private DataTable TblCalcular ;
        public decimal totalmonto = 0;

        public FrmDeclaJura()
        {
            InitializeComponent();
        }



        private void FrmDeclaJura_Load(object sender, EventArgs e)
        {
            //this.MinimumSize = this.MaximumSize = this.Size;

            Lblcodigo.Text = Variables.codigo;
            LblContriNom.Text = Variables.nombre_contri;
            LblContriDoc.Text = Variables.dni;
            LblContriDirecc.Text = direccion;
            codigo = Variables.codigo;            

            //----------------------- CARGAR LOS CHECLISTBOX --------------------------------------
            #region
            try
            {
                tablachkl = NGestion.CargarPrediosChkl(codigo);
                for (int i = 0; i < tablachkl.Rows.Count; i++)
                {
                    //cod = Convert.ToString(tablachkl.Rows[i][1]);
                    cod_pred = Convert.ToString(tablachkl.Rows[i][2]);
                    anexo1 = Convert.ToString(tablachkl.Rows[i][3]);
                    direcc = Convert.ToString(tablachkl.Rows[i][4]);
                    ChklPredio.Items.Add(cod_pred + "-" + anexo1 + "-" + direcc);

                }
                tablachkl.Clear();

                tablachkl = NGestion.CargarPeriodosChkl(codigo);
                min = Convert.ToString(tablachkl.Rows[0][0]);
                max = Convert.ToString(tablachkl.Rows[0][1]);
                for (int i = Convert.ToInt32(min); i <= Convert.ToInt32(max); i++)
                {
                    if (i <= 9)
                    {
                        ChklPeriodo.Items.Add("0" + i);
                    }
                    else
                    {
                        ChklPeriodo.Items.Add(i);
                    }
                }
                tablachkl.Clear();

                tablachkl = NGestion.CargarAnnosChkl(codigo);
                annomin = Convert.ToString(tablachkl.Rows[0][0]);
                annomax = Convert.ToString(tablachkl.Rows[0][1]);
                for (int i = Convert.ToInt32(annomax); i >= Convert.ToInt32(annomin); --i)
                {
                    ChklAño.Items.Add(i);
                }
                tablachkl.Clear();

                tablachkl = NGestion.CargarVehiculoChkl(codigo);
                for (int i = 0; i < tablachkl.Rows.Count; i++)
                {
                    vehiculo = Convert.ToString(tablachkl.Rows[i][0]);
                    ChklVehiculo.Items.Add(vehiculo);
                }
                tablachkl.Clear();

                tablachkl = NGestion.CargarFraccChkl(codigo);
                for (int i = 0; i < tablachkl.Rows.Count; i++)
                {
                    fraccionamiento = Convert.ToString(tablachkl.Rows[i][0]);
                    ChklVehiculo.Items.Add(fraccionamiento);
                }
                tablachkl.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se produjo el siguiente error \n" + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            #endregion

        }



        //--------------------------- VALIDACION DE LOS CHECKBOX "TODOS" --------------------------
        #region
        private void ChkPredioTodos_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkPredioTodos.Checked.Equals(true))
            {
                for (int i = 0; i < ChklPredio.Items.Count; i++)
                {
                    ChklPredio.SetItemChecked(i, true);
                }
            }
            else if (ChkPredioTodos.Checked.Equals(false))
            {
                for (int i = 0; i < ChklPredio.Items.Count; i++)
                {
                    ChklPredio.SetItemChecked(i, false);
                }
            }
        }
        private void ChkAnnoTodos_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkAnnoTodos.Checked.Equals(true))
            {
                for (int i = 0; i < ChklAño.Items.Count; i++)
                {
                    ChklAño.SetItemChecked(i, true);
                }
            }
            else
            {
                for (int i = 0; i < ChklAño.Items.Count; i++)
                {
                    ChklAño.SetItemChecked(i, false);
                }
            }
        }
        private void ChkPeriodoTodos_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkPeriodoTodos.Checked.Equals(true))
            {
                for (int i = 0; i < ChklPeriodo.Items.Count; i++)
                {
                    ChklPeriodo.SetItemChecked(i, true);
                }
            }
            else
            {
                for (int i = 0; i < ChklPeriodo.Items.Count; i++)
                {
                    ChklPeriodo.SetItemChecked(i, false);
                }
            }
        }
        private void ChkVehiculosTodos_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkVehiculosTodos.Checked.Equals(true))
            {
                for (int i = 0; i < ChklVehiculo.Items.Count; i++)
                {
                    ChklVehiculo.SetItemChecked(i, true);
                }
            }
            else
            {
                for (int i = 0; i < ChklVehiculo.Items.Count; i++)
                {
                    ChklVehiculo.SetItemChecked(i, false);
                }
            }
        }
        private void ListvCalcularDeuda_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            try
            {
                decimal montoTotal = 0;
              
                foreach (ListViewItem item in ListvCalcularDeuda.SelectedItems)
                {                
                    if (item.Text != "-")
                    {
                        ListViewItem.ListViewSubItem monto = item.SubItems[11];
                        montoTotal += Convert.ToDecimal(monto.Text);
                        txtMonto.Text = montoTotal.ToString();
                    }                    
                }                
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: \n" + ex);
            }
        }

        private void ChkFraccTodos_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkFraccTodos.Checked.Equals(true))
            {
                for (int i = 0; i < ChklFracc.Items.Count; i++)
                {
                    ChklFracc.SetItemCheckState(i, CheckState.Checked);
                }
            }
            else
            {
                for (int i = 0; i < ChklFracc.Items.Count; i++)
                {
                    ChklFracc.SetItemCheckState(i, CheckState.Unchecked);
                }
            }
        }
        #endregion



        //--------------------------- METODO CALCULAR DEUDA  ---------------------------------------------
        public void CalcularDeuda()
        {
            string tipo = "";
            string tiporec = "";
            string annio = "";
            string periodo = "";
            string predio = "";
            string cadena = "";
            try
            {
                foreach (var tiprec in ChklArbitrios.CheckedItems)
                {
                    if (tiprec.Equals("Limp. Publica"))
                    {
                        tiporec += "*11.01*,";
                    }

                    if (tiprec.Equals("Parq. Jard."))
                    {
                        tiporec += "*11.03*,";
                    }

                    if (tiprec.Equals("Serenazgo"))
                    {
                        tiporec += "*11.04*,";
                    }
                }

                foreach (var tipos in ChklConceptos.CheckedItems)
                {
                    if (tipos.Equals("Predial"))
                    {
                        tipo += "*02.01*,*00.16*,*30.02*,*30.03*,*30.04*,";
                    }

                    if (tipos.Equals("Arbitrios"))
                    {
                        tipo += "*11.00*,";
                    }

                    if (tipos.Equals("Alcabala"))
                    {
                        tipo += "*00.38*,";
                        tiporec += "*00.38*,*31.00*,";
                    }

                    if (tipos.Equals("Imp. Vehicular"))
                    {
                        tipo += "*00.30 *,*25.10*,";
                        tiporec += "*00.30 *,*25.10*,*31.01*,";
                    }
                }
                if (tipo != "")
                {
                    tipo = tipo.Remove(tipo.Length - 1, 1);
                }
                if (tiporec != "")
                {
                    tiporec = tiporec.Remove(tiporec.Length - 1, 1);
                }

                foreach (var pred in ChklPredio.CheckedItems)
                {
                    cadena = "*" + pred.ToString() + "*,";
                    cadena = cadena.Remove(10, (cadena.Length - 10));
                    predio += cadena + "*,";
                }
                if (predio != "")
                {
                    predio = predio.Remove(predio.Length - 1, 1);
                }

                foreach (var anio in ChklAño.CheckedItems)
                {
                    annio += "*" + anio.ToString() + "*,";
                }
                if (annio != "")
                {
                    annio = annio.Remove(annio.Length - 1, 1);
                }

                foreach (var perio in ChklPeriodo.CheckedItems)
                {
                    periodo += "*" + perio.ToString() + "*,";
                }
                if (periodo != "")
                {
                    periodo = periodo.Remove(periodo.Length - 1, 1);
                }


                TblCalcular = NGestion.CalcularDeuda(Lblcodigo.Text, annio, tipo, tiporec, periodo, predio, "0");

            }
            catch (Exception e)
            {
                MessageBox.Show("Se produjo el siguiente error: \n" + e, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        

        //------------------------ METODO CARGAR EL LISTVIEW ------------------------------------------------
        public void CargarListview(DataTable tabla)
        {

            int count = 0;
            List<DataRow> lista = tabla.AsEnumerable().ToList();

            var GrupoList = from fila in lista
                            group fila by fila.Field<string>("des_cabecera") into grupo
                            select grupo;

            foreach (var grupo in GrupoList)
            {
                ListViewGroup GrupoList1 = new ListViewGroup(grupo.Key + " ", HorizontalAlignment.Left);                
                ListvCalcularDeuda.Groups.Add(GrupoList1);

                decimal totalpago = 0;
                decimal totaldescuento = 0;
                decimal totaltodo = 0;
                

                foreach (var objetoagrupado in grupo)
                {

                    ListvCalcularDeuda.Items.Add(new ListViewItem(objetoagrupado.Field<string>("des_tipo"), GrupoList1));

                    ListvCalcularDeuda.Items[count].SubItems.Add(objetoagrupado.Field<string>("anno"));
                    ListvCalcularDeuda.Items[count].SubItems.Add(objetoagrupado.Field<string>("cod_pred"));
                    ListvCalcularDeuda.Items[count].SubItems.Add(objetoagrupado.Field<string>("anexo") + "-" + objetoagrupado.Field<string>("sub_anexo"));
                    ListvCalcularDeuda.Items[count].SubItems.Add(objetoagrupado.Field<string>("periodo"));
                    ListvCalcularDeuda.Items[count].SubItems.Add(Convert.ToString(objetoagrupado.Field<decimal>("imp_insol")));
                    ListvCalcularDeuda.Items[count].SubItems.Add(Convert.ToString(objetoagrupado.Field<decimal>("imp_reaj")));
                    ListvCalcularDeuda.Items[count].SubItems.Add(Convert.ToString(objetoagrupado.Field<decimal>("mora")));
                    ListvCalcularDeuda.Items[count].SubItems.Add(Convert.ToString(objetoagrupado.Field<decimal>("costo_emis")));
                    ListvCalcularDeuda.Items[count].SubItems.Add(Convert.ToString(decimal.Round(objetoagrupado.Field<decimal>("tot_pago"), 2)));
                    ListvCalcularDeuda.Items[count].SubItems.Add(Convert.ToString(decimal.Round(objetoagrupado.Field<decimal>("descuento"), 2)));
                    ListvCalcularDeuda.Items[count].SubItems.Add(Convert.ToString(decimal.Round((((objetoagrupado.Field<decimal>("imp_insol") * objetoagrupado.Field<decimal>("fact_reaj")) + objetoagrupado.Field<decimal>("costo_emis") + objetoagrupado.Field<decimal>("mora")) - objetoagrupado.Field<decimal>("descuento")), 2)));
                    count++;

                    totalpago += (decimal.Round(objetoagrupado.Field<decimal>("tot_pago"), 2));
                    totaldescuento += (decimal.Round(objetoagrupado.Field<decimal>("descuento"), 2));
                    totaltodo += (decimal.Round((((objetoagrupado.Field<decimal>("imp_insol") * objetoagrupado.Field<decimal>("fact_reaj")) + objetoagrupado.Field<decimal>("costo_emis") + objetoagrupado.Field<decimal>("mora")) - objetoagrupado.Field<decimal>("descuento")), 2));
                }
                ListvCalcularDeuda.Items.Add(new ListViewItem("-", GrupoList1));
                ListvCalcularDeuda.Items[count].SubItems.Add("");
                ListvCalcularDeuda.Items[count].SubItems.Add("");
                ListvCalcularDeuda.Items[count].SubItems.Add("");
                ListvCalcularDeuda.Items[count].SubItems.Add("");
                ListvCalcularDeuda.Items[count].SubItems.Add("");
                ListvCalcularDeuda.Items[count].SubItems.Add("");
                ListvCalcularDeuda.Items[count].SubItems.Add("");
                ListvCalcularDeuda.Items[count].SubItems.Add("TOTAL");

                ListvCalcularDeuda.Items[count].SubItems.Add(Convert.ToString(totalpago));
                ListvCalcularDeuda.Items[count].SubItems.Add(Convert.ToString(totaldescuento));
                ListvCalcularDeuda.Items[count].SubItems.Add(Convert.ToString(totaltodo)); //.SubItems.AddRange(subitem);
                totalmonto += totaltodo;
                count++;

            }
            count = 0;
        }

        private async void FrmDeclaJura_Shown(object sender, EventArgs e)
        {
            Task Tarea = new Task(CalcularDeuda);
            Tarea.Start();
            PtbLoad.Visible = true;
            await Tarea;
            CargarListview(TblCalcular);
            PtbLoad.Visible = false;
        }                     
        private async void BtnBuscar_Click(object sender, EventArgs e)
        {
            ListvCalcularDeuda.Items.Clear();
            Task Tarea = new Task(CalcularDeuda);
            Tarea.Start();
            PtbLoad.Visible = true;
            await Tarea;
            CargarListview(TblCalcular);
            PtbLoad.Visible = false;
            //CalcularDeuda();
        }
    }
}
