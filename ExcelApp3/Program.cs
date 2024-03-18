using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using  Excel=Microsoft.Office.Interop.Excel;

namespace ExcelApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String path = @"C:\ExcelPractice\FRM Inventory 01-31-2024.xlsx";

            Excel.Application _app = new Excel.Application();

            _app.Visible = true;
            _app.DisplayAlerts = true;


            Excel.Workbook wb1 =   _app.Workbooks.Open(path);
            Excel.Worksheet ws1 = wb1.Worksheets[8];


            Excel.Range r1 = ws1.Range["A1:A23"];
          //  r1.Copy(Type.Missing);

       
            Excel.Range newr2 = ws1.Range["L1:L23"];
            // newr2.PasteSpecial(Excel.XlPasteType.xlPasteAll);


            //object[,] data = r1.Value;
            //newr2.Value = data;

            //string filePath = @"C:\ExcelPractice\FRM Inventory 01-31-2024.xlsx";
            //ws1.Parent.SaveAs(filePath);

              for(int i =1; i <=23 ; i++) 
              {
                newr2.Cells[i,12] = r1.Cells[i,1].ToString("dd/MM/yyyy");
              }


            Console.WriteLine("Successfull");

            wb1.Save();
            
            wb1.Close();

            _app.Quit();

            Marshal.ReleaseComObject(_app);

        }
    }
}
