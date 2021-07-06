using StudentHelper.Models;
using StudentHelper.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace StudentHelper.ViewModels
{
    public class HomeworkViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private INavigation Navigation { get; set; }
        public ICommand Edit { get; }
        public ObservableCollection<Homework> HomeworkList { get; set; }

        public HomeworkViewModel(INavigation navigation)
        {
            Navigation = navigation;
            Edit = new Command(AddHomework);
            if (Data.CurrentTerm.Subjects == null) 
                Data.CurrentTerm.Subjects = new ObservableCollection<Subject>();
        }

        protected void OnPropertyChanged(string propName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }
        private void AddHomework()
        {
            Navigation.PushAsync(new HomeworkEditPage());
        }
    }
}
