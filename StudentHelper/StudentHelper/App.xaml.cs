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
                Data.CurrentTerm = new Term();

                Data.CurrentTerm.StartDate = Convert.ToDateTime(DateTime.Now.ToShortDateString());

                Week w1 = new Week() { Term = Data.CurrentTerm };
                Week w2 = new Week() { Term = Data.CurrentTerm };
                Data.CurrentTerm.Weeks = new ObservableCollection<Week> { w1, w2 };

                Data.CurrentTerm.Info = new Info() { Term = Data.CurrentTerm };

                Data.Save(Data.CurrentTerm);
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
