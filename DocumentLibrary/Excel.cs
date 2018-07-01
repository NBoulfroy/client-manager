using System;
using System.IO;
using System.Collections.Generic;
using OfficeOpenXml;
using DataLibrary;

namespace DocumentLibrary
{
    [Serializable]
    public sealed class Excel : Document, IDocument
    {
        private readonly FileInfo document;
        private readonly List<string> column;

        public Excel(string path, string file) : base(path, file)
        {
            document = new FileInfo(@"" + path + file);
            column = new List<string>() { "A", "B" };
        }

        #region Method

        public void DocumentBuilder(List<Customer> items)
        {
            // Sheet meter.
            int i = 1;
            // Column number.
            int colIndex = 1;
            // Data value meter.
            int nbValue = 0;

            using (ExcelPackage package = new ExcelPackage())
            {
                // Creates a worksheet into the document.
                ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Sheet " + i);

                foreach (Customer customer in items)
                {
                    nbValue++;

                    // Office 2010 doesn't like to read sheets with more 100 entries.
                    if (nbValue > 100)
                    {
                        i++;
                        nbValue = 1;
                        colIndex = 1;

                        worksheet = package.Workbook.Worksheets.Add("Sheet " + i);
                    }

                    worksheet.Cells[column[0] + colIndex].Value = customer.Customer_lastName;
                    worksheet.Cells[column[1] + colIndex].Value = customer.Customer_firstName;

                    worksheet.Cells.AutoFitColumns(0);

                    colIndex++;
                }
                
                // Saves the the file.
                package.SaveAs(document);
            }
        }

        #endregion
    }
}
