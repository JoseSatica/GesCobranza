namespace CapaPresentacion
{
    partial class FrmAsignarMasivo
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
            this.BtnArchivo = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnCargarArchivo = new System.Windows.Forms.Button();
            this.BtnEnviarCartera = new System.Windows.Forms.Button();
            this.CbxGestores = new System.Windows.Forms.ComboBox();
            this.prueba = new System.Windows.Forms.DataGridView();
            this.OpFileBuscarArchivo = new System.Windows.Forms.OpenFileDialog();
            this.LblRuta = new System.Windows.Forms.Label();
            this.Lblp = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.BtnCambiarCartera = new System.Windows.Forms.Button();
            this.cbxGestorNuevoCambiar = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxGestorAntiguoCambiar = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.PtbLoad = new System.Windows.Forms.PictureBox();
            this.LblNumReTxt = new System.Windows.Forms.Label();
            this.LblNumRegistro = new System.Windows.Forms.Label();
            this.TipAyuda = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.prueba)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PtbLoad)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnArchivo
            // 
            this.BtnArchivo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnArchivo.BackColor = System.Drawing.Color.White;
            this.BtnArchivo.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnArchivo.ForeColor = System.Drawing.Color.Black;
            this.BtnArchivo.Location = new System.Drawing.Point(17, 40);
            this.BtnArchivo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnArchivo.Name = "BtnArchivo";
            this.BtnArchivo.Size = new System.Drawing.Size(107, 46);
            this.BtnArchivo.TabIndex = 1;
            this.BtnArchivo.Text = "BUSCAR ARCHIVO";
            this.BtnArchivo.UseVisualStyleBackColor = false;
            this.BtnArchivo.Click += new System.EventHandler(this.BtnArchivo_Click);
            this.BtnArchivo.MouseHover += new System.EventHandler(this.BtnArchivo_MouseHover);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(132)))), ((int)(((byte)(174)))));
            this.label2.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(206, 44);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "GESTOR :";
            // 
            // BtnCargarArchivo
            // 
            this.BtnCargarArchivo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnCargarArchivo.BackColor = System.Drawing.Color.White;
            this.BtnCargarArchivo.Enabled = false;
            this.BtnCargarArchivo.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCargarArchivo.ForeColor = System.Drawing.Color.Black;
            this.BtnCargarArchivo.Location = new System.Drawing.Point(21, 133);
            this.BtnCargarArchivo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnCargarArchivo.Name = "BtnCargarArchivo";
            this.BtnCargarArchivo.Size = new System.Drawing.Size(107, 46);
            this.BtnCargarArchivo.TabIndex = 3;
            this.BtnCargarArchivo.Text = "CARGAR";
            this.BtnCargarArchivo.UseVisualStyleBackColor = false;
            this.BtnCargarArchivo.Click += new System.EventHandler(this.BtnCargarArchivo_Click);
            this.BtnCargarArchivo.MouseHover += new System.EventHandler(this.BtnCargarArchivo_MouseHover);
            // 
            // BtnEnviarCartera
            // 
            this.BtnEnviarCartera.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnEnviarCartera.BackColor = System.Drawing.Color.White;
            this.BtnEnviarCartera.Enabled = false;
            this.BtnEnviarCartera.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEnviarCartera.ForeColor = System.Drawing.Color.Black;
            this.BtnEnviarCartera.Location = new System.Drawing.Point(262, 71);
            this.BtnEnviarCartera.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnEnviarCartera.Name = "BtnEnviarCartera";
            this.BtnEnviarCartera.Size = new System.Drawing.Size(107, 46);
            this.BtnEnviarCartera.TabIndex = 4;
            this.BtnEnviarCartera.Text = "ENVIAR A CARTERA";
            this.BtnEnviarCartera.UseVisualStyleBackColor = false;
            this.BtnEnviarCartera.Click += new System.EventHandler(this.BtnEnviarCartera_Click);
            this.BtnEnviarCartera.MouseHover += new System.EventHandler(this.BtnEnviarCartera_MouseHover);
            // 
            // CbxGestores
            // 
            this.CbxGestores.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CbxGestores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxGestores.Enabled = false;
            this.CbxGestores.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbxGestores.FormattingEnabled = true;
            this.CbxGestores.Items.AddRange(new object[] {
            ""});
            this.CbxGestores.Location = new System.Drawing.Point(262, 40);
            this.CbxGestores.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CbxGestores.Name = "CbxGestores";
            this.CbxGestores.Size = new System.Drawing.Size(200, 22);
            this.CbxGestores.TabIndex = 5;
            this.CbxGestores.SelectedValueChanged += new System.EventHandler(this.CbxGestores_SelectedValueChanged);
            // 
            // prueba
            // 
            this.prueba.AllowUserToAddRows = false;
            this.prueba.AllowUserToDeleteRows = false;
            this.prueba.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.prueba.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.prueba.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.prueba.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.prueba.GridColor = System.Drawing.Color.White;
            this.prueba.Location = new System.Drawing.Point(21, 201);
            this.prueba.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.prueba.Name = "prueba";
            this.prueba.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.prueba.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.prueba.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.prueba.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            this.prueba.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.prueba.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.prueba.Size = new System.Drawing.Size(182, 302);
            this.prueba.TabIndex = 6;
            // 
            // OpFileBuscarArchivo
            // 
            this.OpFileBuscarArchivo.FileName = "openFileDialog1";
            // 
            // LblRuta
            // 
            this.LblRuta.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LblRuta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(132)))), ((int)(((byte)(174)))));
            this.LblRuta.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRuta.ForeColor = System.Drawing.Color.White;
            this.LblRuta.Location = new System.Drawing.Point(22, 88);
            this.LblRuta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblRuta.Name = "LblRuta";
            this.LblRuta.Size = new System.Drawing.Size(200, 44);
            this.LblRuta.TabIndex = 8;
            this.LblRuta.Text = "Ruta";
            this.LblRuta.Visible = false;
            // 
            // Lblp
            // 
            this.Lblp.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Lblp.AutoSize = true;
            this.Lblp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(132)))), ((int)(((byte)(174)))));
            this.Lblp.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lblp.ForeColor = System.Drawing.Color.White;
            this.Lblp.Location = new System.Drawing.Point(206, 463);
            this.Lblp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lblp.Name = "Lblp";
            this.Lblp.Size = new System.Drawing.Size(27, 22);
            this.Lblp.TabIndex = 9;
            this.Lblp.Text = "Ip";
            this.Lblp.Visible = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox3.Controls.Add(this.BtnCambiarCartera);
            this.groupBox3.Controls.Add(this.cbxGestorNuevoCambiar);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.cbxGestorAntiguoCambiar);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(679, 48);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(450, 522);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "CAMBIAR DE CARTERA";
            // 
            // BtnCambiarCartera
            // 
            this.BtnCambiarCartera.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnCambiarCartera.BackColor = System.Drawing.Color.White;
            this.BtnCambiarCartera.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCambiarCartera.ForeColor = System.Drawing.Color.Black;
            this.BtnCambiarCartera.Location = new System.Drawing.Point(61, 115);
            this.BtnCambiarCartera.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnCambiarCartera.Name = "BtnCambiarCartera";
            this.BtnCambiarCartera.Size = new System.Drawing.Size(107, 46);
            this.BtnCambiarCartera.TabIndex = 14;
            this.BtnCambiarCartera.Text = "CAMBIAR CARTERA";
            this.BtnCambiarCartera.UseVisualStyleBackColor = false;
            this.BtnCambiarCartera.Click += new System.EventHandler(this.BtnCambiarCartera_Click);
            // 
            // cbxGestorNuevoCambiar
            // 
            this.cbxGestorNuevoCambiar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbxGestorNuevoCambiar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxGestorNuevoCambiar.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxGestorNuevoCambiar.FormattingEnabled = true;
            this.cbxGestorNuevoCambiar.Items.AddRange(new object[] {
            ""});
            this.cbxGestorNuevoCambiar.Location = new System.Drawing.Point(162, 73);
            this.cbxGestorNuevoCambiar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbxGestorNuevoCambiar.Name = "cbxGestorNuevoCambiar";
            this.cbxGestorNuevoCambiar.Size = new System.Drawing.Size(200, 22);
            this.cbxGestorNuevoCambiar.TabIndex = 8;
            this.cbxGestorNuevoCambiar.SelectedValueChanged += new System.EventHandler(this.cbxGestorNuevoCambiar_SelectedValueChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(132)))), ((int)(((byte)(174)))));
            this.label3.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(58, 81);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 14);
            this.label3.TabIndex = 7;
            this.label3.Text = "NUEVO GESTOR :";
            // 
            // cbxGestorAntiguoCambiar
            // 
            this.cbxGestorAntiguoCambiar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbxGestorAntiguoCambiar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxGestorAntiguoCambiar.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxGestorAntiguoCambiar.FormattingEnabled = true;
            this.cbxGestorAntiguoCambiar.Items.AddRange(new object[] {
            ""});
            this.cbxGestorAntiguoCambiar.Location = new System.Drawing.Point(162, 41);
            this.cbxGestorAntiguoCambiar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbxGestorAntiguoCambiar.Name = "cbxGestorAntiguoCambiar";
            this.cbxGestorAntiguoCambiar.Size = new System.Drawing.Size(200, 22);
            this.cbxGestorAntiguoCambiar.TabIndex = 6;
            this.cbxGestorAntiguoCambiar.SelectedValueChanged += new System.EventHandler(this.cbxGestorAntiguoCambiar_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(132)))), ((int)(((byte)(174)))));
            this.label1.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(60, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 14);
            this.label1.TabIndex = 3;
            this.label1.Text = "GESTOR :";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox2.Controls.Add(this.PtbLoad);
            this.groupBox2.Controls.Add(this.BtnArchivo);
            this.groupBox2.Controls.Add(this.prueba);
            this.groupBox2.Controls.Add(this.CbxGestores);
            this.groupBox2.Controls.Add(this.BtnCargarArchivo);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.BtnEnviarCartera);
            this.groupBox2.Controls.Add(this.LblRuta);
            this.groupBox2.Controls.Add(this.LblNumReTxt);
            this.groupBox2.Controls.Add(this.LblNumRegistro);
            this.groupBox2.Controls.Add(this.Lblp);
            this.groupBox2.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(194, 48);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(487, 522);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ASIGNAR NUEVA CARTERA";
            // 
            // PtbLoad
            // 
            this.PtbLoad.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PtbLoad.BackColor = System.Drawing.Color.Transparent;
            this.PtbLoad.Image = global::CapaPresentacion.Properties.Resources.icons8_spinner;
            this.PtbLoad.Location = new System.Drawing.Point(210, 134);
            this.PtbLoad.Name = "PtbLoad";
            this.PtbLoad.Size = new System.Drawing.Size(146, 128);
            this.PtbLoad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PtbLoad.TabIndex = 13;
            this.PtbLoad.TabStop = false;
            this.PtbLoad.Visible = false;
            // 
            // LblNumReTxt
            // 
            this.LblNumReTxt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LblNumReTxt.AutoSize = true;
            this.LblNumReTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(132)))), ((int)(((byte)(174)))));
            this.LblNumReTxt.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNumReTxt.ForeColor = System.Drawing.Color.White;
            this.LblNumReTxt.Location = new System.Drawing.Point(22, 183);
            this.LblNumReTxt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblNumReTxt.Name = "LblNumReTxt";
            this.LblNumReTxt.Size = new System.Drawing.Size(100, 14);
            this.LblNumReTxt.TabIndex = 11;
            this.LblNumReTxt.Text = "N° DE REGISTRO :";
            this.LblNumReTxt.Visible = false;
            // 
            // LblNumRegistro
            // 
            this.LblNumRegistro.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LblNumRegistro.AutoSize = true;
            this.LblNumRegistro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(132)))), ((int)(((byte)(174)))));
            this.LblNumRegistro.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNumRegistro.ForeColor = System.Drawing.Color.White;
            this.LblNumRegistro.Location = new System.Drawing.Point(137, 183);
            this.LblNumRegistro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblNumRegistro.Name = "LblNumRegistro";
            this.LblNumRegistro.Size = new System.Drawing.Size(18, 14);
            this.LblNumRegistro.TabIndex = 12;
            this.LblNumRegistro.Text = "Ip";
            this.LblNumRegistro.Visible = false;
            // 
            // TipAyuda
            // 
            this.TipAyuda.AutomaticDelay = 4000;
            this.TipAyuda.AutoPopDelay = 50000;
            this.TipAyuda.InitialDelay = 4000;
            this.TipAyuda.ReshowDelay = 5000;
            // 
            // FrmAsignarMasivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(132)))), ((int)(((byte)(174)))));
            this.ClientSize = new System.Drawing.Size(1373, 773);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmAsignarMasivo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CARTERA MASIVA";
            this.Load += new System.EventHandler(this.FrmAsignarMasivo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.prueba)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PtbLoad)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BtnArchivo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnCargarArchivo;
        private System.Windows.Forms.Button BtnEnviarCartera;
        private System.Windows.Forms.ComboBox CbxGestores;
        public System.Windows.Forms.DataGridView prueba;
        public System.Windows.Forms.OpenFileDialog OpFileBuscarArchivo;
        private System.Windows.Forms.Label LblRuta;
        private System.Windows.Forms.Label Lblp;
        private System.Windows.Forms.Label LblNumRegistro;
        private System.Windows.Forms.Label LblNumReTxt;
        private System.Windows.Forms.PictureBox PtbLoad;
        private System.Windows.Forms.ToolTip TipAyuda;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button BtnCambiarCartera;
        private System.Windows.Forms.ComboBox cbxGestorNuevoCambiar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxGestorAntiguoCambiar;
        private System.Windows.Forms.Label label1;
    }
}