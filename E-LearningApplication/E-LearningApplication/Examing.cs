using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_LearningApplication
{
    public partial class Examing : Form
    {
        public static Examing instance;
        int userID = Login.userID;
        public int testID;
        public Examing()
        {
            InitializeComponent();
            instance = this;
        }
        string stringConnect = @"Data Source=DESKTOP-NC6U1Q4\MSSQL_SERVER;Initial Catalog=E-LearningApplicationDB;Integrated Security=True;Encrypt=False";
        string sql;
        SqlConnection sqlConnection;
        SqlCommand sqlCommand;

        private void submitTest(string file)
        {
            sqlConnection.Open();
            FileStream stream = File.OpenRead(file);
            byte[] contents = new byte[stream.Length];
            stream.Read(contents, 0, (int)stream.Length);
            stream.Close();
            sql = "INSERT INTO TestResults(TestID, UserID, TestSumitted, Date) VALUES (@testID, @userID, @TestSumitted, GETDATE())";
            using (sqlCommand = new SqlCommand(sql, sqlConnection))
            {
                sqlCommand.Parameters.AddWithValue("@testID", testID);
                sqlCommand.Parameters.AddWithValue("@userID", userID);
                sqlCommand.Parameters.AddWithValue("@TestSumitted", contents);
                sqlCommand.ExecuteNonQuery();
            }
            MessageBox.Show("Add exam success!", "E-Learning Application", MessageBoxButtons.OK, MessageBoxIcon.Information);
            sqlConnection.Close();
            this.Close();
        }

        private void btnSubmitTest_Click(object sender, EventArgs e)
        {
            //sqlConnection.Open();
            using (OpenFileDialog dlg = new OpenFileDialog() { Filter = "PDF Documents(*.pdf)|*.pdf", ValidateNames = true })
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    DialogResult dialog = MessageBox.Show("Are you sure you want to upload this File", "Tech & Learn", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialog == DialogResult.Yes)
                    {
                        string fileName = dlg.FileName;
                        submitTest(fileName);
                    }
                }
            }
        }

        private void Examing_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(stringConnect);
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            sql = "SELECT TestName, TestContent FROM Tests WHERE TestID = @TestID";
            using (SqlConnection connection = new SqlConnection(stringConnect))
            {
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@TestID", testID);
                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string fileName = reader["TestName"].ToString();
                            byte[] pdfData = (byte[])reader["TestContent"];

                            SaveFileDialog saveFileDialog = new SaveFileDialog();
                            saveFileDialog.FileName = fileName;
                            saveFileDialog.Filter = "PDF files (*.pdf)|*.pdf";

                            if (saveFileDialog.ShowDialog() == DialogResult.OK)
                            {
                                string filePath = saveFileDialog.FileName;
                                File.WriteAllBytes(filePath, pdfData);
                                MessageBox.Show("PDF file has been saved successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else
                        {
                            MessageBox.Show("No data found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }
    }
}
