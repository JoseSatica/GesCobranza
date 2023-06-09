﻿namespace CapaPresentacion
{
    partial class FrmCarteraGestionDetalle
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
            this.LblCodContri = new System.Windows.Forms.Label();
            this.LblNomContri = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gbxPersona = new System.Windows.Forms.GroupBox();
            this.TxtParentPersNoti = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.TxtEdadPersNoti = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.TxtDniPersNoti = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.TxtNomPersNoti = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblObservacion = new System.Windows.Forms.Label();
            this.BtnGrabar = new System.Windows.Forms.Button();
            this.lblSeguimiento = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.CbxSeguimiento = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItem2 = new DevComponents.Editors.ComboItem();
            this.TxtObserNoti = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.PtbLoad = new System.Windows.Forms.PictureBox();
            this.DtpPorGestionar = new System.Windows.Forms.DateTimePicker();
            this.lblFechaPorGestionar = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.EpSeguimiento = new System.Windows.Forms.ErrorProvider(this.components);
            this.EpObservacion = new System.Windows.Forms.ErrorProvider(this.components);
            this.TipAyuda = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.gbxPersona.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PtbLoad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EpSeguimiento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EpObservacion)).BeginInit();
            this.SuspendLayout();
            // 
            // LblCodContri
            // 
            this.LblCodContri.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LblCodContri.AutoSize = true;
            this.LblCodContri.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCodContri.ForeColor = System.Drawing.Color.White;
            this.LblCodContri.Location = new System.Drawing.Point(28, 33);
            this.LblCodContri.Name = "LblCodContri";
            this.LblCodContri.Size = new System.Drawing.Size(71, 17);
            this.LblCodContri.TabIndex = 1;
            this.LblCodContri.Text = "CodContri";
            // 
            // LblNomContri
            // 
            this.LblNomContri.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LblNomContri.AutoSize = true;
            this.LblNomContri.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNomContri.ForeColor = System.Drawing.Color.White;
            this.LblNomContri.Location = new System.Drawing.Point(151, 33);
            this.LblNomContri.Name = "LblNomContri";
            this.LblNomContri.Size = new System.Drawing.Size(77, 17);
            this.LblNomContri.TabIndex = 2;
            this.LblNomContri.Text = "NomContri";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(132)))), ((int)(((byte)(174)))));
            this.groupBox1.Controls.Add(this.LblNomContri);
            this.groupBox1.Controls.Add(this.LblCodContri);
            this.groupBox1.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1179, 63);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DATOS DEL CONTRIBUYENTE";
            // 
            // gbxPersona
            // 
            this.gbxPersona.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gbxPersona.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(132)))), ((int)(((byte)(174)))));
            this.gbxPersona.Controls.Add(this.TxtParentPersNoti);
            this.gbxPersona.Controls.Add(this.TxtEdadPersNoti);
            this.gbxPersona.Controls.Add(this.TxtDniPersNoti);
            this.gbxPersona.Controls.Add(this.TxtNomPersNoti);
            this.gbxPersona.Controls.Add(this.label7);
            this.gbxPersona.Controls.Add(this.label6);
            this.gbxPersona.Controls.Add(this.label5);
            this.gbxPersona.Controls.Add(this.label4);
            this.gbxPersona.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxPersona.Location = new System.Drawing.Point(12, 301);
            this.gbxPersona.Name = "gbxPersona";
            this.gbxPersona.Size = new System.Drawing.Size(1179, 186);
            this.gbxPersona.TabIndex = 4;
            this.gbxPersona.TabStop = false;
            this.gbxPersona.Text = "DATOS DE LA PERSONA";
            this.gbxPersona.MouseHover += new System.EventHandler(this.gbxPersona_MouseHover);
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
            this.TxtParentPersNoti.Location = new System.Drawing.Point(213, 127);
            this.TxtParentPersNoti.Name = "TxtParentPersNoti";
            this.TxtParentPersNoti.PreventEnterBeep = true;
            this.TxtParentPersNoti.Size = new System.Drawing.Size(469, 25);
            this.TxtParentPersNoti.TabIndex = 71;
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
            this.TxtEdadPersNoti.Location = new System.Drawing.Point(213, 94);
            this.TxtEdadPersNoti.Name = "TxtEdadPersNoti";
            this.TxtEdadPersNoti.PreventEnterBeep = true;
            this.TxtEdadPersNoti.Size = new System.Drawing.Size(107, 25);
            this.TxtEdadPersNoti.TabIndex = 70;
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
            this.TxtDniPersNoti.Location = new System.Drawing.Point(213, 63);
            this.TxtDniPersNoti.Name = "TxtDniPersNoti";
            this.TxtDniPersNoti.PreventEnterBeep = true;
            this.TxtDniPersNoti.Size = new System.Drawing.Size(107, 25);
            this.TxtDniPersNoti.TabIndex = 69;
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
            this.TxtNomPersNoti.Location = new System.Drawing.Point(213, 31);
            this.TxtNomPersNoti.Name = "TxtNomPersNoti";
            this.TxtNomPersNoti.PreventEnterBeep = true;
            this.TxtNomPersNoti.Size = new System.Drawing.Size(469, 25);
            this.TxtNomPersNoti.TabIndex = 68;
            this.TxtNomPersNoti.WatermarkFont = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNomPersNoti.WatermarkText = "Nombre Completo";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(28, 103);
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
            this.label6.Location = new System.Drawing.Point(28, 135);
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
            this.label5.Location = new System.Drawing.Point(28, 71);
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
            this.label4.Location = new System.Drawing.Point(28, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "NOMBRE COMPLETO :";
            // 
            // lblObservacion
            // 
            this.lblObservacion.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblObservacion.AutoSize = true;
            this.lblObservacion.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObservacion.ForeColor = System.Drawing.Color.White;
            this.lblObservacion.Location = new System.Drawing.Point(541, 46);
            this.lblObservacion.Name = "lblObservacion";
            this.lblObservacion.Size = new System.Drawing.Size(126, 17);
            this.lblObservacion.TabIndex = 18;
            this.lblObservacion.Text = "OBSERVACION(*) :";
            this.lblObservacion.MouseHover += new System.EventHandler(this.lblObservacion_MouseHover);
            // 
            // BtnGrabar
            // 
            this.BtnGrabar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnGrabar.BackColor = System.Drawing.Color.White;
            this.BtnGrabar.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGrabar.ForeColor = System.Drawing.Color.Black;
            this.BtnGrabar.Location = new System.Drawing.Point(1058, 46);
            this.BtnGrabar.Name = "BtnGrabar";
            this.BtnGrabar.Size = new System.Drawing.Size(104, 59);
            this.BtnGrabar.TabIndex = 7;
            this.BtnGrabar.Text = "GRABAR";
            this.BtnGrabar.UseVisualStyleBackColor = false;
            this.BtnGrabar.Click += new System.EventHandler(this.BtnGrabar_Click);
            this.BtnGrabar.MouseHover += new System.EventHandler(this.BtnGrabar_MouseHover);
            // 
            // lblSeguimiento
            // 
            this.lblSeguimiento.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblSeguimiento.AutoSize = true;
            this.lblSeguimiento.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeguimiento.ForeColor = System.Drawing.Color.White;
            this.lblSeguimiento.Location = new System.Drawing.Point(28, 49);
            this.lblSeguimiento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSeguimiento.Name = "lblSeguimiento";
            this.lblSeguimiento.Size = new System.Drawing.Size(131, 17);
            this.lblSeguimiento.TabIndex = 16;
            this.lblSeguimiento.Text = "SEGUIMIENTO(*) : ";
            this.lblSeguimiento.MouseHover += new System.EventHandler(this.lblSeguimiento_MouseHover);
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox5.Controls.Add(this.CbxSeguimiento);
            this.groupBox5.Controls.Add(this.TxtObserNoti);
            this.groupBox5.Controls.Add(this.PtbLoad);
            this.groupBox5.Controls.Add(this.DtpPorGestionar);
            this.groupBox5.Controls.Add(this.lblFechaPorGestionar);
            this.groupBox5.Controls.Add(this.lblSeguimiento);
            this.groupBox5.Controls.Add(this.BtnGrabar);
            this.groupBox5.Controls.Add(this.lblObservacion);
            this.groupBox5.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(12, 122);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(1179, 173);
            this.groupBox5.TabIndex = 18;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "ACTUALIZAR GESTION";
            this.groupBox5.Enter += new System.EventHandler(this.groupBox5_Enter);
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
            this.CbxSeguimiento.Location = new System.Drawing.Point(251, 40);
            this.CbxSeguimiento.Name = "CbxSeguimiento";
            this.CbxSeguimiento.Size = new System.Drawing.Size(213, 26);
            this.CbxSeguimiento.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.CbxSeguimiento.TabIndex = 73;
            this.CbxSeguimiento.WatermarkFont = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbxSeguimiento.WatermarkText = "Todos";
            this.CbxSeguimiento.SelectedValueChanged += new System.EventHandler(this.CbxSeguimiento_SelectedValueChanged_1);
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
            this.TxtObserNoti.Location = new System.Drawing.Point(673, 44);
            this.TxtObserNoti.Multiline = true;
            this.TxtObserNoti.Name = "TxtObserNoti";
            this.TxtObserNoti.PreventEnterBeep = true;
            this.TxtObserNoti.Size = new System.Drawing.Size(363, 106);
            this.TxtObserNoti.TabIndex = 72;
            this.TxtObserNoti.WatermarkFont = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtObserNoti.WatermarkText = "Observacion";
            // 
            // PtbLoad
            // 
            this.PtbLoad.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PtbLoad.BackColor = System.Drawing.Color.Transparent;
            this.PtbLoad.Image = global::CapaPresentacion.Properties.Resources.icons8_spinner;
            this.PtbLoad.Location = new System.Drawing.Point(470, 66);
            this.PtbLoad.Name = "PtbLoad";
            this.PtbLoad.Size = new System.Drawing.Size(163, 101);
            this.PtbLoad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PtbLoad.TabIndex = 28;
            this.PtbLoad.TabStop = false;
            this.PtbLoad.Visible = false;
            // 
            // DtpPorGestionar
            // 
            this.DtpPorGestionar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DtpPorGestionar.CalendarFont = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpPorGestionar.Checked = false;
            this.DtpPorGestionar.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpPorGestionar.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpPorGestionar.Location = new System.Drawing.Point(251, 86);
            this.DtpPorGestionar.Name = "DtpPorGestionar";
            this.DtpPorGestionar.ShowCheckBox = true;
            this.DtpPorGestionar.Size = new System.Drawing.Size(213, 25);
            this.DtpPorGestionar.TabIndex = 27;
            // 
            // lblFechaPorGestionar
            // 
            this.lblFechaPorGestionar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblFechaPorGestionar.AutoSize = true;
            this.lblFechaPorGestionar.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaPorGestionar.ForeColor = System.Drawing.Color.White;
            this.lblFechaPorGestionar.Location = new System.Drawing.Point(28, 93);
            this.lblFechaPorGestionar.Name = "lblFechaPorGestionar";
            this.lblFechaPorGestionar.Size = new System.Drawing.Size(217, 17);
            this.lblFechaPorGestionar.TabIndex = 26;
            this.lblFechaPorGestionar.Text = "FECHA PROXIMA A GESTIONAR :";
            this.lblFechaPorGestionar.MouseHover += new System.EventHandler(this.lblFechaPorGestionar_MouseHover);
            // 
            // label21
            // 
            this.label21.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.White;
            this.label21.Location = new System.Drawing.Point(12, 499);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(186, 17);
            this.label21.TabIndex = 19;
            this.label21.Text = "CAMPOS OBLIGATORIOS (*)";
            // 
            // EpSeguimiento
            // 
            this.EpSeguimiento.ContainerControl = this;
            // 
            // EpObservacion
            // 
            this.EpObservacion.ContainerControl = this;
            // 
            // TipAyuda
            // 
            this.TipAyuda.AutomaticDelay = 3000;
            this.TipAyuda.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.TipAyuda.ToolTipTitle = "Info";
            // 
            // FrmCarteraGestionDetalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(132)))), ((int)(((byte)(174)))));
            this.ClientSize = new System.Drawing.Size(1203, 583);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.gbxPersona);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCarteraGestionDetalle";
            this.Load += new System.EventHandler(this.FrmCarteraGestionDetalle_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbxPersona.ResumeLayout(false);
            this.gbxPersona.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PtbLoad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EpSeguimiento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EpObservacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LblCodContri;
        private System.Windows.Forms.Label LblNomContri;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox gbxPersona;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblObservacion;
        private System.Windows.Forms.Button BtnGrabar;
        private System.Windows.Forms.Label lblSeguimiento;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.ErrorProvider EpSeguimiento;
        private System.Windows.Forms.ErrorProvider EpObservacion;
        private System.Windows.Forms.DateTimePicker DtpPorGestionar;
        private System.Windows.Forms.Label lblFechaPorGestionar;
        private System.Windows.Forms.PictureBox PtbLoad;
        private System.Windows.Forms.ToolTip TipAyuda;
        private DevComponents.DotNetBar.Controls.TextBoxX TxtParentPersNoti;
        private DevComponents.DotNetBar.Controls.TextBoxX TxtEdadPersNoti;
        private DevComponents.DotNetBar.Controls.TextBoxX TxtDniPersNoti;
        private DevComponents.DotNetBar.Controls.TextBoxX TxtNomPersNoti;
        private DevComponents.DotNetBar.Controls.TextBoxX TxtObserNoti;
        private DevComponents.DotNetBar.Controls.ComboBoxEx CbxSeguimiento;
        private DevComponents.Editors.ComboItem comboItem2;
    }
}