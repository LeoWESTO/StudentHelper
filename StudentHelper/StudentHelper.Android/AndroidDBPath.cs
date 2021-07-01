using System.IO;

namespace StudentHelper.Droid
{
    public class AndroidDBPath : IFileWorker
    {
        public string GetDatabasePath(string name)
        {
            return Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), name);
        }
    }
}