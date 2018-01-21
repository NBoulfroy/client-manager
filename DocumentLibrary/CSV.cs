using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
using ClassLibrary;

namespace DocumentLibrary
{
    [Serializable]
    public class CSV : Document, IDocument
    {
        StringBuilder stringBuilder;

        public CSV(string path, string file) : base(path, file)
        {
            stringBuilder = new StringBuilder();
        }

        #region Methods

        /// <summary>
        /// Creates header in CSV file.
        /// </summary>
        /// <param name="items"></param>
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
        /// <param name="items"></param>
        public void DocumentBuilder(List<Customer> items)
        {
            foreach (Customer item in items)
            {
                stringBuilder.AppendLine(item.GetLastName() + "," + item.GetFirstName());
            }

            File.AppendAllText(GetPath() + GetFile(), stringBuilder.ToString());
        }

        #endregion
    }
}
