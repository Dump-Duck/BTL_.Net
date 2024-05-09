namespace E_LearningApplication
{
    partial class ExamingManagement
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
            this.TestName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TestID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ManageCourses = new System.Windows.Forms.Label();
            this.Content = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.UserId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CreateAt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label3 = new System.Windows.Forms.Label();
            this.btnUpdateExam = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.btnDeleteExam = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddExam = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxExamID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxExamName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.listViewDataExams = new System.Windows.Forms.ListView();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TestName
            // 
            this.TestName.Text = "Test Name";
            this.TestName.Width = 146;
            // 
            // TestID
            // 
            this.TestID.Text = "Test ID";
            this.TestID.Width = 103;
            // 
            // ManageCourses
            // 
            this.ManageCourses.AutoSize = true;
            this.ManageCourses.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManageCourses.ForeColor = System.Drawing.Color.White;
            this.ManageCourses.Location = new System.Drawing.Point(382, 27);
            this.ManageCourses.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ManageCourses.Name = "ManageCourses";
            this.ManageCourses.Size = new System.Drawing.Size(161, 23);
            this.ManageCourses.TabIndex = 0;
            this.ManageCourses.Text = "Manage Lessons";
            // 
            // Content
            // 
            this.Content.Text = "Content";
            this.Content.Width = 238;
            // 
            // UserId
            // 
            this.UserId.Text = "User ID";
            this.UserId.Width = 164;
            // 
            // CreateAt
            // 
            this.CreateAt.Text = "Create At";
            this.CreateAt.Width = 259;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-95, 301);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 76;
            this.label3.Text = "Level";
            // 
            // btnUpdateExam
            // 
            this.btnUpdateExam.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnUpdateExam.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateExam.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnUpdateExam.Location = new System.Drawing.Point(191, 417);
            this.btnUpdateExam.Name = "btnUpdateExam";
            this.btnUpdateExam.Size = new System.Drawing.Size(179, 45);
            this.btnUpdateExam.TabIndex = 78;
            this.btnUpdateExam.Text = "Update Lesson";
            this.btnUpdateExam.UseVisualStyleBackColor = false;
            this.btnUpdateExam.Click += new System.EventHandler(this.btnUpdateExam_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-95, 228);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 75;
            this.label2.Text = "Description";
            // 
            // btnDeleteExam
            // 
            this.btnDeleteExam.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnDeleteExam.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteExam.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDeleteExam.Location = new System.Drawing.Point(376, 417);
            this.btnDeleteExam.Name = "btnDeleteExam";
            this.btnDeleteExam.Size = new System.Drawing.Size(167, 45);
            this.btnDeleteExam.TabIndex = 79;
            this.btnDeleteExam.Text = "Delete Lesson";
            this.btnDeleteExam.UseVisualStyleBackColor = false;
            this.btnDeleteExam.Click += new System.EventHandler(this.btnDeleteExam_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-95, 156);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 74;
            this.label1.Text = "Course Title";
            // 
            // btnAddExam
            // 
            this.btnAddExam.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnAddExam.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddExam.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAddExam.Location = new System.Drawing.Point(20, 417);
            this.btnAddExam.Name = "btnAddExam";
            this.btnAddExam.Size = new System.Drawing.Size(165, 45);
            this.btnAddExam.TabIndex = 77;
            this.btnAddExam.Text = "Add Lesson";
            this.btnAddExam.UseVisualStyleBackColor = false;
            this.btnAddExam.Click += new System.EventHandler(this.btnAddExam_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel1.Controls.Add(this.ManageCourses);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(990, 86);
            this.panel1.TabIndex = 73;
            // 
            // textBoxExamID
            // 
            this.textBoxExamID.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxExamID.Location = new System.Drawing.Point(20, 205);
            this.textBoxExamID.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxExamID.Name = "textBoxExamID";
            this.textBoxExamID.ReadOnly = true;
            this.textBoxExamID.Size = new System.Drawing.Size(292, 24);
            this.textBoxExamID.TabIndex = 87;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 168);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 86;
            this.label6.Text = "Test ID";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 240);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 13);
            this.label9.TabIndex = 83;
            this.label9.Text = "Test Name";
            // 
            // textBoxExamName
            // 
            this.textBoxExamName.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxExamName.Location = new System.Drawing.Point(20, 277);
            this.textBoxExamName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxExamName.Name = "textBoxExamName";
            this.textBoxExamName.Size = new System.Drawing.Size(292, 24);
            this.textBoxExamName.TabIndex = 82;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(-96, 84);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 81;
            this.label5.Text = "Course ID";
            // 
            // listViewDataExams
            // 
            this.listViewDataExams.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.TestID,
            this.TestName,
            this.Content,
            this.UserId,
            this.CreateAt});
            this.listViewDataExams.HideSelection = false;
            this.listViewDataExams.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.listViewDataExams.Location = new System.Drawing.Point(356, 127);
            this.listViewDataExams.Name = "listViewDataExams";
            this.listViewDataExams.Size = new System.Drawing.Size(612, 284);
            this.listViewDataExams.TabIndex = 80;
            this.listViewDataExams.UseCompatibleStateImageBehavior = false;
            this.listViewDataExams.View = System.Windows.Forms.View.Details;
            // 
            // ExamingManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 469);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnUpdateExam);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDeleteExam);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddExam);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBoxExamID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxExamName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listViewDataExams);
            this.Name = "ExamingManagement";
            this.Text = "ExamingManagement";
            this.Load += new System.EventHandler(this.ExamingManagement_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColumnHeader TestName;
        private System.Windows.Forms.ColumnHeader TestID;
        private System.Windows.Forms.Label ManageCourses;
        private System.Windows.Forms.ColumnHeader Content;
        private System.Windows.Forms.ColumnHeader UserId;
        private System.Windows.Forms.ColumnHeader CreateAt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnUpdateExam;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDeleteExam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddExam;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxExamID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxExamName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListView listViewDataExams;
    }
}