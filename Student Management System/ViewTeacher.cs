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
    public partial class ViewTeacher : Form
    {
        public ViewTeacher()
        {
            InitializeComponent();
        }

        private void ViewTeacher_Load(object sender, EventArgs e)
        {
            try
            {
                var dtt = WebService.web_service().GetAllTeacher();
                DataTable dt = new DataTable();

                dt.Columns.Add("Id");
                dt.Columns.Add("Name");
                dt.Columns.Add("Surname");
                dt.Columns.Add("Subject");

                foreach (DataRow row in dtt.Rows)
                {
                    var item = dt.NewRow();
                    item["id"] = row["Id"].ToString();
                    item["name"] = row["Name"].ToString();
                    item["surname"] = row["Surname"].ToString();
                    item["subject"] = row["Subject"].ToString();

                    dt.Rows.Add(item);
                }

                listofTeachersData.DataSource = dt;
                teacherLabel.Text = "List of courses ( " + listofTeachersData.Rows.Count + " )";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
