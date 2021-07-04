using StudentHelper.Models;
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
    public partial class MenuPage : TabbedPage
    {
        public MenuPage(bool isNew)
        {
            InitializeComponent();
            if (isNew)
            {
                DisplayAlert(
                    "Новый семестр", 
                    "1) Укажите дату начала семестра\n2) Добавьте информацию о каждом предмете в семестре\n3) Заполните расписание на четную и нечетную неделю соответственно\n4) Добавляйте домашние задания и фиксируйте полученные баллы по предметам", 
                    "ОK");
            }
        }
    }
}