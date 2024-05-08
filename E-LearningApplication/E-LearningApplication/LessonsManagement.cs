using System;
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
    public partial class LessonsManagement : Form
    {
        int userID = Login.userID;
        public static LessonsManagement instance;
        public int courseID;

        public LessonsManagement()
        {
            InitializeComponent();
            instance = this;
            
        }
        string stringConnect = @"Data Source=DESKTOP-NC6U1Q4\MSSQL_SERVER;Initial Catalog=E-LearningApplicationDB;Integrated Security=True;Encrypt=False";
        string sql;
        SqlConnection sqlConnection;
        SqlCommand sqlCommand;
        SqlDataReader dataReader;
        int i = 0;

        public void displayDataLessons()
        {
            listViewDataLessons.Items.Clear();
            sqlConnection.Open();
            sql = @"SELECT * FROM Lessons where CourseID = N'" + courseID + @"' ";
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
                listViewDataLessons.Items[i].SubItems.Add(dataReader[5].ToString());
                i++;
            }
            sqlConnection.Close();
        }

        private void LessonsManagement_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(stringConnect);
            displayDataLessons();
        }

        private void addDataLesson(string file)
        {
            sqlConnection.Open();
            FileStream stream = File.OpenRead(file);
            byte[] contents = new byte[stream.Length];
            stream.Read(contents, 0, (int)stream.Length);
            stream.Close();
            sql = "INSERT INTO Lessons(CourseID, LessonName, Content, UpdateAt, CreateAt) VALUES (@courseID, @lessonName, @content, GETDATE(), GETDATE())";
            using (sqlCommand = new SqlCommand(sql, sqlConnection))
            {
                sqlCommand.Parameters.AddWithValue("@courseID", courseID);
                sqlCommand.Parameters.AddWithValue("@lessonName", textBoxLessonName.Text);
                sqlCommand.Parameters.AddWithValue("@content", contents);
                sqlCommand.ExecuteNonQuery();
            }
            MessageBox.Show("Add exam success!", "E-Learning Application", MessageBoxButtons.OK, MessageBoxIcon.Information);
            sqlConnection.Close();
            displayDataLessons();
        }

        private void btnAddLesson_Click(object sender, EventArgs e)
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
                        addDataLesson(fileName);
                    }
                }
            }
        }

        private void btnUpdateLesson_Click(object sender, EventArgs e)
        {
            listViewDataLessons.Items.Clear();
            sqlConnection.Open();
            sql = @"Update Lessons Set LessonName = N'" + textBoxLessonName.Text + @"', UpdateAt = GETDATE() WHERE LessonID = N'" + textBoxLessonID.Text + @"' ";
            sqlCommand = new SqlCommand(sql, sqlConnection);
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Lesson Updated!", "E-Learning Application", MessageBoxButtons.OK, MessageBoxIcon.Information);
            displayDataLessons();
        }

        private void btnDeleteLesson_Click(object sender, EventArgs e)
        {
            listViewDataLessons.Items.Clear();
            sqlConnection.Open();
            sql = @"Delete FROM Lessons Where (LessonID = N'" + textBoxLessonID.Text + @"')";
            sqlCommand = new SqlCommand(sql, sqlConnection);
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Lesson Deleted!", "E-Learning Application", MessageBoxButtons.OK, MessageBoxIcon.Information);
            displayDataLessons();
        }

        private void listViewDataLessons_Click(object sender, EventArgs e)
        {
            textBoxLessonID.Text = listViewDataLessons.SelectedItems[0].SubItems[0].Text;
            textBoxLessonName.Text = listViewDataLessons.SelectedItems[0].SubItems[2].Text;
        }
    }
}
