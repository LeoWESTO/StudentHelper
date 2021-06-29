using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace StudentHelper.Models
{
    [Serializable]
    public class Week
    {
        public ObservableCollection<Subject> MondayTimetable { get; set; } //Пары на понедельник
        public ObservableCollection<Subject> TuesdayTimetable { get; set; } //Пары на вторник
        public ObservableCollection<Subject> WednesdayTimetable { get; set; } //Пары на среду
        public ObservableCollection<Subject> ThursdayTimetable { get; set; } //Пары на четверг
        public ObservableCollection<Subject> FridayTimetable { get; set; } //Пары на пятницу
        public ObservableCollection<Subject> SaturdayTimetable { get; set; } //Пары на субботу

        public Week()
        {
            MondayTimetable     = new ObservableCollection<Subject>();
            TuesdayTimetable    = new ObservableCollection<Subject>();
            WednesdayTimetable  = new ObservableCollection<Subject>();
            ThursdayTimetable   = new ObservableCollection<Subject>();
            FridayTimetable     = new ObservableCollection<Subject>();
            SaturdayTimetable   = new ObservableCollection<Subject>();
        }
    }
}
