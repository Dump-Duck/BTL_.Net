using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_LearningApplication
{
    public partial class Courses : Form
    {
        public Courses()
        {
            InitializeComponent();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void practiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Practices testing = new Practices();
            testing.ShowDialog();
            this.Show();
        }

        private void forumToolStripMenuItem_Click(object sender, EventArgs e)
        {
/*            this.Hide();
            Forum forum = new Forum();
            forum.ShowDialog();
            this.Show();*/

        }

        private void coursesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is courses page!", "E-Learning Application", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
