using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Student_Management_System.Model;

namespace Student_Management_System
{
    public partial class StudentFees : Form
    {
        int totalFees, paid, balance, amount;
        public StudentFees()
        {
            InitializeComponent();
        }

        private void searchStudent1Button_Click(object sender, EventArgs e)
        {
            if (searchStudent1.Text == "")
            {
                MessageBox.Show("Alert!, please input student Id");
                return;
            }
            try
            {
                var dt = WebService.web_service().GetStudentById(Convert.ToInt32(searchStudent1.Text.Trim()));
                var dtt = DBData.LoadCourseData();
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No data found");
                    studentFeeDetails.Visible = false;

                }
                else
                {
                    MessageBox.Show("Data found!");
                    studentFeeDetails.Visible = true;

                    foreach (DataRow row in dtt.Rows)
                    {
                        studentCourse_.Items.Add(row["Name"].ToString());
                    }

                    foreach (DataRow row in dt.Rows)
                    {
                        Student.Id = Convert.ToInt32(row["Id"].ToString());
                        studentFirstName_.Text = row["Name"].ToString();
                        studentLastname_.Text = row["Surname"].ToString();
                        studentEmail_.Text = row["Email"].ToString();

                        byte[] imageArray = (byte[])row["Image"];
                        if (imageArray.Length == 0)
                        {
                            studentPicture.Image = null;
                        }
                        else
                        {
                            studentPicture.Image = Image.FromStream(new MemoryStream(imageArray));
                            
                        }

                        studentFees_.Text = row["Fees"].ToString();
                        studentPaid_.Text = row["Paid"].ToString();
                        studentPhone_.Text = row["Phone"].ToString();
                        studentCourse_.Text = row["Course"].ToString();
                        studentCollege_.Text = row["College"].ToString();
                        studentBalance_.Text = row["Balance"].ToString();
                    }

                    totalFees = (int)Convert.ToInt64(studentFees_.Text);
                    paid = (int)Convert.ToInt64(studentPaid_.Text);
                    balance = (int)Convert.ToInt64(studentBalance_.Text);

                    if (paid == totalFees)
                    {
                        studentPay_.Enabled = false;
                        studentAddPay_.Enabled = false;
                        studentPay_.Text = "Paid";
                    }
                    else
                    {
                        studentPay_.Enabled = true;
                        studentAddPay_.Enabled = true;
                    }

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void studentAddPay__Click(object sender, EventArgs e)
        {

            if (studentPay_.Text.Trim() == "")
            {
                MessageBox.Show("Please input valid amount");
            }
            else
            {
                amount = (int)Convert.ToInt64(studentPay_.Text.Trim());
                if (amount < 0)
                {
                    MessageBox.Show("Please input valid amount");
                    return;
                }
                if (amount > balance)
                {
                    MessageBox.Show("Amount should less than or equal to (" + balance + ")");
                    return;
                }
                balance = balance - amount;
                paid += amount;
                UpdateStudent();
            }

        }

        private void studentEdit__Click(object sender, EventArgs e)
        {
            panel1.Enabled = true;
            studentAddPay_.Enabled = false;
            studentPay_.Enabled = false;
            browsePicture.Enabled = true;
            okUpdateButton.Visible = true;
            studentEdit_.Visible = false;

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            studentFeeDetails.Visible = false;
            studentEdit_.Visible = true;
            okUpdateButton.Visible = false;
            browsePicture.Enabled = false;
        }
        private void okUpdateButton_Click(object sender, EventArgs e)
        {
            studentEdit_.Visible = true;
            okUpdateButton.Visible = false;
            browsePicture.Enabled = false;
            UpdateStudent();
        }

        private void browsePicture_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog file = new OpenFileDialog() {Filter="Files|*.jpg;*.jpeg;*.jfif", ValidateNames=true, Multiselect=false})
            {
                if (file.ShowDialog() == DialogResult.OK)
                {
                    studentPicture.Image = new Bitmap(file.FileName);
                }
            }
        }

        private void UpdateStudent()
        {

            Student.student[0] = studentFirstName_.Text.Trim();
            Student.student[1] = studentLastname_.Text.Trim();
            Student.student[2] = studentPhone_.Text.Trim();
            Student.student[3] = studentEmail_.Text.Trim();
            Student.student[4] = studentCourse_.Text;
            Student.student[5] = studentCollege_.Text;
            Student.student[6] = studentFees_.Text;
            Student.student[7] = Convert.ToString(paid);
            Student.student[8] = Convert.ToString(balance);
            Student.Image = ConvertImageToBytes(studentPicture.Image);
            try
            {
                int result = WebService.web_service().UpdateStudent(Student.student, Student.Image, Student.Id);
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
                    MessageBox.Show("Student successfully updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    studentFeeDetails.Visible = false;
                    panel1.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        public static Byte[] ConvertImageToBytes(Image img)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Bmp);
                return ms.ToArray();
            }
        }
    }
}
