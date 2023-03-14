namespace CapaPresentacion
{
    partial class FrmVerCartera
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BtnDetalleGestion = new System.Windows.Forms.Button();
            this.BtnAsignarGestor = new System.Windows.Forms.Button();
            this.CbxGestores = new System.Windows.Forms.ComboBox();
            this.LblGestor = new System.Windows.Forms.Label();
            this.BtnRefrescar = new System.Windows.Forms.Button();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.LblDesde = new System.Windows.Forms.Label();
            this.DtpIni = new System.Windows.Forms.DateTimePicker();
            this.DtpFin = new System.Windows.Forms.DateTimePicker();
            this.LblHasta = new System.Windows.Forms.Label();
            this.CbxEstado = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnActuaGest = new System.Windows.Forms.Button();
            this.BtnVerDeuda = new System.Windows.Forms.Button();
            this.DgvCartera = new System.Windows.Forms.DataGridView();
            this.CmsMenuOpciones = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.eDITARFECHAAGESTIONARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PtbLoad = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CbxSeguimiento = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.TipAyuda = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TxtApMaterno = new PlaceholderTextBox.PlaceholderTextBox();
            this.TxtApPaterno = new PlaceholderTextBox.PlaceholderTextBox();
            this.TxtNombre = new PlaceholderTextBox.PlaceholderTextBox();
            this.TxtCodigo = new PlaceholderTextBox.PlaceholderTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCartera)).BeginInit();
            this.CmsMenuOpciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PtbLoad)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnDetalleGestion
            // 
            this.BtnDetalleGestion.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnDetalleGestion.BackColor = System.Drawing.Color.GhostWhite;
            this.BtnDetalleGestion.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDetalleGestion.ForeColor = System.Drawing.Color.Black;
            this.BtnDetalleGestion.Location = new System.Drawing.Point(248, 33);
            this.BtnDetalleGestion.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnDetalleGestion.Name = "BtnDetalleGestion";
            this.BtnDetalleGestion.Size = new System.Drawing.Size(160, 44);
            this.BtnDetalleGestion.TabIndex = 54;
            this.BtnDetalleGestion.Text = "VER DETALLE GESTION";
            this.BtnDetalleGestion.UseVisualStyleBackColor = false;
            this.BtnDetalleGestion.Click += new System.EventHandler(this.BtnDetalleGestion_Click_1);
            this.BtnDetalleGestion.MouseHover += new System.EventHandler(this.BtnDetalleGestion_MouseHover);
            // 
            // BtnAsignarGestor
            // 
            this.BtnAsignarGestor.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnAsignarGestor.BackColor = System.Drawing.Color.GhostWhite;
            this.BtnAsignarGestor.Enabled = false;
            this.BtnAsignarGestor.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAsignarGestor.ForeColor = System.Drawing.Color.Black;
            this.BtnAsignarGestor.Location = new System.Drawing.Point(1012, 33);
            this.BtnAsignarGestor.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnAsignarGestor.Name = "BtnAsignarGestor";
            this.BtnAsignarGestor.Size = new System.Drawing.Size(160, 44);
            this.BtnAsignarGestor.TabIndex = 53;
            this.BtnAsignarGestor.Text = "CAMBIAR DE GESTOR";
            this.BtnAsignarGestor.UseVisualStyleBackColor = false;
            this.BtnAsignarGestor.Click += new System.EventHandler(this.BtnAsignarGestor_Click_1);
            this.BtnAsignarGestor.MouseHover += new System.EventHandler(this.BtnAsignarGestor_MouseHover);
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
            this.CbxGestores.Location = new System.Drawing.Point(942, 20);
            this.CbxGestores.Name = "CbxGestores";
            this.CbxGestores.Size = new System.Drawing.Size(190, 23);
            this.CbxGestores.TabIndex = 52;
            this.CbxGestores.Visible = false;
            // 
            // LblGestor
            // 
            this.LblGestor.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LblGestor.AutoSize = true;
            this.LblGestor.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblGestor.ForeColor = System.Drawing.Color.White;
            this.LblGestor.Location = new System.Drawing.Point(885, 28);
            this.LblGestor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblGestor.Name = "LblGestor";
            this.LblGestor.Size = new System.Drawing.Size(56, 15);
            this.LblGestor.TabIndex = 48;
            this.LblGestor.Text = "GESTOR:";
            this.LblGestor.Visible = false;
            // 
            // BtnRefrescar
            // 
            this.BtnRefrescar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnRefrescar.BackColor = System.Drawing.Color.GhostWhite;
            this.BtnRefrescar.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRefrescar.ForeColor = System.Drawing.Color.Black;
            this.BtnRefrescar.Location = new System.Drawing.Point(9, 33);
            this.BtnRefrescar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnRefrescar.Name = "BtnRefrescar";
            this.BtnRefrescar.Size = new System.Drawing.Size(160, 44);
            this.BtnRefrescar.TabIndex = 51;
            this.BtnRefrescar.Text = "COMPARAR MONTO ACTUAL";
            this.BtnRefrescar.UseVisualStyleBackColor = false;
            this.BtnRefrescar.Click += new System.EventHandler(this.BtnRefrescar_Click_1);
            this.BtnRefrescar.MouseHover += new System.EventHandler(this.BtnRefrescar_MouseHover);
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnLimpiar.BackColor = System.Drawing.Color.GhostWhite;
            this.BtnLimpiar.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLimpiar.ForeColor = System.Drawing.Color.Black;
            this.BtnLimpiar.Location = new System.Drawing.Point(487, 96);
            this.BtnLimpiar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(103, 49);
            this.BtnLimpiar.TabIndex = 50;
            this.BtnLimpiar.Text = "LIMPIAR";
            this.BtnLimpiar.UseVisualStyleBackColor = false;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click_1);
            // 
            // LblDesde
            // 
            this.LblDesde.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LblDesde.AutoSize = true;
            this.LblDesde.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDesde.ForeColor = System.Drawing.Color.White;
            this.LblDesde.Location = new System.Drawing.Point(12, 29);
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
            this.DtpIni.Location = new System.Drawing.Point(63, 22);
            this.DtpIni.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DtpIni.Name = "DtpIni";
            this.DtpIni.Size = new System.Drawing.Size(87, 22);
            this.DtpIni.TabIndex = 10;
            // 
            // DtpFin
            // 
            this.DtpFin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DtpFin.Checked = false;
            this.DtpFin.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpFin.Location = new System.Drawing.Point(217, 21);
            this.DtpFin.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DtpFin.Name = "DtpFin";
            this.DtpFin.Size = new System.Drawing.Size(88, 22);
            this.DtpFin.TabIndex = 17;
            // 
            // LblHasta
            // 
            this.LblHasta.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LblHasta.AutoSize = true;
            this.LblHasta.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHasta.ForeColor = System.Drawing.Color.White;
            this.LblHasta.Location = new System.Drawing.Point(169, 28);
            this.LblHasta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblHasta.Name = "LblHasta";
            this.LblHasta.Size = new System.Drawing.Size(45, 14);
            this.LblHasta.TabIndex = 16;
            this.LblHasta.Text = "HASTA";
            // 
            // CbxEstado
            // 
            this.CbxEstado.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CbxEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxEstado.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbxEstado.FormattingEnabled = true;
            this.CbxEstado.Items.AddRange(new object[] {
            ""});
            this.CbxEstado.Location = new System.Drawing.Point(679, 20);
            this.CbxEstado.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CbxEstado.Name = "CbxEstado";
            this.CbxEstado.Size = new System.Drawing.Size(191, 23);
            this.CbxEstado.TabIndex = 47;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(585, 28);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 15);
            this.label8.TabIndex = 46;
            this.label8.Text = "ESTADO:";
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnBuscar.BackColor = System.Drawing.Color.GhostWhite;
            this.BtnBuscar.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscar.ForeColor = System.Drawing.Color.Black;
            this.BtnBuscar.Location = new System.Drawing.Point(378, 96);
            this.BtnBuscar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(101, 50);
            this.BtnBuscar.TabIndex = 1;
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
            this.label2.Location = new System.Drawing.Point(35, 67);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 15);
            this.label2.TabIndex = 42;
            this.label2.Text = "NOMBRE:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(35, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 15);
            this.label1.TabIndex = 41;
            this.label1.Text = "CODIGO:";
            // 
            // BtnActuaGest
            // 
            this.BtnActuaGest.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnActuaGest.BackColor = System.Drawing.Color.GhostWhite;
            this.BtnActuaGest.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnActuaGest.ForeColor = System.Drawing.Color.Black;
            this.BtnActuaGest.Location = new System.Drawing.Point(768, 33);
            this.BtnActuaGest.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnActuaGest.Name = "BtnActuaGest";
            this.BtnActuaGest.Size = new System.Drawing.Size(160, 44);
            this.BtnActuaGest.TabIndex = 40;
            this.BtnActuaGest.Text = "ACTUALIZAR GESTION";
            this.BtnActuaGest.UseVisualStyleBackColor = false;
            this.BtnActuaGest.Click += new System.EventHandler(this.BtnActuaGest_Click_1);
            this.BtnActuaGest.MouseHover += new System.EventHandler(this.BtnActuaGest_MouseHover);
            // 
            // BtnVerDeuda
            // 
            this.BtnVerDeuda.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnVerDeuda.BackColor = System.Drawing.Color.GhostWhite;
            this.BtnVerDeuda.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVerDeuda.ForeColor = System.Drawing.Color.Black;
            this.BtnVerDeuda.Location = new System.Drawing.Point(510, 33);
            this.BtnVerDeuda.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnVerDeuda.Name = "BtnVerDeuda";
            this.BtnVerDeuda.Size = new System.Drawing.Size(160, 44);
            this.BtnVerDeuda.TabIndex = 39;
            this.BtnVerDeuda.Text = "VER DETALLE DE DEUDA";
            this.BtnVerDeuda.UseVisualStyleBackColor = false;
            this.BtnVerDeuda.Click += new System.EventHandler(this.BtnVerDeuda_Click_1);
            this.BtnVerDeuda.MouseHover += new System.EventHandler(this.BtnVerDeuda_MouseHover);
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
            this.DgvCartera.ContextMenuStrip = this.CmsMenuOpciones;
            this.DgvCartera.Location = new System.Drawing.Point(7, 117);
            this.DgvCartera.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DgvCartera.Name = "DgvCartera";
            this.DgvCartera.ReadOnly = true;
            this.DgvCartera.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.DgvCartera.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.DgvCartera.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvCartera.Size = new System.Drawing.Size(1165, 345);
            this.DgvCartera.TabIndex = 38;
            this.DgvCartera.Sorted += new System.EventHandler(this.DgvCartera_Sorted_1);
            this.DgvCartera.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DgvCartera_MouseDown);
            // 
            // CmsMenuOpciones
            // 
            this.CmsMenuOpciones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eDITARFECHAAGESTIONARToolStripMenuItem});
            this.CmsMenuOpciones.Name = "CmsMenuOpciones";
            this.CmsMenuOpciones.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.CmsMenuOpciones.Size = new System.Drawing.Size(228, 26);
            // 
            // eDITARFECHAAGESTIONARToolStripMenuItem
            // 
            this.eDITARFECHAAGESTIONARToolStripMenuItem.Name = "eDITARFECHAAGESTIONARToolStripMenuItem";
            this.eDITARFECHAAGESTIONARToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.eDITARFECHAAGESTIONARToolStripMenuItem.Text = "EDITAR FECHA A GESTIONAR";
            this.eDITARFECHAAGESTIONARToolStripMenuItem.Click += new System.EventHandler(this.eDITARFECHAAGESTIONARToolStripMenuItem_Click);
            // 
            // PtbLoad
            // 
            this.PtbLoad.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PtbLoad.BackColor = System.Drawing.Color.Transparent;
            this.PtbLoad.Image = global::CapaPresentacion.Properties.Resources.icons8_spinner;
            this.PtbLoad.Location = new System.Drawing.Point(5, 117);
            this.PtbLoad.Name = "PtbLoad";
            this.PtbLoad.Size = new System.Drawing.Size(1167, 344);
            this.PtbLoad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PtbLoad.TabIndex = 55;
            this.PtbLoad.TabStop = false;
            this.PtbLoad.Visible = false;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(287, 66);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 15);
            this.label3.TabIndex = 56;
            this.label3.Text = "AP. MATERNO:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(287, 28);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 15);
            this.label4.TabIndex = 58;
            this.label4.Text = "AP. PATERNO:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.LblDesde);
            this.groupBox1.Controls.Add(this.DtpIni);
            this.groupBox1.Controls.Add(this.LblHasta);
            this.groupBox1.Controls.Add(this.DtpFin);
            this.groupBox1.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(38, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(332, 60);
            this.groupBox1.TabIndex = 60;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "FECHA";
            this.groupBox1.MouseHover += new System.EventHandler(this.groupBox1_MouseHover);
            // 
            // CbxSeguimiento
            // 
            this.CbxSeguimiento.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CbxSeguimiento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxSeguimiento.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbxSeguimiento.FormattingEnabled = true;
            this.CbxSeguimiento.Items.AddRange(new object[] {
            ""});
            this.CbxSeguimiento.Location = new System.Drawing.Point(681, 58);
            this.CbxSeguimiento.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CbxSeguimiento.Name = "CbxSeguimiento";
            this.CbxSeguimiento.Size = new System.Drawing.Size(191, 23);
            this.CbxSeguimiento.TabIndex = 62;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(585, 66);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 15);
            this.label5.TabIndex = 61;
            this.label5.Text = "SEGUIMIENTO:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Crimson;
            this.pictureBox1.Location = new System.Drawing.Point(7, 92);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(16, 19);
            this.pictureBox1.TabIndex = 63;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.ForestGreen;
            this.pictureBox2.Location = new System.Drawing.Point(145, 92);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(16, 19);
            this.pictureBox2.TabIndex = 64;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.RoyalBlue;
            this.pictureBox3.Location = new System.Drawing.Point(290, 92);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(16, 19);
            this.pictureBox3.TabIndex = 65;
            this.pictureBox3.TabStop = false;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(30, 97);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 15);
            this.label6.TabIndex = 66;
            this.label6.Text = "FUERA DE PLAZO";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(168, 97);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 15);
            this.label7.TabIndex = 67;
            this.label7.Text = "ANTES DEL PLAZO";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(313, 97);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(148, 15);
            this.label9.TabIndex = 68;
            this.label9.Text = "ULTIMO DIA DEL PLAZO";
            // 
            // TipAyuda
            // 
            this.TipAyuda.AutomaticDelay = 5000;
            this.TipAyuda.AutoPopDelay = 5000;
            this.TipAyuda.InitialDelay = 5000;
            this.TipAyuda.ReshowDelay = 5000;
            this.TipAyuda.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.TipAyuda.ToolTipTitle = "Info";
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
            this.groupBox2.Controls.Add(this.BtnLimpiar);
            this.groupBox2.Controls.Add(this.CbxEstado);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.BtnBuscar);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(7, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1178, 156);
            this.groupBox2.TabIndex = 69;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "CRITERIOS DE BUSQUEDA";
            // 
            // TxtApMaterno
            // 
            this.TxtApMaterno.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TxtApMaterno.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtApMaterno.Location = new System.Drawing.Point(378, 58);
            this.TxtApMaterno.Name = "TxtApMaterno";
            this.TxtApMaterno.PlaceholderText = "Apellido Materno Contribuyente";
            this.TxtApMaterno.Size = new System.Drawing.Size(196, 23);
            this.TxtApMaterno.TabIndex = 66;
            // 
            // TxtApPaterno
            // 
            this.TxtApPaterno.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TxtApPaterno.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtApPaterno.Location = new System.Drawing.Point(378, 22);
            this.TxtApPaterno.Name = "TxtApPaterno";
            this.TxtApPaterno.PlaceholderText = "Apellido Paterno Contribuyente";
            this.TxtApPaterno.Size = new System.Drawing.Size(196, 23);
            this.TxtApPaterno.TabIndex = 65;
            // 
            // TxtNombre
            // 
            this.TxtNombre.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TxtNombre.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombre.Location = new System.Drawing.Point(100, 59);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.PlaceholderText = "Nombre Contribuyente";
            this.TxtNombre.Size = new System.Drawing.Size(180, 23);
            this.TxtNombre.TabIndex = 64;
            // 
            // TxtCodigo
            // 
            this.TxtCodigo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TxtCodigo.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCodigo.Location = new System.Drawing.Point(101, 22);
            this.TxtCodigo.Name = "TxtCodigo";
            this.TxtCodigo.PlaceholderText = "Codigo Contribuyente";
            this.TxtCodigo.Size = new System.Drawing.Size(180, 23);
            this.TxtCodigo.TabIndex = 63;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox3.Controls.Add(this.PtbLoad);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.BtnAsignarGestor);
            this.groupBox3.Controls.Add(this.DgvCartera);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.pictureBox3);
            this.groupBox3.Controls.Add(this.pictureBox2);
            this.groupBox3.Controls.Add(this.pictureBox1);
            this.groupBox3.Controls.Add(this.BtnDetalleGestion);
            this.groupBox3.Controls.Add(this.BtnRefrescar);
            this.groupBox3.Controls.Add(this.BtnActuaGest);
            this.groupBox3.Controls.Add(this.BtnVerDeuda);
            this.groupBox3.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(7, 176);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1178, 468);
            this.groupBox3.TabIndex = 70;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "GESTION DE CARTERA";
            // 
            // FrmVerCartera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(132)))), ((int)(((byte)(174)))));
            this.ClientSize = new System.Drawing.Size(1190, 690);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmVerCartera";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmVerCartera";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmVerCartera_Load);
            this.Shown += new System.EventHandler(this.FrmVerCartera_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.DgvCartera)).EndInit();
            this.CmsMenuOpciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PtbLoad)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BtnDetalleGestion;
        private System.Windows.Forms.Button BtnAsignarGestor;
        private System.Windows.Forms.ComboBox CbxGestores;
        public System.Windows.Forms.Label LblGestor;
        private System.Windows.Forms.Button BtnRefrescar;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.Label LblDesde;
        private System.Windows.Forms.DateTimePicker DtpIni;
        private System.Windows.Forms.Label LblHasta;
        private System.Windows.Forms.DateTimePicker DtpFin;
        private System.Windows.Forms.ComboBox CbxEstado;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnActuaGest;
        private System.Windows.Forms.Button BtnVerDeuda;
        public System.Windows.Forms.DataGridView DgvCartera;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox CbxSeguimiento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ToolTip TipAyuda;
        private System.Windows.Forms.ContextMenuStrip CmsMenuOpciones;
        private System.Windows.Forms.ToolStripMenuItem eDITARFECHAAGESTIONARToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.PictureBox PtbLoad;
        public System.Windows.Forms.GroupBox groupBox3;
        private PlaceholderTextBox.PlaceholderTextBox TxtApMaterno;
        private PlaceholderTextBox.PlaceholderTextBox TxtApPaterno;
        private PlaceholderTextBox.PlaceholderTextBox TxtNombre;
        private PlaceholderTextBox.PlaceholderTextBox TxtCodigo;
    }
}