
namespace Student_Management_System
{
    partial class Completed
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.listofStudentData = new System.Windows.Forms.DataGridView();
            this.studentLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.listofStudentData)).BeginInit();
            this.SuspendLayout();
            // 
            // listofStudentData
            // 
            this.listofStudentData.AllowUserToAddRows = false;
            this.listofStudentData.AllowUserToDeleteRows = false;
            this.listofStudentData.AllowUserToResizeColumns = false;
            this.listofStudentData.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.listofStudentData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.listofStudentData.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.listofStudentData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.listofStudentData.CausesValidation = false;
            this.listofStudentData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listofStudentData.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.listofStudentData.Location = new System.Drawing.Point(51, 96);
            this.listofStudentData.MultiSelect = false;
            this.listofStudentData.Name = "listofStudentData";
            this.listofStudentData.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.listofStudentData.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
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
            this.listofStudentData.TabIndex = 21;
            // 
            // studentLabel
            // 
            this.studentLabel.AutoSize = true;
            this.studentLabel.Location = new System.Drawing.Point(48, 73);
            this.studentLabel.Name = "studentLabel";
            this.studentLabel.Size = new System.Drawing.Size(73, 13);
            this.studentLabel.TabIndex = 20;
            this.studentLabel.Text = "List of Data(0)";
            // 
            // Completed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 450);
            this.Controls.Add(this.listofStudentData);
            this.Controls.Add(this.studentLabel);
            this.Name = "Completed";
            this.Text = "Completed";
            this.Load += new System.EventHandler(this.Completed_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listofStudentData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView listofStudentData;
        private System.Windows.Forms.Label studentLabel;
    }
}