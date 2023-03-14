namespace CapaPresentacion
{
    partial class FrmIngresoxGestor
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DgvMostrarIngresoDetalle = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PicBoxLoad = new System.Windows.Forms.PictureBox();
            this.DgvMostrarIngreso = new System.Windows.Forms.DataGridView();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CbxGestor = new System.Windows.Forms.ComboBox();
            this.DtpFechafin = new System.Windows.Forms.DateTimePicker();
            this.DtpFechaini = new System.Windows.Forms.DateTimePicker();
            this.TipAyuda = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvMostrarIngresoDetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxLoad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvMostrarIngreso)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(132)))), ((int)(((byte)(174)))));
            this.groupBox1.Controls.Add(this.DgvMostrarIngresoDetalle);
            this.groupBox1.Controls.Add(this.PicBoxLoad);
            this.groupBox1.Controls.Add(this.DgvMostrarIngreso);
            this.groupBox1.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(16, 108);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1345, 630);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "RECAUDADO POR GESTOR";
            // 
            // DgvMostrarIngresoDetalle
            // 
            this.DgvMostrarIngresoDetalle.AllowUserToAddRows = false;
            this.DgvMostrarIngresoDetalle.AllowUserToDeleteRows = false;
            this.DgvMostrarIngresoDetalle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DgvMostrarIngresoDetalle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DgvMostrarIngresoDetalle.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DgvMostrarIngresoDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvMostrarIngresoDetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.DgvMostrarIngresoDetalle.Location = new System.Drawing.Point(1098, 23);
            this.DgvMostrarIngresoDetalle.Name = "DgvMostrarIngresoDetalle";
            this.DgvMostrarIngresoDetalle.ReadOnly = true;
            this.DgvMostrarIngresoDetalle.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvMostrarIngresoDetalle.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvMostrarIngresoDetalle.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.DgvMostrarIngresoDetalle.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.DgvMostrarIngresoDetalle.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DgvMostrarIngresoDetalle.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.DgvMostrarIngresoDetalle.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.DgvMostrarIngresoDetalle.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.DgvMostrarIngresoDetalle.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvMostrarIngresoDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvMostrarIngresoDetalle.Size = new System.Drawing.Size(240, 197);
            this.DgvMostrarIngresoDetalle.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "GESTOR";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 81;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "RECAUDADO";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 108;
            // 
            // PicBoxLoad
            // 
            this.PicBoxLoad.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PicBoxLoad.BackColor = System.Drawing.Color.Transparent;
            this.PicBoxLoad.Image = global::CapaPresentacion.Properties.Resources.icons8_spinner;
            this.PicBoxLoad.Location = new System.Drawing.Point(17, 23);
            this.PicBoxLoad.Name = "PicBoxLoad";
            this.PicBoxLoad.Size = new System.Drawing.Size(1075, 599);
            this.PicBoxLoad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PicBoxLoad.TabIndex = 8;
            this.PicBoxLoad.TabStop = false;
            this.PicBoxLoad.Visible = false;
            // 
            // DgvMostrarIngreso
            // 
            this.DgvMostrarIngreso.AllowUserToAddRows = false;
            this.DgvMostrarIngreso.AllowUserToDeleteRows = false;
            this.DgvMostrarIngreso.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DgvMostrarIngreso.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DgvMostrarIngreso.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DgvMostrarIngreso.BackgroundColor = System.Drawing.Color.White;
            this.DgvMostrarIngreso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvMostrarIngreso.Location = new System.Drawing.Point(17, 23);
            this.DgvMostrarIngreso.Margin = new System.Windows.Forms.Padding(4);
            this.DgvMostrarIngreso.Name = "DgvMostrarIngreso";
            this.DgvMostrarIngreso.ReadOnly = true;
            this.DgvMostrarIngreso.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.DgvMostrarIngreso.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.DgvMostrarIngreso.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.DgvMostrarIngreso.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DgvMostrarIngreso.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.DgvMostrarIngreso.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.DgvMostrarIngreso.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.DgvMostrarIngreso.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvMostrarIngreso.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvMostrarIngreso.Size = new System.Drawing.Size(1075, 599);
            this.DgvMostrarIngreso.TabIndex = 6;
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.BackColor = System.Drawing.Color.White;
            this.BtnBuscar.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscar.ForeColor = System.Drawing.Color.Black;
            this.BtnBuscar.Location = new System.Drawing.Point(884, 23);
            this.BtnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(116, 50);
            this.BtnBuscar.TabIndex = 7;
            this.BtnBuscar.Text = "BUSCAR";
            this.BtnBuscar.UseVisualStyleBackColor = false;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            this.BtnBuscar.MouseHover += new System.EventHandler(this.BtnBuscar_MouseHover);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(681, 44);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "HASTA:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(473, 45);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "DESDE:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(208, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "GESTOR:";
            // 
            // CbxGestor
            // 
            this.CbxGestor.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CbxGestor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxGestor.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbxGestor.FormattingEnabled = true;
            this.CbxGestor.Items.AddRange(new object[] {
            ""});
            this.CbxGestor.Location = new System.Drawing.Point(285, 37);
            this.CbxGestor.Margin = new System.Windows.Forms.Padding(4);
            this.CbxGestor.Name = "CbxGestor";
            this.CbxGestor.Size = new System.Drawing.Size(170, 23);
            this.CbxGestor.TabIndex = 2;
            // 
            // DtpFechafin
            // 
            this.DtpFechafin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DtpFechafin.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpFechafin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpFechafin.Location = new System.Drawing.Point(740, 36);
            this.DtpFechafin.Margin = new System.Windows.Forms.Padding(4);
            this.DtpFechafin.Name = "DtpFechafin";
            this.DtpFechafin.Size = new System.Drawing.Size(112, 23);
            this.DtpFechafin.TabIndex = 1;
            // 
            // DtpFechaini
            // 
            this.DtpFechaini.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DtpFechaini.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpFechaini.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpFechaini.Location = new System.Drawing.Point(534, 37);
            this.DtpFechaini.Margin = new System.Windows.Forms.Padding(4);
            this.DtpFechaini.Name = "DtpFechaini";
            this.DtpFechaini.Size = new System.Drawing.Size(120, 23);
            this.DtpFechaini.TabIndex = 0;
            // 
            // TipAyuda
            // 
            this.TipAyuda.AutomaticDelay = 4000;
            this.TipAyuda.AutoPopDelay = 4000;
            this.TipAyuda.InitialDelay = 4000;
            this.TipAyuda.ReshowDelay = 4000;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.BtnBuscar);
            this.groupBox2.Controls.Add(this.DtpFechaini);
            this.groupBox2.Controls.Add(this.DtpFechafin);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.CbxGestor);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(14, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1347, 89);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "CRITERIO DE BUSQUEDA";
            // 
            // FrmIngresoxGestor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(132)))), ((int)(((byte)(174)))));
            this.ClientSize = new System.Drawing.Size(1373, 751);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmIngresoxGestor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "INGRESOS POR GESTOR";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmIngresoxGestor_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvMostrarIngresoDetalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxLoad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvMostrarIngreso)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView DgvMostrarIngreso;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnBuscar;
        public System.Windows.Forms.ComboBox CbxGestor;
        public System.Windows.Forms.DateTimePicker DtpFechafin;
        public System.Windows.Forms.DateTimePicker DtpFechaini;
        private System.Windows.Forms.DataGridView DgvMostrarIngresoDetalle;
        private System.Windows.Forms.PictureBox PicBoxLoad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.ToolTip TipAyuda;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}