// IC12, David Lu, CIS 345, T-Th 12pm
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomEvents
{
    public partial class UpdateStudent : Form
    {
        public event EventHandler StudentUpdated;
        private Student currentStudent;
        
        public UpdateStudent()
        {
            InitializeComponent();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {

            Student tmpStudent = new Student(nameTextBox.Text, idTextBox.Text);

            currentStudent.Name = nameTextBox.Text;
            currentStudent.Id = idTextBox.Text;

            StudentEventArgs tmpArgs = new StudentEventArgs(tmpStudent);

            if (StudentUpdated != null)
                StudentUpdated(this, tmpArgs);

            this.Close();

        }

        public void PopulateData(Student student)
        {
            currentStudent = student;

            nameTextBox.Text = currentStudent.Name;
            idTextBox.Text = currentStudent.Id;

        }


    }
}
