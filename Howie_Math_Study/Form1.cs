using System;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;

namespace Howie_Math_Study
{
    public partial class Form1 : Form
    {
        Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();

        public Form1()
        {
            InitializeComponent();
        }

        private void GenerateExcel_Click(object sender, EventArgs e)
        {
            var xlWorkSheet = (Worksheet) this.GenerateWorkBook().Worksheets[1];


            // Select the Excel cells, in the range c1 to c7 in the worksheet.
            Range aRange = xlWorkSheet.get_Range("C1", "C7");

//            if (aRange == null)
//            {
//                MessageBox.Show(
//                    "Could not get a range. Check to be sure you have the correct versions of the office DLLs.");
//            }
//
//            xlWorkSheet.Cells[1, 1] = "ID";
//            xlWorkSheet.Cells[1, 2] = "Name";
//            xlWorkSheet.Cells[2, 1] = "1";
//            xlWorkSheet.Cells[2, 2] = "One";
//            xlWorkSheet.Cells[3, 1] = "2";
//            xlWorkSheet.Cells[3, 2] = "Two";
//
//            xlWorkBook.SaveAs("e:\\test.xlsx");
        }

        private void Generate10AddXButton_Click(object sender, EventArgs e)
        {
            var data = new GenerateTenAddOneDigitNumber().GenerateGroups(50);
            var workbook = this.GenerateWorkBook();
            var xlWorkSheet = (Worksheet) workbook.Worksheets[1];

            if (xlWorkSheet == null)
            {
                return;
            }

            for (int index = 0; index < data.Length; index++)
            {
                xlWorkSheet.Cells[index + 1, 1] = data[index];
            }

            xlWorkSheet.SaveAs("test3.xlsx");
            workbook.Close();
        }

        private Workbook GenerateWorkBook()
        {
            if (xlApp == null)
            {
                MessageBox.Show("Excel is not properly installed!!");
                return null;
            }

            var xlWorkBook = xlApp.Workbooks.Add(XlWBATemplate.xlWBATWorksheet);

            var xlWorkSheet = (Worksheet) xlWorkBook.Worksheets[1];

            if (xlWorkSheet == null)
            {
                MessageBox.Show(
                    "Worksheet could not be created. Check that your office installation and project references are correct.");
                return null;
            }

            Range aRange = xlWorkSheet.get_Range("C1", "C7");

            if (aRange == null)
            {
                MessageBox.Show(
                    "Could not get a range. Check to be sure you have the correct versions of the office DLLs.");
                return null;
            }

            return xlWorkBook;
        }
    }
}