using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_LearningApplication
{
    public partial class ForumPost : Form
    {
        public ForumPost()
        {
            InitializeComponent();
        }

        string stringConnect = @"Data Source=DESKTOP-NC6U1Q4\MSSQL_SERVER;Initial Catalog=E-LearningApplicationDB;Integrated Security=True;Encrypt=False";
        string sql;
        SqlConnection sqlConnection;
        SqlCommand sqlCommand;

        private void btnPostBlog_Click(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(stringConnect);
            sql = @"INSERT INTO ForumPosts(PostedBy,Title,Content,PostedAt)
                            VALUES (N'" + textPostedBy.Text + @"', N'" + textTitleBox.Text + @"', N'" + richContentBox.Text + @"', GETDATE())";
            sqlConnection.Open();
            sqlCommand = new SqlCommand(sql, sqlConnection);
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Blog post successed!", "E-Learning Application", MessageBoxButtons.OK, MessageBoxIcon.Information);
            textPostedBy.Clear();
            textTitleBox.Clear();
            richContentBox.Clear();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void coursesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void practiceToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void blogPostToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is forum post page!", "E-Learning Application", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void blogManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ForumView forumView = new ForumView();
            forumView.ShowDialog();
            this.Show();
        }
    }
}
