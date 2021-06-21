using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Broadway.CodeFirst
{
    public partial class Form1 : Form
    {
        public string SchoolName = ConfigurationManager.AppSettings["SchoolName"];

        public Form1()
        {
            InitializeComponent();
            this.Text = "Welcome to " + SchoolName;
        }

        
    }
}