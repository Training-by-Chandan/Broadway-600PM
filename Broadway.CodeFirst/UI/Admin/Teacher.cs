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

namespace Broadway.CodeFirst
{
    public partial class Teacher : Form
    {
        public Teacher()
        {
            InitializeComponent();
            this.Text = "Welcome to " + SchoolName;
            dataGridView1.MouseClick += GridStudent_MouseDoubleClick;
            ButtonCreate.Click += ButtonCreate_Click;
            ButtonDelete.Click += ButtonDelete_Click;
            ButtonEdit.Click += ButtonEdit_Click;
        }

        public string SchoolName = ConfigurationManager.AppSettings["SchoolName"];

        private DefaultContext db = new DefaultContext();

        private void GridStudent_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var selected = dataGridView1.SelectedRows;
            if (selected != null && selected.Count > 0)
            {
                //data populate gare
                var row = selected[0];
                TextName.Text = row.Cells["Name"].Value.ToString();

                LabelId.Text = row.Cells["Id"].Value.ToString();

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
        }

        private void LoadData()
        {
            dataGridView1.DataSource = db.Teachers.ToList();
            dataGridView1.Refresh();

            LoadClass();
        }

        private void Insert()
        {
            if (Valid())
            {
                var teacher = new Model.Teacher()
                {
                    Name = TextName.Text,

                    ClassId = Convert.ToInt32(((KeyValuePair<string, string>)BoxClass.SelectedItem).Key)
                };

                db.Teachers.Add(teacher);
                db.SaveChanges();

                Reset();
                LoadData();
            }
            else
            {
                MessageBox.Show(" Some fields are empty, please check the entries");
            }
        }

        private void Reset()
        {
            TextName.Text = string.Empty;

            LabelId.Text = string.Empty;

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
            var existingTeacher = db.Teachers.Find(Convert.ToInt32(LabelId.Text));
            if (existingTeacher != null && Valid())
            {
                existingTeacher.Name = TextName.Text;

                existingTeacher.ClassId = Convert.ToInt32(((KeyValuePair<string, string>)BoxClass.SelectedItem).Key);

                db.Entry(existingTeacher).State = System.Data.Entity.EntityState.Modified;
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
                var existingTeacher = db.Teachers.Find(Convert.ToInt32(LabelId.Text));
                if (existingTeacher != null)
                {
                    db.Teachers.Remove(existingTeacher);
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
            var data = db.Classes.Where(p => p.ClassTeacher.Count == 0).ToDictionary(p => p.Id.ToString(), p => p.Name);

            BoxClass.DataSource = new BindingSource(data, null);
            BoxClass.DisplayMember = "Value";
            BoxClass.ValueMember = "Key";
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }

        private void Teacher_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}