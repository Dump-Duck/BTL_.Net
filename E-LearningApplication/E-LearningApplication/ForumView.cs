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
    public partial class ForumView : Form
    {
        public ForumView()
        {
            InitializeComponent();
            InitializeDataGridView();
        }

        public void InitializeDataGridView()
        {
            dataGridBlogView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridBlogView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        string stringConnect = @"Data Source=DESKTOP-NC6U1Q4\MSSQL_SERVER;Initial Catalog=E-LearningApplicationDB;Integrated Security=True;Encrypt=False";
        string sql;
        SqlConnection sqlConnection;
        SqlCommand sqlCommand;
        SqlDataReader dataReader;
        DataTable dataTable;

        private void blogShow()
        {

            sqlConnection.Open();
            sql = @"SELECT * FROM ForumPosts";
            sqlCommand = new SqlCommand(sql, sqlConnection);
            dataReader = sqlCommand.ExecuteReader();
            dataTable = new DataTable();
            dataTable.Load(dataReader);
            dataGridBlogView.DataSource = dataTable;
            sqlConnection.Close();
        }
       
        private void btnEditBlog_Click(object sender, EventArgs e)
        {
            sql = @"Update ForumPosts Set Title = N'" + textTitle.Text + @"', Content = N'" + richContent.Text + @"' WHERE PostID = N'" + textPostID.Text + @"' ";
            sqlConnection.Open();
            sqlCommand = new SqlCommand(sql, sqlConnection);
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Blog edit success!", "E-Learning Application", MessageBoxButtons.OK, MessageBoxIcon.Information);
            blogShow();
        }

        private void btnDeleteBlog_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            sql = @"Delete FROM ForumPosts Where (PostID = N'" + textPostID.Text + @"')";
            sqlCommand = new SqlCommand(sql, sqlConnection);
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Post Deleted!", "E-Learning Application", MessageBoxButtons.OK, MessageBoxIcon.Information);
            blogShow();
        }

        private void dataGridBlogView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textPostID.Text = dataGridBlogView.SelectedRows[0].Cells["PostID"].Value.ToString();
            textPostedBy.Text = dataGridBlogView.SelectedRows[0].Cells["PostedBy"].Value.ToString();
            textTitle.Text = dataGridBlogView.SelectedRows[0].Cells["Title"].Value.ToString();
            richContent.Text = dataGridBlogView.SelectedRows[0].Cells["Content"].Value.ToString();

        }

        private void ForumView_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(stringConnect);
            blogShow();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Home home = new Home();
            home.ShowDialog();
            this.Show();
        }

        private void coursesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Courses courses = new Courses();
            courses.ShowDialog();
            this.Show();
        }

        private void practiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Practices practices = new Practices();
            practices.ShowDialog();
            this.Show();
        }

        private void blogPostToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ForumPost forumPost = new ForumPost();
            forumPost.ShowDialog();
            this.Show();
        }

        private void blogManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is forum view page!", "E-Learning Application", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
