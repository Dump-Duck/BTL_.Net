namespace E_LearningApplication
{
    partial class CoursesManagement
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            this.CreateAt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.UpdateAt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CreatedBy = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CourseID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Level = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Description = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewDataCourses = new System.Windows.Forms.ListView();
            this.CourseName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Lessons = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBoxCreateBy = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnUpdateCourse = new System.Windows.Forms.Button();
            this.btnAddCourse = new System.Windows.Forms.Button();
            this.ManageCourses = new System.Windows.Forms.Label();
            this.btnDeleteCourse = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxCourseID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxLevelCourse = new System.Windows.Forms.ComboBox();
            this.textBoxDescriptionCourse = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxCourseName = new System.Windows.Forms.TextBox();
            this.btnLesson = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CreateAt
            // 
            this.CreateAt.Text = "Create At";
            this.CreateAt.Width = 113;
            // 
            // UpdateAt
            // 
            this.UpdateAt.Text = "Update At";
            this.UpdateAt.Width = 107;
            // 
            // CreatedBy
            // 
            this.CreatedBy.Text = "Created By";
            this.CreatedBy.Width = 103;
            // 
            // CourseID
            // 
            this.CourseID.Text = "Course ID";
            this.CourseID.Width = 63;
            // 
            // Level
            // 
            this.Level.Text = "Level";
            this.Level.Width = 98;
            // 
            // Description
            // 
            this.Description.Text = "Description";
            this.Description.Width = 101;
            // 
            // listViewDataCourses
            // 
            this.listViewDataCourses.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CourseID,
            this.CourseName,
            this.Description,
            this.Level,
            this.CreatedBy,
            this.UpdateAt,
            this.CreateAt,
            this.Lessons});
            this.listViewDataCourses.HideSelection = false;
            this.listViewDataCourses.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.listViewDataCourses.Location = new System.Drawing.Point(337, 135);
            this.listViewDataCourses.Name = "listViewDataCourses";
            this.listViewDataCourses.Size = new System.Drawing.Size(742, 284);
            this.listViewDataCourses.TabIndex = 28;
            this.listViewDataCourses.UseCompatibleStateImageBehavior = false;
            this.listViewDataCourses.View = System.Windows.Forms.View.Details;
            this.listViewDataCourses.Click += new System.EventHandler(this.listViewDataCourses_Click);
            // 
            // CourseName
            // 
            this.CourseName.Text = "Course Name";
            this.CourseName.Width = 106;
            // 
            // Lessons
            // 
            this.Lessons.Text = "Lessons";
            this.Lessons.Width = 83;
            // 
            // textBoxCreateBy
            // 
            this.textBoxCreateBy.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCreateBy.Location = new System.Drawing.Point(797, 453);
            this.textBoxCreateBy.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxCreateBy.Name = "textBoxCreateBy";
            this.textBoxCreateBy.Size = new System.Drawing.Size(293, 24);
            this.textBoxCreateBy.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(721, 458);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Created By";
            // 
            // btnUpdateCourse
            // 
            this.btnUpdateCourse.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnUpdateCourse.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateCourse.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnUpdateCourse.Location = new System.Drawing.Point(188, 445);
            this.btnUpdateCourse.Name = "btnUpdateCourse";
            this.btnUpdateCourse.Size = new System.Drawing.Size(179, 45);
            this.btnUpdateCourse.TabIndex = 24;
            this.btnUpdateCourse.Text = "Update Course";
            this.btnUpdateCourse.UseVisualStyleBackColor = false;
            this.btnUpdateCourse.Click += new System.EventHandler(this.btnUpdateCourse_Click);
            // 
            // btnAddCourse
            // 
            this.btnAddCourse.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnAddCourse.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCourse.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAddCourse.Location = new System.Drawing.Point(17, 445);
            this.btnAddCourse.Name = "btnAddCourse";
            this.btnAddCourse.Size = new System.Drawing.Size(165, 45);
            this.btnAddCourse.TabIndex = 23;
            this.btnAddCourse.Text = "Add Course";
            this.btnAddCourse.UseVisualStyleBackColor = false;
            this.btnAddCourse.Click += new System.EventHandler(this.btnAddCourse_Click);
            // 
            // ManageCourses
            // 
            this.ManageCourses.AutoSize = true;
            this.ManageCourses.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManageCourses.ForeColor = System.Drawing.Color.White;
            this.ManageCourses.Location = new System.Drawing.Point(455, 26);
            this.ManageCourses.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ManageCourses.Name = "ManageCourses";
            this.ManageCourses.Size = new System.Drawing.Size(161, 23);
            this.ManageCourses.TabIndex = 0;
            this.ManageCourses.Text = "ManageCourses";
            // 
            // btnDeleteCourse
            // 
            this.btnDeleteCourse.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnDeleteCourse.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteCourse.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDeleteCourse.Location = new System.Drawing.Point(373, 445);
            this.btnDeleteCourse.Name = "btnDeleteCourse";
            this.btnDeleteCourse.Size = new System.Drawing.Size(167, 45);
            this.btnDeleteCourse.TabIndex = 25;
            this.btnDeleteCourse.Text = "Delete Course";
            this.btnDeleteCourse.UseVisualStyleBackColor = false;
            this.btnDeleteCourse.Click += new System.EventHandler(this.btnDeleteCourse_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel1.Controls.Add(this.ManageCourses);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1101, 86);
            this.panel1.TabIndex = 16;
            // 
            // textBoxCourseID
            // 
            this.textBoxCourseID.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCourseID.Location = new System.Drawing.Point(17, 172);
            this.textBoxCourseID.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxCourseID.Name = "textBoxCourseID";
            this.textBoxCourseID.Size = new System.Drawing.Size(292, 24);
            this.textBoxCourseID.TabIndex = 37;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 135);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 36;
            this.label6.Text = "Course ID";
            // 
            // comboBoxLevelCourse
            // 
            this.comboBoxLevelCourse.FormattingEnabled = true;
            this.comboBoxLevelCourse.Items.AddRange(new object[] {
            "Basic",
            "Independent",
            "Proficient"});
            this.comboBoxLevelCourse.Location = new System.Drawing.Point(18, 388);
            this.comboBoxLevelCourse.Name = "comboBoxLevelCourse";
            this.comboBoxLevelCourse.Size = new System.Drawing.Size(183, 21);
            this.comboBoxLevelCourse.TabIndex = 35;
            // 
            // textBoxDescriptionCourse
            // 
            this.textBoxDescriptionCourse.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDescriptionCourse.Location = new System.Drawing.Point(18, 317);
            this.textBoxDescriptionCourse.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxDescriptionCourse.Name = "textBoxDescriptionCourse";
            this.textBoxDescriptionCourse.Size = new System.Drawing.Size(293, 24);
            this.textBoxDescriptionCourse.TabIndex = 34;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 352);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 33;
            this.label7.Text = "Level";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 279);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 32;
            this.label8.Text = "Description";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 207);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 13);
            this.label9.TabIndex = 31;
            this.label9.Text = "Course Name";
            // 
            // textBoxCourseName
            // 
            this.textBoxCourseName.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCourseName.Location = new System.Drawing.Point(17, 244);
            this.textBoxCourseName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxCourseName.Name = "textBoxCourseName";
            this.textBoxCourseName.Size = new System.Drawing.Size(292, 24);
            this.textBoxCourseName.TabIndex = 30;
            // 
            // btnLesson
            // 
            this.btnLesson.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnLesson.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLesson.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLesson.Location = new System.Drawing.Point(546, 445);
            this.btnLesson.Name = "btnLesson";
            this.btnLesson.Size = new System.Drawing.Size(167, 45);
            this.btnLesson.TabIndex = 38;
            this.btnLesson.Text = "Lesson";
            this.btnLesson.UseVisualStyleBackColor = false;
            this.btnLesson.Click += new System.EventHandler(this.btnAddLesson_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // CoursesManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 517);
            this.Controls.Add(this.btnLesson);
            this.Controls.Add(this.textBoxCourseID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBoxLevelCourse);
            this.Controls.Add(this.textBoxDescriptionCourse);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxCourseName);
            this.Controls.Add(this.listViewDataCourses);
            this.Controls.Add(this.textBoxCreateBy);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnUpdateCourse);
            this.Controls.Add(this.btnAddCourse);
            this.Controls.Add(this.btnDeleteCourse);
            this.Controls.Add(this.panel1);
            this.Name = "CoursesManagement";
            this.Text = "CoursesManagement";
            this.Load += new System.EventHandler(this.CoursesManagement_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ColumnHeader CreateAt;
        private System.Windows.Forms.ColumnHeader UpdateAt;
        private System.Windows.Forms.ColumnHeader CreatedBy;
        private System.Windows.Forms.ColumnHeader CourseID;
        private System.Windows.Forms.ColumnHeader Level;
        private System.Windows.Forms.ColumnHeader Description;
        private System.Windows.Forms.ListView listViewDataCourses;
        private System.Windows.Forms.TextBox textBoxCreateBy;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnUpdateCourse;
        private System.Windows.Forms.Button btnAddCourse;
        private System.Windows.Forms.Label ManageCourses;
        private System.Windows.Forms.Button btnDeleteCourse;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxCourseID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxLevelCourse;
        private System.Windows.Forms.TextBox textBoxDescriptionCourse;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxCourseName;
        private System.Windows.Forms.ColumnHeader CourseName;
        private System.Windows.Forms.ColumnHeader Lessons;
        private System.Windows.Forms.Button btnLesson;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}