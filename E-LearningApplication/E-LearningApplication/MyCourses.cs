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
            coursesDataGridView.CellContentClick += CoursesDataGridView_CellContentClick;
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
                            // Add Quit button:
                            DataGridViewButtonColumn btnLeaveCourse = new DataGridViewButtonColumn();
                            btnLeaveCourse.Name = "Leave";
                            btnLeaveCourse.Text = "leave";
                            btnLeaveCourse.UseColumnTextForButtonValue = true;
                            coursesDataGridView.Columns.Add(btnLeaveCourse);

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

        private void CoursesDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == coursesDataGridView.Columns["Leave"].Index && e.RowIndex >= 0)
            {
                int courseID = Convert.ToInt32(coursesDataGridView.Rows[e.RowIndex].Cells["CourseID"].Value);

                DialogResult result = MessageBox.Show("Bạn có chắc muốn rời khóa học này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    leaveCourse(courseID);
                    loadMyCoursesIntoTable(userID);
                }
            }
        }

        private void leaveCourse(int courseID)
        {
            sql = @"DELETE * FROM UserCourses WHERE CourseID = @CourseID AND UserID = @UserID";
            using (sqlCommand = new SqlCommand(sql, sqlConnection))
            {
                sqlConnection.Open();
                sqlCommand.Parameters.AddWithValue("@CourseID", courseID);
                sqlCommand.Parameters.AddWithValue("@UserID", userID);

                int rowsAffected = sqlCommand.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("You Have Leave The Course.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Can't Leave The Course.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            
        }
    }
}
