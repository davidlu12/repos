using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// rename or make a "nick name" for a namespace
using Excel = Microsoft.Office.Interop.Excel;

namespace ExcelAPI12pm
{
    public partial class Form1 : Form
    {
        Excel.Application oXL;
        Excel.Workbook oWB;
        Excel.Worksheet oSheet;


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // call the Excel Application constructor
            oXL = new Excel.Application();

            //add a Workbook. Assign reference to oWB
            oWB = oXL.Workbooks.Add();

            // adds a new sheet
            oSheet = oWB.Sheets.Add();

            // place the text "hello world" in cell location 1, 1
            oSheet.Cells[1, 1] = "Hello World!";

            // show the Excel Application
            oXL.Visible = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            oXL.Quit();
        }
    }
}
