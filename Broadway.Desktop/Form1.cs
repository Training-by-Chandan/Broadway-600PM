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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Click += Form1_Click;
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            var mouseEventArgs = (MouseEventArgs)e;
            if (mouseEventArgs.Button== MouseButtons.Right)
            {
               
                contextMenuStrip1.Show(this,mouseEventArgs.Location);
                
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            
            float f = (float)trackBar1.Value;

            richTextBox1.SelectionFont = new Font(this.Font.FontFamily, f);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBold_Click(object sender, EventArgs e)
        {
          
            richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Bold);
            
        }
        bool isLower = false;
        private void button2_Click(object sender, EventArgs e)
        {
            if (isLower)
            {
                richTextBox1.SelectedText = richTextBox1.SelectedText.ToUpper();
                button2.Text = "To Lower";
            }
            else
            {
                richTextBox1.SelectedText = richTextBox1.SelectedText.ToLower();
                button2.Text = "To Upper";
            }
            isLower = !isLower;
        }
    }
}
