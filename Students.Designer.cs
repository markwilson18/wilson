namespace KLL_COMPUTER_STUDIES_LOGIN_FORM
{
    partial class frm_Students
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
            this.dgv_studentslist = new System.Windows.Forms.DataGridView();
            this.sURNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fIRSTNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mIDDLENAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bIRTHDAYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aDDRESSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cONTACTNODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cOURSEYEARDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rOLEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataApp = new KLL_COMPUTER_STUDIES_LOGIN_FORM.DataApp();
            this.btn_New = new System.Windows.Forms.Button();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.txt_Surname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Firstname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Middlename = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Birthday = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Address = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Contactno = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_Courseyear = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cb_Role = new System.Windows.Forms.ComboBox();
            this.tableTableAdapter = new KLL_COMPUTER_STUDIES_LOGIN_FORM.DataAppTableAdapters.TableTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_studentslist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataApp)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_studentslist
            // 
            this.dgv_studentslist.AutoGenerateColumns = false;
            this.dgv_studentslist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_studentslist.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sURNAMEDataGridViewTextBoxColumn,
            this.fIRSTNAMEDataGridViewTextBoxColumn,
            this.mIDDLENAMEDataGridViewTextBoxColumn,
            this.bIRTHDAYDataGridViewTextBoxColumn,
            this.aDDRESSDataGridViewTextBoxColumn,
            this.cONTACTNODataGridViewTextBoxColumn,
            this.cOURSEYEARDataGridViewTextBoxColumn,
            this.rOLEDataGridViewTextBoxColumn});
            this.dgv_studentslist.DataSource = this.tableBindingSource;
            this.dgv_studentslist.Location = new System.Drawing.Point(252, 12);
            this.dgv_studentslist.Name = "dgv_studentslist";
            this.dgv_studentslist.Size = new System.Drawing.Size(841, 495);
            this.dgv_studentslist.TabIndex = 0;
            this.dgv_studentslist.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // sURNAMEDataGridViewTextBoxColumn
            // 
            this.sURNAMEDataGridViewTextBoxColumn.DataPropertyName = "SURNAME";
            this.sURNAMEDataGridViewTextBoxColumn.HeaderText = "SURNAME";
            this.sURNAMEDataGridViewTextBoxColumn.Name = "sURNAMEDataGridViewTextBoxColumn";
            // 
            // fIRSTNAMEDataGridViewTextBoxColumn
            // 
            this.fIRSTNAMEDataGridViewTextBoxColumn.DataPropertyName = "FIRST NAME";
            this.fIRSTNAMEDataGridViewTextBoxColumn.HeaderText = "FIRST NAME";
            this.fIRSTNAMEDataGridViewTextBoxColumn.Name = "fIRSTNAMEDataGridViewTextBoxColumn";
            // 
            // mIDDLENAMEDataGridViewTextBoxColumn
            // 
            this.mIDDLENAMEDataGridViewTextBoxColumn.DataPropertyName = "MIDDLE NAME";
            this.mIDDLENAMEDataGridViewTextBoxColumn.HeaderText = "MIDDLE NAME";
            this.mIDDLENAMEDataGridViewTextBoxColumn.Name = "mIDDLENAMEDataGridViewTextBoxColumn";
            // 
            // bIRTHDAYDataGridViewTextBoxColumn
            // 
            this.bIRTHDAYDataGridViewTextBoxColumn.DataPropertyName = "BIRTHDAY";
            this.bIRTHDAYDataGridViewTextBoxColumn.HeaderText = "BIRTHDAY";
            this.bIRTHDAYDataGridViewTextBoxColumn.Name = "bIRTHDAYDataGridViewTextBoxColumn";
            // 
            // aDDRESSDataGridViewTextBoxColumn
            // 
            this.aDDRESSDataGridViewTextBoxColumn.DataPropertyName = "ADDRESS";
            this.aDDRESSDataGridViewTextBoxColumn.HeaderText = "ADDRESS";
            this.aDDRESSDataGridViewTextBoxColumn.Name = "aDDRESSDataGridViewTextBoxColumn";
            // 
            // cONTACTNODataGridViewTextBoxColumn
            // 
            this.cONTACTNODataGridViewTextBoxColumn.DataPropertyName = "CONTACT NO_";
            this.cONTACTNODataGridViewTextBoxColumn.HeaderText = "CONTACT NO_";
            this.cONTACTNODataGridViewTextBoxColumn.Name = "cONTACTNODataGridViewTextBoxColumn";
            // 
            // cOURSEYEARDataGridViewTextBoxColumn
            // 
            this.cOURSEYEARDataGridViewTextBoxColumn.DataPropertyName = "COURSE/YEAR";
            this.cOURSEYEARDataGridViewTextBoxColumn.HeaderText = "COURSE/YEAR";
            this.cOURSEYEARDataGridViewTextBoxColumn.Name = "cOURSEYEARDataGridViewTextBoxColumn";
            // 
            // rOLEDataGridViewTextBoxColumn
            // 
            this.rOLEDataGridViewTextBoxColumn.DataPropertyName = "ROLE";
            this.rOLEDataGridViewTextBoxColumn.HeaderText = "ROLE";
            this.rOLEDataGridViewTextBoxColumn.Name = "rOLEDataGridViewTextBoxColumn";
            // 
            // tableBindingSource
            // 
            this.tableBindingSource.DataMember = "Table";
            this.tableBindingSource.DataSource = this.dataApp;
            // 
            // dataApp
            // 
            this.dataApp.DataSetName = "DataApp";
            this.dataApp.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btn_New
            // 
            this.btn_New.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn_New.Location = new System.Drawing.Point(143, 353);
            this.btn_New.Name = "btn_New";
            this.btn_New.Size = new System.Drawing.Size(103, 26);
            this.btn_New.TabIndex = 1;
            this.btn_New.Text = "New";
            this.btn_New.UseVisualStyleBackColor = true;
            this.btn_New.Click += new System.EventHandler(this.btn_New_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn_Edit.Location = new System.Drawing.Point(143, 449);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(103, 26);
            this.btn_Edit.TabIndex = 2;
            this.btn_Edit.Text = "Edit";
            this.btn_Edit.UseVisualStyleBackColor = true;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn_Save.Location = new System.Drawing.Point(143, 385);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(103, 26);
            this.btn_Save.TabIndex = 3;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn_Delete.Location = new System.Drawing.Point(143, 481);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(103, 26);
            this.btn_Delete.TabIndex = 4;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn_Cancel.Location = new System.Drawing.Point(143, 417);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(103, 26);
            this.btn_Cancel.TabIndex = 5;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // txt_Surname
            // 
            this.txt_Surname.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "SURNAME", true));
            this.txt_Surname.Location = new System.Drawing.Point(81, 12);
            this.txt_Surname.Name = "txt_Surname";
            this.txt_Surname.Size = new System.Drawing.Size(163, 20);
            this.txt_Surname.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(26, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Surname";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(18, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "First Name";
            // 
            // txt_Firstname
            // 
            this.txt_Firstname.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "FIRST NAME", true));
            this.txt_Firstname.Location = new System.Drawing.Point(81, 38);
            this.txt_Firstname.Name = "txt_Firstname";
            this.txt_Firstname.Size = new System.Drawing.Size(163, 20);
            this.txt_Firstname.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Location = new System.Drawing.Point(6, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Middle Name";
            // 
            // txt_Middlename
            // 
            this.txt_Middlename.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "MIDDLE NAME", true));
            this.txt_Middlename.Location = new System.Drawing.Point(81, 64);
            this.txt_Middlename.Name = "txt_Middlename";
            this.txt_Middlename.Size = new System.Drawing.Size(163, 20);
            this.txt_Middlename.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label4.Location = new System.Drawing.Point(30, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Birthday";
            // 
            // txt_Birthday
            // 
            this.txt_Birthday.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "BIRTHDAY", true));
            this.txt_Birthday.Location = new System.Drawing.Point(81, 90);
            this.txt_Birthday.Name = "txt_Birthday";
            this.txt_Birthday.Size = new System.Drawing.Size(163, 20);
            this.txt_Birthday.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label5.Location = new System.Drawing.Point(30, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Address";
            // 
            // txt_Address
            // 
            this.txt_Address.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "ADDRESS", true));
            this.txt_Address.Location = new System.Drawing.Point(81, 116);
            this.txt_Address.Name = "txt_Address";
            this.txt_Address.Size = new System.Drawing.Size(163, 20);
            this.txt_Address.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label6.Location = new System.Drawing.Point(11, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Contact No.";
            // 
            // txt_Contactno
            // 
            this.txt_Contactno.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "CONTACT NO_", true));
            this.txt_Contactno.Location = new System.Drawing.Point(82, 141);
            this.txt_Contactno.Name = "txt_Contactno";
            this.txt_Contactno.Size = new System.Drawing.Size(162, 20);
            this.txt_Contactno.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label7.Location = new System.Drawing.Point(8, 174);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Course/Year";
            // 
            // txt_Courseyear
            // 
            this.txt_Courseyear.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "COURSE/YEAR", true));
            this.txt_Courseyear.Location = new System.Drawing.Point(81, 167);
            this.txt_Courseyear.Name = "txt_Courseyear";
            this.txt_Courseyear.Size = new System.Drawing.Size(163, 20);
            this.txt_Courseyear.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label8.Location = new System.Drawing.Point(48, 211);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Role";
            // 
            // cb_Role
            // 
            this.cb_Role.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.tableBindingSource, "ROLE", true));
            this.cb_Role.FormattingEnabled = true;
            this.cb_Role.Items.AddRange(new object[] {
            "Admin",
            "Student"});
            this.cb_Role.Location = new System.Drawing.Point(83, 203);
            this.cb_Role.Name = "cb_Role";
            this.cb_Role.Size = new System.Drawing.Size(163, 21);
            this.cb_Role.TabIndex = 21;
            // 
            // tableTableAdapter
            // 
            this.tableTableAdapter.ClearBeforeFill = true;
            // 
            // frm_Students
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(1105, 519);
            this.Controls.Add(this.cb_Role);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_Courseyear);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_Contactno);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_Address);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_Birthday);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Middlename);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Firstname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Surname);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.btn_New);
            this.Controls.Add(this.dgv_studentslist);
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1121, 558);
            this.MinimumSize = new System.Drawing.Size(1121, 558);
            this.Name = "frm_Students";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Students";
            this.Load += new System.EventHandler(this.Students_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_studentslist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataApp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_studentslist;
        private System.Windows.Forms.Button btn_New;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.TextBox txt_Surname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Firstname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Middlename;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Birthday;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Address;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_Contactno;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_Courseyear;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cb_Role;
        private DataApp dataApp;
        private System.Windows.Forms.BindingSource tableBindingSource;
        private DataAppTableAdapters.TableTableAdapter tableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn sURNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fIRSTNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mIDDLENAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bIRTHDAYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aDDRESSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cONTACTNODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cOURSEYEARDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rOLEDataGridViewTextBoxColumn;
    }
}