
namespace Student_Management_System
{
    partial class ViewTeacher
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
            this.teacherLabel = new System.Windows.Forms.Label();
            this.listofTeachersData = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.listofTeachersData)).BeginInit();
            this.SuspendLayout();
            // 
            // teacherLabel
            // 
            this.teacherLabel.AutoSize = true;
            this.teacherLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teacherLabel.Location = new System.Drawing.Point(34, 57);
            this.teacherLabel.Name = "teacherLabel";
            this.teacherLabel.Size = new System.Drawing.Size(114, 13);
            this.teacherLabel.TabIndex = 11;
            this.teacherLabel.Text = "List of Teachers(0)";
            // 
            // listofTeachersData
            // 
            this.listofTeachersData.AllowUserToAddRows = false;
            this.listofTeachersData.AllowUserToDeleteRows = false;
            this.listofTeachersData.AllowUserToResizeColumns = false;
            this.listofTeachersData.AllowUserToResizeRows = false;
            this.listofTeachersData.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.listofTeachersData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.listofTeachersData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.listofTeachersData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listofTeachersData.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.listofTeachersData.Location = new System.Drawing.Point(33, 76);
            this.listofTeachersData.Name = "listofTeachersData";
            this.listofTeachersData.ReadOnly = true;
            this.listofTeachersData.RowHeadersVisible = false;
            this.listofTeachersData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listofTeachersData.Size = new System.Drawing.Size(400, 281);
            this.listofTeachersData.TabIndex = 10;
            // 
            // ViewTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 415);
            this.Controls.Add(this.teacherLabel);
            this.Controls.Add(this.listofTeachersData);
            this.MaximizeBox = false;
            this.Name = "ViewTeacher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewTeacher";
            this.Load += new System.EventHandler(this.ViewTeacher_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listofTeachersData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label teacherLabel;
        private System.Windows.Forms.DataGridView listofTeachersData;
    }
}