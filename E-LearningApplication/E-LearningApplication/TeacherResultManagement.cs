﻿using System;
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
    public partial class TeacherResultManagement : Form
    {
        int userID = Login.userID;
        string stringConnect = @"Data Source=DESKTOP-NC6U1Q4\MSSQL_SERVER;Initial Catalog=E-LearningApplicationDB;Integrated Security=True;Encrypt=False";
        string sql;
        SqlConnection sqlConnection;
        SqlCommand sqlCommand;
        SqlDataReader dataReader;
        int i = 0;
        public TeacherResultManagement()
        {
            InitializeComponent();
        }
        public void displayDataTestResults()
        {
            listViewDataResult.Items.Clear();
            sqlConnection.Open();
            sql = @"select TestResults.ResultID, Tests.TestName, Users.Fullname, TestResults.TestSumitted, TestResults.Result, TestResults.Date from TestResults 
                    inner join Tests on TestResults.TestID = Tests.TestID inner join Users on Users.UserID = Tests.UserID Where Tests.UserID = N'" + userID + @"'";
            sqlCommand = new SqlCommand(sql, sqlConnection);
            dataReader = sqlCommand.ExecuteReader();

            i = 0;
            while (dataReader.Read())
            {
                listViewDataResult.Items.Add(dataReader[0].ToString());
                listViewDataResult.Items[i].SubItems.Add(dataReader[1].ToString());
                listViewDataResult.Items[i].SubItems.Add(dataReader[2].ToString());
                listViewDataResult.Items[i].SubItems.Add(dataReader[3].ToString());
                listViewDataResult.Items[i].SubItems.Add(dataReader[4].ToString());
                listViewDataResult.Items[i].SubItems.Add(dataReader[5].ToString());
                i++;
            }
            sqlConnection.Close();
        }


        private void submitBtn_Click(object sender, EventArgs e)
        {
            listViewDataResult.Items.Clear();
            sqlConnection.Open();
            sql = @"Update TestResults Set Result = N'" + result_txt.Text + @"' WHERE UserID = N'" + userID + @"' ";
            sqlCommand = new SqlCommand(sql, sqlConnection);
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Course Updated!", "E-Learning Application", MessageBoxButtons.OK, MessageBoxIcon.Information);
            displayDataTestResults();
        }

        private void TeacherResultManagement_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(stringConnect);
            displayDataTestResults();
        }

        private void listViewDataResult_Click(object sender, EventArgs e)
        {
            resultID_txt.Text = listViewDataResult.SelectedItems[0].SubItems[0].Text;
            testName_txt.Text = listViewDataResult.SelectedItems[0].SubItems[1].Text;
            userName_txt.Text = listViewDataResult.SelectedItems[0].SubItems[2].Text;
            result_txt.Text = listViewDataResult.SelectedItems[0].SubItems[4].Text;
        }
    }
}