namespace CapaPresentacion.Reporte
{
    partial class FrmReporte
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reporteGestionCarteraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsReporteCartera = new CapaPresentacion.Reporte.DsReporteCartera();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reporteGestionCarteraTableAdapter = new CapaPresentacion.Reporte.DsReporteCarteraTableAdapters.ReporteGestionCarteraTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.reporteGestionCarteraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsReporteCartera)).BeginInit();
            this.SuspendLayout();
            // 
            // reporteGestionCarteraBindingSource
            // 
            this.reporteGestionCarteraBindingSource.DataMember = "ReporteGestionCartera";
            this.reporteGestionCarteraBindingSource.DataSource = this.dsReporteCartera;
            // 
            // dsReporteCartera
            // 
            this.dsReporteCartera.DataSetName = "DsReporteCartera";
            this.dsReporteCartera.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DsReporteCartera";
            reportDataSource2.Value = this.reporteGestionCarteraBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CapaPresentacion.Reporte.Reporte.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1061, 589);
            this.reportViewer1.TabIndex = 0;
            // 
            // reporteGestionCarteraTableAdapter
            // 
            this.reporteGestionCarteraTableAdapter.ClearBeforeFill = true;
            // 
            // FrmReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 589);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FrmReporte";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "REPORTE";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmReporte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reporteGestionCarteraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsReporteCartera)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource reporteGestionCarteraBindingSource;
        private DsReporteCartera dsReporteCartera;
        private DsReporteCarteraTableAdapters.ReporteGestionCarteraTableAdapter reporteGestionCarteraTableAdapter;
    }
}