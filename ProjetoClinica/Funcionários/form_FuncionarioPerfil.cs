using System;
using System.Globalization;
using ProjetoClinica.Context;
using ProjetoClinica.Utilidade;

namespace ProjetoClinica.Funcionários
{
    public partial class form_FuncionarioPerfil : DevExpress.XtraEditors.XtraForm
    {

        projeto_clinicaContext context = new projeto_clinicaContext();


        private int _funcionarioId;
        int anoAtual = DateTime.Now.Year;
        // private DateTime anoNasc;

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
                
                #region Cargo

                if (string.IsNullOrWhiteSpace(funcionario.fun_CargoFuncao))
                {
                    lblFuncionarioCargoPerfil.Text = $"{funcionario.fun_CargoPrimario}";
                } else
                {
                    lblFuncionarioCargoPerfil.Text = $"{funcionario.fun_CargoPrimario}, {funcionario.fun_CargoFuncao}";
                }
                #endregion

                #region CRM
                if (string.IsNullOrWhiteSpace(funcionario.fun_MedCRM))
                {
                    lblFuncionarioCrmPerfil.Visible = false;
                } else
                {
                    lblFuncionarioCrmPerfil.Text = funcionario.fun_MedCRM;
                } 
                #endregion

                //var idade = CalcIdade.CalcularIdadeFuncionario(funcionario.fun_ID);

                lblFuncionarioNascPerfil.Text = funcionario.fun_DataNascimento;
                lblFuncionarioNomeIdadePerfil.Text = $"{funcionario.fun_Nome}, {CalcIdade.CalcularIdadeFuncionario(funcionario.fun_ID)}";
                lblFuncionarioCpfPerfil.Text = funcionario.fun_CPF;
                lblFuncionarioEmailPerfil.Text = funcionario.fun_Email;
                lblFuncionarioTelePerfil.Text = funcionario.fun_Telefone;
                lblFuncionarioSalarioPerfil.Text = (funcionario.fun_Salario).ToString("C", CultureInfo.CurrentCulture);
                imgFuncionarioPerfil.Image = ConversorImagem.ConvertByteArrayToImg(funcionario.fun_foto);
            }
        }
        


        public form_FuncionarioPerfil()
        {
            InitializeComponent();
        }

        private void windowsUIButtonPanel1_Click(object sender, EventArgs e)
        {
            this.Close();

        }

    }
}