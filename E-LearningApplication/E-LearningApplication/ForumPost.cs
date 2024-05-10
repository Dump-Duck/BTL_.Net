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

        int userID = Login.userID;
        string stringConnect = @"Data Source=DESKTOP-NC6U1Q4\MSSQL_SERVER;Initial Catalog=E-LearningApplicationDB;Integrated Security=True;Encrypt=False";
        string sql;
        SqlConnection sqlConnection;
        SqlCommand sqlCommand;

        private void btnPostBlog_Click(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(stringConnect);
            sql = @"INSERT INTO ForumPosts(PostedBy,Title,Content,PostedAt)
                            VALUES (N'" + userID + @"', N'" + textTitleBox.Text + @"', N'" + richContentBox.Text + @"', GETDATE())";
            sqlConnection.Open();
            sqlCommand = new SqlCommand(sql, sqlConnection);
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Blog post successed!", "E-Learning Application", MessageBoxButtons.OK, MessageBoxIcon.Information);
            textTitleBox.Clear();
            richContentBox.Clear();
        }
    }
}
