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
    public partial class Courses : Form
    {
        int userID = Login.userID;
        string stringConnect = @"Data Source=DESKTOP-6NPQFM8;Initial Catalog=E-LearningApplicationDB;Integrated Security=True;Encrypt=False";
        SqlConnection sqlConnection;

        public Courses()
        {
            InitializeComponent();
            coursesDataGridView.CellContentClick += CoursesDataGridView_CellContentClick;
        }
        private void loadAllCourse()
        {
            using (sqlConnection = new SqlConnection(stringConnect))
            {
                sqlConnection.Open();

                // All Courses query then fill in gridview table
                string sqlAllCourses = @"SELECT * FROM Courses";
                SqlCommand cmdAllCourses = new SqlCommand(sqlAllCourses, sqlConnection);
                SqlDataAdapter adapterAllCourses = new SqlDataAdapter(cmdAllCourses);
                DataTable tableAllCourses = new DataTable();
                adapterAllCourses.Fill(tableAllCourses);

                // Query User courses then remove similar course in all courses
                string sqlUserCourses = @"SELECT CourseID FROM UserCourses WHERE UserID = @UserID";
                SqlCommand cmdUserCourses = new SqlCommand(sqlUserCourses, sqlConnection);
                cmdUserCourses.Parameters.AddWithValue("@UserID", userID);
                SqlDataAdapter adapterUserCourses = new SqlDataAdapter(cmdUserCourses);
                DataTable tableUserCourses = new DataTable();
                adapterUserCourses.Fill(tableUserCourses);

                foreach (DataRow row in tableUserCourses.Rows)
                {
                    int CourseID = (int)row["CourseID"];
                    DataRow[] rowsRemove = tableUserCourses.Select("CourseID = " + CourseID);
                    foreach (DataRow rowRemove in rowsRemove)
                    {
                        tableUserCourses.Rows.Remove(rowRemove);
                    }
                }

                if(tableAllCourses.Rows.Count > 0)
                {
                    // Add Enroll button to row
                    DataGridViewButtonColumn btnEnrollColumn = new DataGridViewButtonColumn();
                    btnEnrollColumn.Name = "Enroll";
                    btnEnrollColumn.Text = "Enroll";
                    btnEnrollColumn.UseColumnTextForButtonValue = true;
                    coursesDataGridView.Columns.Add(btnEnrollColumn);

                    coursesDataGridView.DataSource = tableAllCourses;
                } else
                {
                    nullCourse.Visible = true;
                }
            }
            sqlConnection.Close();
        }

        private void CoursesDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == coursesDataGridView.Columns["Enroll"].Index && e.RowIndex >= 0)
            {
                int courseID = Convert.ToInt32(coursesDataGridView.Rows[e.RowIndex].Cells["CourseID"].Value);
                enrollCourse(courseID);
            }
        }

        private void enrollCourse(int courseID)
        {
            using (sqlConnection = new SqlConnection(stringConnect))
            {
                sqlConnection.Open();

                string sqlEnrollCourse = @"INSERT INTO UserCourses (UserID, CourseID, EnrolledAt) VALUE (@UserID, @CourseID, @EnrolledAt)";
                SqlCommand cmdEnrolledCourse = new SqlCommand(sqlEnrollCourse, sqlConnection);
                cmdEnrolledCourse.Parameters.AddWithValue("@UserID", userID);
                cmdEnrolledCourse.Parameters.AddWithValue("@CourseID", courseID);
                cmdEnrolledCourse.Parameters.AddWithValue("@EnrolledAt", DateTime.Now);

                int rowAffected = cmdEnrolledCourse.ExecuteNonQuery();
                if (rowAffected > 0)
                {
                    MessageBox.Show("Enrolled successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Enrollment failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void practiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Practices testing = new Practices();
            testing.ShowDialog();
            this.Show();
        }

        private void forumToolStripMenuItem_Click(object sender, EventArgs e)
        {
/*            this.Hide();
            Forum forum = new Forum();
            forum.ShowDialog();
            this.Show();*/

        }

        private void coursesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is courses page!", "E-Learning Application", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Courses_Load(object sender, EventArgs e)
        {
            loadAllCourse();
        }
    }
}
