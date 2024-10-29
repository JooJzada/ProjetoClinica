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
using Microsoft.Data.SqlClient;
using ProjetoClinica.Context;
using System.Runtime.Remoting.Contexts;

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

        public void CarregarAppointmentsPorID(int resourceId)
        {
            //// TODO: esta linha de código carrega dados na tabela 'calendarioDataSet.Resources'. Você pode movê-la ou removê-la conforme necessário.
            this.resourcesTableAdapter.Fill(this.calendarioDataSet.Resources);
            //// TODO: esta linha de código carrega dados na tabela 'calendarioDataSet.Appointments'. Você pode movê-la ou removê-la conforme necessário.
            this.appointmentsTableAdapter.Fill(this.calendarioDataSet.Appointments);

            using (projeto_clinicaContext context = new projeto_clinicaContext())
            {
                var appointments = context.Appointments.Where(a => a.ResourceID == resourceId).ToList();
                
                schedulerDataStorage1.Appointments.Clear();

                foreach (var appointment in appointments)
                {
                    var schedulerAppoint = schedulerDataStorage1.CreateAppointment(AppointmentType.Normal);
                    schedulerAppoint.Start = appointment.StartDate.GetValueOrDefault(DateTime.Now);
                    schedulerAppoint.End = appointment.EndDate.GetValueOrDefault(DateTime.Now.AddMinutes(30));
                    schedulerAppoint.Subject = appointment.Subject;
                    schedulerAppoint.ResourceId = appointment.ResourceID;
                    schedulerAppoint.Location = appointment.Location;
                    schedulerAppoint.Description = appointment.Description;
                    schedulerAppoint.StatusKey = appointment.Status;
                    schedulerAppoint.LabelKey = appointment.Label;
                    schedulerAppoint.ResourceId = appointment.ResourceID;
                    schedulerAppoint.TimeZoneId = appointment.TimeZoneId;

                    schedulerDataStorage1.Appointments.Add(schedulerAppoint);
                }
                schedulerControl1.Refresh();
            }
        }

        private void form_AgendaPessoal_Load(object sender, EventArgs e)
        {
            lblBemVindo.Text = $"Olá, Dr(a) {Program.usuarioLogado.fun_Nome}";
            webView21.Source = new Uri("https://www.gov.br/saude/pt-br/assuntos/noticias-para-os-estados");

            using (var context = new projeto_clinicaContext())
            {
                var resource = context.Resources.FirstOrDefault(r => r.fk_FunID == Program.usuarioLogado.fun_ID);
                if (resource != null)
                {
                    CarregarAppointmentsPorID(resource.ResourceID);
                } else
                {
                    MessageBox.Show("Resource não encontrado para o usuário logado.", "Erro", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }
    }
}