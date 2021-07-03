using StudentHelper.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Collections.ObjectModel;
using System.Text;

namespace StudentHelper.ViewModels
{
    public class TimetableViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public string TodayLabel => DateTime.Now.ToLongDateString();
        public string DayOfWeekLabel => Data.CurrentTerm.WeekNumber().ToString() + " неделя (" + CultureInfo.GetCultureInfo("ru-RU").DateTimeFormat.GetDayName(DateTime.Now.DayOfWeek) + ")";
        public bool isEven { get; set; }
        public TimetableViewModel()
        {
            isEven = Data.CurrentTerm.WeekNumber() % 2 == 0;
        }
        public string CurrentWeekText
        {
            get
            {
                return (isEven) ? "Чётная неделя" : "Нечётная неделя";
            }
        }
        public ObservableCollection<Subject> MondaySubjects;
        public ObservableCollection<Subject> TuesdaySubjects;
        public ObservableCollection<Subject> WednesdaySubjects;
        public ObservableCollection<Subject> ThursdaySubjects;
        public ObservableCollection<Subject> FridaySubjects;
        public ObservableCollection<Subject> SaturdaySubjects;
        protected void OnPropertyChanged(string propName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }
    }
}
