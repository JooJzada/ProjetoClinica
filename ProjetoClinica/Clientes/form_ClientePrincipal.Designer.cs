namespace ProjetoClinica.Clientes
{
    partial class form_ClientePrincipal
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
            this.windowsUIButtonPanel1 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.windowsUIButtonPanel2 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel();
            this.gridClientes = new DevExpress.XtraGrid.GridControl();
            this.viewClientes = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panelMiniPerfilCliente = new DevExpress.XtraEditors.PanelControl();
            this.lblFuncionarioCrmPerfil = new DevExpress.XtraEditors.LabelControl();
            this.lblFuncionarioCpfPerfil = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.lblFuncionarioTelePerfil = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.lblFuncionarioEmailPerfil = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.lblFuncionarioNascPerfil = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.lblClienteNomeIdadeMini = new DevExpress.XtraEditors.LabelControl();
            this.imgClientePerfil = new System.Windows.Forms.PictureBox();
            this.popupClientes = new DevExpress.XtraBars.PopupMenu(this.components);
            this.popupClienteEditar = new DevExpress.XtraBars.BarButtonItem();
            this.popupClienteDeletar = new DevExpress.XtraBars.BarButtonItem();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelMiniPerfilCliente)).BeginInit();
            this.panelMiniPerfilCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgClientePerfil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // windowsUIButtonPanel1
            // 
            this.windowsUIButtonPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(164)))), ((int)(((byte)(250)))));
            this.windowsUIButtonPanel1.Buttons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
            new DevExpress.XtraBars.Docking2010.WindowsUIButton(),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton()});
            this.windowsUIButtonPanel1.Location = new System.Drawing.Point(0, -3);
            this.windowsUIButtonPanel1.Name = "windowsUIButtonPanel1";
            this.windowsUIButtonPanel1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.windowsUIButtonPanel1.Size = new System.Drawing.Size(75, 137);
            this.windowsUIButtonPanel1.TabIndex = 0;
            this.windowsUIButtonPanel1.Text = "windowsUIButtonPanel1";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(110, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(247, 33);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Tabela de Clientes";
            // 
            // windowsUIButtonPanel2
            // 
            this.windowsUIButtonPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(164)))), ((int)(((byte)(250)))));
            this.windowsUIButtonPanel2.Buttons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
            new DevExpress.XtraBars.Docking2010.WindowsUIButton(),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton(),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton(),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton()});
            this.windowsUIButtonPanel2.Location = new System.Drawing.Point(0, 140);
            this.windowsUIButtonPanel2.Name = "windowsUIButtonPanel2";
            this.windowsUIButtonPanel2.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.windowsUIButtonPanel2.Size = new System.Drawing.Size(75, 582);
            this.windowsUIButtonPanel2.TabIndex = 2;
            this.windowsUIButtonPanel2.Text = "windowsUIButtonPanel2";
            // 
            // gridClientes
            // 
            this.gridClientes.Location = new System.Drawing.Point(81, 183);
            this.gridClientes.MainView = this.viewClientes;
            this.gridClientes.Name = "gridClientes";
            this.gridClientes.Size = new System.Drawing.Size(1187, 525);
            this.gridClientes.TabIndex = 3;
            this.gridClientes.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.viewClientes});
            // 
            // viewClientes
            // 
            this.viewClientes.GridControl = this.gridClientes;
            this.viewClientes.Name = "viewClientes";
            this.viewClientes.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.viewClientes_RowClick);
            this.viewClientes.PopupMenuShowing += new DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventHandler(this.viewClientes_PopupMenuShowing);
            // 
            // panelMiniPerfilCliente
            // 
            this.panelMiniPerfilCliente.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(164)))), ((int)(((byte)(250)))));
            this.panelMiniPerfilCliente.Appearance.Options.UseBackColor = true;
            this.panelMiniPerfilCliente.Controls.Add(this.lblFuncionarioCrmPerfil);
            this.panelMiniPerfilCliente.Controls.Add(this.lblFuncionarioCpfPerfil);
            this.panelMiniPerfilCliente.Controls.Add(this.labelControl7);
            this.panelMiniPerfilCliente.Controls.Add(this.lblFuncionarioTelePerfil);
            this.panelMiniPerfilCliente.Controls.Add(this.labelControl5);
            this.panelMiniPerfilCliente.Controls.Add(this.lblFuncionarioEmailPerfil);
            this.panelMiniPerfilCliente.Controls.Add(this.labelControl3);
            this.panelMiniPerfilCliente.Controls.Add(this.lblFuncionarioNascPerfil);
            this.panelMiniPerfilCliente.Controls.Add(this.labelControl2);
            this.panelMiniPerfilCliente.Controls.Add(this.lblClienteNomeIdadeMini);
            this.panelMiniPerfilCliente.Controls.Add(this.imgClientePerfil);
            this.panelMiniPerfilCliente.Location = new System.Drawing.Point(604, 12);
            this.panelMiniPerfilCliente.Name = "panelMiniPerfilCliente";
            this.panelMiniPerfilCliente.Size = new System.Drawing.Size(664, 165);
            this.panelMiniPerfilCliente.TabIndex = 4;
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
            // lblFuncionarioCpfPerfil
            // 
            this.lblFuncionarioCpfPerfil.Appearance.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.lblFuncionarioCpfPerfil.Appearance.Options.UseFont = true;
            this.lblFuncionarioCpfPerfil.Location = new System.Drawing.Point(171, 95);
            this.lblFuncionarioCpfPerfil.Name = "lblFuncionarioCpfPerfil";
            this.lblFuncionarioCpfPerfil.Size = new System.Drawing.Size(101, 17);
            this.lblFuncionarioCpfPerfil.TabIndex = 25;
            this.lblFuncionarioCpfPerfil.Text = "000.000.000-00";
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
            // lblFuncionarioTelePerfil
            // 
            this.lblFuncionarioTelePerfil.Appearance.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.lblFuncionarioTelePerfil.Appearance.Options.UseFont = true;
            this.lblFuncionarioTelePerfil.Location = new System.Drawing.Point(199, 138);
            this.lblFuncionarioTelePerfil.Name = "lblFuncionarioTelePerfil";
            this.lblFuncionarioTelePerfil.Size = new System.Drawing.Size(111, 17);
            this.lblFuncionarioTelePerfil.TabIndex = 23;
            this.lblFuncionarioTelePerfil.Text = "(71) 9 4002-8922";
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
            // lblFuncionarioEmailPerfil
            // 
            this.lblFuncionarioEmailPerfil.Appearance.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.lblFuncionarioEmailPerfil.Appearance.Options.UseFont = true;
            this.lblFuncionarioEmailPerfil.Location = new System.Drawing.Point(180, 116);
            this.lblFuncionarioEmailPerfil.Name = "lblFuncionarioEmailPerfil";
            this.lblFuncionarioEmailPerfil.Size = new System.Drawing.Size(182, 17);
            this.lblFuncionarioEmailPerfil.TabIndex = 21;
            this.lblFuncionarioEmailPerfil.Text = "emailzão.silveira@hotmail.com";
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
            // lblFuncionarioNascPerfil
            // 
            this.lblFuncionarioNascPerfil.Appearance.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.lblFuncionarioNascPerfil.Appearance.Options.UseFont = true;
            this.lblFuncionarioNascPerfil.Location = new System.Drawing.Point(224, 73);
            this.lblFuncionarioNascPerfil.Name = "lblFuncionarioNascPerfil";
            this.lblFuncionarioNascPerfil.Size = new System.Drawing.Size(74, 17);
            this.lblFuncionarioNascPerfil.TabIndex = 18;
            this.lblFuncionarioNascPerfil.Text = "00/00/0000";
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
            // lblClienteNomeIdadeMini
            // 
            this.lblClienteNomeIdadeMini.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClienteNomeIdadeMini.Appearance.Options.UseFont = true;
            this.lblClienteNomeIdadeMini.Location = new System.Drawing.Point(138, 5);
            this.lblClienteNomeIdadeMini.Name = "lblClienteNomeIdadeMini";
            this.lblClienteNomeIdadeMini.Size = new System.Drawing.Size(509, 29);
            this.lblClienteNomeIdadeMini.TabIndex = 16;
            this.lblClienteNomeIdadeMini.Text = "NOME COMPLETO PEREIRA DA SILVA, 100";
            // 
            // imgClientePerfil
            // 
            this.imgClientePerfil.Location = new System.Drawing.Point(5, 5);
            this.imgClientePerfil.Name = "imgClientePerfil";
            this.imgClientePerfil.Size = new System.Drawing.Size(113, 151);
            this.imgClientePerfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgClientePerfil.TabIndex = 15;
            this.imgClientePerfil.TabStop = false;
            // 
            // popupClientes
            // 
            this.popupClientes.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.popupClienteEditar),
            new DevExpress.XtraBars.LinkPersistInfo(this.popupClienteDeletar)});
            this.popupClientes.Manager = this.barManager1;
            this.popupClientes.Name = "popupClientes";
            // 
            // popupClienteEditar
            // 
            this.popupClienteEditar.Caption = "Editar Cliente";
            this.popupClienteEditar.Id = 0;
            this.popupClienteEditar.Name = "popupClienteEditar";
            this.popupClienteEditar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.popupClienteEditar_ItemClick);
            // 
            // popupClienteDeletar
            // 
            this.popupClienteDeletar.Caption = "Deletar Cliente";
            this.popupClienteDeletar.Id = 1;
            this.popupClienteDeletar.Name = "popupClienteDeletar";
            this.popupClienteDeletar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.popupClienteDeletar_ItemClick);
            // 
            // barManager1
            // 
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.popupClienteEditar,
            this.popupClienteDeletar});
            this.barManager1.MaxItemId = 2;
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
            // form_ClientePrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.panelMiniPerfilCliente);
            this.Controls.Add(this.gridClientes);
            this.Controls.Add(this.windowsUIButtonPanel2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.windowsUIButtonPanel1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IconOptions.ShowIcon = false;
            this.Name = "form_ClientePrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "form_ClientePrincipal";
            ((System.ComponentModel.ISupportInitialize)(this.gridClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelMiniPerfilCliente)).EndInit();
            this.panelMiniPerfilCliente.ResumeLayout(false);
            this.panelMiniPerfilCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgClientePerfil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel windowsUIButtonPanel1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel windowsUIButtonPanel2;
        private DevExpress.XtraGrid.GridControl gridClientes;
        private DevExpress.XtraGrid.Views.Grid.GridView viewClientes;
        private DevExpress.XtraEditors.PanelControl panelMiniPerfilCliente;
        private DevExpress.XtraEditors.LabelControl lblFuncionarioCrmPerfil;
        private DevExpress.XtraEditors.LabelControl lblFuncionarioCpfPerfil;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl lblFuncionarioTelePerfil;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl lblFuncionarioEmailPerfil;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl lblFuncionarioNascPerfil;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl lblClienteNomeIdadeMini;
        private System.Windows.Forms.PictureBox imgClientePerfil;
        private DevExpress.XtraBars.PopupMenu popupClientes;
        private DevExpress.XtraBars.BarButtonItem popupClienteEditar;
        private DevExpress.XtraBars.BarButtonItem popupClienteDeletar;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
    }
}