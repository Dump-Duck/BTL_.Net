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
    public partial class Login : Form
    {
        public static int userID { get; private set; }

        public bool IsLoggedIn { get; set; }

        public Login()
        {
            InitializeComponent();
        }

        string stringConnect = @"Data Source=DESKTOP-6NPQFM8;Initial Catalog=E-LearningApplicationDB;Integrated Security=True;Encrypt=False";
        string sql;
        SqlConnection sqlConnection;
        SqlCommand sqlCommand;

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignUp signUp = new SignUp();
            signUp.ShowDialog();
            this.Show();
        }

        private void hidePassBtn_Click(object sender, EventArgs e)
        {
            if(textPassword.PasswordChar == '\0')
            {
                showPassbtn.BringToFront();
                textPassword.PasswordChar = '*';
            }
        }

        private void showPassBtn_Click(object sender, EventArgs e)
        {
            if (textPassword.PasswordChar == '*')
            {
                hidePassBtn.BringToFront();
                textPassword.PasswordChar = '\0';
            }
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            if (textUserName.Text == null || textPassword.Text == null)
            {
                MessageBox.Show("Login Failed!", "Please full fill the form information!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else
            {
                sqlConnection = new SqlConnection(stringConnect);
                sql = @"SELECT * FROM Users WHERE Username = N'" +textUserName.Text+ "' AND Password = N'" + textPassword.Text + "'";
                sqlConnection.Open();
                sqlCommand = new SqlCommand(sql, sqlConnection);
                SqlDataReader d = sqlCommand.ExecuteReader();

                if (d.Read() == true)
                {
                    userID = (int)d["UserID"];
                    sqlConnection.Close();
                    IsLoggedIn = true;
                    this.Close();
                } else
                {
                    MessageBox.Show("Invalid Information, Login Failed!", "Please Re-Login!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textUserName.Text = "";
                    textPassword.Text = "";
                    textUserName.Focus();
                    if(sqlConnection != null && sqlConnection.State == ConnectionState.Closed)
                    {
                        sqlConnection.Open();
                    }
                }
            }
        }
    }
}
