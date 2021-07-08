using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Broadway.CodeFirst.Service;
using Broadway.CodeFirst.ViewModel;

namespace Broadway.CodeFirst.UI.Admin
{
    public partial class ForgotPasswordForm : Form
    {
        public ForgotPasswordForm()
        {
            InitializeComponent();
        }

        private void ButtonResetSent_Click(object sender, EventArgs e)
        {
            ButtonResetSent.Enabled = false;
            var model = new ForgotPasswordRequestViewModel()
            {
                Username = TextUsername.Text
            };
            var result = UserService.ForgotPassword(model);
            if (result.Status)
            {
                TextUsername.Text = "";
            }
            MessageBox.Show(result.Message);
            ButtonResetSent.Enabled = true;
        }
    }
}