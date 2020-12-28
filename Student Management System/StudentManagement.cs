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
    public partial class StudentManagement : Form
    {
        public StudentManagement()
        {
            InitializeComponent();
        }

        private void addStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var addStudent = new AddStudent();
            addStudent.ShowDialog();
        }

        private void viewStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var viewStudent = new View_Student();
            viewStudent.ShowDialog();
        }

        private void studentFeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var studentfee = new StudentFees();
            studentfee.ShowDialog();
        }

        private void addCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var addcourse = new AddCourse();
            addcourse.ShowDialog();
        }

        private void viewCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var viewcourse = new ViewCourse();
            viewcourse.ShowDialog();
        }

        private void addTeacherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var addteacher = new AddTeacher();
            addteacher.ShowDialog();
        }

        private void viewTeacherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var viewteacher = new ViewTeacher();
            viewteacher.ShowDialog();
        }



        private void courseToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var acourse = new AdminCourse();
            acourse.ShowDialog();
        }

        private void teacherToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var ateacher = new AdminTeacher();
            ateacher.ShowDialog();
        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var auser = new AdminUser();
            auser.ShowDialog();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var astudent = new AdminStudent();
            astudent.ShowDialog();
        }

        private void completedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var com = new Completed();
            com.ShowDialog();
        }

        private void StudentManagement_Load(object sender, EventArgs e)
        {

            if (Auth.Type== "Admin")
            {
                logout.Text = "Logout (Admin Type)";
                administratorToolStripMenuItem.Enabled = true;
            }
            else if(Auth.Type == "User")
            {
                logout.Text = "Logout (User Type)";
                administratorToolStripMenuItem.Enabled = false;
            }

        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var login = new Login();
            login.FormClosed += (o, d) => this.Close();
            Hide();
            login.Show();
        }
    }
}
