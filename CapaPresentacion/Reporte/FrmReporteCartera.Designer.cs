namespace CapaPresentacion.Reporte
{
    partial class FrmReporteCartera
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
            this.reporteGestionCarteraBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dsReporteCartera = new CapaPresentacion.Reporte.DsReporteCartera();
            this.reporteGestionCarteraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reporteGestionCarteraTableAdapter = new CapaPresentacion.Reporte.DsReporteCarteraTableAdapters.ReporteGestionCarteraTableAdapter();
            this.webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            ((System.ComponentModel.ISupportInitialize)(this.reporteGestionCarteraBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsReporteCartera)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reporteGestionCarteraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).BeginInit();
            this.SuspendLayout();
            // 
            // reporteGestionCarteraBindingSource1
            // 
            this.reporteGestionCarteraBindingSource1.DataMember = "ReporteGestionCartera";
            this.reporteGestionCarteraBindingSource1.DataSource = this.dsReporteCartera;
            // 
            // dsReporteCartera
            // 
            this.dsReporteCartera.DataSetName = "DsReporteCartera";
            this.dsReporteCartera.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reporteGestionCarteraBindingSource
            // 
            this.reporteGestionCarteraBindingSource.DataMember = "ReporteGestionCartera";
            this.reporteGestionCarteraBindingSource.DataSource = this.dsReporteCartera;
            // 
            // reporteGestionCarteraTableAdapter
            // 
            this.reporteGestionCarteraTableAdapter.ClearBeforeFill = true;
            // 
            // webView21
            // 
            this.webView21.AllowExternalDrop = true;
            this.webView21.CreationProperties = null;
            this.webView21.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webView21.Location = new System.Drawing.Point(0, 0);
            this.webView21.Name = "webView21";
            this.webView21.Size = new System.Drawing.Size(1136, 728);
            this.webView21.TabIndex = 1;
            this.webView21.ZoomFactor = 1D;
            this.webView21.NavigationCompleted += new System.EventHandler<Microsoft.Web.WebView2.Core.CoreWebView2NavigationCompletedEventArgs>(this.webView21_NavigationCompleted);
            // 
            // FrmReporteCartera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1136, 728);
            this.Controls.Add(this.webView21);
            this.MaximizeBox = false;
            this.Name = "FrmReporteCartera";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte Cartera";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmReporteCartera_FormClosing);
            this.Load += new System.EventHandler(this.FrmReporteCartera_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reporteGestionCarteraBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsReporteCartera)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reporteGestionCarteraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource reporteGestionCarteraBindingSource;
        private DsReporteCartera dsReporteCartera;
        private DsReporteCarteraTableAdapters.ReporteGestionCarteraTableAdapter reporteGestionCarteraTableAdapter;
        private System.Windows.Forms.BindingSource reporteGestionCarteraBindingSource1;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
    }
}