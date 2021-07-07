using StudentHelper.Models;
using StudentHelper.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace StudentHelper.ViewModels
{
    public class SubjectsViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public Subject Subject { get; private set; }
        public string Title => Subject.Title;
        public string TeacherName => Subject.TeacherName;
        public string PointsSum => Subject.Points.ToList().Sum(p => p).ToString();
        public string IsExamString => Subject.IsExam ? "Экзамен" : "Зачёт";
        public Color GoalColor { get; set; }
        public string GoalPoint => Point();
        public SubjectsViewModel(Subject subject)
        {
            Subject = subject;
        }
        protected void OnPropertyChanged(string propName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }
        private string Point()
        {
            string str = "Необходимо набрать ";
            var sum = Subject.Points.ToList().Sum(p => p) - Subject.Points[4];
            if (sum >= 0 && sum < 56)
            {
                GoalColor = Color.Red;
                return str + (56 - sum) + " баллов до оценки \"3\"";
            }
            else if (sum >= 56 && sum < 70)
            {
                GoalColor = Color.Gold;
                return str + (70 - sum) + " баллов до оценки \"4\"";
            }
            else if (sum>=70 && sum < 85)
            {
                GoalColor = Color.Green;
                return str + (85 - sum) + " баллов до оценки \"5\"";
            }
            else
            {
                GoalColor = Color.Green;
                return "Оценка \"5\" гарантирована!";
            }
        }
    }
}
