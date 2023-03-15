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
            this.TxtFechaPorGestionar = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label1 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.TxtObserNoti = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.TxtParentPersNoti = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.TxtEdadPersNoti = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.TxtDniPersNoti = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.TxtNomPersNoti = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
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
            this.DgvCarteraDetalle.Location = new System.Drawing.Point(28, 49);
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
            this.DgvCarteraDetalle.Size = new System.Drawing.Size(1099, 161);
            this.DgvCarteraDetalle.TabIndex = 0;
            this.DgvCarteraDetalle.SelectionChanged += new System.EventHandler(this.DgvCarteraDetalle_SelectionChanged);
            this.DgvCarteraDetalle.Sorted += new System.EventHandler(this.DgvCarteraDetalle_Sorted);
            // 
            // LblCodigo
            // 
            this.LblCodigo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LblCodigo.AutoSize = true;
            this.LblCodigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(132)))), ((int)(((byte)(174)))));
            this.LblCodigo.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCodigo.ForeColor = System.Drawing.Color.White;
            this.LblCodigo.Location = new System.Drawing.Point(33, 29);
            this.LblCodigo.Name = "LblCodigo";
            this.LblCodigo.Size = new System.Drawing.Size(51, 17);
            this.LblCodigo.TabIndex = 1;
            this.LblCodigo.Text = "Codigo";
            // 
            // LblNombre
            // 
            this.LblNombre.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LblNombre.AutoSize = true;
            this.LblNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(132)))), ((int)(((byte)(174)))));
            this.LblNombre.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombre.ForeColor = System.Drawing.Color.White;
            this.LblNombre.Location = new System.Drawing.Point(115, 29);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(59, 17);
            this.LblNombre.TabIndex = 2;
            this.LblNombre.Text = "Nombre";
            // 
            // LblConcepto
            // 
            this.LblConcepto.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LblConcepto.AutoSize = true;
            this.LblConcepto.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblConcepto.ForeColor = System.Drawing.Color.White;
            this.LblConcepto.Location = new System.Drawing.Point(1005, 28);
            this.LblConcepto.Name = "LblConcepto";
            this.LblConcepto.Size = new System.Drawing.Size(25, 17);
            this.LblConcepto.TabIndex = 3;
            this.LblConcepto.Text = "S/.";
            // 
            // LblMonto
            // 
            this.LblMonto.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LblMonto.AutoSize = true;
            this.LblMonto.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMonto.ForeColor = System.Drawing.Color.White;
            this.LblMonto.Location = new System.Drawing.Point(1045, 28);
            this.LblMonto.Name = "LblMonto";
            this.LblMonto.Size = new System.Drawing.Size(49, 17);
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
            this.groupBox1.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.groupBox2.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.groupBox5.Controls.Add(this.TxtFechaPorGestionar);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Controls.Add(this.label17);
            this.groupBox5.Controls.Add(this.TxtObserNoti);
            this.groupBox5.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(18, 22);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(1138, 184);
            this.groupBox5.TabIndex = 10;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "GESTION";
            this.groupBox5.Enter += new System.EventHandler(this.groupBox5_Enter);
            // 
            // TxtFechaPorGestionar
            // 
            this.TxtFechaPorGestionar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            // 
            // 
            // 
            this.TxtFechaPorGestionar.Border.Class = "TextBoxBorder";
            this.TxtFechaPorGestionar.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TxtFechaPorGestionar.FocusHighlightEnabled = true;
            this.TxtFechaPorGestionar.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtFechaPorGestionar.Location = new System.Drawing.Point(711, 25);
            this.TxtFechaPorGestionar.Name = "TxtFechaPorGestionar";
            this.TxtFechaPorGestionar.PreventEnterBeep = true;
            this.TxtFechaPorGestionar.ReadOnly = true;
            this.TxtFechaPorGestionar.Size = new System.Drawing.Size(192, 25);
            this.TxtFechaPorGestionar.TabIndex = 77;
            this.TxtFechaPorGestionar.WatermarkFont = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtFechaPorGestionar.WatermarkText = "Fecha Por Gestionar";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(532, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 17);
            this.label1.TabIndex = 26;
            this.label1.Text = "FECHA POR GESTIONAR :";
            // 
            // label17
            // 
            this.label17.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(31, 23);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(108, 17);
            this.label17.TabIndex = 18;
            this.label17.Text = "OBSERVACION :";
            // 
            // TxtObserNoti
            // 
            this.TxtObserNoti.Anchor = System.Windows.Forms.AnchorStyles.Top;
            // 
            // 
            // 
            this.TxtObserNoti.Border.Class = "TextBoxBorder";
            this.TxtObserNoti.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TxtObserNoti.FocusHighlightEnabled = true;
            this.TxtObserNoti.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtObserNoti.Location = new System.Drawing.Point(145, 25);
            this.TxtObserNoti.Multiline = true;
            this.TxtObserNoti.Name = "TxtObserNoti";
            this.TxtObserNoti.PreventEnterBeep = true;
            this.TxtObserNoti.ReadOnly = true;
            this.TxtObserNoti.Size = new System.Drawing.Size(363, 118);
            this.TxtObserNoti.TabIndex = 77;
            this.TxtObserNoti.WatermarkFont = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtObserNoti.WatermarkText = "Observacion";
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
            this.groupBox3.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(18, 212);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1138, 186);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "DATOS DE LA PERSONA";
            // 
            // TxtParentPersNoti
            // 
            this.TxtParentPersNoti.Anchor = System.Windows.Forms.AnchorStyles.Top;
            // 
            // 
            // 
            this.TxtParentPersNoti.Border.Class = "TextBoxBorder";
            this.TxtParentPersNoti.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TxtParentPersNoti.FocusHighlightEnabled = true;
            this.TxtParentPersNoti.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtParentPersNoti.Location = new System.Drawing.Point(220, 140);
            this.TxtParentPersNoti.Name = "TxtParentPersNoti";
            this.TxtParentPersNoti.PreventEnterBeep = true;
            this.TxtParentPersNoti.ReadOnly = true;
            this.TxtParentPersNoti.Size = new System.Drawing.Size(469, 25);
            this.TxtParentPersNoti.TabIndex = 76;
            this.TxtParentPersNoti.WatermarkFont = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtParentPersNoti.WatermarkText = "Parentesco y/o Cargo";
            // 
            // TxtEdadPersNoti
            // 
            this.TxtEdadPersNoti.Anchor = System.Windows.Forms.AnchorStyles.Top;
            // 
            // 
            // 
            this.TxtEdadPersNoti.Border.Class = "TextBoxBorder";
            this.TxtEdadPersNoti.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TxtEdadPersNoti.FocusHighlightEnabled = true;
            this.TxtEdadPersNoti.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEdadPersNoti.Location = new System.Drawing.Point(220, 107);
            this.TxtEdadPersNoti.Name = "TxtEdadPersNoti";
            this.TxtEdadPersNoti.PreventEnterBeep = true;
            this.TxtEdadPersNoti.ReadOnly = true;
            this.TxtEdadPersNoti.Size = new System.Drawing.Size(107, 25);
            this.TxtEdadPersNoti.TabIndex = 75;
            this.TxtEdadPersNoti.WatermarkFont = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEdadPersNoti.WatermarkText = "Edad";
            // 
            // TxtDniPersNoti
            // 
            this.TxtDniPersNoti.Anchor = System.Windows.Forms.AnchorStyles.Top;
            // 
            // 
            // 
            this.TxtDniPersNoti.Border.Class = "TextBoxBorder";
            this.TxtDniPersNoti.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TxtDniPersNoti.FocusHighlightEnabled = true;
            this.TxtDniPersNoti.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDniPersNoti.Location = new System.Drawing.Point(220, 76);
            this.TxtDniPersNoti.Name = "TxtDniPersNoti";
            this.TxtDniPersNoti.PreventEnterBeep = true;
            this.TxtDniPersNoti.ReadOnly = true;
            this.TxtDniPersNoti.Size = new System.Drawing.Size(107, 25);
            this.TxtDniPersNoti.TabIndex = 74;
            this.TxtDniPersNoti.WatermarkFont = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDniPersNoti.WatermarkText = "DNI";
            // 
            // TxtNomPersNoti
            // 
            this.TxtNomPersNoti.Anchor = System.Windows.Forms.AnchorStyles.Top;
            // 
            // 
            // 
            this.TxtNomPersNoti.Border.Class = "TextBoxBorder";
            this.TxtNomPersNoti.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TxtNomPersNoti.FocusHighlightEnabled = true;
            this.TxtNomPersNoti.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNomPersNoti.Location = new System.Drawing.Point(220, 44);
            this.TxtNomPersNoti.Name = "TxtNomPersNoti";
            this.TxtNomPersNoti.PreventEnterBeep = true;
            this.TxtNomPersNoti.ReadOnly = true;
            this.TxtNomPersNoti.Size = new System.Drawing.Size(469, 25);
            this.TxtNomPersNoti.TabIndex = 73;
            this.TxtNomPersNoti.WatermarkFont = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNomPersNoti.WatermarkText = "Nombre Completo";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(31, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "EDAD :";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(32, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(180, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "PARENTESCO Y/O CARGO :";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(31, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "DNI :";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(31, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "NOMBRE COMPLETO :";
            this.label4.Click += new System.EventHandler(this.label4_Click);
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
        private DevComponents.DotNetBar.Controls.TextBoxX TxtFechaPorGestionar;
        private DevComponents.DotNetBar.Controls.TextBoxX TxtObserNoti;
        private DevComponents.DotNetBar.Controls.TextBoxX TxtParentPersNoti;
        private DevComponents.DotNetBar.Controls.TextBoxX TxtEdadPersNoti;
        private DevComponents.DotNetBar.Controls.TextBoxX TxtDniPersNoti;
        private DevComponents.DotNetBar.Controls.TextBoxX TxtNomPersNoti;
    }
}