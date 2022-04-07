using Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;
using _Excel = Microsoft.Office.Interop.Excel;

namespace CRR4app
{
    internal class ExcelWorker : IDisposable
    {
        string path;
        Workbook wb;
        Worksheet ws;
        _Application excel = new _Excel.Application();
        public ExcelWorker(string path, int sheet)
        {
            this.path = path;
            wb = excel.Workbooks.Open(path);
            ws = wb.Worksheets[sheet];
        }
        public string ReadCell(int Rows, int Colums)
        {
            if (ws.Cells[Rows, Colums].Value2 != null)
                return ws.Cells[Rows, Colums].Value2.ToString();
            else
                return "";
        }
        public double ReadCellDouble(int Rows, int Colums)
        {
            if (ws.Cells[Rows, Colums].Value2 != null)
                return ws.Cells[Rows, Colums].Value2;
            else
                return 0d;
        }
        public void WriteToCell(int Rows, int Colums, string Valuestring = "", double Valuedouble = 0d)
        {
            if (Valuestring == "")
                ws.Cells[Rows, Colums].Value2 = Valuedouble;
            else
                ws.Cells[Rows, Colums].Value2 = Valuestring;
        }
        public void SaveAs(string path)
        {
            try
            {
                wb.SaveAs(path);

                MessageBox.Show("Файл скорректирован");
            }
            catch (System.Runtime.InteropServices.COMException)
            {
                MessageBox.Show("Изменения не приняты");
            }
            //try {  }
            //catch (Exception) { MessageBox.Show("Вы не закрыли файл перед изменением, не забудьте проверить открытую программу EXELE.EXE в диспечере задачь"); }
        }
        public void Dispose()
        {
            Marshal.ReleaseComObject(wb);
            Marshal.ReleaseComObject(ws);
            excel.Quit();
        }
    }
}
