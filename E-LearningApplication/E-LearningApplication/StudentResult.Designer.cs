namespace E_LearningApplication
{
    partial class StudentResult
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label = new System.Windows.Forms.Label();
            this.Result = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TestSumitted = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewDataLessons = new System.Windows.Forms.ListView();
            this.resultID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TestName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel1.Controls.Add(this.label);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 86);
            this.panel1.TabIndex = 75;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.Color.White;
            this.label.Location = new System.Drawing.Point(338, 33);
            this.label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(63, 23);
            this.label.TabIndex = 0;
            this.label.Text = "Result";
            // 
            // Result
            // 
            this.Result.Text = "Result";
            this.Result.Width = 67;
            // 
            // TestSumitted
            // 
            this.TestSumitted.Text = "Test Sumitted";
            this.TestSumitted.Width = 224;
            // 
            // listViewDataLessons
            // 
            this.listViewDataLessons.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.resultID,
            this.TestName,
            this.TestSumitted,
            this.Result,
            this.date});
            this.listViewDataLessons.HideSelection = false;
            this.listViewDataLessons.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.listViewDataLessons.Location = new System.Drawing.Point(81, 123);
            this.listViewDataLessons.Name = "listViewDataLessons";
            this.listViewDataLessons.Size = new System.Drawing.Size(644, 284);
            this.listViewDataLessons.TabIndex = 77;
            this.listViewDataLessons.UseCompatibleStateImageBehavior = false;
            this.listViewDataLessons.View = System.Windows.Forms.View.Details;
            // 
            // resultID
            // 
            this.resultID.Text = "Id";
            // 
            // TestName
            // 
            this.TestName.Text = "Test Name";
            this.TestName.Width = 173;
            // 
            // date
            // 
            this.date.Text = "Date";
            // 
            // StudentResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 455);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listViewDataLessons);
            this.Name = "StudentResult";
            this.Text = "StudentResult";
            this.Load += new System.EventHandler(this.StudentResult_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.ColumnHeader Result;
        private System.Windows.Forms.ColumnHeader TestSumitted;
        private System.Windows.Forms.ListView listViewDataLessons;
        private System.Windows.Forms.ColumnHeader resultID;
        private System.Windows.Forms.ColumnHeader TestName;
        private System.Windows.Forms.ColumnHeader date;
    }
}