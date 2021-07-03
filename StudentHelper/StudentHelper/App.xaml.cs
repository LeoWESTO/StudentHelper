using StudentHelper.Models;
using StudentHelper.Views;
using System;
using System.Linq;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Collections.ObjectModel;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace StudentHelper
{
    public partial class App : Application
    {
        private static readonly string dbNAME = "data.db";
        private static readonly string dbPATH = DependencyService.Get<IFileWorker>().GetDatabasePath(dbNAME);
        public App()
        {
            InitializeComponent();
            bool isNew = false;
            if (!Data.Load(dbPATH))
            {
                Data.CurrentTerm = new Term()
                {
                    StartDate = DateTime.Now,
                    Subjects = new ObservableCollection<Subject>(),
                    Weeks = new ObservableCollection<Week>(),
                    Info = new Info()
                };
                isNew = true;
            }
            MainPage = new NavigationPage(new MenuPage(isNew));
        }

        protected override void OnStart()
        {

        }

        protected override void OnSleep()
        {

        }

        protected override void OnResume()
        {

        }
    }
}
