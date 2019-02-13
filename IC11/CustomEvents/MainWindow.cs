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
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace CustomEvents
{
    public partial class MainWindow : Form
    {
        CourseEntry courseForm;
        BindingList<Course> courseList;

        StudentEntry studentForm;
        UpdateStudent updateForm;

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

        // This will be the event handler for the CourseCreated event. Its purpose is to extract the Course object from within the object e, and add it to the list of courses.
        private void CourseCreated(object sender, EventArgs e)
        {
            CourseEventArgs tmpArgs = null;

            if (e is CourseEventArgs)
            {
                // get student out of e object and add to list
                tmpArgs = (CourseEventArgs)e;
                Course tmpCourse = tmpArgs.Course;
                courseList.Add(tmpCourse);

                statusLabel.Text = $"New Course Added - {tmpCourse.CourseName}";
                timer.Enabled = true;
            }
        }

        // The Add Course Menu Item will create an instance of the CourseEntry form. It will register the CourseCreated event handler.
        private void addCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // instantiate a new data entry form
            courseForm = new CourseEntry();

            // set eventhandler for courseCreated
            courseForm.CourseCreated += new EventHandler(this.CourseCreated);

            // show the form
            courseForm.Show();
        }

        // The Save event handler will call File I/O methods and save the student list to the disk. 
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog.FileName = "";
            saveFileDialog.Filter = "App Data Files (*.dat)|*.dat|All Files (*.*)|*.*";
            DialogResult dialogResult = saveFileDialog.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                string fileName = saveFileDialog.FileName;
                try
                {
                    FileStream file = new FileStream(fileName,FileMode.Create,FileAccess.Write);
                    BinaryFormatter bf = new BinaryFormatter();
                    bf.Serialize(file, studentList);
                    file.Close();
                    statusLabel.Text = "Save Successful";
                }
                catch (Exception)
                {
                    statusLabel.Text = "Save not Successful";
                }
            }
        }

        // The Open event handler will call File I/O methods and load a file from the disk. 
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog.FileName = "";
                openFileDialog.Filter = "App Data Files (*.dat)|*.dat|All Files (*.*)|*.*";
                DialogResult dialogResult = openFileDialog.ShowDialog();

                if(dialogResult == DialogResult.OK)
                {
                    string fileName = openFileDialog.FileName;
                    FileStream file = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                    BinaryFormatter bf = new BinaryFormatter();
                    studentList = (BindingList<Student>)bf.Deserialize(file);
                    studentListBox.DataSource = studentList;
                    statusLabel.Text = "Data File Loaded";
                }                
            }
            catch (Exception)
            {
                statusLabel.Text = "Data File Load Not Successful";
            }

        }
    }
}
