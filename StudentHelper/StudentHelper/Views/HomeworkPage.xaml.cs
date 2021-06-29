using StudentHelper.Models;
using StudentHelper.ViewModels;
using StudentHelper.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace StudentHelper
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class HomeworkPage : ContentPage
	{
        HomeworkViewModel vm = new HomeworkViewModel();

		public HomeworkPage ()
		{
			InitializeComponent ();
            BindingContext = vm;
		}

        private async void HomeworkEdit(object sender, SelectedItemChangedEventArgs e)
        {
            Homework selectedHomework = e.SelectedItem as Homework;
            if (selectedHomework != null)
            {
                ((ListView)sender).SelectedItem = null;
                await Navigation.PushAsync(new HomeworkEditPage(selectedHomework));
            }
        }

        private async void AddHomework(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new HomeworkEditPage(null));
        }
    }
}