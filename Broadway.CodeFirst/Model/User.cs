using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Broadway.CodeFirst.Model
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string PlainPassword { get; set; }
        public UserType Type { get; set; }
    }

    public enum UserType
    {
        Basic = 0,
        Student = 1,
        Teacher = 2,
        Admin = 3
    }
}