using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Student_Management_System.Model;

namespace Student_Management_System
{
    public partial class AdminStudent : Form
    {
        public AdminStudent()
        {
            InitializeComponent();
        }
        private void searchStudentButton_Click(object sender, EventArgs e)
        {
            if (searchStudent.Text == "")
            {
                MessageBox.Show("Alert!, please input student Id");
                return;
            }
            try
            {
                var dt = WebService.web_service().GetStudentById(Convert.ToInt32(searchStudent.Text.Trim()));
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No data found");
                    panel1.Visible = false;

                }
                else
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        Student.Id = (int)Convert.ToInt64(row["Id"].ToString());
                    }

                    MessageBox.Show("Data found");
                    adminStudentData.DataSource = dt;
                    panel1.Visible = true;

                    var str = DBData.CheckCompleted(Student.Id);
                    if (str == "exist")
                    {
                        studentCompletedButton.Visible = false;
                        removeCompleted.Visible = true;
                    }
                    else
                    {
                        studentCompletedButton.Visible = true;
                        removeCompleted.Visible = false;
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void deleteStudentButton_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult res = MessageBox.Show("Are you sure you want to delete this student?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    WebService.web_service().DeleteStudent(Student.Id);
                    MessageBox.Show("Student Successfully deleted");
                    panel1.Visible = false;

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void studentCompletedButton_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure this student is already completed the course?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                try
                {
                    var dt = WebService.web_service().GetStudentById(Student.Id);
                    foreach (DataRow row in dt.Rows)
                    {
                        Student.student[0] = row["Name"].ToString();
                        Student.student[1] = row["Surname"].ToString();
                        Student.student[2] = row["Address"].ToString();
                        Student.student[3] = row["Phone"].ToString();
                        Student.student[4] = row["Email"].ToString();
                        Student.student[5] = row["Course"].ToString();
                        Student.student[6] = row["Teacher"].ToString();
                        Student.student[7] = row["Startdate"].ToString();
                        Student.student[8] = row["Enddate"].ToString();
                        Student.student[9] = row["College"].ToString();
                        Student.student[10] = row["Fees"].ToString();
                        Student.student[11] = row["Details"].ToString();
                        Student.student[12] = row["Year"].ToString();
                        Student.student[13] = row["Paid"].ToString();
                        Student.student[14] = row["Balance"].ToString();
                        Student.student[15] = row["Id"].ToString();
                        Student.Image = (byte[])row["Image"];
                    }
                    WebService.web_service().AddCompletedStudent(Student.student, Student.Image);
                    MessageBox.Show("Student Successfully completed the course (" + Student.student[5] + ")");
                    studentCompletedButton.Visible = false;
                    removeCompleted.Visible = true;


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void removeCompleted_Click(object sender, EventArgs e)
        {
            try
            {
                WebService.web_service().RemoveCompleted(Student.Id);
                MessageBox.Show("Student remove successfully from completed course");
                studentCompletedButton.Visible = true;
                removeCompleted.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void closeStudentButton_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;

        }
    }
}
