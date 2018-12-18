using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using Excel = Microsoft.Office.Interop.Excel;
using System.ComponentModel;

namespace SaveToExcel
{
    class MyExcel
    {
        public static string EXCEL_FILE_PATH = @"C:\Users.xls";

        private static Excel.Application objApplication = null;
        private static Excel.Workbook objWorkBook = null;
        private static Excel.Worksheet objWorksheet = null;
        private static int intlastRow = 0;

        public static void InitializeExcel()
        {
            objApplication = new Excel.Application();
            objApplication.Visible = false;
            objWorkBook = objApplication.Workbooks.Open(EXCEL_FILE_PATH);
            objWorksheet = (Excel.Worksheet)objWorkBook.Sheets[1]; 
            intlastRow = objWorksheet.Cells.SpecialCells(Excel.XlCellType.xlCellTypeLastCell).Row;
        }

        public static void WriteToExcel(User objUser)
        {
            try
            {
                intlastRow += 1;
                objWorksheet.Cells[intlastRow, 1] = objUser.Name;
                objWorksheet.Cells[intlastRow, 2] = objUser.Company;
                objWorksheet.Cells[intlastRow, 3] = objUser.Mobile;
                objWorkBook.Save();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
