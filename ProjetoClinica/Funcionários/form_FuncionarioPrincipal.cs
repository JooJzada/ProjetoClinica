using DevExpress.XtraEditors;
using System;
using System.Linq;
using System.Windows.Forms;
using DevExpress.Data.Linq;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using ProjetoClinica.Context;
using ProjetoClinica.Funcionários;
using ProjetoClinica.Utilidade;
using System.Globalization;
using DevExpress.XtraBars.Docking2010;
using Microsoft.EntityFrameworkCore;
using ProjetoClinica.Funcionários.Login;

namespace ProjetoClinica
{
    public partial class form_FuncionarioPrincipal : DevExpress.XtraEditors.XtraForm
    {
        public form_FuncionarioPrincipal()
        {
            InitializeComponent();
            CarregarTabelaFuncionario();
            VerificarAcesso();
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
            using (projeto_clinicaContext context = new projeto_clinicaContext())
            {

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
        }

        private void VerificarAcesso()
        {
            if (Program.usuarioLogado.fun_admin != true)
            {
                foreach (var item in btnPanelVoltarNovo.Buttons)
                {
                    if (item is WindowsUIButton btn)
                    {
                        if (btn.Caption == "Novo")
                        {
                            btn.Visible = false;
                        }
                    }
                }
                viewFuncionarios.Columns["fun_Salario"].Visible = false;
                btnPanelFunPED.Visible = false;
            }
        }

        private void btnDeletarFuncionario_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var linhaSelecionada = viewFuncionarios.GetFocusedRowCellValue("fun_ID");
            int idFuncionario = Convert.ToInt32(linhaSelecionada);

            using (projeto_clinicaContext context = new projeto_clinicaContext())
            {
                DialogResult result = XtraMessageBox.Show($"Apagar {context.tb_funcionarios.Find(idFuncionario).fun_Nome}?", "Aviso",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    var resource = context.Resources.FirstOrDefault(f => f.fk_FunID == idFuncionario);
                    var funcionario = context.tb_funcionarios.Find(idFuncionario);

                    if (resource != null)
                    {
                        context.Resources.Remove(resource);
                    }

                    context.tb_funcionarios.Remove(funcionario);
                    context.SaveChanges();

                    XtraMessageBox.Show("Funcionário deletado com sucesso!", "Sucesso", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    CarregarTabelaFuncionario();
                }
            }
        }

        private void viewFuncionarios_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
        {
            if (Program.usuarioLogado.fun_admin == true)
            {
                if (e.HitInfo.HitTest == GridHitTest.RowCell)
                {
                    e.Allow = false;
                    popupFuncionarios.ShowPopup((gridFuncionarios.PointToScreen(e.Point)));
                }
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
        private void btnRegEdtLogin_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var linhaSelecionada = viewFuncionarios.GetFocusedRowCellValue("fun_ID");
            int idFuncionario = Convert.ToInt32(linhaSelecionada);

            form_LoginReg loginReg = new form_LoginReg();
            loginReg.FuncionarioID = idFuncionario;
            loginReg.ShowDialog();
        }

        private void viewFuncionarios_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {

            var linhaId = viewFuncionarios.GetFocusedRowCellValue("fun_ID");
            using (projeto_clinicaContext context = new projeto_clinicaContext())
            {
                var funcionario = context.tb_funcionarios.FirstOrDefault(f => f.fun_ID == (int)linhaId);
                if (funcionario != null)
                {
                    if (Program.usuarioLogado.fun_admin != true)
                    {
                        lblFuncionarioSalarioPerfil.Visible = false;
                    }

                    #region Cargo

                    if (string.IsNullOrWhiteSpace(funcionario.fun_CargoFuncao))
                    {
                        lblFuncionarioCargoPerfilMini.Text = $"{funcionario.fun_CargoPrimario}";
                    } else
                    {
                        lblFuncionarioCargoPerfilMini.Text = $"{funcionario.fun_CargoPrimario}, {funcionario.fun_CargoFuncao}";
                    }
                    #endregion

                    lblFunNomeIdadeMini.Text =
                        $"Dr(a) {funcionario.fun_Nome}, {CalcIdade.CalcularIdadeFuncionario(funcionario.fun_ID)}";
                    lblFunCpfPerfilMini.Text = funcionario.fun_CPF;
                    lblFunEmailPerfilMini.Text = funcionario.fun_Email;
                    lblFunNascPerfilMini.Text = funcionario.fun_DataNascimento;
                    lblFunTelePerfilMini.Text = funcionario.fun_Telefone;

                    lblFuncionarioCrmPerfil.Text = funcionario.fun_MedCRM;

                    if (Program.usuarioLogado.fun_admin == true)
                    {
                        lblFuncionarioSalarioPerfil.Text = $"Salário: {(funcionario.fun_Salario).ToString("C", CultureInfo.CurrentCulture)}";
                    } else
                    {
                        lblFuncionarioSalarioPerfil.Text = "";
                    }
                    if (funcionario.fun_foto[0] == 0x00 || funcionario.fun_foto == null)
                    {
                        imgFunPerfil.Image = Properties.Resources.ImagemPadrao;
                    } else
                    {
                        imgFunPerfil.Image = ConversorImagem.ConvertByteArrayToImg(funcionario.fun_foto);
                    }

                    panelMiniPerfilFun.Visible = true;
                    btnPanelFunPED.Visible = true;

                    if (Program.usuarioLogado.fun_admin != true)
                    {
                        btnPanelFunPED.Visible = false;
                    }
                } else
                {
                    panelMiniPerfilFun.Visible = false;
                }

            }
        }

        private void form_FuncionarioPrincipal_Click(object sender, EventArgs e)
        {
            panelMiniPerfilFun.Visible = false;
            btnPanelFunPED.Visible = false;
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
                form_FuncionarioAdd funcionarioAdd = new form_FuncionarioAdd();
                funcionarioAdd.ShowDialog();
                CarregarTabelaFuncionario();
            }
        }

        private void btnPanelFunPED_ButtonClick(object sender, ButtonEventArgs e)
        {
            var linhaSelecionada = viewFuncionarios.GetFocusedRowCellValue("fun_ID");
            int idCliente = Convert.ToInt32(linhaSelecionada);

            WindowsUIButton btn = e.Button as WindowsUIButton;

            if (btn != null && btn.Tag.Equals("Perfil"))
            {
                form_FuncionarioPerfil funPerfil = new form_FuncionarioPerfil();
                funPerfil.FuncionarioID = idCliente;
                funPerfil.ShowDialog();
            }

            if (btn != null && btn.Tag.Equals("Editar"))
            {
                btnEditarFuncionario.PerformClick();
            }

            if (btn != null && btn.Tag.Equals("Login"))
            {
                btnRegEdtLogin.PerformClick();
            }

            if (btn != null && btn.Tag.Equals("Deletar"))
            {
                btnDeletarFuncionario.PerformClick();
            }
        }

        private void form_FuncionarioPrincipal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}