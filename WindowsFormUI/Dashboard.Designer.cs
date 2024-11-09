namespace WindowsFormUI
{
    partial class Dashboard
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
            this.firstNameValue = new System.Windows.Forms.TextBox();
            this.HeaderLabel = new System.Windows.Forms.Label();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.lasttNameValue = new System.Windows.Forms.TextBox();
            this.generateEmployeeId = new System.Windows.Forms.Button();
            this.employeeId = new System.Windows.Forms.Label();
            this.employeeidvalue = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // firstNameValue
            // 
            this.firstNameValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameValue.Location = new System.Drawing.Point(212, 131);
            this.firstNameValue.Name = "firstNameValue";
            this.firstNameValue.Size = new System.Drawing.Size(282, 38);
            this.firstNameValue.TabIndex = 0;
            // 
            // HeaderLabel
            // 
            this.HeaderLabel.AutoSize = true;
            this.HeaderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeaderLabel.Location = new System.Drawing.Point(59, 44);
            this.HeaderLabel.Name = "HeaderLabel";
            this.HeaderLabel.Size = new System.Drawing.Size(536, 49);
            this.HeaderLabel.TabIndex = 1;
            this.HeaderLabel.Text = "Employee Creation Demo";
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstNameLabel.Location = new System.Drawing.Point(49, 131);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(180, 40);
            this.FirstNameLabel.TabIndex = 2;
            this.FirstNameLabel.Text = "FirstName";
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastNameLabel.Location = new System.Drawing.Point(49, 193);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(143, 32);
            this.LastNameLabel.TabIndex = 3;
            this.LastNameLabel.Text = "LastName";
            // 
            // lasttNameValue
            // 
            this.lasttNameValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lasttNameValue.Location = new System.Drawing.Point(227, 190);
            this.lasttNameValue.Name = "lasttNameValue";
            this.lasttNameValue.Size = new System.Drawing.Size(267, 38);
            this.lasttNameValue.TabIndex = 4;
            // 
            // generateEmployeeId
            // 
            this.generateEmployeeId.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generateEmployeeId.Location = new System.Drawing.Point(98, 251);
            this.generateEmployeeId.Name = "generateEmployeeId";
            this.generateEmployeeId.Size = new System.Drawing.Size(328, 69);
            this.generateEmployeeId.TabIndex = 5;
            this.generateEmployeeId.Text = "Generate Employee Id";
            this.generateEmployeeId.UseVisualStyleBackColor = true;
            this.generateEmployeeId.Click += new System.EventHandler(this.generateEmployeeId_Click);
            // 
            // employeeId
            // 
            this.employeeId.AutoSize = true;
            this.employeeId.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeId.Location = new System.Drawing.Point(37, 355);
            this.employeeId.Name = "employeeId";
            this.employeeId.Size = new System.Drawing.Size(175, 32);
            this.employeeId.TabIndex = 6;
            this.employeeId.Text = "Employee ID";
            // 
            // employeeidvalue
            // 
            this.employeeidvalue.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeidvalue.Location = new System.Drawing.Point(227, 349);
            this.employeeidvalue.Name = "employeeidvalue";
            this.employeeidvalue.Size = new System.Drawing.Size(267, 38);
            this.employeeidvalue.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.employeeidvalue);
            this.Controls.Add(this.employeeId);
            this.Controls.Add(this.generateEmployeeId);
            this.Controls.Add(this.lasttNameValue);
            this.Controls.Add(this.LastNameLabel);
            this.Controls.Add(this.FirstNameLabel);
            this.Controls.Add(this.HeaderLabel);
            this.Controls.Add(this.firstNameValue);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox firstNameValue;
        private System.Windows.Forms.Label HeaderLabel;
        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.TextBox lasttNameValue;
        private System.Windows.Forms.Button generateEmployeeId;
        private System.Windows.Forms.Label employeeId;
        private System.Windows.Forms.TextBox employeeidvalue;
    }
}

