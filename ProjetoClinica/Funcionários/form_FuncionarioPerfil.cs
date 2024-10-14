using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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

                #region Calcular Idade
                var anoNasc = Convert.ToDateTime(funcionario.fun_DataNascimento);
                int anoNascInt = anoNasc.Year;
                //int idade = anoAtual - Convert.ToInt32(anoNasc);
                int idade = anoAtual - anoNascInt;

                if (DateTime.Now < anoNasc.AddYears(idade))
                {
                    idade--;
                }
                #endregion
                
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

                lblFuncionarioNascPerfil.Text = funcionario.fun_DataNascimento;
                lblFuncionarioNomeIdadePerfil.Text = $"{funcionario.fun_Nome}, {idade}";
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