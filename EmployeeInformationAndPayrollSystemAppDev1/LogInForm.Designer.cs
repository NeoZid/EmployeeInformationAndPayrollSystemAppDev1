namespace EmployeeInformationAndPayrollSystemAppDev1
{
    partial class LogInForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogInForm));
            this.mainTitle = new System.Windows.Forms.Label();
            this.signInButton = new System.Windows.Forms.Button();
            this.passwordTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.userIdTb = new System.Windows.Forms.TextBox();
            this.languageCb = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mainTitle
            // 
            resources.ApplyResources(this.mainTitle, "mainTitle");
            this.mainTitle.BackColor = System.Drawing.Color.Transparent;
            this.mainTitle.ForeColor = System.Drawing.Color.MidnightBlue;
            this.mainTitle.Name = "mainTitle";
            // 
            // signInButton
            // 
            resources.ApplyResources(this.signInButton, "signInButton");
            this.signInButton.BackColor = System.Drawing.Color.Turquoise;
            this.signInButton.ForeColor = System.Drawing.Color.White;
            this.signInButton.Name = "signInButton";
            this.signInButton.UseVisualStyleBackColor = false;
            this.signInButton.Click += new System.EventHandler(this.signInButton_Click);
            // 
            // passwordTb
            // 
            resources.ApplyResources(this.passwordTb, "passwordTb");
            this.passwordTb.Name = "passwordTb";
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
            // userIdTb
            // 
            resources.ApplyResources(this.userIdTb, "userIdTb");
            this.userIdTb.Name = "userIdTb";
            // 
            // languageCb
            // 
            resources.ApplyResources(this.languageCb, "languageCb");
            this.languageCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.languageCb.FormattingEnabled = true;
            this.languageCb.Items.AddRange(new object[] {
            resources.GetString("languageCb.Items"),
            resources.GetString("languageCb.Items1"),
            resources.GetString("languageCb.Items2")});
            this.languageCb.Name = "languageCb";
            this.languageCb.SelectedIndexChanged += new System.EventHandler(this.languageCb_SelectedIndexChanged);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // LogInForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.languageCb);
            this.Controls.Add(this.userIdTb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passwordTb);
            this.Controls.Add(this.signInButton);
            this.Controls.Add(this.mainTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "LogInForm";
            this.Load += new System.EventHandler(this.LogInForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mainTitle;
        private System.Windows.Forms.Button signInButton;
        private System.Windows.Forms.TextBox passwordTb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox userIdTb;
        private System.Windows.Forms.Label label3;
        internal System.Windows.Forms.ComboBox languageCb;
    }
}

