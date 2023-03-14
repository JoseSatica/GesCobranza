namespace CapaPresentacion
{
    partial class FrmMantenimiento
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
            this.CbxUsuarios = new System.Windows.Forms.ComboBox();
            this.LblGestor = new System.Windows.Forms.Label();
            this.DgvGestores = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnDarPermiso = new System.Windows.Forms.Button();
            this.BtnQuitarPermiso = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgvGestores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CbxUsuarios
            // 
            this.CbxUsuarios.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CbxUsuarios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxUsuarios.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbxUsuarios.FormattingEnabled = true;
            this.CbxUsuarios.Items.AddRange(new object[] {
            ""});
            this.CbxUsuarios.Location = new System.Drawing.Point(126, 73);
            this.CbxUsuarios.Name = "CbxUsuarios";
            this.CbxUsuarios.Size = new System.Drawing.Size(452, 23);
            this.CbxUsuarios.TabIndex = 54;
            this.CbxUsuarios.SelectedValueChanged += new System.EventHandler(this.CbxUsuarios_SelectedValueChanged);
            // 
            // LblGestor
            // 
            this.LblGestor.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LblGestor.AutoSize = true;
            this.LblGestor.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblGestor.ForeColor = System.Drawing.Color.White;
            this.LblGestor.Location = new System.Drawing.Point(52, 81);
            this.LblGestor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblGestor.Name = "LblGestor";
            this.LblGestor.Size = new System.Drawing.Size(67, 15);
            this.LblGestor.TabIndex = 53;
            this.LblGestor.Text = "USUARIOS:";
            // 
            // DgvGestores
            // 
            this.DgvGestores.AllowUserToAddRows = false;
            this.DgvGestores.AllowUserToDeleteRows = false;
            this.DgvGestores.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DgvGestores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DgvGestores.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DgvGestores.BackgroundColor = System.Drawing.Color.White;
            this.DgvGestores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvGestores.Location = new System.Drawing.Point(55, 167);
            this.DgvGestores.Name = "DgvGestores";
            this.DgvGestores.ReadOnly = true;
            this.DgvGestores.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            this.DgvGestores.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvGestores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvGestores.Size = new System.Drawing.Size(523, 233);
            this.DgvGestores.TabIndex = 57;
            this.DgvGestores.Sorted += new System.EventHandler(this.DgvGestores_Sorted);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(52, 149);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 15);
            this.label2.TabIndex = 59;
            this.label2.Text = "LISTA DE GESTORES:";
            // 
            // BtnDarPermiso
            // 
            this.BtnDarPermiso.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnDarPermiso.BackColor = System.Drawing.Color.GhostWhite;
            this.BtnDarPermiso.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDarPermiso.ForeColor = System.Drawing.Color.Black;
            this.BtnDarPermiso.Location = new System.Drawing.Point(601, 279);
            this.BtnDarPermiso.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnDarPermiso.Name = "BtnDarPermiso";
            this.BtnDarPermiso.Size = new System.Drawing.Size(99, 59);
            this.BtnDarPermiso.TabIndex = 60;
            this.BtnDarPermiso.Text = "DAR PERMISO";
            this.BtnDarPermiso.UseVisualStyleBackColor = false;
            this.BtnDarPermiso.Visible = false;
            this.BtnDarPermiso.Click += new System.EventHandler(this.BtnDarPermiso_Click);
            // 
            // BtnQuitarPermiso
            // 
            this.BtnQuitarPermiso.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnQuitarPermiso.BackColor = System.Drawing.Color.GhostWhite;
            this.BtnQuitarPermiso.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnQuitarPermiso.ForeColor = System.Drawing.Color.Black;
            this.BtnQuitarPermiso.Location = new System.Drawing.Point(601, 344);
            this.BtnQuitarPermiso.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnQuitarPermiso.Name = "BtnQuitarPermiso";
            this.BtnQuitarPermiso.Size = new System.Drawing.Size(99, 59);
            this.BtnQuitarPermiso.TabIndex = 61;
            this.BtnQuitarPermiso.Text = "QUITAR PERMISO";
            this.BtnQuitarPermiso.UseVisualStyleBackColor = false;
            this.BtnQuitarPermiso.Visible = false;
            this.BtnQuitarPermiso.Click += new System.EventHandler(this.BtnQuitarPermiso_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(94, 417);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 15);
            this.label1.TabIndex = 64;
            this.label1.Text = "SIN PERMISO";
            this.label1.Visible = false;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(94, 453);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 15);
            this.label3.TabIndex = 65;
            this.label3.Text = "CON PERMISO";
            this.label3.Visible = false;
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnEliminar.BackColor = System.Drawing.Color.GhostWhite;
            this.BtnEliminar.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminar.ForeColor = System.Drawing.Color.Black;
            this.BtnEliminar.Image = global::CapaPresentacion.Properties.Resources.quitar_usuario_para_boton;
            this.BtnEliminar.Location = new System.Drawing.Point(601, 167);
            this.BtnEliminar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(98, 75);
            this.BtnEliminar.TabIndex = 66;
            this.BtnEliminar.Text = "ELIMINAR";
            this.BtnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnEliminar.UseVisualStyleBackColor = false;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox2.BackColor = System.Drawing.Color.DodgerBlue;
            this.pictureBox2.Location = new System.Drawing.Point(55, 442);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 28);
            this.pictureBox2.TabIndex = 63;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.BackColor = System.Drawing.Color.Crimson;
            this.pictureBox1.Location = new System.Drawing.Point(55, 406);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 28);
            this.pictureBox1.TabIndex = 62;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnAgregar.BackColor = System.Drawing.Color.GhostWhite;
            this.BtnAgregar.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregar.ForeColor = System.Drawing.Color.Black;
            this.BtnAgregar.Image = global::CapaPresentacion.Properties.Resources.agregar_usuario_para_boton;
            this.BtnAgregar.Location = new System.Drawing.Point(600, 46);
            this.BtnAgregar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(99, 75);
            this.BtnAgregar.TabIndex = 58;
            this.BtnAgregar.Text = "AGREGAR";
            this.BtnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnAgregar.UseVisualStyleBackColor = false;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.BtnEliminar);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.BtnQuitarPermiso);
            this.groupBox1.Controls.Add(this.BtnDarPermiso);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.BtnAgregar);
            this.groupBox1.Controls.Add(this.DgvGestores);
            this.groupBox1.Controls.Add(this.CbxUsuarios);
            this.groupBox1.Controls.Add(this.LblGestor);
            this.groupBox1.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(244, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(759, 498);
            this.groupBox1.TabIndex = 67;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "MANTENIMIENTO";
            // 
            // FrmMantenimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(132)))), ((int)(((byte)(174)))));
            this.ClientSize = new System.Drawing.Size(1214, 558);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMantenimiento";
            this.Text = "FrmMantenimiento";
            this.Load += new System.EventHandler(this.FrmMantenimiento_Load);
            this.Shown += new System.EventHandler(this.FrmMantenimiento_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.DgvGestores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox CbxUsuarios;
        public System.Windows.Forms.Label LblGestor;
        private System.Windows.Forms.DataGridView DgvGestores;
        private System.Windows.Forms.Button BtnAgregar;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnDarPermiso;
        private System.Windows.Forms.Button BtnQuitarPermiso;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}