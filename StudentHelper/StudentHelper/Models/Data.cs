using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Xamarin.Forms;

namespace StudentHelper.Models
{
    public static class Data
    {
        public static Term CurrentTerm { get; set; }

        public static void Save()
        {
            DependencyService.Get<IFileWorker>().SaveDataAsync("Term.sh", CurrentTerm);
        }

        public static void Load()
        {
            CurrentTerm = DependencyService.Get<IFileWorker>().LoadDataAsync("Term.sh");
        }
    }
}
