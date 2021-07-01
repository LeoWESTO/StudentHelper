using StudentHelper.Models;
using StudentHelper.Views;
using System;
using System.Linq;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace StudentHelper
{
    public partial class App : Application
    {
        private static readonly string dbNAME = "data.db";
        private static string dbPATH = DependencyService.Get<IFileWorker>().GetDatabasePath(dbNAME);
        public App()
        {
            InitializeComponent();

            if (Data.Load(dbPATH)) MainPage = new NavigationPage(new MenuPage());
            else MainPage = new NavigationPage(new NewInfoPage());
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
