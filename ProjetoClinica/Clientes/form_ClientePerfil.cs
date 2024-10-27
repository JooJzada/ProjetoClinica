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
using ProjetoClinica.Utilidade;
using System.Globalization;
using DevExpress.XtraBars.Docking2010;
using ProjetoClinica.Properties;

namespace ProjetoClinica.Clientes
{
    public partial class form_ClientePerfil : DevExpress.XtraEditors.XtraForm
    {
        projeto_clinicaContext context = new projeto_clinicaContext();


        private int _clienteId;
        int anoAtual = DateTime.Now.Year;

        public int ClienteID
        {
            get { return _clienteId; }
            set
            {
                _clienteId = value;
                var cliente = context.tb_cliente.Find(_clienteId);

                lblClienteNascPerfil.Text = cliente.cl_data_nascimento;
                lblClienteNomeIdadePerfil.Text = $"{cliente.cl_nome}, {CalcIdade.CalcularIdadeCliente(cliente.cl_id)}";
                lblClienteCpfPerfil.Text = cliente.cl_cpf;
                lblClienteEmailPerfil.Text = cliente.cl_email;
                lblClienteTelePerfil.Text = cliente.cl_telefone;
                lblClientePlanoPerfil.Text = cliente.cl_plano;
                if (cliente.cl_foto[0] == 0x00)
                {
                    imgClientePerfil.Image = Resources.ImagemPadrao;
                } else
                {
                    imgClientePerfil.Image = ConversorImagem.ConvertByteArrayToImg(cliente.cl_foto);
                }
            }
        }

        public form_ClientePerfil()
        {
            InitializeComponent();
        }

        private void windowsUIButtonPanel1_ButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
        {
            WindowsUIButton btn = (WindowsUIButton)e.Button;
            if (btn != null && btn.Tag.Equals("Voltar"))
            {
                this.Close();
            }
        }
    }
}