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
    public delegate void StudentCreated(object sender, EventArgs e);

    public partial class StudentEntry : Form
    {
        public event StudentCreated NewStudentCreated;

        public StudentEntry()
        {
            InitializeComponent();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            
            if (nameTextBox.Text == String.Empty || idTextBox.Text == String.Empty)
            {
                MessageBox.Show("Enter all data fields.");
                return;
            }

            // Enclose new data in a student object
            // put student object inside a DataEntryEventArgs object
            Student tmpStudent = new Student(nameTextBox.Text, idTextBox.Text);
            StudentEventArgs tmpArgs = new StudentEventArgs(tmpStudent);

   


            // raise StudentCreated event
            // use upcasting and pass tmpArgs as EventArgs
            NewStudentCreated(this, tmpArgs);

            // reset textboxes for entry
            nameTextBox.Clear();
            idTextBox.Clear();
            nameTextBox.Focus();

        }

        private void StudentEntry_Load(object sender, EventArgs e)
        {

        }


    }
}
