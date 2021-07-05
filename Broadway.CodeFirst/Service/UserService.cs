using Broadway.CodeFirst.Data;
using Broadway.CodeFirst.Model;
using Broadway.CodeFirst.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Broadway.CodeFirst.Service
{
    public static class UserService
    {
        public static DefaultContext db = new DefaultContext();

        public static LoginResponseViewModel Login(LoginRequestViewModel model)
        {
            var result = new LoginResponseViewModel();
            try
            {
                //find existing user
                var existingUser = db.Users.FirstOrDefault(p => p.Username.ToUpper() == model.Username.ToUpper());
                if (existingUser == null)
                {
                    result.Message = "User not found";
                }
                else
                {
                    if (existingUser.PlainPassword == model.Password)
                    {
                        result.Status = true;
                        result.Message = "Loggedin successfully";
                        result.Type = existingUser.Type;
                        result.UserId = existingUser.Id;
                    }
                    else
                    {
                        result.Message = "Password did not match";
                    }
                }
            }
            catch (Exception ex)
            {
                result.Message = ex.Message;
            }

            return result;
        }

        public static StudentUserCreateResponseViewModel CreateStudentUser(StudentUserCreateRequestViewModel model)
        {
            var res = new StudentUserCreateResponseViewModel();
            try
            {
                var user = new User()
                {
                    Email = model.Email,
                    Username = model.Username,
                    PlainPassword = model.Password,
                    Type = UserType.Student
                };

                db.Users.Add(user);
                db.SaveChanges();

                var student = new Student()
                {
                    Address = model.Address,
                    ClassId = model.ClassId,
                    Name = model.Name,
                    UserId = user.Id
                };
                db.Student.Add(student);
                db.SaveChanges();
                res.Status = true;
                res.Message = "User and student created successfully";
            }
            catch (Exception ex)
            {
                res.Message = ex.Message;
            }

            return res;
        }

        public static List<AdminStudentListViewModel> ListAllStudentsInDashboard()
        {
            var data = db.Student.Where(p => !p.IsDeleted).Select(p => new AdminStudentListViewModel
            {
                StudentId = p.Id,
                StudentEmail = p.StudentUser == null ? "" : p.StudentUser.Email,
                StudentName = p.Name,
                StudentUserName = p.StudentUser == null ? "" : p.StudentUser.Username
            });
            return data.ToList();
        }
    }
}