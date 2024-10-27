using DevExpress.XtraEditors;
using DevExpress.XtraScheduler;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoClinica.Medico
{
    public partial class form_AgendaPessoal : DevExpress.XtraEditors.XtraForm
    {
        public form_AgendaPessoal()
        {
            InitializeComponent();


            schedulerControl1.OptionsCustomization.AllowAppointmentCreate = UsedAppointmentType.None;
            schedulerControl1.OptionsCustomization.AllowAppointmentEdit = UsedAppointmentType.None;
            schedulerControl1.OptionsCustomization.AllowAppointmentDelete = UsedAppointmentType.None;
            schedulerControl1.OptionsCustomization.AllowAppointmentDrag = UsedAppointmentType.None;
            schedulerControl1.OptionsCustomization.AllowAppointmentResize = UsedAppointmentType.None;
        }

        private void form_AgendaPessoal_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'calendarioDataSet.Resources'. Você pode movê-la ou removê-la conforme necessário.
            this.resourcesTableAdapter.Fill(this.calendarioDataSet.Resources);
            // TODO: esta linha de código carrega dados na tabela 'calendarioDataSet.Appointments'. Você pode movê-la ou removê-la conforme necessário.
            this.appointmentsTableAdapter.Fill(this.calendarioDataSet.Appointments);

            lblBemVindo.Text = $"Olá, {Program.usuarioLogado.fun_Nome}";

            webView21.Source = new Uri("https://www.gov.br/saude/pt-br/assuntos/noticias-para-os-estados");

        }
        
        
    }
}