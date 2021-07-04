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

        private void SaveInfo(object sender, EventArgs e)
        {
            Data.Update();
            vm.IsSaveable = false;
        }

        private async void SelectTerm(object sender, EventArgs e)
        {
            var s = Data.Terms.Select(t => t.StartDate.ToShortDateString()).ToArray();
            var action = await DisplayActionSheet("Выбрать семестр", "Отмена", null, s);
            if(action != null)
            {
                var date = Convert.ToDateTime(action);
                Data.CurrentTerm = Data.Terms.Find(t => t.StartDate == date);
            }
        }

        private async void ClearData(object sender, EventArgs e)
        {
            bool result = await DisplayAlert(
                "Очистка данных", 
                "Вы хотите удалить все данные?\nДанное действие очистит базу данных приложения.\nПотребуется перезапуск!", 
                "Да", "Нет");
            if (result)
            {
                Data.Clear();
                DependencyService.Get<ICloseApp>().CloseApp();
            }
        }
    }
}