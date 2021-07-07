using StudentHelper.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace StudentHelper.ViewModels
{
    public class HomeworkViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public Homework Homework { get; private set; }
        public string Title => Homework.Subject.Title;
        public string Type
        {
            get
            {
                if (Homework.Type == LessonType.Lecture) return "Лекция";
                if (Homework.Type == LessonType.Seminar) return "Практика";
                if (Homework.Type == LessonType.Lab) return "Лабораторная";
                return "";
            }
        }
        public string Task => Homework.Task;
        public HomeworkViewModel(Homework homework)
        {
            Homework = homework;
        }
        protected void OnPropertyChanged(string propName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }
    }
}
