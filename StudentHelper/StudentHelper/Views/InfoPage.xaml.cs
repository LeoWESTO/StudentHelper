using StudentHelper.Models;
using StudentHelper.ViewModels;
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
	public partial class InfoPage : ContentPage
	{
        InfoViewModel vm = new InfoViewModel();

        public InfoPage ()
		{
			InitializeComponent();
            BindingContext = vm;
        }

        private void SaveInfo(object sender, System.EventArgs e)
        {
            Data.Save();
            vm.IsSaveable = false;
        }
    }
}