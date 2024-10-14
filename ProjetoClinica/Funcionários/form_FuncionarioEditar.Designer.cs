namespace ProjetoClinica.Funcionários
{
    partial class form_FuncionarioEditar
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
            this.imgFuncionario = new DevExpress.XtraEditors.ImageEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.btnFuncionarioAtualizar = new DevExpress.XtraEditors.SimpleButton();
            this.txtFuncionarioCRM = new DevExpress.XtraEditors.TextEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.txtFuncionarioSalario = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.txtFuncionarioFuncao = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txtFuncionarioCargo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtFuncionarioCPF = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtFuncionarioTelefone = new DevExpress.XtraEditors.TextEdit();
            this.txtFuncionarioEmail = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtFuncionarioNascimento = new DevExpress.XtraEditors.TextEdit();
            this.txtFuncionarioNome = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.imgFuncionario.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFuncionarioCRM.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFuncionarioSalario.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFuncionarioFuncao.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFuncionarioCargo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFuncionarioCPF.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFuncionarioTelefone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFuncionarioEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFuncionarioNascimento.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFuncionarioNome.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // imgFuncionario
            // 
            this.imgFuncionario.Location = new System.Drawing.Point(12, 285);
            this.imgFuncionario.Name = "imgFuncionario";
            this.imgFuncionario.Properties.AutoHeight = false;
            this.imgFuncionario.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.imgFuncionario.Size = new System.Drawing.Size(111, 54);
            this.imgFuncionario.TabIndex = 41;
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(12, 266);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(64, 13);
            this.labelControl10.TabIndex = 40;
            this.labelControl10.Text = "Anexar Foto:";
            // 
            // btnFuncionarioAtualizar
            // 
            this.btnFuncionarioAtualizar.Location = new System.Drawing.Point(143, 285);
            this.btnFuncionarioAtualizar.Name = "btnFuncionarioAtualizar";
            this.btnFuncionarioAtualizar.Size = new System.Drawing.Size(209, 54);
            this.btnFuncionarioAtualizar.TabIndex = 39;
            this.btnFuncionarioAtualizar.Text = "Atualizar Funcionário";
            this.btnFuncionarioAtualizar.Click += new System.EventHandler(this.btnFuncionarioAtualizar_Click);
            // 
            // txtFuncionarioCRM
            // 
            this.txtFuncionarioCRM.Location = new System.Drawing.Point(143, 240);
            this.txtFuncionarioCRM.Name = "txtFuncionarioCRM";
            this.txtFuncionarioCRM.Properties.UseMaskAsDisplayFormat = true;
            this.txtFuncionarioCRM.Size = new System.Drawing.Size(209, 20);
            this.txtFuncionarioCRM.TabIndex = 33;
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(143, 221);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(26, 13);
            this.labelControl9.TabIndex = 38;
            this.labelControl9.Text = "CRM:";
            // 
            // txtFuncionarioSalario
            // 
            this.txtFuncionarioSalario.Location = new System.Drawing.Point(12, 240);
            this.txtFuncionarioSalario.Name = "txtFuncionarioSalario";
            this.txtFuncionarioSalario.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtFuncionarioSalario.Properties.MaskSettings.Set("mask", "c");
            this.txtFuncionarioSalario.Properties.MaskSettings.Set("culture", "pt-BR");
            this.txtFuncionarioSalario.Properties.UseMaskAsDisplayFormat = true;
            this.txtFuncionarioSalario.Size = new System.Drawing.Size(111, 20);
            this.txtFuncionarioSalario.TabIndex = 32;
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(15, 221);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(36, 13);
            this.labelControl8.TabIndex = 37;
            this.labelControl8.Text = "Salário:";
            // 
            // txtFuncionarioFuncao
            // 
            this.txtFuncionarioFuncao.Location = new System.Drawing.Point(143, 187);
            this.txtFuncionarioFuncao.Name = "txtFuncionarioFuncao";
            this.txtFuncionarioFuncao.Properties.UseMaskAsDisplayFormat = true;
            this.txtFuncionarioFuncao.Size = new System.Drawing.Size(209, 20);
            this.txtFuncionarioFuncao.TabIndex = 31;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(143, 168);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(39, 13);
            this.labelControl7.TabIndex = 36;
            this.labelControl7.Text = "Função:";
            // 
            // txtFuncionarioCargo
            // 
            this.txtFuncionarioCargo.Location = new System.Drawing.Point(12, 187);
            this.txtFuncionarioCargo.Name = "txtFuncionarioCargo";
            this.txtFuncionarioCargo.Properties.UseMaskAsDisplayFormat = true;
            this.txtFuncionarioCargo.Size = new System.Drawing.Size(111, 20);
            this.txtFuncionarioCargo.TabIndex = 30;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(15, 168);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(33, 13);
            this.labelControl6.TabIndex = 35;
            this.labelControl6.Text = "Cargo:";
            // 
            // txtFuncionarioCPF
            // 
            this.txtFuncionarioCPF.Location = new System.Drawing.Point(12, 134);
            this.txtFuncionarioCPF.Name = "txtFuncionarioCPF";
            this.txtFuncionarioCPF.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.SimpleMaskManager));
            this.txtFuncionarioCPF.Properties.MaskSettings.Set("MaskManagerSignature", "ignoreMaskBlank=True");
            this.txtFuncionarioCPF.Properties.MaskSettings.Set("mask", "999.999.999-99");
            this.txtFuncionarioCPF.Properties.UseMaskAsDisplayFormat = true;
            this.txtFuncionarioCPF.Size = new System.Drawing.Size(220, 20);
            this.txtFuncionarioCPF.TabIndex = 26;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(15, 115);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(23, 13);
            this.labelControl5.TabIndex = 34;
            this.labelControl5.Text = "CPF:";
            // 
            // txtFuncionarioTelefone
            // 
            this.txtFuncionarioTelefone.EditValue = "";
            this.txtFuncionarioTelefone.Location = new System.Drawing.Point(252, 134);
            this.txtFuncionarioTelefone.Name = "txtFuncionarioTelefone";
            this.txtFuncionarioTelefone.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.SimpleMaskManager));
            this.txtFuncionarioTelefone.Properties.MaskSettings.Set("mask", "(00) 0 0000-0000");
            this.txtFuncionarioTelefone.Properties.MaskSettings.Set("MaskManagerSignature", "ignoreMaskBlank=True");
            this.txtFuncionarioTelefone.Properties.UseMaskAsDisplayFormat = true;
            this.txtFuncionarioTelefone.Size = new System.Drawing.Size(100, 20);
            this.txtFuncionarioTelefone.TabIndex = 28;
            // 
            // txtFuncionarioEmail
            // 
            this.txtFuncionarioEmail.Location = new System.Drawing.Point(12, 81);
            this.txtFuncionarioEmail.Name = "txtFuncionarioEmail";
            this.txtFuncionarioEmail.Size = new System.Drawing.Size(220, 20);
            this.txtFuncionarioEmail.TabIndex = 23;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(252, 115);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(46, 13);
            this.labelControl3.TabIndex = 29;
            this.labelControl3.Text = "Telefone:";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(15, 62);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(28, 13);
            this.labelControl4.TabIndex = 27;
            this.labelControl4.Text = "Email:";
            // 
            // txtFuncionarioNascimento
            // 
            this.txtFuncionarioNascimento.EditValue = "";
            this.txtFuncionarioNascimento.Location = new System.Drawing.Point(252, 81);
            this.txtFuncionarioNascimento.Name = "txtFuncionarioNascimento";
            this.txtFuncionarioNascimento.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.SimpleMaskManager));
            this.txtFuncionarioNascimento.Properties.MaskSettings.Set("MaskManagerSignature", "ignoreMaskBlank=True");
            this.txtFuncionarioNascimento.Properties.MaskSettings.Set("mask", "00/00/0000");
            this.txtFuncionarioNascimento.Properties.MaskSettings.Set("culture", "pt-BR");
            this.txtFuncionarioNascimento.Properties.UseMaskAsDisplayFormat = true;
            this.txtFuncionarioNascimento.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtFuncionarioNascimento.Size = new System.Drawing.Size(100, 20);
            this.txtFuncionarioNascimento.TabIndex = 25;
            // 
            // txtFuncionarioNome
            // 
            this.txtFuncionarioNome.Location = new System.Drawing.Point(12, 28);
            this.txtFuncionarioNome.Name = "txtFuncionarioNome";
            this.txtFuncionarioNome.Size = new System.Drawing.Size(340, 20);
            this.txtFuncionarioNome.TabIndex = 22;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(252, 62);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(100, 13);
            this.labelControl2.TabIndex = 24;
            this.labelControl2.Text = "Data de Nascimento:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 9);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(31, 13);
            this.labelControl1.TabIndex = 21;
            this.labelControl1.Text = "Nome:";
            // 
            // form_FuncionarioEditar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 362);
            this.Controls.Add(this.imgFuncionario);
            this.Controls.Add(this.labelControl10);
            this.Controls.Add(this.btnFuncionarioAtualizar);
            this.Controls.Add(this.txtFuncionarioCRM);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.txtFuncionarioSalario);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.txtFuncionarioFuncao);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.txtFuncionarioCargo);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.txtFuncionarioCPF);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.txtFuncionarioTelefone);
            this.Controls.Add(this.txtFuncionarioEmail);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.txtFuncionarioNascimento);
            this.Controls.Add(this.txtFuncionarioNome);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Name = "form_FuncionarioEditar";
            this.Text = "form_FuncionarioEditar";
            ((System.ComponentModel.ISupportInitialize)(this.imgFuncionario.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFuncionarioCRM.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFuncionarioSalario.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFuncionarioFuncao.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFuncionarioCargo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFuncionarioCPF.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFuncionarioTelefone.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFuncionarioEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFuncionarioNascimento.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFuncionarioNome.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.ImageEdit imgFuncionario;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.SimpleButton btnFuncionarioAtualizar;
        private DevExpress.XtraEditors.TextEdit txtFuncionarioCRM;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.TextEdit txtFuncionarioSalario;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.TextEdit txtFuncionarioFuncao;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit txtFuncionarioCargo;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit txtFuncionarioCPF;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtFuncionarioTelefone;
        private DevExpress.XtraEditors.TextEdit txtFuncionarioEmail;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtFuncionarioNascimento;
        private DevExpress.XtraEditors.TextEdit txtFuncionarioNome;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}