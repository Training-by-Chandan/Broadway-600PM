using Broadway.CodeFirst.Data;
using Broadway.CodeFirst.Model;
using Broadway.CodeFirst.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
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
                    if (existingUser.HasedPassword == Common.MD5Hash.Create(model.Password))
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
                    HasedPassword = Common.MD5Hash.Create(model.Password),
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

        public static ForgotPasswordResponseViewModel ForgotPassword(ForgotPasswordRequestViewModel model)
        {
            var res = new ForgotPasswordResponseViewModel();

            try
            {
                var user = db.Users.FirstOrDefault(p => p.Username == model.Username);
                if (user != null)
                {
                    var password = GenerateRandomPassword();
                    user.HasedPassword = Common.MD5Hash.Create(password);
                    db.Entry(user).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();

                    SendEmail(user.Email, user.Username, password);
                    res.Status = true;
                    res.Message = "Password cahnged and email is sent";
                }
                else
                {
                    res.Message = "User not found";
                }
            }
            catch (Exception ex)
            {
                res.Message = ex.Message;
            }

            return res;
        }

        private static void SendEmail(string email, string username, string password)
        {
            var receiver = new MailAddress(email, username);
            var sender = new MailAddress("gchandaniw@gmail.com", "Chandan Gupta Bhagat");

            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = true,
                Credentials = new NetworkCredential("gchandaniw@gmail.com", "dvsjyhawrgisaymr")
            };

            var msg = new MailMessage(sender, receiver)
            {
                Subject = "Password changed as per Requested",
                Body = $"Hi {username}! your new password is {password}.\nPlease login to continue.",
            };

            smtp.Send(msg);
        }

        private static string GenerateRandomPassword()
        {
            return "Test@123";
        }
    }
}