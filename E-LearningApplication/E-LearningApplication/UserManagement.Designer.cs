namespace E_LearningApplication
{
    partial class UserManagement
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.coursesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.practiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.forumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blogPostToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blogManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.userID_txt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.password_txt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.username_txt = new System.Windows.Forms.TextBox();
            this.ManageUsers = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.fullname_txt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.userDataGridView = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.levelBox = new System.Windows.Forms.ComboBox();
            this.dateOfBirth_txt = new System.Windows.Forms.TextBox();
            this.avatar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.roleBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.email_txt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.menuStrip.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userDataGridView)).BeginInit();
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
            this.menuStrip.Size = new System.Drawing.Size(1220, 24);
            this.menuStrip.TabIndex = 13;
            this.menuStrip.Text = "menuStrip";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.homeToolStripMenuItem.Text = "Home";
            // 
            // coursesToolStripMenuItem
            // 
            this.coursesToolStripMenuItem.Name = "coursesToolStripMenuItem";
            this.coursesToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.coursesToolStripMenuItem.Text = "Courses";
            // 
            // practiceToolStripMenuItem
            // 
            this.practiceToolStripMenuItem.Name = "practiceToolStripMenuItem";
            this.practiceToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.practiceToolStripMenuItem.Text = "Practices";
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
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // userID_txt
            // 
            this.userID_txt.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userID_txt.Location = new System.Drawing.Point(11, 159);
            this.userID_txt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.userID_txt.Name = "userID_txt";
            this.userID_txt.Size = new System.Drawing.Size(52, 24);
            this.userID_txt.TabIndex = 57;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 137);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 56;
            this.label6.Text = "User ID";
            // 
            // password_txt
            // 
            this.password_txt.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_txt.Location = new System.Drawing.Point(215, 159);
            this.password_txt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.password_txt.Name = "password_txt";
            this.password_txt.Size = new System.Drawing.Size(199, 24);
            this.password_txt.TabIndex = 54;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(212, 134);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 52;
            this.label8.Text = "Password";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(68, 134);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.TabIndex = 51;
            this.label9.Text = "Username";
            // 
            // username_txt
            // 
            this.username_txt.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_txt.Location = new System.Drawing.Point(71, 159);
            this.username_txt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.username_txt.Name = "username_txt";
            this.username_txt.Size = new System.Drawing.Size(136, 24);
            this.username_txt.TabIndex = 50;
            // 
            // ManageUsers
            // 
            this.ManageUsers.AutoSize = true;
            this.ManageUsers.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManageUsers.ForeColor = System.Drawing.Color.White;
            this.ManageUsers.Location = new System.Drawing.Point(525, 28);
            this.ManageUsers.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ManageUsers.Name = "ManageUsers";
            this.ManageUsers.Size = new System.Drawing.Size(141, 23);
            this.ManageUsers.TabIndex = 0;
            this.ManageUsers.Text = "Manage Users";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnUpdate.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnUpdate.Location = new System.Drawing.Point(28, 393);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(179, 45);
            this.btnUpdate.TabIndex = 44;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // fullname_txt
            // 
            this.fullname_txt.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullname_txt.Location = new System.Drawing.Point(11, 211);
            this.fullname_txt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.fullname_txt.Name = "fullname_txt";
            this.fullname_txt.Size = new System.Drawing.Size(196, 24);
            this.fullname_txt.TabIndex = 47;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 191);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 46;
            this.label4.Text = "Fullname";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnDelete.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDelete.Location = new System.Drawing.Point(219, 393);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(167, 45);
            this.btnDelete.TabIndex = 45;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel1.Controls.Add(this.ManageUsers);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1220, 86);
            this.panel1.TabIndex = 39;
            // 
            // userDataGridView
            // 
            this.userDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userDataGridView.Location = new System.Drawing.Point(457, 138);
            this.userDataGridView.Name = "userDataGridView";
            this.userDataGridView.Size = new System.Drawing.Size(713, 316);
            this.userDataGridView.TabIndex = 59;
            this.userDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.userDataGridView_CellClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 293);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 53;
            this.label7.Text = "Level";
            // 
            // levelBox
            // 
            this.levelBox.FormattingEnabled = true;
            this.levelBox.Items.AddRange(new object[] {
            "Basic",
            "Independent",
            "Proficient"});
            this.levelBox.Location = new System.Drawing.Point(11, 309);
            this.levelBox.Name = "levelBox";
            this.levelBox.Size = new System.Drawing.Size(196, 21);
            this.levelBox.TabIndex = 55;
            // 
            // dateOfBirth_txt
            // 
            this.dateOfBirth_txt.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateOfBirth_txt.Location = new System.Drawing.Point(215, 211);
            this.dateOfBirth_txt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dateOfBirth_txt.Name = "dateOfBirth_txt";
            this.dateOfBirth_txt.Size = new System.Drawing.Size(199, 24);
            this.dateOfBirth_txt.TabIndex = 60;
            // 
            // avatar
            // 
            this.avatar.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avatar.Location = new System.Drawing.Point(215, 262);
            this.avatar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.avatar.Name = "avatar";
            this.avatar.Size = new System.Drawing.Size(199, 24);
            this.avatar.TabIndex = 61;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(216, 191);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 62;
            this.label1.Text = "Date Of Birth";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(216, 246);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 63;
            this.label2.Text = "Avatar";
            // 
            // roleBox
            // 
            this.roleBox.FormattingEnabled = true;
            this.roleBox.Items.AddRange(new object[] {
            "Student",
            "Teacher"});
            this.roleBox.Location = new System.Drawing.Point(215, 309);
            this.roleBox.Name = "roleBox";
            this.roleBox.Size = new System.Drawing.Size(199, 21);
            this.roleBox.TabIndex = 64;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(216, 293);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 65;
            this.label3.Text = "Role";
            // 
            // email_txt
            // 
            this.email_txt.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_txt.Location = new System.Drawing.Point(11, 262);
            this.email_txt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.email_txt.Name = "email_txt";
            this.email_txt.Size = new System.Drawing.Size(196, 24);
            this.email_txt.TabIndex = 67;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 242);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 66;
            this.label5.Text = "Email";
            // 
            // UserManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1220, 523);
            this.Controls.Add(this.email_txt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.roleBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.avatar);
            this.Controls.Add(this.dateOfBirth_txt);
            this.Controls.Add(this.userDataGridView);
            this.Controls.Add(this.userID_txt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.levelBox);
            this.Controls.Add(this.password_txt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.username_txt);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.fullname_txt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip);
            this.Name = "UserManagement";
            this.Text = "UserManagement";
            this.Load += new System.EventHandler(this.UserManagement_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem coursesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem practiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem forumToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blogPostToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blogManagementToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox userID_txt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox password_txt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox username_txt;
        private System.Windows.Forms.Label ManageUsers;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox fullname_txt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView userDataGridView;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox levelBox;
        private System.Windows.Forms.TextBox dateOfBirth_txt;
        private System.Windows.Forms.TextBox avatar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox roleBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox email_txt;
        private System.Windows.Forms.Label label5;
    }
}