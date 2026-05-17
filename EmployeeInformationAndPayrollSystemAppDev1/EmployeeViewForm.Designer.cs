namespace EmployeeInformationAndPayrollSystemAppDev1
{
    partial class EmployeeViewForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeViewForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.departmentLabel = new System.Windows.Forms.Label();
            this.roleLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.hoursWorkedTb = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.grossPayLabel = new System.Windows.Forms.Label();
            this.netPayLabel = new System.Windows.Forms.Label();
            this.PTOdaysLabel = new System.Windows.Forms.Label();
            this.hourlyRateLabel = new System.Windows.Forms.Label();
            this.logoutButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.changePwBtn = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.confirmPasswordTb = new System.Windows.Forms.TextBox();
            this.newPasswordTb = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
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
            // nameLabel
            // 
            resources.ApplyResources(this.nameLabel, "nameLabel");
            this.nameLabel.Name = "nameLabel";
            // 
            // idLabel
            // 
            resources.ApplyResources(this.idLabel, "idLabel");
            this.idLabel.Name = "idLabel";
            // 
            // departmentLabel
            // 
            resources.ApplyResources(this.departmentLabel, "departmentLabel");
            this.departmentLabel.Name = "departmentLabel";
            // 
            // roleLabel
            // 
            resources.ApplyResources(this.roleLabel, "roleLabel");
            this.roleLabel.Name = "roleLabel";
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
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // hoursWorkedTb
            // 
            resources.ApplyResources(this.hoursWorkedTb, "hoursWorkedTb");
            this.hoursWorkedTb.Name = "hoursWorkedTb";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // calculateButton
            // 
            this.calculateButton.BackColor = System.Drawing.Color.Turquoise;
            resources.ApplyResources(this.calculateButton, "calculateButton");
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.UseVisualStyleBackColor = false;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // grossPayLabel
            // 
            resources.ApplyResources(this.grossPayLabel, "grossPayLabel");
            this.grossPayLabel.Name = "grossPayLabel";
            // 
            // netPayLabel
            // 
            resources.ApplyResources(this.netPayLabel, "netPayLabel");
            this.netPayLabel.Name = "netPayLabel";
            // 
            // PTOdaysLabel
            // 
            resources.ApplyResources(this.PTOdaysLabel, "PTOdaysLabel");
            this.PTOdaysLabel.Name = "PTOdaysLabel";
            // 
            // hourlyRateLabel
            // 
            resources.ApplyResources(this.hourlyRateLabel, "hourlyRateLabel");
            this.hourlyRateLabel.Name = "hourlyRateLabel";
            // 
            // logoutButton
            // 
            this.logoutButton.BackColor = System.Drawing.Color.MidnightBlue;
            resources.ApplyResources(this.logoutButton, "logoutButton");
            this.logoutButton.ForeColor = System.Drawing.Color.White;
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.UseVisualStyleBackColor = false;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.departmentLabel);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.nameLabel);
            this.groupBox1.Controls.Add(this.idLabel);
            this.groupBox1.Controls.Add(this.roleLabel);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.netPayLabel);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.hourlyRateLabel);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.PTOdaysLabel);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.hoursWorkedTb);
            this.groupBox2.Controls.Add(this.grossPayLabel);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.calculateButton);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label10.Name = "label10";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.changePwBtn);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.confirmPasswordTb);
            this.groupBox3.Controls.Add(this.newPasswordTb);
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            // 
            // changePwBtn
            // 
            this.changePwBtn.BackColor = System.Drawing.Color.Turquoise;
            resources.ApplyResources(this.changePwBtn, "changePwBtn");
            this.changePwBtn.Name = "changePwBtn";
            this.changePwBtn.UseVisualStyleBackColor = false;
            this.changePwBtn.Click += new System.EventHandler(this.changePwBtn_Click);
            // 
            // label12
            // 
            resources.ApplyResources(this.label12, "label12");
            this.label12.Name = "label12";
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.Name = "label11";
            // 
            // confirmPasswordTb
            // 
            resources.ApplyResources(this.confirmPasswordTb, "confirmPasswordTb");
            this.confirmPasswordTb.Name = "confirmPasswordTb";
            this.confirmPasswordTb.UseSystemPasswordChar = true;
            // 
            // newPasswordTb
            // 
            resources.ApplyResources(this.newPasswordTb, "newPasswordTb");
            this.newPasswordTb.Name = "newPasswordTb";
            this.newPasswordTb.UseSystemPasswordChar = true;
            // 
            // EmployeeViewForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "EmployeeViewForm";
            this.Load += new System.EventHandler(this.EmployeeViewForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label departmentLabel;
        private System.Windows.Forms.Label roleLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox hoursWorkedTb;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label grossPayLabel;
        private System.Windows.Forms.Label netPayLabel;
        private System.Windows.Forms.Label PTOdaysLabel;
        private System.Windows.Forms.Label hourlyRateLabel;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox newPasswordTb;
        private System.Windows.Forms.TextBox confirmPasswordTb;
        private System.Windows.Forms.Button changePwBtn;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
    }
}