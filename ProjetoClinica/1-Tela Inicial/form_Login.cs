using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoClinica.Context;

namespace ProjetoClinica.Login
{
    public partial class form_Login : DevExpress.XtraEditors.XtraForm
    {
        projeto_clinicaContext context = new projeto_clinicaContext();

        public form_Login()
        {
            InitializeComponent();
        }

        private void btnEntrarLogin_Click(object sender, EventArgs e)
        {
            var usuario = txtUsuarioLogin.Text;
            var senha = txtSenhaLogin.Text;

            var user = context.tb_funcionarios.FirstOrDefault(u => u.fun_login == usuario && u.fun_senha == senha);

            if (user == null)
            {
                XtraMessageBox.Show("Usuário ou senha inválidos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Program.isLogged = true;
            Program.usuarioLogado = user;
            this.Close();
        }

        private void form_Login_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter))
            {
                btnEntrarLogin_Click(sender, e);
            }
        }
    }
}