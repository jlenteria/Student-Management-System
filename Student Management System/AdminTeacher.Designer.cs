
namespace Student_Management_System
{
    partial class AdminTeacher
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
            this.searchTeacherGroup = new System.Windows.Forms.GroupBox();
            this.searchTeacherButton = new System.Windows.Forms.Button();
            this.label61 = new System.Windows.Forms.Label();
            this.searchTeacher = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.closeTeacher = new System.Windows.Forms.Button();
            this.editTeacherButton = new System.Windows.Forms.Button();
            this.adminTeacherData = new System.Windows.Forms.DataGridView();
            this.deleteTeacherButton = new System.Windows.Forms.Button();
            this.editTeacherPanel = new System.Windows.Forms.GroupBox();
            this.closeUpdateButton = new System.Windows.Forms.Button();
            this.updateTeacherButton = new System.Windows.Forms.Button();
            this.editTeacherSubject = new System.Windows.Forms.ComboBox();
            this.label76 = new System.Windows.Forms.Label();
            this.label77 = new System.Windows.Forms.Label();
            this.label78 = new System.Windows.Forms.Label();
            this.editTeacherFname = new System.Windows.Forms.TextBox();
            this.label81 = new System.Windows.Forms.Label();
            this.editTeacherLname = new System.Windows.Forms.TextBox();
            this.label82 = new System.Windows.Forms.Label();
            this.label83 = new System.Windows.Forms.Label();
            this.searchTeacherGroup.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adminTeacherData)).BeginInit();
            this.editTeacherPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchTeacherGroup
            // 
            this.searchTeacherGroup.Controls.Add(this.searchTeacherButton);
            this.searchTeacherGroup.Controls.Add(this.label61);
            this.searchTeacherGroup.Controls.Add(this.searchTeacher);
            this.searchTeacherGroup.Location = new System.Drawing.Point(191, 26);
            this.searchTeacherGroup.Name = "searchTeacherGroup";
            this.searchTeacherGroup.Size = new System.Drawing.Size(322, 77);
            this.searchTeacherGroup.TabIndex = 14;
            this.searchTeacherGroup.TabStop = false;
            this.searchTeacherGroup.Text = "Search ID";
            // 
            // searchTeacherButton
            // 
            this.searchTeacherButton.Location = new System.Drawing.Point(236, 32);
            this.searchTeacherButton.Name = "searchTeacherButton";
            this.searchTeacherButton.Size = new System.Drawing.Size(63, 23);
            this.searchTeacherButton.TabIndex = 2;
            this.searchTeacherButton.Text = "Search";
            this.searchTeacherButton.UseVisualStyleBackColor = true;
            this.searchTeacherButton.Click += new System.EventHandler(this.searchTeacherButton_Click);
            // 
            // label61
            // 
            this.label61.AutoSize = true;
            this.label61.Location = new System.Drawing.Point(23, 35);
            this.label61.Name = "label61";
            this.label61.Size = new System.Drawing.Size(67, 13);
            this.label61.TabIndex = 1;
            this.label61.Text = "Teacher ID: ";
            // 
            // searchTeacher
            // 
            this.searchTeacher.Location = new System.Drawing.Point(93, 32);
            this.searchTeacher.MaxLength = 6;
            this.searchTeacher.Name = "searchTeacher";
            this.searchTeacher.Size = new System.Drawing.Size(136, 20);
            this.searchTeacher.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.closeTeacher);
            this.panel2.Controls.Add(this.editTeacherButton);
            this.panel2.Controls.Add(this.adminTeacherData);
            this.panel2.Controls.Add(this.deleteTeacherButton);
            this.panel2.Location = new System.Drawing.Point(151, 119);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(398, 199);
            this.panel2.TabIndex = 15;
            this.panel2.Visible = false;
            // 
            // closeTeacher
            // 
            this.closeTeacher.Location = new System.Drawing.Point(282, 155);
            this.closeTeacher.Name = "closeTeacher";
            this.closeTeacher.Size = new System.Drawing.Size(75, 29);
            this.closeTeacher.TabIndex = 16;
            this.closeTeacher.Text = "Close";
            this.closeTeacher.UseVisualStyleBackColor = true;
            this.closeTeacher.Click += new System.EventHandler(this.closeTeacher_Click);
            // 
            // editTeacherButton
            // 
            this.editTeacherButton.Location = new System.Drawing.Point(161, 155);
            this.editTeacherButton.Name = "editTeacherButton";
            this.editTeacherButton.Size = new System.Drawing.Size(115, 28);
            this.editTeacherButton.TabIndex = 14;
            this.editTeacherButton.Text = "Edit Teacher";
            this.editTeacherButton.UseVisualStyleBackColor = true;
            this.editTeacherButton.Click += new System.EventHandler(this.editTeacherButton_Click);
            // 
            // adminTeacherData
            // 
            this.adminTeacherData.AllowUserToAddRows = false;
            this.adminTeacherData.AllowUserToDeleteRows = false;
            this.adminTeacherData.AllowUserToResizeColumns = false;
            this.adminTeacherData.AllowUserToResizeRows = false;
            this.adminTeacherData.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.adminTeacherData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.adminTeacherData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.adminTeacherData.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.adminTeacherData.Location = new System.Drawing.Point(0, 3);
            this.adminTeacherData.Name = "adminTeacherData";
            this.adminTeacherData.ReadOnly = true;
            this.adminTeacherData.RowHeadersVisible = false;
            this.adminTeacherData.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminTeacherData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.adminTeacherData.Size = new System.Drawing.Size(397, 99);
            this.adminTeacherData.TabIndex = 13;
            // 
            // deleteTeacherButton
            // 
            this.deleteTeacherButton.Location = new System.Drawing.Point(40, 155);
            this.deleteTeacherButton.Name = "deleteTeacherButton";
            this.deleteTeacherButton.Size = new System.Drawing.Size(115, 28);
            this.deleteTeacherButton.TabIndex = 10;
            this.deleteTeacherButton.Text = "Delete Teacher";
            this.deleteTeacherButton.UseVisualStyleBackColor = true;
            this.deleteTeacherButton.Click += new System.EventHandler(this.deleteTeacherButton_Click);
            // 
            // editTeacherPanel
            // 
            this.editTeacherPanel.Controls.Add(this.closeUpdateButton);
            this.editTeacherPanel.Controls.Add(this.updateTeacherButton);
            this.editTeacherPanel.Controls.Add(this.editTeacherSubject);
            this.editTeacherPanel.Controls.Add(this.label76);
            this.editTeacherPanel.Controls.Add(this.label77);
            this.editTeacherPanel.Controls.Add(this.label78);
            this.editTeacherPanel.Controls.Add(this.editTeacherFname);
            this.editTeacherPanel.Controls.Add(this.label81);
            this.editTeacherPanel.Controls.Add(this.editTeacherLname);
            this.editTeacherPanel.Controls.Add(this.label82);
            this.editTeacherPanel.Controls.Add(this.label83);
            this.editTeacherPanel.Location = new System.Drawing.Point(151, 119);
            this.editTeacherPanel.Name = "editTeacherPanel";
            this.editTeacherPanel.Size = new System.Drawing.Size(398, 200);
            this.editTeacherPanel.TabIndex = 16;
            this.editTeacherPanel.TabStop = false;
            this.editTeacherPanel.Text = "Edit Teacher";
            this.editTeacherPanel.Visible = false;
            // 
            // closeUpdateButton
            // 
            this.closeUpdateButton.Location = new System.Drawing.Point(227, 155);
            this.closeUpdateButton.Name = "closeUpdateButton";
            this.closeUpdateButton.Size = new System.Drawing.Size(75, 29);
            this.closeUpdateButton.TabIndex = 20;
            this.closeUpdateButton.Text = "Cancel";
            this.closeUpdateButton.UseVisualStyleBackColor = true;
            this.closeUpdateButton.Click += new System.EventHandler(this.closeUpdateButton_Click);
            // 
            // updateTeacherButton
            // 
            this.updateTeacherButton.Location = new System.Drawing.Point(144, 155);
            this.updateTeacherButton.Name = "updateTeacherButton";
            this.updateTeacherButton.Size = new System.Drawing.Size(79, 29);
            this.updateTeacherButton.TabIndex = 19;
            this.updateTeacherButton.Text = "Update";
            this.updateTeacherButton.UseVisualStyleBackColor = true;
            this.updateTeacherButton.Click += new System.EventHandler(this.updateTeacherButton_Click);
            // 
            // editTeacherSubject
            // 
            this.editTeacherSubject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.editTeacherSubject.FormattingEnabled = true;
            this.editTeacherSubject.Items.AddRange(new object[] {
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
            this.editTeacherSubject.Location = new System.Drawing.Point(145, 108);
            this.editTeacherSubject.Name = "editTeacherSubject";
            this.editTeacherSubject.Size = new System.Drawing.Size(157, 21);
            this.editTeacherSubject.TabIndex = 18;
            // 
            // label76
            // 
            this.label76.AutoSize = true;
            this.label76.ForeColor = System.Drawing.Color.Red;
            this.label76.Location = new System.Drawing.Point(74, 72);
            this.label76.Name = "label76";
            this.label76.Size = new System.Drawing.Size(11, 13);
            this.label76.TabIndex = 17;
            this.label76.Text = "*";
            // 
            // label77
            // 
            this.label77.AutoSize = true;
            this.label77.ForeColor = System.Drawing.Color.Red;
            this.label77.Location = new System.Drawing.Point(83, 111);
            this.label77.Name = "label77";
            this.label77.Size = new System.Drawing.Size(11, 13);
            this.label77.TabIndex = 16;
            this.label77.Text = "*";
            // 
            // label78
            // 
            this.label78.AutoSize = true;
            this.label78.ForeColor = System.Drawing.Color.Red;
            this.label78.Location = new System.Drawing.Point(74, 32);
            this.label78.Name = "label78";
            this.label78.Size = new System.Drawing.Size(11, 13);
            this.label78.TabIndex = 15;
            this.label78.Text = "*";
            // 
            // editTeacherFname
            // 
            this.editTeacherFname.Location = new System.Drawing.Point(144, 30);
            this.editTeacherFname.Name = "editTeacherFname";
            this.editTeacherFname.Size = new System.Drawing.Size(158, 20);
            this.editTeacherFname.TabIndex = 11;
            // 
            // label81
            // 
            this.label81.AutoSize = true;
            this.label81.Location = new System.Drawing.Point(92, 111);
            this.label81.Name = "label81";
            this.label81.Size = new System.Drawing.Size(46, 13);
            this.label81.TabIndex = 7;
            this.label81.Text = "Subject:";
            // 
            // editTeacherLname
            // 
            this.editTeacherLname.Location = new System.Drawing.Point(144, 68);
            this.editTeacherLname.Name = "editTeacherLname";
            this.editTeacherLname.Size = new System.Drawing.Size(158, 20);
            this.editTeacherLname.TabIndex = 5;
            // 
            // label82
            // 
            this.label82.AutoSize = true;
            this.label82.Location = new System.Drawing.Point(82, 72);
            this.label82.Name = "label82";
            this.label82.Size = new System.Drawing.Size(56, 13);
            this.label82.TabIndex = 2;
            this.label82.Text = "Lastname:";
            // 
            // label83
            // 
            this.label83.AutoSize = true;
            this.label83.Location = new System.Drawing.Point(83, 33);
            this.label83.Name = "label83";
            this.label83.Size = new System.Drawing.Size(55, 13);
            this.label83.TabIndex = 0;
            this.label83.Text = "Firstname:";
            // 
            // AdminTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 345);
            this.Controls.Add(this.searchTeacherGroup);
            this.Controls.Add(this.editTeacherPanel);
            this.Controls.Add(this.panel2);
            this.MaximizeBox = false;
            this.Name = "AdminTeacher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminTeacher";
            this.searchTeacherGroup.ResumeLayout(false);
            this.searchTeacherGroup.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.adminTeacherData)).EndInit();
            this.editTeacherPanel.ResumeLayout(false);
            this.editTeacherPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox searchTeacherGroup;
        private System.Windows.Forms.Button searchTeacherButton;
        private System.Windows.Forms.Label label61;
        private System.Windows.Forms.TextBox searchTeacher;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button closeTeacher;
        private System.Windows.Forms.Button editTeacherButton;
        private System.Windows.Forms.DataGridView adminTeacherData;
        private System.Windows.Forms.Button deleteTeacherButton;
        private System.Windows.Forms.GroupBox editTeacherPanel;
        private System.Windows.Forms.Button closeUpdateButton;
        private System.Windows.Forms.Button updateTeacherButton;
        private System.Windows.Forms.ComboBox editTeacherSubject;
        private System.Windows.Forms.Label label76;
        private System.Windows.Forms.Label label77;
        private System.Windows.Forms.Label label78;
        private System.Windows.Forms.TextBox editTeacherFname;
        private System.Windows.Forms.Label label81;
        private System.Windows.Forms.TextBox editTeacherLname;
        private System.Windows.Forms.Label label82;
        private System.Windows.Forms.Label label83;
    }
}