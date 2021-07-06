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
		public HomeworkEditPage (Homework hw = null, Subject subject = null, LessonType type = LessonType.Seminar)
		{
			InitializeComponent();
            vm = new EditHomeworkViewModel(hw, subject, type, Navigation);
            BindingContext = vm;
		}
    }
}