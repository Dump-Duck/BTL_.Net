namespace E_LearningApplication
{
    partial class ForumPost
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
            this.forumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blogPostToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blogManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPostBlog = new System.Windows.Forms.Button();
            this.panelBlogPost = new System.Windows.Forms.Panel();
            this.labelForumTitle = new System.Windows.Forms.Label();
            this.textTitleBox = new System.Windows.Forms.TextBox();
            this.textPostedBy = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.richContentBox = new System.Windows.Forms.RichTextBox();
            this.menuStrip.SuspendLayout();
            this.panelBlogPost.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.coursesToolStripMenuItem,
            this.practiceToolStripMenuItem,
            this.forumToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(735, 24);
            this.menuStrip.TabIndex = 12;
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
            this.blogPostToolStripMenuItem,
            this.blogManagementToolStripMenuItem});
            this.forumToolStripMenuItem.Name = "forumToolStripMenuItem";
            this.forumToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.forumToolStripMenuItem.Text = "Forum";
            // 
            // blogPostToolStripMenuItem
            // 
            this.blogPostToolStripMenuItem.Name = "blogPostToolStripMenuItem";
            this.blogPostToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.blogPostToolStripMenuItem.Text = "Blog Post";
            this.blogPostToolStripMenuItem.Click += new System.EventHandler(this.blogPostToolStripMenuItem_Click);
            // 
            // blogManagementToolStripMenuItem
            // 
            this.blogManagementToolStripMenuItem.Name = "blogManagementToolStripMenuItem";
            this.blogManagementToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.blogManagementToolStripMenuItem.Text = "Blog View";
            this.blogManagementToolStripMenuItem.Click += new System.EventHandler(this.blogManagementToolStripMenuItem_Click);
            // 
            // btnPostBlog
            // 
            this.btnPostBlog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnPostBlog.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPostBlog.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPostBlog.Location = new System.Drawing.Point(647, 18);
            this.btnPostBlog.Margin = new System.Windows.Forms.Padding(2);
            this.btnPostBlog.Name = "btnPostBlog";
            this.btnPostBlog.Size = new System.Drawing.Size(80, 36);
            this.btnPostBlog.TabIndex = 3;
            this.btnPostBlog.Text = "Post";
            this.btnPostBlog.UseVisualStyleBackColor = false;
            this.btnPostBlog.Click += new System.EventHandler(this.btnPostBlog_Click);
            // 
            // panelBlogPost
            // 
            this.panelBlogPost.BackColor = System.Drawing.Color.Moccasin;
            this.panelBlogPost.Controls.Add(this.labelForumTitle);
            this.panelBlogPost.Location = new System.Drawing.Point(0, 26);
            this.panelBlogPost.Margin = new System.Windows.Forms.Padding(2);
            this.panelBlogPost.Name = "panelBlogPost";
            this.panelBlogPost.Size = new System.Drawing.Size(735, 64);
            this.panelBlogPost.TabIndex = 13;
            // 
            // labelForumTitle
            // 
            this.labelForumTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelForumTitle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelForumTitle.Location = new System.Drawing.Point(253, 14);
            this.labelForumTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelForumTitle.Name = "labelForumTitle";
            this.labelForumTitle.Size = new System.Drawing.Size(219, 25);
            this.labelForumTitle.TabIndex = 11;
            this.labelForumTitle.Text = "Blog Post";
            this.labelForumTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textTitleBox
            // 
            this.textTitleBox.Location = new System.Drawing.Point(63, 18);
            this.textTitleBox.Margin = new System.Windows.Forms.Padding(2);
            this.textTitleBox.Name = "textTitleBox";
            this.textTitleBox.Size = new System.Drawing.Size(581, 20);
            this.textTitleBox.TabIndex = 9;
            // 
            // textPostedBy
            // 
            this.textPostedBy.Location = new System.Drawing.Point(74, 199);
            this.textPostedBy.Margin = new System.Windows.Forms.Padding(2);
            this.textPostedBy.Name = "textPostedBy";
            this.textPostedBy.Size = new System.Drawing.Size(136, 20);
            this.textPostedBy.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Linen;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.richContentBox);
            this.panel1.Controls.Add(this.textTitleBox);
            this.panel1.Controls.Add(this.btnPostBlog);
            this.panel1.Controls.Add(this.textPostedBy);
            this.panel1.Location = new System.Drawing.Point(0, 94);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(735, 224);
            this.panel1.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(2, 202);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Posted By:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(2, 41);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Content: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Title: ";
            // 
            // richContentBox
            // 
            this.richContentBox.Location = new System.Drawing.Point(63, 39);
            this.richContentBox.Margin = new System.Windows.Forms.Padding(2);
            this.richContentBox.Name = "richContentBox";
            this.richContentBox.Size = new System.Drawing.Size(581, 159);
            this.richContentBox.TabIndex = 11;
            this.richContentBox.Text = "";
            // 
            // ForumPost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 320);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.panelBlogPost);
            this.Controls.Add(this.panel1);
            this.Name = "ForumPost";
            this.Text = "ForumPost";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.panelBlogPost.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem coursesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem practiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem forumToolStripMenuItem;
        private System.Windows.Forms.Button btnPostBlog;
        private System.Windows.Forms.Panel panelBlogPost;
        private System.Windows.Forms.Label labelForumTitle;
        private System.Windows.Forms.TextBox textTitleBox;
        private System.Windows.Forms.TextBox textPostedBy;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richContentBox;
        private System.Windows.Forms.ToolStripMenuItem blogPostToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blogManagementToolStripMenuItem;
    }
}