using System.Collections.Generic;
using Microsoft.Office.Interop.Excel;

namespace Howie_Math_Study.utility
{
    internal class WorksheetBuilder : IWorksheetBuilder
    {
        public Worksheet Build(IEnumerable<string> questions, Workbook excelBook)
        {
            if (excelBook == null)
            {
                return null;
            }

            var sheet = (Worksheet) excelBook.Worksheets[1];

            if (sheet == null)
            {
                return null;
            }

            var rowIndex = 1;
            var columnIndex = 1;

            var group = this.GetPageGroup(questions);

            foreach (var page in group)
            {
                foreach (var question in page)
                {
                    if (columnIndex > 5)
                    {
                        rowIndex++;
                        columnIndex = 1;
                    }

                    sheet.Cells[rowIndex, columnIndex] = question;
                    this.SetTopicCell(sheet.Cells[rowIndex, columnIndex] as Range);

                    columnIndex = columnIndex + 2;
                }

                rowIndex = rowIndex + 6;
            }


            this.SetSplitCell(sheet.Cells[1, 2] as Range);
            this.SetSplitCell(sheet.Cells[1, 4] as Range);

            return sheet;
        }

        public List<List<string>> GetPageGroup(IEnumerable<string> questions)
        {
            var group = new List<List<string>>();
            var pageQuestions = new List<string>();
            group.Add(pageQuestions);

            foreach (var question in questions)
            {
                if (pageQuestions.Count >= 60)
                {
                    pageQuestions = new List<string>();
                    group.Add(pageQuestions);
                }

                pageQuestions.Add(question);
            }

            return group;
        }


        private void SetTopicCell(Range cell)
        {
            cell.RowHeight = 37.5;
            cell.Font.Size = 20;
            cell.Font.FontStyle = "Verdana";
            cell.ColumnWidth = 24;
            cell.HorizontalAlignment = 4;
        }

        private void SetSplitCell(Range cell)
        {
            cell.ColumnWidth = 3.5;
        }
    }
}