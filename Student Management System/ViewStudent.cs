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
    public partial class View_Student : Form
    {
        public View_Student()
        {
            InitializeComponent();
        }

        private void View_Student_Load(object sender, EventArgs e)
        {

            filterTeacher.SelectedIndex = -1;
            filterCourse.SelectedIndex = -1;
            try
            {

                LoadData();
                var dt = DBData.LoadCourseData();
                var dt2 = DBData.LoadTeacherData();
                foreach (DataRow row in dt.Rows)
                {
                    filterCourse.Items.Add(row["name"].ToString());
                }

                foreach (DataRow row in dt2.Rows)
                {
                    filterTeacher.Items.Add(row["name"].ToString() + " " + row["surname"].ToString());
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadData()
        {
            try
            {
                var dt = WebService.web_service().GetAllStudent();
                listofStudentData.DataSource = dt;
                studentLabel.Text = "List of student (" + listofStudentData.Rows.Count + ")";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void filterCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            DBData.Bind = new BindingSource();
            DBData.Bind.DataSource = listofStudentData.DataSource;
            DBData.Bind.Filter = listofStudentData.Columns[6].HeaderText.ToString() + " LIKE '%" + filterCourse.Text.Trim().ToString() + "%'";
            listofStudentData.DataSource = DBData.Bind;
            studentLabel.Text = "List of student (" + listofStudentData.Rows.Count + ")";

        }

        private void filterTeacher_SelectedIndexChanged(object sender, EventArgs e)
        {
            DBData.Bind = new BindingSource();
            DBData.Bind.DataSource = listofStudentData.DataSource;
            DBData.Bind.Filter = listofStudentData.Columns[7].HeaderText.ToString() + " LIKE '%" + filterTeacher.Text.Trim().ToString() + "%'";
            listofStudentData.DataSource = DBData.Bind;
            studentLabel.Text = "List of student (" + listofStudentData.Rows.Count + ")";

        }

        private void sortLastname_TextChanged(object sender, EventArgs e)
        {
            filterTeacher.SelectedIndex = -1;
            filterCourse.SelectedIndex = -1;

            DBData.Bind = new BindingSource();
            DBData.Bind.DataSource = listofStudentData.DataSource;
            DBData.Bind.Filter = listofStudentData.Columns[2].HeaderText.ToString() + " LIKE '%" + sortLastname.Text.Trim().ToLower().ToString() + "%'";
            listofStudentData.DataSource = DBData.Bind;
            studentLabel.Text = "List of student (" + listofStudentData.Rows.Count + ")";
        }

        private void filterCourse_Click(object sender, EventArgs e)
        {
            filterTeacher.SelectedIndex = -1;
        }

        private void filterTeacher_Click(object sender, EventArgs e)
        {
            filterCourse.SelectedIndex = -1;
        }
    }
}
