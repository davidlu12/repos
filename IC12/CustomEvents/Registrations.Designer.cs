namespace CustomEvents
{
    partial class Registrations
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
            this.removeButton = new System.Windows.Forms.Button();
            this.registrationListBox = new System.Windows.Forms.ListBox();
            this.addButton = new System.Windows.Forms.Button();
            this.coursesComboBox = new System.Windows.Forms.ComboBox();
            this.creditsDisplayLabel = new System.Windows.Forms.Label();
            this.idDisplayLabel = new System.Windows.Forms.Label();
            this.nameDisplayLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(320, 158);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(59, 23);
            this.removeButton.TabIndex = 15;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // registrationListBox
            // 
            this.registrationListBox.FormattingEnabled = true;
            this.registrationListBox.Location = new System.Drawing.Point(37, 158);
            this.registrationListBox.Name = "registrationListBox";
            this.registrationListBox.Size = new System.Drawing.Size(269, 95);
            this.registrationListBox.TabIndex = 14;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(320, 108);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(59, 23);
            this.addButton.TabIndex = 13;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // coursesComboBox
            // 
            this.coursesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.coursesComboBox.FormattingEnabled = true;
            this.coursesComboBox.Location = new System.Drawing.Point(114, 110);
            this.coursesComboBox.Name = "coursesComboBox";
            this.coursesComboBox.Size = new System.Drawing.Size(192, 21);
            this.coursesComboBox.TabIndex = 12;
            // 
            // creditsDisplayLabel
            // 
            this.creditsDisplayLabel.AutoSize = true;
            this.creditsDisplayLabel.Location = new System.Drawing.Point(111, 77);
            this.creditsDisplayLabel.Name = "creditsDisplayLabel";
            this.creditsDisplayLabel.Size = new System.Drawing.Size(91, 13);
            this.creditsDisplayLabel.TabIndex = 5;
            this.creditsDisplayLabel.Text = "Number of Credits";
            // 
            // idDisplayLabel
            // 
            this.idDisplayLabel.AutoSize = true;
            this.idDisplayLabel.Location = new System.Drawing.Point(111, 51);
            this.idDisplayLabel.Name = "idDisplayLabel";
            this.idDisplayLabel.Size = new System.Drawing.Size(70, 13);
            this.idDisplayLabel.TabIndex = 6;
            this.idDisplayLabel.Text = "ID of Student";
            // 
            // nameDisplayLabel
            // 
            this.nameDisplayLabel.AutoSize = true;
            this.nameDisplayLabel.Location = new System.Drawing.Point(111, 23);
            this.nameDisplayLabel.Name = "nameDisplayLabel";
            this.nameDisplayLabel.Size = new System.Drawing.Size(87, 13);
            this.nameDisplayLabel.TabIndex = 7;
            this.nameDisplayLabel.Text = "Name of Student";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(34, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Course";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Credits";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Name";
            // 
            // Registrations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 344);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.registrationListBox);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.coursesComboBox);
            this.Controls.Add(this.creditsDisplayLabel);
            this.Controls.Add(this.idDisplayLabel);
            this.Controls.Add(this.nameDisplayLabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Registrations";
            this.Text = "Registrations";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.ListBox registrationListBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.ComboBox coursesComboBox;
        private System.Windows.Forms.Label creditsDisplayLabel;
        private System.Windows.Forms.Label idDisplayLabel;
        private System.Windows.Forms.Label nameDisplayLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}