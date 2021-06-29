using StudentHelper.Models;
using StudentHelper.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace StudentHelper
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            Data.Load();
            MainPage = new NavigationPage(new MenuPage());
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
