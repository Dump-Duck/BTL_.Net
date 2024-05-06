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
    public partial class CoursesManagement : Form
    {

        public static CoursesManagement instance;
        public CoursesManagement()
        {
            InitializeComponent();
            instance = this;
        }

        // them chuoi ket not 
        string stringConnect = @"Data Source=DESKTOP-NC6U1Q4\MSSQL_SERVER;Initial Catalog=E-LearningApplicationDB;Integrated Security=True;Encrypt=False";
        string sql;
        SqlConnection sqlConnection;
        SqlCommand sqlCommand;
        SqlDataReader dataReader;
        int i = 0;

        public void displayDataCourses()
        {
            listViewDataCourses.Items.Clear();
            sqlConnection.Open();
            sql = @"SELECT * FROM Courses";
            sqlCommand = new SqlCommand(sql, sqlConnection);
            dataReader = sqlCommand.ExecuteReader();

            i = 0;
            while (dataReader.Read())
            {
                listViewDataCourses.Items.Add(dataReader[0].ToString());
                listViewDataCourses.Items[i].SubItems.Add(dataReader[1].ToString());
                listViewDataCourses.Items[i].SubItems.Add(dataReader[2].ToString());
                listViewDataCourses.Items[i].SubItems.Add(dataReader[3].ToString());
                listViewDataCourses.Items[i].SubItems.Add(dataReader[4].ToString());
                listViewDataCourses.Items[i].SubItems.Add(dataReader[5].ToString());
                listViewDataCourses.Items[i].SubItems.Add(dataReader[6].ToString());
                i++;
            }
            sqlConnection.Close();
        }


        private void CoursesManagement_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(stringConnect);
            displayDataCourses();
        }

        private void listViewDataCourses_Click(object sender, EventArgs e)
        {
            textBoxCourseID.Text = listViewDataCourses.SelectedItems[0].SubItems[0].Text;
            textBoxCourseName.Text = listViewDataCourses.SelectedItems[0].SubItems[1].Text;
            textBoxDescriptionCourse.Text = listViewDataCourses.SelectedItems[0].SubItems[2].Text;
            comboBoxLevelCourse.Text = listViewDataCourses.SelectedItems[0].SubItems[3].Text;
            textBoxCreateBy.Text = listViewDataCourses.SelectedItems[0].SubItems[4].Text;
        }

        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            DateTime curDate = DateTime.Now;
            listViewDataCourses.Items.Clear();
            sqlConnection.Open();
            sql = @"INSERT INTO Courses(CourseName, Description, Level, CreateBy, UpdateAt, CreateAt)
                  VALUES (N'" + textBoxCourseName.Text + @"', N'" + textBoxDescriptionCourse.Text + @"', N'" + comboBoxLevelCourse.Text + @"',N'" + textBoxCreateBy.Text + @"', GETDATE(), GETDATE())";
            sqlCommand = new SqlCommand(sql, sqlConnection);
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Add course success!", "E-Learning Application", MessageBoxButtons.OK, MessageBoxIcon.Information);
            displayDataCourses();
        }

        private void btnUpdateCourse_Click(object sender, EventArgs e)
        {
            DateTime curDate = DateTime.Now;
            listViewDataCourses.Items.Clear();
            sqlConnection.Open();
            sql = @"Update Courses Set CourseName = N'" + textBoxCourseName.Text + @"', Description = N'" + textBoxDescriptionCourse.Text + @"',
                      Level = N'" + comboBoxLevelCourse.Text + @"', UpdateAt = GETDATE() WHERE CourseID = N'" + textBoxCourseID.Text + @"' ";
            sqlCommand = new SqlCommand(sql, sqlConnection);
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Course Updated!", "E-Learning Application", MessageBoxButtons.OK, MessageBoxIcon.Information);
            displayDataCourses();
        }

        private void btnDeleteCourse_Click(object sender, EventArgs e)
        {
            listViewDataCourses.Items.Clear();
            sqlConnection.Open();
            sql = @"Delete FROM Courses Where (CourseID = N'" + textBoxCourseID.Text + @"')";
            sqlCommand = new SqlCommand(sql, sqlConnection);
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Course Deleted!", "E-Learning Application", MessageBoxButtons.OK, MessageBoxIcon.Information);
            displayDataCourses();
        }


        private void btnAddLesson_Click(object sender, EventArgs e)
        {
            LessonsManagement lessonsManagement = new LessonsManagement();
            LessonsManagement.instance.courseID = int.Parse(textBoxCourseID.Text);
            lessonsManagement.Show();
        }
    }
}
