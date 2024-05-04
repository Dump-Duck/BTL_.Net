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
        public CoursesManagement()
        {
            InitializeComponent();
        }
        // them chuoi ket not 
        string stringConnect = @"Data Source=DESKTOP-NC6U1Q4\MSSQL_SERVER;Initial Catalog=E-LearningApplicationDB;Integrated Security=True;Encrypt=False";
        string sql;
        SqlConnection sqlConnection;
        SqlCommand excutive;
        SqlDataReader dataReader;
        int i = 0;


        private void CoursesManagement_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(stringConnect);
        }
        public void displayDataCourses()
        {
            listViewDataCourses.Items.Clear();
            sqlConnection.Open();
            sql = @"SELECT * FROM Courses";
            excutive = new SqlCommand(sql, sqlConnection);
            dataReader = excutive.ExecuteReader();

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
            }
            sqlConnection.Close();
        }

        private void listViewDataCourses_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listViewDataCourses_Click(object sender, EventArgs e)
        {
            textBoxCourseID.Text = listViewDataCourses.SelectedItems[0].SubItems[0].Text;
            textBoxCourseTitle.Text = listViewDataCourses.SelectedItems[0].SubItems[1].Text;
            textBoxDescriptionCourse.Text = listViewDataCourses.SelectedItems[0].SubItems[2].Text;
            comboBoxLabelCourse.Text = listViewDataCourses.SelectedItems[0].SubItems[3].Text;
            textBoxCreateBy.Text = listViewDataCourses.SelectedItems[0].SubItems[4].Text;

        }

        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            DateTime curDate = DateTime.Now;
            listViewDataCourses.Items.Clear();
            sqlConnection.Open();
            sql = @"INSERT INTO Courses(CourseName, Description, Level, CreatedBy, UpdateAt, CreatedAt)
                VALUE (N'" + textBoxCourseTitle + @"', N'" + textBoxDescriptionCourse + @"', N'" + comboBoxLabelCourse + @"',N'" + textBoxCreateBy + @"', N'" + curDate + @"', N'" + curDate + @"')";
            excutive = new SqlCommand(sql, sqlConnection);
            excutive.ExecuteNonQuery();
            sqlConnection.Close();
            displayDataCourses();
        }

        private void btnUpdateCourse_Click(object sender, EventArgs e)
        {
            DateTime curDate = DateTime.Now;
            listViewDataCourses.Items.Clear();
            sqlConnection.Open();
            sql = @"Update Courses Set CourseName = N'" + textBoxCourseTitle + @"', Description = N'" + textBoxDescriptionCourse + @"',
                    Level = N'" + comboBoxLabelCourse + @"', UpdateAt = N'" + curDate + @"' WHERE CourseID = N'" + textBoxCourseID + @"' ";
            excutive = new SqlCommand(sql, sqlConnection);
            excutive.ExecuteNonQuery();
            sqlConnection.Close();
            displayDataCourses();
        }

        private void btnDeleteCourse_Click(object sender, EventArgs e)
        {
            listViewDataCourses.Items.Clear();
            sqlConnection.Open();
            sql = @"Delete FROM Courses Where (CourseID = N'" + textBoxCourseID + @"')";
            excutive = new SqlCommand(sql, sqlConnection);
            excutive.ExecuteNonQuery();
            sqlConnection.Close();
            displayDataCourses();
        }
    }
}
