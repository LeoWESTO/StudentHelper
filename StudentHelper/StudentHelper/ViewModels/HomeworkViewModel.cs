using StudentHelper.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;

namespace StudentHelper.ViewModels
{
    public class HomeworkViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        
        public ObservableCollection<Homework> HomeworkList => Data.CurrentTerm.Homeworks;
        public bool IsEnabled => Data.CurrentTerm.Subjects.Count > 0;

        protected void OnPropertyChanged(string propName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }
    }
}
