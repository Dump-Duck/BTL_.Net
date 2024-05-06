namespace E_LearningApplication
{
    partial class ForumView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.textPostedAt = new System.Windows.Forms.TextBox();
            this.labelPostedAt = new System.Windows.Forms.Label();
            this.richContent = new System.Windows.Forms.RichTextBox();
            this.textTitle = new System.Windows.Forms.TextBox();
            this.textPostID = new System.Windows.Forms.TextBox();
            this.textPostedBy = new System.Windows.Forms.TextBox();
            this.btnDeleteBlog = new System.Windows.Forms.Button();
            this.btnEditBlog = new System.Windows.Forms.Button();
            this.labelContentBlog = new System.Windows.Forms.Label();
            this.labelTilteBlog = new System.Windows.Forms.Label();
            this.labelPostID = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelPostedBy = new System.Windows.Forms.Label();
            this.forumPostsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridBlogView = new System.Windows.Forms.DataGridView();
            this.labelForumTitle = new System.Windows.Forms.Label();
            this.panelBlogView = new System.Windows.Forms.Panel();
            this.blogViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blogPostToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.forumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.practiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.coursesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.appDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appDataSet = new E_LearningApplication.AppDataSet();
            this.forumPostsTableAdapter = new E_LearningApplication.AppDataSetTableAdapters.ForumPostsTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.forumPostsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBlogView)).BeginInit();
            this.panelBlogView.SuspendLayout();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // textPostedAt
            // 
            this.textPostedAt.Location = new System.Drawing.Point(228, 301);
            this.textPostedAt.Margin = new System.Windows.Forms.Padding(2);
            this.textPostedAt.Name = "textPostedAt";
            this.textPostedAt.Size = new System.Drawing.Size(113, 20);
            this.textPostedAt.TabIndex = 12;
            // 
            // labelPostedAt
            // 
            this.labelPostedAt.AutoSize = true;
            this.labelPostedAt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPostedAt.Location = new System.Drawing.Point(162, 302);
            this.labelPostedAt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPostedAt.Name = "labelPostedAt";
            this.labelPostedAt.Size = new System.Drawing.Size(61, 15);
            this.labelPostedAt.TabIndex = 11;
            this.labelPostedAt.Text = "Posted At:";
            // 
            // richContent
            // 
            this.richContent.Location = new System.Drawing.Point(53, 51);
            this.richContent.Margin = new System.Windows.Forms.Padding(2);
            this.richContent.Name = "richContent";
            this.richContent.Size = new System.Drawing.Size(288, 244);
            this.richContent.TabIndex = 10;
            this.richContent.Text = "";
            // 
            // textTitle
            // 
            this.textTitle.Location = new System.Drawing.Point(53, 24);
            this.textTitle.Margin = new System.Windows.Forms.Padding(2);
            this.textTitle.Name = "textTitle";
            this.textTitle.Size = new System.Drawing.Size(288, 20);
            this.textTitle.TabIndex = 9;
            // 
            // textPostID
            // 
            this.textPostID.Location = new System.Drawing.Point(53, 3);
            this.textPostID.Margin = new System.Windows.Forms.Padding(2);
            this.textPostID.Name = "textPostID";
            this.textPostID.Size = new System.Drawing.Size(62, 20);
            this.textPostID.TabIndex = 8;
            // 
            // textPostedBy
            // 
            this.textPostedBy.Location = new System.Drawing.Point(211, 3);
            this.textPostedBy.Margin = new System.Windows.Forms.Padding(2);
            this.textPostedBy.Name = "textPostedBy";
            this.textPostedBy.Size = new System.Drawing.Size(68, 20);
            this.textPostedBy.TabIndex = 7;
            // 
            // btnDeleteBlog
            // 
            this.btnDeleteBlog.Location = new System.Drawing.Point(178, 322);
            this.btnDeleteBlog.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeleteBlog.Name = "btnDeleteBlog";
            this.btnDeleteBlog.Size = new System.Drawing.Size(172, 25);
            this.btnDeleteBlog.TabIndex = 6;
            this.btnDeleteBlog.Text = "Delete Blog";
            this.btnDeleteBlog.UseVisualStyleBackColor = true;
            this.btnDeleteBlog.Click += new System.EventHandler(this.btnDeleteBlog_Click);
            // 
            // btnEditBlog
            // 
            this.btnEditBlog.Location = new System.Drawing.Point(0, 322);
            this.btnEditBlog.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditBlog.Name = "btnEditBlog";
            this.btnEditBlog.Size = new System.Drawing.Size(174, 25);
            this.btnEditBlog.TabIndex = 4;
            this.btnEditBlog.Text = "Edit Blog";
            this.btnEditBlog.UseVisualStyleBackColor = true;
            this.btnEditBlog.Click += new System.EventHandler(this.btnEditBlog_Click);
            // 
            // labelContentBlog
            // 
            this.labelContentBlog.AutoSize = true;
            this.labelContentBlog.Location = new System.Drawing.Point(5, 53);
            this.labelContentBlog.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelContentBlog.Name = "labelContentBlog";
            this.labelContentBlog.Size = new System.Drawing.Size(47, 13);
            this.labelContentBlog.TabIndex = 3;
            this.labelContentBlog.Text = "Content:";
            // 
            // labelTilteBlog
            // 
            this.labelTilteBlog.AutoSize = true;
            this.labelTilteBlog.Location = new System.Drawing.Point(5, 24);
            this.labelTilteBlog.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTilteBlog.Name = "labelTilteBlog";
            this.labelTilteBlog.Size = new System.Drawing.Size(30, 13);
            this.labelTilteBlog.TabIndex = 2;
            this.labelTilteBlog.Text = "Title:";
            // 
            // labelPostID
            // 
            this.labelPostID.AutoSize = true;
            this.labelPostID.Location = new System.Drawing.Point(5, 5);
            this.labelPostID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPostID.Name = "labelPostID";
            this.labelPostID.Size = new System.Drawing.Size(45, 13);
            this.labelPostID.TabIndex = 0;
            this.labelPostID.Text = "Post ID:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.OldLace;
            this.panel1.Controls.Add(this.textPostedAt);
            this.panel1.Controls.Add(this.labelPostedAt);
            this.panel1.Controls.Add(this.richContent);
            this.panel1.Controls.Add(this.textTitle);
            this.panel1.Controls.Add(this.textPostID);
            this.panel1.Controls.Add(this.textPostedBy);
            this.panel1.Controls.Add(this.btnDeleteBlog);
            this.panel1.Controls.Add(this.btnEditBlog);
            this.panel1.Controls.Add(this.labelContentBlog);
            this.panel1.Controls.Add(this.labelTilteBlog);
            this.panel1.Controls.Add(this.labelPostedBy);
            this.panel1.Controls.Add(this.labelPostID);
            this.panel1.Location = new System.Drawing.Point(0, 97);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 349);
            this.panel1.TabIndex = 14;
            // 
            // labelPostedBy
            // 
            this.labelPostedBy.AutoSize = true;
            this.labelPostedBy.Location = new System.Drawing.Point(150, 5);
            this.labelPostedBy.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPostedBy.Name = "labelPostedBy";
            this.labelPostedBy.Size = new System.Drawing.Size(58, 13);
            this.labelPostedBy.TabIndex = 1;
            this.labelPostedBy.Text = "Posted By:";
            // 
            // forumPostsBindingSource
            // 
            this.forumPostsBindingSource.DataMember = "ForumPosts";
            this.forumPostsBindingSource.DataSource = this.appDataSetBindingSource;
            // 
            // dataGridBlogView
            // 
            this.dataGridBlogView.BackgroundColor = System.Drawing.Color.Cornsilk;
            this.dataGridBlogView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridBlogView.Location = new System.Drawing.Point(354, 97);
            this.dataGridBlogView.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridBlogView.Name = "dataGridBlogView";
            this.dataGridBlogView.RowHeadersWidth = 62;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dataGridBlogView.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridBlogView.RowTemplate.Height = 28;
            this.dataGridBlogView.Size = new System.Drawing.Size(515, 349);
            this.dataGridBlogView.TabIndex = 13;
            this.dataGridBlogView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridBlogView_CellClick);
            // 
            // labelForumTitle
            // 
            this.labelForumTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelForumTitle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelForumTitle.Location = new System.Drawing.Point(311, 20);
            this.labelForumTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelForumTitle.Name = "labelForumTitle";
            this.labelForumTitle.Size = new System.Drawing.Size(219, 25);
            this.labelForumTitle.TabIndex = 11;
            this.labelForumTitle.Text = "Blog View";
            this.labelForumTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelBlogView
            // 
            this.panelBlogView.BackColor = System.Drawing.Color.Moccasin;
            this.panelBlogView.Controls.Add(this.labelForumTitle);
            this.panelBlogView.Location = new System.Drawing.Point(0, 29);
            this.panelBlogView.Margin = new System.Windows.Forms.Padding(2);
            this.panelBlogView.Name = "panelBlogView";
            this.panelBlogView.Size = new System.Drawing.Size(869, 64);
            this.panelBlogView.TabIndex = 12;
            // 
            // blogViewToolStripMenuItem
            // 
            this.blogViewToolStripMenuItem.Name = "blogViewToolStripMenuItem";
            this.blogViewToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.blogViewToolStripMenuItem.Text = "Blog View";
            this.blogViewToolStripMenuItem.Click += new System.EventHandler(this.blogManagementToolStripMenuItem_Click);
            // 
            // blogPostToolStripMenuItem
            // 
            this.blogPostToolStripMenuItem.Name = "blogPostToolStripMenuItem";
            this.blogPostToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.blogPostToolStripMenuItem.Text = "Blog Post";
            this.blogPostToolStripMenuItem.Click += new System.EventHandler(this.blogPostToolStripMenuItem_Click);
            // 
            // forumToolStripMenuItem
            // 
            this.forumToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.blogPostToolStripMenuItem,
            this.blogViewToolStripMenuItem});
            this.forumToolStripMenuItem.Name = "forumToolStripMenuItem";
            this.forumToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.forumToolStripMenuItem.Text = "Forum";
            // 
            // practiceToolStripMenuItem
            // 
            this.practiceToolStripMenuItem.Name = "practiceToolStripMenuItem";
            this.practiceToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.practiceToolStripMenuItem.Text = "Practices";
            this.practiceToolStripMenuItem.Click += new System.EventHandler(this.practiceToolStripMenuItem_Click);
            // 
            // coursesToolStripMenuItem
            // 
            this.coursesToolStripMenuItem.Name = "coursesToolStripMenuItem";
            this.coursesToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.coursesToolStripMenuItem.Text = "Courses";
            this.coursesToolStripMenuItem.Click += new System.EventHandler(this.coursesToolStripMenuItem_Click);
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
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
            this.menuStrip.Size = new System.Drawing.Size(870, 24);
            this.menuStrip.TabIndex = 11;
            this.menuStrip.Text = "menuStrip";
            // 
            // appDataSetBindingSource
            // 
            this.appDataSetBindingSource.DataSource = this.appDataSet;
            this.appDataSetBindingSource.Position = 0;
            // 
            // appDataSet
            // 
            this.appDataSet.DataSetName = "AppDataSet";
            this.appDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // forumPostsTableAdapter
            // 
            this.forumPostsTableAdapter.ClearBeforeFill = true;
            // 
            // ForumView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridBlogView);
            this.Controls.Add(this.panelBlogView);
            this.Controls.Add(this.menuStrip);
            this.Name = "ForumView";
            this.Text = "ForumView";
            this.Load += new System.EventHandler(this.ForumView_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.forumPostsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBlogView)).EndInit();
            this.panelBlogView.ResumeLayout(false);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textPostedAt;
        private System.Windows.Forms.Label labelPostedAt;
        private System.Windows.Forms.RichTextBox richContent;
        private System.Windows.Forms.TextBox textTitle;
        private System.Windows.Forms.TextBox textPostID;
        private System.Windows.Forms.TextBox textPostedBy;
        private System.Windows.Forms.Button btnDeleteBlog;
        private System.Windows.Forms.Button btnEditBlog;
        private System.Windows.Forms.Label labelContentBlog;
        private System.Windows.Forms.Label labelTilteBlog;
        private System.Windows.Forms.Label labelPostID;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelPostedBy;
        private AppDataSetTableAdapters.ForumPostsTableAdapter forumPostsTableAdapter;
        private AppDataSet appDataSet;
        private System.Windows.Forms.BindingSource appDataSetBindingSource;
        private System.Windows.Forms.BindingSource forumPostsBindingSource;
        private System.Windows.Forms.DataGridView dataGridBlogView;
        private System.Windows.Forms.Label labelForumTitle;
        private System.Windows.Forms.Panel panelBlogView;
        private System.Windows.Forms.ToolStripMenuItem blogViewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blogPostToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem forumToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem practiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem coursesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip;
    }
}