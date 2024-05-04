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
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("");
            this.CourseTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CreatedAt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.UpdateAt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CreatedBy = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CourseID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Level = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Description = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label5 = new System.Windows.Forms.Label();
            this.listViewDataCourses = new System.Windows.Forms.ListView();
            this.textBoxCreateBy = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnUpdateCourse = new System.Windows.Forms.Button();
            this.btnAddCourse = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ManageCourses = new System.Windows.Forms.Label();
            this.btnDeleteCourse = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxCourseID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxLabelCourse = new System.Windows.Forms.ComboBox();
            this.textBoxDescriptionCourse = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxCourseTitle = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CourseTitle
            // 
            this.CourseTitle.DisplayIndex = 1;
            this.CourseTitle.Text = "CourseTitle";
            this.CourseTitle.Width = 185;
            // 
            // CreatedAt
            // 
            this.CreatedAt.DisplayIndex = 6;
            this.CreatedAt.Text = "Created Date";
            this.CreatedAt.Width = 326;
            // 
            // UpdateAt
            // 
            this.UpdateAt.DisplayIndex = 5;
            this.UpdateAt.Text = "Update At";
            this.UpdateAt.Width = 0;
            // 
            // CreatedBy
            // 
            this.CreatedBy.DisplayIndex = 4;
            this.CreatedBy.Text = "Created By";
            this.CreatedBy.Width = 0;
            // 
            // CourseID
            // 
            this.CourseID.DisplayIndex = 0;
            this.CourseID.Text = "Course ID";
            this.CourseID.Width = 152;
            // 
            // Level
            // 
            this.Level.DisplayIndex = 3;
            this.Level.Text = "Level";
            this.Level.Width = 143;
            // 
            // Description
            // 
            this.Description.DisplayIndex = 2;
            this.Description.Text = "Description";
            this.Description.Width = 235;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(-101, 110);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Course ID";
            // 
            // listViewDataCourses
            // 
            this.listViewDataCourses.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Description,
            this.Level,
            this.CourseID,
            this.CreatedBy,
            this.UpdateAt,
            this.CreatedAt,
            this.CourseTitle});
            this.listViewDataCourses.HideSelection = false;
            this.listViewDataCourses.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem2});
            this.listViewDataCourses.Location = new System.Drawing.Point(397, 138);
            this.listViewDataCourses.Name = "listViewDataCourses";
            this.listViewDataCourses.Size = new System.Drawing.Size(682, 284);
            this.listViewDataCourses.TabIndex = 28;
            this.listViewDataCourses.UseCompatibleStateImageBehavior = false;
            this.listViewDataCourses.View = System.Windows.Forms.View.Details;
            // 
            // textBoxCreateBy
            // 
            this.textBoxCreateBy.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCreateBy.Location = new System.Drawing.Point(795, 451);
            this.textBoxCreateBy.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxCreateBy.Name = "textBoxCreateBy";
            this.textBoxCreateBy.Size = new System.Drawing.Size(293, 24);
            this.textBoxCreateBy.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(653, 454);
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
            this.btnUpdateCourse.Location = new System.Drawing.Point(216, 443);
            this.btnUpdateCourse.Name = "btnUpdateCourse";
            this.btnUpdateCourse.Size = new System.Drawing.Size(179, 45);
            this.btnUpdateCourse.TabIndex = 24;
            this.btnUpdateCourse.Text = "Update Course";
            this.btnUpdateCourse.UseVisualStyleBackColor = false;
            // 
            // btnAddCourse
            // 
            this.btnAddCourse.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnAddCourse.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCourse.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAddCourse.Location = new System.Drawing.Point(15, 443);
            this.btnAddCourse.Name = "btnAddCourse";
            this.btnAddCourse.Size = new System.Drawing.Size(165, 45);
            this.btnAddCourse.TabIndex = 23;
            this.btnAddCourse.Text = "Add Course";
            this.btnAddCourse.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-100, 327);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Level";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-100, 254);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Description";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-100, 182);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Course Title";
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
            this.btnDeleteCourse.Location = new System.Drawing.Point(441, 443);
            this.btnDeleteCourse.Name = "btnDeleteCourse";
            this.btnDeleteCourse.Size = new System.Drawing.Size(167, 45);
            this.btnDeleteCourse.TabIndex = 25;
            this.btnDeleteCourse.Text = "Delete Course";
            this.btnDeleteCourse.UseVisualStyleBackColor = false;
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
            this.textBoxCourseID.Location = new System.Drawing.Point(15, 170);
            this.textBoxCourseID.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxCourseID.Name = "textBoxCourseID";
            this.textBoxCourseID.Size = new System.Drawing.Size(292, 24);
            this.textBoxCourseID.TabIndex = 37;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 133);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 36;
            this.label6.Text = "Course ID";
            // 
            // comboBoxLabelCourse
            // 
            this.comboBoxLabelCourse.FormattingEnabled = true;
            this.comboBoxLabelCourse.Items.AddRange(new object[] {
            "Basic",
            "Independent",
            "Proficient"});
            this.comboBoxLabelCourse.Location = new System.Drawing.Point(16, 386);
            this.comboBoxLabelCourse.Name = "comboBoxLabelCourse";
            this.comboBoxLabelCourse.Size = new System.Drawing.Size(183, 21);
            this.comboBoxLabelCourse.TabIndex = 35;
            // 
            // textBoxDescriptionCourse
            // 
            this.textBoxDescriptionCourse.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDescriptionCourse.Location = new System.Drawing.Point(16, 315);
            this.textBoxDescriptionCourse.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxDescriptionCourse.Name = "textBoxDescriptionCourse";
            this.textBoxDescriptionCourse.Size = new System.Drawing.Size(293, 24);
            this.textBoxDescriptionCourse.TabIndex = 34;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 350);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 33;
            this.label7.Text = "Level";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 277);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 32;
            this.label8.Text = "Description";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 205);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 13);
            this.label9.TabIndex = 31;
            this.label9.Text = "Course Title";
            // 
            // textBoxCourseTitle
            // 
            this.textBoxCourseTitle.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCourseTitle.Location = new System.Drawing.Point(15, 242);
            this.textBoxCourseTitle.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxCourseTitle.Name = "textBoxCourseTitle";
            this.textBoxCourseTitle.Size = new System.Drawing.Size(292, 24);
            this.textBoxCourseTitle.TabIndex = 30;
            // 
            // CoursesManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 517);
            this.Controls.Add(this.textBoxCourseID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBoxLabelCourse);
            this.Controls.Add(this.textBoxDescriptionCourse);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxCourseTitle);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listViewDataCourses);
            this.Controls.Add(this.textBoxCreateBy);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnUpdateCourse);
            this.Controls.Add(this.btnAddCourse);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDeleteCourse);
            this.Controls.Add(this.panel1);
            this.Name = "CoursesManagement";
            this.Text = "CoursesManagement";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ColumnHeader CourseTitle;
        private System.Windows.Forms.ColumnHeader CreatedAt;
        private System.Windows.Forms.ColumnHeader UpdateAt;
        private System.Windows.Forms.ColumnHeader CreatedBy;
        private System.Windows.Forms.ColumnHeader CourseID;
        private System.Windows.Forms.ColumnHeader Level;
        private System.Windows.Forms.ColumnHeader Description;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListView listViewDataCourses;
        private System.Windows.Forms.TextBox textBoxCreateBy;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnUpdateCourse;
        private System.Windows.Forms.Button btnAddCourse;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ManageCourses;
        private System.Windows.Forms.Button btnDeleteCourse;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxCourseID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxLabelCourse;
        private System.Windows.Forms.TextBox textBoxDescriptionCourse;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxCourseTitle;
    }
}