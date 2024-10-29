using DevExpress.XtraEditors;
using System;
using System.Windows.Forms;
using ProjetoClinica.Context;
using ProjetoClinica.Utilidade;

namespace ProjetoClinica.Clientes
{
    public partial class form_ClienteEditar : DevExpress.XtraEditors.XtraForm
    {
        public form_ClienteEditar()
        {
            InitializeComponent();
        }

        projeto_clinicaContext context = new projeto_clinicaContext();

        private int _clienteID;

        public int ClienteID
        {
            get
            {
                return _clienteID;

            }
            set
            {
                _clienteID = value;
                var cliente = context.tb_cliente.Find(_clienteID);
                txtClienteNome.Text = cliente.cl_nome;
                txtClienteEmail.Text = cliente.cl_email;
                txtClienteNascimento.Text = cliente.cl_data_nascimento;
                txtClienteCPF.Text = cliente.cl_cpf;
                txtClienteTelefone.Text = cliente.cl_telefone;
                txtClientePlano.Text = cliente.cl_plano;
                if (cliente.cl_foto != null)
                {
                    imgCliente.Image = ConversorImagem.ConvertByteArrayToImg(cliente.cl_foto);
                }
            }
        }

        private void btnClienteEditar_Click(object sender, EventArgs e)
        {
            var cliente = context.tb_cliente.Find(_clienteID);
            cliente.cl_nome = txtClienteNome.Text;
            cliente.cl_foto = ConversorImagem.ConvertImgToByte(imgCliente.Image);
            cliente.cl_cpf = txtClienteCPF.Text;
            cliente.cl_data_nascimento = txtClienteNascimento.Text;
            cliente.cl_email = txtClienteEmail.Text;
            cliente.cl_telefone = txtClienteTelefone.Text;
            cliente.cl_plano = txtClientePlano.Text;

            context.tb_cliente.Update(cliente);
            context.SaveChanges();

            XtraMessageBox.Show("Cliente atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            this.Close();

        }

        private void form_ClienteEditar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }

        }
    }
}