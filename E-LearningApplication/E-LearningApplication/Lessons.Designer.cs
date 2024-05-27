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
            this.lessonsDataGridView = new System.Windows.Forms.DataGridView();
            this.noneLesson = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Lesson = new System.Windows.Forms.Label();
            this.btnRead = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.lessonsDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lessonsDataGridView
            // 
            this.lessonsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lessonsDataGridView.Location = new System.Drawing.Point(28, 97);
            this.lessonsDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.lessonsDataGridView.Name = "lessonsDataGridView";
            this.lessonsDataGridView.RowHeadersWidth = 51;
            this.lessonsDataGridView.RowTemplate.Height = 24;
            this.lessonsDataGridView.Size = new System.Drawing.Size(661, 250);
            this.lessonsDataGridView.TabIndex = 6;
            // 
            // noneLesson
            // 
            this.noneLesson.AutoSize = true;
            this.noneLesson.BackColor = System.Drawing.Color.DarkGray;
            this.noneLesson.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.noneLesson.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noneLesson.Location = new System.Drawing.Point(239, 214);
            this.noneLesson.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.noneLesson.Name = "noneLesson";
            this.noneLesson.Size = new System.Drawing.Size(227, 13);
            this.noneLesson.TabIndex = 8;
            this.noneLesson.Text = "(Lessons Of This Course Will Be Update Soon)";
            this.noneLesson.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel1.Controls.Add(this.Lesson);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(711, 86);
            this.panel1.TabIndex = 41;
            // 
            // Lesson
            // 
            this.Lesson.AutoSize = true;
            this.Lesson.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lesson.ForeColor = System.Drawing.Color.White;
            this.Lesson.Location = new System.Drawing.Point(314, 30);
            this.Lesson.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lesson.Name = "Lesson";
            this.Lesson.Size = new System.Drawing.Size(77, 23);
            this.Lesson.TabIndex = 0;
            this.Lesson.Text = "Lessons";
            // 
            // btnRead
            // 
            this.btnRead.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnRead.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRead.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRead.Location = new System.Drawing.Point(263, 374);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(167, 45);
            this.btnRead.TabIndex = 42;
            this.btnRead.Text = "Read";
            this.btnRead.UseVisualStyleBackColor = false;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // Lessons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 434);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.noneLesson);
            this.Controls.Add(this.lessonsDataGridView);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Lessons";
            this.Text = "Lessons";
            this.Load += new System.EventHandler(this.Lessons_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lessonsDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView lessonsDataGridView;
        private System.Windows.Forms.Label noneLesson;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Lesson;
        private System.Windows.Forms.Button btnRead;
    }
}