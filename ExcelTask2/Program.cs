using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;

namespace ExcelTask2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            String path1 = @"C:\ExcelProject\Reports\Task 2\OneDrive_2023-12-28 week\week 47\Week 47 Sales 2023-11-20.xlsm";
            String path2 = @"C:\ExcelProject\Reports\Task 2\ChngeDemo.xlsx";

            Excel.Application _app = new Excel.Application();

            _app.Visible = true;
            _app.DisplayAlerts = true;


            //Getting total numbers of stores===========

            Excel.Workbook listofstores = _app.Workbooks.Open(path1);
            Excel.Worksheet listStore = listofstores.Worksheets["Week 42"];

            Excel.Workbook zeesales = _app.Workbooks.Open(path2);
            Excel.Worksheet zeealesheet = zeesales.Worksheets["Sheet1"]; 


             //  Excel.Workbook weeklyreport = _app.Workbooks.Open(path2);
              //  Excel.Worksheet weekno = _app.Worksheets["Week 47"];


              // Excel.Range col1 = listStore.Columns["A"];

              // int n1= col1.Rows.Count;


            int lastRow = listStore.Cells.Find("*", Missing.Value, Missing.Value, Missing.Value,
                  Excel.XlSearchOrder.xlByRows, Excel.XlSearchDirection.xlPrevious,
                  false, Missing.Value, Missing.Value).Row;


            List<string> list1 = new List<string>() { "R1","D1","D3","D6","D8","R2","D2","D7","D9"};

              int numberofstores = 0;
           
             for (int i = 1; i <= lastRow; i++)
             {
                //if (col1.Cells[i].Value == "R1" || col1.Cells[i].Value == "D1" || col1.Cells[i].Value == "D3"|| col1.Cells[i].Value == "D6" || col1.Cells[i].Value == "D8" || col1.Cells[i].Value == "R2" ||
                //    col1.Cells[i].Value == "D2" || col1.Cells[i].Value == "D7" || col1.Cells[i].Value == "D9" )
                //{

                //    numberofstores= col1.Cells[i+1].Value;
                //}

                /*

                                    if(v1 == col1.Cells.Value[i])
                                    {
                                        numberofstores += col1.Cells[i + 1].Value;
                                */


                if (listStore.Cells[i, 1].Value == null)
                {
                    continue;
                }
                else
                {

                    if (list1.Contains(listStore.Cells[i, 1].Value.ToString()))
                    {
                        numberofstores += listStore.Cells[i + 1, 1].Value;
                    }
                }
                //foreach (var v1 in list1)
                //{


                //    if (v1.Equals(listStore.Cells[i,1].Value))
                //    {

                //        var rowcount = listStore.Cells[i + 1, 1].Value;
                //        int n2 =(int)rowcount;


                //       numberofstores += n2;


                //    }
                    

                //}
             }

            Console.WriteLine(numberofstores);
           


            var date1 = listStore.Cells[3,3].Value.ToString("dd/MM/yyyy");

            Console.WriteLine(date1);



            int wtdstors=(int)listStore.Cells[lastRow, 3].Value;
            //   var wtdpercentage = "("+listStore.Cells[lastRow, 6].Value.ToString("0.00")+")";
            //   var wtdpercentage1 = -(double.Parse(wtdpercentage));

            var wtdpercentage  =  listStore.Cells[lastRow, 6].Value.ToString("0.00") ;
            var wtdpercentage1 = double.Parse(wtdpercentage);
                wtdpercentage1 = Math.Abs(wtdpercentage1);

            var wtdpercentage2="("+wtdpercentage1+")";

            Console.WriteLine(wtdstors);
            Console.WriteLine(wtdpercentage2);


            var wtdTrans = ((listStore.Cells[(lastRow-1), 26].Value)/numberofstores);
            var wtdtranpercentage   = listStore.Cells[(lastRow-1),28].Value.ToString("0.00");
            var wtdtranspercentage1 = double.Parse(wtdtranpercentage);
                wtdtranspercentage1 = Math.Abs(wtdtranspercentage1);
            var wtdtranspercentage2 = "(" + wtdtranspercentage1 + ")";

            Console.WriteLine(wtdTrans);
            Console.WriteLine(wtdtranspercentage2);
          


            var chekAvg = (wtdstors/wtdTrans).ToString("0.00");

            Console.WriteLine(chekAvg);



            //CHANGING THE DATA

            zeealesheet.Cells[4, 2].Value = numberofstores;
            zeealesheet.Cells[7, 2].Value = date1;
            zeealesheet.Cells[7, 3].Value = wtdstors;
            zeealesheet.Cells[7, 4].Value = wtdpercentage2;
            zeealesheet.Cells[7, 5].Value = wtdTrans;
            zeealesheet.Cells[7, 6].Value = wtdtranspercentage2;
            zeealesheet.Cells[7, 7].Value = chekAvg;




            listofstores.Close();
            zeesales.Close();
            _app.Quit();
            Marshal.ReleaseComObject(_app);





        }
    }
}
