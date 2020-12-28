
namespace Student_Management_System
{
    partial class AddStudent
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
            this.addStudentButton = new System.Windows.Forms.Button();
            this.educationDetails = new System.Windows.Forms.GroupBox();
            this.studentYear = new System.Windows.Forms.ComboBox();
            this.collegeName = new System.Windows.Forms.ComboBox();
            this.label29 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.studentTeacher = new System.Windows.Forms.ComboBox();
            this.studentEnd = new System.Windows.Forms.DateTimePicker();
            this.studentStart = new System.Windows.Forms.DateTimePicker();
            this.studentCourse = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.studentDetails = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.studentFees = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.personalDetails = new System.Windows.Forms.GroupBox();
            this.browsePicture = new System.Windows.Forms.Button();
            this.studentPicture = new System.Windows.Forms.PictureBox();
            this.nextButton = new System.Windows.Forms.Button();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.studentEmail = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.studentAddress = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.studentSurname = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.studentPhone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.studentFirstname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.educationDetails.SuspendLayout();
            this.personalDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // addStudentButton
            // 
            this.addStudentButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addStudentButton.Enabled = false;
            this.addStudentButton.Location = new System.Drawing.Point(514, 349);
            this.addStudentButton.Name = "addStudentButton";
            this.addStudentButton.Size = new System.Drawing.Size(119, 39);
            this.addStudentButton.TabIndex = 17;
            this.addStudentButton.Text = "Add Student";
            this.addStudentButton.UseVisualStyleBackColor = true;
            this.addStudentButton.Click += new System.EventHandler(this.addStudentButton_Click);
            // 
            // educationDetails
            // 
            this.educationDetails.Controls.Add(this.studentYear);
            this.educationDetails.Controls.Add(this.collegeName);
            this.educationDetails.Controls.Add(this.label29);
            this.educationDetails.Controls.Add(this.label27);
            this.educationDetails.Controls.Add(this.label11);
            this.educationDetails.Controls.Add(this.label26);
            this.educationDetails.Controls.Add(this.label25);
            this.educationDetails.Controls.Add(this.label23);
            this.educationDetails.Controls.Add(this.studentTeacher);
            this.educationDetails.Controls.Add(this.studentEnd);
            this.educationDetails.Controls.Add(this.studentStart);
            this.educationDetails.Controls.Add(this.studentCourse);
            this.educationDetails.Controls.Add(this.label16);
            this.educationDetails.Controls.Add(this.label15);
            this.educationDetails.Controls.Add(this.studentDetails);
            this.educationDetails.Controls.Add(this.label9);
            this.educationDetails.Controls.Add(this.label10);
            this.educationDetails.Controls.Add(this.studentFees);
            this.educationDetails.Controls.Add(this.label12);
            this.educationDetails.Controls.Add(this.label13);
            this.educationDetails.Controls.Add(this.label14);
            this.educationDetails.Enabled = false;
            this.educationDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.educationDetails.Location = new System.Drawing.Point(514, 62);
            this.educationDetails.Name = "educationDetails";
            this.educationDetails.Size = new System.Drawing.Size(465, 204);
            this.educationDetails.TabIndex = 16;
            this.educationDetails.TabStop = false;
            this.educationDetails.Text = "Education Details";
            // 
            // studentYear
            // 
            this.studentYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.studentYear.FormattingEnabled = true;
            this.studentYear.Items.AddRange(new object[] {
            "2019",
            "2020",
            "2021",
            "2022",
            "2023"});
            this.studentYear.Location = new System.Drawing.Point(318, 162);
            this.studentYear.Name = "studentYear";
            this.studentYear.Size = new System.Drawing.Size(125, 24);
            this.studentYear.TabIndex = 32;
            this.studentYear.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // collegeName
            // 
            this.collegeName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.collegeName.FormattingEnabled = true;
            this.collegeName.Items.AddRange(new object[] {
            "Engineering",
            "IT",
            "IS",
            "Computer Science",
            "Education",
            "Pyschology",
            "Nurse",
            "MedTech",
            "Criminology",
            "HRM",
            "Tourism"});
            this.collegeName.Location = new System.Drawing.Point(318, 43);
            this.collegeName.Name = "collegeName";
            this.collegeName.Size = new System.Drawing.Size(125, 24);
            this.collegeName.TabIndex = 31;
            this.collegeName.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.ForeColor = System.Drawing.Color.Red;
            this.label29.Location = new System.Drawing.Point(260, 163);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(13, 17);
            this.label29.TabIndex = 29;
            this.label29.Text = "*";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.ForeColor = System.Drawing.Color.Red;
            this.label27.Location = new System.Drawing.Point(-1, 87);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(13, 17);
            this.label27.TabIndex = 27;
            this.label27.Text = "*";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(253, 47);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 17);
            this.label11.TabIndex = 7;
            this.label11.Text = "College:";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.ForeColor = System.Drawing.Color.Red;
            this.label26.Location = new System.Drawing.Point(17, 168);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(13, 17);
            this.label26.TabIndex = 26;
            this.label26.Text = "*";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.ForeColor = System.Drawing.Color.Red;
            this.label25.Location = new System.Drawing.Point(16, 130);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(13, 17);
            this.label25.TabIndex = 25;
            this.label25.Text = "*";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.ForeColor = System.Drawing.Color.Red;
            this.label23.Location = new System.Drawing.Point(6, 47);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(13, 17);
            this.label23.TabIndex = 23;
            this.label23.Text = "*";
            // 
            // studentTeacher
            // 
            this.studentTeacher.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.studentTeacher.FormattingEnabled = true;
            this.studentTeacher.Location = new System.Drawing.Point(80, 83);
            this.studentTeacher.Name = "studentTeacher";
            this.studentTeacher.Size = new System.Drawing.Size(125, 24);
            this.studentTeacher.TabIndex = 21;
            this.studentTeacher.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // studentEnd
            // 
            this.studentEnd.Location = new System.Drawing.Point(79, 163);
            this.studentEnd.Name = "studentEnd";
            this.studentEnd.Size = new System.Drawing.Size(125, 23);
            this.studentEnd.TabIndex = 20;
            // 
            // studentStart
            // 
            this.studentStart.Location = new System.Drawing.Point(80, 125);
            this.studentStart.Name = "studentStart";
            this.studentStart.Size = new System.Drawing.Size(124, 23);
            this.studentStart.TabIndex = 19;
            // 
            // studentCourse
            // 
            this.studentCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.studentCourse.FormattingEnabled = true;
            this.studentCourse.Location = new System.Drawing.Point(79, 43);
            this.studentCourse.Name = "studentCourse";
            this.studentCourse.Size = new System.Drawing.Size(125, 24);
            this.studentCourse.TabIndex = 17;
            this.studentCourse.SelectedIndexChanged += new System.EventHandler(this.studentCourse_SelectedIndexChanged);
            this.studentCourse.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(270, 165);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(42, 17);
            this.label16.TabIndex = 15;
            this.label16.Text = "Year:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(36, 168);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(37, 17);
            this.label15.TabIndex = 13;
            this.label15.Text = "End:";
            // 
            // studentDetails
            // 
            this.studentDetails.Location = new System.Drawing.Point(318, 123);
            this.studentDetails.Name = "studentDetails";
            this.studentDetails.Size = new System.Drawing.Size(125, 23);
            this.studentDetails.TabIndex = 12;
            this.studentDetails.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(247, 125);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 17);
            this.label9.TabIndex = 11;
            this.label9.Text = "Details:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(31, 129);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 17);
            this.label10.TabIndex = 9;
            this.label10.Text = "Start:";
            // 
            // studentFees
            // 
            this.studentFees.Enabled = false;
            this.studentFees.Location = new System.Drawing.Point(318, 84);
            this.studentFees.Name = "studentFees";
            this.studentFees.Size = new System.Drawing.Size(125, 23);
            this.studentFees.TabIndex = 6;
            this.studentFees.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(269, 87);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(43, 17);
            this.label12.TabIndex = 5;
            this.label12.Text = "Fees:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(9, 87);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 17);
            this.label13.TabIndex = 2;
            this.label13.Text = "Teacher:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(16, 47);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(57, 17);
            this.label14.TabIndex = 0;
            this.label14.Text = "Course:";
            // 
            // personalDetails
            // 
            this.personalDetails.Controls.Add(this.browsePicture);
            this.personalDetails.Controls.Add(this.studentPicture);
            this.personalDetails.Controls.Add(this.nextButton);
            this.personalDetails.Controls.Add(this.label22);
            this.personalDetails.Controls.Add(this.label21);
            this.personalDetails.Controls.Add(this.label20);
            this.personalDetails.Controls.Add(this.label19);
            this.personalDetails.Controls.Add(this.label17);
            this.personalDetails.Controls.Add(this.studentEmail);
            this.personalDetails.Controls.Add(this.label8);
            this.personalDetails.Controls.Add(this.studentAddress);
            this.personalDetails.Controls.Add(this.label7);
            this.personalDetails.Controls.Add(this.studentSurname);
            this.personalDetails.Controls.Add(this.label6);
            this.personalDetails.Controls.Add(this.studentPhone);
            this.personalDetails.Controls.Add(this.label5);
            this.personalDetails.Controls.Add(this.studentFirstname);
            this.personalDetails.Controls.Add(this.label3);
            this.personalDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.personalDetails.Location = new System.Drawing.Point(12, 62);
            this.personalDetails.Name = "personalDetails";
            this.personalDetails.Size = new System.Drawing.Size(465, 326);
            this.personalDetails.TabIndex = 15;
            this.personalDetails.TabStop = false;
            this.personalDetails.Text = "Personal Details";
            // 
            // browsePicture
            // 
            this.browsePicture.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browsePicture.Location = new System.Drawing.Point(19, 277);
            this.browsePicture.Name = "browsePicture";
            this.browsePicture.Size = new System.Drawing.Size(61, 23);
            this.browsePicture.TabIndex = 19;
            this.browsePicture.Text = "Browse";
            this.browsePicture.UseVisualStyleBackColor = true;
            this.browsePicture.Click += new System.EventHandler(this.browsePicture_Click);
            // 
            // studentPicture
            // 
            this.studentPicture.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.studentPicture.Image = global::Student_Management_System.Properties.Resources.user_icon_image_placeholder;
            this.studentPicture.Location = new System.Drawing.Point(87, 184);
            this.studentPicture.Name = "studentPicture";
            this.studentPicture.Size = new System.Drawing.Size(139, 116);
            this.studentPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.studentPicture.TabIndex = 18;
            this.studentPicture.TabStop = false;
            // 
            // nextButton
            // 
            this.nextButton.Enabled = false;
            this.nextButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextButton.Location = new System.Drawing.Point(368, 287);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(75, 30);
            this.nextButton.TabIndex = 17;
            this.nextButton.Text = "Next";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.ForeColor = System.Drawing.Color.Red;
            this.label22.Location = new System.Drawing.Point(256, 88);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(13, 17);
            this.label22.TabIndex = 16;
            this.label22.Text = "*";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.ForeColor = System.Drawing.Color.Red;
            this.label21.Location = new System.Drawing.Point(6, 130);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(13, 17);
            this.label21.TabIndex = 15;
            this.label21.Text = "*";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.ForeColor = System.Drawing.Color.Red;
            this.label20.Location = new System.Drawing.Point(6, 87);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(13, 17);
            this.label20.TabIndex = 15;
            this.label20.Text = "*";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.ForeColor = System.Drawing.Color.Red;
            this.label19.Location = new System.Drawing.Point(228, 50);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(13, 17);
            this.label19.TabIndex = 15;
            this.label19.Text = "*";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.Color.Red;
            this.label17.Location = new System.Drawing.Point(16, 50);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(13, 17);
            this.label17.TabIndex = 13;
            this.label17.Text = "*";
            // 
            // studentEmail
            // 
            this.studentEmail.Location = new System.Drawing.Point(318, 86);
            this.studentEmail.MaxLength = 11;
            this.studentEmail.Name = "studentEmail";
            this.studentEmail.Size = new System.Drawing.Size(125, 23);
            this.studentEmail.TabIndex = 12;
            this.studentEmail.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(266, 89);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 17);
            this.label8.TabIndex = 11;
            this.label8.Text = "Email:";
            // 
            // studentAddress
            // 
            this.studentAddress.Location = new System.Drawing.Point(87, 126);
            this.studentAddress.Name = "studentAddress";
            this.studentAddress.Size = new System.Drawing.Size(125, 23);
            this.studentAddress.TabIndex = 10;
            this.studentAddress.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 129);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 17);
            this.label7.TabIndex = 9;
            this.label7.Text = "Address:";
            // 
            // studentSurname
            // 
            this.studentSurname.Location = new System.Drawing.Point(87, 84);
            this.studentSurname.Name = "studentSurname";
            this.studentSurname.Size = new System.Drawing.Size(125, 23);
            this.studentSurname.TabIndex = 8;
            this.studentSurname.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "Surname:";
            // 
            // studentPhone
            // 
            this.studentPhone.Location = new System.Drawing.Point(318, 47);
            this.studentPhone.MaxLength = 11;
            this.studentPhone.Name = "studentPhone";
            this.studentPhone.Size = new System.Drawing.Size(125, 23);
            this.studentPhone.TabIndex = 6;
            this.studentPhone.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(237, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Phone No:";
            // 
            // studentFirstname
            // 
            this.studentFirstname.Location = new System.Drawing.Point(87, 44);
            this.studentFirstname.Name = "studentFirstname";
            this.studentFirstname.Size = new System.Drawing.Size(125, 23);
            this.studentFirstname.TabIndex = 1;
            this.studentFirstname.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Name:";
            // 
            // AddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 450);
            this.Controls.Add(this.addStudentButton);
            this.Controls.Add(this.educationDetails);
            this.Controls.Add(this.personalDetails);
            this.MaximizeBox = false;
            this.Name = "AddStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddStudent";
            this.Load += new System.EventHandler(this.AddStudent_Load_1);
            this.educationDetails.ResumeLayout(false);
            this.educationDetails.PerformLayout();
            this.personalDetails.ResumeLayout(false);
            this.personalDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addStudentButton;
        private System.Windows.Forms.GroupBox educationDetails;
        private System.Windows.Forms.ComboBox studentYear;
        private System.Windows.Forms.ComboBox collegeName;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.ComboBox studentTeacher;
        private System.Windows.Forms.DateTimePicker studentEnd;
        private System.Windows.Forms.DateTimePicker studentStart;
        private System.Windows.Forms.ComboBox studentCourse;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox studentDetails;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox studentFees;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox personalDetails;
        private System.Windows.Forms.Button browsePicture;
        private System.Windows.Forms.PictureBox studentPicture;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox studentEmail;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox studentAddress;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox studentSurname;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox studentPhone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox studentFirstname;
        private System.Windows.Forms.Label label3;
    }
}