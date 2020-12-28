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
    public partial class AdminTeacher : Form
    {
        public AdminTeacher()
        {
            InitializeComponent();
        }


        private void searchTeacherButton_Click(object sender, EventArgs e)
        {
            if (searchTeacher.Text.Trim() == "")
            {
                MessageBox.Show("Alert!, please input teacher's id");
                return;
            }
            try
            {
                var dt = WebService.web_service().GetTeacherById(Convert.ToInt32(searchTeacher.Text.Trim()));

                DataTable dtt = new DataTable();

                dtt.Columns.Add("Id");
                dtt.Columns.Add("Name");
                dtt.Columns.Add("Surname");
                dtt.Columns.Add("Subject");

                foreach (DataRow row in dt.Rows)
                {
                    var item = dtt.NewRow();

                    item["Id"] = row["id"].ToString();
                    item["Name"] = row["name"].ToString();
                    item["Surname"] = row["surname"].ToString();
                    item["subject"] = row["subject"].ToString();
                    dtt.Rows.Add(item);
                }

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No Data Found");
                    editTeacherPanel.Visible = false;
                    return;
                }
                MessageBox.Show("Data Found");
                panel2.Visible = true;
                searchTeacherButton.Enabled = false;
                adminTeacherData.DataSource = dtt;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void deleteTeacherButton_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure you want to delete this teacher?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                try
                {
                    WebService.web_service().DeleteTeacher(Convert.ToInt32(adminTeacherData.CurrentRow.Cells[0].Value.ToString()));
                    MessageBox.Show("Teacher deleted successfully");
                    panel2.Visible = false;
                    searchTeacherButton.Enabled = true;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void editTeacherButton_Click(object sender, EventArgs e)
        {
            editTeacherFname.Text = adminTeacherData.CurrentRow.Cells[1].Value.ToString();
            editTeacherLname.Text = adminTeacherData.CurrentRow.Cells[2].Value.ToString();
            editTeacherSubject.Text = adminTeacherData.CurrentRow.Cells[3].Value.ToString();
            Teacher.Id = Convert.ToInt32(adminTeacherData.CurrentRow.Cells[0].Value.ToString());
            panel2.Visible = false;
            editTeacherPanel.Visible = true;
        }

        private void closeTeacher_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            searchTeacherButton.Enabled = true;

        }

        private void updateTeacherButton_Click(object sender, EventArgs e)
        {
            if (editTeacherFname.Text.Trim() == ""  || editTeacherLname.Text.Trim() == "")
            {
                MessageBox.Show("Alert!, please complete fields");
                return;
            }

            try
            {
                int result = WebService.web_service().UpdateTeacher(editTeacherFname.Text.Trim(), editTeacherLname.Text.Trim(), editTeacherSubject.Text, Teacher.Id);

                if (result == 100)
                {
                    MessageBox.Show("Teacher already added", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (result == 400)
                {
                    MessageBox.Show("Oooops, there is something wrong", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (result == 200)
                {
                    MessageBox.Show("Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    editTeacherPanel.Visible = false;
                    panel2.Visible = true;
                    adminTeacherData.DataSource = WebService.web_service().GetTeacherById(Teacher.Id);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

        }

        private void closeUpdateButton_Click(object sender, EventArgs e)
        {
            editTeacherPanel.Visible = false;
            panel2.Visible = true;
        }
    }
}
