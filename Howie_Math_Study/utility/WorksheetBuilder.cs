using System.Collections.Generic;
using System.Linq;
using Microsoft.Office.Interop.Excel;

namespace Howie_Math_Study.utility
{
    internal class WorksheetBuilder : IWorksheetBuilder
    {
        public Worksheet Build(string[] questions, Workbook excelBook)
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
                    if (columnIndex > 8)
                    {
                        rowIndex++;
                        columnIndex = 1;
                    }

                    sheet.Cells[rowIndex, columnIndex] = question;
                    this.SetTopicCell((Range) sheet.Cells[rowIndex, columnIndex]);
                    this.SetResultCell((Range) sheet.Cells[rowIndex, columnIndex + 1]);


                    columnIndex = columnIndex + 3;
                }

                rowIndex = rowIndex + 6;
            }


            this.SetSplitCell((Range) sheet.Cells[1, 3]);
            this.SetSplitCell((Range) sheet.Cells[1, 6]);

            return sheet;
        }

        public List<List<string>> GetPageGroup(string[] questions)
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
            cell.ColumnWidth = 14.75;
        }

        private void SetResultCell(Range cell)
        {
            cell.Borders.LineStyle = 1;
            cell.Borders.get_Item(XlBordersIndex.xlEdgeTop).LineStyle = XlLineStyle.xlContinuous;
            cell.Borders.get_Item(XlBordersIndex.xlEdgeBottom).Weight = XlBorderWeight.xlThin;
        }

        private void SetSplitCell(Range cell)
        {
            cell.ColumnWidth = 5;
        }
    }
}