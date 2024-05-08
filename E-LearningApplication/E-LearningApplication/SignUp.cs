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
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        string stringConnect = @"Data Source=DESKTOP-NC6U1Q4\MSSQL_SERVER;Initial Catalog=E-LearningApplicationDB;Integrated Security=True;Encrypt=False";
        string sql;
        SqlConnection sqlConnection;
        SqlCommand sqlCommand;

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(stringConnect);
            sql = @"INSERT INTO Users(Username,Password,Email,Level,Role)
                            VALUES (N'"+textUserName.Text+@"', N'"+textPassword.Text+@"', N'"+textEmail.Text+@"', N'"+levelSelectBox.Text+@"', N'"+roleSelectBox.Text+@"')";
            sqlConnection.Open();
            sqlCommand = new SqlCommand(sql, sqlConnection);
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Sign up success!", "E-Learning Application", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void hidePassBtn_Click(object sender, EventArgs e)
        {
            if(textPassword.PasswordChar == '\0')
            {
                showPassBtn.BringToFront();
                textPassword.PasswordChar = '*';
            }
        }

        private void showPassBtn_Click(object sender, EventArgs e)
        {
            if(textPassword.PasswordChar == '*')
            {
                hidePassBtn.BringToFront();
                textPassword.PasswordChar = '\0';
            }
        }
    }
}
