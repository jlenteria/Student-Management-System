using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Management_System.Model
{
    class DBData
    {

        public static BindingSource Bind
        {
            get;set;
        }
        public static DataTable CourseData
        {
            get; set;
        }
        public static DataTable TeacherData
        {
            get;set;
        }
        public static DataTable LoadCourseData()
        {
            //Course

            var dt = WebService.web_service().GetAllCourse();
            DataTable dtt = new DataTable();

            dtt.Columns.Add("Name");
            foreach (DataRow row in dt.Rows)
            {
                var item = dtt.NewRow();
                item["name"] = row["name"].ToString();
                dtt.Rows.Add(item);
            }
            return dtt;
        }
        public static DataTable LoadTeacherData()
        {
            var dt2 = WebService.web_service().GetAllTeacher();
            var dtt2 = new DataTable();
            dtt2.Columns.Add("Name");
            dtt2.Columns.Add("Surname");

            foreach (DataRow row in dt2.Rows)
            {
                var item = dtt2.NewRow();
                item["name"] = row["Name"].ToString();
                item["surname"] = row["Surname"].ToString();

                dtt2.Rows.Add(item);
            }
            return dtt2;
        }

        public static DataTable LoadStudentCompleted()
        {
            var dtt = WebService.web_service().GetCompletedStudent();
            if (dtt.Rows.Count > 0)
            {
                return dtt;
            }
            else
            {
                return null;
            }
        }

        public static string CheckCompleted(int id)
        {
            int result = WebService.web_service().CheckCompletedStudent(id);
            if (result == 1)
            {
                return "exist";
            }
            else
            {
                return "not exist";
            }
        }
    }
}
