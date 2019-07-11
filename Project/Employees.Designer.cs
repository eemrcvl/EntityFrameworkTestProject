namespace Project
{
    partial class Employees
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
            this.dgwEmployee = new System.Windows.Forms.DataGridView();
            this.gbxFirstName = new System.Windows.Forms.GroupBox();
            this.lblName = new System.Windows.Forms.Label();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.gbxLastName = new System.Windows.Forms.GroupBox();
            this.tbxLastName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgwEmployee)).BeginInit();
            this.gbxFirstName.SuspendLayout();
            this.gbxLastName.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwEmployee
            // 
            this.dgwEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwEmployee.Location = new System.Drawing.Point(12, 12);
            this.dgwEmployee.Name = "dgwEmployee";
            this.dgwEmployee.Size = new System.Drawing.Size(832, 239);
            this.dgwEmployee.TabIndex = 0;
            // 
            // gbxFirstName
            // 
            this.gbxFirstName.Controls.Add(this.tbxName);
            this.gbxFirstName.Controls.Add(this.lblName);
            this.gbxFirstName.Location = new System.Drawing.Point(12, 263);
            this.gbxFirstName.Name = "gbxFirstName";
            this.gbxFirstName.Size = new System.Drawing.Size(277, 100);
            this.gbxFirstName.TabIndex = 1;
            this.gbxFirstName.TabStop = false;
            this.gbxFirstName.Text = "Find by First Name";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(23, 46);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(86, 43);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(118, 20);
            this.tbxName.TabIndex = 1;
            this.tbxName.TextChanged += new System.EventHandler(this.tbxName_TextChanged);
            // 
            // gbxLastName
            // 
            this.gbxLastName.Controls.Add(this.tbxLastName);
            this.gbxLastName.Controls.Add(this.lblLastName);
            this.gbxLastName.Location = new System.Drawing.Point(12, 380);
            this.gbxLastName.Name = "gbxLastName";
            this.gbxLastName.Size = new System.Drawing.Size(277, 100);
            this.gbxLastName.TabIndex = 2;
            this.gbxLastName.TabStop = false;
            this.gbxLastName.Text = "Find by Last Name";
            // 
            // tbxLastName
            // 
            this.tbxLastName.Location = new System.Drawing.Point(86, 43);
            this.tbxLastName.Name = "tbxLastName";
            this.tbxLastName.Size = new System.Drawing.Size(118, 20);
            this.tbxLastName.TabIndex = 1;
            this.tbxLastName.TextChanged += new System.EventHandler(this.tbxLastName_TextChanged);
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(23, 46);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(58, 13);
            this.lblLastName.TabIndex = 0;
            this.lblLastName.Text = "Last Name";
            // 
            // Employees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 492);
            this.Controls.Add(this.gbxLastName);
            this.Controls.Add(this.gbxFirstName);
            this.Controls.Add(this.dgwEmployee);
            this.Name = "Employees";
            this.Text = "Employees";
            this.Load += new System.EventHandler(this.Employees_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwEmployee)).EndInit();
            this.gbxFirstName.ResumeLayout(false);
            this.gbxFirstName.PerformLayout();
            this.gbxLastName.ResumeLayout(false);
            this.gbxLastName.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwEmployee;
        private System.Windows.Forms.GroupBox gbxFirstName;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.GroupBox gbxLastName;
        private System.Windows.Forms.TextBox tbxLastName;
        private System.Windows.Forms.Label lblLastName;
    }
}