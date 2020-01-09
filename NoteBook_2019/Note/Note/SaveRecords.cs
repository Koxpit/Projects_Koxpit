using System;
using System.Windows.Forms;

namespace Note
{
    static class SaveRecords
    {
        static public void SaveToExcel(DataGridView dataGridView)
        {
            try
            {
                Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel.Workbook ExcelWorkBook;
                Microsoft.Office.Interop.Excel.Worksheet ExcelWorkSheet;

                ExcelWorkBook=ExcelApp.Workbooks.Add(System.Reflection.Missing.Value);
                ExcelWorkSheet=(Microsoft.Office.Interop.Excel.Worksheet)ExcelWorkBook.Worksheets.get_Item(1);

                PrintRecordsToExcelCells(ExcelApp, dataGridView);

                ExcelApp.Visible=true;
                ExcelApp.UserControl=true;

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        static private void PrintRecordsToExcelCells(Microsoft.Office.Interop.Excel.Application excelApp,
            DataGridView dataGridView)
        {
            for (int i = 0; i<dataGridView.Rows.Count; i++)
            {
                for (int j = 0; j<dataGridView.ColumnCount; j++)
                {
                    excelApp.Cells[i+1, j+1]=dataGridView.Rows[i].Cells[j].Value;
                }
            }
        }
    }
}
