using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using  Excel=Microsoft.Office.Interop.Excel;

namespace ExcelApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String path = @"C:\ExcelPractice\Book1.xlsx";

            Excel.Application _app = new Excel.Application();

            _app.Visible = true;
            _app.DisplayAlerts = true;

            Excel.Workbook wb1 = _app.Workbooks.Open(path);
            Excel.Worksheet ws1 = wb1.Worksheets[1];

          // ws1.Cells[1, 1] = "Day2";

            Excel.Range ws1_Range = ws1.UsedRange;

            int rows = ws1_Range.Rows.Count;
            int cols = ws1_Range.Columns.Count;

            Console.WriteLine(rows);
            Console.WriteLine(cols);

            
            //for (int i = 1; i <= rows; i++)
            //{
            //    for (int j = 1; j <= cols; j++)
            //    {
            //        if (ws1_Range.Cells[i, j] == null)
            //        {

            //            continue;


            //        }
            //        else
            //        {
            //            Console.WriteLine(ws1_Range.Cells[i, j].Value2.ToString() + "   ");
            //        }
            //    }
            //}


            Excel.Range operation = ws1.Range["A1:A15"];

              int i = 1;
            foreach (Excel.Range range in operation)
            {
               
                range.Value = "Day"+i;
                i++;
            }



            //copying data....!

            Excel.Range operation2 = ws1.Range["L1:L15"];

            for(int j=1;j<=15;j++)
            {
                operation2.Cells[j].Value= operation.Cells[j].Value;
            }



            //Excel.Range used = ws1.UsedRange;

            //foreach (Excel.Range range in used )
            //{
            //    if( range.Value !=null)
            //    {
            //        Console.Write(range.Value.ToString()+"  ");
            //    }
            //    else 
            //    {
            //       continue;
            //    }
            //}

            ws1.Cells[2, 4].Value = "Accessing cell 2,4";

            ws1.Cells.Range["E6:G10"].Value = "E6 TO G10";




            int n = ws1.Cells[13,1].End(Excel.XlDirection.xlToRight).Column;
            Excel.Range change = ws1.Range[ws1.Cells[13,1],ws1.Cells[13, n]];

            foreach (Excel.Range range in change)
            {
                range.Value = "Hello";
            }

            Excel.Worksheet ws2 = wb1.Worksheets[2];

            Excel.Range secondSheet = ws2.Range["A1:A15"];

            for(int k=1;k<=15;k++) 
            {
                secondSheet.Cells[k].Value = operation.Cells[k].value;
            }

            wb1.Close();
            _app.Quit();
            Marshal.ReleaseComObject(_app);



        }
    }
}
