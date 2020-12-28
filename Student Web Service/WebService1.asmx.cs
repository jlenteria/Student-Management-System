using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using Student_Web_Service.Models;

namespace Student_Web_Service
{

    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]

    [Obsolete]
    public class WebService1 : WebService
    {

        //Course
        //Getall
        [WebMethod]
        public DataTable GetAllCourse()
        {
            using (SqlConnection con = new SqlConnection(DBConnection.StudentDB()))
            {
                using (SqlCommand cmd = new SqlCommand("SP_GetAllCourse", con))
                {
                    con.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.ExecuteNonQuery();
                    con.Close();

                    DataTable dt = new DataTable();
                    SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                    dt.TableName = "All Course";
                    adapt.Fill(dt);

                    return dt;
                }
            }
            
        }

        //Add
        [WebMethod]
        public int AddCourse(string name,string duration,int fee)
        {
            using (SqlConnection con = new SqlConnection(DBConnection.StudentDB()))
            {
                using (SqlCommand cmd = new SqlCommand("SP_AddCourse", con))
                {
                    con.Open();
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.Parameters.AddWithValue("@Duration", duration);
                    cmd.Parameters.AddWithValue("@Fees", fee);

                    var output = cmd.Parameters.Add("@Ret", SqlDbType.Int);
                    output.Direction = ParameterDirection.Output;
                    cmd.ExecuteNonQuery();
                        
                    return Convert.ToInt32(output.Value.ToString());
                }
            }
        }

        //GetbyId
        [WebMethod]
        public DataTable GetCourseByName(string name)
        {
            using (SqlConnection con = new SqlConnection(DBConnection.StudentDB()))
            {
                using (SqlCommand cmd = new SqlCommand("SP_GetCourseByName", con))
                {
                    con.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.ExecuteNonQuery();

                    DataTable dt = new DataTable();
                    SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                    dt.TableName = "Course By Id";
                    adapt.Fill(dt);

                    return dt;
                }
            }
        }

        //Update
        [WebMethod]
        public int UpdateCourse(string name,string duration, int fee, int id)
        {
            using (SqlConnection con = new SqlConnection(DBConnection.StudentDB()))
            {
                using (SqlCommand cmd = new SqlCommand("SP_EditCourse", con))
                {
                    con.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.Parameters.AddWithValue("@Duration", duration);
                    cmd.Parameters.AddWithValue("@Fees", fee);
                    cmd.Parameters.AddWithValue("@Id", id);
                    var output = cmd.Parameters.Add("@Ret", SqlDbType.Int);
                    output.Direction = ParameterDirection.Output;
                    cmd.ExecuteNonQuery();

                    return Convert.ToInt32(output.Value.ToString());
                }
            }
        }

        //Delete
        [WebMethod]
        public void DeleteCourse(string name)
        {
            using (SqlConnection con = new SqlConnection(DBConnection.StudentDB()))
            {
                using (SqlCommand cmd = new SqlCommand("SP_DeleteCourse", con))
                {
                    con.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.ExecuteNonQuery();
                }
            }
        }


        //Teacher
        [WebMethod]
        public DataTable GetAllTeacher()
        {
            using (SqlConnection con = new SqlConnection(DBConnection.StudentDB()))
            {
                using (SqlCommand cmd = new SqlCommand("SP_GetAllTeacher", con))
                {

                    con.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.ExecuteNonQuery();
                    con.Close();

                    DataTable dt = new DataTable();
                    SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                    dt.TableName = "Teachers Table";
                    adapt.Fill(dt);

                    return dt;
                }
            }
        }

        //Add Teacher
        [WebMethod]
        public int AddTeacher(string name, string surname, string subject)
        {
            using (SqlConnection con = new SqlConnection(DBConnection.StudentDB()))
            {
                using (SqlCommand cmd = new SqlCommand("SP_AddTeacher", con))
                {
                    try
                    {
                        con.Open();
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@Name",name);
                        cmd.Parameters.AddWithValue("@Surname", surname);
                        cmd.Parameters.AddWithValue("@Subject", subject);

                        var output = cmd.Parameters.Add("@Ret", SqlDbType.Int);
                        output.Direction = ParameterDirection.Output;
                        cmd.ExecuteNonQuery();

                        return Convert.ToInt32(output.Value.ToString());

                    }
                    catch (Exception err)
                    {
                        con.Close();
                        return 400;
                    }
                }
            }
        }

        //GetTeacherById
        [WebMethod]
        public DataTable GetTeacherById(int id)
        {
            using (SqlConnection con = new SqlConnection(DBConnection.StudentDB()))
            {
                using (SqlCommand cmd = new SqlCommand("SP_GetTeacherById", con))
                {
                    con.Open();
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.ExecuteNonQuery();

                    DataTable dt = new DataTable();
                    SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                    dt.TableName = "Teacher by Id Table";
                    adapt.Fill(dt);

                    return dt;
                }
            }
        }

        //updateTeacher
        [WebMethod]
        public int UpdateTeacher(string name,string surname, string subject,int id)
        {
            using (SqlConnection con = new SqlConnection(DBConnection.StudentDB()))
            {
                using (SqlCommand cmd = new SqlCommand("SP_EditTeacher", con))
                {
                    con.Open();
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.Parameters.AddWithValue("@Surname", surname);
                    cmd.Parameters.AddWithValue("@Subject", subject);

                    var output = cmd.Parameters.Add("@Ret", SqlDbType.Int);
                    output.Direction = ParameterDirection.Output;
                    cmd.ExecuteNonQuery();

                    return Convert.ToInt32(output.Value.ToString());
                }
            }
        }

        //Delete Teacher
        [WebMethod]
        public void DeleteTeacher(int id)
        {
            using (SqlConnection con = new SqlConnection(DBConnection.StudentDB()))
            {
                using (SqlCommand cmd = new SqlCommand("SP_DeleteTeacher", con))
                {       
                    con.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        [WebMethod]
        public int GetFees(string name)
        {
            using (SqlConnection con = new SqlConnection(DBConnection.StudentDB()))
            {
                using (SqlCommand cmd = new SqlCommand("Select Fees from Course where name = '" + name + "'", con))
                {
                    con.Open();
                    cmd.CommandType = CommandType.Text;

                    DataTable dt = new DataTable();
                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        return Convert.ToInt32(dr["fees"].ToString());
                    }
                    else
                    {
                        return 0;
                    }

                }
            }
        }

        //student
        [WebMethod]
        public int AddStudent(string[] inputs, byte[] image)
        {
            using (SqlConnection con = new SqlConnection(DBConnection.StudentDB()))
            {
                using (SqlCommand cmd = new SqlCommand("SP_AddStudent", con))
                {
                    con.Open();
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@Name", inputs[0]);
                    cmd.Parameters.AddWithValue("@Surname", inputs[1]);
                    cmd.Parameters.AddWithValue("@Address", inputs[2]);
                    cmd.Parameters.AddWithValue("@Phone", inputs[3]);
                    cmd.Parameters.AddWithValue("@Email", inputs[4]);
                    cmd.Parameters.AddWithValue("@Course", inputs[5]);
                    cmd.Parameters.AddWithValue("@Teacher", inputs[6]);
                    cmd.Parameters.AddWithValue("@Startdate", inputs[7]);
                    cmd.Parameters.AddWithValue("@Enddate", inputs[8]);
                    cmd.Parameters.AddWithValue("@College", inputs[9]);
                    cmd.Parameters.AddWithValue("@Fees", Convert.ToInt64(inputs[10]));
                    cmd.Parameters.AddWithValue("@Details", inputs[11]);
                    cmd.Parameters.AddWithValue("@Year", inputs[12]);
                    cmd.Parameters.AddWithValue("@Paid", Convert.ToInt64(inputs[13]));
                    cmd.Parameters.AddWithValue("@Balance", Convert.ToInt64(inputs[14]));
                    cmd.Parameters.AddWithValue("@Image", image);


                    var output = cmd.Parameters.Add("@Ret", SqlDbType.Int);
                    output.Direction = ParameterDirection.Output;
                    cmd.ExecuteNonQuery();
                    con.Close();
                    return Convert.ToInt32(output.Value.ToString());
                }
            }
        }

        [WebMethod]
        public DataTable GetAllStudent()
        {
            using (SqlConnection con = new SqlConnection(DBConnection.StudentDB()))
            {
                using (SqlCommand cmd = new SqlCommand("SP_GetAllStudent", con))
                {
                    con.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.ExecuteNonQuery();
                    con.Close();

                    DataTable dt = new DataTable();
                    SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                    dt.TableName = "All Student";
                    adapt.Fill(dt);

                    return dt;
                }
            }
        }
        [WebMethod]
        public DataTable GetStudentById(int id)
        {
            using (SqlConnection con = new SqlConnection(DBConnection.StudentDB()))
            {
                using (SqlCommand cmd = new SqlCommand("SP_GetStudentById", con))
                {
                    con.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.ExecuteNonQuery();
                    con.Close();

                    DataTable dt = new DataTable();
                    SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                    dt.TableName = "Student";
                    adapt.Fill(dt);

                    return dt;
                }
            }
        }
        [WebMethod]
        public void DeleteStudent(int id)
        {
            using (SqlConnection con = new SqlConnection(DBConnection.StudentDB()))
            {
                using (SqlCommand cmd = new SqlCommand("SP_DeleteStudent", con))
                {
                    con.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
        }
        [WebMethod]
        public int UpdateStudent(string[] inputs, byte[] image, int id)
        {
            using (SqlConnection con = new SqlConnection(DBConnection.StudentDB()))
            {
                using (SqlCommand cmd = new SqlCommand("SP_EditStudent", con))
                {
                    con.Open();
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@Name", inputs[0]);
                    cmd.Parameters.AddWithValue("@Surname", inputs[1]);
                    cmd.Parameters.AddWithValue("@Phone", inputs[2]);
                    cmd.Parameters.AddWithValue("@Email", inputs[3]);
                    cmd.Parameters.AddWithValue("@Course", inputs[4]);
                    cmd.Parameters.AddWithValue("@College", inputs[5]);
                    cmd.Parameters.AddWithValue("@Fees", Convert.ToInt64(inputs[6]));
                    cmd.Parameters.AddWithValue("@Paid", Convert.ToInt64(inputs[7]));
                    cmd.Parameters.AddWithValue("@Balance", Convert.ToInt64(inputs[8]));
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.Parameters.AddWithValue("@Image", image);

                    var output = cmd.Parameters.Add("@Ret", SqlDbType.Int);
                    output.Direction = ParameterDirection.Output;
                    cmd.ExecuteNonQuery();
                    con.Close();

                    return Convert.ToInt32(output.Value.ToString());
                }
            }
        }

        [WebMethod]
        public void AddCompletedStudent(string[] inputs,byte[] image)
        {
            using (SqlConnection con = new SqlConnection(DBConnection.StudentDB()))
            {
                using (SqlCommand cmd = new SqlCommand("SP_AddCompletedStudent", con))
                {
                    con.Open();
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@Name", inputs[0]);
                    cmd.Parameters.AddWithValue("@Surname", inputs[1]);
                    cmd.Parameters.AddWithValue("@Address", inputs[2]);
                    cmd.Parameters.AddWithValue("@Phone", inputs[3]);
                    cmd.Parameters.AddWithValue("@Email", inputs[4]);
                    cmd.Parameters.AddWithValue("@Course", inputs[5]);
                    cmd.Parameters.AddWithValue("@Teacher", inputs[6]);
                    cmd.Parameters.AddWithValue("@Startdate", inputs[7]);
                    cmd.Parameters.AddWithValue("@Enddate", inputs[8]);
                    cmd.Parameters.AddWithValue("@College", inputs[9]);
                    cmd.Parameters.AddWithValue("@Fees", Convert.ToInt64(inputs[10]));
                    cmd.Parameters.AddWithValue("@Details", inputs[11]);
                    cmd.Parameters.AddWithValue("@Year", inputs[12]);
                    cmd.Parameters.AddWithValue("@Paid", Convert.ToInt64(inputs[13]));
                    cmd.Parameters.AddWithValue("@Balance", Convert.ToInt64(inputs[14]));
                    cmd.Parameters.AddWithValue("@Id", Convert.ToInt64(inputs[15]));
                    cmd.Parameters.AddWithValue("@Image", image);

                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
        }

        [WebMethod]
        public DataTable GetCompletedStudent()
        {
            using (SqlConnection con = new SqlConnection(DBConnection.StudentDB()))
            {
                using (SqlCommand cmd = new SqlCommand("Select * from CompleteStudents", con))
                {
                    con.Open();
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();

                    con.Close();
                    DataTable dt = new DataTable();
                    SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                    dt.TableName = "completed student";
                    adapt.Fill(dt);
                    return dt;
                }
            }
        }
        [WebMethod]
        public int CheckCompletedStudent(int id)
        {
            using (SqlConnection con = new SqlConnection(DBConnection.StudentDB()))
            {
                using (SqlCommand cmd = new SqlCommand("Select * from CompleteStudents where id='" + id + "'", con))
                {
                    con.Open();
                    cmd.CommandType = CommandType.Text;
                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.HasRows)
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                    con.Close();
                }
            }
        }
        [WebMethod]
        public void RemoveCompleted(int id)
        {
            using (SqlConnection con = new SqlConnection(DBConnection.StudentDB()))
            {
                using (SqlCommand cmd = new SqlCommand("Delete CompleteStudents where id='" + id + "'", con))
                {
                    con.Open();
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
        }

        //user
        [WebMethod]
        public int AddUser(string[] inputs)
        {
            using (SqlConnection con = new SqlConnection(DBConnection.StudentDB()))
            {
                using (SqlCommand cmd = new SqlCommand("SP_AddAuth", con))
                {
                    con.Open();
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@Username", inputs[0]);
                    cmd.Parameters.AddWithValue("@Password", inputs[1]);
                    cmd.Parameters.AddWithValue("@Type", inputs[2]);

                    var output = cmd.Parameters.AddWithValue("@Ret", SqlDbType.Int);
                    output.Direction = ParameterDirection.Output;
                    cmd.ExecuteNonQuery();
                    con.Close();
                    return Convert.ToInt32(output.Value.ToString());
                }
            }
        }
        [WebMethod]
        public int EditAuth(string[] inputs, int id)
        {
            using (SqlConnection con = new SqlConnection(DBConnection.StudentDB()))
            {
                using (SqlCommand cmd = new SqlCommand("SP_EditAuth", con))
                {
                    con.Open();
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@Username", inputs[0]);
                    cmd.Parameters.AddWithValue("@Password", inputs[1]);
                    cmd.Parameters.AddWithValue("@Type", inputs[2]);
                    cmd.Parameters.AddWithValue("@Id", id);


                    var output = cmd.Parameters.AddWithValue("@Ret", SqlDbType.Int);
                    output.Direction = ParameterDirection.Output;
                    cmd.ExecuteNonQuery();
                    con.Close();
                    return Convert.ToInt32(output.Value.ToString());
                }
            }
        }
        [WebMethod]
        public DataTable GetAuthByUsername(string uname)
        {
            using (SqlConnection con = new SqlConnection(DBConnection.StudentDB()))
            {
                using (SqlCommand cmd = new SqlCommand("SP_GetAuthByUname", con))
                {
                    con.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Username", uname);
                    cmd.ExecuteNonQuery();
                    con.Close();

                    DataTable dt = new DataTable();
                    SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                    dt.TableName = "auth";
                    adapt.Fill(dt);

                    return dt;
                    
                }
            }
        }
        [WebMethod]
        public void DeleteAuth(int id)
        {
            using (SqlConnection con = new SqlConnection(DBConnection.StudentDB()))
            {
                using (SqlCommand cmd = new SqlCommand("Delete Auth where id='" + id + "'", con))
                {
                    con.Open();
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
        }

        [WebMethod]
        public int Login(string uname, string pass)
        {
            using (SqlConnection con = new SqlConnection(DBConnection.StudentDB()))
            {
                using (SqlCommand cmd = new SqlCommand("SP_Login", con))
                {
                    con.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Username", uname);
                    cmd.Parameters.AddWithValue("@Password", pass);

                    var output = cmd.Parameters.Add("@Ret", SqlDbType.Int);
                    output.Direction = ParameterDirection.Output;

                    cmd.ExecuteNonQuery();
                    con.Close();

                    return Convert.ToInt16(output.Value.ToString());
                }
            }
        }
    }
}
