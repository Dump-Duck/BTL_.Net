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
    public partial class StudentResult : Form
    {
        int userID = Login.userID;
        string stringConnect = @"Data Source=DESKTOP-NC6U1Q4\MSSQL_SERVER;Initial Catalog=E-LearningApplicationDB;Integrated Security=True;Encrypt=False";
        string sql;
        SqlConnection sqlConnection;
        SqlCommand sqlCommand;
        SqlDataReader dataReader;
        int i = 0;
        public StudentResult()
        {
            InitializeComponent();
        }
        public void displayDataTestResults()
        {
            listViewDataLessons.Items.Clear();
            sqlConnection.Open();
            sql = @"select TestResults.ResultID, Tests.TestName, Users.Fullname, TestResults.TestSumitted, TestResults.Result from TestResults 
                    inner join Tests on TestResults.TestID = Tests.TestID inner join Users on Users.UserID = Tests.UserID Where Users.UserID = N'" + userID + @"'";
            sqlCommand = new SqlCommand(sql, sqlConnection);
            dataReader = sqlCommand.ExecuteReader();

            i = 0;
            while (dataReader.Read())
            {
                listViewDataLessons.Items.Add(dataReader[0].ToString());
                listViewDataLessons.Items[i].SubItems.Add(dataReader[1].ToString());
                listViewDataLessons.Items[i].SubItems.Add(dataReader[2].ToString());
                listViewDataLessons.Items[i].SubItems.Add(dataReader[3].ToString());
                listViewDataLessons.Items[i].SubItems.Add(dataReader[4].ToString());
                i++;
            }
            sqlConnection.Close();
        }

        private void StudentResult_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(stringConnect);
            displayDataTestResults();
        }
    }
}
