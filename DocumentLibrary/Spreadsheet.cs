using System;
using System.Collections.Generic;
using ExcelLibrary.SpreadSheet;
using ClassLibrary;

namespace DocumentLibrary
{
    [Serializable]
    public class Spreadsheet : Document, IDocument
    {
        Workbook workbook;

        public Spreadsheet(string path, string file) : base(path, file)
        {
            workbook = new Workbook();
        }

        #region Method

        public void DocumentBuilder(List<Customer> items)
        {
            // Sheet meter.
            int i = 1;
            // Row number.
            int j = 0;
            // Column number.
            int k = 0;
            // Data value meter.
            int nbValue = 0;

            // Sheet creation.
            Worksheet worksheet = new Worksheet("sheet" + i);

            foreach (Customer customer in items)
            {
                nbValue++;

                // Office 2010 don't like to read sheets with more 100 entries.
                if (nbValue > 100)
                {
                    workbook.Worksheets.Add(worksheet);

                    i++;
                    j = 0;
                    k = 0;
                    nbValue = 1;

                    worksheet = new Worksheet("sheet" + i);
                }

                worksheet.Cells[j, k] = new Cell(customer.GetLastName());
                worksheet.Cells.ColumnWidth[(ushort)j, (ushort)k] = (ushort)10000;
                k++;
                worksheet.Cells[j, k] = new Cell(customer.GetFirstName());
                worksheet.Cells.ColumnWidth[(ushort)j, (ushort)k] = (ushort)10000;
                j++;
                k--;
            }

            workbook.Worksheets.Add(worksheet);
            workbook.Save(GetPath() + GetFile());
        }

        #endregion
    }
}
