namespace CapaPresentacion.Reporte
{
    partial class FrmReporteNotificaciones
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reporteCargoNotificacionesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.notificaciones = new CapaPresentacion.Reporte.Notificaciones();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reporteCargoNotificacionesTableAdapter = new CapaPresentacion.Reporte.NotificacionesTableAdapters.ReporteCargoNotificacionesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.reporteCargoNotificacionesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notificaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // reporteCargoNotificacionesBindingSource
            // 
            this.reporteCargoNotificacionesBindingSource.DataMember = "ReporteCargoNotificaciones";
            this.reporteCargoNotificacionesBindingSource.DataSource = this.notificaciones;
            // 
            // notificaciones
            // 
            this.notificaciones.DataSetName = "Notificaciones";
            this.notificaciones.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DsNotificaciones";
            reportDataSource1.Value = this.reporteCargoNotificacionesBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CapaPresentacion.Reporte.ReporteCargo.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1114, 740);
            this.reportViewer1.TabIndex = 0;
            // 
            // reporteCargoNotificacionesTableAdapter
            // 
            this.reporteCargoNotificacionesTableAdapter.ClearBeforeFill = true;
            // 
            // FrmReporteNotificaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 740);
            this.Controls.Add(this.reportViewer1);
            this.MaximizeBox = false;
            this.Name = "FrmReporteNotificaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmReporteNotificaciones";
            this.Load += new System.EventHandler(this.FrmReporteNotificaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reporteCargoNotificacionesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notificaciones)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource reporteCargoNotificacionesBindingSource;
        private Notificaciones notificaciones;
        private NotificacionesTableAdapters.ReporteCargoNotificacionesTableAdapter reporteCargoNotificacionesTableAdapter;
    }
}