using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;

namespace Excelapp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String path = @"C:\ExcelPractice\FRM Inventory 01-31-2024.xlsx";

            

            Excel.Application _excelapp = new Excel.Application();


            _excelapp.Visible = false;
            _excelapp.DisplayAlerts = false;

            Excel.Workbook wb1 = _excelapp.Workbooks.Open(path);
            Excel.Worksheet ws1 = (Excel.Worksheet)wb1.Worksheets[1];
      



            ws1.Cells[1, 1] = "Hello Excel";


            //Excel.Worksheet ws2 = (Excel.Worksheet)wb1.Worksheets[2];

           

            String readdata = ws1.Cells[1, 1].ToString();
            Console.WriteLine("Value of cell=" + readdata);

            ws1.Cells.Font.Bold = true;
            ws1.Cells.Font.Italic = true;
            ws1.Cells.Interior.Color = Excel.XlRgbColor.rgbDarkCyan;


            //ws2.Cells.Font.Bold = true;
            //ws2.Cells.Font.Italic = true;
            //ws2.Cells.Interior.Color = Excel.XlRgbColor.rgbOrangeRed;

            // wb1.Save();

            wb1.Close();
            
            _excelapp.Quit();
            
            Marshal.ReleaseComObject(_excelapp);

        }
    }
}
