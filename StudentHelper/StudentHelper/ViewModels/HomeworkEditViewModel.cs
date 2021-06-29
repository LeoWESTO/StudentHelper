using StudentHelper.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace StudentHelper.ViewModels
{
    public class HomeworkEditViewModel : INotifyPropertyChanged
    {
        public readonly Homework homework;
        public event PropertyChangedEventHandler PropertyChanged;
        public string[] SubjTitles => Data.CurrentTerm.Subjects.Select(s => s.Title).OrderBy(s => s).ToArray();

        public HomeworkEditViewModel(Homework hw)
        {
            if (hw == null) homework = new Homework();
            else homework = hw;
        }

        public string Task
        {
            get { return homework.Task; }
            set
            {
                if (homework.Task != value)
                {
                    homework.Task = value;
                    OnPropertyChanged("Task");
                }
            }
        }

        protected void OnPropertyChanged(string propName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }
    }
}
