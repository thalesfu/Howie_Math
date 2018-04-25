using Microsoft.Office.Interop.Excel;

namespace Howie_Math_Study.utility
{
    public interface IWorksheetBuilder
    {
        Worksheet Build(string[] questions, Workbook excelBook);
    }
}