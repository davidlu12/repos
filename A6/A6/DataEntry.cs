// A6, David Lu, CIS 345, T-TH 12pm
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

namespace A6
{
    // declare delegates
    public delegate void StaffCreated(object sender, EventArgs e);
    public delegate void StudentCreated(object sender, EventArgs e);

    public partial class DataEntry : Form
    {
        // used bindinglist to store student and staff list
        BindingList<Student> studentList;
        BindingList<Staff> staffList;

        public event StaffCreated NewStaffCreated;
        public event StudentCreated NewStudentCreated;

        public DataEntry()
        {
            InitializeComponent();
        }

        // stores name and id when create is clicked
        private void okButton_Click(object sender, EventArgs e)
        {
            if (!(studentRadioButton.Checked || staffRadioButton.Checked))
            {
                MessageBox.Show("Select Person Type");
                return;
            }
     
            // raise StudentCreated or StaffCreated event as appropriate
            // also called fire, trigger, invoke
            if (studentRadioButton.Checked && NewStudentCreated != null)
            {
                Student tmpStudent = new Student(nameTextBox.Text, idTextBox.Text);
                StudentEventArgs tmpArgs = new StudentEventArgs(tmpStudent);
                NewStudentCreated(this, tmpArgs);
                nameTextBox.Clear();
                idTextBox.Clear();
                nameTextBox.Focus();
            }
            else if (staffRadioButton.Checked && NewStaffCreated != null)
            {
                Staff tmpStaff = new Staff(nameTextBox.Text, idTextBox.Text);
                StaffEventArgs tmpArgs = new StaffEventArgs(tmpStaff);
                NewStaffCreated(this, tmpArgs);
                nameTextBox.Clear();
                idTextBox.Clear();
                nameTextBox.Focus();
            }
            
        }

        // load event handler instantiates bindingList
        private void Form1_Load(object sender, EventArgs e)
        {
            SetEventHandlers();
            studentList = new BindingList<Student>();
            studentListBox.DataSource = studentList;
            staffList = new BindingList<Staff>();
            staffListBox.DataSource = staffList;
        }

        // sets event handlers
        private void SetEventHandlers()
        {
            this.NewStaffCreated += new StaffCreated(this.DataEntry_StaffCreated);
            this.NewStudentCreated += new StudentCreated(this.DataEntry_StudentCreated);
        }

        // staff event handler
        private void DataEntry_StaffCreated(object sender, EventArgs e)
        {
            StaffEventArgs tmpArgs = null;

            if (e is StaffEventArgs)
            {
                // get staff out of e object and add to list
                tmpArgs = (StaffEventArgs)e;
                Staff tmpStaff = tmpArgs.Staff;
                staffList.Add(tmpStaff);

                statusLabel.Text = $"New Staff Added - {tmpStaff.StaffName}";
            }
            staffRadioButton.Checked = false;
        }

        // student Event handler
        private void DataEntry_StudentCreated(object sender, EventArgs e)
        {
            StudentEventArgs tmpArgs = null;

            if (e is StudentEventArgs)
            {
                // get student out of e object and add to list
                tmpArgs = (StudentEventArgs)e;
                Student tmpStudent = tmpArgs.Student;
                studentList.Add(tmpStudent);

                statusLabel.Text = $"New Student Added - {tmpStudent.Name}";
            }
            studentRadioButton.Checked = false;
        }

        // The Save event handler will call File I/O methods and save the student list to the disk. 
        private void saveStudentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog.FileName = "";
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
                    statusLabel.Text = "Student File Saved Successful";
                }
                catch (Exception)
                {
                    statusLabel.Text = "Student File Saved not Successful";
                }
            }
        }

        // The Open event handler will call File I/O methods and load a file from the disk. 
        private void openStudentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog.FileName = "";
                openFileDialog.Filter = "App Data Files (*.dat)|*.dat|All Files (*.*)|*.*";
                DialogResult dialogResult = openFileDialog.ShowDialog();

                if (dialogResult == DialogResult.OK)
                {
                    string fileName = openFileDialog.FileName;
                    FileStream file = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                    BinaryFormatter bf = new BinaryFormatter();
                    studentList = (BindingList<Student>)bf.Deserialize(file);
                    studentListBox.DataSource = studentList;
                    statusLabel.Text = "Student File Loaded";
                }
            }
            catch (Exception)
            {
                statusLabel.Text = "Student File Load Not Successful";
            }
        }

        // The Save event handler will call File I/O methods and save the staff list to the disk. 
        private void saveStaffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog.FileName = "";
            saveFileDialog.Filter = "App Data Files (*.dat)|*.dat|All Files (*.*)|*.*";
            DialogResult dialogResult = saveFileDialog.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                string fileName = saveFileDialog.FileName;
                try
                {
                    FileStream file = new FileStream(fileName, FileMode.Create, FileAccess.Write);
                    BinaryFormatter bf = new BinaryFormatter();
                    bf.Serialize(file, staffList);
                    file.Close();
                    statusLabel.Text = "Staff File Saved Successful";
                }
                catch (Exception)
                {
                    statusLabel.Text = "Staff File Save Unsuccessful";
                }
            }
        }

        // The Open event handler will call File I/O methods and load a file from the disk. 
        private void openStaffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog.FileName = "";
                openFileDialog.Filter = "App Data Files (*.dat)|*.dat|All Files (*.*)|*.*";
                DialogResult dialogResult = openFileDialog.ShowDialog();

                if (dialogResult == DialogResult.OK)
                {
                    string fileName = openFileDialog.FileName;
                    FileStream file = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                    BinaryFormatter bf = new BinaryFormatter();
                    staffList = (BindingList<Staff>)bf.Deserialize(file);
                    staffListBox.DataSource = staffList;
                    statusLabel.Text = "Staff File Loaded";
                }
            }
            catch (Exception)
            {
                statusLabel.Text = "Staff File Load Not Successful";
            }
        }
    }
}
