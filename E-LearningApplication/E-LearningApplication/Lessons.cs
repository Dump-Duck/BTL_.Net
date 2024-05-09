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
    public partial class Lessons : Form
    {
        private int currentCourseID;
        string stringConnect = @""; // add connect with database
        string sql;
        SqlConnection sqlConnection;
        SqlCommand sqlCommand;
        public Lessons(int courseID)
        {
            InitializeComponent();
            this.currentCourseID = courseID;
        }

        private void loadLessonsOfCourse(int courseID)
        {
            using (sqlConnection = new SqlConnection(stringConnect))
            {
                sqlConnection.Open();
                sql = @"SELECT l.LessonID, l.LessonName, c.CourseName, l.UpdateAt, l.CreateAt FROM Lessons l JOIN Courses c ON l.CourseID = c.CourseID WHERE l.CourseID = @CourseID";
                using (sqlCommand = new SqlCommand(sql, sqlConnection))
                {
                    sqlCommand.Parameters.AddWithValue("@CourseID", courseID);
                    using (SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        
                        if (dataTable.Rows.Count > 0)
                        {
                            lessonsDataGridView.DataSource = dataTable;
                        }
                        else
                        {
                            noneLesson.Visible = true;
                        }
                    }
                }
            }
        }
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

        private void forumToolStripMenuItem_Click(object sender, EventArgs e)
        {
/*            this.Hide();
            Forum forum = new Forum();
            forum.ShowDialog();
            this.Show();*/

        }

        private void practiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Practices practices = new Practices();
            practices.ShowDialog();
            this.Show();
        }

        private void Lessons_Load(object sender, EventArgs e)
        {
            loadLessonsOfCourse(this.currentCourseID);
        }
    }
}
