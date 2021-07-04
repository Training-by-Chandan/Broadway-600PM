using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Broadway.CodeFirst.Model
{
    public class Subject
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public int? ClassId { get; set; }

        [ForeignKey("ClassId")]
        public virtual Classes Class { get; set; }

        public int? TeacherId { get; set; }

        [ForeignKey("TeacherId")]
        public virtual Teacher Teacher { get; set; }
    }
}