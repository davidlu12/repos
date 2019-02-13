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

namespace DialogBoxesTabs12pm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog.FileName = "";
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files(*.*)|*.*";
            DialogResult result  = openFileDialog.ShowDialog();
           
            if (result == DialogResult.OK)
            {
                string fileName = openFileDialog.FileName;
                MessageBox.Show($"You opened {fileName}");
            }

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            saveFileDialog.FileName = "";
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files(*.*)|*.*";
            DialogResult result = saveFileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                string fileName = saveFileDialog.FileName;
                MessageBox.Show($"You saved {fileName}");
            }

        }
    }
}
