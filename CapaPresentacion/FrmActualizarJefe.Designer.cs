﻿
namespace CapaPresentacion
{
    partial class FrmActualizarJefe
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
            this.BtnActualizarCartera = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CbxGestorNuevo = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItem3 = new DevComponents.Editors.ComboItem();
            this.PtbLoad = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LblMonto = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LblContri = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.LblCodGestor = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.LblCodContri = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ErrorIcono = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PtbLoad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorIcono)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnActualizarCartera
            // 
            this.BtnActualizarCartera.BackColor = System.Drawing.Color.White;
            this.BtnActualizarCartera.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnActualizarCartera.ForeColor = System.Drawing.Color.Black;
            this.BtnActualizarCartera.Location = new System.Drawing.Point(405, 132);
            this.BtnActualizarCartera.Margin = new System.Windows.Forms.Padding(2);
            this.BtnActualizarCartera.Name = "BtnActualizarCartera";
            this.BtnActualizarCartera.Size = new System.Drawing.Size(95, 54);
            this.BtnActualizarCartera.TabIndex = 14;
            this.BtnActualizarCartera.Text = "CAMBIAR";
            this.BtnActualizarCartera.UseVisualStyleBackColor = false;
            this.BtnActualizarCartera.Click += new System.EventHandler(this.BtnActualizarCartera_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(132)))), ((int)(((byte)(174)))));
            this.groupBox2.Controls.Add(this.CbxGestorNuevo);
            this.groupBox2.Controls.Add(this.PtbLoad);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.LblMonto);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.BtnActualizarCartera);
            this.groupBox2.Controls.Add(this.LblContri);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.LblCodGestor);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.LblCodContri);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(7, 6);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(528, 219);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ASIGNAR GESTOR";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // CbxGestorNuevo
            // 
            this.CbxGestorNuevo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CbxGestorNuevo.DisplayMember = "Text";
            this.CbxGestorNuevo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CbxGestorNuevo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxGestorNuevo.FocusHighlightEnabled = true;
            this.CbxGestorNuevo.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbxGestorNuevo.FormattingEnabled = true;
            this.CbxGestorNuevo.ItemHeight = 20;
            this.CbxGestorNuevo.Items.AddRange(new object[] {
            this.comboItem3});
            this.CbxGestorNuevo.Location = new System.Drawing.Point(196, 157);
            this.CbxGestorNuevo.Name = "CbxGestorNuevo";
            this.CbxGestorNuevo.Size = new System.Drawing.Size(193, 26);
            this.CbxGestorNuevo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.CbxGestorNuevo.TabIndex = 75;
            this.CbxGestorNuevo.WatermarkFont = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbxGestorNuevo.WatermarkText = "Todos";
            this.CbxGestorNuevo.SelectedValueChanged += new System.EventHandler(this.CbxGestorNuevo_SelectedValueChanged_1);
            // 
            // PtbLoad
            // 
            this.PtbLoad.Image = global::CapaPresentacion.Properties.Resources.icons8_spinner;
            this.PtbLoad.Location = new System.Drawing.Point(422, 8);
            this.PtbLoad.Name = "PtbLoad";
            this.PtbLoad.Size = new System.Drawing.Size(78, 110);
            this.PtbLoad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PtbLoad.TabIndex = 18;
            this.PtbLoad.TabStop = false;
            this.PtbLoad.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(168, 132);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "S/";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblMonto
            // 
            this.LblMonto.AutoSize = true;
            this.LblMonto.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMonto.ForeColor = System.Drawing.Color.White;
            this.LblMonto.Location = new System.Drawing.Point(194, 132);
            this.LblMonto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblMonto.Name = "LblMonto";
            this.LblMonto.Size = new System.Drawing.Size(46, 17);
            this.LblMonto.TabIndex = 16;
            this.LblMonto.Text = "label8";
            this.LblMonto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(21, 132);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "MONTO :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblContri
            // 
            this.LblContri.AutoSize = true;
            this.LblContri.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblContri.ForeColor = System.Drawing.Color.White;
            this.LblContri.Location = new System.Drawing.Point(194, 40);
            this.LblContri.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblContri.Name = "LblContri";
            this.LblContri.Size = new System.Drawing.Size(54, 17);
            this.LblContri.TabIndex = 9;
            this.LblContri.Text = "label12";
            this.LblContri.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(21, 40);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(131, 17);
            this.label11.TabIndex = 8;
            this.label11.Text = "CONTRIBUYENTE :";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(21, 166);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(153, 17);
            this.label9.TabIndex = 5;
            this.label9.Text = "COD. GESTOR NUEVO :";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblCodGestor
            // 
            this.LblCodGestor.AutoSize = true;
            this.LblCodGestor.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCodGestor.ForeColor = System.Drawing.Color.White;
            this.LblCodGestor.Location = new System.Drawing.Point(194, 101);
            this.LblCodGestor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblCodGestor.Name = "LblCodGestor";
            this.LblCodGestor.Size = new System.Drawing.Size(46, 17);
            this.LblCodGestor.TabIndex = 4;
            this.LblCodGestor.Text = "label8";
            this.LblCodGestor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(21, 101);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 17);
            this.label7.TabIndex = 3;
            this.label7.Text = "COD. GESTOR :";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblCodContri
            // 
            this.LblCodContri.AutoSize = true;
            this.LblCodContri.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCodContri.ForeColor = System.Drawing.Color.White;
            this.LblCodContri.Location = new System.Drawing.Point(194, 70);
            this.LblCodContri.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblCodContri.Name = "LblCodContri";
            this.LblCodContri.Size = new System.Drawing.Size(46, 17);
            this.LblCodContri.TabIndex = 2;
            this.LblCodContri.Text = "label6";
            this.LblCodContri.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(21, 70);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "COD. CONTRIBUYENTE :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ErrorIcono
            // 
            this.ErrorIcono.ContainerControl = this;
            // 
            // FrmActualizarJefe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(132)))), ((int)(((byte)(174)))));
            this.ClientSize = new System.Drawing.Size(542, 234);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "FrmActualizarJefe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmActualizarJefe_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PtbLoad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorIcono)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BtnActualizarCartera;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label LblContri;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label LblCodGestor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label LblCodContri;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ErrorProvider ErrorIcono;
        private System.Windows.Forms.Label LblMonto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox PtbLoad;
        private DevComponents.DotNetBar.Controls.ComboBoxEx CbxGestorNuevo;
        private DevComponents.Editors.ComboItem comboItem3;
    }
}