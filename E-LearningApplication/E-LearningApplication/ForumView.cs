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
        int userID = Login.userID;
        public ForumView()
        {
            InitializeComponent();
            InitializeDataGridView();
        }

        public void InitializeDataGridView()
        {
            dataGridBlog.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridBlog.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridComments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridComments.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
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
            dataGridBlog.DataSource = dataTable;
            sqlConnection.Close();
        }
        private void CommentsShow(string postID)
        {
            sqlConnection.Open();
            sql = @"SELECT * FROM Comments Where PostID = " + postID + "";
            sqlCommand = new SqlCommand(sql, sqlConnection);
            dataReader = sqlCommand.ExecuteReader();
            dataTable = new DataTable();
            dataTable.Load(dataReader);
            dataGridComments.DataSource = dataTable;
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

        private void dataGridBlog_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textPostID.Text = dataGridBlog.SelectedRows[0].Cells["PostID"].Value.ToString();
            textPostedBy.Text = dataGridBlog.SelectedRows[0].Cells["PostedBy"].Value.ToString();
            textTitle.Text = dataGridBlog.SelectedRows[0].Cells["Title"].Value.ToString();
            richContent.Text = dataGridBlog.SelectedRows[0].Cells["Content"].Value.ToString();
            CommentsShow(dataGridBlog.SelectedRows[0].Cells["PostID"].Value.ToString());
            textPostIDCmt.Text = dataGridBlog.SelectedRows[0].Cells["PostID"].Value.ToString();
            textUserIDCmt.Text = userID.ToString();
            btnCmt.Visible = true;
            textContentCmt.Clear();
            if (userID.ToString() == textPostedBy.Text)
            {
                btnEditBlog.Visible = true;
                btnDeleteBlog.Visible = true;
            }
        }

        private void ForumView_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(stringConnect);
            blogShow();
            btnEditBlog.Visible = false;
            btnDeleteBlog.Visible = false;
            btnEditCmt.Visible = false;
            btnDelete.Visible = false;
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

        private void btnEditCmt_Click(object sender, EventArgs e)
        {
            sql = @"Update Comments Set Content = N'" + textContentCmt.Text + @"' WHERE PostID = N'" + textPostIDCmt.Text + @"' ";
            sqlConnection.Open();
            sqlCommand = new SqlCommand(sql, sqlConnection);
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Comment Edit Successed!", "E-Learning Application", MessageBoxButtons.OK, MessageBoxIcon.Information);
            CommentsShow(dataGridBlog.SelectedRows[0].Cells["PostID"].Value.ToString());
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            sql = @"Delete FROM Comments Where (PostID = N'" + textPostIDCmt.Text + @"')";
            sqlCommand = new SqlCommand(sql, sqlConnection);
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Comment Deleted!", "E-Learning Application", MessageBoxButtons.OK, MessageBoxIcon.Information);
            CommentsShow(dataGridBlog.SelectedRows[0].Cells["PostID"].Value.ToString());
        }

        private void btnCmt_Click(object sender, EventArgs e)
        {

            sqlConnection = new SqlConnection(stringConnect);
            sql = @"INSERT INTO Comments(PostID,UserID,Content,CommentAt)
                            VALUES (N'" + textPostIDCmt.Text + @"', N'" + textUserIDCmt.Text + @"', N'" + textContentCmt.Text + @"', GETDATE())";
            sqlConnection.Open();
            sqlCommand = new SqlCommand(sql, sqlConnection);
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Comment successed!", "E-Learning Application", MessageBoxButtons.OK, MessageBoxIcon.Information);
            textPostIDCmt.Clear();
            textUserIDCmt.Clear();
            textContentCmt.Clear();
        }

        private void dataGridComments_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textPostIDCmt.Text = dataGridComments.SelectedRows[0].Cells["PostID"].Value.ToString();
            textUserIDCmt.Text = dataGridComments.SelectedRows[0].Cells["UserID"].Value.ToString();
            textContentCmt.Text = dataGridComments.SelectedRows[0].Cells["Content"].Value.ToString();
            if(userID.ToString() != textUserIDCmt.Text)
            {
                btnCmt.Visible = false;
            }
            if (userID.ToString() == textUserIDCmt.Text)
            {
                btnEditCmt.Visible = true;
                btnDelete.Visible = true;
            }
        }
    }
}
