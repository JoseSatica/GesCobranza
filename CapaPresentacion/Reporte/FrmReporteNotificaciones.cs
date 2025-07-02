using Microsoft.Reporting.WinForms;
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
    public partial class FrmReporteNotificaciones : Form
    {
        public FrmReporteNotificaciones()
        {
            InitializeComponent();
        }

        private void FrmReporteNotificaciones_Load(object sender, EventArgs e)
        {
            this.MinimumSize = this.MaximumSize = this.Size;
            // Crea un objeto ReportParameter con el nombre y valor del parámetro
            ReportParameter parametro = new ReportParameter("UsuarioReporte", Variables.cod_usuario);

            // Asigna el parámetro al visor del informe
            reportViewer1.LocalReport.SetParameters(parametro);

            this.reporteCargoNotificacionesTableAdapter.Fill(notificaciones.ReporteCargoNotificaciones,Variables.fechaini,Variables.fechafin);
            this.reportViewer1.RefreshReport();
        }
    }
}
