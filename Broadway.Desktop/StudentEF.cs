using Broadway.Desktop.EF;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Broadway.Desktop
{
    public partial class StudentEF : Form
    {
        private BWEntities db = new BWEntities();

        public StudentEF()
        {
            InitializeComponent();
            loaddata();
            loadlabel();
        }

        private void loadlabel()
        {
            var st = db.Students.Find(16);
            label1.Text = $"Name = {st.Name}, Father = {st.StudentParents.FirstOrDefault(p => p.Parent.Type == 0).Parent.Name}, Mother={st.StudentParents.FirstOrDefault(p => p.Parent.Type == 1).Parent.Name}";
        }

        private void loaddata()
        {
            dataGridView1.DataSource = db.Students.ToList();
            dataGridView1.Refresh();
        }

        private void insertData()
        {
            var student = new Student();
            student.Name = txtName.Text;

            db.Students.Add(student);
            db.SaveChanges();

            loaddata();
        }

        private void ResetFields()
        {
            txtName.Text = string.Empty;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            insertData();
        }
    }
}