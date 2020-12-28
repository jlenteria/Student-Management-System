using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;

namespace Student_Web_Service.Models
{
    public class DBConnection
    {
        public static string StudentDB()
        {
            return ConfigurationManager.ConnectionStrings["StudentDB"].ConnectionString;
        }
    }
}