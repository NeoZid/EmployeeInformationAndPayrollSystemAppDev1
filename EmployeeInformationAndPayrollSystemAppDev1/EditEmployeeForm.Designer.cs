namespace EmployeeInformationAndPayrollSystemAppDev1
{
    partial class EditEmployeeForm
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
            this.label9 = new System.Windows.Forms.Label();
            this.hoursWorkedTb = new System.Windows.Forms.TextBox();
            this.departmentCb = new System.Windows.Forms.ComboBox();
            this.emailTb = new System.Windows.Forms.TextBox();
            this.editButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.hourlyRateTb = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.roleCb = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.PTODaysTb = new System.Windows.Forms.TextBox();
            this.bdayTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.employeeInfo = new System.Windows.Forms.Label();
            this.lNameTb = new System.Windows.Forms.TextBox();
            this.fNameTb = new System.Windows.Forms.TextBox();
            this.editTitle = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 335);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 17);
            this.label9.TabIndex = 47;
            this.label9.Text = "Hours Worked";
            // 
            // hoursWorkedTb
            // 
            this.hoursWorkedTb.Location = new System.Drawing.Point(12, 312);
            this.hoursWorkedTb.Name = "hoursWorkedTb";
            this.hoursWorkedTb.Size = new System.Drawing.Size(161, 20);
            this.hoursWorkedTb.TabIndex = 46;
            // 
            // departmentCb
            // 
            this.departmentCb.FormattingEnabled = true;
            this.departmentCb.Items.AddRange(new object[] {
            "Finance",
            "Information Technology",
            "Marketing",
            "Management"});
            this.departmentCb.Location = new System.Drawing.Point(452, 258);
            this.departmentCb.Name = "departmentCb";
            this.departmentCb.Size = new System.Drawing.Size(161, 21);
            this.departmentCb.TabIndex = 45;
            // 
            // emailTb
            // 
            this.emailTb.Location = new System.Drawing.Point(452, 204);
            this.emailTb.Name = "emailTb";
            this.emailTb.Size = new System.Drawing.Size(161, 20);
            this.emailTb.TabIndex = 44;
            // 
            // editButton
            // 
            this.editButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.editButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editButton.Location = new System.Drawing.Point(226, 388);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(172, 34);
            this.editButton.TabIndex = 43;
            this.editButton.TabStop = false;
            this.editButton.Text = "Confirm Edit";
            this.editButton.UseVisualStyleBackColor = false;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(449, 336);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 17);
            this.label8.TabIndex = 42;
            this.label8.Text = "Hourly Rate";
            // 
            // hourlyRateTb
            // 
            this.hourlyRateTb.Location = new System.Drawing.Point(452, 313);
            this.hourlyRateTb.Name = "hourlyRateTb";
            this.hourlyRateTb.Size = new System.Drawing.Size(158, 20);
            this.hourlyRateTb.TabIndex = 41;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(228, 336);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 17);
            this.label7.TabIndex = 40;
            this.label7.Text = "Role/Title";
            // 
            // roleCb
            // 
            this.roleCb.FormattingEnabled = true;
            this.roleCb.Items.AddRange(new object[] {
            "Accountant",
            "Budget Analyst",
            "Software Developer",
            "IT Support",
            "Content Creator",
            "Marketing Specialist",
            "Manager",
            "Team Lead"});
            this.roleCb.Location = new System.Drawing.Point(230, 312);
            this.roleCb.Name = "roleCb";
            this.roleCb.Size = new System.Drawing.Size(161, 21);
            this.roleCb.TabIndex = 39;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(449, 282);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 17);
            this.label6.TabIndex = 38;
            this.label6.Text = "Department";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(230, 282);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 17);
            this.label5.TabIndex = 37;
            this.label5.Text = "PTO Days";
            // 
            // PTODaysTb
            // 
            this.PTODaysTb.Location = new System.Drawing.Point(230, 259);
            this.PTODaysTb.Name = "PTODaysTb";
            this.PTODaysTb.Size = new System.Drawing.Size(163, 20);
            this.PTODaysTb.TabIndex = 36;
            // 
            // bdayTimePicker
            // 
            this.bdayTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.bdayTimePicker.Location = new System.Drawing.Point(12, 259);
            this.bdayTimePicker.Name = "bdayTimePicker";
            this.bdayTimePicker.Size = new System.Drawing.Size(162, 20);
            this.bdayTimePicker.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 282);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 17);
            this.label4.TabIndex = 34;
            this.label4.Text = "Date of Birth";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(449, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 17);
            this.label3.TabIndex = 33;
            this.label3.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(230, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 32;
            this.label2.Text = "Last Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 227);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 31;
            this.label1.Text = "First Name";
            // 
            // employeeInfo
            // 
            this.employeeInfo.AutoSize = true;
            this.employeeInfo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeInfo.Location = new System.Drawing.Point(230, 159);
            this.employeeInfo.Name = "employeeInfo";
            this.employeeInfo.Size = new System.Drawing.Size(166, 20);
            this.employeeInfo.TabIndex = 30;
            this.employeeInfo.Text = "Employee Information";
            // 
            // lNameTb
            // 
            this.lNameTb.Location = new System.Drawing.Point(231, 204);
            this.lNameTb.Name = "lNameTb";
            this.lNameTb.Size = new System.Drawing.Size(162, 20);
            this.lNameTb.TabIndex = 29;
            // 
            // fNameTb
            // 
            this.fNameTb.Location = new System.Drawing.Point(12, 204);
            this.fNameTb.Name = "fNameTb";
            this.fNameTb.Size = new System.Drawing.Size(162, 20);
            this.fNameTb.TabIndex = 28;
            // 
            // editTitle
            // 
            this.editTitle.AutoSize = true;
            this.editTitle.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editTitle.Location = new System.Drawing.Point(185, 85);
            this.editTitle.Name = "editTitle";
            this.editTitle.Size = new System.Drawing.Size(256, 47);
            this.editTitle.TabIndex = 26;
            this.editTitle.Text = "Edit Employee";
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.SystemColors.GrayText;
            this.cancelButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.Location = new System.Drawing.Point(226, 428);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(172, 30);
            this.cancelButton.TabIndex = 48;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // EditEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(625, 593);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.hoursWorkedTb);
            this.Controls.Add(this.departmentCb);
            this.Controls.Add(this.emailTb);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.hourlyRateTb);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.roleCb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PTODaysTb);
            this.Controls.Add(this.bdayTimePicker);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.employeeInfo);
            this.Controls.Add(this.lNameTb);
            this.Controls.Add(this.fNameTb);
            this.Controls.Add(this.editTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "EditEmployeeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditEmployeeForm";
            this.Load += new System.EventHandler(this.EditEmployeeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox hoursWorkedTb;
        private System.Windows.Forms.ComboBox departmentCb;
        private System.Windows.Forms.TextBox emailTb;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox hourlyRateTb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox roleCb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox PTODaysTb;
        private System.Windows.Forms.DateTimePicker bdayTimePicker;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label employeeInfo;
        private System.Windows.Forms.TextBox lNameTb;
        private System.Windows.Forms.TextBox fNameTb;
        private System.Windows.Forms.Label editTitle;
        private System.Windows.Forms.Button cancelButton;
    }
}