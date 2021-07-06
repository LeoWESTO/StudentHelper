using StudentHelper.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace StudentHelper.ViewModels
{
    public class EditHomeworkViewModel : INotifyPropertyChanged
    {
        private readonly Homework homework;
        private bool isNew;
        public event PropertyChangedEventHandler PropertyChanged;
        private INavigation Navigation { get; set; }
        public ICommand Add { get; }
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
        public string[] SubjTitles => Data.CurrentTerm.Subjects.Select(s => s.Title).OrderBy(s => s).ToArray();
        public string[] SubjTypes { get; } = new string[] { "Лекция", "Практика", "Лабораторная" };
        public int SelectedSubj
        {
            set
            {
                homework.Subject = Data.CurrentTerm.Subjects.Single(s => s.Title == SubjTitles[value]);
            }
        }
        public int SelectedTypes
        {
            set
            {
                if (SubjTypes[value] == "Лекция") homework.Type = LessonType.Lecture;
                if (SubjTypes[value] == "Практика") homework.Type = LessonType.Seminar;
                if (SubjTypes[value] == "Лабораторная") homework.Type = LessonType.Lab;
            }
        }
        public EditHomeworkViewModel(Homework hw, Subject sub, LessonType type, INavigation navigation)
        {
            Navigation = navigation;
            Add = new Command(AddHomework);


            if (hw == null)
            {
                homework = new Homework();
                isNew = true;
            }
            else
            {
                homework = hw;
                isNew = false;
            }
        }

        protected void OnPropertyChanged(string propName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }
        private void AddHomework()
        {
            if(homework.Subject != null)
            {
                if (isNew)
                {
                    if (homework.Subject.Homeworks == null) homework.Subject.Homeworks = new System.Collections.ObjectModel.ObservableCollection<Homework>();
                    homework.Subject.Homeworks.Add(homework);
                    Data.Update();
                }
            }
        }
    }
}
