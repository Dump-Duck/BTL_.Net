using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_LearningApplication
{
    public partial class ExamingManagement : Form
    {
        int userID = Login.userID;
        string stringConnect = @"Data Source=DESKTOP-NC6U1Q4\MSSQL_SERVER;Initial Catalog=E-LearningApplicationDB;Integrated Security=True;Encrypt=False";
        string sql;
        SqlConnection sqlConnection;
        SqlCommand sqlCommand;
        SqlDataReader dataReader;
        int i = 0;

        public ExamingManagement()
        {
            InitializeComponent();
        }
        public void ExamingManagement_Load(object sender, EventArgs e)
        {
            MessageBox.Show(@""+ userID + @"", "E-Learning Application", MessageBoxButtons.OK, MessageBoxIcon.Information);
            sqlConnection = new SqlConnection(stringConnect);
            displayDataExams();
        }

        public void displayDataExams()
        {
            listViewDataExams.Items.Clear();
            sqlConnection.Open();
            sql = @"SELECT * FROM Tests";
            sqlCommand = new SqlCommand(sql, sqlConnection);
            dataReader = sqlCommand.ExecuteReader();

            i = 0;
            while (dataReader.Read())
            {
                listViewDataExams.Items.Add(dataReader[0].ToString());
                listViewDataExams.Items[i].SubItems.Add(dataReader[1].ToString());
                listViewDataExams.Items[i].SubItems.Add(dataReader[2].ToString());
                listViewDataExams.Items[i].SubItems.Add(dataReader[3].ToString());
                listViewDataExams.Items[i].SubItems.Add(dataReader[4].ToString());

                i++;
            }
            sqlConnection.Close();
        }


        private void listViewDataExams_Click(object sender, EventArgs e)
        {
            textBoxExamID.Text = listViewDataExams.SelectedItems[0].SubItems[0].Text;
            textBoxExamName.Text = listViewDataExams.SelectedItems[0].SubItems[2].Text;
        }


        private void btnAddExam_Click(object sender, EventArgs e)
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
                        addDataExam(fileName);
                    }
                }
            }
        }

        private void addDataExam(string file)
        {
            sqlConnection.Open();
            FileStream stream = File.OpenRead(file);
            byte[] contents = new byte[stream.Length];
            stream.Read(contents, 0, (int)stream.Length);
            stream.Close();
            sql = "INSERT INTO Tests(TestName, TestContent, UserID, CreateDate) VALUES (@name, @content, @userid, GETDATE())";
            using (sqlCommand = new SqlCommand(sql, sqlConnection))
            {
                sqlCommand.Parameters.AddWithValue("@name", textBoxExamName.Text);
                sqlCommand.Parameters.AddWithValue("@content", contents);
                sqlCommand.Parameters.AddWithValue("@userid", userID);
                sqlCommand.ExecuteNonQuery();
            }
            MessageBox.Show("Add exam success!", "E-Learning Application", MessageBoxButtons.OK, MessageBoxIcon.Information);
            sqlConnection.Close();
            displayDataExams();
        }

        private void btnUpdateExam_Click(object sender, EventArgs e)
        {
            listViewDataExams.Items.Clear();
            sqlConnection.Open();
            sql = @"Update Tests Set TestName = N'" + textBoxExamName.Text + @"'
                      WHERE TestID = N'" + textBoxExamID.Text + @"' ";
            sqlCommand = new SqlCommand(sql, sqlConnection);
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Exam Updated!", "E-Learning Application", MessageBoxButtons.OK, MessageBoxIcon.Information);
            displayDataExams();
        }

        private void btnDeleteExam_Click(object sender, EventArgs e)
        {
            listViewDataExams.Items.Clear();
            sqlConnection.Open();
            sql = @"Delete FROM Tests Where (TestID = N'" + textBoxExamID.Text + @"')";
            sqlCommand = new SqlCommand(sql, sqlConnection);
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Exam Deleted!", "E-Learning Application", MessageBoxButtons.OK, MessageBoxIcon.Information);
            displayDataExams();
        }
    }
}
