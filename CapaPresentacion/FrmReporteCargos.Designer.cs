namespace CapaPresentacion
{
    partial class FrmReporteCargos
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
            this.LVListadoValores = new DevComponents.DotNetBar.Controls.ListViewEx();
            this.orden = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Codigo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Cargo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Notificador = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Valor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Monto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FNotifica = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BTNnuevo = new DevComponents.DotNetBar.ButtonItem();
            this.BTNactualizar = new DevComponents.DotNetBar.ButtonItem();
            this.ButtonItem1 = new DevComponents.DotNetBar.ButtonItem();
            this.PanelCargo = new DevComponents.DotNetBar.PanelEx();
            this.BtnProcesar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DTIFIFinal = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.DTIFInicial = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.PanelValor = new DevComponents.DotNetBar.PanelEx();
            this.TxtAnnovalor = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.LabelX5 = new DevComponents.DotNetBar.LabelX();
            this.LabelX6 = new DevComponents.DotNetBar.LabelX();
            this.TxtValor = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.CmbTipoValor = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.LabelX1 = new DevComponents.DotNetBar.LabelX();
            this.BtnBuscaValor = new DevComponents.DotNetBar.ButtonX();
            this.TableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Panel5 = new System.Windows.Forms.Panel();
            this.BtnCerrar = new FontAwesome.Sharp.IconButton();
            this.BtnImprimir = new System.Windows.Forms.Button();
            this.dtg = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.PanelCriterios = new DevComponents.DotNetBar.PanelEx();
            this.PanelCargo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DTIFIFinal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DTIFInicial)).BeginInit();
            this.PanelValor.SuspendLayout();
            this.TableLayoutPanel1.SuspendLayout();
            this.Panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg)).BeginInit();
            this.PanelCriterios.SuspendLayout();
            this.SuspendLayout();
            // 
            // LVListadoValores
            // 
            this.LVListadoValores.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.LVListadoValores.Border.Class = "ListViewBorder";
            this.LVListadoValores.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LVListadoValores.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.orden,
            this.Codigo,
            this.Nombre,
            this.Cargo,
            this.Notificador,
            this.Valor,
            this.Monto,
            this.FNotifica,
            this.ColumnHeader1,
            this.ColumnHeader2,
            this.ColumnHeader3,
            this.ColumnHeader4,
            this.ColumnHeader5});
            this.LVListadoValores.DisabledBackColor = System.Drawing.Color.Empty;
            this.LVListadoValores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LVListadoValores.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LVListadoValores.ForeColor = System.Drawing.Color.Black;
            this.LVListadoValores.GridLines = true;
            this.LVListadoValores.HideSelection = false;
            this.LVListadoValores.Location = new System.Drawing.Point(4, 4);
            this.LVListadoValores.Name = "LVListadoValores";
            this.LVListadoValores.Size = new System.Drawing.Size(1272, 572);
            this.LVListadoValores.TabIndex = 2;
            this.LVListadoValores.UseCompatibleStateImageBehavior = false;
            this.LVListadoValores.View = System.Windows.Forms.View.Details;
            // 
            // orden
            // 
            this.orden.Text = "Nro";
            this.orden.Width = 50;
            // 
            // Codigo
            // 
            this.Codigo.Text = "Codigo";
            this.Codigo.Width = 70;
            // 
            // Nombre
            // 
            this.Nombre.Text = "Apellidos y Nombres";
            this.Nombre.Width = 300;
            // 
            // Cargo
            // 
            this.Cargo.Text = "Nro Cargo";
            this.Cargo.Width = 88;
            // 
            // Notificador
            // 
            this.Notificador.Text = "Notificador";
            this.Notificador.Width = 255;
            // 
            // Valor
            // 
            this.Valor.Text = "Valor";
            this.Valor.Width = 255;
            // 
            // Monto
            // 
            this.Monto.Text = "Monto";
            this.Monto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Monto.Width = 85;
            // 
            // FNotifica
            // 
            this.FNotifica.Text = "Fec. Notifica";
            this.FNotifica.Width = 110;
            // 
            // ColumnHeader1
            // 
            this.ColumnHeader1.Text = "num_valor";
            this.ColumnHeader1.Width = 0;
            // 
            // ColumnHeader2
            // 
            this.ColumnHeader2.Text = "ano_valor";
            this.ColumnHeader2.Width = 0;
            // 
            // ColumnHeader3
            // 
            this.ColumnHeader3.Text = "id_valor";
            this.ColumnHeader3.Width = 0;
            // 
            // ColumnHeader4
            // 
            this.ColumnHeader4.Text = "num_cargo";
            this.ColumnHeader4.Width = 0;
            // 
            // ColumnHeader5
            // 
            this.ColumnHeader5.Text = "ano_cargo";
            this.ColumnHeader5.Width = 0;
            // 
            // BTNnuevo
            // 
            this.BTNnuevo.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground;
            this.BTNnuevo.FontBold = true;
            this.BTNnuevo.HotFontBold = true;
            this.BTNnuevo.ImageFixedSize = new System.Drawing.Size(100, 0);
            this.BTNnuevo.ImageListSizeSelection = DevComponents.DotNetBar.eButtonImageListSelection.Medium;
            this.BTNnuevo.ImagePaddingHorizontal = 10;
            this.BTNnuevo.ImagePaddingVertical = 10;
            this.BTNnuevo.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.BTNnuevo.ItemAlignment = DevComponents.DotNetBar.eItemAlignment.Center;
            this.BTNnuevo.Name = "BTNnuevo";
            this.BTNnuevo.PopupType = DevComponents.DotNetBar.ePopupType.ToolBar;
            this.BTNnuevo.PopupWidth = 100;
            this.BTNnuevo.SubItemsExpandWidth = 14;
            this.BTNnuevo.Text = "&Nuevo";
            // 
            // BTNactualizar
            // 
            this.BTNactualizar.ImageFixedSize = new System.Drawing.Size(100, 0);
            this.BTNactualizar.ImageListSizeSelection = DevComponents.DotNetBar.eButtonImageListSelection.Medium;
            this.BTNactualizar.ImagePaddingHorizontal = 10;
            this.BTNactualizar.ImagePaddingVertical = 10;
            this.BTNactualizar.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.BTNactualizar.ItemAlignment = DevComponents.DotNetBar.eItemAlignment.Center;
            this.BTNactualizar.Name = "BTNactualizar";
            this.BTNactualizar.PopupType = DevComponents.DotNetBar.ePopupType.ToolBar;
            this.BTNactualizar.PopupWidth = 100;
            this.BTNactualizar.SubItemsExpandWidth = 14;
            this.BTNactualizar.Text = "&Actualizar";
            // 
            // ButtonItem1
            // 
            this.ButtonItem1.ImageFixedSize = new System.Drawing.Size(100, 0);
            this.ButtonItem1.ImageListSizeSelection = DevComponents.DotNetBar.eButtonImageListSelection.Medium;
            this.ButtonItem1.ImagePaddingHorizontal = 10;
            this.ButtonItem1.ImagePaddingVertical = 10;
            this.ButtonItem1.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.ButtonItem1.ItemAlignment = DevComponents.DotNetBar.eItemAlignment.Center;
            this.ButtonItem1.Name = "ButtonItem1";
            this.ButtonItem1.PopupType = DevComponents.DotNetBar.ePopupType.ToolBar;
            this.ButtonItem1.PopupWidth = 100;
            this.ButtonItem1.SubItemsExpandWidth = 14;
            this.ButtonItem1.Text = "A&nular";
            // 
            // PanelCargo
            // 
            this.PanelCargo.CanvasColor = System.Drawing.SystemColors.Control;
            this.PanelCargo.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.PanelCargo.Controls.Add(this.BtnProcesar);
            this.PanelCargo.Controls.Add(this.label2);
            this.PanelCargo.Controls.Add(this.label1);
            this.PanelCargo.Controls.Add(this.DTIFIFinal);
            this.PanelCargo.Controls.Add(this.DTIFInicial);
            this.PanelCargo.DisabledBackColor = System.Drawing.Color.Empty;
            this.PanelCargo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelCargo.Location = new System.Drawing.Point(0, 0);
            this.PanelCargo.Name = "PanelCargo";
            this.PanelCargo.Size = new System.Drawing.Size(1280, 40);
            this.PanelCargo.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.PanelCargo.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(132)))), ((int)(((byte)(174)))));
            this.PanelCargo.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.PanelCargo.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.PanelCargo.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.PanelCargo.Style.GradientAngle = 90;
            this.PanelCargo.TabIndex = 20;
            // 
            // BtnProcesar
            // 
            this.BtnProcesar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnProcesar.BackColor = System.Drawing.Color.White;
            this.BtnProcesar.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnProcesar.ForeColor = System.Drawing.Color.Black;
            this.BtnProcesar.Location = new System.Drawing.Point(673, 5);
            this.BtnProcesar.Name = "BtnProcesar";
            this.BtnProcesar.Size = new System.Drawing.Size(117, 30);
            this.BtnProcesar.TabIndex = 10;
            this.BtnProcesar.Text = "PROCESAR";
            this.BtnProcesar.UseVisualStyleBackColor = false;
            this.BtnProcesar.Click += new System.EventHandler(this.BtnProcesar_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(353, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Fecha Fin:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(54, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Fecha Inicio:";
            // 
            // DTIFIFinal
            // 
            this.DTIFIFinal.Anchor = System.Windows.Forms.AnchorStyles.Top;
            // 
            // 
            // 
            this.DTIFIFinal.BackgroundStyle.Class = "DateTimeInputBackground";
            this.DTIFIFinal.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.DTIFIFinal.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.DTIFIFinal.ButtonDropDown.Visible = true;
            this.DTIFIFinal.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTIFIFinal.ForeColor = System.Drawing.Color.Black;
            this.DTIFIFinal.IsPopupCalendarOpen = false;
            this.DTIFIFinal.Location = new System.Drawing.Point(456, 10);
            // 
            // 
            // 
            // 
            // 
            // 
            this.DTIFIFinal.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.DTIFIFinal.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.DTIFIFinal.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.DTIFIFinal.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.DTIFIFinal.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.DTIFIFinal.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.DTIFIFinal.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.DTIFIFinal.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.DTIFIFinal.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.DTIFIFinal.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.DTIFIFinal.MonthCalendar.DisplayMonth = new System.DateTime(2023, 3, 1, 0, 0, 0, 0);
            // 
            // 
            // 
            this.DTIFIFinal.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.DTIFIFinal.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.DTIFIFinal.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.DTIFIFinal.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.DTIFIFinal.MonthCalendar.TodayButtonVisible = true;
            this.DTIFIFinal.Name = "DTIFIFinal";
            this.DTIFIFinal.Size = new System.Drawing.Size(112, 25);
            this.DTIFIFinal.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.DTIFIFinal.TabIndex = 7;
            // 
            // DTIFInicial
            // 
            this.DTIFInicial.Anchor = System.Windows.Forms.AnchorStyles.Top;
            // 
            // 
            // 
            this.DTIFInicial.BackgroundStyle.Class = "DateTimeInputBackground";
            this.DTIFInicial.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.DTIFInicial.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.DTIFInicial.ButtonDropDown.Visible = true;
            this.DTIFInicial.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTIFInicial.ForeColor = System.Drawing.Color.Black;
            this.DTIFInicial.IsPopupCalendarOpen = false;
            this.DTIFInicial.Location = new System.Drawing.Point(171, 10);
            // 
            // 
            // 
            // 
            // 
            // 
            this.DTIFInicial.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.DTIFInicial.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.DTIFInicial.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.DTIFInicial.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.DTIFInicial.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.DTIFInicial.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.DTIFInicial.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.DTIFInicial.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.DTIFInicial.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.DTIFInicial.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.DTIFInicial.MonthCalendar.DisplayMonth = new System.DateTime(2023, 3, 1, 0, 0, 0, 0);
            // 
            // 
            // 
            this.DTIFInicial.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.DTIFInicial.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.DTIFInicial.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.DTIFInicial.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.DTIFInicial.MonthCalendar.TodayButtonVisible = true;
            this.DTIFInicial.Name = "DTIFInicial";
            this.DTIFInicial.Size = new System.Drawing.Size(112, 25);
            this.DTIFInicial.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.DTIFInicial.TabIndex = 6;
            // 
            // PanelValor
            // 
            this.PanelValor.CanvasColor = System.Drawing.SystemColors.Control;
            this.PanelValor.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.PanelValor.Controls.Add(this.TxtAnnovalor);
            this.PanelValor.Controls.Add(this.LabelX5);
            this.PanelValor.Controls.Add(this.LabelX6);
            this.PanelValor.Controls.Add(this.TxtValor);
            this.PanelValor.Controls.Add(this.CmbTipoValor);
            this.PanelValor.Controls.Add(this.LabelX1);
            this.PanelValor.Controls.Add(this.BtnBuscaValor);
            this.PanelValor.DisabledBackColor = System.Drawing.Color.Empty;
            this.PanelValor.Location = new System.Drawing.Point(40, 49);
            this.PanelValor.Name = "PanelValor";
            this.PanelValor.Size = new System.Drawing.Size(963, 40);
            this.PanelValor.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.PanelValor.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.PanelValor.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.PanelValor.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.PanelValor.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.PanelValor.Style.GradientAngle = 90;
            this.PanelValor.TabIndex = 37;
            this.PanelValor.Visible = false;
            // 
            // TxtAnnovalor
            // 
            this.TxtAnnovalor.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.TxtAnnovalor.Border.Class = "TextBoxBorder";
            this.TxtAnnovalor.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TxtAnnovalor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtAnnovalor.DisabledBackColor = System.Drawing.Color.White;
            this.TxtAnnovalor.FocusHighlightEnabled = true;
            this.TxtAnnovalor.ForeColor = System.Drawing.Color.Black;
            this.TxtAnnovalor.Location = new System.Drawing.Point(733, 10);
            this.TxtAnnovalor.MaxLength = 4;
            this.TxtAnnovalor.Name = "TxtAnnovalor";
            this.TxtAnnovalor.PreventEnterBeep = true;
            this.TxtAnnovalor.Size = new System.Drawing.Size(73, 20);
            this.TxtAnnovalor.TabIndex = 13;
            this.TxtAnnovalor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtAnnovalor.WatermarkText = "9999";
            // 
            // LabelX5
            // 
            this.LabelX5.AutoSize = true;
            // 
            // 
            // 
            this.LabelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LabelX5.ForeColor = System.Drawing.Color.Black;
            this.LabelX5.Location = new System.Drawing.Point(668, 14);
            this.LabelX5.Name = "LabelX5";
            this.LabelX5.Size = new System.Drawing.Size(51, 15);
            this.LabelX5.TabIndex = 12;
            this.LabelX5.Text = "Año Valor";
            // 
            // LabelX6
            // 
            this.LabelX6.AutoSize = true;
            // 
            // 
            // 
            this.LabelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LabelX6.ForeColor = System.Drawing.Color.Black;
            this.LabelX6.Location = new System.Drawing.Point(474, 14);
            this.LabelX6.Name = "LabelX6";
            this.LabelX6.Size = new System.Drawing.Size(49, 15);
            this.LabelX6.TabIndex = 11;
            this.LabelX6.Text = "Nro Valor";
            // 
            // TxtValor
            // 
            this.TxtValor.AutoSelectAll = true;
            this.TxtValor.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.TxtValor.Border.Class = "TextBoxBorder";
            this.TxtValor.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TxtValor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtValor.DisabledBackColor = System.Drawing.Color.White;
            this.TxtValor.FocusHighlightEnabled = true;
            this.TxtValor.ForeColor = System.Drawing.Color.Black;
            this.TxtValor.Location = new System.Drawing.Point(527, 11);
            this.TxtValor.MaxLength = 200;
            this.TxtValor.Name = "TxtValor";
            this.TxtValor.PreventEnterBeep = true;
            this.TxtValor.Size = new System.Drawing.Size(124, 20);
            this.TxtValor.TabIndex = 9;
            // 
            // CmbTipoValor
            // 
            this.CmbTipoValor.DisplayMember = "Text";
            this.CmbTipoValor.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CmbTipoValor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbTipoValor.FocusHighlightEnabled = true;
            this.CmbTipoValor.ForeColor = System.Drawing.Color.Black;
            this.CmbTipoValor.FormattingEnabled = true;
            this.CmbTipoValor.ItemHeight = 17;
            this.CmbTipoValor.Location = new System.Drawing.Point(80, 10);
            this.CmbTipoValor.Name = "CmbTipoValor";
            this.CmbTipoValor.Size = new System.Drawing.Size(374, 23);
            this.CmbTipoValor.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.CmbTipoValor.TabIndex = 8;
            // 
            // LabelX1
            // 
            this.LabelX1.AutoSize = true;
            // 
            // 
            // 
            this.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LabelX1.ForeColor = System.Drawing.Color.Black;
            this.LabelX1.Location = new System.Drawing.Point(7, 14);
            this.LabelX1.Name = "LabelX1";
            this.LabelX1.Size = new System.Drawing.Size(53, 15);
            this.LabelX1.TabIndex = 7;
            this.LabelX1.Text = "Tipo Valor";
            // 
            // BtnBuscaValor
            // 
            this.BtnBuscaValor.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BtnBuscaValor.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BtnBuscaValor.Location = new System.Drawing.Point(868, 10);
            this.BtnBuscaValor.Name = "BtnBuscaValor";
            this.BtnBuscaValor.Size = new System.Drawing.Size(93, 22);
            this.BtnBuscaValor.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BtnBuscaValor.TabIndex = 4;
            this.BtnBuscaValor.Text = "Buscar";
            // 
            // TableLayoutPanel1
            // 
            this.TableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.TableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.TableLayoutPanel1.ColumnCount = 1;
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel1.Controls.Add(this.Panel5, 0, 2);
            this.TableLayoutPanel1.Controls.Add(this.LVListadoValores, 0, 0);
            this.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayoutPanel1.Location = new System.Drawing.Point(0, 40);
            this.TableLayoutPanel1.Name = "TableLayoutPanel1";
            this.TableLayoutPanel1.RowCount = 3;
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 98.63714F));
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 1.362862F));
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 84F));
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TableLayoutPanel1.Size = new System.Drawing.Size(1280, 674);
            this.TableLayoutPanel1.TabIndex = 57;
            // 
            // Panel5
            // 
            this.Panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(132)))), ((int)(((byte)(174)))));
            this.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel5.Controls.Add(this.BtnCerrar);
            this.Panel5.Controls.Add(this.BtnImprimir);
            this.Panel5.Controls.Add(this.dtg);
            this.Panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel5.ForeColor = System.Drawing.Color.Black;
            this.Panel5.Location = new System.Drawing.Point(4, 591);
            this.Panel5.Name = "Panel5";
            this.Panel5.Size = new System.Drawing.Size(1272, 79);
            this.Panel5.TabIndex = 4;
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnCerrar.BackColor = System.Drawing.Color.White;
            this.BtnCerrar.Flip = FontAwesome.Sharp.FlipOrientation.Vertical;
            this.BtnCerrar.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCerrar.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.BtnCerrar.IconColor = System.Drawing.Color.Crimson;
            this.BtnCerrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnCerrar.IconSize = 30;
            this.BtnCerrar.Location = new System.Drawing.Point(525, 19);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(220, 39);
            this.BtnCerrar.TabIndex = 48;
            this.BtnCerrar.Text = "&CERRAR VENTANA[ESC]";
            this.BtnCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnCerrar.UseVisualStyleBackColor = false;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // BtnImprimir
            // 
            this.BtnImprimir.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnImprimir.BackColor = System.Drawing.Color.White;
            this.BtnImprimir.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnImprimir.Location = new System.Drawing.Point(330, 19);
            this.BtnImprimir.Name = "BtnImprimir";
            this.BtnImprimir.Size = new System.Drawing.Size(139, 39);
            this.BtnImprimir.TabIndex = 11;
            this.BtnImprimir.Text = "EXPORTAR";
            this.BtnImprimir.UseVisualStyleBackColor = false;
            this.BtnImprimir.Click += new System.EventHandler(this.BtnImprimir_Click);
            // 
            // dtg
            // 
            this.dtg.BackgroundColor = System.Drawing.Color.White;
            this.dtg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtg.DefaultCellStyle = dataGridViewCellStyle1;
            this.dtg.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dtg.Location = new System.Drawing.Point(21, 10);
            this.dtg.Name = "dtg";
            this.dtg.Size = new System.Drawing.Size(240, 60);
            this.dtg.TabIndex = 5;
            this.dtg.Visible = false;
            // 
            // PanelCriterios
            // 
            this.PanelCriterios.CanvasColor = System.Drawing.SystemColors.Control;
            this.PanelCriterios.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.PanelCriterios.Controls.Add(this.PanelValor);
            this.PanelCriterios.Controls.Add(this.PanelCargo);
            this.PanelCriterios.DisabledBackColor = System.Drawing.Color.Empty;
            this.PanelCriterios.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelCriterios.Location = new System.Drawing.Point(0, 0);
            this.PanelCriterios.Name = "PanelCriterios";
            this.PanelCriterios.Size = new System.Drawing.Size(1280, 40);
            this.PanelCriterios.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.PanelCriterios.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.PanelCriterios.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.PanelCriterios.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.PanelCriterios.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.PanelCriterios.Style.GradientAngle = 90;
            this.PanelCriterios.TabIndex = 56;
            this.PanelCriterios.Text = "PanelEx2";
            // 
            // FrmReporteCargos
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(1280, 714);
            this.Controls.Add(this.TableLayoutPanel1);
            this.Controls.Add(this.PanelCriterios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmReporteCargos";
            this.Text = "FrmReporteCargos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmReporteCargos_Load);
            this.PanelCargo.ResumeLayout(false);
            this.PanelCargo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DTIFIFinal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DTIFInicial)).EndInit();
            this.PanelValor.ResumeLayout(false);
            this.PanelValor.PerformLayout();
            this.TableLayoutPanel1.ResumeLayout(false);
            this.Panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtg)).EndInit();
            this.PanelCriterios.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        internal DevComponents.DotNetBar.Controls.ListViewEx LVListadoValores;
        internal System.Windows.Forms.ColumnHeader orden;
        internal System.Windows.Forms.ColumnHeader Codigo;
        internal System.Windows.Forms.ColumnHeader Nombre;
        internal System.Windows.Forms.ColumnHeader Cargo;
        internal System.Windows.Forms.ColumnHeader Notificador;
        internal System.Windows.Forms.ColumnHeader Valor;
        internal System.Windows.Forms.ColumnHeader Monto;
        internal System.Windows.Forms.ColumnHeader FNotifica;
        internal System.Windows.Forms.ColumnHeader ColumnHeader1;
        internal System.Windows.Forms.ColumnHeader ColumnHeader2;
        internal System.Windows.Forms.ColumnHeader ColumnHeader3;
        internal System.Windows.Forms.ColumnHeader ColumnHeader4;
        internal System.Windows.Forms.ColumnHeader ColumnHeader5;
        internal DevComponents.DotNetBar.ButtonItem BTNnuevo;
        internal DevComponents.DotNetBar.ButtonItem BTNactualizar;
        internal DevComponents.DotNetBar.ButtonItem ButtonItem1;
        internal DevComponents.DotNetBar.PanelEx PanelCargo;
        internal DevComponents.Editors.DateTimeAdv.DateTimeInput DTIFIFinal;
        internal DevComponents.Editors.DateTimeAdv.DateTimeInput DTIFInicial;
        internal DevComponents.DotNetBar.PanelEx PanelValor;
        internal DevComponents.DotNetBar.Controls.TextBoxX TxtAnnovalor;
        internal DevComponents.DotNetBar.LabelX LabelX5;
        internal DevComponents.DotNetBar.LabelX LabelX6;
        internal DevComponents.DotNetBar.Controls.TextBoxX TxtValor;
        internal DevComponents.DotNetBar.Controls.ComboBoxEx CmbTipoValor;
        internal DevComponents.DotNetBar.LabelX LabelX1;
        internal DevComponents.DotNetBar.ButtonX BtnBuscaValor;
        internal System.Windows.Forms.TableLayoutPanel TableLayoutPanel1;
        internal System.Windows.Forms.Panel Panel5;
        internal DevComponents.DotNetBar.Controls.DataGridViewX dtg;
        internal DevComponents.DotNetBar.PanelEx PanelCriterios;
        private System.Windows.Forms.Button BtnProcesar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnImprimir;
        private FontAwesome.Sharp.IconButton BtnCerrar;
    }
}