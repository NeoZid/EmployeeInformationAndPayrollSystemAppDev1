namespace EmployeeInformationAndPayrollSystemAppDev1
{
    partial class ManagerForm
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
            this.employeeDataView = new System.Windows.Forms.DataGridView();
            this.registerButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.logoutButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manager Dashboard";
            // 
            // employeeDataView
            // 
            this.employeeDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeeDataView.Location = new System.Drawing.Point(27, 72);
            this.employeeDataView.Name = "employeeDataView";
            this.employeeDataView.Size = new System.Drawing.Size(1035, 404);
            this.employeeDataView.TabIndex = 1;
            // 
            // registerButton
            // 
            this.registerButton.Location = new System.Drawing.Point(330, 34);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(206, 32);
            this.registerButton.TabIndex = 2;
            this.registerButton.Text = "Register An Employee";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(590, 35);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(206, 31);
            this.editButton.TabIndex = 3;
            this.editButton.Text = "Edit An Employee";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(825, 35);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(206, 32);
            this.removeButton.TabIndex = 4;
            this.removeButton.Text = "Remove an employee";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // logoutButton
            // 
            this.logoutButton.Location = new System.Drawing.Point(987, 504);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(75, 23);
            this.logoutButton.TabIndex = 5;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // ManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 549);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.employeeDataView);
            this.Controls.Add(this.label1);
            this.Name = "ManagerForm";
            this.Text = "ManagerForm";
            this.Load += new System.EventHandler(this.ManagerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView employeeDataView;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button logoutButton;
    }
}