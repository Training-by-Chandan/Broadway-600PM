using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Broadway.CodeFirst.Model
{
    public class Teacher
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public int? ClassId { get; set; }

        [ForeignKey("ClassId")]
        public virtual Classes Classes { get; set; }

        public int? UserId { get; set; }

        [ForeignKey("UserId")]
        public virtual User TeacherUser { get; set; }
    }
}