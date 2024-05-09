namespace E_LearningApplication
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.coursesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.practiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.forumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.myCourses = new System.Windows.Forms.ToolStripMenuItem();
            this.coursesManagement = new System.Windows.Forms.ToolStripMenuItem();
            this.usersManagement = new System.Windows.Forms.ToolStripMenuItem();
            this.examManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.myCoursesBtn = new System.Windows.Forms.Button();
            this.practiceBtn = new System.Windows.Forms.Button();
            this.resultBtn = new System.Windows.Forms.Button();
            this.blogViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blogPostToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.coursesToolStripMenuItem,
            this.practiceToolStripMenuItem,
            this.forumToolStripMenuItem,
            this.myCourses,
            this.coursesManagement,
            this.usersManagement,
            this.examManagementToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(716, 24);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // coursesToolStripMenuItem
            // 
            this.coursesToolStripMenuItem.Name = "coursesToolStripMenuItem";
            this.coursesToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.coursesToolStripMenuItem.Text = "Courses";
            this.coursesToolStripMenuItem.Click += new System.EventHandler(this.coursesToolStripMenuItem_Click);
            // 
            // practiceToolStripMenuItem
            // 
            this.practiceToolStripMenuItem.Name = "practiceToolStripMenuItem";
            this.practiceToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.practiceToolStripMenuItem.Text = "Practices";
            this.practiceToolStripMenuItem.Click += new System.EventHandler(this.practiceToolStripMenuItem_Click);
            // 
            // forumToolStripMenuItem
            // 
            this.forumToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.blogViewToolStripMenuItem,
            this.blogPostToolStripMenuItem});
            this.forumToolStripMenuItem.Name = "forumToolStripMenuItem";
            this.forumToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.forumToolStripMenuItem.Text = "Forum";
            // 
            // myCourses
            // 
            this.myCourses.Name = "myCourses";
            this.myCourses.Size = new System.Drawing.Size(81, 20);
            this.myCourses.Text = "My Courses";
            this.myCourses.Click += new System.EventHandler(this.myCourses_Click);
            // 
            // coursesManagement
            // 
            this.coursesManagement.Name = "coursesManagement";
            this.coursesManagement.Size = new System.Drawing.Size(135, 20);
            this.coursesManagement.Text = "Courses Management";
            this.coursesManagement.Click += new System.EventHandler(this.coursesManagement_Click);
            // 
            // usersManagement
            // 
            this.usersManagement.Name = "usersManagement";
            this.usersManagement.Size = new System.Drawing.Size(121, 20);
            this.usersManagement.Text = "Users Management";
            this.usersManagement.Click += new System.EventHandler(this.usersManagement_Click);
            // 
            // examManagementToolStripMenuItem
            // 
            this.examManagementToolStripMenuItem.Name = "examManagementToolStripMenuItem";
            this.examManagementToolStripMenuItem.Size = new System.Drawing.Size(122, 20);
            this.examManagementToolStripMenuItem.Text = "Exam Management";
            this.examManagementToolStripMenuItem.Click += new System.EventHandler(this.examManagementToolStripMenuItem_Click);
            // 
            // myCoursesBtn
            // 
            this.myCoursesBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.myCoursesBtn.Location = new System.Drawing.Point(9, 273);
            this.myCoursesBtn.Margin = new System.Windows.Forms.Padding(2);
            this.myCoursesBtn.Name = "myCoursesBtn";
            this.myCoursesBtn.Size = new System.Drawing.Size(202, 106);
            this.myCoursesBtn.TabIndex = 2;
            this.myCoursesBtn.Text = "My Courses";
            this.myCoursesBtn.UseVisualStyleBackColor = true;
            this.myCoursesBtn.Click += new System.EventHandler(this.myCoursesBtn_Click);
            // 
            // practiceBtn
            // 
            this.practiceBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.practiceBtn.Location = new System.Drawing.Point(257, 273);
            this.practiceBtn.Margin = new System.Windows.Forms.Padding(2);
            this.practiceBtn.Name = "practiceBtn";
            this.practiceBtn.Size = new System.Drawing.Size(202, 106);
            this.practiceBtn.TabIndex = 3;
            this.practiceBtn.Text = "Practice";
            this.practiceBtn.UseVisualStyleBackColor = true;
            this.practiceBtn.Click += new System.EventHandler(this.practiceBtn_Click);
            // 
            // resultBtn
            // 
            this.resultBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.resultBtn.Location = new System.Drawing.Point(505, 273);
            this.resultBtn.Margin = new System.Windows.Forms.Padding(2);
            this.resultBtn.Name = "resultBtn";
            this.resultBtn.Size = new System.Drawing.Size(202, 106);
            this.resultBtn.TabIndex = 4;
            this.resultBtn.Text = "Results";
            this.resultBtn.UseVisualStyleBackColor = true;
            this.resultBtn.Click += new System.EventHandler(this.resultBtn_Click);
            // 
            // blogViewToolStripMenuItem
            // 
            this.blogViewToolStripMenuItem.Name = "blogViewToolStripMenuItem";
            this.blogViewToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.blogViewToolStripMenuItem.Text = "Blog View";
            this.blogViewToolStripMenuItem.Click += new System.EventHandler(this.blogViewToolStripMenuItem_Click);
            // 
            // blogPostToolStripMenuItem
            // 
            this.blogPostToolStripMenuItem.Name = "blogPostToolStripMenuItem";
            this.blogPostToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.blogPostToolStripMenuItem.Text = "Blog Post";
            this.blogPostToolStripMenuItem.Click += new System.EventHandler(this.blogPostToolStripMenuItem_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(716, 408);
            this.Controls.Add(this.resultBtn);
            this.Controls.Add(this.practiceBtn);
            this.Controls.Add(this.myCoursesBtn);
            this.Controls.Add(this.menuStrip);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Home";
            this.Text = "Home";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem coursesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem practiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem forumToolStripMenuItem;
        private System.Windows.Forms.Button myCoursesBtn;
        private System.Windows.Forms.Button practiceBtn;
        private System.Windows.Forms.Button resultBtn;
        private System.Windows.Forms.ToolStripMenuItem coursesManagement;
        private System.Windows.Forms.ToolStripMenuItem myCourses;
        private System.Windows.Forms.ToolStripMenuItem usersManagement;
        private System.Windows.Forms.ToolStripMenuItem examManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blogViewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blogPostToolStripMenuItem;
    }
}

