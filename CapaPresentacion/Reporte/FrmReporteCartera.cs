using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Reporte
{
    public partial class FrmReporteCartera : Form
    {
        public FrmReporteCartera()
        {
            InitializeComponent();
        }
        private DataTable tablaHtml;
        private DataTable tablaReporte;
        string borrarPath;
        private string Html;
        private async void FrmReporteCartera_Load(object sender, EventArgs e)
        {
            this.MinimumSize = this.MaximumSize = this.Size;
            // TODO: esta línea de código carga datos en la tabla 'dsReporteCartera.ReporteGestionCartera' Puede moverla o quitarla según sea necesario.
            //this.reporteGestionCarteraTableAdapter.Fill(this.dsReporteCartera.ReporteGestionCartera, Variables.codigo,Variables.deta_estado,Variables.deta_seguimiento,Variables.nombre_contri,Variables.ap_paterno,Variables.ap_materno,Variables.gestor,Variables.fechaini,Variables.fechafin);        
            //this.reportViewer1.RefreshReport();

            tablaHtml = NReporte.ObtenerPlantilla(34); // 39 34
            tablaReporte = NReporte.ReporteGestionCartera(Variables.codigo, Variables.deta_estado, Variables.deta_seguimiento, Variables.nombre_contri, Variables.ap_paterno, Variables.ap_materno, Variables.gestor, Variables.fechaini, Variables.fechafin);
            if (tablaHtml.Rows.Count <= 0)
            {
                MessageBox.Show("No se cargo la plantilla","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            if (tablaReporte.Rows.Count <= 0)
            {
                MessageBox.Show("Hubo problemas con el reporte", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Html = tablaHtml.Rows[0][0].ToString();

            StringBuilder filasHtml = new StringBuilder();
            foreach (DataRow row in tablaReporte.Rows)
            {
                filasHtml.AppendLine("<tr>");
                filasHtml.AppendLine($"<td>{row["Gestor"]}</td>");
                filasHtml.AppendLine($"<td>{row["Tipo"]}</td>");
                filasHtml.AppendLine($"<td>{row["Codigo"]}</td>");
                filasHtml.AppendLine($"<td>{row["Contribuyente"]}</td>");
                filasHtml.AppendLine($"<td>{row["Direccion"]}</td>");
                filasHtml.AppendLine($"<td>{row["Monto"]}</td>");
                filasHtml.AppendLine($"<td>{row["Seguimiento"]}</td>");
                filasHtml.AppendLine($"<td>{row["Fecha"]}</td>");
                filasHtml.AppendLine($"<td>{row["Estado"]}</td>");
                //filasHtml.AppendLine($"<td>{row["Direccion"]}</td>");
                filasHtml.AppendLine("</tr>");
            }

            string htmlFinal = Html
                .Replace("@insertar", filasHtml.ToString())
                //.Replace("TOTAL_PAGINAS", totalPaginas.ToString())
                .Replace("NOMBRE_AQUI", Variables.usuario)
                .Replace("AREA_AQUI", Variables.area_usuario);
            // Guardar el HTML en un archivo temporal
            string htmlFilePath = borrarPath = Path.Combine(Path.GetTempPath(), "tabla_dinamica.html");
            File.WriteAllText(htmlFilePath, htmlFinal, Encoding.UTF8);

            // Asegura que el entorno de WebView2 esté inicializado
            await webView21.EnsureCoreWebView2Async(null);
            // Carga un archivo HTML o una URL
            webView21.Source = new Uri(htmlFilePath);
            
        }

        private async void webView21_NavigationCompleted(object sender, Microsoft.Web.WebView2.Core.CoreWebView2NavigationCompletedEventArgs e)
        {
            await webView21.ExecuteScriptAsync("window.print();");
        }

        private void FrmReporteCartera_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!string.IsNullOrEmpty(borrarPath))
            File.Delete(borrarPath);
        }
    }
}
