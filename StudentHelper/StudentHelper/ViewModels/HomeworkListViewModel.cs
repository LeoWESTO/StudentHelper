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
    public class HomeworkListViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private INavigation Navigation { get; set; }
        public ICommand Add { get; }
        public ObservableCollection<HomeworkViewModel> HomeworkList { get; set; }
        private HomeworkViewModel selectedHomeworkItem;
        public HomeworkViewModel SelectedHomeworkItem
        {
            get { return selectedHomeworkItem; }
            set
            {
                selectedHomeworkItem = value;
                EditHomework();
                selectedHomeworkItem = null;
                OnPropertyChanged("SelectedHomeworkItem");
            }
        }
        public HomeworkListViewModel(INavigation navigation)
        {
            Navigation = navigation;
            Add = new Command(AddHomework);
            if (Data.CurrentTerm.Subjects == null) 
                Data.CurrentTerm.Subjects = new ObservableCollection<Subject>();
            HomeworkList = new ObservableCollection<HomeworkViewModel>();
            RefreshList();
        }

        protected void OnPropertyChanged(string propName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }
        private void AddHomework()
        {
            Navigation.PushAsync(new HomeworkEditPage());
        }
        private void EditHomework()
        {
            Navigation.PushAsync(new HomeworkEditPage(selectedHomeworkItem.Homework));
        }
        public void RefreshList()
        {
            HomeworkList.Clear();
            foreach(var s in Data.CurrentTerm.Subjects)
            {
                if (s.Homeworks == null) continue; 
                foreach(var h in s.Homeworks)
                {
                    HomeworkList.Add(new HomeworkViewModel(h));
                }
            }
        }
    }
}
