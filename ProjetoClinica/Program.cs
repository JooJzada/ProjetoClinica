using System;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;
using DevExpress.Xpo.DB;
using ProjetoClinica.Login;
using ProjetoClinica.Medico;
using ProjetoClinica.Models;
using ProjetoClinica.XPO.Database;


namespace ProjetoClinica
{
    internal static class Program
    {
        static public bool isLogged { get; set; }
        static public tb_funcionarios usuarioLogado { get; set; }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ConnectionHelper.Connect(AutoCreateOption.None);

            Thread.CurrentThread.CurrentUICulture = CultureInfo.CreateSpecificCulture("pt-BR");

            form_Login formLogin = new form_Login();
            formLogin.ShowDialog();

            if (isLogged == false)
            {
                return;
            }

            if (Program.usuarioLogado.fun_CargoPrimario == "Médico")
            {
                form_AgendaPessoal agendaPessoal = new form_AgendaPessoal();
                agendaPessoal.ShowDialog();
            } else
                Application.Run(new form_TelaInicial());
        }
    }
}
