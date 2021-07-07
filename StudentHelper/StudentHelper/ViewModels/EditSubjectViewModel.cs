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
    public class EditSubjectViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private Subject subject;
        private bool isNew;
        private INavigation Navigation { get; set; }
        public ICommand Save { get; }
        public ICommand Delete { get; }
        public string Title
        {
            get { return subject.Title; }
            set
            {
                subject.Title = value;
                OnPropertyChanged("Title");
            }
        }
        public string TeacherName
        {
            get { return subject.TeacherName; }
            set
            {
                subject.TeacherName = value;
                OnPropertyChanged("TeacherName");
            }
        }
        public string IsExamString
        {
            get { return subject.IsExam ? "Экзамен" : "Зачёт"; }
        }
        public bool IsExam
        {
            get { return subject.IsExam; }
            set
            {
                subject.IsExam = value;
                OnPropertyChanged("IsExam");
                OnPropertyChanged("IsExamString");
            }
        }
        public string FirstAtt
        {
            get { return subject.Points[0].ToString(); }
            set
            {
                if (!String.IsNullOrEmpty(value))
                {
                    subject.Points[0] = Convert.ToByte(value);
                    OnPropertyChanged("FirstAtt");
                }
            }
        }
        public string SecondAtt
        {
            get { return subject.Points[1].ToString(); }
            set
            {
                if (!String.IsNullOrEmpty(value))
                {
                    subject.Points[1] = Convert.ToByte(value);
                    OnPropertyChanged("SecondAtt");
                }
            }
        }
        public string ThirdAtt
        {
            get { return subject.Points[2].ToString(); }
            set
            {
                if (!String.IsNullOrEmpty(value))
                {
                    subject.Points[2] = Convert.ToByte(value);
                    OnPropertyChanged("ThirdAtt");
                }
                
            }
        }
        public string Attendance
        {
            get { return subject.Points[3].ToString(); }
            set
            {
                if (!String.IsNullOrEmpty(value))
                {
                    subject.Points[3] = Convert.ToByte(value);
                    OnPropertyChanged("Attendance");
                }
            }
        }
        public string Session
        {
            get { return subject.Points[4].ToString(); }
            set
            {
                if (!String.IsNullOrEmpty(value))
                {
                    subject.Points[4] = Convert.ToByte(value);
                    OnPropertyChanged("Session");
                }
            }
        }

        public EditSubjectViewModel(Subject s, INavigation navigation)
        {
            if (s != null)
            {
                subject = s;
                isNew = false;
            }
            else
            {
                isNew = true;
                subject = new Subject() { Term = Data.CurrentTerm, Points = new byte[5] };
            }
            Save = new Command(SaveSubject);
            Delete = new Command(DeleteSubject);
            Navigation = navigation;
        }
        protected void OnPropertyChanged(string propName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }
        private void SaveSubject()
        {
            if (isNew)
            {
                Data.CurrentTerm.Subjects.Add(subject);
            }
            else
            {
                var i = Data.CurrentTerm.Subjects.IndexOf(
                    Data.CurrentTerm.Subjects.Single(s => s.Id == subject.Id));
                Data.CurrentTerm.Subjects[i] = subject;
            }
            Data.Update();
            Navigation.PopAsync();
        }
        private async void DeleteSubject()
        {
            var ans = await Application.Current.MainPage.DisplayAlert(
                "Удаление", 
                "Вы действительно хотите удалить предмет из базы?", 
                "Да", "Нет");
            if (!isNew && ans)
            {
                Data.CurrentTerm.Subjects.Remove(Data.CurrentTerm.Subjects.Single(s => s.Id == subject.Id));
                Data.Update();
            }
            await Navigation.PopAsync();
        }
    }
}
