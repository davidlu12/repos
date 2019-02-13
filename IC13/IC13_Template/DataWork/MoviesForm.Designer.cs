namespace DataWork
{
    partial class MoviesForm
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
            this.loadButton = new System.Windows.Forms.Button();
            this.moviesListBox = new System.Windows.Forms.ListBox();
            this.movieDetailsButtons = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(154, 26);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(108, 23);
            this.loadButton.TabIndex = 2;
            this.loadButton.Text = "Load Sample Data";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // moviesListBox
            // 
            this.moviesListBox.FormattingEnabled = true;
            this.moviesListBox.Location = new System.Drawing.Point(12, 26);
            this.moviesListBox.Name = "moviesListBox";
            this.moviesListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.moviesListBox.Size = new System.Drawing.Size(119, 95);
            this.moviesListBox.TabIndex = 3;
            // 
            // movieDetailsButtons
            // 
            this.movieDetailsButtons.Location = new System.Drawing.Point(154, 64);
            this.movieDetailsButtons.Name = "movieDetailsButtons";
            this.movieDetailsButtons.Size = new System.Drawing.Size(108, 23);
            this.movieDetailsButtons.TabIndex = 2;
            this.movieDetailsButtons.Text = "Open Movie Details";
            this.movieDetailsButtons.UseVisualStyleBackColor = true;
            this.movieDetailsButtons.Click += new System.EventHandler(this.movieDetailsButtons_Click);
            // 
            // MoviesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 323);
            this.Controls.Add(this.moviesListBox);
            this.Controls.Add(this.movieDetailsButtons);
            this.Controls.Add(this.loadButton);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MoviesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Movies";
            this.Load += new System.EventHandler(this.MoviesForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.ListBox moviesListBox;
        private System.Windows.Forms.Button movieDetailsButtons;
    }
}

