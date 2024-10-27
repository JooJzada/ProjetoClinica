using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraScheduler;
using ProjetoClinica._1_Tela_Inicial;
using ProjetoClinica.Clientes;
using ProjetoClinica.Enum;
using ProjetoClinica.Funcionários;
using ProjetoClinica.Utilidade;

namespace ProjetoClinica {
    public partial class form_TelaInicial : DevExpress.XtraEditors.XtraForm {
        public form_TelaInicial() {
            InitializeComponent();
            VerificarAcesso();

            schedulerControl1.OptionsCustomization.AllowAppointmentCreate = UsedAppointmentType.None;
            schedulerControl1.OptionsCustomization.AllowAppointmentEdit = UsedAppointmentType.None;
            schedulerControl1.OptionsCustomization.AllowAppointmentDelete = UsedAppointmentType.None;
            schedulerControl1.OptionsCustomization.AllowAppointmentDrag = UsedAppointmentType.None;
            schedulerControl1.OptionsCustomization.AllowAppointmentResize = UsedAppointmentType.None;
        }

        private void VerificarAcesso()
        {
            if (Program.usuarioLogado.fun_admin != true)
            {
                btnFuncionarioPrincipalMenu.Visibility = BarItemVisibility.Never;
                btnFuncionarioAddMenu.Visibility = BarItemVisibility.Never;
            }
            

        }

        

        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraScheduler.TimeRuler timeRuler4 = new DevExpress.XtraScheduler.TimeRuler();
            DevExpress.XtraScheduler.TimeRuler timeRuler5 = new DevExpress.XtraScheduler.TimeRuler();
            DevExpress.XtraScheduler.TimeRuler timeRuler6 = new DevExpress.XtraScheduler.TimeRuler();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barFuncionarioMenu = new DevExpress.XtraBars.BarSubItem();
            this.btnFuncionarioPrincipalMenu = new DevExpress.XtraBars.BarButtonItem();
            this.btnFuncionarioAddMenu = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItem2 = new DevExpress.XtraBars.BarSubItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnAgenda = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.pnlAgenda = new DevExpress.XtraEditors.PanelControl();
            this.schedulerControl1 = new DevExpress.XtraScheduler.SchedulerControl();
            this.schedulerDataStorage1 = new DevExpress.XtraScheduler.SchedulerDataStorage(this.components);
            this.appointmentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.calendarioDataSet = new ProjetoClinica.CalendarioDataSet();
            this.resourcesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appointmentsTableAdapter = new ProjetoClinica.CalendarioDataSetTableAdapters.AppointmentsTableAdapter();
            this.resourcesTableAdapter = new ProjetoClinica.CalendarioDataSetTableAdapters.ResourcesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlAgenda)).BeginInit();
            this.pnlAgenda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerDataStorage1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calendarioDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resourcesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barFuncionarioMenu,
            this.btnFuncionarioPrincipalMenu,
            this.btnFuncionarioAddMenu,
            this.barSubItem2,
            this.barButtonItem1,
            this.barButtonItem2,
            this.barBtnAgenda});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 7;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barFuncionarioMenu),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem2),
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtnAgenda)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // barFuncionarioMenu
            // 
            this.barFuncionarioMenu.Caption = "Funcionários";
            this.barFuncionarioMenu.Id = 0;
            this.barFuncionarioMenu.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnFuncionarioPrincipalMenu),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnFuncionarioAddMenu)});
            this.barFuncionarioMenu.Name = "barFuncionarioMenu";
            this.barFuncionarioMenu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barFuncionarioMenu_ItemClick);
            // 
            // btnFuncionarioPrincipalMenu
            // 
            this.btnFuncionarioPrincipalMenu.Caption = "Tela Principal";
            this.btnFuncionarioPrincipalMenu.Id = 1;
            this.btnFuncionarioPrincipalMenu.Name = "btnFuncionarioPrincipalMenu";
            this.btnFuncionarioPrincipalMenu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnFuncionarioPrincipalMenu_ItemClick);
            // 
            // btnFuncionarioAddMenu
            // 
            this.btnFuncionarioAddMenu.Caption = "Adicionar Funcionário";
            this.btnFuncionarioAddMenu.Id = 2;
            this.btnFuncionarioAddMenu.Name = "btnFuncionarioAddMenu";
            this.btnFuncionarioAddMenu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnFuncionarioAddMenu_ItemClick_1);
            // 
            // barSubItem2
            // 
            this.barSubItem2.Caption = "Clientes";
            this.barSubItem2.Id = 3;
            this.barSubItem2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem2)});
            this.barSubItem2.Name = "barSubItem2";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Tela Principal";
            this.barButtonItem1.Id = 4;
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Adicionar cliente";
            this.barButtonItem2.Id = 5;
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
            // 
            // barBtnAgenda
            // 
            this.barBtnAgenda.Caption = "Agendas";
            this.barBtnAgenda.Id = 6;
            this.barBtnAgenda.Name = "barBtnAgenda";
            this.barBtnAgenda.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnAgenda_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1280, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 690);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1280, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 666);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1280, 24);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 666);
            // 
            // pnlAgenda
            // 
            this.pnlAgenda.Controls.Add(this.schedulerControl1);
            this.pnlAgenda.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlAgenda.Location = new System.Drawing.Point(999, 24);
            this.pnlAgenda.Name = "pnlAgenda";
            this.pnlAgenda.Size = new System.Drawing.Size(281, 666);
            this.pnlAgenda.TabIndex = 5;
            // 
            // schedulerControl1
            // 
            this.schedulerControl1.ActiveViewType = DevExpress.XtraScheduler.SchedulerViewType.Agenda;
            this.schedulerControl1.DataStorage = this.schedulerDataStorage1;
            this.schedulerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.schedulerControl1.Location = new System.Drawing.Point(2, 2);
            this.schedulerControl1.MenuManager = this.barManager1;
            this.schedulerControl1.Name = "schedulerControl1";
            this.schedulerControl1.Size = new System.Drawing.Size(277, 662);
            this.schedulerControl1.Start = new System.DateTime(2024, 10, 21, 0, 0, 0, 0);
            this.schedulerControl1.TabIndex = 0;
            this.schedulerControl1.Text = "schedulerControl1";
            this.schedulerControl1.Views.DayView.TimeRulers.Add(timeRuler4);
            this.schedulerControl1.Views.FullWeekView.Enabled = true;
            this.schedulerControl1.Views.FullWeekView.TimeRulers.Add(timeRuler5);
            this.schedulerControl1.Views.WeekView.Enabled = false;
            this.schedulerControl1.Views.WorkWeekView.TimeRulers.Add(timeRuler6);
            this.schedulerControl1.Views.YearView.UseOptimizedScrolling = false;
            // 
            // schedulerDataStorage1
            // 
            // 
            // 
            // 
            this.schedulerDataStorage1.AppointmentDependencies.AutoReload = false;
            // 
            // 
            // 
            this.schedulerDataStorage1.Appointments.DataSource = this.appointmentsBindingSource;
            this.schedulerDataStorage1.Appointments.Labels.CreateNewLabel(0, "None", "&None", System.Drawing.SystemColors.Window);
            this.schedulerDataStorage1.Appointments.Labels.CreateNewLabel(1, "Important", "&Important", System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(194)))), ((int)(((byte)(190))))));
            this.schedulerDataStorage1.Appointments.Labels.CreateNewLabel(2, "Business", "&Business", System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(213)))), ((int)(((byte)(255))))));
            this.schedulerDataStorage1.Appointments.Labels.CreateNewLabel(3, "Personal", "&Personal", System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(244)))), ((int)(((byte)(156))))));
            this.schedulerDataStorage1.Appointments.Labels.CreateNewLabel(4, "Vacation", "&Vacation", System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(228)))), ((int)(((byte)(199))))));
            this.schedulerDataStorage1.Appointments.Labels.CreateNewLabel(5, "Must Attend", "Must &Attend", System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(206)))), ((int)(((byte)(147))))));
            this.schedulerDataStorage1.Appointments.Labels.CreateNewLabel(6, "Travel Required", "&Travel Required", System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(244)))), ((int)(((byte)(255))))));
            this.schedulerDataStorage1.Appointments.Labels.CreateNewLabel(7, "Needs Preparation", "&Needs Preparation", System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(219)))), ((int)(((byte)(152))))));
            this.schedulerDataStorage1.Appointments.Labels.CreateNewLabel(8, "Birthday", "&Birthday", System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(207)))), ((int)(((byte)(233))))));
            this.schedulerDataStorage1.Appointments.Labels.CreateNewLabel(9, "Anniversary", "&Anniversary", System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(233)))), ((int)(((byte)(223))))));
            this.schedulerDataStorage1.Appointments.Labels.CreateNewLabel(10, "Phone Call", "Phone &Call", System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(247)))), ((int)(((byte)(165))))));
            this.schedulerDataStorage1.Appointments.Mappings.AllDay = "AllDay";
            this.schedulerDataStorage1.Appointments.Mappings.Description = "Description";
            this.schedulerDataStorage1.Appointments.Mappings.End = "EndDate";
            this.schedulerDataStorage1.Appointments.Mappings.Label = "Label";
            this.schedulerDataStorage1.Appointments.Mappings.Location = "Location";
            this.schedulerDataStorage1.Appointments.Mappings.OriginalOccurrenceEnd = "QueryEndDate";
            this.schedulerDataStorage1.Appointments.Mappings.OriginalOccurrenceStart = "QueryStartDate";
            this.schedulerDataStorage1.Appointments.Mappings.RecurrenceInfo = "RecurrenceInfo";
            this.schedulerDataStorage1.Appointments.Mappings.ReminderInfo = "ReminderInfo";
            this.schedulerDataStorage1.Appointments.Mappings.ResourceId = "ResourceID";
            this.schedulerDataStorage1.Appointments.Mappings.Start = "StartDate";
            this.schedulerDataStorage1.Appointments.Mappings.Status = "Status";
            this.schedulerDataStorage1.Appointments.Mappings.Subject = "Subject";
            this.schedulerDataStorage1.Appointments.Mappings.TimeZoneId = "TimeZoneId";
            this.schedulerDataStorage1.Appointments.Mappings.Type = "Type";
            // 
            // 
            // 
            this.schedulerDataStorage1.Resources.DataSource = this.resourcesBindingSource;
            this.schedulerDataStorage1.Resources.Mappings.Caption = "ResourceName";
            this.schedulerDataStorage1.Resources.Mappings.Color = "Color";
            this.schedulerDataStorage1.Resources.Mappings.Id = "ResourceID";
            this.schedulerDataStorage1.Resources.Mappings.Image = "Image";
            // 
            // appointmentsBindingSource
            // 
            this.appointmentsBindingSource.DataMember = "Appointments";
            this.appointmentsBindingSource.DataSource = this.calendarioDataSet;
            // 
            // calendarioDataSet
            // 
            this.calendarioDataSet.DataSetName = "CalendarioDataSet";
            this.calendarioDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // resourcesBindingSource
            // 
            this.resourcesBindingSource.DataMember = "Resources";
            this.resourcesBindingSource.DataSource = this.calendarioDataSet;
            // 
            // appointmentsTableAdapter
            // 
            this.appointmentsTableAdapter.ClearBeforeFill = true;
            // 
            // resourcesTableAdapter
            // 
            this.resourcesTableAdapter.ClearBeforeFill = true;
            // 
            // form_TelaInicial
            // 
            this.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.Appearance.Options.UseBackColor = true;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Tile;
            this.BackgroundImageStore = global::ProjetoClinica.Properties.Resources.Fundo_Projeto_Clinica;
            this.ClientSize = new System.Drawing.Size(1280, 690);
            this.Controls.Add(this.pnlAgenda);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.IconOptions.Image = global::ProjetoClinica.Properties.Resources.Icone_Projeto_Clinica;
            this.Name = "form_TelaInicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Clinica Eldorou";
            this.Load += new System.EventHandler(this.form_TelaInicial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlAgenda)).EndInit();
            this.pnlAgenda.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.schedulerControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerDataStorage1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calendarioDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resourcesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void btnFuncionarioPrincipalMenu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            form_FuncionarioPrincipal funcionarioPrincipal = new form_FuncionarioPrincipal();
            funcionarioPrincipal.ShowDialog();
        }


        private void btnFuncionarioAddMenu_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            form_FuncionarioAdd funcionarioAdd = new form_FuncionarioAdd();
            funcionarioAdd.ShowDialog();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            form_ClientePrincipal clientePrincipal = new form_ClientePrincipal();
            clientePrincipal.ShowDialog();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            form_ClienteAdd clienteAdd = new form_ClienteAdd();
            clienteAdd.ShowDialog();
        }

        private void barBtnAgenda_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            form_AgendaCalendario agendaCalendario = new form_AgendaCalendario();
            agendaCalendario.ShowDialog();
        }

        private void form_TelaInicial_Load(object sender, System.EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'calendarioDataSet.Resources'. Você pode movê-la ou removê-la conforme necessário.
            this.resourcesTableAdapter.Fill(this.calendarioDataSet.Resources);
            // TODO: esta linha de código carrega dados na tabela 'calendarioDataSet.Appointments'. Você pode movê-la ou removê-la conforme necessário.
            this.appointmentsTableAdapter.Fill(this.calendarioDataSet.Appointments);
            // TODO: esta linha de código carrega dados na tabela 'calendarioDataSet.Resources'. Você pode movê-la ou removê-la conforme necessário.
            this.resourcesTableAdapter.Fill(this.calendarioDataSet.Resources);
            // TODO: esta linha de código carrega dados na tabela 'calendarioDataSet.Appointments'. Você pode movê-la ou removê-la conforme necessário.
            this.appointmentsTableAdapter.Fill(this.calendarioDataSet.Appointments);

            
        }

        private void barFuncionarioMenu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Program.usuarioLogado.fun_admin != true)
            {
                btnFuncionarioPrincipalMenu.PerformClick();
            }

        }
    }
}