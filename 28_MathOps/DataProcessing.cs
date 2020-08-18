using Microsoft.Office.Interop;
using System;
using System.Collections.Generic;
using System.Text;
using Excel = Microsoft.Office.Interop.Excel;

namespace _28_MathOps
{
    class DataProcessing : MathOperations
    {
        string path = @"C:\Users\Ognjan.Eskic\source\repos\MentorshipCSharpProgram\28_MathOps\src\Data\DataInput.xlsx";
        public void Processing()
        {
            var exApp = new Microsoft.Office.Interop.Excel.Application();
            var wb = exApp.Workbooks.Open(path);
            var ws = (Microsoft.Office.Interop.Excel.Worksheet)wb.Sheets["Sheet1"];
        }
         
    }
}
