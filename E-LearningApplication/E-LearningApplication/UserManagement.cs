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
            InitializeDataGridView();
        }

        public void InitializeDataGridView()
        {
            userDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            userDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
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

        private void blogPostToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void blogManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void userManagementShow()
        {
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
            sqlConnection = new SqlConnection(stringConnect);
            this.userManagementShow();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            sql = @"Update Users Set Username = N'" + username_txt.Text + @"', Password = N'" + password_txt.Text + @"', 
                    Email = N'" + email_txt.Text + @"', Fullname = N'" + fullname_txt.Text + @"', 
                    Level = N'" + levelBox.Text + @"', Role = N'" + roleBox.Text + @"' , DateOfBirth = N'" + dateOfBirth.Text + @"', UpdateAt = GETDATE()
                    WHERE UserID = N'" + userID_txt.Text + @"' ";
            sqlConnection.Open();
            sqlCommand = new SqlCommand(sql, sqlConnection);
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("User update success!", "E-Learning Application", MessageBoxButtons.OK, MessageBoxIcon.Information);
            userManagementShow();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            sql = @"Delete FROM Users Where (UserID = N'" + userID_txt.Text + @"')";
            sqlCommand = new SqlCommand(sql, sqlConnection);
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("User Deleted!", "E-Learning Application", MessageBoxButtons.OK, MessageBoxIcon.Information);
            userManagementShow();
        }

        private void userDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            userID_txt.Text = userDataGridView.SelectedRows[0].Cells["UserID"].Value.ToString();
            username_txt.Text = userDataGridView.SelectedRows[0].Cells["Username"].Value.ToString();
            password_txt.Text = userDataGridView.SelectedRows[0].Cells["Password"].Value.ToString();
            email_txt.Text = userDataGridView.SelectedRows[0].Cells["Email"].Value.ToString();
            fullname_txt.Text = userDataGridView.SelectedRows[0].Cells["Fullname"].Value.ToString();
            dateOfBirth.Text = userDataGridView.SelectedRows[0].Cells["DateOfBirth"].Value.ToString();
            levelBox.Text = userDataGridView.SelectedRows[0].Cells["Level"].Value.ToString();
            roleBox.Text = userDataGridView.SelectedRows[0].Cells["Role"].Value.ToString();
        }
    }
}
