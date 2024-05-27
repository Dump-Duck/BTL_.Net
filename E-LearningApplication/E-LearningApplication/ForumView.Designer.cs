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
            this.forumPostsTableAdapter = new E_LearningApplication.AppDataSetTableAdapters.ForumPostsTableAdapter();
            this.commentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appDataSet = new E_LearningApplication.AppDataSet();
            this.labelPostedBy = new System.Windows.Forms.Label();
            this.forumPostsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridBlogView = new System.Windows.Forms.DataGridView();
            this.labelForumTitle = new System.Windows.Forms.Label();
            this.panelBlogView = new System.Windows.Forms.Panel();
            this.btnEditCmt = new System.Windows.Forms.Button();
            this.commentsTableAdapter = new E_LearningApplication.AppDataSetTableAdapters.CommentsTableAdapter();
            this.btnCmt = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.textContentCmt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textUserIDCmt = new System.Windows.Forms.TextBox();
            this.labelUserIDCmt = new System.Windows.Forms.Label();
            this.textPostIDCmt = new System.Windows.Forms.TextBox();
            this.labelPostIDCmt = new System.Windows.Forms.Label();
            this.dataGridComments = new System.Windows.Forms.DataGridView();
            this.richContent = new System.Windows.Forms.RichTextBox();
            this.textTitle = new System.Windows.Forms.TextBox();
            this.textPostID = new System.Windows.Forms.TextBox();
            this.textPostedBy = new System.Windows.Forms.TextBox();
            this.btnDeleteBlog = new System.Windows.Forms.Button();
            this.btnEditBlog = new System.Windows.Forms.Button();
            this.labelContentBlog = new System.Windows.Forms.Label();
            this.labelTilteBlog = new System.Windows.Forms.Label();
            this.dataGridBlog = new System.Windows.Forms.DataGridView();
            this.labelPostID = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.commentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.forumPostsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBlogView)).BeginInit();
            this.panelBlogView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridComments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBlog)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // forumPostsTableAdapter
            // 
            this.forumPostsTableAdapter.ClearBeforeFill = true;
            // 
            // commentsBindingSource
            // 
            this.commentsBindingSource.DataMember = "Comments";
            this.commentsBindingSource.DataSource = this.appDataSet;
            // 
            // appDataSet
            // 
            this.appDataSet.DataSetName = "AppDataSet";
            this.appDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // appDataSetBindingSource
            // 
            this.appDataSetBindingSource.DataSource = this.appDataSet;
            this.appDataSetBindingSource.Position = 0;
            // 
            // dataGridBlogView
            // 
            this.dataGridBlogView.BackgroundColor = System.Drawing.Color.Cornsilk;
            this.dataGridBlogView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridBlogView.Location = new System.Drawing.Point(353, 64);
            this.dataGridBlogView.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridBlogView.Name = "dataGridBlogView";
            this.dataGridBlogView.RowHeadersWidth = 62;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dataGridBlogView.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridBlogView.RowTemplate.Height = 28;
            this.dataGridBlogView.Size = new System.Drawing.Size(515, 510);
            this.dataGridBlogView.TabIndex = 19;
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
            this.panelBlogView.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panelBlogView.Controls.Add(this.labelForumTitle);
            this.panelBlogView.Location = new System.Drawing.Point(-1, 0);
            this.panelBlogView.Margin = new System.Windows.Forms.Padding(2);
            this.panelBlogView.Name = "panelBlogView";
            this.panelBlogView.Size = new System.Drawing.Size(869, 64);
            this.panelBlogView.TabIndex = 18;
            // 
            // btnEditCmt
            // 
            this.btnEditCmt.Location = new System.Drawing.Point(1, 536);
            this.btnEditCmt.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditCmt.Name = "btnEditCmt";
            this.btnEditCmt.Size = new System.Drawing.Size(112, 38);
            this.btnEditCmt.TabIndex = 23;
            this.btnEditCmt.Text = "Edit CMT";
            this.btnEditCmt.UseVisualStyleBackColor = true;
            this.btnEditCmt.Click += new System.EventHandler(this.btnEditCmt_Click);
            // 
            // commentsTableAdapter
            // 
            this.commentsTableAdapter.ClearBeforeFill = true;
            // 
            // btnCmt
            // 
            this.btnCmt.Location = new System.Drawing.Point(228, 472);
            this.btnCmt.Margin = new System.Windows.Forms.Padding(2);
            this.btnCmt.Name = "btnCmt";
            this.btnCmt.Size = new System.Drawing.Size(112, 38);
            this.btnCmt.TabIndex = 20;
            this.btnCmt.Text = "Comment";
            this.btnCmt.UseVisualStyleBackColor = true;
            this.btnCmt.Click += new System.EventHandler(this.btnCmt_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(112, 472);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(119, 38);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = "Delete CMT";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // textContentCmt
            // 
            this.textContentCmt.Location = new System.Drawing.Point(185, 430);
            this.textContentCmt.Margin = new System.Windows.Forms.Padding(2);
            this.textContentCmt.Name = "textContentCmt";
            this.textContentCmt.Size = new System.Drawing.Size(156, 20);
            this.textContentCmt.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(124, 432);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Comment :";
            // 
            // textUserIDCmt
            // 
            this.textUserIDCmt.Location = new System.Drawing.Point(53, 452);
            this.textUserIDCmt.Margin = new System.Windows.Forms.Padding(2);
            this.textUserIDCmt.Name = "textUserIDCmt";
            this.textUserIDCmt.ReadOnly = true;
            this.textUserIDCmt.Size = new System.Drawing.Size(62, 20);
            this.textUserIDCmt.TabIndex = 17;
            // 
            // labelUserIDCmt
            // 
            this.labelUserIDCmt.AutoSize = true;
            this.labelUserIDCmt.Location = new System.Drawing.Point(5, 454);
            this.labelUserIDCmt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelUserIDCmt.Name = "labelUserIDCmt";
            this.labelUserIDCmt.Size = new System.Drawing.Size(46, 13);
            this.labelUserIDCmt.TabIndex = 16;
            this.labelUserIDCmt.Text = "User ID:";
            // 
            // textPostIDCmt
            // 
            this.textPostIDCmt.Location = new System.Drawing.Point(53, 432);
            this.textPostIDCmt.Margin = new System.Windows.Forms.Padding(2);
            this.textPostIDCmt.Name = "textPostIDCmt";
            this.textPostIDCmt.ReadOnly = true;
            this.textPostIDCmt.Size = new System.Drawing.Size(62, 20);
            this.textPostIDCmt.TabIndex = 15;
            // 
            // labelPostIDCmt
            // 
            this.labelPostIDCmt.AutoSize = true;
            this.labelPostIDCmt.Location = new System.Drawing.Point(5, 434);
            this.labelPostIDCmt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPostIDCmt.Name = "labelPostIDCmt";
            this.labelPostIDCmt.Size = new System.Drawing.Size(45, 13);
            this.labelPostIDCmt.TabIndex = 14;
            this.labelPostIDCmt.Text = "Post ID:";
            // 
            // dataGridComments
            // 
            this.dataGridComments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridComments.Location = new System.Drawing.Point(8, 297);
            this.dataGridComments.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridComments.Name = "dataGridComments";
            this.dataGridComments.RowHeadersWidth = 62;
            this.dataGridComments.RowTemplate.Height = 28;
            this.dataGridComments.Size = new System.Drawing.Size(332, 131);
            this.dataGridComments.TabIndex = 13;
            this.dataGridComments.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridComments_CellClick);
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
            this.textPostID.ReadOnly = true;
            this.textPostID.Size = new System.Drawing.Size(62, 20);
            this.textPostID.TabIndex = 8;
            // 
            // textPostedBy
            // 
            this.textPostedBy.Location = new System.Drawing.Point(211, 3);
            this.textPostedBy.Margin = new System.Windows.Forms.Padding(2);
            this.textPostedBy.Name = "textPostedBy";
            this.textPostedBy.ReadOnly = true;
            this.textPostedBy.Size = new System.Drawing.Size(68, 20);
            this.textPostedBy.TabIndex = 7;
            // 
            // btnDeleteBlog
            // 
            this.btnDeleteBlog.Location = new System.Drawing.Point(1, 199);
            this.btnDeleteBlog.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeleteBlog.Name = "btnDeleteBlog";
            this.btnDeleteBlog.Size = new System.Drawing.Size(51, 94);
            this.btnDeleteBlog.TabIndex = 6;
            this.btnDeleteBlog.Text = "Delete Blog";
            this.btnDeleteBlog.UseVisualStyleBackColor = true;
            this.btnDeleteBlog.Click += new System.EventHandler(this.btnDeleteBlog_Click);
            // 
            // btnEditBlog
            // 
            this.btnEditBlog.Location = new System.Drawing.Point(0, 105);
            this.btnEditBlog.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditBlog.Name = "btnEditBlog";
            this.btnEditBlog.Size = new System.Drawing.Size(54, 90);
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
            // dataGridBlog
            // 
            this.dataGridBlog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridBlog.Location = new System.Drawing.Point(354, 66);
            this.dataGridBlog.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridBlog.Name = "dataGridBlog";
            this.dataGridBlog.RowHeadersWidth = 62;
            this.dataGridBlog.RowTemplate.Height = 28;
            this.dataGridBlog.Size = new System.Drawing.Size(515, 508);
            this.dataGridBlog.TabIndex = 22;
            this.dataGridBlog.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridBlog_CellClick);
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
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btnCmt);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.textContentCmt);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textUserIDCmt);
            this.panel1.Controls.Add(this.labelUserIDCmt);
            this.panel1.Controls.Add(this.textPostIDCmt);
            this.panel1.Controls.Add(this.labelPostIDCmt);
            this.panel1.Controls.Add(this.dataGridComments);
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
            this.panel1.Location = new System.Drawing.Point(-1, 64);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 510);
            this.panel1.TabIndex = 21;
            // 
            // ForumView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 578);
            this.Controls.Add(this.panelBlogView);
            this.Controls.Add(this.btnEditCmt);
            this.Controls.Add(this.dataGridBlog);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridBlogView);
            this.Name = "ForumView";
            this.Text = "ForumView";
            this.Load += new System.EventHandler(this.ForumView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.commentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.forumPostsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBlogView)).EndInit();
            this.panelBlogView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridComments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBlog)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private AppDataSetTableAdapters.ForumPostsTableAdapter forumPostsTableAdapter;
        private System.Windows.Forms.BindingSource commentsBindingSource;
        private AppDataSet appDataSet;
        private System.Windows.Forms.Label labelPostedBy;
        private System.Windows.Forms.BindingSource forumPostsBindingSource;
        private System.Windows.Forms.BindingSource appDataSetBindingSource;
        private System.Windows.Forms.DataGridView dataGridBlogView;
        private System.Windows.Forms.Label labelForumTitle;
        private System.Windows.Forms.Panel panelBlogView;
        private System.Windows.Forms.Button btnEditCmt;
        private AppDataSetTableAdapters.CommentsTableAdapter commentsTableAdapter;
        private System.Windows.Forms.Button btnCmt;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox textContentCmt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textUserIDCmt;
        private System.Windows.Forms.Label labelUserIDCmt;
        private System.Windows.Forms.TextBox textPostIDCmt;
        private System.Windows.Forms.Label labelPostIDCmt;
        private System.Windows.Forms.DataGridView dataGridComments;
        private System.Windows.Forms.RichTextBox richContent;
        private System.Windows.Forms.TextBox textTitle;
        private System.Windows.Forms.TextBox textPostID;
        private System.Windows.Forms.TextBox textPostedBy;
        private System.Windows.Forms.Button btnDeleteBlog;
        private System.Windows.Forms.Button btnEditBlog;
        private System.Windows.Forms.Label labelContentBlog;
        private System.Windows.Forms.Label labelTilteBlog;
        private System.Windows.Forms.DataGridView dataGridBlog;
        private System.Windows.Forms.Label labelPostID;
        private System.Windows.Forms.Panel panel1;
    }
}