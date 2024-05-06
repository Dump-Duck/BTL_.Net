using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_LearningApplication
{
    public partial class Home : Form
    {
        private int currentUserID;
        string stringConnect = @"Data Source=DESKTOP-NC6U1Q4\MSSQL_SERVER;Initial Catalog=E-LearningApplicationDB;Integrated Security=True;Encrypt=False";
        string sql;
        SqlConnection sqlConnection;
        SqlCommand sqlCommand;

        private bool hasPermission(int userID, string role)
        {
            using (sqlConnection = new SqlConnection(stringConnect))
            {
                sqlConnection.Open();
                sql = @"SELECT COUNT(*) FROM Users WHERE Username = @UserID AND Role = @Role";
                using(sqlCommand = new SqlCommand(sql, sqlConnection))
                {
                    sqlCommand.Parameters.AddWithValue("@UserID", userID);
                    sqlCommand.Parameters.AddWithValue("@Role", role);
                    int count = (int)sqlCommand.ExecuteScalar();
                    return count > 0;
                }
            }
        }

        private void checkPermission(int userID)
        {
            if(!hasPermission(userID, "Admin"))
            {
                usersManagement.Visible = false;
            }
            if(!hasPermission(userID, "Teacher"))
            {
                coursesManagement.Visible = false;
            }
            if(!hasPermission(userID, "Student"))
            {
                myCourses.Visible = false;
            }
        }
        public Home(int userID)
        {
            InitializeComponent();
            currentUserID = userID;
            checkPermission(currentUserID);
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

        private void forumToolStripMenuItem_Click(object sender, EventArgs e)
        {
/*            this.Hide();
            Forum forum = new Forum();
            forum.ShowDialog();
            this.Show();*/

        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is home page!", "E-Learning Application", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
