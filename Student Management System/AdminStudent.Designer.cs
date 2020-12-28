
namespace Student_Management_System
{
    partial class AdminStudent
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.closeStudentButton = new System.Windows.Forms.Button();
            this.adminStudentData = new System.Windows.Forms.DataGridView();
            this.deleteStudentButton = new System.Windows.Forms.Button();
            this.removeCompleted = new System.Windows.Forms.Button();
            this.studentCompletedButton = new System.Windows.Forms.Button();
            this.searchStudentGroup = new System.Windows.Forms.GroupBox();
            this.searchStudentButton = new System.Windows.Forms.Button();
            this.label60 = new System.Windows.Forms.Label();
            this.searchStudent = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adminStudentData)).BeginInit();
            this.searchStudentGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.closeStudentButton);
            this.panel1.Controls.Add(this.adminStudentData);
            this.panel1.Controls.Add(this.deleteStudentButton);
            this.panel1.Controls.Add(this.removeCompleted);
            this.panel1.Controls.Add(this.studentCompletedButton);
            this.panel1.Location = new System.Drawing.Point(16, 131);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(671, 199);
            this.panel1.TabIndex = 15;
            this.panel1.Visible = false;
            // 
            // closeStudentButton
            // 
            this.closeStudentButton.Location = new System.Drawing.Point(482, 144);
            this.closeStudentButton.Name = "closeStudentButton";
            this.closeStudentButton.Size = new System.Drawing.Size(75, 29);
            this.closeStudentButton.TabIndex = 15;
            this.closeStudentButton.Text = "Close";
            this.closeStudentButton.UseVisualStyleBackColor = true;
            this.closeStudentButton.Click += new System.EventHandler(this.closeStudentButton_Click);
            // 
            // adminStudentData
            // 
            this.adminStudentData.AllowUserToAddRows = false;
            this.adminStudentData.AllowUserToDeleteRows = false;
            this.adminStudentData.AllowUserToResizeColumns = false;
            this.adminStudentData.AllowUserToResizeRows = false;
            this.adminStudentData.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.adminStudentData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.adminStudentData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.adminStudentData.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.adminStudentData.Location = new System.Drawing.Point(0, 3);
            this.adminStudentData.Name = "adminStudentData";
            this.adminStudentData.ReadOnly = true;
            this.adminStudentData.RowHeadersVisible = false;
            this.adminStudentData.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminStudentData.RowTemplate.Height = 90;
            this.adminStudentData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.adminStudentData.Size = new System.Drawing.Size(671, 112);
            this.adminStudentData.TabIndex = 12;
            // 
            // deleteStudentButton
            // 
            this.deleteStudentButton.Location = new System.Drawing.Point(236, 145);
            this.deleteStudentButton.Name = "deleteStudentButton";
            this.deleteStudentButton.Size = new System.Drawing.Size(90, 28);
            this.deleteStudentButton.TabIndex = 10;
            this.deleteStudentButton.Text = "Delete Student";
            this.deleteStudentButton.UseVisualStyleBackColor = true;
            this.deleteStudentButton.Click += new System.EventHandler(this.deleteStudentButton_Click);
            // 
            // removeCompleted
            // 
            this.removeCompleted.Location = new System.Drawing.Point(332, 145);
            this.removeCompleted.Name = "removeCompleted";
            this.removeCompleted.Size = new System.Drawing.Size(144, 28);
            this.removeCompleted.TabIndex = 14;
            this.removeCompleted.Text = "Remove from Completed";
            this.removeCompleted.UseVisualStyleBackColor = true;
            this.removeCompleted.Visible = false;
            this.removeCompleted.Click += new System.EventHandler(this.removeCompleted_Click);
            // 
            // studentCompletedButton
            // 
            this.studentCompletedButton.Location = new System.Drawing.Point(332, 145);
            this.studentCompletedButton.Name = "studentCompletedButton";
            this.studentCompletedButton.Size = new System.Drawing.Size(109, 28);
            this.studentCompletedButton.TabIndex = 13;
            this.studentCompletedButton.Text = "Add to Completed";
            this.studentCompletedButton.UseVisualStyleBackColor = true;
            this.studentCompletedButton.Click += new System.EventHandler(this.studentCompletedButton_Click);
            // 
            // searchStudentGroup
            // 
            this.searchStudentGroup.Controls.Add(this.searchStudentButton);
            this.searchStudentGroup.Controls.Add(this.label60);
            this.searchStudentGroup.Controls.Add(this.searchStudent);
            this.searchStudentGroup.Location = new System.Drawing.Point(193, 38);
            this.searchStudentGroup.Name = "searchStudentGroup";
            this.searchStudentGroup.Size = new System.Drawing.Size(322, 77);
            this.searchStudentGroup.TabIndex = 14;
            this.searchStudentGroup.TabStop = false;
            this.searchStudentGroup.Text = "Search ID";
            // 
            // searchStudentButton
            // 
            this.searchStudentButton.Location = new System.Drawing.Point(236, 32);
            this.searchStudentButton.Name = "searchStudentButton";
            this.searchStudentButton.Size = new System.Drawing.Size(63, 23);
            this.searchStudentButton.TabIndex = 2;
            this.searchStudentButton.Text = "Search";
            this.searchStudentButton.UseVisualStyleBackColor = true;
            this.searchStudentButton.Click += new System.EventHandler(this.searchStudentButton_Click);
            // 
            // label60
            // 
            this.label60.AutoSize = true;
            this.label60.Location = new System.Drawing.Point(23, 35);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(64, 13);
            this.label60.TabIndex = 1;
            this.label60.Text = "Student ID: ";
            // 
            // searchStudent
            // 
            this.searchStudent.Location = new System.Drawing.Point(93, 32);
            this.searchStudent.MaxLength = 6;
            this.searchStudent.Name = "searchStudent";
            this.searchStudent.Size = new System.Drawing.Size(136, 20);
            this.searchStudent.TabIndex = 0;
            // 
            // AdminStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 345);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.searchStudentGroup);
            this.MaximizeBox = false;
            this.Name = "AdminStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminStudent";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.adminStudentData)).EndInit();
            this.searchStudentGroup.ResumeLayout(false);
            this.searchStudentGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button closeStudentButton;
        private System.Windows.Forms.Button removeCompleted;
        private System.Windows.Forms.Button studentCompletedButton;
        private System.Windows.Forms.DataGridView adminStudentData;
        private System.Windows.Forms.Button deleteStudentButton;
        private System.Windows.Forms.GroupBox searchStudentGroup;
        private System.Windows.Forms.Button searchStudentButton;
        private System.Windows.Forms.Label label60;
        private System.Windows.Forms.TextBox searchStudent;
    }
}