using Excel= Microsoft.Office.Interop.Excel;

namespace IneropPrac
{
    internal class Program
    {
        static void Main(string[] args)
        {

            String path = @"C:\Users\Nimap\Downloads\FRM Inventory 01-31-2024.xlsx";

            Excel.Application _excelapp = new Excel.Application();

            Excel.Workbook wb1 = _excelapp.Workbooks.Open(path);
            Excel.Worksheet ws1 = (Excel.Worksheet)wb1.Worksheets[1];

       

            ws1.Cells[1, 1] = "Hello Excel";

            String readdata = ws1.Cells[1, 1].ToString();
            Console.WriteLine("Value of cell="+readdata);

            ws1.Cells.Font.Bold = true;
            ws1.Cells.Font.Italic = true;
            ws1.Cells.Interior.Color = Excel.XlRgbColor.rgbAqua;

            wb1.Save();
            _excelapp.Quit();


            //Excel.Workbook workbook = application.Workbooks.Add();
            //Excel.Worksheet worksheet = (Excel.Worksheet)workbook.Worksheets[1];


            //Excel.Range cell = (Excel.Range)worksheet.Cells[1, 1];
            //cell.Value = "Hello,excel";

            //string cellvalue = cell.Value.ToString();
            //Console.WriteLine("value of string=" + cellvalue);


            //cell.Font.Bold = true;
            //cell.Interior.Color = Excel.XlRgbColor.rgbAqua;

            //workbook.SaveAs("exampe1s.xlsx");

            //workbook.Close();
            //application.Quit();
        }
    }
}
