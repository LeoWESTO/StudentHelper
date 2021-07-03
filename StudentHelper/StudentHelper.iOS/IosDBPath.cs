using System;
using System.IO;
using Xamarin.Forms;

[assembly: Dependency(typeof(StudentHelper.iOS.IosDBPath))]
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