namespace DataWork
{
    partial class DetailForm
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
            this.whatMovieButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ratingLabel = new System.Windows.Forms.Label();
            this.movieDisplayLabel = new System.Windows.Forms.Label();
            this.ratingDisplayLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // whatMovieButton
            // 
            this.whatMovieButton.Location = new System.Drawing.Point(83, 101);
            this.whatMovieButton.Name = "whatMovieButton";
            this.whatMovieButton.Size = new System.Drawing.Size(119, 23);
            this.whatMovieButton.TabIndex = 0;
            this.whatMovieButton.Text = "What can I watch?";
            this.whatMovieButton.UseVisualStyleBackColor = true;
            this.whatMovieButton.Click += new System.EventHandler(this.whatMovieButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // ratingLabel
            // 
            this.ratingLabel.AutoSize = true;
            this.ratingLabel.Location = new System.Drawing.Point(13, 55);
            this.ratingLabel.Name = "ratingLabel";
            this.ratingLabel.Size = new System.Drawing.Size(38, 13);
            this.ratingLabel.TabIndex = 2;
            this.ratingLabel.Text = "Rating";
            // 
            // movieDisplayLabel
            // 
            this.movieDisplayLabel.AutoSize = true;
            this.movieDisplayLabel.Location = new System.Drawing.Point(112, 27);
            this.movieDisplayLabel.Name = "movieDisplayLabel";
            this.movieDisplayLabel.Size = new System.Drawing.Size(104, 13);
            this.movieDisplayLabel.TabIndex = 3;
            this.movieDisplayLabel.Text = "Movie Name Display";
            // 
            // ratingDisplayLabel
            // 
            this.ratingDisplayLabel.AutoSize = true;
            this.ratingDisplayLabel.Location = new System.Drawing.Point(112, 55);
            this.ratingDisplayLabel.Name = "ratingDisplayLabel";
            this.ratingDisplayLabel.Size = new System.Drawing.Size(75, 13);
            this.ratingDisplayLabel.TabIndex = 3;
            this.ratingDisplayLabel.Text = "Rating Display";
            // 
            // DetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.ratingDisplayLabel);
            this.Controls.Add(this.movieDisplayLabel);
            this.Controls.Add(this.ratingLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.whatMovieButton);
            this.Name = "DetailForm";
            this.Text = "Movie Details";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button whatMovieButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ratingLabel;
        private System.Windows.Forms.Label movieDisplayLabel;
        private System.Windows.Forms.Label ratingDisplayLabel;
    }
}