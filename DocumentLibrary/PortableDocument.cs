using System;
using System.Collections.Generic;
using DataLibrary;
using PdfSharp.Pdf;
using PdfSharp.Fonts;
using PdfSharp.Pdf.IO;
using PdfSharp.Drawing;

namespace DocumentLibrary
{
    [Serializable]
    public class PortableDocument : Document, IDocument
    {
        private readonly PdfDocument pdf;
        private readonly string title;

        public PortableDocument(string path, string file, string title) : base(path, file)
        {
            pdf = new PdfDocument();
            this.title = title;
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

            // Sets a font.
            XFont font = new XFont("Times new roman", 20, XFontStyle.Regular);
        }

        #endregion
    }
}
