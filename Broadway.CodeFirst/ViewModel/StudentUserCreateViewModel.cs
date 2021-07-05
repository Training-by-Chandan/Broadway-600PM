using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Broadway.CodeFirst.ViewModel
{
    public class StudentUserCreateRequestViewModel : RequestViewModel
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public int? ClassId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public string Email { get; set; }
    }

    public class StudentUserCreateResponseViewModel : ResponseViewModel
    {
    }
}