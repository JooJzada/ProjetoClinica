using DevExpress.Data.Linq;
using System;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using ProjetoClinica.Context;
using ProjetoClinica.Models;
using DevExpress.XtraEditors;

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

        private void viewClientes_RowClick(object sender, RowClickEventArgs e)
        {
            GridView view = sender as GridView;

            if (e.RowHandle >= 0)
            {
                var linhaSelecionada = view.GetRowCellValue(e.RowHandle, "cl_id");
                int idCliente = Convert.ToInt32(linhaSelecionada);
                MessageBox.Show(Convert.ToString(idCliente));
            }

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

            using (projeto_clinicaContext context = new projeto_clinicaContext())
            {
                var cliente = context.tb_cliente.Find(idCliente);
                context.tb_cliente.Remove(cliente);
                context.SaveChanges();

                XtraMessageBox.Show("Cliente deletado com sucesso!", "Sucesso", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                CarregarTabelaClientes();
            }
        }
    }
}
