using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace LMS.Tables
{
    class RegisteredUsers
    {
        public Guid UserID { get; set; }
        public String UserName { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String Password { get; set; }
        public String Address { get; set; }
        public String Email { get; set; }
        public String MemberID { get; set; }
        public String PhoneNumber { get; set; }
    }
}
