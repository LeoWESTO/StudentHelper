using StudentHelper.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace StudentHelper.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SubjectsPage : ContentPage
	{
		private SubjectsListViewModel vm;
		public SubjectsPage()
        {
            InitializeComponent();
			vm = new SubjectsListViewModel(Navigation);
            BindingContext = vm;
        }

        protected override void OnAppearing()
        {
            vm.RefreshList();
        }
	}
}