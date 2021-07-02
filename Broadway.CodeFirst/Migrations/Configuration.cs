namespace Broadway.CodeFirst.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Broadway.CodeFirst.Model;

    internal sealed class Configuration : DbMigrationsConfiguration<Broadway.CodeFirst.Data.DefaultContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Broadway.CodeFirst.Data.DefaultContext db)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.

            var User = new User()
            {
                Username = "Admin",
                PlainPassword = "Admin@123",
                Type = UserType.Admin
            };
            var existingAdmin = db.Users.FirstOrDefault(p => p.Username == "Admin");
            if (existingAdmin == null)
            {
                db.Users.Add(User);
                db.SaveChanges();
            }

            var student = new User()
            {
                Username = "Student",
                PlainPassword = "Student@123",
                Type = UserType.Student
            };
            var existingStudent = db.Users.FirstOrDefault(p => p.Username == "Student");
            if (existingStudent == null)
            {
                db.Users.Add(student);
                db.SaveChanges();
            }

            var teacher = new User()
            {
                Username = "Teacher",
                PlainPassword = "Teacher@123",
                Type = UserType.Teacher
            };
            var existingTeacher = db.Users.FirstOrDefault(p => p.Username == "Teacher");
            if (existingTeacher == null)
            {
                db.Users.Add(teacher);
                db.SaveChanges();
            }
        }
    }
}