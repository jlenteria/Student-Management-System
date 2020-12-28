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
    public partial class AddCourse : Form
    {
        public AddCourse()
        {
            InitializeComponent();
        }

        private void addCourseButton_Click(object sender, EventArgs e)
        {
            if (courseFees.Text == "" || courseName.Text.Trim() == "" || courseDuration.Text == "")
            {
                MessageBox.Show("Please, complete fields");
                return;
            }
            var course = new Course();
            course.Name = courseName.Text.Trim();
            course.Fees = (int)Convert.ToInt64(courseFees.Text.Trim());
            course.Duration = courseDuration.Text.Trim();

            try
            {
                int result = WebService.web_service().AddCourse(course.Name, course.Duration, course.Fees);
                if (result == 100)
                {
                    MessageBox.Show("Course is already added", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (result == 400)
                {
                    MessageBox.Show("Ooops, there is something wrong!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (result == 200)
                {
                    MessageBox.Show("Course successfully added", "Information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    courseFees.Clear();
                    courseName.Clear();
                    courseDuration.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
