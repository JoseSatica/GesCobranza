namespace CapaPresentacion
{
    partial class FrmCarteraDetalle
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
            this.DgvCarteraDetalle = new System.Windows.Forms.DataGridView();
            this.LblCodigo = new System.Windows.Forms.Label();
            this.LblNombre = new System.Windows.Forms.Label();
            this.LblConcepto = new System.Windows.Forms.Label();
            this.LblMonto = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtFechaPorGestionar = new PlaceholderTextBox.PlaceholderTextBox();
            this.TxtObserNoti = new PlaceholderTextBox.PlaceholderTextBox();
            this.TxtNomPersNoti = new PlaceholderTextBox.PlaceholderTextBox();
            this.TxtDniPersNoti = new PlaceholderTextBox.PlaceholderTextBox();
            this.TxtEdadPersNoti = new PlaceholderTextBox.PlaceholderTextBox();
            this.TxtParentPersNoti = new PlaceholderTextBox.PlaceholderTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCarteraDetalle)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // DgvCarteraDetalle
            // 
            this.DgvCarteraDetalle.AllowUserToAddRows = false;
            this.DgvCarteraDetalle.AllowUserToDeleteRows = false;
            this.DgvCarteraDetalle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DgvCarteraDetalle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DgvCarteraDetalle.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DgvCarteraDetalle.BackgroundColor = System.Drawing.Color.White;
            this.DgvCarteraDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvCarteraDetalle.Location = new System.Drawing.Point(28, 37);
            this.DgvCarteraDetalle.Name = "DgvCarteraDetalle";
            this.DgvCarteraDetalle.ReadOnly = true;
            this.DgvCarteraDetalle.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvCarteraDetalle.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvCarteraDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvCarteraDetalle.Size = new System.Drawing.Size(1099, 175);
            this.DgvCarteraDetalle.TabIndex = 0;
            this.DgvCarteraDetalle.SelectionChanged += new System.EventHandler(this.DgvCarteraDetalle_SelectionChanged);
            this.DgvCarteraDetalle.Sorted += new System.EventHandler(this.DgvCarteraDetalle_Sorted);
            // 
            // LblCodigo
            // 
            this.LblCodigo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LblCodigo.AutoSize = true;
            this.LblCodigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(132)))), ((int)(((byte)(174)))));
            this.LblCodigo.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCodigo.ForeColor = System.Drawing.Color.White;
            this.LblCodigo.Location = new System.Drawing.Point(26, 20);
            this.LblCodigo.Name = "LblCodigo";
            this.LblCodigo.Size = new System.Drawing.Size(45, 15);
            this.LblCodigo.TabIndex = 1;
            this.LblCodigo.Text = "Codigo";
            // 
            // LblNombre
            // 
            this.LblNombre.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LblNombre.AutoSize = true;
            this.LblNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(132)))), ((int)(((byte)(174)))));
            this.LblNombre.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombre.ForeColor = System.Drawing.Color.White;
            this.LblNombre.Location = new System.Drawing.Point(108, 20);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(52, 15);
            this.LblNombre.TabIndex = 2;
            this.LblNombre.Text = "Nombre";
            // 
            // LblConcepto
            // 
            this.LblConcepto.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LblConcepto.AutoSize = true;
            this.LblConcepto.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblConcepto.ForeColor = System.Drawing.Color.White;
            this.LblConcepto.Location = new System.Drawing.Point(998, 19);
            this.LblConcepto.Name = "LblConcepto";
            this.LblConcepto.Size = new System.Drawing.Size(22, 15);
            this.LblConcepto.TabIndex = 3;
            this.LblConcepto.Text = "S/.";
            // 
            // LblMonto
            // 
            this.LblMonto.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LblMonto.AutoSize = true;
            this.LblMonto.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMonto.ForeColor = System.Drawing.Color.White;
            this.LblMonto.Location = new System.Drawing.Point(1038, 19);
            this.LblMonto.Name = "LblMonto";
            this.LblMonto.Size = new System.Drawing.Size(43, 15);
            this.LblMonto.TabIndex = 4;
            this.LblMonto.Text = "Monto";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(132)))), ((int)(((byte)(174)))));
            this.groupBox1.Controls.Add(this.LblConcepto);
            this.groupBox1.Controls.Add(this.LblCodigo);
            this.groupBox1.Controls.Add(this.LblNombre);
            this.groupBox1.Controls.Add(this.LblMonto);
            this.groupBox1.Controls.Add(this.DgvCarteraDetalle);
            this.groupBox1.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(49, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1171, 219);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "FLUJO DE GESTION";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(132)))), ((int)(((byte)(174)))));
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(49, 232);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1171, 414);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DETALLE DE LA GESTION";
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(132)))), ((int)(((byte)(174)))));
            this.groupBox5.Controls.Add(this.TxtObserNoti);
            this.groupBox5.Controls.Add(this.TxtFechaPorGestionar);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Controls.Add(this.label17);
            this.groupBox5.Font = new System.Drawing.Font("Cambria", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(18, 22);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(1138, 184);
            this.groupBox5.TabIndex = 10;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "GESTION";
            this.groupBox5.Enter += new System.EventHandler(this.groupBox5_Enter);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(491, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 15);
            this.label1.TabIndex = 26;
            this.label1.Text = "FECHA POR GESTIONAR :";
            // 
            // label17
            // 
            this.label17.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(31, 23);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(94, 15);
            this.label17.TabIndex = 18;
            this.label17.Text = "OBSERVACION :";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(132)))), ((int)(((byte)(174)))));
            this.groupBox3.Controls.Add(this.TxtParentPersNoti);
            this.groupBox3.Controls.Add(this.TxtEdadPersNoti);
            this.groupBox3.Controls.Add(this.TxtDniPersNoti);
            this.groupBox3.Controls.Add(this.TxtNomPersNoti);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Font = new System.Drawing.Font("Cambria", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(18, 212);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1138, 186);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "DATOS DE LA PERSONA";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(31, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "EDAD :";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(32, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(156, 15);
            this.label6.TabIndex = 2;
            this.label6.Text = "PARENTESCO Y/O CARGO :";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(31, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "DNI :";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(31, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "NOMBRE COMPLETO :";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // TxtFechaPorGestionar
            // 
            this.TxtFechaPorGestionar.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtFechaPorGestionar.Location = new System.Drawing.Point(645, 44);
            this.TxtFechaPorGestionar.Name = "TxtFechaPorGestionar";
            this.TxtFechaPorGestionar.PlaceholderText = "Fecha por Gestionar";
            this.TxtFechaPorGestionar.Size = new System.Drawing.Size(259, 23);
            this.TxtFechaPorGestionar.TabIndex = 28;
            // 
            // TxtObserNoti
            // 
            this.TxtObserNoti.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtObserNoti.Location = new System.Drawing.Point(34, 44);
            this.TxtObserNoti.Multiline = true;
            this.TxtObserNoti.Name = "TxtObserNoti";
            this.TxtObserNoti.PlaceholderText = "Observacion";
            this.TxtObserNoti.Size = new System.Drawing.Size(335, 116);
            this.TxtObserNoti.TabIndex = 29;
            // 
            // TxtNomPersNoti
            // 
            this.TxtNomPersNoti.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNomPersNoti.Location = new System.Drawing.Point(190, 41);
            this.TxtNomPersNoti.Name = "TxtNomPersNoti";
            this.TxtNomPersNoti.PlaceholderText = "Nombre Completo";
            this.TxtNomPersNoti.Size = new System.Drawing.Size(510, 23);
            this.TxtNomPersNoti.TabIndex = 30;
            // 
            // TxtDniPersNoti
            // 
            this.TxtDniPersNoti.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDniPersNoti.Location = new System.Drawing.Point(190, 70);
            this.TxtDniPersNoti.Name = "TxtDniPersNoti";
            this.TxtDniPersNoti.PlaceholderText = "DNI";
            this.TxtDniPersNoti.Size = new System.Drawing.Size(107, 23);
            this.TxtDniPersNoti.TabIndex = 31;
            // 
            // TxtEdadPersNoti
            // 
            this.TxtEdadPersNoti.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEdadPersNoti.Location = new System.Drawing.Point(190, 99);
            this.TxtEdadPersNoti.Name = "TxtEdadPersNoti";
            this.TxtEdadPersNoti.PlaceholderText = "Edad";
            this.TxtEdadPersNoti.Size = new System.Drawing.Size(107, 23);
            this.TxtEdadPersNoti.TabIndex = 32;
            // 
            // TxtParentPersNoti
            // 
            this.TxtParentPersNoti.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtParentPersNoti.Location = new System.Drawing.Point(190, 134);
            this.TxtParentPersNoti.Name = "TxtParentPersNoti";
            this.TxtParentPersNoti.PlaceholderText = "Parentesco y/o Cargo";
            this.TxtParentPersNoti.Size = new System.Drawing.Size(510, 23);
            this.TxtParentPersNoti.TabIndex = 33;
            // 
            // FrmCarteraDetalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(132)))), ((int)(((byte)(174)))));
            this.ClientSize = new System.Drawing.Size(1259, 654);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCarteraDetalle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DETALLE";
            this.Load += new System.EventHandler(this.FrmCarteraDetalle_Load);
            this.Shown += new System.EventHandler(this.FrmCarteraDetalle_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.DgvCarteraDetalle)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvCarteraDetalle;
        private System.Windows.Forms.Label LblCodigo;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.Label LblConcepto;
        private System.Windows.Forms.Label LblMonto;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private PlaceholderTextBox.PlaceholderTextBox TxtObserNoti;
        private PlaceholderTextBox.PlaceholderTextBox TxtFechaPorGestionar;
        private PlaceholderTextBox.PlaceholderTextBox TxtParentPersNoti;
        private PlaceholderTextBox.PlaceholderTextBox TxtEdadPersNoti;
        private PlaceholderTextBox.PlaceholderTextBox TxtDniPersNoti;
        private PlaceholderTextBox.PlaceholderTextBox TxtNomPersNoti;
    }
}