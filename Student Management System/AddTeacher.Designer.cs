
namespace Student_Management_System
{
    partial class AddTeacher
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
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.teacherSubject = new System.Windows.Forms.ComboBox();
            this.label74 = new System.Windows.Forms.Label();
            this.label73 = new System.Windows.Forms.Label();
            this.label72 = new System.Windows.Forms.Label();
            this.teacherLastname = new System.Windows.Forms.TextBox();
            this.label51 = new System.Windows.Forms.Label();
            this.addTeacherButton = new System.Windows.Forms.Button();
            this.teacherFirstname = new System.Windows.Forms.TextBox();
            this.label52 = new System.Windows.Forms.Label();
            this.label53 = new System.Windows.Forms.Label();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.teacherSubject);
            this.groupBox5.Controls.Add(this.label74);
            this.groupBox5.Controls.Add(this.label73);
            this.groupBox5.Controls.Add(this.label72);
            this.groupBox5.Controls.Add(this.teacherLastname);
            this.groupBox5.Controls.Add(this.label51);
            this.groupBox5.Controls.Add(this.addTeacherButton);
            this.groupBox5.Controls.Add(this.teacherFirstname);
            this.groupBox5.Controls.Add(this.label52);
            this.groupBox5.Controls.Add(this.label53);
            this.groupBox5.Location = new System.Drawing.Point(23, 27);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(370, 266);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Add Teacher";
            // 
            // teacherSubject
            // 
            this.teacherSubject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.teacherSubject.FormattingEnabled = true;
            this.teacherSubject.Items.AddRange(new object[] {
            "Math",
            "Filipino",
            "English",
            "Science",
            "Web Development",
            "Desktop Development",
            "Calculus",
            "Logic",
            "Cisco",
            "History",
            "Programming"});
            this.teacherSubject.Location = new System.Drawing.Point(144, 126);
            this.teacherSubject.Name = "teacherSubject";
            this.teacherSubject.Size = new System.Drawing.Size(157, 21);
            this.teacherSubject.TabIndex = 18;
            // 
            // label74
            // 
            this.label74.AutoSize = true;
            this.label74.ForeColor = System.Drawing.Color.Red;
            this.label74.Location = new System.Drawing.Point(73, 93);
            this.label74.Name = "label74";
            this.label74.Size = new System.Drawing.Size(11, 13);
            this.label74.TabIndex = 17;
            this.label74.Text = "*";
            // 
            // label73
            // 
            this.label73.AutoSize = true;
            this.label73.ForeColor = System.Drawing.Color.Red;
            this.label73.Location = new System.Drawing.Point(82, 129);
            this.label73.Name = "label73";
            this.label73.Size = new System.Drawing.Size(11, 13);
            this.label73.TabIndex = 16;
            this.label73.Text = "*";
            // 
            // label72
            // 
            this.label72.AutoSize = true;
            this.label72.ForeColor = System.Drawing.Color.Red;
            this.label72.Location = new System.Drawing.Point(73, 56);
            this.label72.Name = "label72";
            this.label72.Size = new System.Drawing.Size(11, 13);
            this.label72.TabIndex = 15;
            this.label72.Text = "*";
            // 
            // teacherLastname
            // 
            this.teacherLastname.Location = new System.Drawing.Point(143, 91);
            this.teacherLastname.Name = "teacherLastname";
            this.teacherLastname.Size = new System.Drawing.Size(158, 20);
            this.teacherLastname.TabIndex = 11;
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Location = new System.Drawing.Point(91, 129);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(46, 13);
            this.label51.TabIndex = 7;
            this.label51.Text = "Subject:";
            // 
            // addTeacherButton
            // 
            this.addTeacherButton.Location = new System.Drawing.Point(143, 181);
            this.addTeacherButton.Name = "addTeacherButton";
            this.addTeacherButton.Size = new System.Drawing.Size(158, 27);
            this.addTeacherButton.TabIndex = 6;
            this.addTeacherButton.Text = "Add";
            this.addTeacherButton.UseVisualStyleBackColor = true;
            this.addTeacherButton.Click += new System.EventHandler(this.addTeacherButton_Click);
            // 
            // teacherFirstname
            // 
            this.teacherFirstname.Location = new System.Drawing.Point(143, 53);
            this.teacherFirstname.Name = "teacherFirstname";
            this.teacherFirstname.Size = new System.Drawing.Size(158, 20);
            this.teacherFirstname.TabIndex = 5;
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Location = new System.Drawing.Point(81, 94);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(56, 13);
            this.label52.TabIndex = 2;
            this.label52.Text = "Lastname:";
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Location = new System.Drawing.Point(82, 57);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(55, 13);
            this.label53.TabIndex = 0;
            this.label53.Text = "Firstname:";
            // 
            // AddTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 321);
            this.Controls.Add(this.groupBox5);
            this.MaximizeBox = false;
            this.Name = "AddTeacher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddTeacher";
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ComboBox teacherSubject;
        private System.Windows.Forms.Label label74;
        private System.Windows.Forms.Label label73;
        private System.Windows.Forms.Label label72;
        private System.Windows.Forms.TextBox teacherLastname;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.Button addTeacherButton;
        private System.Windows.Forms.TextBox teacherFirstname;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.Label label53;
    }
}