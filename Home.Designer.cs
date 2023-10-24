namespace KLL_COMPUTER_STUDIES_LOGIN_FORM
{
    partial class frm_Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Home));
            this.btn_logout = new System.Windows.Forms.Button();
            this.lbl_loguser = new System.Windows.Forms.Label();
            this.btn_attendance = new System.Windows.Forms.Button();
            this.btn_Student = new System.Windows.Forms.Button();
            this.btn_adduseradmin = new System.Windows.Forms.Button();
            this.btn_settings = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_logout
            // 
            this.btn_logout.BackColor = System.Drawing.Color.IndianRed;
            this.btn_logout.Location = new System.Drawing.Point(1122, 12);
            this.btn_logout.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(92, 33);
            this.btn_logout.TabIndex = 6;
            this.btn_logout.Text = "Log Out";
            this.btn_logout.UseVisualStyleBackColor = false;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // lbl_loguser
            // 
            this.lbl_loguser.AutoSize = true;
            this.lbl_loguser.BackColor = System.Drawing.Color.Transparent;
            this.lbl_loguser.Font = new System.Drawing.Font("Impact", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_loguser.Location = new System.Drawing.Point(13, 12);
            this.lbl_loguser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_loguser.Name = "lbl_loguser";
            this.lbl_loguser.Size = new System.Drawing.Size(162, 43);
            this.lbl_loguser.TabIndex = 7;
            this.lbl_loguser.Text = "Welcome:";
            this.lbl_loguser.Click += new System.EventHandler(this.lbl_loguser_Click);
            // 
            // btn_attendance
            // 
            this.btn_attendance.BackColor = System.Drawing.Color.IndianRed;
            this.btn_attendance.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_attendance.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn_attendance.Location = new System.Drawing.Point(131, 196);
            this.btn_attendance.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_attendance.Name = "btn_attendance";
            this.btn_attendance.Size = new System.Drawing.Size(200, 76);
            this.btn_attendance.TabIndex = 8;
            this.btn_attendance.Text = "Attendance";
            this.btn_attendance.UseVisualStyleBackColor = false;
            // 
            // btn_Student
            // 
            this.btn_Student.BackColor = System.Drawing.Color.IndianRed;
            this.btn_Student.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Student.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn_Student.Location = new System.Drawing.Point(131, 278);
            this.btn_Student.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_Student.Name = "btn_Student";
            this.btn_Student.Size = new System.Drawing.Size(200, 76);
            this.btn_Student.TabIndex = 9;
            this.btn_Student.Text = "Student";
            this.btn_Student.UseVisualStyleBackColor = false;
            this.btn_Student.Click += new System.EventHandler(this.btn_Student_Click);
            // 
            // btn_adduseradmin
            // 
            this.btn_adduseradmin.BackColor = System.Drawing.Color.IndianRed;
            this.btn_adduseradmin.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_adduseradmin.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn_adduseradmin.Location = new System.Drawing.Point(131, 360);
            this.btn_adduseradmin.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_adduseradmin.Name = "btn_adduseradmin";
            this.btn_adduseradmin.Size = new System.Drawing.Size(200, 76);
            this.btn_adduseradmin.TabIndex = 12;
            this.btn_adduseradmin.Text = "Add User/Admin";
            this.btn_adduseradmin.UseVisualStyleBackColor = false;
            this.btn_adduseradmin.Click += new System.EventHandler(this.btn_adduseradmin_Click);
            // 
            // btn_settings
            // 
            this.btn_settings.BackColor = System.Drawing.Color.IndianRed;
            this.btn_settings.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_settings.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn_settings.Location = new System.Drawing.Point(131, 442);
            this.btn_settings.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_settings.Name = "btn_settings";
            this.btn_settings.Size = new System.Drawing.Size(200, 76);
            this.btn_settings.TabIndex = 13;
            this.btn_settings.Text = "Settings";
            this.btn_settings.UseVisualStyleBackColor = false;
            this.btn_settings.Click += new System.EventHandler(this.btn_settings_Click_1);
            // 
            // frm_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1227, 563);
            this.Controls.Add(this.btn_settings);
            this.Controls.Add(this.btn_adduseradmin);
            this.Controls.Add(this.btn_Student);
            this.Controls.Add(this.btn_attendance);
            this.Controls.Add(this.lbl_loguser);
            this.Controls.Add(this.btn_logout);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1243, 602);
            this.MinimumSize = new System.Drawing.Size(949, 489);
            this.Name = "frm_Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.frm_Home_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Label lbl_loguser;
        private System.Windows.Forms.Button btn_attendance;
        private System.Windows.Forms.Button btn_Student;
        private System.Windows.Forms.Button btn_adduseradmin;
        private System.Windows.Forms.Button btn_settings;
    }
}