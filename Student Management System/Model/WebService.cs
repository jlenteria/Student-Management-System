using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;

namespace Student_Management_System.Model
{
     
    class WebService
    {
        public static StudentWebService.WebService1 web_service()
        {
            ServicePointManager.ServerCertificateValidationCallback = new System.Net.Security.RemoteCertificateValidationCallback(
           delegate { return true; });
            return new StudentWebService.WebService1();
        }
    }
}
