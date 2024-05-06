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
    public partial class LessonsManagement : Form
    {
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

        private void btnAddLesson_Click(object sender, EventArgs e)
        {
            listViewDataLessons.Items.Clear();
            sqlConnection.Open();
            sql = @"INSERT INTO Lessons(CourseID, LessonName, Content, UpdateAt, CreateAt)
                  VALUES (N'" + courseID + @"', N'" + textBoxLessonName.Text + @"', N'" + textBoxContent.Text + @"', GETDATE(), GETDATE())";
            sqlCommand = new SqlCommand(sql, sqlConnection);
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Add course success!", "E-Learning Application", MessageBoxButtons.OK, MessageBoxIcon.Information);
            displayDataLessons();
        }

        private void btnUpdateLesson_Click(object sender, EventArgs e)
        {
            listViewDataLessons.Items.Clear();
            sqlConnection.Open();
            sql = @"Update Lessons Set LessonName = N'" + textBoxLessonName.Text + @"', Content = N'" + textBoxContent.Text + @"',
                      UpdateAt = GETDATE() WHERE LessonID = N'" + textBoxLessonID.Text + @"' ";
            sqlCommand = new SqlCommand(sql, sqlConnection);
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Course Updated!", "E-Learning Application", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            MessageBox.Show("Course Deleted!", "E-Learning Application", MessageBoxButtons.OK, MessageBoxIcon.Information);
            displayDataLessons();
        }

        private void listViewDataLessons_Click(object sender, EventArgs e)
        {
            textBoxLessonID.Text = listViewDataLessons.SelectedItems[0].SubItems[0].Text;
            textBoxLessonName.Text = listViewDataLessons.SelectedItems[0].SubItems[2].Text;
            textBoxContent.Text = listViewDataLessons.SelectedItems[0].SubItems[3].Text;
        }
    }
}
