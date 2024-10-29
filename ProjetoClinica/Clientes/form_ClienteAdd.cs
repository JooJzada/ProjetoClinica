using DevExpress.XtraEditors;
using ProjetoClinica.Models;
using ProjetoClinica.Utilidade;
using System;
using System.Drawing;
using System.Windows.Forms;
using ProjetoClinica.Context;
using ProjetoClinica.Properties;

namespace ProjetoClinica.Clientes
{
    public partial class form_ClienteAdd : DevExpress.XtraEditors.XtraForm
    {
        public form_ClienteAdd()
        {
            InitializeComponent();
        }

        private void btnClienteAdd_Click(object sender, EventArgs e)
        {
            tb_cliente novoCliente = new tb_cliente();
            novoCliente.cl_nome = txtClienteNome.Text;

            #region Foto
            if (imgCliente == null)
            {
                novoCliente.cl_foto = null;
            } else
            {
                novoCliente.cl_foto = ConversorImagem.ConvertImgToByte(imgCliente.Image);
            } 
            #endregion
            novoCliente.cl_cpf = txtClienteCPF.Text;
            novoCliente.cl_data_nascimento = txtClienteNascimento.Text;
            novoCliente.cl_email = txtClienteEmail.Text;
            novoCliente.cl_telefone = txtClienteTelefone.Text;
            novoCliente.cl_plano = txtClientePlano.Text;
                
            using (projeto_clinicaContext context = new projeto_clinicaContext())
            {
                context.tb_cliente.Add(novoCliente);
                context.SaveChanges();
            }

            XtraMessageBox.Show("Cliente adicionado com sucesso!", "Sucesso", MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            this.Close();
        }

        private void form_ClienteAdd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }

        }
    }
}