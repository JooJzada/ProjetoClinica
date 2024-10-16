namespace ProjetoClinica.Clientes
{
    partial class form_ClienteEditar
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
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.btnClienteEditar = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.imgCliente = new DevExpress.XtraEditors.ImageEdit();
            this.txtClientePlano = new DevExpress.XtraEditors.TextEdit();
            this.txtClienteCPF = new DevExpress.XtraEditors.TextEdit();
            this.txtClienteTelefone = new DevExpress.XtraEditors.TextEdit();
            this.txtClienteEmail = new DevExpress.XtraEditors.TextEdit();
            this.txtClienteNascimento = new DevExpress.XtraEditors.TextEdit();
            this.txtClienteNome = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCliente.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtClientePlano.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtClienteCPF.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtClienteTelefone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtClienteEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtClienteNascimento.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtClienteNome.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(132, 168);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(64, 13);
            this.labelControl10.TabIndex = 49;
            this.labelControl10.Text = "Anexar Foto:";
            // 
            // btnClienteEditar
            // 
            this.btnClienteEditar.Location = new System.Drawing.Point(213, 168);
            this.btnClienteEditar.Name = "btnClienteEditar";
            this.btnClienteEditar.Size = new System.Drawing.Size(141, 39);
            this.btnClienteEditar.TabIndex = 48;
            this.btnClienteEditar.Text = "Atualizar Cliente";
            this.btnClienteEditar.Click += new System.EventHandler(this.btnClienteEditar_Click);
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(15, 168);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(30, 13);
            this.labelControl6.TabIndex = 47;
            this.labelControl6.Text = "Plano:";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(15, 115);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(23, 13);
            this.labelControl5.TabIndex = 46;
            this.labelControl5.Text = "CPF:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(252, 115);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(46, 13);
            this.labelControl3.TabIndex = 45;
            this.labelControl3.Text = "Telefone:";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(15, 62);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(28, 13);
            this.labelControl4.TabIndex = 43;
            this.labelControl4.Text = "Email:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(252, 62);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(100, 13);
            this.labelControl2.TabIndex = 39;
            this.labelControl2.Text = "Data de Nascimento:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 9);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(31, 13);
            this.labelControl1.TabIndex = 37;
            this.labelControl1.Text = "Nome:";
            // 
            // imgCliente
            // 
            this.imgCliente.Location = new System.Drawing.Point(132, 187);
            this.imgCliente.Name = "imgCliente";
            this.imgCliente.Properties.AutoHeight = false;
            this.imgCliente.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.imgCliente.Size = new System.Drawing.Size(64, 20);
            this.imgCliente.TabIndex = 50;
            // 
            // txtClientePlano
            // 
            this.txtClientePlano.Location = new System.Drawing.Point(12, 187);
            this.txtClientePlano.Name = "txtClientePlano";
            this.txtClientePlano.Properties.UseMaskAsDisplayFormat = true;
            this.txtClientePlano.Size = new System.Drawing.Size(111, 20);
            this.txtClientePlano.TabIndex = 44;
            // 
            // txtClienteCPF
            // 
            this.txtClienteCPF.Location = new System.Drawing.Point(12, 134);
            this.txtClienteCPF.Name = "txtClienteCPF";
            this.txtClienteCPF.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.SimpleMaskManager));
            this.txtClienteCPF.Properties.MaskSettings.Set("MaskManagerSignature", "ignoreMaskBlank=True");
            this.txtClienteCPF.Properties.MaskSettings.Set("mask", "999.999.999-99");
            this.txtClienteCPF.Properties.UseMaskAsDisplayFormat = true;
            this.txtClienteCPF.Size = new System.Drawing.Size(220, 20);
            this.txtClienteCPF.TabIndex = 41;
            // 
            // txtClienteTelefone
            // 
            this.txtClienteTelefone.EditValue = "";
            this.txtClienteTelefone.Location = new System.Drawing.Point(252, 134);
            this.txtClienteTelefone.Name = "txtClienteTelefone";
            this.txtClienteTelefone.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.SimpleMaskManager));
            this.txtClienteTelefone.Properties.MaskSettings.Set("mask", "(00) 0 0000-0000");
            this.txtClienteTelefone.Properties.MaskSettings.Set("MaskManagerSignature", "ignoreMaskBlank=True");
            this.txtClienteTelefone.Properties.UseMaskAsDisplayFormat = true;
            this.txtClienteTelefone.Size = new System.Drawing.Size(100, 20);
            this.txtClienteTelefone.TabIndex = 42;
            // 
            // txtClienteEmail
            // 
            this.txtClienteEmail.Location = new System.Drawing.Point(12, 81);
            this.txtClienteEmail.Name = "txtClienteEmail";
            this.txtClienteEmail.Size = new System.Drawing.Size(220, 20);
            this.txtClienteEmail.TabIndex = 38;
            // 
            // txtClienteNascimento
            // 
            this.txtClienteNascimento.EditValue = "";
            this.txtClienteNascimento.Location = new System.Drawing.Point(252, 81);
            this.txtClienteNascimento.Name = "txtClienteNascimento";
            this.txtClienteNascimento.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.SimpleMaskManager));
            this.txtClienteNascimento.Properties.MaskSettings.Set("MaskManagerSignature", "ignoreMaskBlank=True");
            this.txtClienteNascimento.Properties.MaskSettings.Set("mask", "00/00/0000");
            this.txtClienteNascimento.Properties.MaskSettings.Set("culture", "pt-BR");
            this.txtClienteNascimento.Properties.UseMaskAsDisplayFormat = true;
            this.txtClienteNascimento.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtClienteNascimento.Size = new System.Drawing.Size(100, 20);
            this.txtClienteNascimento.TabIndex = 40;
            // 
            // txtClienteNome
            // 
            this.txtClienteNome.Location = new System.Drawing.Point(12, 28);
            this.txtClienteNome.Name = "txtClienteNome";
            this.txtClienteNome.Size = new System.Drawing.Size(340, 20);
            this.txtClienteNome.TabIndex = 36;
            // 
            // form_ClienteEditar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 223);
            this.Controls.Add(this.imgCliente);
            this.Controls.Add(this.labelControl10);
            this.Controls.Add(this.btnClienteEditar);
            this.Controls.Add(this.txtClientePlano);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.txtClienteCPF);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.txtClienteTelefone);
            this.Controls.Add(this.txtClienteEmail);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.txtClienteNascimento);
            this.Controls.Add(this.txtClienteNome);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.IconOptions.ShowIcon = false;
            this.Name = "form_ClienteEditar";
            this.Text = "Editar Cliente";
            ((System.ComponentModel.ISupportInitialize)(this.imgCliente.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtClientePlano.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtClienteCPF.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtClienteTelefone.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtClienteEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtClienteNascimento.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtClienteNome.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.ImageEdit imgCliente;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.SimpleButton btnClienteEditar;
        private DevExpress.XtraEditors.TextEdit txtClientePlano;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit txtClienteCPF;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtClienteTelefone;
        private DevExpress.XtraEditors.TextEdit txtClienteEmail;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtClienteNascimento;
        private DevExpress.XtraEditors.TextEdit txtClienteNome;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}