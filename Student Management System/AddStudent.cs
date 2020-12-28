using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Student_Management_System.Model;

namespace Student_Management_System
{
    public partial class AddStudent : Form
    {
        public AddStudent()
        {
            InitializeComponent();
        }
        private void nextButton_Click(object sender, EventArgs e)
        {
            educationDetails.Enabled = true;
        }
        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            if (studentFirstname.Text.Trim() != "" && studentSurname.Text.Trim() != "" && studentAddress.Text.Trim() != "" && studentPhone.Text.Trim() != "" && studentEmail.Text.Trim() != "")
            {
                nextButton.Enabled = true;
            }
            if (educationDetails.Enabled == true && studentCourse.SelectedIndex != -1 && studentTeacher.SelectedIndex != -1 && collegeName.SelectedIndex != -1 && studentYear.SelectedIndex != -1)
            {
                addStudentButton.Enabled = true;
            }
        }

        private void browsePicture_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog file = new OpenFileDialog() { Filter = "Files|*.jpg;*.jpeg;*.jfif", ValidateNames = true, Multiselect = false })
            {
                if (file.ShowDialog() == DialogResult.OK)
                {
                    studentPicture.Image = Image.FromFile(file.FileName);
                }
            }
        }
        private void AddStudent_Load_1(object sender, EventArgs e)
        {
            try
            {

                var dt = DBData.LoadCourseData();
                var dt2 = DBData.LoadTeacherData();
                foreach (DataRow row in dt.Rows)
                {
                    studentCourse.Items.Add(row["name"].ToString());
                    studentCourse.SelectedIndex = 0;
                }

                foreach (DataRow row in dt2.Rows)
                {
                    studentTeacher.Items.Add(row["name"].ToString() + " " + row["surname"].ToString());
                    studentTeacher.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void studentCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int fee = WebService.web_service().GetFees(studentCourse.Text);
                studentFees.Text = fee.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void addStudentButton_Click(object sender, EventArgs e)
        {
            Student.student[0] = studentFirstname.Text.Trim();
            Student.student[1] = studentSurname.Text.Trim();
            Student.student[2] = studentAddress.Text.Trim();
            Student.student[3] = studentPhone.Text.Trim();
            Student.student[4] = studentEmail.Text.Trim();
            Student.student[5] = studentCourse.Text;
            Student.student[6] = studentTeacher.Text;
            Student.student[7] = studentStart.Text;
            Student.student[8] = studentEnd.Text;
            Student.student[9] = collegeName.Text;
            Student.student[10] = studentFees.Text.Trim();
            Student.student[11] = studentDetails.Text.Trim();
            Student.student[12] = studentYear.Text;
            Student.student[13] = "0";
            Student.student[14] = studentFees.Text.Trim();

            Student.Image =  Student.ConvertImageToBytes(studentPicture.Image);

            try
            {
                int result = WebService.web_service().AddStudent(Student.student, Student.Image);
                if (result == 100)
                {
                    MessageBox.Show("Student is already added", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (result == 400)
                {
                    MessageBox.Show("Ooops, there is something wrong!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (result == 200)
                {
                    MessageBox.Show("Student successfully added", "Information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    studentPicture.Image = null;
                    studentFirstname.Clear();
                    studentSurname.Clear();
                    studentAddress.Clear();
                    studentPhone.Clear();
                    studentEmail.Clear();
                    studentCourse.SelectedIndex = 0;
                    studentTeacher.SelectedIndex = 0;
                    studentStart.Value = DateTime.Now;
                    studentEnd.Value = DateTime.Now;
                    studentCourse.SelectedIndex = 0;
                    studentFees.Clear();
                    studentDetails.Clear();
                    studentYear.SelectedIndex = 0;
                    studentFees.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }

}
