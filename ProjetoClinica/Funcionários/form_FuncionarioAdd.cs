using DevExpress.XtraEditors;
using System;
using System.Windows.Forms;
using ProjetoClinica.Context;
using ProjetoClinica.Models;
using ProjetoClinica.Utilidade;

namespace ProjetoClinica.Funcionários {
    public partial class form_FuncionarioAdd : DevExpress.XtraEditors.XtraForm {
        public form_FuncionarioAdd() {
            InitializeComponent();
        }

        private void btnFuncionarioAdd_Click(object sender, EventArgs e) {

            //if (imgFuncionario == null)
            //{
            //    XtraMessageBox.Show("Anexe uma imagem do Funcionário!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}

            //byte[] imagemConvertidaVarBinaryMAX = ConversorImagem.ConvertImgToByte(imgFuncionario.Image);

            tb_funcionarios novoFuncionario = new tb_funcionarios();
            novoFuncionario.fun_Nome = txtFuncionarioNome.Text;
            novoFuncionario.fun_foto = ConversorImagem.ConvertImgToByte(imgFuncionario.Image);
            novoFuncionario.fun_CPF = txtFuncionarioCPF.Text;
            novoFuncionario.fun_DataNascimento = txtFuncionarioNascimento.Text;
            novoFuncionario.fun_Email = txtFuncionarioEmail.Text;
            novoFuncionario.fun_Telefone = txtFuncionarioTelefone.Text;
            novoFuncionario.fun_Salario = Convert.ToDecimal(txtFuncionarioSalario.Text.Replace("R$ ", ""));
            novoFuncionario.fun_CargoPrimario = txtFuncionarioCargo.Text;
            novoFuncionario.fun_CargoFuncao = txtFuncionarioFuncao.Text;
            novoFuncionario.fun_MedCRM = txtFuncionarioCRM.Text;

            using (projeto_clinicaContext context = new projeto_clinicaContext()) {

                context.tb_funcionarios.Add(novoFuncionario);
                context.SaveChanges(); 
            }

            XtraMessageBox.Show("Funcionário adicionado com sucesso!", "Sucesso", MessageBoxButtons.OK,
                MessageBoxIcon.Information);



        }

        private void form_FuncionarioAdd_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Escape) {
                this.Close();
            }
            
        }

    }
}