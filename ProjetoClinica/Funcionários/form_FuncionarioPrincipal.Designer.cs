namespace ProjetoClinica {
    partial class form_FuncionarioPrincipal {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_FuncionarioPrincipal));
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions1 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions2 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions3 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions4 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions5 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            this.gridFuncionarios = new DevExpress.XtraGrid.GridControl();
            this.viewFuncionarios = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnSalario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.popupFuncionarios = new DevExpress.XtraBars.PopupMenu(this.components);
            this.btnAbrirPerfil = new DevExpress.XtraBars.BarButtonItem();
            this.btnEditarFuncionario = new DevExpress.XtraBars.BarButtonItem();
            this.btnDeletarFuncionario = new DevExpress.XtraBars.BarButtonItem();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.btnPanelFunPED = new DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel();
            this.btnPanelVoltarNovo = new DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panelMiniPerfilFun = new DevExpress.XtraEditors.PanelControl();
            this.lblFuncionarioSalarioPerfil = new DevExpress.XtraEditors.LabelControl();
            this.lblFuncionarioCargoPerfilMini = new DevExpress.XtraEditors.LabelControl();
            this.lblFuncionarioCrmPerfil = new DevExpress.XtraEditors.LabelControl();
            this.lblFunCpfPerfilMini = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.lblFunTelePerfilMini = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.lblFunEmailPerfilMini = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.lblFunNascPerfilMini = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.lblFunNomeIdadeMini = new DevExpress.XtraEditors.LabelControl();
            this.imgFunPerfil = new System.Windows.Forms.PictureBox();
            this.barDockControl1 = new DevExpress.XtraBars.BarDockControl();
            this.btnRegEdtLogin = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.gridFuncionarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewFuncionarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupFuncionarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelMiniPerfilFun)).BeginInit();
            this.panelMiniPerfilFun.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgFunPerfil)).BeginInit();
            this.SuspendLayout();
            // 
            // gridFuncionarios
            // 
            this.gridFuncionarios.Location = new System.Drawing.Point(81, 183);
            this.gridFuncionarios.MainView = this.viewFuncionarios;
            this.gridFuncionarios.Name = "gridFuncionarios";
            this.gridFuncionarios.Size = new System.Drawing.Size(1187, 525);
            this.gridFuncionarios.TabIndex = 0;
            this.gridFuncionarios.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.viewFuncionarios});
            // 
            // viewFuncionarios
            // 
            this.viewFuncionarios.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumnSalario,
            this.gridColumn9});
            this.viewFuncionarios.GridControl = this.gridFuncionarios;
            this.viewFuncionarios.Name = "viewFuncionarios";
            this.viewFuncionarios.OptionsBehavior.Editable = false;
            this.viewFuncionarios.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.viewFuncionarios_RowCellClick);
            this.viewFuncionarios.PopupMenuShowing += new DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventHandler(this.viewFuncionarios_PopupMenuShowing);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "ID";
            this.gridColumn1.FieldName = "fun_ID";
            this.gridColumn1.Name = "gridColumn1";
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Nome";
            this.gridColumn2.FieldName = "fun_Nome";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Cargo";
            this.gridColumn3.FieldName = "fun_CargoPrimario";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 1;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Especialização";
            this.gridColumn4.FieldName = "fun_CargoFuncao";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 2;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Telefone";
            this.gridColumn5.FieldName = "fun_Telefone";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 3;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Email";
            this.gridColumn6.FieldName = "fun_Email";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 4;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Data de Nasc.";
            this.gridColumn7.FieldName = "fun_DataNascimento";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 5;
            // 
            // gridColumnSalario
            // 
            this.gridColumnSalario.Caption = "Salário";
            this.gridColumnSalario.FieldName = "fun_Salario";
            this.gridColumnSalario.Name = "gridColumnSalario";
            this.gridColumnSalario.Visible = true;
            this.gridColumnSalario.VisibleIndex = 7;
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "CRM";
            this.gridColumn9.FieldName = "fun_MedCRM";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 6;
            // 
            // popupFuncionarios
            // 
            this.popupFuncionarios.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnAbrirPerfil),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnEditarFuncionario),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnDeletarFuncionario),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnRegEdtLogin)});
            this.popupFuncionarios.Manager = this.barManager1;
            this.popupFuncionarios.Name = "popupFuncionarios";
            // 
            // btnAbrirPerfil
            // 
            this.btnAbrirPerfil.Caption = "Abrir perfil";
            this.btnAbrirPerfil.Id = 0;
            this.btnAbrirPerfil.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnAbrirPerfil.ImageOptions.SvgImage")));
            this.btnAbrirPerfil.Name = "btnAbrirPerfil";
            this.btnAbrirPerfil.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAbrirPerfil_ItemClick);
            // 
            // btnEditarFuncionario
            // 
            this.btnEditarFuncionario.Caption = "Editar funcionário";
            this.btnEditarFuncionario.Id = 1;
            this.btnEditarFuncionario.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnEditarFuncionario.ImageOptions.SvgImage")));
            this.btnEditarFuncionario.Name = "btnEditarFuncionario";
            this.btnEditarFuncionario.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnEditarFuncionario_ItemClick);
            // 
            // btnDeletarFuncionario
            // 
            this.btnDeletarFuncionario.Caption = "Deletar funcionário";
            this.btnDeletarFuncionario.Id = 2;
            this.btnDeletarFuncionario.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDeletarFuncionario.ImageOptions.SvgImage")));
            this.btnDeletarFuncionario.Name = "btnDeletarFuncionario";
            this.btnDeletarFuncionario.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDeletarFuncionario_ItemClick);
            // 
            // barManager1
            // 
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnAbrirPerfil,
            this.btnEditarFuncionario,
            this.btnDeletarFuncionario,
            this.btnRegEdtLogin});
            this.barManager1.MaxItemId = 4;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1280, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 720);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1280, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 720);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1280, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 720);
            // 
            // btnPanelFunPED
            // 
            this.btnPanelFunPED.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(164)))), ((int)(((byte)(250)))));
            windowsUIButtonImageOptions1.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("windowsUIButtonImageOptions1.SvgImage")));
            windowsUIButtonImageOptions2.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("windowsUIButtonImageOptions2.SvgImage")));
            windowsUIButtonImageOptions3.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("windowsUIButtonImageOptions3.SvgImage")));
            this.btnPanelFunPED.Buttons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("Perfil", true, windowsUIButtonImageOptions1, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, "Perfil", -1, false),
            new DevExpress.XtraBars.Docking2010.WindowsUISeparator(),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("Editar", true, windowsUIButtonImageOptions2, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, "Editar", -1, false),
            new DevExpress.XtraBars.Docking2010.WindowsUISeparator(),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("Deletar", true, windowsUIButtonImageOptions3, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, "Deletar", -1, false)});
            this.btnPanelFunPED.Location = new System.Drawing.Point(0, 195);
            this.btnPanelFunPED.Name = "btnPanelFunPED";
            this.btnPanelFunPED.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.btnPanelFunPED.Size = new System.Drawing.Size(73, 529);
            this.btnPanelFunPED.TabIndex = 6;
            this.btnPanelFunPED.Text = "windowsUIButtonPanel2";
            this.btnPanelFunPED.UseButtonBackgroundImages = false;
            this.btnPanelFunPED.Visible = false;
            this.btnPanelFunPED.ButtonClick += new DevExpress.XtraBars.Docking2010.ButtonEventHandler(this.btnPanelFunPED_ButtonClick);
            // 
            // btnPanelVoltarNovo
            // 
            this.btnPanelVoltarNovo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(164)))), ((int)(((byte)(250)))));
            windowsUIButtonImageOptions4.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("windowsUIButtonImageOptions4.SvgImage")));
            windowsUIButtonImageOptions5.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("windowsUIButtonImageOptions5.SvgImage")));
            this.btnPanelVoltarNovo.Buttons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("Voltar", false, windowsUIButtonImageOptions4, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, "Voltar", -1, false),
            new DevExpress.XtraBars.Docking2010.WindowsUISeparator(),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("Novo", true, windowsUIButtonImageOptions5, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, "Novo", -1, false)});
            this.btnPanelVoltarNovo.Location = new System.Drawing.Point(0, -628);
            this.btnPanelVoltarNovo.Name = "btnPanelVoltarNovo";
            this.btnPanelVoltarNovo.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.btnPanelVoltarNovo.Size = new System.Drawing.Size(73, 1395);
            this.btnPanelVoltarNovo.TabIndex = 5;
            this.btnPanelVoltarNovo.Text = "windowsUIButtonPanel1";
            this.btnPanelVoltarNovo.UseButtonBackgroundImages = false;
            this.btnPanelVoltarNovo.ButtonClick += new DevExpress.XtraBars.Docking2010.ButtonEventHandler(this.btnPanelVoltarNovo_ButtonClick);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(110, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(312, 33);
            this.labelControl1.TabIndex = 7;
            this.labelControl1.Text = "Tabela de Funcionários";
            // 
            // panelMiniPerfilFun
            // 
            this.panelMiniPerfilFun.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(164)))), ((int)(((byte)(250)))));
            this.panelMiniPerfilFun.Appearance.Options.UseBackColor = true;
            this.panelMiniPerfilFun.Controls.Add(this.lblFuncionarioSalarioPerfil);
            this.panelMiniPerfilFun.Controls.Add(this.lblFuncionarioCargoPerfilMini);
            this.panelMiniPerfilFun.Controls.Add(this.lblFuncionarioCrmPerfil);
            this.panelMiniPerfilFun.Controls.Add(this.lblFunCpfPerfilMini);
            this.panelMiniPerfilFun.Controls.Add(this.labelControl7);
            this.panelMiniPerfilFun.Controls.Add(this.lblFunTelePerfilMini);
            this.panelMiniPerfilFun.Controls.Add(this.labelControl5);
            this.panelMiniPerfilFun.Controls.Add(this.lblFunEmailPerfilMini);
            this.panelMiniPerfilFun.Controls.Add(this.labelControl3);
            this.panelMiniPerfilFun.Controls.Add(this.lblFunNascPerfilMini);
            this.panelMiniPerfilFun.Controls.Add(this.labelControl2);
            this.panelMiniPerfilFun.Controls.Add(this.lblFunNomeIdadeMini);
            this.panelMiniPerfilFun.Controls.Add(this.imgFunPerfil);
            this.panelMiniPerfilFun.Location = new System.Drawing.Point(604, 12);
            this.panelMiniPerfilFun.Name = "panelMiniPerfilFun";
            this.panelMiniPerfilFun.Size = new System.Drawing.Size(664, 165);
            this.panelMiniPerfilFun.TabIndex = 9;
            this.panelMiniPerfilFun.Visible = false;
            // 
            // lblFuncionarioSalarioPerfil
            // 
            this.lblFuncionarioSalarioPerfil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFuncionarioSalarioPerfil.Appearance.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.lblFuncionarioSalarioPerfil.Appearance.Options.UseFont = true;
            this.lblFuncionarioSalarioPerfil.Location = new System.Drawing.Point(514, 138);
            this.lblFuncionarioSalarioPerfil.Name = "lblFuncionarioSalarioPerfil";
            this.lblFuncionarioSalarioPerfil.Size = new System.Drawing.Size(133, 17);
            this.lblFuncionarioSalarioPerfil.TabIndex = 15;
            this.lblFuncionarioSalarioPerfil.Text = "Salário: R$ 99.999,99";
            // 
            // lblFuncionarioCargoPerfilMini
            // 
            this.lblFuncionarioCargoPerfilMini.Appearance.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.lblFuncionarioCargoPerfilMini.Appearance.Options.UseFont = true;
            this.lblFuncionarioCargoPerfilMini.Location = new System.Drawing.Point(138, 40);
            this.lblFuncionarioCargoPerfilMini.Name = "lblFuncionarioCargoPerfilMini";
            this.lblFuncionarioCargoPerfilMini.Size = new System.Drawing.Size(114, 19);
            this.lblFuncionarioCargoPerfilMini.TabIndex = 27;
            this.lblFuncionarioCargoPerfilMini.Text = "Cargo + Função";
            // 
            // lblFuncionarioCrmPerfil
            // 
            this.lblFuncionarioCrmPerfil.Appearance.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.lblFuncionarioCrmPerfil.Appearance.Options.UseFont = true;
            this.lblFuncionarioCrmPerfil.Location = new System.Drawing.Point(569, 40);
            this.lblFuncionarioCrmPerfil.Name = "lblFuncionarioCrmPerfil";
            this.lblFuncionarioCrmPerfil.Size = new System.Drawing.Size(78, 19);
            this.lblFuncionarioCrmPerfil.TabIndex = 26;
            this.lblFuncionarioCrmPerfil.Text = "123456-SP";
            // 
            // lblFunCpfPerfilMini
            // 
            this.lblFunCpfPerfilMini.Appearance.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.lblFunCpfPerfilMini.Appearance.Options.UseFont = true;
            this.lblFunCpfPerfilMini.Location = new System.Drawing.Point(171, 95);
            this.lblFunCpfPerfilMini.Name = "lblFunCpfPerfilMini";
            this.lblFunCpfPerfilMini.Size = new System.Drawing.Size(101, 17);
            this.lblFunCpfPerfilMini.TabIndex = 25;
            this.lblFunCpfPerfilMini.Text = "000.000.000-00";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(138, 95);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(27, 16);
            this.labelControl7.TabIndex = 24;
            this.labelControl7.Text = "CPF:";
            // 
            // lblFunTelePerfilMini
            // 
            this.lblFunTelePerfilMini.Appearance.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.lblFunTelePerfilMini.Appearance.Options.UseFont = true;
            this.lblFunTelePerfilMini.Location = new System.Drawing.Point(199, 138);
            this.lblFunTelePerfilMini.Name = "lblFunTelePerfilMini";
            this.lblFunTelePerfilMini.Size = new System.Drawing.Size(111, 17);
            this.lblFunTelePerfilMini.TabIndex = 23;
            this.lblFunTelePerfilMini.Text = "(71) 9 4002-8922";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(138, 139);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(55, 16);
            this.labelControl5.TabIndex = 22;
            this.labelControl5.Text = "Telefone:";
            // 
            // lblFunEmailPerfilMini
            // 
            this.lblFunEmailPerfilMini.Appearance.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.lblFunEmailPerfilMini.Appearance.Options.UseFont = true;
            this.lblFunEmailPerfilMini.Location = new System.Drawing.Point(180, 116);
            this.lblFunEmailPerfilMini.Name = "lblFunEmailPerfilMini";
            this.lblFunEmailPerfilMini.Size = new System.Drawing.Size(182, 17);
            this.lblFunEmailPerfilMini.TabIndex = 21;
            this.lblFunEmailPerfilMini.Text = "emailzão.silveira@hotmail.com";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(138, 117);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(36, 16);
            this.labelControl3.TabIndex = 20;
            this.labelControl3.Text = "Email:";
            // 
            // lblFunNascPerfilMini
            // 
            this.lblFunNascPerfilMini.Appearance.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.lblFunNascPerfilMini.Appearance.Options.UseFont = true;
            this.lblFunNascPerfilMini.Location = new System.Drawing.Point(224, 73);
            this.lblFunNascPerfilMini.Name = "lblFunNascPerfilMini";
            this.lblFunNascPerfilMini.Size = new System.Drawing.Size(74, 17);
            this.lblFunNascPerfilMini.TabIndex = 18;
            this.lblFunNascPerfilMini.Text = "00/00/0000";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(138, 73);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(80, 16);
            this.labelControl2.TabIndex = 17;
            this.labelControl2.Text = "Data de Nasc:";
            // 
            // lblFunNomeIdadeMini
            // 
            this.lblFunNomeIdadeMini.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFunNomeIdadeMini.Appearance.Options.UseFont = true;
            this.lblFunNomeIdadeMini.Location = new System.Drawing.Point(138, 5);
            this.lblFunNomeIdadeMini.Name = "lblFunNomeIdadeMini";
            this.lblFunNomeIdadeMini.Size = new System.Drawing.Size(509, 29);
            this.lblFunNomeIdadeMini.TabIndex = 16;
            this.lblFunNomeIdadeMini.Text = "NOME COMPLETO PEREIRA DA SILVA, 100";
            // 
            // imgFunPerfil
            // 
            this.imgFunPerfil.BackColor = System.Drawing.Color.Transparent;
            this.imgFunPerfil.Location = new System.Drawing.Point(10, 7);
            this.imgFunPerfil.Name = "imgFunPerfil";
            this.imgFunPerfil.Size = new System.Drawing.Size(113, 151);
            this.imgFunPerfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgFunPerfil.TabIndex = 15;
            this.imgFunPerfil.TabStop = false;
            // 
            // barDockControl1
            // 
            this.barDockControl1.CausesValidation = false;
            this.barDockControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControl1.Location = new System.Drawing.Point(1280, 0);
            this.barDockControl1.Manager = this.barManager1;
            this.barDockControl1.Size = new System.Drawing.Size(0, 720);
            // 
            // btnRegEdtLogin
            // 
            this.btnRegEdtLogin.Caption = "Registrar/Editar Login";
            this.btnRegEdtLogin.Id = 3;
            this.btnRegEdtLogin.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnRegEdtLogin.ImageOptions.SvgImage")));
            this.btnRegEdtLogin.Name = "btnRegEdtLogin";
            this.btnRegEdtLogin.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRegEdtLogin_ItemClick);
            // 
            // form_FuncionarioPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.panelMiniPerfilFun);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.btnPanelFunPED);
            this.Controls.Add(this.btnPanelVoltarNovo);
            this.Controls.Add(this.gridFuncionarios);
            this.Controls.Add(this.barDockControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("form_FuncionarioPrincipal.IconOptions.Image")));
            this.Name = "form_FuncionarioPrincipal";
            this.Text = "Tabela de Funcionários";
            this.Click += new System.EventHandler(this.form_FuncionarioPrincipal_Click);
            ((System.ComponentModel.ISupportInitialize)(this.gridFuncionarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewFuncionarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupFuncionarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelMiniPerfilFun)).EndInit();
            this.panelMiniPerfilFun.ResumeLayout(false);
            this.panelMiniPerfilFun.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgFunPerfil)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridFuncionarios;
        private DevExpress.XtraGrid.Views.Grid.GridView viewFuncionarios;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnSalario;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraBars.PopupMenu popupFuncionarios;
        private DevExpress.XtraBars.BarButtonItem btnAbrirPerfil;
        private DevExpress.XtraBars.BarButtonItem btnEditarFuncionario;
        private DevExpress.XtraBars.BarButtonItem btnDeletarFuncionario;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel btnPanelFunPED;
        private DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel btnPanelVoltarNovo;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.PanelControl panelMiniPerfilFun;
        private DevExpress.XtraEditors.LabelControl lblFuncionarioCrmPerfil;
        private DevExpress.XtraEditors.LabelControl lblFunCpfPerfilMini;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl lblFunTelePerfilMini;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl lblFunEmailPerfilMini;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl lblFunNascPerfilMini;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl lblFunNomeIdadeMini;
        private System.Windows.Forms.PictureBox imgFunPerfil;
        private DevExpress.XtraBars.BarDockControl barDockControl1;
        private DevExpress.XtraEditors.LabelControl lblFuncionarioCargoPerfilMini;
        private DevExpress.XtraEditors.LabelControl lblFuncionarioSalarioPerfil;
        private DevExpress.XtraBars.BarButtonItem btnRegEdtLogin;
    }
}