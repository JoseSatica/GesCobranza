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
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LblDesde = new System.Windows.Forms.Label();
            this.DtpIni = new System.Windows.Forms.DateTimePicker();
            this.DtpFin = new System.Windows.Forms.DateTimePicker();
            this.LblHasta = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LblGestor = new System.Windows.Forms.Label();
            this.BtnReporte = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DgvCartera = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CbxGestores = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItem3 = new DevComponents.Editors.ComboItem();
            this.CbxSeguimiento = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItem2 = new DevComponents.Editors.ComboItem();
            this.CbxEstado = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItem1 = new DevComponents.Editors.ComboItem();
            this.TxtApMaterno = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.TxtApPaterno = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.TxtNombre = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.TxtCodigo = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ptbLoad3 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCartera)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLoad3)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(594, 67);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 17);
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
            this.groupBox1.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(18, 102);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(369, 59);
            this.groupBox1.TabIndex = 77;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "FECHA";
            // 
            // LblDesde
            // 
            this.LblDesde.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LblDesde.AutoSize = true;
            this.LblDesde.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDesde.ForeColor = System.Drawing.Color.White;
            this.LblDesde.Location = new System.Drawing.Point(11, 30);
            this.LblDesde.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblDesde.Name = "LblDesde";
            this.LblDesde.Size = new System.Drawing.Size(53, 17);
            this.LblDesde.TabIndex = 15;
            this.LblDesde.Text = "DESDE";
            // 
            // DtpIni
            // 
            this.DtpIni.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DtpIni.Checked = false;
            this.DtpIni.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpIni.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpIni.Location = new System.Drawing.Point(68, 23);
            this.DtpIni.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DtpIni.Name = "DtpIni";
            this.DtpIni.Size = new System.Drawing.Size(116, 25);
            this.DtpIni.TabIndex = 10;
            // 
            // DtpFin
            // 
            this.DtpFin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DtpFin.Checked = false;
            this.DtpFin.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpFin.Location = new System.Drawing.Point(245, 23);
            this.DtpFin.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DtpFin.Name = "DtpFin";
            this.DtpFin.Size = new System.Drawing.Size(117, 25);
            this.DtpFin.TabIndex = 17;
            // 
            // LblHasta
            // 
            this.LblHasta.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LblHasta.AutoSize = true;
            this.LblHasta.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHasta.ForeColor = System.Drawing.Color.White;
            this.LblHasta.Location = new System.Drawing.Point(192, 30);
            this.LblHasta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblHasta.Name = "LblHasta";
            this.LblHasta.Size = new System.Drawing.Size(51, 17);
            this.LblHasta.TabIndex = 16;
            this.LblHasta.Text = "HASTA";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(286, 34);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 17);
            this.label4.TabIndex = 75;
            this.label4.Text = "AP. PATERNO:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(286, 67);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 17);
            this.label3.TabIndex = 73;
            this.label3.Text = "AP. MATERNO:";
            // 
            // LblGestor
            // 
            this.LblGestor.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LblGestor.AutoSize = true;
            this.LblGestor.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblGestor.ForeColor = System.Drawing.Color.White;
            this.LblGestor.Location = new System.Drawing.Point(907, 34);
            this.LblGestor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblGestor.Name = "LblGestor";
            this.LblGestor.Size = new System.Drawing.Size(65, 17);
            this.LblGestor.TabIndex = 70;
            this.LblGestor.Text = "GESTOR:";
            this.LblGestor.Visible = false;
            // 
            // BtnReporte
            // 
            this.BtnReporte.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnReporte.BackColor = System.Drawing.Color.GhostWhite;
            this.BtnReporte.Enabled = false;
            this.BtnReporte.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReporte.ForeColor = System.Drawing.Color.Black;
            this.BtnReporte.Location = new System.Drawing.Point(558, 112);
            this.BtnReporte.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnReporte.Name = "BtnReporte";
            this.BtnReporte.Size = new System.Drawing.Size(134, 50);
            this.BtnReporte.TabIndex = 71;
            this.BtnReporte.Text = "REPORTE";
            this.BtnReporte.UseVisualStyleBackColor = false;
            this.BtnReporte.Click += new System.EventHandler(this.BtnReporte_Click);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(597, 34);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 17);
            this.label8.TabIndex = 68;
            this.label8.Text = "ESTADO:";
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnBuscar.BackColor = System.Drawing.Color.GhostWhite;
            this.BtnBuscar.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscar.ForeColor = System.Drawing.Color.Black;
            this.BtnBuscar.Location = new System.Drawing.Point(416, 112);
            this.BtnBuscar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(134, 50);
            this.BtnBuscar.TabIndex = 63;
            this.BtnBuscar.Text = "BUSCAR";
            this.BtnBuscar.UseVisualStyleBackColor = false;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(15, 68);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 65;
            this.label2.Text = "NOMBRE:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(15, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
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
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvCartera.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvCartera.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvCartera.Location = new System.Drawing.Point(22, 22);
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
            this.DgvCartera.Size = new System.Drawing.Size(1133, 430);
            this.DgvCartera.TabIndex = 80;
            this.DgvCartera.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvCartera_CellContentClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox2.Controls.Add(this.CbxGestores);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.CbxSeguimiento);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.CbxEstado);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.TxtApMaterno);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.TxtApPaterno);
            this.groupBox2.Controls.Add(this.LblGestor);
            this.groupBox2.Controls.Add(this.TxtNombre);
            this.groupBox2.Controls.Add(this.BtnReporte);
            this.groupBox2.Controls.Add(this.TxtCodigo);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.BtnBuscar);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(18, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1183, 180);
            this.groupBox2.TabIndex = 82;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "CRITERIOS DE BUSQUEDA";
            // 
            // CbxGestores
            // 
            this.CbxGestores.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CbxGestores.DisplayMember = "Text";
            this.CbxGestores.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CbxGestores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxGestores.FocusHighlightEnabled = true;
            this.CbxGestores.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbxGestores.FormattingEnabled = true;
            this.CbxGestores.ItemHeight = 20;
            this.CbxGestores.Items.AddRange(new object[] {
            this.comboItem3});
            this.CbxGestores.Location = new System.Drawing.Point(975, 27);
            this.CbxGestores.Name = "CbxGestores";
            this.CbxGestores.Size = new System.Drawing.Size(193, 26);
            this.CbxGestores.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.CbxGestores.TabIndex = 90;
            this.CbxGestores.WatermarkFont = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbxGestores.WatermarkText = "Todos";
            this.CbxGestores.SelectedValueChanged += new System.EventHandler(this.CbxGestores_SelectedValueChanged);
            // 
            // CbxSeguimiento
            // 
            this.CbxSeguimiento.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CbxSeguimiento.DisplayMember = "Text";
            this.CbxSeguimiento.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CbxSeguimiento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxSeguimiento.FocusHighlightEnabled = true;
            this.CbxSeguimiento.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbxSeguimiento.FormattingEnabled = true;
            this.CbxSeguimiento.ItemHeight = 20;
            this.CbxSeguimiento.Items.AddRange(new object[] {
            this.comboItem2});
            this.CbxSeguimiento.Location = new System.Drawing.Point(704, 57);
            this.CbxSeguimiento.Name = "CbxSeguimiento";
            this.CbxSeguimiento.Size = new System.Drawing.Size(193, 26);
            this.CbxSeguimiento.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.CbxSeguimiento.TabIndex = 89;
            this.CbxSeguimiento.WatermarkFont = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbxSeguimiento.WatermarkText = "Todos";
            this.CbxSeguimiento.SelectedValueChanged += new System.EventHandler(this.CbxSeguimiento_SelectedValueChanged);
            // 
            // CbxEstado
            // 
            this.CbxEstado.DisplayMember = "Text";
            this.CbxEstado.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CbxEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxEstado.FocusHighlightEnabled = true;
            this.CbxEstado.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbxEstado.FormattingEnabled = true;
            this.CbxEstado.ItemHeight = 20;
            this.CbxEstado.Items.AddRange(new object[] {
            this.comboItem1});
            this.CbxEstado.Location = new System.Drawing.Point(704, 25);
            this.CbxEstado.Name = "CbxEstado";
            this.CbxEstado.Size = new System.Drawing.Size(193, 26);
            this.CbxEstado.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.CbxEstado.TabIndex = 88;
            this.CbxEstado.WatermarkFont = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbxEstado.WatermarkText = "Todos";
            this.CbxEstado.SelectedValueChanged += new System.EventHandler(this.CbxEstado_SelectedValueChanged);
            // 
            // TxtApMaterno
            // 
            this.TxtApMaterno.Anchor = System.Windows.Forms.AnchorStyles.Top;
            // 
            // 
            // 
            this.TxtApMaterno.Border.Class = "TextBoxBorder";
            this.TxtApMaterno.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TxtApMaterno.FocusHighlightEnabled = true;
            this.TxtApMaterno.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtApMaterno.Location = new System.Drawing.Point(394, 59);
            this.TxtApMaterno.Name = "TxtApMaterno";
            this.TxtApMaterno.PreventEnterBeep = true;
            this.TxtApMaterno.Size = new System.Drawing.Size(193, 25);
            this.TxtApMaterno.TabIndex = 87;
            this.TxtApMaterno.WatermarkFont = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtApMaterno.WatermarkText = "Apellido Materno";
            // 
            // TxtApPaterno
            // 
            this.TxtApPaterno.Anchor = System.Windows.Forms.AnchorStyles.Top;
            // 
            // 
            // 
            this.TxtApPaterno.Border.Class = "TextBoxBorder";
            this.TxtApPaterno.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TxtApPaterno.FocusHighlightEnabled = true;
            this.TxtApPaterno.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtApPaterno.Location = new System.Drawing.Point(394, 28);
            this.TxtApPaterno.Name = "TxtApPaterno";
            this.TxtApPaterno.PreventEnterBeep = true;
            this.TxtApPaterno.Size = new System.Drawing.Size(193, 25);
            this.TxtApPaterno.TabIndex = 86;
            this.TxtApPaterno.WatermarkFont = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtApPaterno.WatermarkText = "Apellido Paterno";
            // 
            // TxtNombre
            // 
            this.TxtNombre.Anchor = System.Windows.Forms.AnchorStyles.Top;
            // 
            // 
            // 
            this.TxtNombre.Border.Class = "TextBoxBorder";
            this.TxtNombre.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TxtNombre.FocusHighlightEnabled = true;
            this.TxtNombre.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombre.Location = new System.Drawing.Point(86, 60);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.PreventEnterBeep = true;
            this.TxtNombre.Size = new System.Drawing.Size(193, 25);
            this.TxtNombre.TabIndex = 85;
            this.TxtNombre.WatermarkFont = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombre.WatermarkText = "Nombre Contribuyente";
            // 
            // TxtCodigo
            // 
            this.TxtCodigo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            // 
            // 
            // 
            this.TxtCodigo.Border.Class = "TextBoxBorder";
            this.TxtCodigo.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TxtCodigo.FocusHighlightEnabled = true;
            this.TxtCodigo.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCodigo.Location = new System.Drawing.Point(86, 26);
            this.TxtCodigo.Name = "TxtCodigo";
            this.TxtCodigo.PreventEnterBeep = true;
            this.TxtCodigo.Size = new System.Drawing.Size(193, 25);
            this.TxtCodigo.TabIndex = 84;
            this.TxtCodigo.WatermarkFont = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCodigo.WatermarkText = "Codigo Contribuyente";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox3.Controls.Add(this.ptbLoad3);
            this.groupBox3.Controls.Add(this.DgvCartera);
            this.groupBox3.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(19, 198);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1182, 458);
            this.groupBox3.TabIndex = 83;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "PRE VISUALIZACION";
            // 
            // ptbLoad3
            // 
            this.ptbLoad3.Image = global::CapaPresentacion.Properties.Resources.icons8_spinner;
            this.ptbLoad3.Location = new System.Drawing.Point(12, 22);
            this.ptbLoad3.Name = "ptbLoad3";
            this.ptbLoad3.Size = new System.Drawing.Size(1143, 430);
            this.ptbLoad3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ptbLoad3.TabIndex = 83;
            this.ptbLoad3.TabStop = false;
            this.ptbLoad3.Visible = false;
            // 
            // FrmReporteCartera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(132)))), ((int)(((byte)(174)))));
            this.ClientSize = new System.Drawing.Size(1219, 690);
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label LblDesde;
        private System.Windows.Forms.DateTimePicker DtpIni;
        private System.Windows.Forms.DateTimePicker DtpFin;
        private System.Windows.Forms.Label LblHasta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label LblGestor;
        private System.Windows.Forms.Button BtnReporte;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView DgvCartera;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox ptbLoad3;
        private DevComponents.DotNetBar.Controls.ComboBoxEx CbxGestores;
        private DevComponents.Editors.ComboItem comboItem3;
        private DevComponents.DotNetBar.Controls.ComboBoxEx CbxSeguimiento;
        private DevComponents.Editors.ComboItem comboItem2;
        private DevComponents.DotNetBar.Controls.ComboBoxEx CbxEstado;
        private DevComponents.Editors.ComboItem comboItem1;
        private DevComponents.DotNetBar.Controls.TextBoxX TxtApMaterno;
        private DevComponents.DotNetBar.Controls.TextBoxX TxtApPaterno;
        private DevComponents.DotNetBar.Controls.TextBoxX TxtNombre;
        private DevComponents.DotNetBar.Controls.TextBoxX TxtCodigo;
    }
}