using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;

namespace StudentHelper.Models
{
    [Serializable]
    public class Term
    {
        public byte WeekNumber { get; set; }
        public ObservableCollection<Subject> Subjects { get; set; }
        public ObservableCollection<Homework> Homeworks { get; set; }
        public Week EvenWeek { get; set; }
        public Week OddWeek { get; set; }
        public Info Info { get; set; }

        public Term()
        {
            Subjects = new ObservableCollection<Subject>();
            Homeworks = new ObservableCollection<Homework>();
            EvenWeek = new Week();
            OddWeek = new Week();
            Info = new Info();
            WeekNumber = (byte)((DateTime.Now - Info.StartDate).TotalDays / 7 % 4 + 1);
        }
    }
}
