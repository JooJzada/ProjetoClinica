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
using DevExpress.Data.Linq;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using ProjetoClinica.Context;
using ProjetoClinica.Funcionários;
using ProjetoClinica.Models;

namespace ProjetoClinica
{
    public partial class form_FuncionarioPrincipal : DevExpress.XtraEditors.XtraForm
    {
        public form_FuncionarioPrincipal()
        {
            InitializeComponent();
            CarregarTabelaFuncionario();
        }

        public void CarregarTabelaFuncionario()
        {
            LinqInstantFeedbackSource linqInstantFeedbackSource = new LinqInstantFeedbackSource();

            linqInstantFeedbackSource.KeyExpression = "fun_ID";
            linqInstantFeedbackSource.DefaultSorting = "fun_Nome ASC";

            linqInstantFeedbackSource.GetQueryable += LinqInstantFeedbackSource_GetQueryable;
            gridFuncionarios.DataSource = linqInstantFeedbackSource;


        }

        public void LinqInstantFeedbackSource_GetQueryable(object sender, GetQueryableEventArgs e)
        {
            projeto_clinicaContext context = new projeto_clinicaContext();

            var query =
                from funcionario in context.tb_funcionarios
                orderby funcionario.fun_Nome ascending
                select new
                {

                    funcionario.fun_ID,
                    funcionario.fun_Nome,
                    funcionario.fun_DataNascimento,
                    funcionario.fun_CargoPrimario,
                    funcionario.fun_CargoFuncao,
                    funcionario.fun_Email,
                    funcionario.fun_Telefone,
                    funcionario.fun_CPF,
                    funcionario.fun_Salario,
                    funcionario.fun_MedCRM,
                };
            e.QueryableSource = query;
        }

        private void btnDeletarFuncionario_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var linhaSelecionada = viewFuncionarios.GetFocusedRowCellValue("fun_ID");
            int idFuncionario = Convert.ToInt32(linhaSelecionada);

            using (projeto_clinicaContext context = new projeto_clinicaContext())
            {
                var funcionario = context.tb_funcionarios.Find(idFuncionario);
                context.tb_funcionarios.Remove(funcionario);
                context.SaveChanges();
                
                XtraMessageBox.Show("Funcionário Deletado com sucesso!", "Sucesso", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                CarregarTabelaFuncionario();
            }

        }

        private void viewFuncionarios_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
        {
            if (e.HitInfo.HitTest == GridHitTest.RowCell)
            {
                e.Allow = false;
                popupFuncionarios.ShowPopup((gridFuncionarios.PointToScreen(e.Point)));
            }

        }

        private void btnEditarFuncionario_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var linhaSelecionada = viewFuncionarios.GetFocusedRowCellValue("fun_ID");
            int idFuncionario = Convert.ToInt32(linhaSelecionada);

            form_FuncionarioEditar formFuncionarioEditar = new form_FuncionarioEditar();
            formFuncionarioEditar.FuncionarioID = idFuncionario;

            formFuncionarioEditar.ShowDialog();
            CarregarTabelaFuncionario();
        }

        private void btnAbrirPerfil_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var linhaSelecionada = viewFuncionarios.GetFocusedRowCellValue("fun_ID");
            int idFuncionario = Convert.ToInt32(linhaSelecionada);

            form_FuncionarioPerfil formFuncionarioPerfil = new form_FuncionarioPerfil();
            formFuncionarioPerfil.FuncionarioID = idFuncionario;
            formFuncionarioPerfil.ShowDialog();
        }
    }
}