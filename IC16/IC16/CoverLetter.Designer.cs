namespace IC16
{
    partial class CoverLetter
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
            this.nameLabel = new System.Windows.Forms.Label();
            this.companyLabel = new System.Windows.Forms.Label();
            this.topicLabel = new System.Windows.Forms.Label();
            this.miscLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.companyTextBox = new System.Windows.Forms.TextBox();
            this.topicTextBox = new System.Windows.Forms.TextBox();
            this.miscTextBox = new System.Windows.Forms.TextBox();
            this.generateDocumentButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(13, 13);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(35, 13);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Name";
            // 
            // companyLabel
            // 
            this.companyLabel.AutoSize = true;
            this.companyLabel.Location = new System.Drawing.Point(13, 41);
            this.companyLabel.Name = "companyLabel";
            this.companyLabel.Size = new System.Drawing.Size(51, 13);
            this.companyLabel.TabIndex = 1;
            this.companyLabel.Text = "Company";
            // 
            // topicLabel
            // 
            this.topicLabel.AutoSize = true;
            this.topicLabel.Location = new System.Drawing.Point(12, 68);
            this.topicLabel.Name = "topicLabel";
            this.topicLabel.Size = new System.Drawing.Size(34, 13);
            this.topicLabel.TabIndex = 2;
            this.topicLabel.Text = "Topic";
            // 
            // miscLabel
            // 
            this.miscLabel.AutoSize = true;
            this.miscLabel.Location = new System.Drawing.Point(13, 110);
            this.miscLabel.Name = "miscLabel";
            this.miscLabel.Size = new System.Drawing.Size(29, 13);
            this.miscLabel.TabIndex = 3;
            this.miscLabel.Text = "Misc";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(88, 13);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(209, 20);
            this.nameTextBox.TabIndex = 4;
            // 
            // companyTextBox
            // 
            this.companyTextBox.Location = new System.Drawing.Point(88, 41);
            this.companyTextBox.Name = "companyTextBox";
            this.companyTextBox.Size = new System.Drawing.Size(209, 20);
            this.companyTextBox.TabIndex = 5;
            // 
            // topicTextBox
            // 
            this.topicTextBox.Location = new System.Drawing.Point(88, 68);
            this.topicTextBox.Name = "topicTextBox";
            this.topicTextBox.Size = new System.Drawing.Size(209, 20);
            this.topicTextBox.TabIndex = 6;
            // 
            // miscTextBox
            // 
            this.miscTextBox.Location = new System.Drawing.Point(88, 110);
            this.miscTextBox.Multiline = true;
            this.miscTextBox.Name = "miscTextBox";
            this.miscTextBox.Size = new System.Drawing.Size(209, 67);
            this.miscTextBox.TabIndex = 7;
            // 
            // generateDocumentButton
            // 
            this.generateDocumentButton.Location = new System.Drawing.Point(88, 197);
            this.generateDocumentButton.Name = "generateDocumentButton";
            this.generateDocumentButton.Size = new System.Drawing.Size(153, 23);
            this.generateDocumentButton.TabIndex = 8;
            this.generateDocumentButton.Text = "Generate Document";
            this.generateDocumentButton.UseVisualStyleBackColor = true;
            this.generateDocumentButton.Click += new System.EventHandler(this.generateDocumentButton_Click);
            // 
            // CoverLetter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 234);
            this.Controls.Add(this.generateDocumentButton);
            this.Controls.Add(this.miscTextBox);
            this.Controls.Add(this.topicTextBox);
            this.Controls.Add(this.companyTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.miscLabel);
            this.Controls.Add(this.topicLabel);
            this.Controls.Add(this.companyLabel);
            this.Controls.Add(this.nameLabel);
            this.Name = "CoverLetter";
            this.Text = "Cover Letter Generator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CoverLetter_FormClosing);
            this.Load += new System.EventHandler(this.CoverLetter_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label companyLabel;
        private System.Windows.Forms.Label topicLabel;
        private System.Windows.Forms.Label miscLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox companyTextBox;
        private System.Windows.Forms.TextBox topicTextBox;
        private System.Windows.Forms.TextBox miscTextBox;
        private System.Windows.Forms.Button generateDocumentButton;
    }
}

