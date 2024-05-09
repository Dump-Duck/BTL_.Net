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
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSubmitTest
            // 
            this.btnSubmitTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSubmitTest.Location = new System.Drawing.Point(459, 180);
            this.btnSubmitTest.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSubmitTest.Name = "btnSubmitTest";
            this.btnSubmitTest.Size = new System.Drawing.Size(138, 54);
            this.btnSubmitTest.TabIndex = 0;
            this.btnSubmitTest.Text = "Submit";
            this.btnSubmitTest.UseVisualStyleBackColor = true;
            this.btnSubmitTest.Click += new System.EventHandler(this.btnSubmitTest_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button2.Location = new System.Drawing.Point(288, 180);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(138, 54);
            this.button2.TabIndex = 1;
            this.button2.Text = "Test";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Examing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 346);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnSubmitTest);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Examing";
            this.Text = "Examing";
            this.Load += new System.EventHandler(this.Examing_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSubmitTest;
        private System.Windows.Forms.Button button2;
    }
}