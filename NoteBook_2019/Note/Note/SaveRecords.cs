using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
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

                PrintToExcelCells(ExcelApp, dataGridView);

                ExcelApp.Visible=true;
                ExcelApp.UserControl=true;

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        static private void PrintToExcelCells(Microsoft.Office.Interop.Excel.Application excelApp,
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

        static public void SaveToFile(List<Record> ListRecords)
        {
            try
            {
                LoginForm f2 = new LoginForm();
                int id = f2.id;

                using (FileStream fs = new FileStream(id.ToString() + ".dat", FileMode.OpenOrCreate))
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    formatter.Serialize(fs, ListRecords);

                    MessageBox.Show("Save complete!");
                    fs.Close();
                }
            }
            catch { return; }
        }
    }
}
