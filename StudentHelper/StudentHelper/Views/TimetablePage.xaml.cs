using StudentHelper.Models;
using StudentHelper.ViewModels;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace StudentHelper
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class TimetablePage : ContentPage
	{
        TimetableViewModel vm = new TimetableViewModel();

        public TimetablePage ()
		{
			InitializeComponent();
            BindingContext = vm;
		}

        private void ChangeWeek(object sender, System.EventArgs e)
        {
            vm.isEven = !vm.isEven;
        }

        private void MondaySubjectsEdit(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null) ;
        }
        private void TuesdaySubjectsEdit(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null) ;
        }
        private void WednesdaySubjectsEdit(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null) ;
        }
        private void ThursdaySubjectsEdit(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null) ;
        }
        private void FridaySubjectsEdit(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null) ;
        }
        private void SaturdaySubjectsEdit(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null) ;
        }
    }
}