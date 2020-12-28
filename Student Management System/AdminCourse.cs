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
    public partial class AdminCourse : Form
    {
        public AdminCourse()
        {
            InitializeComponent();
        }

        private void searchCourseButton_Click(object sender, EventArgs e)
        {
            if (searchCourse.Text.Trim() == "")
            {
                MessageBox.Show("Alert!, please input course");
                return;
            }
            try
            {
                var dt = WebService.web_service().GetCourseByName(searchCourse.Text.Trim());
                DataTable dtt = new DataTable();

                dtt.Columns.Add("Id");
                dtt.Columns.Add("Name");
                dtt.Columns.Add("Fees");
                dtt.Columns.Add("Duration");

                foreach (DataRow row in dt.Rows)
                {
                    var item = dtt.NewRow();

                    item["Id"] = row["id"].ToString();
                    item["Name"] = row["name"].ToString();
                    item["Fees"] = row["fees"].ToString();
                    item["Duration"] = row["duration"].ToString();

                    dtt.Rows.Add(item);

                }
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No Data Found", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    panel3.Visible = false;
                    return;

                }
                else
                {
                    MessageBox.Show("Data Found", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    adminCourseData.DataSource = dtt;
                    searchCourseButton.Enabled = false;
                    panel3.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void deleteCourse_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult res = MessageBox.Show("Are you sure you want to delete this course ? ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    WebService.web_service().DeleteCourse(adminCourseData.CurrentRow.Cells[1].Value.ToString());
                    MessageBox.Show("Course successfully deleted");
                    searchCourseButton.Enabled = true;
                    panel3.Visible = false;
                    searchCourse.Clear();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void editCourseButton_Click(object sender, EventArgs e)
        {
            editCourseGroup.Visible = true;
            editCourseName.Text = adminCourseData.CurrentRow.Cells[1].Value.ToString();
            editCourseFees.Text = adminCourseData.CurrentRow.Cells[2].Value.ToString();
            editCourseDuration.Text = adminCourseData.CurrentRow.Cells[3].Value.ToString();
            Course.Id = Convert.ToInt32(adminCourseData.CurrentRow.Cells[0].Value.ToString());

        }

        private void closeCourse_Click(object sender, EventArgs e)
        {
            searchCourseButton.Enabled = true;
            panel3.Visible = false;
            searchCourse.Clear();

        }

        private void updateCourseButton_Click(object sender, EventArgs e)
        {
            if (editCourseName.Text.Trim() == "" || editCourseFees.Text.Trim() == "")
            {
                MessageBox.Show("Alert!, please complete fields");
                return;
            }
            try
            {
                int result = WebService.web_service().UpdateCourse(editCourseName.Text.Trim(), editCourseDuration.Text.Trim(), (int)Convert.ToInt64(editCourseFees.Text.Trim()), Course.Id);
                if (result == 100)
                {
                    MessageBox.Show("Course already added", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (result == 400)
                {
                    MessageBox.Show("Oooops, there is something wrong", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (result == 200)
                {
                    MessageBox.Show("Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    editCourseGroup.Visible = false;
                    panel3.Visible = true;
                    adminCourseData.DataSource = WebService.web_service().GetCourseByName(editCourseName.Text.Trim());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void editCourseCancelButton_Click(object sender, EventArgs e)
        {
            editCourseGroup.Visible = false;
        }
    }
}
