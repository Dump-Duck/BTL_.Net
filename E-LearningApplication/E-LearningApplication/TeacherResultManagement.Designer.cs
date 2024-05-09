namespace E_LearningApplication
{
    partial class TeacherResultManagement
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            this.submitBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ManageCourses = new System.Windows.Forms.Label();
            this.resultID_txt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.testName_txt = new System.Windows.Forms.TextBox();
            this.listViewDataResult = new System.Windows.Forms.ListView();
            this.resultID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TestID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.UserID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TestSumitted = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Result = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.userName_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.result_txt = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // submitBtn
            // 
            this.submitBtn.BackColor = System.Drawing.Color.LightSkyBlue;
            this.submitBtn.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.submitBtn.Location = new System.Drawing.Point(63, 356);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(165, 45);
            this.submitBtn.TabIndex = 62;
            this.submitBtn.Text = "Submit Result";
            this.submitBtn.UseVisualStyleBackColor = false;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel1.Controls.Add(this.ManageCourses);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(918, 86);
            this.panel1.TabIndex = 58;
            // 
            // ManageCourses
            // 
            this.ManageCourses.AutoSize = true;
            this.ManageCourses.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManageCourses.ForeColor = System.Drawing.Color.White;
            this.ManageCourses.Location = new System.Drawing.Point(372, 30);
            this.ManageCourses.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ManageCourses.Name = "ManageCourses";
            this.ManageCourses.Size = new System.Drawing.Size(147, 23);
            this.ManageCourses.TabIndex = 0;
            this.ManageCourses.Text = "Manage Result";
            // 
            // resultID_txt
            // 
            this.resultID_txt.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultID_txt.Location = new System.Drawing.Point(20, 152);
            this.resultID_txt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.resultID_txt.Name = "resultID_txt";
            this.resultID_txt.ReadOnly = true;
            this.resultID_txt.Size = new System.Drawing.Size(292, 24);
            this.resultID_txt.TabIndex = 70;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 136);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 69;
            this.label6.Text = "Result ID";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 179);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 13);
            this.label9.TabIndex = 68;
            this.label9.Text = "Test name";
            // 
            // testName_txt
            // 
            this.testName_txt.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.testName_txt.Location = new System.Drawing.Point(20, 195);
            this.testName_txt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.testName_txt.Name = "testName_txt";
            this.testName_txt.ReadOnly = true;
            this.testName_txt.Size = new System.Drawing.Size(292, 24);
            this.testName_txt.TabIndex = 67;
            // 
            // listViewDataResult
            // 
            this.listViewDataResult.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.resultID,
            this.TestID,
            this.UserID,
            this.TestSumitted,
            this.Result,
            this.Date});
            this.listViewDataResult.HideSelection = false;
            this.listViewDataResult.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.listViewDataResult.Location = new System.Drawing.Point(330, 117);
            this.listViewDataResult.Name = "listViewDataResult";
            this.listViewDataResult.Size = new System.Drawing.Size(588, 284);
            this.listViewDataResult.TabIndex = 65;
            this.listViewDataResult.UseCompatibleStateImageBehavior = false;
            this.listViewDataResult.View = System.Windows.Forms.View.Details;
            this.listViewDataResult.Click += new System.EventHandler(this.listViewDataResult_Click);
            // 
            // resultID
            // 
            this.resultID.Text = "Id";
            // 
            // TestID
            // 
            this.TestID.Text = "Test";
            this.TestID.Width = 87;
            // 
            // UserID
            // 
            this.UserID.Text = "User";
            this.UserID.Width = 173;
            // 
            // TestSumitted
            // 
            this.TestSumitted.Text = "Test Sumitted";
            this.TestSumitted.Width = 151;
            // 
            // Result
            // 
            this.Result.Text = "Result";
            // 
            // Date
            // 
            this.Date.Text = "Date";
            // 
            // userName_txt
            // 
            this.userName_txt.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userName_txt.Location = new System.Drawing.Point(20, 238);
            this.userName_txt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.userName_txt.Name = "userName_txt";
            this.userName_txt.ReadOnly = true;
            this.userName_txt.Size = new System.Drawing.Size(292, 24);
            this.userName_txt.TabIndex = 71;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 222);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 72;
            this.label1.Text = "User Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 265);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 74;
            this.label2.Text = "Result";
            // 
            // result_txt
            // 
            this.result_txt.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result_txt.Location = new System.Drawing.Point(19, 281);
            this.result_txt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.result_txt.Name = "result_txt";
            this.result_txt.Size = new System.Drawing.Size(292, 24);
            this.result_txt.TabIndex = 73;
            // 
            // TeacherResultManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 434);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.result_txt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.userName_txt);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.resultID_txt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.testName_txt);
            this.Controls.Add(this.listViewDataResult);
            this.Name = "TeacherResultManagement";
            this.Text = "TeacherResultManagement";
            this.Load += new System.EventHandler(this.TeacherResultManagement_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label ManageCourses;
        private System.Windows.Forms.TextBox resultID_txt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox testName_txt;
        private System.Windows.Forms.ListView listViewDataResult;
        private System.Windows.Forms.ColumnHeader resultID;
        private System.Windows.Forms.ColumnHeader TestID;
        private System.Windows.Forms.ColumnHeader UserID;
        private System.Windows.Forms.ColumnHeader TestSumitted;
        private System.Windows.Forms.ColumnHeader Result;
        private System.Windows.Forms.TextBox userName_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox result_txt;
        private System.Windows.Forms.ColumnHeader Date;
    }
}