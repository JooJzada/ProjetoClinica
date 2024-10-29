namespace ProjetoClinica.Medico
{
    partial class form_AgendaPessoal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraScheduler.TimeRuler timeRuler1 = new DevExpress.XtraScheduler.TimeRuler();
            DevExpress.XtraScheduler.TimeRuler timeRuler2 = new DevExpress.XtraScheduler.TimeRuler();
            DevExpress.XtraScheduler.TimeRuler timeRuler3 = new DevExpress.XtraScheduler.TimeRuler();
            this.schedulerControl1 = new DevExpress.XtraScheduler.SchedulerControl();
            this.schedulerDataStorage1 = new DevExpress.XtraScheduler.SchedulerDataStorage(this.components);
            this.appointmentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.calendarioDataSet = new ProjetoClinica.CalendarioDataSet();
            this.resourcesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appointmentsTableAdapter = new ProjetoClinica.CalendarioDataSetTableAdapters.AppointmentsTableAdapter();
            this.resourcesTableAdapter = new ProjetoClinica.CalendarioDataSetTableAdapters.ResourcesTableAdapter();
            this.lblBemVindo = new DevExpress.XtraEditors.LabelControl();
            this.webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.lblNoticias = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerDataStorage1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calendarioDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resourcesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).BeginInit();
            this.SuspendLayout();
            // 
            // schedulerControl1
            // 
            this.schedulerControl1.DataStorage = this.schedulerDataStorage1;
            this.schedulerControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.schedulerControl1.Location = new System.Drawing.Point(729, 0);
            this.schedulerControl1.Name = "schedulerControl1";
            this.schedulerControl1.Size = new System.Drawing.Size(551, 690);
            this.schedulerControl1.Start = new System.DateTime(2024, 10, 24, 0, 0, 0, 0);
            this.schedulerControl1.TabIndex = 0;
            this.schedulerControl1.Text = "schedulerControl1";
            this.schedulerControl1.Views.DayView.TimeRulers.Add(timeRuler1);
            this.schedulerControl1.Views.FullWeekView.Enabled = true;
            this.schedulerControl1.Views.FullWeekView.TimeRulers.Add(timeRuler2);
            this.schedulerControl1.Views.WeekView.Enabled = false;
            this.schedulerControl1.Views.WorkWeekView.TimeRulers.Add(timeRuler3);
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
            // lblBemVindo
            // 
            this.lblBemVindo.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold);
            this.lblBemVindo.Appearance.Options.UseFont = true;
            this.lblBemVindo.Location = new System.Drawing.Point(12, 12);
            this.lblBemVindo.Name = "lblBemVindo";
            this.lblBemVindo.Size = new System.Drawing.Size(609, 29);
            this.lblBemVindo.TabIndex = 1;
            this.lblBemVindo.Text = "Olá, Dr. Nome Completo Pereira da Silva Rodrigues";
            // 
            // webView21
            // 
            this.webView21.AllowExternalDrop = true;
            this.webView21.CreationProperties = null;
            this.webView21.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView21.Location = new System.Drawing.Point(12, 146);
            this.webView21.Name = "webView21";
            this.webView21.Size = new System.Drawing.Size(711, 531);
            this.webView21.TabIndex = 2;
            this.webView21.ZoomFactor = 1D;
            // 
            // lblNoticias
            // 
            this.lblNoticias.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.lblNoticias.Appearance.Options.UseFont = true;
            this.lblNoticias.Location = new System.Drawing.Point(12, 121);
            this.lblNoticias.Name = "lblNoticias";
            this.lblNoticias.Size = new System.Drawing.Size(107, 19);
            this.lblNoticias.TabIndex = 3;
            this.lblNoticias.Text = "Notícias Gov:";
            // 
            // form_AgendaPessoal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 690);
            this.Controls.Add(this.lblNoticias);
            this.Controls.Add(this.webView21);
            this.Controls.Add(this.lblBemVindo);
            this.Controls.Add(this.schedulerControl1);
            this.IconOptions.Image = global::ProjetoClinica.Properties.Resources.Icone_Projeto_Clinica;
            this.Name = "form_AgendaPessoal";
            this.Text = "Agenda";
            this.Load += new System.EventHandler(this.form_AgendaPessoal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.schedulerControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerDataStorage1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calendarioDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resourcesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraScheduler.SchedulerControl schedulerControl1;
        private DevExpress.XtraScheduler.SchedulerDataStorage schedulerDataStorage1;
        private CalendarioDataSet calendarioDataSet;
        private System.Windows.Forms.BindingSource appointmentsBindingSource;
        private CalendarioDataSetTableAdapters.AppointmentsTableAdapter appointmentsTableAdapter;
        private System.Windows.Forms.BindingSource resourcesBindingSource;
        private CalendarioDataSetTableAdapters.ResourcesTableAdapter resourcesTableAdapter;
        private DevExpress.XtraEditors.LabelControl lblBemVindo;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
        private DevExpress.XtraEditors.LabelControl lblNoticias;
    }
}