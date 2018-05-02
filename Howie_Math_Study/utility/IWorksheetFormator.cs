using System.Collections.Generic;
using Microsoft.Office.Interop.Excel;

namespace Howie_Math_Study.utility
{
    public interface IWorksheetBuilder
    {
        Worksheet Build(IEnumerable<string> questions, Workbook excelBook);
    }
}