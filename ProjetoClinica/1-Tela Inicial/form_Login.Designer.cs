namespace ProjetoClinica.Login
{
    partial class form_Login
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtUsuarioLogin = new System.Windows.Forms.TextBox();
            this.txtSenhaLogin = new System.Windows.Forms.TextBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.btnEntrarLogin = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::ProjetoClinica.Properties.Resources.Fundo_Projeto_Clinica;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(330, 168);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(12, 179);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(56, 19);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Usuário:";
            // 
            // txtUsuarioLogin
            // 
            this.txtUsuarioLogin.Location = new System.Drawing.Point(12, 204);
            this.txtUsuarioLogin.Name = "txtUsuarioLogin";
            this.txtUsuarioLogin.Size = new System.Drawing.Size(171, 21);
            this.txtUsuarioLogin.TabIndex = 2;
            this.txtUsuarioLogin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.form_Login_KeyDown);
            // 
            // txtSenhaLogin
            // 
            this.txtSenhaLogin.Location = new System.Drawing.Point(12, 260);
            this.txtSenhaLogin.Name = "txtSenhaLogin";
            this.txtSenhaLogin.Size = new System.Drawing.Size(171, 21);
            this.txtSenhaLogin.TabIndex = 4;
            this.txtSenhaLogin.UseSystemPasswordChar = true;
            this.txtSenhaLogin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.form_Login_KeyDown);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(12, 235);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(46, 19);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Senha:";
            // 
            // btnEntrarLogin
            // 
            this.btnEntrarLogin.Appearance.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.btnEntrarLogin.Appearance.Options.UseFont = true;
            this.btnEntrarLogin.Location = new System.Drawing.Point(217, 204);
            this.btnEntrarLogin.Name = "btnEntrarLogin";
            this.btnEntrarLogin.Size = new System.Drawing.Size(101, 77);
            this.btnEntrarLogin.TabIndex = 5;
            this.btnEntrarLogin.Text = "Entrar";
            this.btnEntrarLogin.Click += new System.EventHandler(this.btnEntrarLogin_Click);
            this.btnEntrarLogin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.form_Login_KeyDown);
            // 
            // form_Login
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(50)))), ((int)(((byte)(74)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 306);
            this.Controls.Add(this.btnEntrarLogin);
            this.Controls.Add(this.txtSenhaLogin);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txtUsuarioLogin);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.pictureBox1);
            this.IconOptions.Image = global::ProjetoClinica.Properties.Resources.Icone_Projeto_Clinica;
            this.Name = "form_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login de Usuário";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.form_Login_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.TextBox txtUsuarioLogin;
        private System.Windows.Forms.TextBox txtSenhaLogin;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton btnEntrarLogin;
    }
}