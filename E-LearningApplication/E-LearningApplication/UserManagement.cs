using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace E_LearningApplication
{
    public partial class UserManagement : Form
    {
        public UserManagement()
        {
            InitializeComponent();
        }

        // them chuoi ket not 
        string stringConnect = @"Data Source=DESKTOP-NC6U1Q4\MSSQL_SERVER;Initial Catalog=E-LearningApplicationDB;Integrated Security=True;Encrypt=False";
        string sql;
        SqlConnection sqlConnection;
        SqlCommand sqlCommand;
        SqlDataReader dataReader;
        DataTable dataTable;

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
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
            this.Hide();
            Forum forum = new Forum();
            forum.ShowDialog();
            this.Show();
        }

        private void userManagementShow()
        {
            sqlConnection = new SqlConnection(stringConnect);
            sqlConnection.Open();
            sql = @"SELECT * FROM Users";
            sqlCommand = new SqlCommand(sql, sqlConnection);
            dataReader = sqlCommand.ExecuteReader();
            dataTable = new DataTable();
            dataTable.Load(dataReader);
            userDataGridView.DataSource = dataTable;
            sqlConnection.Close();

        }

        private void UserManagement_Load(object sender, EventArgs e)
        {
            this.userManagementShow();
        }
    }
}
