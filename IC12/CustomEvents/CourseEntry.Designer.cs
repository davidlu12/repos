namespace CustomEvents
{
    partial class CourseEntry
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
            this.addButton = new System.Windows.Forms.Button();
            this.courseCreditsTextBox = new System.Windows.Forms.TextBox();
            this.courseCreditsLabel = new System.Windows.Forms.Label();
            this.courseIDTextBox = new System.Windows.Forms.TextBox();
            this.courseIDLabel = new System.Windows.Forms.Label();
            this.courseNameTextBox = new System.Windows.Forms.TextBox();
            this.courseNameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(173, 188);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 9;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // courseCreditsTextBox
            // 
            this.courseCreditsTextBox.Location = new System.Drawing.Point(148, 144);
            this.courseCreditsTextBox.Name = "courseCreditsTextBox";
            this.courseCreditsTextBox.Size = new System.Drawing.Size(100, 20);
            this.courseCreditsTextBox.TabIndex = 6;
            // 
            // courseCreditsLabel
            // 
            this.courseCreditsLabel.AutoSize = true;
            this.courseCreditsLabel.Location = new System.Drawing.Point(36, 147);
            this.courseCreditsLabel.Name = "courseCreditsLabel";
            this.courseCreditsLabel.Size = new System.Drawing.Size(91, 13);
            this.courseCreditsLabel.TabIndex = 3;
            this.courseCreditsLabel.Text = "Number of Credits";
            // 
            // courseIDTextBox
            // 
            this.courseIDTextBox.Location = new System.Drawing.Point(148, 94);
            this.courseIDTextBox.Name = "courseIDTextBox";
            this.courseIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.courseIDTextBox.TabIndex = 7;
            // 
            // courseIDLabel
            // 
            this.courseIDLabel.AutoSize = true;
            this.courseIDLabel.Location = new System.Drawing.Point(36, 97);
            this.courseIDLabel.Name = "courseIDLabel";
            this.courseIDLabel.Size = new System.Drawing.Size(54, 13);
            this.courseIDLabel.TabIndex = 4;
            this.courseIDLabel.Text = "Course ID";
            // 
            // courseNameTextBox
            // 
            this.courseNameTextBox.Location = new System.Drawing.Point(148, 51);
            this.courseNameTextBox.Name = "courseNameTextBox";
            this.courseNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.courseNameTextBox.TabIndex = 8;
            // 
            // courseNameLabel
            // 
            this.courseNameLabel.AutoSize = true;
            this.courseNameLabel.Location = new System.Drawing.Point(36, 54);
            this.courseNameLabel.Name = "courseNameLabel";
            this.courseNameLabel.Size = new System.Drawing.Size(71, 13);
            this.courseNameLabel.TabIndex = 5;
            this.courseNameLabel.Text = "Course Name";
            // 
            // CourseEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.courseCreditsTextBox);
            this.Controls.Add(this.courseCreditsLabel);
            this.Controls.Add(this.courseIDTextBox);
            this.Controls.Add(this.courseIDLabel);
            this.Controls.Add(this.courseNameTextBox);
            this.Controls.Add(this.courseNameLabel);
            this.Name = "CourseEntry";
            this.Text = "CourseEntry";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox courseCreditsTextBox;
        private System.Windows.Forms.Label courseCreditsLabel;
        private System.Windows.Forms.TextBox courseIDTextBox;
        private System.Windows.Forms.Label courseIDLabel;
        private System.Windows.Forms.TextBox courseNameTextBox;
        private System.Windows.Forms.Label courseNameLabel;
    }
}