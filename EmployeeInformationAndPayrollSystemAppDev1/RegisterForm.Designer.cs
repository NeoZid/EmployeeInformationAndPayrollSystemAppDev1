namespace EmployeeInformationAndPayrollSystemAppDev1
{
    partial class RegisterForm
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
            this.registerTitle = new System.Windows.Forms.Label();
            this.infoLabel = new System.Windows.Forms.Label();
            this.fNameTb = new System.Windows.Forms.TextBox();
            this.lNameTb = new System.Windows.Forms.TextBox();
            this.employeeInfo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bdayTimePicker = new System.Windows.Forms.DateTimePicker();
            this.employeeIdTb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.roleCb = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.hourlyRateTb = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.registerButton = new System.Windows.Forms.Button();
            this.emailTb = new System.Windows.Forms.TextBox();
            this.departmentCb = new System.Windows.Forms.ComboBox();
            this.passwordTb = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // registerTitle
            // 
            this.registerTitle.AutoSize = true;
            this.registerTitle.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerTitle.Location = new System.Drawing.Point(188, 31);
            this.registerTitle.Name = "registerTitle";
            this.registerTitle.Size = new System.Drawing.Size(249, 37);
            this.registerTitle.TabIndex = 0;
            this.registerTitle.Text = "Registration Form";
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoLabel.Location = new System.Drawing.Point(190, 70);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(244, 17);
            this.infoLabel.TabIndex = 1;
            this.infoLabel.Text = "Fill out the form carefully for registration";
            // 
            // fNameTb
            // 
            this.fNameTb.Location = new System.Drawing.Point(121, 150);
            this.fNameTb.Name = "fNameTb";
            this.fNameTb.Size = new System.Drawing.Size(162, 20);
            this.fNameTb.TabIndex = 2;
            // 
            // lNameTb
            // 
            this.lNameTb.Location = new System.Drawing.Point(333, 150);
            this.lNameTb.Name = "lNameTb";
            this.lNameTb.Size = new System.Drawing.Size(162, 20);
            this.lNameTb.TabIndex = 3;
            // 
            // employeeInfo
            // 
            this.employeeInfo.AutoSize = true;
            this.employeeInfo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeInfo.Location = new System.Drawing.Point(118, 117);
            this.employeeInfo.Name = "employeeInfo";
            this.employeeInfo.Size = new System.Drawing.Size(182, 21);
            this.employeeInfo.TabIndex = 5;
            this.employeeInfo.Text = "Employee Information";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(118, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(330, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(118, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(330, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Date of Birth";
            // 
            // bdayTimePicker
            // 
            this.bdayTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.bdayTimePicker.Location = new System.Drawing.Point(333, 208);
            this.bdayTimePicker.Name = "bdayTimePicker";
            this.bdayTimePicker.Size = new System.Drawing.Size(158, 20);
            this.bdayTimePicker.TabIndex = 12;
            // 
            // employeeIdTb
            // 
            this.employeeIdTb.Location = new System.Drawing.Point(232, 285);
            this.employeeIdTb.Name = "employeeIdTb";
            this.employeeIdTb.ReadOnly = true;
            this.employeeIdTb.Size = new System.Drawing.Size(161, 20);
            this.employeeIdTb.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(260, 308);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Employee ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(331, 364);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "Department";
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
            this.roleCb.Location = new System.Drawing.Point(121, 394);
            this.roleCb.Name = "roleCb";
            this.roleCb.Size = new System.Drawing.Size(161, 21);
            this.roleCb.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(118, 418);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 17);
            this.label7.TabIndex = 18;
            this.label7.Text = "Role/Title";
            // 
            // hourlyRateTb
            // 
            this.hourlyRateTb.Location = new System.Drawing.Point(333, 395);
            this.hourlyRateTb.Name = "hourlyRateTb";
            this.hourlyRateTb.Size = new System.Drawing.Size(158, 20);
            this.hourlyRateTb.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(330, 418);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 17);
            this.label8.TabIndex = 20;
            this.label8.Text = "Hourly Rate";
            // 
            // registerButton
            // 
            this.registerButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.registerButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerButton.ForeColor = System.Drawing.Color.White;
            this.registerButton.Location = new System.Drawing.Point(226, 450);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(172, 32);
            this.registerButton.TabIndex = 21;
            this.registerButton.Text = "Register";
            this.registerButton.UseVisualStyleBackColor = false;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // emailTb
            // 
            this.emailTb.Location = new System.Drawing.Point(121, 208);
            this.emailTb.Name = "emailTb";
            this.emailTb.Size = new System.Drawing.Size(161, 20);
            this.emailTb.TabIndex = 22;
            // 
            // departmentCb
            // 
            this.departmentCb.FormattingEnabled = true;
            this.departmentCb.Items.AddRange(new object[] {
            "Finance",
            "Information Technology",
            "Marketing",
            "Management"});
            this.departmentCb.Location = new System.Drawing.Point(333, 340);
            this.departmentCb.Name = "departmentCb";
            this.departmentCb.Size = new System.Drawing.Size(158, 21);
            this.departmentCb.TabIndex = 23;
            // 
            // passwordTb
            // 
            this.passwordTb.Location = new System.Drawing.Point(121, 341);
            this.passwordTb.Name = "passwordTb";
            this.passwordTb.Size = new System.Drawing.Size(161, 20);
            this.passwordTb.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(118, 364);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 17);
            this.label9.TabIndex = 25;
            this.label9.Text = "Password";
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(625, 593);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.passwordTb);
            this.Controls.Add(this.departmentCb);
            this.Controls.Add(this.emailTb);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.hourlyRateTb);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.roleCb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.employeeIdTb);
            this.Controls.Add(this.bdayTimePicker);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.employeeInfo);
            this.Controls.Add(this.lNameTb);
            this.Controls.Add(this.fNameTb);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.registerTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterForm";
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label registerTitle;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.TextBox fNameTb;
        private System.Windows.Forms.TextBox lNameTb;
        private System.Windows.Forms.Label employeeInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker bdayTimePicker;
        private System.Windows.Forms.TextBox employeeIdTb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox roleCb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox hourlyRateTb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.TextBox emailTb;
        private System.Windows.Forms.ComboBox departmentCb;
        private System.Windows.Forms.TextBox passwordTb;
        private System.Windows.Forms.Label label9;
    }
}