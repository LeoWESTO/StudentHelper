using System.IO;
using Xamarin.Forms;

[assembly: Dependency(typeof(StudentHelper.Droid.AndroidDBPath))]
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