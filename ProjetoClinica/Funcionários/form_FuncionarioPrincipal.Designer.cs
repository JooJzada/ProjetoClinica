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
            this.gridFuncionarios = new DevExpress.XtraGrid.GridControl();
            this.viewFuncionarios = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.gridFuncionarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewFuncionarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupFuncionarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridFuncionarios
            // 
            this.gridFuncionarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridFuncionarios.Location = new System.Drawing.Point(0, 0);
            this.gridFuncionarios.MainView = this.viewFuncionarios;
            this.gridFuncionarios.Name = "gridFuncionarios";
            this.gridFuncionarios.Size = new System.Drawing.Size(1278, 688);
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
            this.gridColumn8,
            this.gridColumn9});
            this.viewFuncionarios.GridControl = this.gridFuncionarios;
            this.viewFuncionarios.Name = "viewFuncionarios";
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
            // gridColumn8
            // 
            this.gridColumn8.Caption = "Salário";
            this.gridColumn8.FieldName = "fun_Salario";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 7;
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
            new DevExpress.XtraBars.LinkPersistInfo(this.btnDeletarFuncionario)});
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
            this.btnDeletarFuncionario});
            this.barManager1.MaxItemId = 3;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1278, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 688);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1278, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 688);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1278, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 688);
            // 
            // form_FuncionarioPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1278, 688);
            this.Controls.Add(this.gridFuncionarios);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("form_FuncionarioPrincipal.IconOptions.Image")));
            this.Name = "form_FuncionarioPrincipal";
            this.Text = "Tabela de Funcionários";
            ((System.ComponentModel.ISupportInitialize)(this.gridFuncionarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewFuncionarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupFuncionarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
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
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
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
    }
}