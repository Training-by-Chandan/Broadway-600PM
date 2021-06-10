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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            LoadRandomData();
            dataGridView1.DataSource = students;
           
            dataGridView1.Refresh();
            dataGridView1.MouseClick += DataGridView1_MouseClick;
        }

        private void DataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            var rows = dataGridView1.SelectedRows;
            if (rows==null || rows.Count==0)
            {
                label1.Text = "";
                textBox1.Text = "";

                btnCreate.Visible = true;
                btnEdit.Visible = false;
                btnDelete.Visible = false;
            }
            else
            {
                var data = rows[0];
                label1.Text = data.Cells["Id"].Value.ToString();
                textBox1.Text = data.Cells["Name"].Value.ToString();
                
                btnCreate.Visible = false;
                btnEdit.Visible = true;
                btnDelete.Visible = true;
            }
        }

        void LoadRandomData()
        {
            students.Add(new Student { Id = 1, Name = "Chandan1" });
            students.Add(new Student { Id = 2, Name = "Chandan2" });
            students.Add(new Student { Id = 3, Name = "Chandan3" });
            students.Add(new Student { Id = 4, Name = "Chandan4" });
            students.Add(new Student { Id = 5, Name = "Chandan5" });
            students.Add(new Student { Id = 6, Name = "Chandan6" });
            students.Add(new Student { Id = 7, Name = "Chandan7" });
            students.Add(new Student { Id = 8, Name = "Chandan8" });
            students.Add(new Student { Id = 9, Name = "Chandan9" });
            students.Add(new Student { Id = 10, Name = "Chandan10" });
        }
        int nextId = 11;
        private List<Student> students { get; set; } = new List<Student>();

        private void btnCreate_Click(object sender, EventArgs e)
        {
            students.Add(new Student { Id = nextId, Name = textBox1.Text });
            nextId++;
            
            dataGridView1.DataSource = students;
            dataGridView1.Refresh();
        }
    }

    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
