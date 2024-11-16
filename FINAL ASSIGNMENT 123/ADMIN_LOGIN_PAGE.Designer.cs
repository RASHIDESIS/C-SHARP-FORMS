namespace FINAL_ASSIGNMENT_123
{
    partial class ADMIN_LOGIN_PAGE
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
            this.label1 = new System.Windows.Forms.Label();
            this.Manage_Staff = new System.Windows.Forms.Button();
            this.Manage_Service = new System.Windows.Forms.Button();
            this.FEEDBACKS = new System.Windows.Forms.Button();
            this.REPORTS = new System.Windows.Forms.Button();
            this.LOGOUT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "WELCOME RASHID";
            // 
            // Manage_Staff
            // 
            this.Manage_Staff.Location = new System.Drawing.Point(71, 142);
            this.Manage_Staff.Name = "Manage_Staff";
            this.Manage_Staff.Size = new System.Drawing.Size(225, 43);
            this.Manage_Staff.TabIndex = 1;
            this.Manage_Staff.Text = "MANAGE ACCOUNT STAFF";
            this.Manage_Staff.UseVisualStyleBackColor = true;
            this.Manage_Staff.Click += new System.EventHandler(this.button1_Click);
            // 
            // Manage_Service
            // 
            this.Manage_Service.Location = new System.Drawing.Point(71, 209);
            this.Manage_Service.Name = "Manage_Service";
            this.Manage_Service.Size = new System.Drawing.Size(225, 43);
            this.Manage_Service.TabIndex = 2;
            this.Manage_Service.Text = "MANAGE SERVICES";
            this.Manage_Service.UseVisualStyleBackColor = true;
            this.Manage_Service.Click += new System.EventHandler(this.Manage_Service_Click);
            // 
            // FEEDBACKS
            // 
            this.FEEDBACKS.Location = new System.Drawing.Point(71, 277);
            this.FEEDBACKS.Name = "FEEDBACKS";
            this.FEEDBACKS.Size = new System.Drawing.Size(225, 43);
            this.FEEDBACKS.TabIndex = 3;
            this.FEEDBACKS.Text = "FEEDBACKS";
            this.FEEDBACKS.UseVisualStyleBackColor = true;
            this.FEEDBACKS.Click += new System.EventHandler(this.FEEDBACKS_Click);
            // 
            // REPORTS
            // 
            this.REPORTS.Location = new System.Drawing.Point(71, 344);
            this.REPORTS.Name = "REPORTS";
            this.REPORTS.Size = new System.Drawing.Size(225, 43);
            this.REPORTS.TabIndex = 4;
            this.REPORTS.Text = "REPORTS";
            this.REPORTS.UseVisualStyleBackColor = true;
            this.REPORTS.Click += new System.EventHandler(this.REPORTS_Click);
            // 
            // LOGOUT
            // 
            this.LOGOUT.Location = new System.Drawing.Point(583, 344);
            this.LOGOUT.Name = "LOGOUT";
            this.LOGOUT.Size = new System.Drawing.Size(164, 43);
            this.LOGOUT.TabIndex = 5;
            this.LOGOUT.Text = "LOGOUT";
            this.LOGOUT.UseVisualStyleBackColor = true;
            this.LOGOUT.Click += new System.EventHandler(this.LOGOUT_Click);
            // 
            // ADMIN_LOGIN_PAGE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LOGOUT);
            this.Controls.Add(this.REPORTS);
            this.Controls.Add(this.FEEDBACKS);
            this.Controls.Add(this.Manage_Service);
            this.Controls.Add(this.Manage_Staff);
            this.Controls.Add(this.label1);
            this.Name = "ADMIN_LOGIN_PAGE";
            this.Text = "ADMIN_LOGIN_PAGE";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Manage_Staff;
        private System.Windows.Forms.Button Manage_Service;
        private System.Windows.Forms.Button FEEDBACKS;
        private System.Windows.Forms.Button REPORTS;
        private System.Windows.Forms.Button LOGOUT;
    }
}