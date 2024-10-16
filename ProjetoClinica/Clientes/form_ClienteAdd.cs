﻿using DevExpress.XtraEditors;
using ProjetoClinica.Models;
using ProjetoClinica.Utilidade;
using System;
using System.Windows.Forms;
using ProjetoClinica.Context;

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
            if (imgCliente == null)
            {
                XtraMessageBox.Show("Anexe uma imagem do cliente!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            tb_cliente novoCliente = new tb_cliente();
            novoCliente.cl_nome = txtClienteNome.Text;
            novoCliente.cl_foto = ConversorImagem.ConvertImgToByte(imgCliente.Image);
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