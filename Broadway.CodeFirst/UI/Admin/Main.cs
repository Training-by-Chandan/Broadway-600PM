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
    public partial class Main : Form
    {
        private int childFormNumber = 0;

        public Main()
        {
            InitializeComponent();
        }

        private void manageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.MdiParent = this;
            f.Show();
        }

        private void manageToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ClassForm f = new ClassForm();
            f.MdiParent = this;
            f.Show();
        }

        private void manageToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Teacher t = new Teacher();
            t.MdiParent = this;
            t.Show();
        }
    }
}