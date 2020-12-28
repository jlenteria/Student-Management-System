
namespace Student_Management_System
{
    partial class View_Student
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.listofStudentData = new System.Windows.Forms.DataGridView();
            this.studentLabel = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.filterCourse = new System.Windows.Forms.ComboBox();
            this.Lastname = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.filterTeacher = new System.Windows.Forms.ComboBox();
            this.sortLastname = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.listofStudentData)).BeginInit();
            this.SuspendLayout();
            // 
            // listofStudentData
            // 
            this.listofStudentData.AllowUserToAddRows = false;
            this.listofStudentData.AllowUserToDeleteRows = false;
            this.listofStudentData.AllowUserToResizeColumns = false;
            this.listofStudentData.AllowUserToResizeRows = false;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.listofStudentData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.listofStudentData.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.listofStudentData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.listofStudentData.CausesValidation = false;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.listofStudentData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.listofStudentData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listofStudentData.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.listofStudentData.Location = new System.Drawing.Point(49, 100);
            this.listofStudentData.MultiSelect = false;
            this.listofStudentData.Name = "listofStudentData";
            this.listofStudentData.ReadOnly = true;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.listofStudentData.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.listofStudentData.RowHeadersVisible = false;
            this.listofStudentData.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.listofStudentData.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listofStudentData.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.listofStudentData.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.listofStudentData.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.listofStudentData.RowTemplate.Height = 90;
            this.listofStudentData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listofStudentData.ShowCellErrors = false;
            this.listofStudentData.ShowCellToolTips = false;
            this.listofStudentData.ShowEditingIcon = false;
            this.listofStudentData.ShowRowErrors = false;
            this.listofStudentData.Size = new System.Drawing.Size(887, 281);
            this.listofStudentData.TabIndex = 19;
            // 
            // studentLabel
            // 
            this.studentLabel.AutoSize = true;
            this.studentLabel.Location = new System.Drawing.Point(46, 77);
            this.studentLabel.Name = "studentLabel";
            this.studentLabel.Size = new System.Drawing.Size(73, 13);
            this.studentLabel.TabIndex = 18;
            this.studentLabel.Text = "List of Data(0)";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.Location = new System.Drawing.Point(414, 74);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(49, 15);
            this.label34.TabIndex = 17;
            this.label34.Text = "Course:";
            // 
            // filterCourse
            // 
            this.filterCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filterCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterCourse.FormattingEnabled = true;
            this.filterCourse.Location = new System.Drawing.Point(469, 69);
            this.filterCourse.Name = "filterCourse";
            this.filterCourse.Size = new System.Drawing.Size(99, 21);
            this.filterCourse.TabIndex = 16;
            this.filterCourse.SelectedIndexChanged += new System.EventHandler(this.filterCourse_SelectedIndexChanged);
            this.filterCourse.Click += new System.EventHandler(this.filterCourse_Click);
            // 
            // Lastname
            // 
            this.Lastname.AutoSize = true;
            this.Lastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lastname.Location = new System.Drawing.Point(754, 72);
            this.Lastname.Name = "Lastname";
            this.Lastname.Size = new System.Drawing.Size(70, 15);
            this.Lastname.TabIndex = 15;
            this.Lastname.Text = "Last Name:";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.Location = new System.Drawing.Point(581, 74);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(55, 15);
            this.label32.TabIndex = 14;
            this.label32.Text = "Teacher:";
            // 
            // filterTeacher
            // 
            this.filterTeacher.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filterTeacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterTeacher.FormattingEnabled = true;
            this.filterTeacher.Location = new System.Drawing.Point(642, 69);
            this.filterTeacher.Name = "filterTeacher";
            this.filterTeacher.Size = new System.Drawing.Size(102, 21);
            this.filterTeacher.TabIndex = 13;
            this.filterTeacher.SelectedIndexChanged += new System.EventHandler(this.filterTeacher_SelectedIndexChanged);
            this.filterTeacher.Click += new System.EventHandler(this.filterTeacher_Click);
            // 
            // sortLastname
            // 
            this.sortLastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sortLastname.Location = new System.Drawing.Point(825, 70);
            this.sortLastname.Name = "sortLastname";
            this.sortLastname.Size = new System.Drawing.Size(111, 20);
            this.sortLastname.TabIndex = 12;
            this.sortLastname.TextChanged += new System.EventHandler(this.sortLastname_TextChanged);
            // 
            // View_Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 450);
            this.Controls.Add(this.listofStudentData);
            this.Controls.Add(this.studentLabel);
            this.Controls.Add(this.label34);
            this.Controls.Add(this.filterCourse);
            this.Controls.Add(this.Lastname);
            this.Controls.Add(this.label32);
            this.Controls.Add(this.filterTeacher);
            this.Controls.Add(this.sortLastname);
            this.MaximizeBox = false;
            this.Name = "View_Student";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Student";
            this.Load += new System.EventHandler(this.View_Student_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listofStudentData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label studentLabel;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.ComboBox filterCourse;
        private System.Windows.Forms.Label Lastname;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.ComboBox filterTeacher;
        private System.Windows.Forms.TextBox sortLastname;
        private System.Windows.Forms.DataGridView listofStudentData;
    }
}