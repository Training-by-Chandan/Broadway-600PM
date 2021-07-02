using Broadway.CodeFirst.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Broadway.CodeFirst.ViewModel
{
    public class LoginRequestViewModel : RequestViewModel
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }

    public class LoginResponseViewModel : ResponseViewModel
    {
        public int UserId { get; set; }
        public UserType Type { get; set; }
    }

    public class RequestViewModel
    {
    }

    public class ResponseViewModel
    {
        public bool Status { get; set; } = false;
        public string Message { get; set; }
    }
}