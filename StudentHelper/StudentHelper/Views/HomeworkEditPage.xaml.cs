using StudentHelper.Models;
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
	public partial class HomeworkEditPage : ContentPage
	{
        EditHomeworkViewModel vm;
		public HomeworkEditPage (Homework hw = null)
		{
			InitializeComponent();
            vm = new EditHomeworkViewModel(hw, Navigation);
            BindingContext = vm;
		}
    }
}