using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
using ClassLibrary;

namespace DocumentLibrary
{
    [Serializable]
    public class CSV : IDocument
    {
        StringBuilder stringBuilder;
        string path;
        string file;

        public CSV(string path, string file)
        {
            stringBuilder = new StringBuilder();
            this.path = path;
            this.file = file;
        }

        #region Accessors

        public string GetPath() { return path; }
        public string GetFile() { return file; }

        #endregion

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

            File.AppendAllText(path + file, stringBuilder.ToString());
        }

        #endregion
    }
}
