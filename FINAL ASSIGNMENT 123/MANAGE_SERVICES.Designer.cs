namespace FINAL_ASSIGNMENT_123
{
    partial class MANAGE_SERVICES
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
            this.SERVICES = new System.Windows.Forms.Label();
            this.ADD_SERVICES = new System.Windows.Forms.Button();
            this.EDIT_SERVICE = new System.Windows.Forms.Button();
            this.DELETE_SERVICE = new System.Windows.Forms.Button();
            this.BACK = new System.Windows.Forms.Button();
            this.servicesBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.cARSHOP123DataSet1 = new FINAL_ASSIGNMENT_123.CARSHOP123DataSet1();
            this.servicesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.servicesTableAdapter = new FINAL_ASSIGNMENT_123.CARSHOP123DataSet1TableAdapters.ServicesTableAdapter();
            this.servicesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.serviceIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estimatedTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.servicesBindingSource7 = new System.Windows.Forms.BindingSource(this.components);
            this.cARSHOP123DataSet11 = new FINAL_ASSIGNMENT_123.CARSHOP123DataSet1();
            this.servicesBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.servicesBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.servicesBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.servicesBindingSource6 = new System.Windows.Forms.BindingSource(this.components);
            this.cARSHOP123DataSet2 = new FINAL_ASSIGNMENT_123.CARSHOP123DataSet2();
            this.cARSHOP123DataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.servicesBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cARSHOP123DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicesBindingSource7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cARSHOP123DataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicesBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicesBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicesBindingSource5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicesBindingSource6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cARSHOP123DataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cARSHOP123DataSet2BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // SERVICES
            // 
            this.SERVICES.AutoSize = true;
            this.SERVICES.Font = new System.Drawing.Font("Cooper Black", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SERVICES.Location = new System.Drawing.Point(352, 11);
            this.SERVICES.Name = "SERVICES";
            this.SERVICES.Size = new System.Drawing.Size(164, 32);
            this.SERVICES.TabIndex = 0;
            this.SERVICES.Text = "SERVICES";
            // 
            // ADD_SERVICES
            // 
            this.ADD_SERVICES.Location = new System.Drawing.Point(78, 479);
            this.ADD_SERVICES.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ADD_SERVICES.Name = "ADD_SERVICES";
            this.ADD_SERVICES.Size = new System.Drawing.Size(148, 49);
            this.ADD_SERVICES.TabIndex = 1;
            this.ADD_SERVICES.Text = "ADD SERVICES";
            this.ADD_SERVICES.UseVisualStyleBackColor = true;
            this.ADD_SERVICES.Click += new System.EventHandler(this.ADD_SERVICES_Click);
            // 
            // EDIT_SERVICE
            // 
            this.EDIT_SERVICE.Location = new System.Drawing.Point(281, 479);
            this.EDIT_SERVICE.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.EDIT_SERVICE.Name = "EDIT_SERVICE";
            this.EDIT_SERVICE.Size = new System.Drawing.Size(148, 49);
            this.EDIT_SERVICE.TabIndex = 2;
            this.EDIT_SERVICE.Text = "EDIT SERVICE";
            this.EDIT_SERVICE.UseVisualStyleBackColor = true;
            this.EDIT_SERVICE.Click += new System.EventHandler(this.EDIT_SERVICE_Click);
            // 
            // DELETE_SERVICE
            // 
            this.DELETE_SERVICE.Location = new System.Drawing.Point(471, 479);
            this.DELETE_SERVICE.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DELETE_SERVICE.Name = "DELETE_SERVICE";
            this.DELETE_SERVICE.Size = new System.Drawing.Size(164, 49);
            this.DELETE_SERVICE.TabIndex = 3;
            this.DELETE_SERVICE.Text = "DELETE SERVICE";
            this.DELETE_SERVICE.UseVisualStyleBackColor = true;
            this.DELETE_SERVICE.Click += new System.EventHandler(this.DELETE_SERVICE_Click);
            // 
            // BACK
            // 
            this.BACK.Location = new System.Drawing.Point(691, 479);
            this.BACK.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BACK.Name = "BACK";
            this.BACK.Size = new System.Drawing.Size(148, 49);
            this.BACK.TabIndex = 8;
            this.BACK.Text = "BACK";
            this.BACK.UseVisualStyleBackColor = true;
            this.BACK.Click += new System.EventHandler(this.BACK_Click);
            // 
            // servicesBindingSource2
            // 
            this.servicesBindingSource2.DataMember = "Services";
            this.servicesBindingSource2.DataSource = this.cARSHOP123DataSet1;
            // 
            // cARSHOP123DataSet1
            // 
            this.cARSHOP123DataSet1.DataSetName = "CARSHOP123DataSet1";
            this.cARSHOP123DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // servicesBindingSource
            // 
            this.servicesBindingSource.DataMember = "Services";
            this.servicesBindingSource.DataSource = this.cARSHOP123DataSet1;
            // 
            // servicesTableAdapter
            // 
            this.servicesTableAdapter.ClearBeforeFill = true;
            // 
            // servicesBindingSource1
            // 
            this.servicesBindingSource1.DataMember = "Services";
            this.servicesBindingSource1.DataSource = this.cARSHOP123DataSet1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.serviceIDDataGridViewTextBoxColumn,
            this.serviceTypeDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.estimatedTimeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.servicesBindingSource7;
            this.dataGridView1.Location = new System.Drawing.Point(42, 78);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(760, 315);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // serviceIDDataGridViewTextBoxColumn
            // 
            this.serviceIDDataGridViewTextBoxColumn.DataPropertyName = "serviceID";
            this.serviceIDDataGridViewTextBoxColumn.HeaderText = "serviceID";
            this.serviceIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.serviceIDDataGridViewTextBoxColumn.Name = "serviceIDDataGridViewTextBoxColumn";
            this.serviceIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.serviceIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // serviceTypeDataGridViewTextBoxColumn
            // 
            this.serviceTypeDataGridViewTextBoxColumn.DataPropertyName = "serviceType";
            this.serviceTypeDataGridViewTextBoxColumn.HeaderText = "serviceType";
            this.serviceTypeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.serviceTypeDataGridViewTextBoxColumn.Name = "serviceTypeDataGridViewTextBoxColumn";
            this.serviceTypeDataGridViewTextBoxColumn.Width = 125;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "description";
            this.descriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.Width = 125;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "price";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.Width = 125;
            // 
            // estimatedTimeDataGridViewTextBoxColumn
            // 
            this.estimatedTimeDataGridViewTextBoxColumn.DataPropertyName = "estimatedTime";
            this.estimatedTimeDataGridViewTextBoxColumn.HeaderText = "estimatedTime";
            this.estimatedTimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.estimatedTimeDataGridViewTextBoxColumn.Name = "estimatedTimeDataGridViewTextBoxColumn";
            this.estimatedTimeDataGridViewTextBoxColumn.Width = 125;
            // 
            // servicesBindingSource7
            // 
            this.servicesBindingSource7.DataMember = "Services";
            this.servicesBindingSource7.DataSource = this.cARSHOP123DataSet11;
            // 
            // cARSHOP123DataSet11
            // 
            this.cARSHOP123DataSet11.DataSetName = "CARSHOP123DataSet1";
            this.cARSHOP123DataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // servicesBindingSource3
            // 
            this.servicesBindingSource3.DataMember = "Services";
            this.servicesBindingSource3.DataSource = this.cARSHOP123DataSet1;
            // 
            // servicesBindingSource4
            // 
            this.servicesBindingSource4.DataMember = "Services";
            this.servicesBindingSource4.DataSource = this.cARSHOP123DataSet1;
            // 
            // servicesBindingSource5
            // 
            this.servicesBindingSource5.DataMember = "Services";
            this.servicesBindingSource5.DataSource = this.cARSHOP123DataSet11;
            // 
            // servicesBindingSource6
            // 
            this.servicesBindingSource6.DataMember = "Services";
            this.servicesBindingSource6.DataSource = this.cARSHOP123DataSet11;
            // 
            // cARSHOP123DataSet2
            // 
            this.cARSHOP123DataSet2.DataSetName = "CARSHOP123DataSet2";
            this.cARSHOP123DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cARSHOP123DataSet2BindingSource
            // 
            this.cARSHOP123DataSet2BindingSource.DataSource = this.cARSHOP123DataSet2;
            this.cARSHOP123DataSet2BindingSource.Position = 0;
            // 
            // MANAGE_SERVICES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 548);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BACK);
            this.Controls.Add(this.DELETE_SERVICE);
            this.Controls.Add(this.EDIT_SERVICE);
            this.Controls.Add(this.ADD_SERVICES);
            this.Controls.Add(this.SERVICES);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MANAGE_SERVICES";
            this.Text = "MANAGE_SERVICES";
            this.Load += new System.EventHandler(this.MANAGE_SERVICES_Load);
            ((System.ComponentModel.ISupportInitialize)(this.servicesBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cARSHOP123DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicesBindingSource7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cARSHOP123DataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicesBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicesBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicesBindingSource5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicesBindingSource6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cARSHOP123DataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cARSHOP123DataSet2BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SERVICES;
        private System.Windows.Forms.Button ADD_SERVICES;
        private System.Windows.Forms.Button EDIT_SERVICE;
        private System.Windows.Forms.Button DELETE_SERVICE;
        private System.Windows.Forms.Button BACK;
        private CARSHOP123DataSet1 cARSHOP123DataSet1;
        private System.Windows.Forms.BindingSource servicesBindingSource;
        private CARSHOP123DataSet1TableAdapters.ServicesTableAdapter servicesTableAdapter;
        private System.Windows.Forms.BindingSource servicesBindingSource1;
        private System.Windows.Forms.BindingSource servicesBindingSource2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource servicesBindingSource4;
        private System.Windows.Forms.BindingSource servicesBindingSource3;
        private CARSHOP123DataSet1 cARSHOP123DataSet11;
        private System.Windows.Forms.BindingSource servicesBindingSource5;
        private System.Windows.Forms.BindingSource servicesBindingSource6;
        private System.Windows.Forms.BindingSource cARSHOP123DataSet2BindingSource;
        private CARSHOP123DataSet2 cARSHOP123DataSet2;
        private System.Windows.Forms.BindingSource servicesBindingSource7;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviceIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviceTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estimatedTimeDataGridViewTextBoxColumn;
    }
}