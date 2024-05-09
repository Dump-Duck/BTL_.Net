namespace E_LearningApplication
{
    partial class Lessons
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
            this.label1 = new System.Windows.Forms.Label();
            this.lessonsDataGridView = new System.Windows.Forms.DataGridView();
            this.noneLesson = new System.Windows.Forms.Label();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lessonsDataGridView)).BeginInit();
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
            this.forumToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(7, 4, 0, 4);
            this.menuStrip.Size = new System.Drawing.Size(1304, 42);
            this.menuStrip.TabIndex = 5;
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
            // forumToolStripMenuItem
            // 
            this.forumToolStripMenuItem.Name = "forumToolStripMenuItem";
            this.forumToolStripMenuItem.Size = new System.Drawing.Size(90, 34);
            this.forumToolStripMenuItem.Text = "Forum";
            this.forumToolStripMenuItem.Click += new System.EventHandler(this.forumToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(554, 174);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 38);
            this.label1.TabIndex = 7;
            this.label1.Text = "Lessons";
            // 
            // lessonsDataGridView
            // 
            this.lessonsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lessonsDataGridView.Location = new System.Drawing.Point(48, 277);
            this.lessonsDataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lessonsDataGridView.Name = "lessonsDataGridView";
            this.lessonsDataGridView.RowHeadersWidth = 51;
            this.lessonsDataGridView.RowTemplate.Height = 24;
            this.lessonsDataGridView.Size = new System.Drawing.Size(1212, 401);
            this.lessonsDataGridView.TabIndex = 6;
            // 
            // noneLesson
            // 
            this.noneLesson.AutoSize = true;
            this.noneLesson.BackColor = System.Drawing.Color.DarkGray;
            this.noneLesson.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.noneLesson.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noneLesson.Location = new System.Drawing.Point(442, 477);
            this.noneLesson.Name = "noneLesson";
            this.noneLesson.Size = new System.Drawing.Size(424, 25);
            this.noneLesson.TabIndex = 8;
            this.noneLesson.Text = "(Lessons Of This Course Will Be Update Soon)";
            this.noneLesson.Visible = false;
            // 
            // Lessons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1304, 711);
            this.Controls.Add(this.noneLesson);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lessonsDataGridView);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Lessons";
            this.Text = "Lessons";
            this.Load += new System.EventHandler(this.Lessons_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lessonsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem coursesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem practiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem forumToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView lessonsDataGridView;
        private System.Windows.Forms.Label noneLesson;
    }
}