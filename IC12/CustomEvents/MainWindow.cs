// IC12, David Lu, CIS 345, T-Th 12pm
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomEvents
{
    public partial class MainWindow : Form
    {
        StudentEntry studentForm;
        UpdateStudent updateForm;
        CourseEntry courseForm;
        BindingList<Course> courseList;
        Registrations registrationForm;

        Student selectedStudent;

        BindingList<Student> studentList;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void StudentForm_NewStudentCreated(object sender, EventArgs e)
        {
            // event handler for NewStudentCreated method
            // The EventArgs object is actually a DataEntryEventArgs object
            // Downcast it and store it in a variable of type DataEntryEventArgs
            StudentEventArgs tmpArgs = null;

            if (e is StudentEventArgs)
            {
                // get student out of e object and add to list
                tmpArgs = (StudentEventArgs)e;
                Student tmpStudent = tmpArgs.Student;
                studentList.Add(tmpStudent);

                statusLabel.Text = $"New Student Added - {tmpStudent.Name}";
                timer.Enabled = true;

            }

        }

        private void CourseForm_CourseCreated(object sender, EventArgs e)
        {
            if (e is CourseEventArgs)
            {
                CourseEventArgs tmpArgs = (CourseEventArgs)e;
                Course tmpCourse = tmpArgs.Course;
                courseList.Add(tmpCourse);

                statusLabel.Text = $"New Course Added - {tmpCourse.CourseName}";
                timer.Enabled = true;
            }
        }

        private void openFormButton_Click(object sender, EventArgs e)
        {

            
        }


        private void UpdateForm_StudentUpdated(object sender, EventArgs e)
        {
            if (e is StudentEventArgs)
            {
                // extract student out of e object and update status
                StudentEventArgs tmpArgs = (StudentEventArgs) e;
                Student tmpStudent = tmpArgs.Student;
                statusLabel.Text = $"Student Updated - {tmpStudent.Name}";
                timer.Enabled = true;

                // reset the bindings so that the listbox updates
                // manual refresh
                 studentList.ResetBindings();

            }
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            studentList = new BindingList<Student>();
            studentListBox.DataSource = studentList;

            courseList = new BindingList<Course>();
            courseListBox.DataSource = courseList;


        }

        private void timer_Tick(object sender, EventArgs e)
        {
            timer.Enabled = false;
            statusLabel.Text = "Ready";
        }

        private void studentListBox_DoubleClick(object sender, EventArgs e)
        {
            if (studentListBox.SelectedItem == null)
                return;

            // get the student which is currently selected
            selectedStudent = (Student)studentListBox.SelectedItem;

            // create the form
            updateForm = new UpdateStudent();

            // register the event handler
            updateForm.StudentUpdated += new EventHandler(this.UpdateForm_StudentUpdated);

            // show the form and set it to show details of the selected student
            updateForm.PopulateData(selectedStudent);
            updateForm.Show();

        }

        private void addStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // instantiate a new data entry form
            studentForm = new StudentEntry();

            // show the form
            studentForm.Show();

            // set eventhandler for NewStudentCreatedEvent
            studentForm.NewStudentCreated += new StudentCreated(this.StudentForm_NewStudentCreated);
        }

        private void addCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            courseForm = new CourseEntry();
            courseForm.CourseCreated += new EventHandler(this.CourseForm_CourseCreated);
            courseForm.Show();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog.Filter = "App Data Files (*.dat)|*.dat|All Files (*.*)|*.*";
            DialogResult dialogResult = saveFileDialog.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                string fileName = saveFileDialog.FileName;
                try
                {
                    FileStream file = new FileStream(fileName, FileMode.Create, FileAccess.Write);
                    BinaryFormatter bf = new BinaryFormatter();
                    bf.Serialize(file, studentList);
                    file.Close();
                    statusLabel.Text = "File saved.";

                }
                catch (Exception)
                {

                    statusLabel.Text = "Save Not successful";
                }

            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog.Filter = "App Data Files (*.dat)|*.dat|All Files (*.*)|*.*";
                openFileDialog.FilterIndex = 1;

                DialogResult dialogResult = openFileDialog.ShowDialog();

                if (dialogResult == DialogResult.OK)
                {
                    string fileName = openFileDialog.FileName;

                    FileStream file = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                    BinaryFormatter bf = new BinaryFormatter();
                    studentList = (BindingList<Student>)bf.Deserialize(file);
                    studentListBox.DataSource = studentList;
                    statusLabel.Text = "Data loaded";
                }

            }
            catch (Exception)
            {

                statusLabel.Text = "Data loading not successful";
            }
        }

        // The Edit Registration Menu Item needs to open the Registrations Form window and show it to the user
        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (studentListBox.SelectedItem == null)
            {
                MessageBox.Show("Select student for registration.");
                return;
            }
            selectedStudent = (Student) studentListBox.SelectedItem;
            registrationForm = new Registrations();
            registrationForm.SetRegistrationData(selectedStudent, courseList);
            registrationForm.Show();
        }
    }
}
