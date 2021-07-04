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
        public DbSet<Model.Teacher> Teachers { get; set; }
        public DbSet<Classes> Classes { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Subject> Subjects { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}