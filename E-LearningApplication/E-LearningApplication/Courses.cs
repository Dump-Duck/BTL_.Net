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
            this.Hide();
            Home home = new Home();
            home.ShowDialog();
            this.Show();
        }

        private void practiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Testing testing = new Testing();
            testing.ShowDialog();
            this.Show();
        }

        private void blogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Forum forum = new Forum();
            forum.ShowDialog();
            this.Show();
        }
    }
}
