using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
using DataLibrary;

namespace DocumentLibrary
{
    [Serializable]
    public class CSV : Document, IDocument
    {
        StringBuilder stringBuilder;

        /// <summary>
        /// CSV's constructor.
        /// </summary>
        /// <param name="path">File's path</param>
        /// <param name="file">File's name</param>
        public CSV(string path, string file) : base(path, file)
        {
            stringBuilder = new StringBuilder();
        }

        #region Methods

        /// <summary>
        /// Creates header in CSV file.
        /// </summary>
        /// <param name="items">List of values which uses like header into the document</param>
        public void HeaderBuilder(List<string> items)
        {
            string header = "";

            foreach (string item in items)
            {
                header += item + ",";
            }

            stringBuilder.AppendLine(header);
        }

        /// <summary>
        /// Adds content in CSV file and creates it.
        /// </summary>
        /// <param name="items">List of customers</param>
        public void DocumentBuilder(List<Customer> items)
        {
            foreach (Customer item in items)
            {
                stringBuilder.AppendLine(item.Customer_lastName + "," + item.Customer_firstName);
            }

            File.AppendAllText(GetPath() + GetFile(), stringBuilder.ToString());
        }

        #endregion
    }
}
