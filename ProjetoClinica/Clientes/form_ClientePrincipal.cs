using DevExpress.Data.Linq;
using System;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraBars.Docking2010;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using ProjetoClinica.Context;
using ProjetoClinica.Models;
using DevExpress.XtraEditors;
using ProjetoClinica.Properties;
using ProjetoClinica.Utilidade;

namespace ProjetoClinica.Clientes
{
    public partial class form_ClientePrincipal : DevExpress.XtraEditors.XtraForm
    {

        projeto_clinicaContext context = new projeto_clinicaContext();

        public form_ClientePrincipal()
        {
            InitializeComponent();
            CarregarTabelaClientes();
        }

        public void CarregarTabelaClientes()
        {
            LinqInstantFeedbackSource linqInstantFeedbackSource = new LinqInstantFeedbackSource();

            linqInstantFeedbackSource.KeyExpression = "cl_id";
            linqInstantFeedbackSource.DefaultSorting = "cl_nome ASC";
            linqInstantFeedbackSource.GetQueryable += LinqInstantFeedbackSource_GetQueryable;
            gridClientes.DataSource = linqInstantFeedbackSource;
        }

        public void LinqInstantFeedbackSource_GetQueryable(object sender, GetQueryableEventArgs e)
        {
            projeto_clinicaContext context = new projeto_clinicaContext();


            var query = from cliente in context.tb_cliente
                        orderby cliente.cl_nome ascending
                        select new
                        {
                            cliente.cl_id,
                            cliente.cl_nome,
                            cliente.cl_cpf,
                            cliente.cl_data_nascimento,
                            cliente.cl_email,
                            cliente.cl_telefone,
                            cliente.cl_plano
                        };

            e.QueryableSource = query;

        }


        private void viewClientes_PopupMenuShowing(object sender, PopupMenuShowingEventArgs e)
        {
            if (e.HitInfo.HitTest == GridHitTest.RowCell)
            {
                e.Allow = false;
                popupClientes.ShowPopup((gridClientes.PointToScreen(e.Point)));
            }
        }

        private void popupClienteEditar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var linhaSelecionada = viewClientes.GetFocusedRowCellValue("cl_id");
            int idCliente = Convert.ToInt32(linhaSelecionada);

            form_ClienteEditar clienteEditar = new form_ClienteEditar();
            clienteEditar.ClienteID = idCliente;

            clienteEditar.ShowDialog();
            CarregarTabelaClientes();

        }

        private void popupClienteDeletar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var linhaSelecionada = viewClientes.GetFocusedRowCellValue("cl_id");
            int idCliente = Convert.ToInt32(linhaSelecionada);

            DialogResult result = XtraMessageBox.Show("Tem certeza que deseja deletar?", "Aviso",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);



            if (result == DialogResult.Yes)
            {
                using (projeto_clinicaContext context = new projeto_clinicaContext())
                {
                    var cliente = context.tb_cliente.Find(idCliente);
                    context.tb_cliente.Remove(cliente);
                    context.SaveChanges();

                    XtraMessageBox.Show("Cliente deletado com sucesso!", "Sucesso", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    panelMiniPerfilCliente.Visible = false;
                    CarregarTabelaClientes();
                    form_ClientePrincipal_Click(sender, e);
                }

            }


        }

        private void viewClientes_RowCellClick(object sender, RowCellClickEventArgs e)
        {
            var linhaId = viewClientes.GetFocusedRowCellValue("cl_id");
            var cliente = context.tb_cliente.FirstOrDefault(p => p.cl_id == (int)linhaId);

            if (cliente != null)
            {

                lblClienteNomeIdadeMini.Text = $"{cliente.cl_nome}, {CalcIdade.CalcularIdadeCliente(cliente.cl_id)}";
                lblClienteCpfPerfilMini.Text = cliente.cl_cpf;
                lblClienteEmailPerfilMini.Text = cliente.cl_email;
                lblClienteNascPerfilMini.Text = cliente.cl_data_nascimento;
                lblClienteTelePerfilMini.Text = cliente.cl_telefone;

                if (cliente.cl_foto[0] == 0x00)
                {
                    imgClientePerfil.Image = Properties.Resources.ImagemPadrao;
                } else
                {
                    imgClientePerfil.Image = ConversorImagem.ConvertByteArrayToImg(cliente.cl_foto);
                }


                panelMiniPerfilCliente.Visible = true;
                btnPanelClientePMED.Visible = true;

            } else
            {
                panelMiniPerfilCliente.Visible = false;
                btnPanelClientePMED.Visible = false;
            }
        }

        private void btnPanelVoltarNovo_ButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
        {
            WindowsUIButton btn = e.Button as WindowsUIButton;

            if (btn != null && btn.Tag.Equals("Voltar"))
            {
                this.Close();
            }

            if (btn != null && btn.Tag.Equals("Novo"))
            {
                form_ClienteAdd clienteAdd = new form_ClienteAdd();
                clienteAdd.ShowDialog();
                CarregarTabelaClientes();
            }
        }

        private void btnPanelClientePMED_ButtonClick(object sender, ButtonEventArgs e)
        {
            var linhaSelecionada = viewClientes.GetFocusedRowCellValue("cl_id");
            int idCliente = Convert.ToInt32(linhaSelecionada);


            WindowsUIButton btn = e.Button as WindowsUIButton;

            if (btn != null && btn.Tag.Equals("Perfil"))
            {
                form_ClientePerfil clientePerfil = new form_ClientePerfil();
                clientePerfil.ClienteID = idCliente;
                clientePerfil.ShowDialog();
            }

            if (btn != null && btn.Tag.Equals("Editar"))
            {
                popupClienteEditar.PerformClick();
                //form_ClienteEditar clienteEdit = new form_ClienteEditar();
                //clienteEdit.ClienteID = idCliente;
                //clienteEdit.ShowDialog();
                //CarregarTabelaClientes();

            }

            if (btn != null && btn.Tag.Equals("Deletar"))
            {
                popupClienteDeletar.PerformClick();
            }
        }
        private void form_ClientePrincipal_Click(object sender, EventArgs e)
        {
            panelMiniPerfilCliente.Visible = false;
            btnPanelClientePMED.Visible = false;
        }

        private void form_ClientePrincipal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }

        }
    }
}