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
                HasedPassword = Common.MD5Hash.Create("Admin@123"),
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
                HasedPassword = Common.MD5Hash.Create("Student@123"),
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
                HasedPassword = Common.MD5Hash.Create("Teacher@123"),
                Type = UserType.Teacher
            };
            var existingTeacher = db.Users.FirstOrDefault(p => p.Username == "Teacher");
            if (existingTeacher == null)
            {
                db.Users.Add(teacher);
                db.SaveChanges();
            }

            //var allUsersWithoutHashedPwd = db.Users.Where(p => p.HasedPassword == null || p.HasedPassword == "").ToList();

            //foreach (var item in allUsersWithoutHashedPwd)
            //{
            //    item.HasedPassword = Common.MD5Hash.Create(item.PlainPassword);
            //    db.Entry(item).State = EntityState.Modified;
            //    db.SaveChanges();
            //}
        }
    }
}