namespace ProjetoClinica.Funcionários {
    partial class form_FuncionarioPerfil {
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
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions1 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_FuncionarioPerfil));
            this.windowsUIButtonPanel1 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel();
            this.imgFuncionarioPerfil = new System.Windows.Forms.PictureBox();
            this.lblFuncionarioNomeIdadePerfil = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.lblFuncionarioNascPerfil = new DevExpress.XtraEditors.LabelControl();
            this.lblFuncionarioCargoPerfil = new DevExpress.XtraEditors.LabelControl();
            this.lblFuncionarioEmailPerfil = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.lblFuncionarioTelePerfil = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.lblFuncionarioCpfPerfil = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.lblFuncionarioCrmPerfil = new DevExpress.XtraEditors.LabelControl();
            this.lblFuncionarioSalarioPerfil = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.imgFuncionarioPerfil)).BeginInit();
            this.SuspendLayout();
            // 
            // windowsUIButtonPanel1
            // 
            this.windowsUIButtonPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(164)))), ((int)(((byte)(250)))));
            windowsUIButtonImageOptions1.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("windowsUIButtonImageOptions1.SvgImage")));
            this.windowsUIButtonPanel1.Buttons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
            new DevExpress.XtraBars.Docking2010.WindowsUISeparator(),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("btnVoltarPerfil", false, windowsUIButtonImageOptions1, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, "Voltar", -1, false),
            new DevExpress.XtraBars.Docking2010.WindowsUISeparator()});
            this.windowsUIButtonPanel1.ContentAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.windowsUIButtonPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.windowsUIButtonPanel1.Location = new System.Drawing.Point(0, 0);
            this.windowsUIButtonPanel1.Name = "windowsUIButtonPanel1";
            this.windowsUIButtonPanel1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.windowsUIButtonPanel1.Size = new System.Drawing.Size(50, 178);
            this.windowsUIButtonPanel1.TabIndex = 0;
            this.windowsUIButtonPanel1.Text = "windowsUIButtonPanel1";
            this.windowsUIButtonPanel1.UseButtonBackgroundImages = false;
            this.windowsUIButtonPanel1.ButtonClick += new DevExpress.XtraBars.Docking2010.ButtonEventHandler(this.windowsUIButtonPanel1_ButtonClick);
            this.windowsUIButtonPanel1.Click += new System.EventHandler(this.windowsUIButtonPanel1_Click);
            // 
            // imgFuncionarioPerfil
            // 
            this.imgFuncionarioPerfil.Location = new System.Drawing.Point(67, 12);
            this.imgFuncionarioPerfil.Name = "imgFuncionarioPerfil";
            this.imgFuncionarioPerfil.Size = new System.Drawing.Size(113, 151);
            this.imgFuncionarioPerfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgFuncionarioPerfil.TabIndex = 1;
            this.imgFuncionarioPerfil.TabStop = false;
            // 
            // lblFuncionarioNomeIdadePerfil
            // 
            this.lblFuncionarioNomeIdadePerfil.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFuncionarioNomeIdadePerfil.Appearance.Options.UseFont = true;
            this.lblFuncionarioNomeIdadePerfil.Location = new System.Drawing.Point(200, 12);
            this.lblFuncionarioNomeIdadePerfil.Name = "lblFuncionarioNomeIdadePerfil";
            this.lblFuncionarioNomeIdadePerfil.Size = new System.Drawing.Size(509, 29);
            this.lblFuncionarioNomeIdadePerfil.TabIndex = 2;
            this.lblFuncionarioNomeIdadePerfil.Text = "NOME COMPLETO PEREIRA DA SILVA, 100";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(200, 81);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(80, 16);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Data de Nasc:";
            // 
            // lblFuncionarioNascPerfil
            // 
            this.lblFuncionarioNascPerfil.Appearance.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.lblFuncionarioNascPerfil.Appearance.Options.UseFont = true;
            this.lblFuncionarioNascPerfil.Location = new System.Drawing.Point(286, 81);
            this.lblFuncionarioNascPerfil.Name = "lblFuncionarioNascPerfil";
            this.lblFuncionarioNascPerfil.Size = new System.Drawing.Size(74, 17);
            this.lblFuncionarioNascPerfil.TabIndex = 4;
            this.lblFuncionarioNascPerfil.Text = "00/00/0000";
            // 
            // lblFuncionarioCargoPerfil
            // 
            this.lblFuncionarioCargoPerfil.Appearance.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.lblFuncionarioCargoPerfil.Appearance.Options.UseFont = true;
            this.lblFuncionarioCargoPerfil.Location = new System.Drawing.Point(200, 47);
            this.lblFuncionarioCargoPerfil.Name = "lblFuncionarioCargoPerfil";
            this.lblFuncionarioCargoPerfil.Size = new System.Drawing.Size(114, 19);
            this.lblFuncionarioCargoPerfil.TabIndex = 5;
            this.lblFuncionarioCargoPerfil.Text = "Cargo + Função";
            // 
            // lblFuncionarioEmailPerfil
            // 
            this.lblFuncionarioEmailPerfil.Appearance.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.lblFuncionarioEmailPerfil.Appearance.Options.UseFont = true;
            this.lblFuncionarioEmailPerfil.Location = new System.Drawing.Point(242, 124);
            this.lblFuncionarioEmailPerfil.Name = "lblFuncionarioEmailPerfil";
            this.lblFuncionarioEmailPerfil.Size = new System.Drawing.Size(182, 17);
            this.lblFuncionarioEmailPerfil.TabIndex = 7;
            this.lblFuncionarioEmailPerfil.Text = "emailzão.silveira@hotmail.com";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(200, 125);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(36, 16);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "Email:";
            // 
            // lblFuncionarioTelePerfil
            // 
            this.lblFuncionarioTelePerfil.Appearance.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.lblFuncionarioTelePerfil.Appearance.Options.UseFont = true;
            this.lblFuncionarioTelePerfil.Location = new System.Drawing.Point(261, 146);
            this.lblFuncionarioTelePerfil.Name = "lblFuncionarioTelePerfil";
            this.lblFuncionarioTelePerfil.Size = new System.Drawing.Size(111, 17);
            this.lblFuncionarioTelePerfil.TabIndex = 9;
            this.lblFuncionarioTelePerfil.Text = "(71) 9 4002-8922";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(200, 147);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(55, 16);
            this.labelControl5.TabIndex = 8;
            this.labelControl5.Text = "Telefone:";
            // 
            // lblFuncionarioCpfPerfil
            // 
            this.lblFuncionarioCpfPerfil.Appearance.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.lblFuncionarioCpfPerfil.Appearance.Options.UseFont = true;
            this.lblFuncionarioCpfPerfil.Location = new System.Drawing.Point(233, 103);
            this.lblFuncionarioCpfPerfil.Name = "lblFuncionarioCpfPerfil";
            this.lblFuncionarioCpfPerfil.Size = new System.Drawing.Size(101, 17);
            this.lblFuncionarioCpfPerfil.TabIndex = 11;
            this.lblFuncionarioCpfPerfil.Text = "000.000.000-00";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(200, 103);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(27, 16);
            this.labelControl7.TabIndex = 10;
            this.labelControl7.Text = "CPF:";
            // 
            // lblFuncionarioCrmPerfil
            // 
            this.lblFuncionarioCrmPerfil.Appearance.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.lblFuncionarioCrmPerfil.Appearance.Options.UseFont = true;
            this.lblFuncionarioCrmPerfil.Location = new System.Drawing.Point(631, 47);
            this.lblFuncionarioCrmPerfil.Name = "lblFuncionarioCrmPerfil";
            this.lblFuncionarioCrmPerfil.Size = new System.Drawing.Size(78, 19);
            this.lblFuncionarioCrmPerfil.TabIndex = 12;
            this.lblFuncionarioCrmPerfil.Text = "123456-SP";
            // 
            // lblFuncionarioSalarioPerfil
            // 
            this.lblFuncionarioSalarioPerfil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFuncionarioSalarioPerfil.Appearance.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.lblFuncionarioSalarioPerfil.Appearance.Options.UseFont = true;
            this.lblFuncionarioSalarioPerfil.Location = new System.Drawing.Point(576, 146);
            this.lblFuncionarioSalarioPerfil.Name = "lblFuncionarioSalarioPerfil";
            this.lblFuncionarioSalarioPerfil.Size = new System.Drawing.Size(133, 17);
            this.lblFuncionarioSalarioPerfil.TabIndex = 14;
            this.lblFuncionarioSalarioPerfil.Text = "Salário: R$ 99.999,99";
            // 
            // form_FuncionarioPerfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 178);
            this.Controls.Add(this.lblFuncionarioSalarioPerfil);
            this.Controls.Add(this.lblFuncionarioCrmPerfil);
            this.Controls.Add(this.lblFuncionarioCpfPerfil);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.lblFuncionarioTelePerfil);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.lblFuncionarioEmailPerfil);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.lblFuncionarioCargoPerfil);
            this.Controls.Add(this.lblFuncionarioNascPerfil);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.lblFuncionarioNomeIdadePerfil);
            this.Controls.Add(this.imgFuncionarioPerfil);
            this.Controls.Add(this.windowsUIButtonPanel1);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.None;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "form_FuncionarioPerfil";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.form_FuncionarioPerfil_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.imgFuncionarioPerfil)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel windowsUIButtonPanel1;
        private System.Windows.Forms.PictureBox imgFuncionarioPerfil;
        private DevExpress.XtraEditors.LabelControl lblFuncionarioNomeIdadePerfil;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl lblFuncionarioNascPerfil;
        private DevExpress.XtraEditors.LabelControl lblFuncionarioCargoPerfil;
        private DevExpress.XtraEditors.LabelControl lblFuncionarioEmailPerfil;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl lblFuncionarioTelePerfil;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl lblFuncionarioCpfPerfil;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl lblFuncionarioCrmPerfil;
        private DevExpress.XtraEditors.LabelControl lblFuncionarioSalarioPerfil;
    }
}