using System;
using System.Windows.Forms;
using Ctrip.Duckbill;
using Ctrip.Duckbill.Extensions;
using Howie_Math_Study.questions;
using Howie_Math_Study.utility;
using Microsoft.Office.Interop.Excel;

namespace Howie_Math_Study
{
    public partial class Form1 : Form
    {
        private readonly Microsoft.Office.Interop.Excel.Application excel;
        private readonly IQuestionsBuilder tenPlusOneDigitQuestionsBuilder;
        private readonly IQuestionsBuilder ninePlusOneDigitQuestionsBuilder;
        private readonly IQuestionsBuilder eightPlusOneDigitQuestionsBuilder;
        private readonly IQuestionsBuilder tenSubtractionQuestionBuilder;
        private readonly IWorksheetBuilder worksheetBuilder;

        public Form1()
        {
            this.excel = new Microsoft.Office.Interop.Excel.Application();
            this.tenPlusOneDigitQuestionsBuilder = DuckBillContainer.Get<ITenPlusOneDigitQuestionBuilder>();
            this.ninePlusOneDigitQuestionsBuilder = DuckBillContainer.Get<INinePlusOneDigitQuestionBuilder>();
            this.eightPlusOneDigitQuestionsBuilder = DuckBillContainer.Get<IEightPlusOneDigitQuestionBuilder>();
            this.tenSubtractionQuestionBuilder = DuckBillContainer.Get<ITenSubtractionQuestionBuilder>();
            this.worksheetBuilder = DuckBillContainer.Get<IWorksheetBuilder>();
            InitializeComponent();
        }

        private void Generate10AddXButton_Click(object sender, EventArgs e)
        {
            var questions = this.tenPlusOneDigitQuestionsBuilder.Build(this.questionCountbox.Text.ToInt());
            var excelbook = this.GenerateWorkBook();

            var sheet = this.worksheetBuilder.Build(questions, excelbook);

            sheet.SaveAs("Howie10+.xlsx");
            excelbook.Close();
        }

        private void Generate9AddXButton_Click(object sender, EventArgs e)
        {
            var questions = this.ninePlusOneDigitQuestionsBuilder.Build(this.questionCountbox.Text.ToInt());
            var excelbook = this.GenerateWorkBook();

            var sheet = this.worksheetBuilder.Build(questions, excelbook);

            sheet.SaveAs("Howie9+.xlsx");
            excelbook.Close();
        }

        private void Generate8AddXButton_Click(object sender, EventArgs e)
        {
            var questions = this.eightPlusOneDigitQuestionsBuilder.Build(this.questionCountbox.Text.ToInt());
            var excelbook = this.GenerateWorkBook();

            var sheet = this.worksheetBuilder.Build(questions, excelbook);

            sheet.SaveAs("Howie8+.xlsx");
            excelbook.Close();
        }

        private Workbook GenerateWorkBook()
        {
            if (excel == null)
            {
                MessageBox.Show("Excel is not properly installed!!");
                return null;
            }

            var xlWorkBook = excel.Workbooks.Add(XlWBATemplate.xlWBATWorksheet);

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

        private void Generate10SubtractionXButton_Click(object sender, EventArgs e)
        {
            var questions = this.tenSubtractionQuestionBuilder.Build(this.questionCountbox.Text.ToInt());
            var excelbook = this.GenerateWorkBook();

            var sheet = this.worksheetBuilder.Build(questions, excelbook);

            sheet.SaveAs("Howie10-.xlsx");
            excelbook.Close();
        }
    }
}