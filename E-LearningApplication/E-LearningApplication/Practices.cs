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
    public partial class Practices : Form
    {
        public static Practices instance;

        public Practices()
        {
            InitializeComponent();
            instance = this;
        }

        int userID = Login.userID;
        // them chuoi ket not 
        string stringConnect = @"Data Source=DESKTOP-NC6U1Q4\MSSQL_SERVER;Initial Catalog=E-LearningApplicationDB;Integrated Security=True;Encrypt=False";
        string sql;
        SqlConnection sqlConnection;
        SqlCommand sqlCommand;
        SqlDataReader dataReader;
        int i = 0;

        public void displayDataTest()
        {
            listViewDataTests.Items.Clear();
            sqlConnection.Open();
            sql = @"SELECT * FROM Tests";
            sqlCommand = new SqlCommand(sql, sqlConnection);
            dataReader = sqlCommand.ExecuteReader();

            i = 0;
            while (dataReader.Read())
            {
                listViewDataTests.Items.Add(dataReader[0].ToString());
                listViewDataTests.Items[i].SubItems.Add(dataReader[1].ToString());
                listViewDataTests.Items[i].SubItems.Add(dataReader[2].ToString());
                listViewDataTests.Items[i].SubItems.Add(dataReader[3].ToString());
                listViewDataTests.Items[i].SubItems.Add(dataReader[4].ToString());
                i++;
            }
            sqlConnection.Close();
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
            MessageBox.Show("This is practices page!", "E-Learning Application", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Practices_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(stringConnect);
            displayDataTest();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            Examing examing = new Examing();
            Examing.instance.testID = int.Parse(btnTest.Text);
            examing.Show();
        }

        private void listViewDataTests_Click(object sender, EventArgs e)
        {
            btnTest.Text = listViewDataTests.SelectedItems[0].SubItems[0].Text ;
        }
    }
}
