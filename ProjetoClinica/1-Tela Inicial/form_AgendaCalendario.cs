using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoClinica._1_Tela_Inicial
{
    public partial class form_AgendaCalendario : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public form_AgendaCalendario()
        {
            InitializeComponent();
        }

        private void form_AgendaCalendario_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'calendarioDataSet.Resources'. Você pode movê-la ou removê-la conforme necessário.
            this.resourcesTableAdapter.Fill(this.calendarioDataSet.Resources);
            // TODO: esta linha de código carrega dados na tabela 'calendarioDataSet.Appointments'. Você pode movê-la ou removê-la conforme necessário.
            this.appointmentsTableAdapter.Fill(this.calendarioDataSet.Appointments);

            schedulerControl1.GoToToday();

        }

        private void schedulerDataStorage1_AppointmentsChanged(object sender, DevExpress.XtraScheduler.PersistentObjectsEventArgs e)
        {
            appointmentsTableAdapter.Update(calendarioDataSet);
            calendarioDataSet.AcceptChanges();
        }


    }
}