
namespace Student_Management_System
{
    partial class ViewCourse
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.listofCourseData = new System.Windows.Forms.DataGridView();
            this.courseLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.listofCourseData)).BeginInit();
            this.SuspendLayout();
            // 
            // listofCourseData
            // 
            this.listofCourseData.AllowUserToAddRows = false;
            this.listofCourseData.AllowUserToDeleteRows = false;
            this.listofCourseData.AllowUserToResizeColumns = false;
            this.listofCourseData.AllowUserToResizeRows = false;
            this.listofCourseData.BackgroundColor = System.Drawing.SystemColors.Control;
            this.listofCourseData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.listofCourseData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.listofCourseData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listofCourseData.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.listofCourseData.Location = new System.Drawing.Point(35, 50);
            this.listofCourseData.Name = "listofCourseData";
            this.listofCourseData.ReadOnly = true;
            this.listofCourseData.RowHeadersVisible = false;
            this.listofCourseData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listofCourseData.Size = new System.Drawing.Size(397, 353);
            this.listofCourseData.TabIndex = 10;
            // 
            // courseLabel
            // 
            this.courseLabel.AutoSize = true;
            this.courseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseLabel.Location = new System.Drawing.Point(32, 31);
            this.courseLabel.Name = "courseLabel";
            this.courseLabel.Size = new System.Drawing.Size(106, 13);
            this.courseLabel.TabIndex = 9;
            this.courseLabel.Text = "List of Courses(0)";
            // 
            // ViewCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 415);
            this.Controls.Add(this.listofCourseData);
            this.Controls.Add(this.courseLabel);
            this.MaximizeBox = false;
            this.Name = "ViewCourse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewCourse";
            this.Load += new System.EventHandler(this.ViewCourse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listofCourseData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView listofCourseData;
        private System.Windows.Forms.Label courseLabel;
    }
}