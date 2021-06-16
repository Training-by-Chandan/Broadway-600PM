using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Broadway.Desktop
{
    public partial class Initial : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;

        public Initial()
        {
            InitializeComponent();
            LoadDataV2();
        }

        private void LoadData()
        {
            SqlConnection con = new SqlConnection(connectionString);
            string query = "select * from Student";

            SqlCommand cmd = new SqlCommand(query, con);
            try
            {
                con.Open();
                var result = cmd.ExecuteReader();
                List<Student> list = new List<Student>();
                while (result.Read())
                {
                    var student = new Student();
                    student.Id = result.GetFieldValue<int>(0);
                    student.Name = result.GetFieldValue<string>(1);
                    list.Add(student);
                }

                dataGridView1.DataSource = list;
                dataGridView1.Refresh();
            }
            catch (Exception ex)
            {
            }
            finally
            {
                con.Close();
            }
        }

        private void LoadDataV2()
        {
            var ds = new DataSet();
            SqlConnection con = new SqlConnection(connectionString);
            string query = "select * from Student";

            SqlDataAdapter adapt = new SqlDataAdapter(query, con);
            try
            {
                adapt.Fill(ds);

                dataGridView1.DataSource = ds.Tables[0];
                dataGridView1.Refresh();
            }
            catch (Exception ex)
            {
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            InsertData();
        }

        private void InsertData()
        {
            SqlConnection con = new SqlConnection(connectionString);
            string query = "insert into student (name) values ('" + txtName.Text + "')";

            SqlCommand cmd = new SqlCommand(query, con);
            try
            {
                con.Open();
                var result = cmd.ExecuteNonQuery();

                txtName.Text = "";
                LoadDataV2();
            }
            catch (Exception ex)
            {
            }
            finally
            {
                con.Close();
            }
        }

        private void UpdateData()
        {
            SqlConnection con = new SqlConnection(connectionString);
            string query = "update student set name= '" + txtName.Text + "' where id=1";

            SqlCommand cmd = new SqlCommand(query, con);
            try
            {
                con.Open();
                var result = cmd.ExecuteNonQuery();

                txtName.Text = "";
                LoadDataV2();
            }
            catch (Exception ex)
            {
            }
            finally
            {
                con.Close();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateData();
        }
    }

    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}