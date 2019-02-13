// IC16, David Lu, CIS345, T-Th 12pm
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;

namespace IC16
{
    public partial class CoverLetter : Form
    {
        Word.Application wordApp;
        Word.Document document;
        Word.Paragraph paragraph;

        public CoverLetter()
        {
            InitializeComponent();
        }

        private void CoverLetter_Load(object sender, EventArgs e)
        {
            wordApp = new Word.Application();
            wordApp.Visible = false;
        }

        private void CoverLetter_FormClosing(object sender, FormClosingEventArgs e)
        {
            wordApp.Quit();
        }

        // generate document 
        private void generateDocumentButton_Click(object sender, EventArgs e)
        {
            string letterText;
            letterText = $"Dear {nameTextBox.Text}\n" +
                $"Thank you for meeting with me at the recent career fair. " +
                $"I enjoyed learning about {topicTextBox.Text} at {companyTextBox.Text}.";

            document = wordApp.Documents.Add();
            paragraph = document.Paragraphs.Add();

            Word.Font wordFont = new Word.Font();
            wordFont.Name = "Times New Roman";
            wordFont.Size = 12;

            paragraph.Range.Font = wordFont;
            paragraph.Range.InsertBefore(letterText);

            paragraph = document.Paragraphs.Add();
            paragraph.Range.InsertBefore(miscTextBox.Text);

            string fileName = $"{companyTextBox.Text}.docx";
            document.SaveAs2(fileName);
            document.Close(Word.WdSaveOptions.wdDoNotSaveChanges);
        }
    }
}
