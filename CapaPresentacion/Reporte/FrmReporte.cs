using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Reporte
{
    public partial class FrmReporte : Form
    {
        public FrmReporte()
        {
            InitializeComponent();
        }

        private void FrmReporte_Load(object sender, EventArgs e)
        {
            this.MinimumSize = this.MaximumSize = this.Size;
            this.reporteGestionCarteraTableAdapter.Fill(dsReporteCartera.ReporteGestionCartera, Variables.codigo, Variables.deta_estado, Variables.deta_seguimiento, Variables.nombre_contri, Variables.ap_paterno, Variables.ap_materno, Variables.gestor, Variables.fechaini, Variables.fechafin);            
            this.reportViewer1.RefreshReport();

        }
    }
}
