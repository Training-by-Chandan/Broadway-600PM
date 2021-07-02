using Broadway.CodeFirst.Service;
using Broadway.CodeFirst.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Broadway.CodeFirst
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            var request = new LoginRequestViewModel()
            {
                Username = TextUsername.Text,
                Password = TextPassword.Text
            };
            var result = UserService.Login(request);
            if (result.Status)
            {
                switch (result.Type)
                {
                    //change the form
                    case Model.UserType.Student:
                        StudentMain sm = new StudentMain();
                        sm.Show();
                        break;

                    case Model.UserType.Teacher:
                        TeacherMain tm = new TeacherMain();
                        tm.Show();
                        break;

                    case Model.UserType.Admin:
                        Main main = new Main();
                        main.Show();
                        break;

                    default:
                        break;
                }

                this.Hide();
            }
            else
            {
                MessageBox.Show(result.Message);
            }
        }
    }
}