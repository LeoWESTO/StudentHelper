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
        HomeworkListViewModel vm;

		public HomeworkPage ()
		{
			InitializeComponent ();
            vm = new HomeworkListViewModel(Navigation);
            BindingContext = vm;
		}
		protected override void OnAppearing()
        {
			vm.RefreshList();
        }
    }
}