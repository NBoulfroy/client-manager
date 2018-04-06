using System;

namespace DocumentLibrary
{
    [Serializable]
    public abstract class Document
    {
        string path;
        string file;

        public Document(string path, string file)
        {
            this.path = path;
            this.file = file;
        }

        #region Accessors

        public string GetPath() { return path; }
        public string GetFile() { return file; }

        #endregion
    }
}
