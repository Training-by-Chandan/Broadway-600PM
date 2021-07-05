using Broadway.CodeFirst.Data;
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
using Broadway.CodeFirst.Service;

namespace Broadway.CodeFirst
{
    public partial class Form1 : Form
    {
        public string SchoolName = ConfigurationManager.AppSettings["SchoolName"];

        private DefaultContext db = new DefaultContext();

        public Form1()
        {
            InitializeComponent();
            this.Text = "Welcome to " + SchoolName;
            GridStudent.MouseClick += GridStudent_MouseDoubleClick;
        }

        private void GridStudent_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var selected = GridStudent.SelectedRows;
            if (selected != null && selected.Count > 0)
            {
                //data populate gare
                var row = selected[0];
                TextName.Text = row.Cells["Name"].Value.ToString();
                TextAddress.Text = row.Cells["Address"].Value.ToString();

                LabelId.Text = row.Cells["Id"].Value.ToString();
                var student = db.Student.FirstOrDefault(p => p.Id.ToString() == LabelId.Text);

                var classteacher = student.Classes.ClassTeacher == null ? "" : student.Classes.ClassTeacher.FirstOrDefault().Name;
                LabelClassTeacher.Text = $"Class Teacher: {classteacher}";
                LabelClassTeacher.Visible = true;
                ButtonCreate.Visible = false;
                ButtonEdit.Visible = true;
                ButtonDelete.Visible = true;
            }
            else
            {
                Reset();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            GridStudent.DataSource = UserService.ListAllStudentsInDashboard();
            GridStudent.Refresh();

            LoadClass();
        }

        private void Insert()
        {
            if (Valid() && TextPassword.Text == TextConfirmPassword.Text)
            {
                var student = new ViewModel.StudentUserCreateRequestViewModel()
                {
                    Name = TextName.Text,
                    Address = TextAddress.Text,
                    Email = TextEmail.Text,
                    Username = TextUserName.Text,
                    Password = TextPassword.Text,

                    ClassId = Convert.ToInt32(((KeyValuePair<string, string>)BoxClass.SelectedItem).Key)
                };

                var result = UserService.CreateStudentUser(student);
                if (result.Status)
                {
                    Reset();
                    LoadData();
                }
                else
                {
                    MessageBox.Show(result.Message);
                }
            }
            else
            {
                MessageBox.Show(" Some fields are empty, please check the entries");
            }
        }

        private void Reset()
        {
            TextName.Text = string.Empty;
            TextAddress.Text = string.Empty;
            LabelId.Text = string.Empty;
            LabelClassTeacher.Text = string.Empty;

            ButtonCreate.Visible = true;
            ButtonEdit.Visible = false;
            ButtonDelete.Visible = false;
        }

        private bool Valid()
        {
            var res = false;
            if (!string.IsNullOrWhiteSpace(TextName.Text))
            {
                res = true;
            }

            return res;
        }

        private void ButtonCreate_Click(object sender, EventArgs e)
        {
            Insert();
        }

        private void Edit()
        {
            var existingStudent = db.Student.Find(Convert.ToInt32(LabelId.Text));
            if (existingStudent != null && Valid())
            {
                existingStudent.Name = TextName.Text;
                existingStudent.Address = TextAddress.Text;

                existingStudent.ClassId = Convert.ToInt32(((KeyValuePair<string, string>)BoxClass.SelectedItem).Key);

                db.Entry(existingStudent).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();

                Reset();
                LoadData();
            }
            else
            {
                MessageBox.Show("Some Error occured");
            }
        }

        private void Delete()
        {
            var result = MessageBox.Show("Are you sure you want to delete this?", "Warning!", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                var existingStudent = db.Student.Find(Convert.ToInt32(LabelId.Text));
                if (existingStudent != null)
                {
                    db.Student.Remove(existingStudent);
                    db.SaveChanges();

                    Reset();
                    LoadData();
                }
            }
        }

        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            Edit();
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void LoadClass()
        {
            var data = db.Classes.ToDictionary(p => p.Id.ToString(), p => p.Name);

            BoxClass.DataSource = new BindingSource(data, null);
            BoxClass.DisplayMember = "Value";
            BoxClass.ValueMember = "Key";
        }
    }
}