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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
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
            this.cancelBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // registerTitle
            // 
            resources.ApplyResources(this.registerTitle, "registerTitle");
            this.registerTitle.Name = "registerTitle";
            // 
            // infoLabel
            // 
            resources.ApplyResources(this.infoLabel, "infoLabel");
            this.infoLabel.Name = "infoLabel";
            // 
            // fNameTb
            // 
            resources.ApplyResources(this.fNameTb, "fNameTb");
            this.fNameTb.Name = "fNameTb";
            // 
            // lNameTb
            // 
            resources.ApplyResources(this.lNameTb, "lNameTb");
            this.lNameTb.Name = "lNameTb";
            // 
            // employeeInfo
            // 
            resources.ApplyResources(this.employeeInfo, "employeeInfo");
            this.employeeInfo.Name = "employeeInfo";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // bdayTimePicker
            // 
            resources.ApplyResources(this.bdayTimePicker, "bdayTimePicker");
            this.bdayTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.bdayTimePicker.Name = "bdayTimePicker";
            // 
            // employeeIdTb
            // 
            resources.ApplyResources(this.employeeIdTb, "employeeIdTb");
            this.employeeIdTb.Name = "employeeIdTb";
            this.employeeIdTb.ReadOnly = true;
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // roleCb
            // 
            resources.ApplyResources(this.roleCb, "roleCb");
            this.roleCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.roleCb.FormattingEnabled = true;
            this.roleCb.Items.AddRange(new object[] {
            resources.GetString("roleCb.Items"),
            resources.GetString("roleCb.Items1"),
            resources.GetString("roleCb.Items2"),
            resources.GetString("roleCb.Items3"),
            resources.GetString("roleCb.Items4"),
            resources.GetString("roleCb.Items5"),
            resources.GetString("roleCb.Items6"),
            resources.GetString("roleCb.Items7")});
            this.roleCb.Name = "roleCb";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // hourlyRateTb
            // 
            resources.ApplyResources(this.hourlyRateTb, "hourlyRateTb");
            this.hourlyRateTb.Name = "hourlyRateTb";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // registerButton
            // 
            resources.ApplyResources(this.registerButton, "registerButton");
            this.registerButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.registerButton.ForeColor = System.Drawing.Color.White;
            this.registerButton.Name = "registerButton";
            this.registerButton.UseVisualStyleBackColor = false;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // emailTb
            // 
            resources.ApplyResources(this.emailTb, "emailTb");
            this.emailTb.Name = "emailTb";
            // 
            // departmentCb
            // 
            resources.ApplyResources(this.departmentCb, "departmentCb");
            this.departmentCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.departmentCb.FormattingEnabled = true;
            this.departmentCb.Items.AddRange(new object[] {
            resources.GetString("departmentCb.Items"),
            resources.GetString("departmentCb.Items1"),
            resources.GetString("departmentCb.Items2"),
            resources.GetString("departmentCb.Items3")});
            this.departmentCb.Name = "departmentCb";
            // 
            // passwordTb
            // 
            resources.ApplyResources(this.passwordTb, "passwordTb");
            this.passwordTb.Name = "passwordTb";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // cancelBtn
            // 
            resources.ApplyResources(this.cancelBtn, "cancelBtn");
            this.cancelBtn.BackColor = System.Drawing.SystemColors.GrayText;
            this.cancelBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.UseVisualStyleBackColor = false;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // RegisterForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.Controls.Add(this.cancelBtn);
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
        private System.Windows.Forms.Button cancelBtn;
    }
}