// IC11, David Lu, CIS 345, T-Th 12pm
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
    public partial class CourseEntry : Form
    {
        public EventHandler CourseCreated;

        public CourseEntry()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (courseNameTextBox.Text == String.Empty || courseIDTextBox.Text == String.Empty
                || courseCreditsTextBox.Text == String.Empty)
            {
                MessageBox.Show("Enter all data.");
                return;
            }

            int courseCredits = Convert.ToInt32(courseCreditsTextBox.Text);

            Course tmpCourse = new Course(courseNameTextBox.Text, courseIDTextBox.Text, courseCredits);
            CourseEventArgs tmpArgs = new CourseEventArgs(tmpCourse);

            if (CourseCreated != null)
                CourseCreated(this, tmpArgs);

            courseNameTextBox.Clear();
            courseIDTextBox.Clear();
            courseCreditsTextBox.Clear();
            courseNameTextBox.Focus();

        }
    }
}
