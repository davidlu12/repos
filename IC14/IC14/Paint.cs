// IC14, David Lu, CIS 345, T-Th 12pm
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IC14
{
    public partial class Paint : Form
    {
        private Color penColor;
        private Pen myPen;
        private Point previousPoint;
        private Point currentPoint;
        private Graphics myGraphics;
        private bool keepDrawing;

        public Paint()
        {
            InitializeComponent();
        }

        private void Paint_Load(object sender, EventArgs e)
        {
            previousPoint = new Point();
            currentPoint = new Point();
            penColor = Color.Black;
            keepDrawing = false;
            myPen = new Pen(penColor);
            myGraphics = this.CreateGraphics();
        }

        private void blackRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (blackRadioButton.Checked == true)
            {
                penColor = Color.Black;
            }
        }

        private void blueRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (blueRadioButton.Checked == true)
            {
                penColor = Color.Blue;
            }
        }

        private void greenRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (greenRadioButton.Checked == true)
            {
                penColor = Color.Green;
            }
        }

        private void redRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (redRadioButton.Checked == true)
            {
                penColor = Color.Red;
            }
        }

        private void smallRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (smallRadioButton.Checked == true)
            {
                myPen.Width = 2;
            }
        }

        private void mediumRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (mediumRadioButton.Checked == true)
            {
                myPen.Width = 4;
            }
        }

        private void largeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (largeRadioButton.Checked == true)
            {
                myPen.Width = 6;
            }
        }

        // The MouseDown event handler method is called when the user presses the Mouse button
        private void Paint_MouseDown(object sender, MouseEventArgs e)
        {
            keepDrawing = true;
            currentPoint = new Point(e.X,e.Y);
        }

        // The MouseUp event handler method is called when the user releases the Mouse button.
        private void Paint_MouseUp(object sender, MouseEventArgs e)
        {
            keepDrawing = false;
        }

        // The MouseMove event handler method is called when the user moves the Mouse button
        private void Paint_MouseMove(object sender, MouseEventArgs e)
        {
            if (keepDrawing == true)
            {
                previousPoint = currentPoint;
                currentPoint = new Point(e.X, e.Y);
                myPen.Color = penColor;
                myGraphics.DrawLine(myPen, previousPoint,currentPoint);
            }
        }
        // The CheckedChanged event handler method is called whenever the checkbox is selected or unselected.
        private void dottedLineCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (dottedLineCheckBox.Checked == true)
            {
                myPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            }
            else
            {
                myPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            }
        }

        //  The Click event handler method is called whenever the button is pressed. It will be used to clear the picture.        private void clearButton_Click(object sender, EventArgs e)
        {
            myGraphics.Clear(Color.White);
        }
    }
}
