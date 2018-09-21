using System;
using System.Collections.Generic;
using DataLibrary;
using PdfSharp.Pdf;
using PdfSharp.Drawing;
using PdfSharp.Drawing.Layout;

namespace DocumentLibrary
{
    [Serializable]
    public class PortableDocument : Document, IDocument
    {
        private readonly PdfDocument pdf;
        private readonly string title;
        private int x;
        private int y;

        public PortableDocument(string path, string file, string title, int x, int y) : base(path, file)
        {
            pdf = new PdfDocument();
            this.title = title;
            this.x = x;
            this.y = y;
        }

        #region Method

        /// <summary>
        /// Creates a Portable Document File.
        /// </summary>
        /// <param name="items">List of values which uses like header into the document</param>
        public void DocumentBuilder(List<Customer> items)
        {
            // Sets a title to the document.
            pdf.Info.Title = title;

            // Adds page into the document.
            PdfPage page = pdf.AddPage();

            // 
            XGraphics graph = XGraphics.FromPdfPage(page);

            // Sets a font.
            XFont font = new XFont(
                "Times new roman",
                11, 
                XFontStyle.Regular
            );

            foreach (Customer customer in items)
            {
                XTextFormatter tf = new XTextFormatter(graph);
                tf.Alignment = XParagraphAlignment.Left;

                tf.DrawString(
                    customer.Customer_lastName + " " + customer.Customer_firstName, 
                    font, 
                    XBrushes.Black,
                    new XRect(x, y, page.Width - 200, 600), 
                    XStringFormats.TopLeft
                );

                y += 15;
            }

            // Saves file.
            pdf.Save(GetPath() + GetFile());
        }

        #endregion
    }
}
