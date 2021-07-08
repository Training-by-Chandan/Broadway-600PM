using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Broadway.CodeFirst.ViewModel
{
    public class ForgotPasswordRequestViewModel : RequestViewModel
    {
        public string Username { get; set; }
    }

    public class ForgotPasswordResponseViewModel : ResponseViewModel
    {
    }
}