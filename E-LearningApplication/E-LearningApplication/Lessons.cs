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
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;

namespace E_LearningApplication
{
    public partial class Lessons : Form
    {
        private int currentCourseID;
        string stringConnect = @"Data Source=DESKTOP-NC6U1Q4\MSSQL_SERVER;Initial Catalog=E-LearningApplicationDB;Integrated Security=True;Encrypt=False";
        string sql;
        SqlConnection sqlConnection;
        SqlCommand sqlCommand;
        public Lessons(int courseID)
        {
            InitializeComponent();
            this.currentCourseID = courseID;
            InitializeDataGridView();
        }

        public void InitializeDataGridView()
        {
            lessonsDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            lessonsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
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

        private void Lessons_Load(object sender, EventArgs e)
        {
            loadLessonsOfCourse(this.currentCourseID);
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            // Connection string to your SQL Server
            string connectionString = "Data Source=DESKTOP-NC6U1Q4\\MSSQL_SERVER;Initial Catalog=E-LearningApplicationDB;Integrated Security=True;Encrypt=False";

            // SQL query to fetch varbinary data from SQL Server
            string query = "SELECT Content FROM Lessons WHERE LessonID = @pdfId";

            // PDF ID to fetch from the database
            int pdfId = (int)lessonsDataGridView.SelectedRows[0].Cells["LessonID"].Value;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@pdfId", pdfId);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Get the byte array from the database
                                byte[] pdfBytes = (byte[])reader["Content"];

                                // Load the byte array into a MemoryStream
                                using (MemoryStream stream = new MemoryStream(pdfBytes))
                                {
                                    // Read the PDF file using iTextSharp
                                    using (PdfReader pdfReader = new PdfReader(stream))
                                    {
                                        string text = "";

                                        for (int page = 1; page <= pdfReader.NumberOfPages; page++)
                                        {
                                            text += PdfTextExtractor.GetTextFromPage(pdfReader, page);
                                        }

                                        // Display the text in a MessageBox (or use it as needed)
                                        MessageBox.Show(text);
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("PDF not found in the database.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
