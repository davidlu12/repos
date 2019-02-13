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
    public partial class Registrations : Form
    {
        Student currentStudent;
        BindingList<Course> courses;
        int registeredCredits;
        const int MAXCREDITS = 15;

        public Registrations()
        {
            InitializeComponent();
        }

        // This method should set up to display data in the form
        public void SetRegistrationData(Student student, BindingList<Course> courses)
        {
            currentStudent = student;
            this.courses = courses;

            nameDisplayLabel.Text = currentStudent.Name;
            idDisplayLabel.Text = currentStudent.Id;

            registrationListBox.DataSource = currentStudent.Courses;
            coursesComboBox.DataSource = courses;
        }

        // The Add button will add the course which is currently selected to the list of courses that the student maintains.
        private void addButton_Click(object sender, EventArgs e)
        {
            Course selectedCourse = (Course)coursesComboBox.SelectedItem;

            if ((registeredCredits + selectedCourse.Credits) <= MAXCREDITS)
            {
                if(currentStudent.Courses.IndexOf(selectedCourse)==-1)
                {
                    currentStudent.Courses.Add(selectedCourse);

                    registeredCredits += selectedCourse.Credits;
                    creditsDisplayLabel.Text = registeredCredits.ToString();
                }
                else
                {
                    MessageBox.Show("Course already added.");
                }
            }
            else
            {
                MessageBox.Show("Over max credits");
            }
        }

        // The Remove button will remove the course which is currently selected from the list of courses that the student maintains.
        private void removeButton_Click(object sender, EventArgs e)
        {
            Course tmpCourse;
            if(registrationListBox.SelectedItem != null)
            {
                tmpCourse = (Course)registrationListBox.SelectedItem;
                currentStudent.Courses.Remove(tmpCourse);
                registeredCredits -= tmpCourse.Credits;
                creditsDisplayLabel.Text = registeredCredits.ToString();
            }
        }
    }    
}
