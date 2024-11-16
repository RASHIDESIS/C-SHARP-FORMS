namespace FINAL_ASSIGNMENT_123
{
    partial class Form1
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
            this.WELCOME = new System.Windows.Forms.Label();
            this.CHOOSE = new System.Windows.Forms.Label();
            this.BUTTON_ADMIN = new System.Windows.Forms.Button();
            this.RECEPTIONIST = new System.Windows.Forms.Button();
            this.CUSTOMER = new System.Windows.Forms.Button();
            this.MECHANIC = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // WELCOME
            // 
            this.WELCOME.AutoSize = true;
            this.WELCOME.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.WELCOME.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.WELCOME.Cursor = System.Windows.Forms.Cursors.Cross;
            this.WELCOME.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.WELCOME.Font = new System.Drawing.Font("Cooper Black", 19.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WELCOME.Location = new System.Drawing.Point(222, 38);
            this.WELCOME.Name = "WELCOME";
            this.WELCOME.Size = new System.Drawing.Size(312, 41);
            this.WELCOME.TabIndex = 0;
            this.WELCOME.Text = "WELCOME PAGE";
            // 
            // CHOOSE
            // 
            this.CHOOSE.AutoSize = true;
            this.CHOOSE.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.CHOOSE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CHOOSE.Cursor = System.Windows.Forms.Cursors.Cross;
            this.CHOOSE.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CHOOSE.Font = new System.Drawing.Font("Cooper Black", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CHOOSE.Location = new System.Drawing.Point(261, 109);
            this.CHOOSE.Name = "CHOOSE";
            this.CHOOSE.Size = new System.Drawing.Size(248, 28);
            this.CHOOSE.TabIndex = 1;
            this.CHOOSE.Text = "CHOOSE TO LOG IN";
            // 
            // BUTTON_ADMIN
            // 
            this.BUTTON_ADMIN.Font = new System.Drawing.Font("Cooper Black", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BUTTON_ADMIN.Location = new System.Drawing.Point(323, 157);
            this.BUTTON_ADMIN.Name = "BUTTON_ADMIN";
            this.BUTTON_ADMIN.Size = new System.Drawing.Size(132, 50);
            this.BUTTON_ADMIN.TabIndex = 2;
            this.BUTTON_ADMIN.Text = "ADMIN";
            this.BUTTON_ADMIN.UseVisualStyleBackColor = true;
            this.BUTTON_ADMIN.Click += new System.EventHandler(this.ADMIN_Click);
            // 
            // RECEPTIONIST
            // 
            this.RECEPTIONIST.Location = new System.Drawing.Point(323, 227);
            this.RECEPTIONIST.Name = "RECEPTIONIST";
            this.RECEPTIONIST.Size = new System.Drawing.Size(132, 50);
            this.RECEPTIONIST.TabIndex = 3;
            this.RECEPTIONIST.Text = "RECEPTIONIST";
            this.RECEPTIONIST.UseVisualStyleBackColor = true;
            // 
            // CUSTOMER
            // 
            this.CUSTOMER.Location = new System.Drawing.Point(323, 298);
            this.CUSTOMER.Name = "CUSTOMER";
            this.CUSTOMER.Size = new System.Drawing.Size(132, 50);
            this.CUSTOMER.TabIndex = 4;
            this.CUSTOMER.Text = "CUSTOMER";
            this.CUSTOMER.UseVisualStyleBackColor = true;
            // 
            // MECHANIC
            // 
            this.MECHANIC.Location = new System.Drawing.Point(323, 365);
            this.MECHANIC.Name = "MECHANIC";
            this.MECHANIC.Size = new System.Drawing.Size(132, 50);
            this.MECHANIC.TabIndex = 5;
            this.MECHANIC.Text = "MECHANIC";
            this.MECHANIC.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MECHANIC);
            this.Controls.Add(this.CUSTOMER);
            this.Controls.Add(this.RECEPTIONIST);
            this.Controls.Add(this.BUTTON_ADMIN);
            this.Controls.Add(this.CHOOSE);
            this.Controls.Add(this.WELCOME);
            this.Name = "Form1";
            this.Text = "WELCOME";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label WELCOME;
        private System.Windows.Forms.Label CHOOSE;
        private System.Windows.Forms.Button BUTTON_ADMIN;
        private System.Windows.Forms.Button RECEPTIONIST;
        private System.Windows.Forms.Button CUSTOMER;
        private System.Windows.Forms.Button MECHANIC;
    }
}

