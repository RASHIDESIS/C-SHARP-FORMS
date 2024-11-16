namespace FINAL_ASSIGNMENT_123
{
    partial class REPORTS
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
            this.REPORT = new System.Windows.Forms.Label();
            this.BACK = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.appointmentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vehicleIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mechanicIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appointmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cARSHOP123DataSet2 = new FINAL_ASSIGNMENT_123.CARSHOP123DataSet2();
            this.appointmentTableAdapter = new FINAL_ASSIGNMENT_123.CARSHOP123DataSet2TableAdapters.AppointmentTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cARSHOP123DataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // REPORT
            // 
            this.REPORT.AutoSize = true;
            this.REPORT.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.REPORT.Location = new System.Drawing.Point(314, 39);
            this.REPORT.Name = "REPORT";
            this.REPORT.Size = new System.Drawing.Size(129, 26);
            this.REPORT.TabIndex = 0;
            this.REPORT.Text = "REPORTS";
            // 
            // BACK
            // 
            this.BACK.Location = new System.Drawing.Point(643, 376);
            this.BACK.Name = "BACK";
            this.BACK.Size = new System.Drawing.Size(109, 49);
            this.BACK.TabIndex = 1;
            this.BACK.Text = "BACK";
            this.BACK.UseVisualStyleBackColor = true;
            this.BACK.Click += new System.EventHandler(this.BACK_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.appointmentIDDataGridViewTextBoxColumn,
            this.appStatusDataGridViewTextBoxColumn,
            this.appDateDataGridViewTextBoxColumn,
            this.appTimeDataGridViewTextBoxColumn,
            this.vehicleIDDataGridViewTextBoxColumn,
            this.customerIDDataGridViewTextBoxColumn,
            this.mechanicIDDataGridViewTextBoxColumn,
            this.serviceIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.appointmentBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(45, 101);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(707, 245);
            this.dataGridView1.TabIndex = 2;
            // 
            // appointmentIDDataGridViewTextBoxColumn
            // 
            this.appointmentIDDataGridViewTextBoxColumn.DataPropertyName = "appointmentID";
            this.appointmentIDDataGridViewTextBoxColumn.HeaderText = "appointmentID";
            this.appointmentIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.appointmentIDDataGridViewTextBoxColumn.Name = "appointmentIDDataGridViewTextBoxColumn";
            this.appointmentIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // appStatusDataGridViewTextBoxColumn
            // 
            this.appStatusDataGridViewTextBoxColumn.DataPropertyName = "appStatus";
            this.appStatusDataGridViewTextBoxColumn.HeaderText = "appStatus";
            this.appStatusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.appStatusDataGridViewTextBoxColumn.Name = "appStatusDataGridViewTextBoxColumn";
            this.appStatusDataGridViewTextBoxColumn.Width = 125;
            // 
            // appDateDataGridViewTextBoxColumn
            // 
            this.appDateDataGridViewTextBoxColumn.DataPropertyName = "appDate";
            this.appDateDataGridViewTextBoxColumn.HeaderText = "appDate";
            this.appDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.appDateDataGridViewTextBoxColumn.Name = "appDateDataGridViewTextBoxColumn";
            this.appDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // appTimeDataGridViewTextBoxColumn
            // 
            this.appTimeDataGridViewTextBoxColumn.DataPropertyName = "appTime";
            this.appTimeDataGridViewTextBoxColumn.HeaderText = "appTime";
            this.appTimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.appTimeDataGridViewTextBoxColumn.Name = "appTimeDataGridViewTextBoxColumn";
            this.appTimeDataGridViewTextBoxColumn.Width = 125;
            // 
            // vehicleIDDataGridViewTextBoxColumn
            // 
            this.vehicleIDDataGridViewTextBoxColumn.DataPropertyName = "vehicleID";
            this.vehicleIDDataGridViewTextBoxColumn.HeaderText = "vehicleID";
            this.vehicleIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.vehicleIDDataGridViewTextBoxColumn.Name = "vehicleIDDataGridViewTextBoxColumn";
            this.vehicleIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // customerIDDataGridViewTextBoxColumn
            // 
            this.customerIDDataGridViewTextBoxColumn.DataPropertyName = "customerID";
            this.customerIDDataGridViewTextBoxColumn.HeaderText = "customerID";
            this.customerIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.customerIDDataGridViewTextBoxColumn.Name = "customerIDDataGridViewTextBoxColumn";
            this.customerIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // mechanicIDDataGridViewTextBoxColumn
            // 
            this.mechanicIDDataGridViewTextBoxColumn.DataPropertyName = "mechanicID";
            this.mechanicIDDataGridViewTextBoxColumn.HeaderText = "mechanicID";
            this.mechanicIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mechanicIDDataGridViewTextBoxColumn.Name = "mechanicIDDataGridViewTextBoxColumn";
            this.mechanicIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // serviceIDDataGridViewTextBoxColumn
            // 
            this.serviceIDDataGridViewTextBoxColumn.DataPropertyName = "serviceID";
            this.serviceIDDataGridViewTextBoxColumn.HeaderText = "serviceID";
            this.serviceIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.serviceIDDataGridViewTextBoxColumn.Name = "serviceIDDataGridViewTextBoxColumn";
            this.serviceIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // appointmentBindingSource
            // 
            this.appointmentBindingSource.DataMember = "Appointment";
            this.appointmentBindingSource.DataSource = this.cARSHOP123DataSet2;
            // 
            // cARSHOP123DataSet2
            // 
            this.cARSHOP123DataSet2.DataSetName = "CARSHOP123DataSet2";
            this.cARSHOP123DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // appointmentTableAdapter
            // 
            this.appointmentTableAdapter.ClearBeforeFill = true;
            // 
            // REPORTS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BACK);
            this.Controls.Add(this.REPORT);
            this.Name = "REPORTS";
            this.Text = "REPORTS";
            this.Load += new System.EventHandler(this.REPORTS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cARSHOP123DataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label REPORT;
        private System.Windows.Forms.Button BACK;
        private System.Windows.Forms.DataGridView dataGridView1;
        private CARSHOP123DataSet2 cARSHOP123DataSet2;
        private System.Windows.Forms.BindingSource appointmentBindingSource;
        private CARSHOP123DataSet2TableAdapters.AppointmentTableAdapter appointmentTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn appointmentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn appStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn appDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn appTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehicleIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mechanicIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviceIDDataGridViewTextBoxColumn;
    }
}