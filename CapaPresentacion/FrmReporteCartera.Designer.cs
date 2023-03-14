namespace CapaPresentacion
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.CbxSeguimiento = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LblDesde = new System.Windows.Forms.Label();
            this.DtpIni = new System.Windows.Forms.DateTimePicker();
            this.DtpFin = new System.Windows.Forms.DateTimePicker();
            this.LblHasta = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CbxGestores = new System.Windows.Forms.ComboBox();
            this.LblGestor = new System.Windows.Forms.Label();
            this.BtnReporte = new System.Windows.Forms.Button();
            this.CbxEstado = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DgvCartera = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ptbLoad3 = new System.Windows.Forms.PictureBox();
            this.TxtApMaterno = new PlaceholderTextBox.PlaceholderTextBox();
            this.TxtApPaterno = new PlaceholderTextBox.PlaceholderTextBox();
            this.TxtNombre = new PlaceholderTextBox.PlaceholderTextBox();
            this.TxtCodigo = new PlaceholderTextBox.PlaceholderTextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCartera)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLoad3)).BeginInit();
            this.SuspendLayout();
            // 
            // CbxSeguimiento
            // 
            this.CbxSeguimiento.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CbxSeguimiento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxSeguimiento.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbxSeguimiento.FormattingEnabled = true;
            this.CbxSeguimiento.Items.AddRange(new object[] {
            ""});
            this.CbxSeguimiento.Location = new System.Drawing.Point(681, 61);
            this.CbxSeguimiento.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CbxSeguimiento.Name = "CbxSeguimiento";
            this.CbxSeguimiento.Size = new System.Drawing.Size(191, 23);
            this.CbxSeguimiento.TabIndex = 79;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(584, 69);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 15);
            this.label5.TabIndex = 78;
            this.label5.Text = "SEGUIMIENTO:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.LblDesde);
            this.groupBox1.Controls.Add(this.DtpIni);
            this.groupBox1.Controls.Add(this.DtpFin);
            this.groupBox1.Controls.Add(this.LblHasta);
            this.groupBox1.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 102);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(361, 59);
            this.groupBox1.TabIndex = 77;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "FECHA";
            // 
            // LblDesde
            // 
            this.LblDesde.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LblDesde.AutoSize = true;
            this.LblDesde.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDesde.ForeColor = System.Drawing.Color.White;
            this.LblDesde.Location = new System.Drawing.Point(8, 28);
            this.LblDesde.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblDesde.Name = "LblDesde";
            this.LblDesde.Size = new System.Drawing.Size(43, 14);
            this.LblDesde.TabIndex = 15;
            this.LblDesde.Text = "DESDE";
            // 
            // DtpIni
            // 
            this.DtpIni.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DtpIni.Checked = false;
            this.DtpIni.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpIni.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpIni.Location = new System.Drawing.Point(65, 21);
            this.DtpIni.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DtpIni.Name = "DtpIni";
            this.DtpIni.Size = new System.Drawing.Size(116, 22);
            this.DtpIni.TabIndex = 10;
            // 
            // DtpFin
            // 
            this.DtpFin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DtpFin.Checked = false;
            this.DtpFin.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpFin.Location = new System.Drawing.Point(244, 21);
            this.DtpFin.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DtpFin.Name = "DtpFin";
            this.DtpFin.Size = new System.Drawing.Size(110, 22);
            this.DtpFin.TabIndex = 17;
            // 
            // LblHasta
            // 
            this.LblHasta.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LblHasta.AutoSize = true;
            this.LblHasta.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHasta.ForeColor = System.Drawing.Color.White;
            this.LblHasta.Location = new System.Drawing.Point(196, 28);
            this.LblHasta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblHasta.Name = "LblHasta";
            this.LblHasta.Size = new System.Drawing.Size(45, 14);
            this.LblHasta.TabIndex = 16;
            this.LblHasta.Text = "HASTA";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(276, 34);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 15);
            this.label4.TabIndex = 75;
            this.label4.Text = "AP. PATERNO:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(276, 67);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 15);
            this.label3.TabIndex = 73;
            this.label3.Text = "AP. MATERNO:";
            // 
            // CbxGestores
            // 
            this.CbxGestores.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CbxGestores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxGestores.Enabled = false;
            this.CbxGestores.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbxGestores.FormattingEnabled = true;
            this.CbxGestores.Items.AddRange(new object[] {
            ""});
            this.CbxGestores.Location = new System.Drawing.Point(949, 30);
            this.CbxGestores.Name = "CbxGestores";
            this.CbxGestores.Size = new System.Drawing.Size(190, 23);
            this.CbxGestores.TabIndex = 72;
            this.CbxGestores.Visible = false;
            // 
            // LblGestor
            // 
            this.LblGestor.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LblGestor.AutoSize = true;
            this.LblGestor.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblGestor.ForeColor = System.Drawing.Color.White;
            this.LblGestor.Location = new System.Drawing.Point(890, 36);
            this.LblGestor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblGestor.Name = "LblGestor";
            this.LblGestor.Size = new System.Drawing.Size(56, 15);
            this.LblGestor.TabIndex = 70;
            this.LblGestor.Text = "GESTOR:";
            this.LblGestor.Visible = false;
            // 
            // BtnReporte
            // 
            this.BtnReporte.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnReporte.BackColor = System.Drawing.Color.GhostWhite;
            this.BtnReporte.Enabled = false;
            this.BtnReporte.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReporte.ForeColor = System.Drawing.Color.Black;
            this.BtnReporte.Location = new System.Drawing.Point(590, 107);
            this.BtnReporte.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnReporte.Name = "BtnReporte";
            this.BtnReporte.Size = new System.Drawing.Size(148, 54);
            this.BtnReporte.TabIndex = 71;
            this.BtnReporte.Text = "REPORTE";
            this.BtnReporte.UseVisualStyleBackColor = false;
            this.BtnReporte.Click += new System.EventHandler(this.BtnReporte_Click);
            // 
            // CbxEstado
            // 
            this.CbxEstado.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CbxEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxEstado.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbxEstado.FormattingEnabled = true;
            this.CbxEstado.Items.AddRange(new object[] {
            ""});
            this.CbxEstado.Location = new System.Drawing.Point(681, 28);
            this.CbxEstado.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CbxEstado.Name = "CbxEstado";
            this.CbxEstado.Size = new System.Drawing.Size(191, 23);
            this.CbxEstado.TabIndex = 69;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(584, 36);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 15);
            this.label8.TabIndex = 68;
            this.label8.Text = "ESTADO:";
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnBuscar.BackColor = System.Drawing.Color.GhostWhite;
            this.BtnBuscar.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscar.ForeColor = System.Drawing.Color.Black;
            this.BtnBuscar.Location = new System.Drawing.Point(417, 107);
            this.BtnBuscar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(148, 54);
            this.BtnBuscar.TabIndex = 63;
            this.BtnBuscar.Text = "BUSCAR";
            this.BtnBuscar.UseVisualStyleBackColor = false;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(10, 68);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 15);
            this.label2.TabIndex = 65;
            this.label2.Text = "NOMBRE:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(10, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 15);
            this.label1.TabIndex = 64;
            this.label1.Text = "CODIGO:";
            // 
            // DgvCartera
            // 
            this.DgvCartera.AllowUserToAddRows = false;
            this.DgvCartera.AllowUserToDeleteRows = false;
            this.DgvCartera.AllowUserToOrderColumns = true;
            this.DgvCartera.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DgvCartera.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DgvCartera.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DgvCartera.BackgroundColor = System.Drawing.Color.White;
            this.DgvCartera.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvCartera.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvCartera.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvCartera.Location = new System.Drawing.Point(12, 22);
            this.DgvCartera.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DgvCartera.Name = "DgvCartera";
            this.DgvCartera.ReadOnly = true;
            this.DgvCartera.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.DgvCartera.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.DgvCartera.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvCartera.Size = new System.Drawing.Size(1139, 430);
            this.DgvCartera.TabIndex = 80;
            this.DgvCartera.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvCartera_CellContentClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox2.Controls.Add(this.TxtApMaterno);
            this.groupBox2.Controls.Add(this.TxtApPaterno);
            this.groupBox2.Controls.Add(this.TxtNombre);
            this.groupBox2.Controls.Add(this.TxtCodigo);
            this.groupBox2.Controls.Add(this.CbxSeguimiento);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.CbxGestores);
            this.groupBox2.Controls.Add(this.LblGestor);
            this.groupBox2.Controls.Add(this.BtnReporte);
            this.groupBox2.Controls.Add(this.CbxEstado);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.BtnBuscar);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(14, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1163, 180);
            this.groupBox2.TabIndex = 82;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "CRITERIOS DE BUSQUEDA";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox3.Controls.Add(this.ptbLoad3);
            this.groupBox3.Controls.Add(this.DgvCartera);
            this.groupBox3.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(15, 198);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1162, 458);
            this.groupBox3.TabIndex = 83;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "PRE VISUALIZACION";
            // 
            // ptbLoad3
            // 
            this.ptbLoad3.Image = global::CapaPresentacion.Properties.Resources.icons8_spinner;
            this.ptbLoad3.Location = new System.Drawing.Point(12, 22);
            this.ptbLoad3.Name = "ptbLoad3";
            this.ptbLoad3.Size = new System.Drawing.Size(1139, 430);
            this.ptbLoad3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ptbLoad3.TabIndex = 83;
            this.ptbLoad3.TabStop = false;
            this.ptbLoad3.Visible = false;
            // 
            // TxtApMaterno
            // 
            this.TxtApMaterno.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TxtApMaterno.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtApMaterno.Location = new System.Drawing.Point(366, 60);
            this.TxtApMaterno.Name = "TxtApMaterno";
            this.TxtApMaterno.PlaceholderText = "Apellido Materno Contribuyente";
            this.TxtApMaterno.Size = new System.Drawing.Size(196, 23);
            this.TxtApMaterno.TabIndex = 83;
            // 
            // TxtApPaterno
            // 
            this.TxtApPaterno.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TxtApPaterno.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtApPaterno.Location = new System.Drawing.Point(366, 30);
            this.TxtApPaterno.Name = "TxtApPaterno";
            this.TxtApPaterno.PlaceholderText = "Apellido Paterno Contribuyente";
            this.TxtApPaterno.Size = new System.Drawing.Size(196, 23);
            this.TxtApPaterno.TabIndex = 82;
            // 
            // TxtNombre
            // 
            this.TxtNombre.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TxtNombre.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombre.Location = new System.Drawing.Point(89, 61);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.PlaceholderText = "Nombre Contribuyente";
            this.TxtNombre.Size = new System.Drawing.Size(180, 23);
            this.TxtNombre.TabIndex = 81;
            // 
            // TxtCodigo
            // 
            this.TxtCodigo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TxtCodigo.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCodigo.Location = new System.Drawing.Point(89, 30);
            this.TxtCodigo.Name = "TxtCodigo";
            this.TxtCodigo.PlaceholderText = "Codigo Contribuyente";
            this.TxtCodigo.Size = new System.Drawing.Size(180, 23);
            this.TxtCodigo.TabIndex = 80;
            // 
            // FrmReporteCartera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(132)))), ((int)(((byte)(174)))));
            this.ClientSize = new System.Drawing.Size(1201, 690);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmReporteCartera";
            this.Text = "FrmReporteCartera";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmReporteCartera_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCartera)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbLoad3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox CbxSeguimiento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label LblDesde;
        private System.Windows.Forms.DateTimePicker DtpIni;
        private System.Windows.Forms.DateTimePicker DtpFin;
        private System.Windows.Forms.Label LblHasta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CbxGestores;
        public System.Windows.Forms.Label LblGestor;
        private System.Windows.Forms.Button BtnReporte;
        private System.Windows.Forms.ComboBox CbxEstado;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView DgvCartera;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox ptbLoad3;
        private PlaceholderTextBox.PlaceholderTextBox TxtApMaterno;
        private PlaceholderTextBox.PlaceholderTextBox TxtApPaterno;
        private PlaceholderTextBox.PlaceholderTextBox TxtNombre;
        private PlaceholderTextBox.PlaceholderTextBox TxtCodigo;
    }
}