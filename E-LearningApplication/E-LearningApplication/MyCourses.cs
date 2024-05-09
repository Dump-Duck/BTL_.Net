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
    public partial class MyCourses : Form
    {
        int userID = Login.userID;
        string stringConnect = @"Data Source=DESKTOP-NC6U1Q4\MSSQL_SERVER;Initial Catalog=E-LearningApplicationDB;Integrated Security=True;Encrypt=False";
        string sql;
        SqlConnection sqlConnection;
        SqlCommand sqlCommand;


        public MyCourses()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void loadMyCoursesIntoTable(int userID)
        {
            using (sqlConnection = new SqlConnection(stringConnect))
            {
                sqlConnection.Open();
                sql = @"SELECT c.CourseID AS CourseID, c.CourseName, c.Level, c.CreateBy, c.UpdateAt, c.CreateAt, uc.EnrolledAt FROM UserCourses uc JOIN Courses c ON uc.CourseID = c.CourseID WHERE uc.UserID = @UserID";
                using (sqlCommand = new SqlCommand(sql, sqlConnection))
                {
                    sqlCommand.Parameters.AddWithValue("@UserID", userID);

                    using (SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        if(dataTable.Rows.Count > 0)
                        {
                            coursesDataGridView.DataSource = dataTable;
                        } else
                        {
                            nullCourse.Visible = true;
                        }
                    }
                }
            }
        }

        private void MyCourses_Load(object sender, EventArgs e)
        {
            loadMyCoursesIntoTable(userID);
        }

        private void nullCourse_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Courses courses = new Courses();
            courses.ShowDialog();
            this.Show();
            nullCourse.LinkVisited = true;
        }

        private void coursesDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                int courseID = Convert.ToInt32(coursesDataGridView.Rows[e.RowIndex].Cells["CourseID"].Value);

                Lessons lessonsForm = new Lessons(courseID);
                lessonsForm.ShowDialog();
            }
        }
    }
}
