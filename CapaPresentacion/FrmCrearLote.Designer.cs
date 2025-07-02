namespace CapaPresentacion
{
    partial class FrmCrearLote
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TxtAnno = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtNro = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvLote = new System.Windows.Forms.DataGridView();
            this.BtnBuscar = new FontAwesome.Sharp.IconButton();
            this.BtnCrearLote = new System.Windows.Forms.Button();
            this.TxtDocumento = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label1 = new System.Windows.Forms.Label();
            this.OpFileBuscarArchivo = new System.Windows.Forms.OpenFileDialog();
            this.EpValidar = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLote)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EpValidar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(132)))), ((int)(((byte)(174)))));
            this.panel1.Controls.Add(this.TxtAnno);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.TxtNro);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dgvLote);
            this.panel1.Controls.Add(this.BtnBuscar);
            this.panel1.Controls.Add(this.BtnCrearLote);
            this.panel1.Controls.Add(this.TxtDocumento);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1154, 393);
            this.panel1.TabIndex = 0;
            // 
            // TxtAnno
            // 
            this.TxtAnno.Anchor = System.Windows.Forms.AnchorStyles.Top;
            // 
            // 
            // 
            this.TxtAnno.Border.Class = "TextBoxBorder";
            this.TxtAnno.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TxtAnno.FocusHighlightEnabled = true;
            this.TxtAnno.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtAnno.Location = new System.Drawing.Point(236, 26);
            this.TxtAnno.Name = "TxtAnno";
            this.TxtAnno.PreventEnterBeep = true;
            this.TxtAnno.Size = new System.Drawing.Size(78, 25);
            this.TxtAnno.TabIndex = 59;
            this.TxtAnno.WatermarkFont = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtAnno.WatermarkText = "Año";
            this.TxtAnno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtAnno_KeyPress);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(194, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 17);
            this.label3.TabIndex = 58;
            this.label3.Text = "Año:";
            // 
            // TxtNro
            // 
            this.TxtNro.Anchor = System.Windows.Forms.AnchorStyles.Top;
            // 
            // 
            // 
            this.TxtNro.Border.Class = "TextBoxBorder";
            this.TxtNro.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TxtNro.FocusHighlightEnabled = true;
            this.TxtNro.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNro.Location = new System.Drawing.Point(76, 26);
            this.TxtNro.Name = "TxtNro";
            this.TxtNro.PreventEnterBeep = true;
            this.TxtNro.Size = new System.Drawing.Size(99, 25);
            this.TxtNro.TabIndex = 57;
            this.TxtNro.WatermarkFont = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNro.WatermarkText = "Nro.";
            this.TxtNro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNro_KeyPress);
            this.TxtNro.Leave += new System.EventHandler(this.TxtNro_Leave);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(34, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 17);
            this.label2.TabIndex = 56;
            this.label2.Text = "Nro:";
            // 
            // dgvLote
            // 
            this.dgvLote.AllowUserToAddRows = false;
            this.dgvLote.AllowUserToDeleteRows = false;
            this.dgvLote.AllowUserToOrderColumns = true;
            this.dgvLote.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dgvLote.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvLote.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvLote.BackgroundColor = System.Drawing.Color.White;
            this.dgvLote.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLote.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvLote.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLote.Location = new System.Drawing.Point(33, 70);
            this.dgvLote.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvLote.Name = "dgvLote";
            this.dgvLote.ReadOnly = true;
            this.dgvLote.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            this.dgvLote.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvLote.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLote.Size = new System.Drawing.Size(1092, 258);
            this.dgvLote.TabIndex = 55;
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnBuscar.BackColor = System.Drawing.Color.White;
            this.BtnBuscar.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.BtnBuscar.IconColor = System.Drawing.Color.Black;
            this.BtnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnBuscar.IconSize = 30;
            this.BtnBuscar.Location = new System.Drawing.Point(993, 18);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(69, 39);
            this.BtnBuscar.TabIndex = 53;
            this.BtnBuscar.UseVisualStyleBackColor = false;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // BtnCrearLote
            // 
            this.BtnCrearLote.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnCrearLote.BackColor = System.Drawing.Color.GhostWhite;
            this.BtnCrearLote.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCrearLote.ForeColor = System.Drawing.Color.Black;
            this.BtnCrearLote.Location = new System.Drawing.Point(33, 334);
            this.BtnCrearLote.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnCrearLote.Name = "BtnCrearLote";
            this.BtnCrearLote.Size = new System.Drawing.Size(132, 49);
            this.BtnCrearLote.TabIndex = 51;
            this.BtnCrearLote.Text = "ENVIAR A LEGAL";
            this.BtnCrearLote.UseVisualStyleBackColor = false;
            this.BtnCrearLote.Click += new System.EventHandler(this.BtnCrearLote_Click);
            // 
            // TxtDocumento
            // 
            this.TxtDocumento.Anchor = System.Windows.Forms.AnchorStyles.Top;
            // 
            // 
            // 
            this.TxtDocumento.Border.Class = "TextBoxBorder";
            this.TxtDocumento.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TxtDocumento.FocusHighlightEnabled = true;
            this.TxtDocumento.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDocumento.Location = new System.Drawing.Point(436, 26);
            this.TxtDocumento.Name = "TxtDocumento";
            this.TxtDocumento.PreventEnterBeep = true;
            this.TxtDocumento.ReadOnly = true;
            this.TxtDocumento.Size = new System.Drawing.Size(530, 25);
            this.TxtDocumento.TabIndex = 16;
            this.TxtDocumento.WatermarkFont = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDocumento.WatermarkText = "Seleccione el documento";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(345, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Documento:";
            // 
            // OpFileBuscarArchivo
            // 
            this.OpFileBuscarArchivo.FileName = "openFileDialog1";
            // 
            // EpValidar
            // 
            this.EpValidar.ContainerControl = this;
            // 
            // FrmCrearLote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1154, 393);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "FrmCrearLote";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmCrearLote_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLote)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EpValidar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevComponents.DotNetBar.Controls.TextBoxX TxtDocumento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnCrearLote;
        private FontAwesome.Sharp.IconButton BtnBuscar;
        private System.Windows.Forms.OpenFileDialog OpFileBuscarArchivo;
        public System.Windows.Forms.DataGridView dgvLote;
        private DevComponents.DotNetBar.Controls.TextBoxX TxtAnno;
        private System.Windows.Forms.Label label3;
        private DevComponents.DotNetBar.Controls.TextBoxX TxtNro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ErrorProvider EpValidar;
    }
}