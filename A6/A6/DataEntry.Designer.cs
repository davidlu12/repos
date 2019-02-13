namespace A6
{
    partial class DataEntry
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
            this.okButton = new System.Windows.Forms.Button();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.idLabel = new System.Windows.Forms.Label();
            this.studentListBox = new System.Windows.Forms.ListBox();
            this.studentRadioButton = new System.Windows.Forms.RadioButton();
            this.staffRadioButton = new System.Windows.Forms.RadioButton();
            this.personGroupBox = new System.Windows.Forms.GroupBox();
            this.staffListBox = new System.Windows.Forms.ListBox();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openStudentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openStaffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveStudentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveStaffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.personGroupBox.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(277, 166);
            this.okButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(100, 28);
            this.okButton.TabIndex = 2;
            this.okButton.Text = "Create";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(225, 102);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(151, 22);
            this.nameTextBox.TabIndex = 0;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(24, 102);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(45, 17);
            this.nameLabel.TabIndex = 2;
            this.nameLabel.Text = "Name";
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(225, 134);
            this.idTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(151, 22);
            this.idTextBox.TabIndex = 1;
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(24, 134);
            this.idLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(21, 17);
            this.idLabel.TabIndex = 2;
            this.idLabel.Text = "ID";
            // 
            // studentListBox
            // 
            this.studentListBox.FormattingEnabled = true;
            this.studentListBox.ItemHeight = 16;
            this.studentListBox.Location = new System.Drawing.Point(16, 219);
            this.studentListBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.studentListBox.Name = "studentListBox";
            this.studentListBox.Size = new System.Drawing.Size(157, 116);
            this.studentListBox.TabIndex = 3;
            // 
            // studentRadioButton
            // 
            this.studentRadioButton.AutoSize = true;
            this.studentRadioButton.Location = new System.Drawing.Point(21, 18);
            this.studentRadioButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.studentRadioButton.Name = "studentRadioButton";
            this.studentRadioButton.Size = new System.Drawing.Size(78, 21);
            this.studentRadioButton.TabIndex = 4;
            this.studentRadioButton.TabStop = true;
            this.studentRadioButton.Text = "Student";
            this.studentRadioButton.UseVisualStyleBackColor = true;
            // 
            // staffRadioButton
            // 
            this.staffRadioButton.AutoSize = true;
            this.staffRadioButton.Location = new System.Drawing.Point(209, 18);
            this.staffRadioButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.staffRadioButton.Name = "staffRadioButton";
            this.staffRadioButton.Size = new System.Drawing.Size(58, 21);
            this.staffRadioButton.TabIndex = 5;
            this.staffRadioButton.TabStop = true;
            this.staffRadioButton.Text = "Staff";
            this.staffRadioButton.UseVisualStyleBackColor = true;
            // 
            // personGroupBox
            // 
            this.personGroupBox.Controls.Add(this.studentRadioButton);
            this.personGroupBox.Controls.Add(this.staffRadioButton);
            this.personGroupBox.Location = new System.Drawing.Point(16, 28);
            this.personGroupBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.personGroupBox.Name = "personGroupBox";
            this.personGroupBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.personGroupBox.Size = new System.Drawing.Size(361, 47);
            this.personGroupBox.TabIndex = 6;
            this.personGroupBox.TabStop = false;
            this.personGroupBox.Text = "Person Type";
            // 
            // staffListBox
            // 
            this.staffListBox.FormattingEnabled = true;
            this.staffListBox.ItemHeight = 16;
            this.staffListBox.Location = new System.Drawing.Point(219, 219);
            this.staffListBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.staffListBox.Name = "staffListBox";
            this.staffListBox.Size = new System.Drawing.Size(157, 116);
            this.staffListBox.TabIndex = 3;
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(420, 28);
            this.menuStrip.TabIndex = 7;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openStudentsToolStripMenuItem,
            this.openStaffToolStripMenuItem,
            this.saveStudentsToolStripMenuItem,
            this.saveStaffToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openStudentsToolStripMenuItem
            // 
            this.openStudentsToolStripMenuItem.Name = "openStudentsToolStripMenuItem";
            this.openStudentsToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.openStudentsToolStripMenuItem.Text = "Open Students";
            this.openStudentsToolStripMenuItem.Click += new System.EventHandler(this.openStudentsToolStripMenuItem_Click);
            // 
            // openStaffToolStripMenuItem
            // 
            this.openStaffToolStripMenuItem.Name = "openStaffToolStripMenuItem";
            this.openStaffToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.openStaffToolStripMenuItem.Text = "Open Staff";
            this.openStaffToolStripMenuItem.Click += new System.EventHandler(this.openStaffToolStripMenuItem_Click);
            // 
            // saveStudentsToolStripMenuItem
            // 
            this.saveStudentsToolStripMenuItem.Name = "saveStudentsToolStripMenuItem";
            this.saveStudentsToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.saveStudentsToolStripMenuItem.Text = "Save Students";
            this.saveStudentsToolStripMenuItem.Click += new System.EventHandler(this.saveStudentsToolStripMenuItem_Click);
            // 
            // saveStaffToolStripMenuItem
            // 
            this.saveStaffToolStripMenuItem.Name = "saveStaffToolStripMenuItem";
            this.saveStaffToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.saveStaffToolStripMenuItem.Text = "Save Staff";
            this.saveStaffToolStripMenuItem.Click += new System.EventHandler(this.saveStaffToolStripMenuItem_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 373);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(420, 25);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip";
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(50, 20);
            this.statusLabel.Text = "Ready";
            // 
            // DataEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 398);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.personGroupBox);
            this.Controls.Add(this.staffListBox);
            this.Controls.Add(this.studentListBox);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DataEntry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Data Entry Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.personGroupBox.ResumeLayout(false);
            this.personGroupBox.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.ListBox studentListBox;
        private System.Windows.Forms.RadioButton studentRadioButton;
        private System.Windows.Forms.RadioButton staffRadioButton;
        private System.Windows.Forms.GroupBox personGroupBox;
        private System.Windows.Forms.ListBox staffListBox;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openStudentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openStaffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveStudentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveStaffToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
    }
}

