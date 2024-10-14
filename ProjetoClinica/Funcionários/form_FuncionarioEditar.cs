using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ProjetoClinica.Context;
using ProjetoClinica.Utilidade;

namespace ProjetoClinica.Funcionários
{
    public partial class form_FuncionarioEditar : DevExpress.XtraEditors.XtraForm
    {
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
                txtFuncionarioNome.Text = funcionario.fun_Nome;
                txtFuncionarioEmail.Text = funcionario.fun_Email;
                txtFuncionarioNascimento.Text = funcionario.fun_DataNascimento;
                txtFuncionarioCPF.Text = funcionario.fun_CPF;
                txtFuncionarioTelefone.Text = funcionario.fun_Telefone;
                txtFuncionarioCargo.Text = funcionario.fun_CargoPrimario;
                txtFuncionarioFuncao.Text = funcionario.fun_CargoFuncao;
                txtFuncionarioSalario.Text = Convert.ToString(funcionario.fun_Salario);
                txtFuncionarioCRM.Text = funcionario.fun_MedCRM;
                imgFuncionario.Image = ConversorImagem.ConvertByteArrayToImg(funcionario.fun_foto);
            }
        }


        public form_FuncionarioEditar()
        {
            InitializeComponent();
        }

        private void btnFuncionarioAtualizar_Click(object sender, EventArgs e)
        {
            var funcionario = context.tb_funcionarios.Find(_funcionarioId);
            funcionario.fun_Nome = txtFuncionarioNome.Text;
            funcionario.fun_foto = ConversorImagem.ConvertImgToByte(imgFuncionario.Image);
            funcionario.fun_CPF = txtFuncionarioCPF.Text;
            funcionario.fun_DataNascimento = txtFuncionarioNascimento.Text;
            funcionario.fun_Email = txtFuncionarioEmail.Text;
            funcionario.fun_Telefone = txtFuncionarioTelefone.Text;
            funcionario.fun_Salario = Convert.ToDecimal(txtFuncionarioSalario.Text.Replace("R$ ", ""));
            funcionario.fun_CargoPrimario = txtFuncionarioCargo.Text;
            funcionario.fun_CargoFuncao = txtFuncionarioFuncao.Text;
            funcionario.fun_MedCRM = txtFuncionarioCRM.Text;

            context.tb_funcionarios.Update(funcionario);
            context.SaveChanges();

            XtraMessageBox.Show("Funcionário atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            this.Close();
        }
    }
}