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
    public partial class InitialV2 : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;

        public InitialV2()
        {
            InitializeComponent();
            loadData();
        }

        private void loadData()
        {
            var ds = new DataSet();
            SqlConnection con = new SqlConnection(connectionString);
            string query = "select * from vw_studentparent";

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

        private void InsertData()
        {
            SqlConnection con = new SqlConnection(connectionString);
            string query = "sp_studentParent";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@student", txtStudent.Text);
            cmd.Parameters.AddWithValue("@father", txtFather.Text);
            cmd.Parameters.AddWithValue("@mother", txtMother.Text);

            try
            {
                con.Open();
                var result = cmd.ExecuteNonQuery();

                loadData();
                ResetFields();
            }
            catch (Exception ex)
            {
            }
            finally
            {
                con.Close();
            }
        }

        private void ResetFields()
        {
            txtStudent.Text = string.Empty;
            txtFather.Text = string.Empty;
            txtMother.Text = string.Empty;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            InsertData();
        }
    }
}