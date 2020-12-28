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
    public partial class ViewCourse : Form
    {
        public ViewCourse()
        {
            InitializeComponent();
        }

        private void ViewCourse_Load(object sender, EventArgs e)
        {
            try
            {
                var dtt = WebService.web_service().GetAllCourse();
                DataTable dt = new DataTable();
                dt.Columns.Add("Id");
                dt.Columns.Add("Name");
                dt.Columns.Add("Fees");
                dt.Columns.Add("Duration");

                foreach (DataRow row in dtt.Rows)
                {
                    var item = dt.NewRow();
                    item["Id"] = row["Id"].ToString();
                    item["Name"] = row["Name"].ToString();
                    item["Fees"] = row["Fees"].ToString();
                    item["Duration"] = row["Duration"].ToString();
                    dt.Rows.Add(item);
                }
                listofCourseData.DataSource = dt;
                courseLabel.Text = "List of courses ( " + listofCourseData.Rows.Count + " )";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
