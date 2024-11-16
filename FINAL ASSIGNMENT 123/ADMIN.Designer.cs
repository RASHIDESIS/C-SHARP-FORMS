namespace FINAL_ASSIGNMENT_123
{
    partial class ADMIN_LOGIN
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
            this.ADMIN = new System.Windows.Forms.Label();
            this.USERNAME = new System.Windows.Forms.Label();
            this.PASSWORD = new System.Windows.Forms.Label();
            this.button_LOGIN = new System.Windows.Forms.Button();
            this.button_BACK = new System.Windows.Forms.Button();
            this.textBox_USERNAME = new System.Windows.Forms.TextBox();
            this.textBox_PASSWORD = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ADMIN
            // 
            this.ADMIN.AutoSize = true;
            this.ADMIN.Font = new System.Drawing.Font("Cooper Black", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ADMIN.Location = new System.Drawing.Point(190, 62);
            this.ADMIN.Name = "ADMIN";
            this.ADMIN.Size = new System.Drawing.Size(380, 39);
            this.ADMIN.TabIndex = 0;
            this.ADMIN.Text = "ADMIN LOGIN PAGE";
            // 
            // USERNAME
            // 
            this.USERNAME.AutoSize = true;
            this.USERNAME.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.USERNAME.Location = new System.Drawing.Point(123, 165);
            this.USERNAME.Name = "USERNAME";
            this.USERNAME.Size = new System.Drawing.Size(132, 25);
            this.USERNAME.TabIndex = 1;
            this.USERNAME.Text = "USERNAME";
            // 
            // PASSWORD
            // 
            this.PASSWORD.AutoSize = true;
            this.PASSWORD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PASSWORD.Location = new System.Drawing.Point(123, 252);
            this.PASSWORD.Name = "PASSWORD";
            this.PASSWORD.Size = new System.Drawing.Size(138, 25);
            this.PASSWORD.TabIndex = 2;
            this.PASSWORD.Text = "PASSWORD";
            // 
            // button_LOGIN
            // 
            this.button_LOGIN.Location = new System.Drawing.Point(310, 328);
            this.button_LOGIN.Name = "button_LOGIN";
            this.button_LOGIN.Size = new System.Drawing.Size(121, 40);
            this.button_LOGIN.TabIndex = 3;
            this.button_LOGIN.Text = "LOGIN";
            this.button_LOGIN.UseVisualStyleBackColor = true;
            this.button_LOGIN.Click += new System.EventHandler(this.button_LOGIN_Click);
            // 
            // button_BACK
            // 
            this.button_BACK.Location = new System.Drawing.Point(59, 378);
            this.button_BACK.Name = "button_BACK";
            this.button_BACK.Size = new System.Drawing.Size(121, 40);
            this.button_BACK.TabIndex = 4;
            this.button_BACK.Text = "BACK";
            this.button_BACK.UseVisualStyleBackColor = true;
            this.button_BACK.Click += new System.EventHandler(this.button_BACK_Click);
            // 
            // textBox_USERNAME
            // 
            this.textBox_USERNAME.Location = new System.Drawing.Point(310, 165);
            this.textBox_USERNAME.Multiline = true;
            this.textBox_USERNAME.Name = "textBox_USERNAME";
            this.textBox_USERNAME.Size = new System.Drawing.Size(136, 25);
            this.textBox_USERNAME.TabIndex = 5;
            // 
            // textBox_PASSWORD
            // 
            this.textBox_PASSWORD.Location = new System.Drawing.Point(310, 251);
            this.textBox_PASSWORD.Multiline = true;
            this.textBox_PASSWORD.Name = "textBox_PASSWORD";
            this.textBox_PASSWORD.Size = new System.Drawing.Size(136, 26);
            this.textBox_PASSWORD.TabIndex = 6;
            // 
            // ADMIN_LOGIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox_PASSWORD);
            this.Controls.Add(this.textBox_USERNAME);
            this.Controls.Add(this.button_BACK);
            this.Controls.Add(this.button_LOGIN);
            this.Controls.Add(this.PASSWORD);
            this.Controls.Add(this.USERNAME);
            this.Controls.Add(this.ADMIN);
            this.Name = "ADMIN_LOGIN";
            this.Text = "ADMIN_LOGIN";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ADMIN;
        private System.Windows.Forms.Label USERNAME;
        private System.Windows.Forms.Label PASSWORD;
        private System.Windows.Forms.Button button_LOGIN;
        private System.Windows.Forms.Button button_BACK;
        private System.Windows.Forms.TextBox textBox_USERNAME;
        private System.Windows.Forms.TextBox textBox_PASSWORD;
    }
}