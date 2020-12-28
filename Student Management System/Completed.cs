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
    public partial class Completed : Form
    {
        public Completed()
        {
            InitializeComponent();
        }

        private void Completed_Load(object sender, EventArgs e)
        {
            try
            {

                listofStudentData.DataSource = WebService.web_service().GetCompletedStudent();
                studentLabel.Text = "List of student (" + listofStudentData.Rows.Count + ")";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
             }
        }
    }
}
