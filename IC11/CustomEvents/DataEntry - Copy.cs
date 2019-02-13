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

    public partial class DataEdit : Form
    {
        public event StudentCreated NewStudentCreated;

        public DataEdit()
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
            DataEntryEventArgs tmpArgs = new DataEntryEventArgs(tmpStudent);

   


            // raise StudentCreated event
            // use upcasting and pass tmpArgs as EventArgs
            NewStudentCreated(this, tmpArgs);

            // reset textboxes for entry
            nameTextBox.Clear();
            idTextBox.Clear();
            nameTextBox.Focus();

        }

        private void DataEntry_Load(object sender, EventArgs e)
        {

        }


    }
}
