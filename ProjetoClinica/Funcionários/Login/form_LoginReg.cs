using DevExpress.XtraEditors;
using ProjetoClinica.Context;
using ProjetoClinica.Models;
using ProjetoClinica.Utilidade;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.LookAndFeel;
using DevExpress.XtraEditors.Controls;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace ProjetoClinica.Funcionários.Login
{
    public partial class form_LoginReg : DevExpress.XtraEditors.XtraForm
    {
        public form_LoginReg()
        {
            InitializeComponent();

            btnRevelar.LookAndFeel.Style = LookAndFeelStyle.Flat;
            btnRevelar.BorderStyle = BorderStyles.NoBorder;
        }
        projeto_clinicaContext context = new projeto_clinicaContext();


        

        private int _funcionarioId;

        public int FuncionarioID
        {
            get
            {
                return _funcionarioId;

            }
            set
            {
                _funcionarioId = value;
                var funcionario = context.tb_funcionarios.Find(_funcionarioId);
                lblRegistarLogin.Text = $"Registrar login para {funcionario.fun_Nome}";
                txtUsuarioLogin.Text = funcionario.fun_login;
                txtSenhaLogin.Text = funcionario.fun_senha;
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            var funcionario = context.tb_funcionarios.Find(_funcionarioId);
            funcionario.fun_login = txtUsuarioLogin.Text;
            funcionario.fun_senha = txtSenhaLogin.Text;
           

            context.tb_funcionarios.Update(funcionario);
            context.SaveChanges();
            
            XtraMessageBox.Show("Login adicionado com sucesso!", "Sucesso", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            this.Close();
        }

        private void btnRevelar_Click(object sender, EventArgs e)
        {
            if (txtSenhaLogin.Properties.PasswordChar == '\0') // '\0' significa que o texto está visível
            {
                txtSenhaLogin.Properties.PasswordChar = '*'; // Oculta o texto
            } else
            {
                txtSenhaLogin.Properties.PasswordChar = '\0'; // Mostra o texto
            }
        }
    }
}