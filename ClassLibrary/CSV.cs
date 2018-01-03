using System;
using System.IO;
using System.Text;
using System.Collections.Generic;

namespace ClassLibrary
{
    [Serializable]
    public class CSV
    {
        StringBuilder stringBuilder;
        string path;
        string file;

        public CSV(string path = "", string file = "spreadsheet.csv")
        {
            stringBuilder = new StringBuilder();
            this.path = path;
            this.file = file;
        }

        #region Accessors

        public StringBuilder GetStringBuilder() { return stringBuilder; }
        public string GetPath() { return path; }
        public string GetFile() { return file; }

        #endregion

        #region Methods

        public void HeaderBuilder(List<string> items)
        {
            string header = "";

            foreach (string item in items)
            {
                header += item + ",";
            }

            stringBuilder.AppendLine(header);
        }

        public void AddContent(List<Client> items)
        {
            foreach (Client item in items)
            {
                stringBuilder.AppendLine(item.GetLastName() + "," + item.GetFirstName());
            }
        }

        public void FileCreation()
        {
            File.AppendAllText(path + file, stringBuilder.ToString());
        }

        #endregion
    }
}
