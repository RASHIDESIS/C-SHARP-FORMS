namespace FINAL_ASSIGNMENT_123
{
    partial class UPDATE_SERVICE
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
            this.label5 = new System.Windows.Forms.Label();
            this.labelServiceType = new System.Windows.Forms.Label();
            this.textBoxServiceType = new System.Windows.Forms.TextBox();
            this.labelDescription = new System.Windows.Forms.Label();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelEstimatedTime = new System.Windows.Forms.Label();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.textBoxEstimatedTime = new System.Windows.Forms.TextBox();
            this.labelServiceID = new System.Windows.Forms.Label();
            this.textBoxServiceID = new System.Windows.Forms.TextBox();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.servicesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cARSHOP123DataSet1 = new FINAL_ASSIGNMENT_123.CARSHOP123DataSet1();
            this.servicesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.servicesTableAdapter = new FINAL_ASSIGNMENT_123.CARSHOP123DataSet1TableAdapters.ServicesTableAdapter();
            this.servicesBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.servicesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cARSHOP123DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicesBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Courier New", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(53, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(252, 31);
            this.label5.TabIndex = 10;
            this.label5.Text = "UPDATE SERVICE";
            // 
            // labelServiceType
            // 
            this.labelServiceType.AutoSize = true;
            this.labelServiceType.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelServiceType.Location = new System.Drawing.Point(55, 125);
            this.labelServiceType.Name = "labelServiceType";
            this.labelServiceType.Size = new System.Drawing.Size(139, 20);
            this.labelServiceType.TabIndex = 11;
            this.labelServiceType.Text = "ServiceType :";
            // 
            // textBoxServiceType
            // 
            this.textBoxServiceType.Location = new System.Drawing.Point(235, 125);
            this.textBoxServiceType.Name = "textBoxServiceType";
            this.textBoxServiceType.Size = new System.Drawing.Size(130, 22);
            this.textBoxServiceType.TabIndex = 12;
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescription.Location = new System.Drawing.Point(55, 180);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(139, 20);
            this.labelDescription.TabIndex = 13;
            this.labelDescription.Text = "Description :";
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(235, 178);
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(130, 22);
            this.textBoxDescription.TabIndex = 14;
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrice.Location = new System.Drawing.Point(55, 230);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(79, 20);
            this.labelPrice.TabIndex = 15;
            this.labelPrice.Text = "Price :";
            // 
            // labelEstimatedTime
            // 
            this.labelEstimatedTime.AutoSize = true;
            this.labelEstimatedTime.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEstimatedTime.Location = new System.Drawing.Point(55, 284);
            this.labelEstimatedTime.Name = "labelEstimatedTime";
            this.labelEstimatedTime.Size = new System.Drawing.Size(159, 20);
            this.labelEstimatedTime.TabIndex = 16;
            this.labelEstimatedTime.Text = "EstimatedTime :";
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(235, 229);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(130, 22);
            this.textBoxPrice.TabIndex = 17;
            // 
            // textBoxEstimatedTime
            // 
            this.textBoxEstimatedTime.Location = new System.Drawing.Point(235, 282);
            this.textBoxEstimatedTime.Name = "textBoxEstimatedTime";
            this.textBoxEstimatedTime.Size = new System.Drawing.Size(130, 22);
            this.textBoxEstimatedTime.TabIndex = 18;
            // 
            // labelServiceID
            // 
            this.labelServiceID.AutoSize = true;
            this.labelServiceID.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelServiceID.Location = new System.Drawing.Point(55, 83);
            this.labelServiceID.Name = "labelServiceID";
            this.labelServiceID.Size = new System.Drawing.Size(119, 20);
            this.labelServiceID.TabIndex = 19;
            this.labelServiceID.Text = "ServiceID :";
            // 
            // textBoxServiceID
            // 
            this.textBoxServiceID.Location = new System.Drawing.Point(235, 77);
            this.textBoxServiceID.Name = "textBoxServiceID";
            this.textBoxServiceID.Size = new System.Drawing.Size(130, 22);
            this.textBoxServiceID.TabIndex = 20;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(520, 77);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(130, 49);
            this.buttonUpdate.TabIndex = 21;
            this.buttonUpdate.Text = "UPDATE";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(520, 255);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(130, 49);
            this.buttonBack.TabIndex = 22;
            this.buttonBack.Text = "BACK";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click_1);
            // 
            // servicesBindingSource1
            // 
            this.servicesBindingSource1.DataMember = "Services";
            this.servicesBindingSource1.DataSource = this.cARSHOP123DataSet1;
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
            // servicesBindingSource2
            // 
            this.servicesBindingSource2.DataMember = "Services";
            this.servicesBindingSource2.DataSource = this.cARSHOP123DataSet1;
            // 
            // UPDATE_SERVICE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 376);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.textBoxServiceID);
            this.Controls.Add(this.labelServiceID);
            this.Controls.Add(this.textBoxEstimatedTime);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.labelEstimatedTime);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.textBoxServiceType);
            this.Controls.Add(this.labelServiceType);
            this.Controls.Add(this.label5);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UPDATE_SERVICE";
            this.Text = "UPDATE_SERVICE";
            ((System.ComponentModel.ISupportInitialize)(this.servicesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cARSHOP123DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicesBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelServiceType;
        private System.Windows.Forms.TextBox textBoxServiceType;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelEstimatedTime;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.TextBox textBoxEstimatedTime;
        private System.Windows.Forms.Label labelServiceID;
        private System.Windows.Forms.TextBox textBoxServiceID;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonBack;
        private CARSHOP123DataSet1 cARSHOP123DataSet1;
        private System.Windows.Forms.BindingSource servicesBindingSource;
        private CARSHOP123DataSet1TableAdapters.ServicesTableAdapter servicesTableAdapter;
        private System.Windows.Forms.BindingSource servicesBindingSource1;
        private System.Windows.Forms.BindingSource servicesBindingSource2;
    }
}