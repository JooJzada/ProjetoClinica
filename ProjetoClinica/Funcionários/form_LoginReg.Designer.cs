namespace ProjetoClinica.Funcionários.Login
{
    partial class form_LoginReg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_LoginReg));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.lblRegistarLogin = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.txtUsuarioLogin = new DevExpress.XtraEditors.TextEdit();
            this.txtSenhaLogin = new DevExpress.XtraEditors.TextEdit();
            this.btnRevelar = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsuarioLogin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSenhaLogin.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(12, 47);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(60, 19);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Usuário:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(12, 109);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(49, 19);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Senha:";
            // 
            // lblRegistarLogin
            // 
            this.lblRegistarLogin.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistarLogin.Appearance.Options.UseFont = true;
            this.lblRegistarLogin.Location = new System.Drawing.Point(12, 12);
            this.lblRegistarLogin.Name = "lblRegistarLogin";
            this.lblRegistarLogin.Size = new System.Drawing.Size(324, 16);
            this.lblRegistarLogin.TabIndex = 4;
            this.lblRegistarLogin.Text = "Registro de login para Rodolfo Pereira Armando da Silva";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(258, 88);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 52);
            this.simpleButton1.TabIndex = 5;
            this.simpleButton1.Text = "Registrar";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // txtUsuarioLogin
            // 
            this.txtUsuarioLogin.Location = new System.Drawing.Point(12, 72);
            this.txtUsuarioLogin.Name = "txtUsuarioLogin";
            this.txtUsuarioLogin.Size = new System.Drawing.Size(230, 20);
            this.txtUsuarioLogin.TabIndex = 7;
            // 
            // txtSenhaLogin
            // 
            this.txtSenhaLogin.Location = new System.Drawing.Point(12, 134);
            this.txtSenhaLogin.Name = "txtSenhaLogin";
            this.txtSenhaLogin.Properties.PasswordChar = '*';
            this.txtSenhaLogin.Size = new System.Drawing.Size(230, 20);
            this.txtSenhaLogin.TabIndex = 8;
            // 
            // btnRevelar
            // 
            this.btnRevelar.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnRevelar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnRevelar.ImageOptions.SvgImage")));
            this.btnRevelar.ImageOptions.SvgImageSize = new System.Drawing.Size(15, 15);
            this.btnRevelar.Location = new System.Drawing.Point(221, 136);
            this.btnRevelar.Name = "btnRevelar";
            this.btnRevelar.Size = new System.Drawing.Size(19, 16);
            this.btnRevelar.TabIndex = 9;
            this.btnRevelar.Click += new System.EventHandler(this.btnRevelar_Click);
            // 
            // form_LoginReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 183);
            this.Controls.Add(this.btnRevelar);
            this.Controls.Add(this.txtSenhaLogin);
            this.Controls.Add(this.txtUsuarioLogin);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.lblRegistarLogin);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.IconOptions.Image = global::ProjetoClinica.Properties.Resources.Icone_Projeto_Clinica;
            this.Name = "form_LoginReg";
            this.Text = "Registro de Login";
            ((System.ComponentModel.ISupportInitialize)(this.txtUsuarioLogin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSenhaLogin.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl lblRegistarLogin;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.TextEdit txtUsuarioLogin;
        private DevExpress.XtraEditors.TextEdit txtSenhaLogin;
        private DevExpress.XtraEditors.SimpleButton btnRevelar;
    }
}