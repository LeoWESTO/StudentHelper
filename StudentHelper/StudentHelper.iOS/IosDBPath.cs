using System;
using System.IO;

namespace StudentHelper.iOS
{
    public class IosDBPath : IFileWorker
    {
        public string GetDatabasePath(string name)
        {
            return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "..", "Library", name);
        }
    }
}