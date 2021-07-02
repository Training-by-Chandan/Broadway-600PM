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
    }
}