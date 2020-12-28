using Student_Management_System.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Management_System
{
    public partial class AddTeacher : Form
    {
        public AddTeacher()
        {
            InitializeComponent();
        }

        private void addTeacherButton_Click(object sender, EventArgs e)
        {
            if (teacherLastname.Text.Trim() == "" || teacherFirstname.Text.Trim() == "" || teacherSubject.Text == "")
            {
                MessageBox.Show("Please, complete fields");
                return;
            }

            var teacher = new Teacher();
            teacher.Name = teacherFirstname.Text.Trim();
            teacher.Surname = teacherLastname.Text.Trim();
            teacher.Subject = teacherSubject.Text;

            try
            {
                int result = WebService.web_service().AddTeacher(teacher.Name,teacher.Surname,teacher.Subject);
                if (result == 100)
                {
                    MessageBox.Show("Teacher is already added", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (result == 400)
                {
                    MessageBox.Show("Ooops, there is something wrong!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (result == 200)
                {
                    MessageBox.Show("Teacher successfully added", "Information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    teacherLastname.Clear();
                    teacherFirstname.Clear();
                    teacherSubject.SelectedIndex = 0;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
