using System;
using System.Collections.Generic;
using GemBox.Spreadsheet;
using DataLibrary;

namespace DocumentLibrary
{
    [Serializable]
    public class OpenDocumentSpreadsheet : IDocument
    {
        ExcelFile excelFile;
        string path;
        string file;
        int columnCount;
        ExcelWorksheet excelWorksheet;

        public OpenDocumentSpreadsheet(string path = "", string file = "spreadsheet.ods")
        {
            SpreadsheetInfo.SetLicense("FREE-LIMITED-KEY");
            excelFile = new ExcelFile();
            this.path = path;
            this.file = file;
        }

        #region Accessors

        public string GetPath() { return path; }
        public string GetFile() { return file; }

        #endregion

        #region Method

        /// <summary>
        /// ODS file generation.
        /// </summary>
        public void DocumentBuilder(List<Customer> items)
        {
            int i = 1;
            int j = 0;
            int k = 0;
            int nbValue = 0;

            excelWorksheet = excelFile.Worksheets.Add("paper" + i);

            foreach (Customer item in items)
            {
                nbValue++;

                if (nbValue == 20)
                {
                    i++;
                    j = 0;
                    k = 0;
                    nbValue = 0;

                    excelWorksheet = excelFile.Worksheets.Add("paper" + i);
                }

                excelWorksheet.Cells[j, k].Value = item.GetLastName();
                k++;
                excelWorksheet.Cells[j, k].Value = item.GetFirstName();
                j++;
                k--;

                columnCount = excelWorksheet.CalculateMaxUsedColumns();
                for (int l = 0; l < columnCount; l++)
                    excelWorksheet.Columns[l].AutoFit(1, excelWorksheet.Rows[1], excelWorksheet.Rows[excelWorksheet.Rows.Count - 1]);
            }

            excelFile.Save(path + file);
        }

        #endregion
    }
}
