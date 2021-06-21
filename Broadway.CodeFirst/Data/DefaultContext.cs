using Broadway.CodeFirst.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Broadway.CodeFirst.Data
{
    public class DefaultContext : DbContext
    {
        public DefaultContext() : base("name=Default")
        {
        }

        public DbSet<Student> Student { get; set; }
        public DbSet<Teacher> Teacher { get; set; }
    }
}