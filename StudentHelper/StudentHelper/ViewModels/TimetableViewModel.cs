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
        public string DayOfWeekLabel => Data.CurrentTerm.WeekNumber.ToString() + " неделя (" + CultureInfo.GetCultureInfo("ru-RU").DateTimeFormat.GetDayName(DateTime.Now.DayOfWeek) + ")";
        public bool isEven { get; set; }
        public TimetableViewModel()
        {
            isEven = Data.CurrentTerm.WeekNumber % 2 == 0;
        }
        public string CurrentWeekText
        {
            get
            {
                return (isEven) ? "Чётная неделя" : "Нечётная неделя";
            }
        }
        public ObservableCollection<Subject> MondaySubjects
        {
            get
            {
                if (Data.CurrentTerm.WeekNumber % 2 == 0) return Data.CurrentTerm.EvenWeek.MondayTimetable;
                else return Data.CurrentTerm.OddWeek.MondayTimetable;
            }
        }
        public ObservableCollection<Subject> TuesdaySubjects
        {
            get
            {
                if (Data.CurrentTerm.WeekNumber % 2 == 0) return Data.CurrentTerm.EvenWeek.TuesdayTimetable;
                else return Data.CurrentTerm.OddWeek.TuesdayTimetable;
            }
        }
        public ObservableCollection<Subject> WednesdaySubjects
        {
            get
            {
                if (Data.CurrentTerm.WeekNumber % 2 == 0) return Data.CurrentTerm.EvenWeek.WednesdayTimetable;
                else return Data.CurrentTerm.OddWeek.WednesdayTimetable;
            }
        }
        public ObservableCollection<Subject> ThursdaySubjects
        {
            get
            {
                if (Data.CurrentTerm.WeekNumber % 2 == 0) return Data.CurrentTerm.EvenWeek.ThursdayTimetable;
                else return Data.CurrentTerm.OddWeek.ThursdayTimetable;
            }
        }
        public ObservableCollection<Subject> FridaySubjects
        {
            get
            {
                if (Data.CurrentTerm.WeekNumber % 2 == 0) return Data.CurrentTerm.EvenWeek.FridayTimetable;
                else return Data.CurrentTerm.OddWeek.FridayTimetable;
            }
        }
        public ObservableCollection<Subject> SaturdaySubjects
        {
            get
            {
                if (Data.CurrentTerm.WeekNumber % 2 == 0) return Data.CurrentTerm.EvenWeek.SaturdayTimetable;
                else return Data.CurrentTerm.OddWeek.SaturdayTimetable;
            }
        }
        protected void OnPropertyChanged(string propName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }
    }
}
