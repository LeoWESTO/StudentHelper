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
    public class SubjectsListViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private INavigation Navigation { get; set; }
        public ICommand Add { get; }
        public ICommand Refresh { get; }
        private SubjectsViewModel selectedSubjectItem;
        public SubjectsViewModel SelectedSubjectItem
        {
            get { return selectedSubjectItem; }
            set
            {
                selectedSubjectItem = value;
                EditSubject();
                selectedSubjectItem = null;
                OnPropertyChanged("SelectedSubjectItem");
            }
        }
        public string TotalSubjects => "Всего предметов: " + SubjectItems.Count.ToString();
        public ObservableCollection<SubjectsViewModel> SubjectItems { get; set; }

        public SubjectsListViewModel(INavigation navigation)
        {
            Navigation = navigation;
            Add = new Command(AddSubject);
            Refresh = new Command(RefreshList);
            SubjectItems = new ObservableCollection<SubjectsViewModel>();
            RefreshList();
        }
        protected void OnPropertyChanged(string propName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }
        private void AddSubject()
        {
            Navigation.PushAsync(new EditSubjectPage());
        }
        private void EditSubject()
        {
            Navigation.PushAsync(new EditSubjectPage(selectedSubjectItem.Subject));
        }
        public void RefreshList()
        {
            SubjectItems.Clear();
            foreach (var s in Data.CurrentTerm.Subjects)
            {
                SubjectItems.Add(new SubjectsViewModel(s));
            }
            OnPropertyChanged("TotalSubjects");
        }
    }
}
