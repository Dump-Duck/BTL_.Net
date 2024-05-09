namespace E_LearningApplication
{
    partial class MyCourses
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.coursesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.practiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.coursesDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.nullCourse = new System.Windows.Forms.LinkLabel();
            this.myCoursesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.examManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.coursesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.coursesToolStripMenuItem,
            this.practiceToolStripMenuItem,
            this.blogToolStripMenuItem,
            this.myCoursesToolStripMenuItem,
            this.examManagementToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(7, 4, 0, 4);
            this.menuStrip.Size = new System.Drawing.Size(1466, 42);
            this.menuStrip.TabIndex = 3;
            this.menuStrip.Text = "menuStrip";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(87, 34);
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // coursesToolStripMenuItem
            // 
            this.coursesToolStripMenuItem.Name = "coursesToolStripMenuItem";
            this.coursesToolStripMenuItem.Size = new System.Drawing.Size(104, 34);
            this.coursesToolStripMenuItem.Text = "Courses";
            this.coursesToolStripMenuItem.Click += new System.EventHandler(this.coursesToolStripMenuItem_Click);
            // 
            // practiceToolStripMenuItem
            // 
            this.practiceToolStripMenuItem.Name = "practiceToolStripMenuItem";
            this.practiceToolStripMenuItem.Size = new System.Drawing.Size(113, 34);
            this.practiceToolStripMenuItem.Text = "Practices";
            this.practiceToolStripMenuItem.Click += new System.EventHandler(this.practiceToolStripMenuItem_Click);
            // 
            // blogToolStripMenuItem
            // 
            this.blogToolStripMenuItem.Name = "blogToolStripMenuItem";
            this.blogToolStripMenuItem.Size = new System.Drawing.Size(90, 34);
            this.blogToolStripMenuItem.Text = "Forum";
            this.blogToolStripMenuItem.Click += new System.EventHandler(this.blogToolStripMenuItem_Click);
            // 
            // coursesDataGridView
            // 
            this.coursesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.coursesDataGridView.Location = new System.Drawing.Point(127, 336);
            this.coursesDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.coursesDataGridView.Name = "coursesDataGridView";
            this.coursesDataGridView.RowHeadersWidth = 51;
            this.coursesDataGridView.RowTemplate.Height = 24;
            this.coursesDataGridView.Size = new System.Drawing.Size(1212, 401);
            this.coursesDataGridView.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(606, 217);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 38);
            this.label1.TabIndex = 5;
            this.label1.Text = "My Courses";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // nullCourse
            // 
            this.nullCourse.AutoSize = true;
            this.nullCourse.BackColor = System.Drawing.Color.DarkGray;
            this.nullCourse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nullCourse.Location = new System.Drawing.Point(310, 519);
            this.nullCourse.Name = "nullCourse";
            this.nullCourse.Size = new System.Drawing.Size(862, 25);
            this.nullCourse.TabIndex = 6;
            this.nullCourse.TabStop = true;
            this.nullCourse.Text = ">> You do not enrolled any course at the moment. Please click here to see all cou" +
    "rses available <<";
            this.nullCourse.Visible = false;
            this.nullCourse.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.nullCourse_LinkClicked);
            // 
            // myCoursesToolStripMenuItem
            // 
            this.myCoursesToolStripMenuItem.Name = "myCoursesToolStripMenuItem";
            this.myCoursesToolStripMenuItem.Size = new System.Drawing.Size(139, 34);
            this.myCoursesToolStripMenuItem.Text = "My Courses";
            this.myCoursesToolStripMenuItem.Click += new System.EventHandler(this.myCoursesToolStripMenuItem_Click);
            // 
            // examManagementToolStripMenuItem
            // 
            this.examManagementToolStripMenuItem.Name = "examManagementToolStripMenuItem";
            this.examManagementToolStripMenuItem.Size = new System.Drawing.Size(211, 34);
            this.examManagementToolStripMenuItem.Text = "Exam Management";
            this.examManagementToolStripMenuItem.Click += new System.EventHandler(this.examManagementToolStripMenuItem_Click);
            // 
            // MyCourses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1466, 844);
            this.Controls.Add(this.nullCourse);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.coursesDataGridView);
            this.Controls.Add(this.menuStrip);
            this.Name = "MyCourses";
            this.Text = "My Courses";
            this.Load += new System.EventHandler(this.MyCourses_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.coursesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem coursesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem practiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blogToolStripMenuItem;
        private System.Windows.Forms.DataGridView coursesDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel nullCourse;
        private System.Windows.Forms.ToolStripMenuItem myCoursesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem examManagementToolStripMenuItem;
    }
}