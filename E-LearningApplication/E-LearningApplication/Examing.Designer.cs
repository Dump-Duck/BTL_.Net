namespace E_LearningApplication
{
    partial class Examing
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
            this.btnSubmitTest = new System.Windows.Forms.Button();
            this.btnDownload = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // btnSubmitTest
            // 
            this.btnSubmitTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSubmitTest.Location = new System.Drawing.Point(251, 61);
            this.btnSubmitTest.Margin = new System.Windows.Forms.Padding(2);
            this.btnSubmitTest.Name = "btnSubmitTest";
            this.btnSubmitTest.Size = new System.Drawing.Size(138, 54);
            this.btnSubmitTest.TabIndex = 0;
            this.btnSubmitTest.Text = "Submit";
            this.btnSubmitTest.UseVisualStyleBackColor = true;
            this.btnSubmitTest.Click += new System.EventHandler(this.btnSubmitTest_Click);
            // 
            // btnDownload
            // 
            this.btnDownload.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDownload.Location = new System.Drawing.Point(70, 61);
            this.btnDownload.Margin = new System.Windows.Forms.Padding(2);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(138, 54);
            this.btnDownload.TabIndex = 1;
            this.btnDownload.Text = "Download";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // Examing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 175);
            this.Controls.Add(this.btnDownload);
            this.Controls.Add(this.btnSubmitTest);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Examing";
            this.Text = "Examing";
            this.Load += new System.EventHandler(this.Examing_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSubmitTest;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}