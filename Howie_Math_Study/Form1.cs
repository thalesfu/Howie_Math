﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
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

        private readonly Dictionary<string, IQuestionsBuilder> questionBuilders;

        private readonly IWorksheetBuilder worksheetBuilder;

        private readonly INow now;

        private const string Choice = "choice";

        public Form1()
        {
            this.excel = new Microsoft.Office.Interop.Excel.Application();
            this.questionBuilders = new Dictionary<string, IQuestionsBuilder>
            {
                {"TenPlusXButton", DuckBillContainer.Get<ITenPlusXQuestionBuilder>()},
                {"NinePlusXButton", DuckBillContainer.Get<INinePlusXQuestionBuilder>()},
                {"EightPlusXButton", DuckBillContainer.Get<IEightPlusXQuestionBuilder>()},
                {"SevenPlusXButton", DuckBillContainer.Get<ISevenPlusXQuestionBuilder>()},
                {"SixPlusXButton", DuckBillContainer.Get<ISixPlusXQuestionBuilder>()},
                {"FivePlusXButton", DuckBillContainer.Get<IFivePlusXQuestionBuilder>()},
                {"X0PlusY0Button", DuckBillContainer.Get<IX0PlusY0QuestionsBuilder>()},
                {"TenSubtractionXButton", DuckBillContainer.Get<ITenSubtractionXQuestionBuilder>()}
            };


            this.worksheetBuilder = DuckBillContainer.Get<IWorksheetBuilder>();
            this.now = DuckBillContainer.Get<INow>();
            InitializeComponent();
        }

        private void Generate10AddXButton_Click(object sender, EventArgs e)
        {
//            var questions = this.tenPlusOneDigitQuestionsBuilder.Build(this.questionCountbox.Text.ToInt());
//            var excelbook = this.GenerateWorkBook();
//
//            var sheet = this.worksheetBuilder.Build(questions, excelbook);
//
//            sheet.SaveAs($"10+X_{this.now.DateTime.ToString("yyyyMMddhhmmss")}.xlsx");
//            excelbook.Close();
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
//            var questions = this.tenSubtractionXQuestionBuilder.Build(this.questionCountbox.Text.ToInt());
//            var excelbook = this.GenerateWorkBook();
//
//            var sheet = this.worksheetBuilder.Build(questions, excelbook);
//
//            sheet.SaveAs($"10-X_{this.now.DateTime.ToString("yyyyMMddhhmmss")}.xlsx");
//            excelbook.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (Control control in this.questionPanel.Controls) //遍历Form上的所有控件  
            {
                var button = control as System.Windows.Forms.Button;

                if (button == null)
                {
                    continue;
                }

                button.Click += SwitchButtonStatus;
            }

            this.PageCountControl.SelectedItem = "1";
        }

        private static void SwitchButtonStatus(object sender, EventArgs e)
        {
            var button = sender as System.Windows.Forms.Button;

            if (button == null)
            {
                return;
            }

            if (button.Tag == null)
            {
                button.Tag = Choice;
                button.BackColor = Color.FromKnownColor(KnownColor.ButtonShadow);
            }
            else
            {
                button.BackColor = Color.FromKnownColor(KnownColor.ControlLight);
                button.Tag = null;
            }
        }

        private void PrintButton_Click(object sender, EventArgs e)
        {
            var questions = this.GenerateQuestions();

            var excelbook = this.GenerateWorkBook();
            this.worksheetBuilder.Build(questions, excelbook);

            excelbook.PrintOut();
            excelbook.Close(false);
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            var questions = this.GenerateQuestions();

            var excelbook = this.GenerateWorkBook();
            var sheet = this.worksheetBuilder.Build(questions, excelbook);

            sheet.SaveAs($"Questions_{this.now.DateTime:yyyyMMddhhmmss}.xlsx");
            MessageBox.Show($"文件已经保存到{excelbook.FullName}");
            excelbook.Close();
        }

        private List<string> GenerateQuestions()
        {
            var questions = new List<string>();

            var questionTypes = this.questionPanel.Controls.Cast<Control>()
                .Where(control =>
                    control is System.Windows.Forms.Button && Choice.Equals(control.Tag) &&
                    this.questionBuilders.ContainsKey(control.Name))
                .Select(control => this.questionBuilders[control.Name])
                .ToArray();

            if (questionTypes.Length == 0)
            {
                MessageBox.Show("没有选择任何题目");
                return questions;
            }

            var pagesize = this.PageSizeControl.Text.ToDecimal();

            if (pagesize == decimal.Zero)
            {
                MessageBox.Show("每页数量为0");
                return questions;
            }

            var pagecount = this.PageCountControl.SelectedItem.ToInt();

            if (pagecount == 0)
            {
                MessageBox.Show("页数为0");
                return questions;
            }


            for (var page = 1; page <= pagecount; page++)
            {
                var perTypeQuestionCount = Math.Ceiling(pagesize / questionTypes.Length.ToDecimal()).ToInt();

                questions.AddRange(questionTypes.SelectMany(type => type.Build(perTypeQuestionCount))
                    .OrderBy(question => Guid.NewGuid()));
            }

            return questions;
        }
    }
}