
namespace Student_Management_System
{
    partial class AddCourse
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label84 = new System.Windows.Forms.Label();
            this.label86 = new System.Windows.Forms.Label();
            this.label87 = new System.Windows.Forms.Label();
            this.courseFees = new System.Windows.Forms.TextBox();
            this.courseDuration = new System.Windows.Forms.ComboBox();
            this.addCourseButton = new System.Windows.Forms.Button();
            this.courseName = new System.Windows.Forms.TextBox();
            this.label49 = new System.Windows.Forms.Label();
            this.label48 = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label84);
            this.groupBox4.Controls.Add(this.label86);
            this.groupBox4.Controls.Add(this.label87);
            this.groupBox4.Controls.Add(this.courseFees);
            this.groupBox4.Controls.Add(this.courseDuration);
            this.groupBox4.Controls.Add(this.addCourseButton);
            this.groupBox4.Controls.Add(this.courseName);
            this.groupBox4.Controls.Add(this.label49);
            this.groupBox4.Controls.Add(this.label48);
            this.groupBox4.Controls.Add(this.label47);
            this.groupBox4.Location = new System.Drawing.Point(26, 39);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(370, 228);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Add Course";
            // 
            // label84
            // 
            this.label84.AutoSize = true;
            this.label84.ForeColor = System.Drawing.Color.Red;
            this.label84.Location = new System.Drawing.Point(40, 121);
            this.label84.Name = "label84";
            this.label84.Size = new System.Drawing.Size(11, 13);
            this.label84.TabIndex = 21;
            this.label84.Text = "*";
            // 
            // label86
            // 
            this.label86.AutoSize = true;
            this.label86.ForeColor = System.Drawing.Color.Red;
            this.label86.Location = new System.Drawing.Point(80, 83);
            this.label86.Name = "label86";
            this.label86.Size = new System.Drawing.Size(11, 13);
            this.label86.TabIndex = 19;
            this.label86.Text = "*";
            // 
            // label87
            // 
            this.label87.AutoSize = true;
            this.label87.ForeColor = System.Drawing.Color.Red;
            this.label87.Location = new System.Drawing.Point(71, 46);
            this.label87.Name = "label87";
            this.label87.Size = new System.Drawing.Size(11, 13);
            this.label87.TabIndex = 18;
            this.label87.Text = "*";
            // 
            // courseFees
            // 
            this.courseFees.Location = new System.Drawing.Point(131, 82);
            this.courseFees.MaxLength = 6;
            this.courseFees.Name = "courseFees";
            this.courseFees.Size = new System.Drawing.Size(158, 20);
            this.courseFees.TabIndex = 9;
            // 
            // courseDuration
            // 
            this.courseDuration.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.courseDuration.FormattingEnabled = true;
            this.courseDuration.Items.AddRange(new object[] {
            "1 Month",
            "2 Months",
            "3 Months",
            "5 Months",
            "6 Months",
            "8 Months",
            "1 Year"});
            this.courseDuration.Location = new System.Drawing.Point(131, 119);
            this.courseDuration.Name = "courseDuration";
            this.courseDuration.Size = new System.Drawing.Size(158, 21);
            this.courseDuration.TabIndex = 8;
            // 
            // addCourseButton
            // 
            this.addCourseButton.Location = new System.Drawing.Point(131, 168);
            this.addCourseButton.Name = "addCourseButton";
            this.addCourseButton.Size = new System.Drawing.Size(158, 29);
            this.addCourseButton.TabIndex = 7;
            this.addCourseButton.Text = "Add";
            this.addCourseButton.UseVisualStyleBackColor = true;
            this.addCourseButton.Click += new System.EventHandler(this.addCourseButton_Click);
            // 
            // courseName
            // 
            this.courseName.Location = new System.Drawing.Point(131, 44);
            this.courseName.Name = "courseName";
            this.courseName.Size = new System.Drawing.Size(158, 20);
            this.courseName.TabIndex = 5;
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Location = new System.Drawing.Point(49, 122);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(76, 13);
            this.label49.TabIndex = 3;
            this.label49.Text = "Time Duration:";
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Location = new System.Drawing.Point(92, 85);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(33, 13);
            this.label48.TabIndex = 2;
            this.label48.Text = "Fees:";
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Location = new System.Drawing.Point(82, 47);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(43, 13);
            this.label47.TabIndex = 0;
            this.label47.Text = "Course:";
            // 
            // AddCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 321);
            this.Controls.Add(this.groupBox4);
            this.MaximizeBox = false;
            this.Name = "AddCourse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Course";
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label84;
        private System.Windows.Forms.Label label86;
        private System.Windows.Forms.Label label87;
        private System.Windows.Forms.TextBox courseFees;
        private System.Windows.Forms.ComboBox courseDuration;
        private System.Windows.Forms.Button addCourseButton;
        private System.Windows.Forms.TextBox courseName;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.Label label47;
    }
}