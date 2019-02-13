// IC15, David Lu, CIS 345, T-TH 12pm
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace IC15
{
    public partial class DataEntry : Form
    {
        // .NET Object References
        Excel.Application oXL;
        Excel.Workbook oWB;
        Excel.Worksheet oSheet;

        // non-.NET instance variables
        int[] scoreArray;
        int scoreCount;

        public DataEntry()
        {
            InitializeComponent();
            scoreCount = 0;
            scoreArray = new int[10];
        }

        //  It should take the score from the TextBox and copy it into the array.
        private void nextButton_Click(object sender, EventArgs e)
        {
            scoreArray[scoreCount] = Convert.ToInt32(scoreTextBox.Text);
            scoreCount++;
            scoreTextBox.Text = string.Empty;
            scoreTextBox.Focus();
        }

        // Assign it to your Application object reference, oXL.
        private void openButton_Click(object sender, EventArgs e)
        {
            oXL = new Excel.Application();
            oXL.Visible = true;
            oWB = oXL.Workbooks.Add();
            oSheet = oWB.Worksheets.Add();

            for (int i = 1; i < scoreCount; i++)
            {
                oSheet.Cells[i,2] = scoreArray[i-1];
            }

            string fromCell;
            string toCell;

            fromCell = "B1";
            toCell = $"B{scoreCount}";

            oSheet.Cells[scoreCount + 1,1] = "Average";
            oSheet.Cells[scoreCount + 1,2] = $"=AVERAGE({fromCell}:{toCell})";
            oSheet.Cells[scoreCount + 2,1] = "Median";
            oSheet.Cells[scoreCount + 2,2] = $"=MEDIAN({fromCell}:{toCell})";
        }

        // save excel
        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                oWB.SaveAs("DataFile");
            }
            catch (Exception)
            {
                MessageBox.Show("There was an error!");
            }
        }

        // exits excel
        private void exitButton_Click(object sender, EventArgs e)
        {
            try
            {
                oWB.Close();
                oXL.Quit();
            }
            catch (Exception)
            {
                MessageBox.Show("There was an error!");
            }
        }
    }
}
