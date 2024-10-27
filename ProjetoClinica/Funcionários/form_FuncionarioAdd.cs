using DevExpress.XtraEditors;
using System;
using System.Linq;
using System.Windows.Forms;
using DevExpress.Xpo;
using ProjetoClinica.Context;
using ProjetoClinica.Models;
using ProjetoClinica.Utilidade;
using ProjetoClinica.XPO.Database;

namespace ProjetoClinica.Funcionários
{
    public partial class form_FuncionarioAdd : DevExpress.XtraEditors.XtraForm
    {
        public form_FuncionarioAdd()
        {
            InitializeComponent();
        }

        private void CarregarProfissão()
        {
            //    projeto_clinicaContext context = new projeto_clinicaContext();
            //    var funcionarios = context.tb_funcionarios.ToList();

            //UnitOfWork uow = new UnitOfWork(XpoDefault.DataLayer);
            //var query = from funcionario in new XPQuery<tb_funcionariosxpo>(uow)
            //    orderby funcionario.fun_Nome ascending
            //    select new
            //    {
            //        funcionario.fun_ID
            //    };
        }



        private void btnFuncionarioAdd_Click(object sender, EventArgs e)
        {

            if (imgFuncionario == null)
            {
                XtraMessageBox.Show("Anexe uma imagem do Funcionário!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //byte[] imagemConvertidaVarBinaryMAX = ConversorImagem.ConvertImgToByte(imgFuncionario.Image);

            tb_funcionarios novoFuncionario = new tb_funcionarios();
            novoFuncionario.fun_Nome = txtFuncionarioNome.Text;
            novoFuncionario.fun_foto = ConversorImagem.ConvertImgToByte(imgFuncionario.Image);
            novoFuncionario.fun_CPF = txtFuncionarioCPF.Text;
            novoFuncionario.fun_DataNascimento = txtFuncionarioNascimento.Text;
            novoFuncionario.fun_Email = txtFuncionarioEmail.Text;
            novoFuncionario.fun_Telefone = txtFuncionarioTelefone.Text;
            novoFuncionario.fun_Salario = Convert.ToDecimal(txtFuncionarioSalario.Text.Replace("R$ ", ""));
            novoFuncionario.fun_CargoPrimario = cBoxCargo.Text;
            novoFuncionario.fun_CargoFuncao = txtFuncionarioFuncao.Text;
            novoFuncionario.fun_MedCRM = txtFuncionarioCRM.Text;


            using (projeto_clinicaContext context = new projeto_clinicaContext())
            {
                int? ultimoResourceId = context.Resources.Max(r => (int?)r.ResourceID);
                int novoResource = ultimoResourceId.HasValue ? ultimoResourceId.Value + 1 : 1;

                context.tb_funcionarios.Add(novoFuncionario);
                context.SaveChanges();

                
                var novaResource = new Resources
                {
                    ResourceID = novoResource,
                    ResourceName = novoFuncionario.fun_Nome,
                    fk_FunID = novoFuncionario.fun_ID
                };

                context.Resources.Add(novaResource);
                context.SaveChanges();
            }

            XtraMessageBox.Show("Funcionário adicionado com sucesso!", "Sucesso", MessageBoxButtons.OK,
                MessageBoxIcon.Information);



        }

        private void form_FuncionarioAdd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }

        }

    }
}