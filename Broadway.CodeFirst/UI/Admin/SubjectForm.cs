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

namespace Broadway.CodeFirst.UI.Admin
{
    public partial class SubjectForm : Form
    {
        public SubjectForm()
        {
            InitializeComponent();
            GridSubject.MouseDoubleClick += GridSubject_MouseDoubleClick;
        }

        public string SchoolName = ConfigurationManager.AppSettings["SchoolName"];

        private DefaultContext db = new DefaultContext();

        private void GridSubject_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var selected = GridSubject.SelectedRows;
            if (selected != null && selected.Count > 0)
            {
                //data populate gare
                var row = selected[0];
                TextName.Text = row.Cells["Name"].Value.ToString();

                TextCode.Text = row.Cells["Code"].Value.ToString();
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

        private void LoadData()
        {
            GridSubject.DataSource = db.Subjects.ToList();
            GridSubject.Refresh();

            LoadClass();
            LoadTeacher();
        }

        private void Insert()
        {
            if (Valid())
            {
                var subject = new Model.Subject()
                {
                    Name = TextName.Text,
                    Code = TextCode.Text,
                    ClassId = Convert.ToInt32(((KeyValuePair<string, string>)BoxClass.SelectedItem).Key),
                    TeacherId = Convert.ToInt32(((KeyValuePair<string, string>)BoxTeacher.SelectedItem).Key)
                };

                db.Subjects.Add(subject);
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

            TextCode.Text = string.Empty;
            LabelId.Text = string.Empty;

            ButtonCreate.Visible = true;
            ButtonEdit.Visible = false;
            ButtonDelete.Visible = false;
        }

        private bool Valid()
        {
            var res = false;
            if (!string.IsNullOrWhiteSpace(TextName.Text) && !string.IsNullOrWhiteSpace(TextCode.Text))
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
            var existingSubject = db.Subjects.Find(Convert.ToInt32(LabelId.Text));
            if (existingSubject != null && Valid())
            {
                existingSubject.Name = TextName.Text;

                existingSubject.Code = TextCode.Text;
                existingSubject.ClassId = Convert.ToInt32(((KeyValuePair<string, string>)BoxClass.SelectedItem).Key);

                existingSubject.TeacherId = Convert.ToInt32(((KeyValuePair<string, string>)BoxTeacher.SelectedItem).Key);

                db.Entry(existingSubject).State = System.Data.Entity.EntityState.Modified;
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
                var existingSubject = db.Subjects.Find(Convert.ToInt32(LabelId.Text));
                if (existingSubject != null)
                {
                    db.Subjects.Remove(existingSubject);
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

        private void LoadTeacher()
        {
            var data = db.Teachers.ToDictionary(p => p.Id.ToString(), p => p.Name);

            BoxTeacher.DataSource = new BindingSource(data, null);
            BoxTeacher.DisplayMember = "Value";
            BoxTeacher.ValueMember = "Key";
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }

        private void SubjectForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}