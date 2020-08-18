using System;
using Microsoft.Office.Interop;
using Excel = Microsoft.Office.Interop.Excel;

namespace _28_MathOps
{
    class Program
    {
        static void openFile()
        {
            string path = @"C:\Users\Ognjan.Eskic\source\repos\MentorshipCSharpProgram\28_MathOps\src\Data\DataInput.xlsx";
            var excelApp = new Excel.Application();
            excelApp.Visible = true;
            Excel.Workbooks books = excelApp.Workbooks;
            Excel.Workbook sheet = books.Open(path);
        }
        static void Main(string[] args)
        {
            openFile();

        }
    }
}
