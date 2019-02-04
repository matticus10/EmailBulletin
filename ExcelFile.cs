using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Excel = Microsoft.Office.Interop.Excel;

namespace EmailBulletin
{
    class ExcelFile
    {
        public Excel.Application excelApp;
        public Excel.Workbook xlWorkBook;
        public Excel.Worksheet sheet;
        public static string SendListPath { get; set; } = "";
        public static string IgnoreListPath { get; set; } = "";
        public static List<string> toList = new List<string>();
        public static List<string> ignoreList = new List<string>();
        private static string TempPath = Directory.GetCurrentDirectory() + "temp.xls";

        public static List<string> CreateSendList()
        {
            if (Errors.Count() == 0)
            {
                if (CopyFile(SendListPath))
                {
                    XlsToList("I", toList, true);
                }

                if (CopyFile(IgnoreListPath))
                {
                    XlsToList("A", ignoreList, false);
                }
            }
            
            return toList.Except(ignoreList).ToList();
        }

        public void CreateExcelInstance(string filePath)
        {
            try
            {
                excelApp = new Excel.Application();
                xlWorkBook = excelApp.Workbooks.Open(filePath);
                sheet = (Excel.Worksheet)excelApp.Sheets["Sheet1"];
                excelApp.Visible = false;
            }
            catch
            {

            }
        }

        private static bool CopyFile(string fromPath)
        {
            if (Errors.Count() == 0)
            {
                try
                {
                    File.Copy(fromPath, TempPath);
                    return true;
                }
                catch
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        private static void XlsToList (string emailColumn, List<string> list, bool unmerge)
        {
            ExcelFile excelFile = new ExcelFile();

            try
            {
                excelFile.CreateExcelInstance(TempPath);

                if (unmerge)
                {
                    excelFile.excelApp.Range["J:J"].UnMerge(); // cleans up exported email addresses in merged fields
                }

                var LastRow = excelFile.sheet.UsedRange.Rows.Count;
                LastRow = LastRow + excelFile.sheet.UsedRange.Row - 1;

                for (int i = 1; i <= LastRow; i++)
                {
                    Excel.Range excelRange = excelFile.excelApp.Range[emailColumn + i];

                    if (excelRange.Text.ToString().Contains("@"))
                    {
                        list.Add(excelRange.Text.ToString().Trim());
                    }
                }
            }
            finally
            {
                excelFile.xlWorkBook.Close(false);
                excelFile.excelApp.Quit();
                excelFile.releaseObject(excelFile.excelApp);
                excelFile.releaseObject(excelFile.xlWorkBook);
                File.Delete(TempPath);

            }
        }

        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception)
            {
                obj = null;
            }
            finally
            {
                GC.Collect();
            }
        }

        public static void ResetVariables()
        {
            SendListPath = "";
            IgnoreListPath = "";
            toList.Clear();
            ignoreList.Clear();
        }
    }
}
