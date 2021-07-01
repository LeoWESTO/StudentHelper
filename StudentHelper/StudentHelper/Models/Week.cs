using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace StudentHelper.Models
{
    public class Week
    {
        public int Id { get; set; }
        public Term Term { get; set; }
        public int TermId { get; set; }
        public byte[] MondayTimetable { get; set; } = new byte[4];  //Пары на понедельник
        public byte[] TuesdayTimetable { get; set; } = new byte[4]; //Пары на вторник
        public byte[] WednesdayTimetable { get; set; } = new byte[4]; //Пары на среду
        public byte[] ThursdayTimetable { get; set; } = new byte[4]; //Пары на четверг
        public byte[] FridayTimetable { get; set; } = new byte[4]; //Пары на пятницу
        public byte[] SaturdayTimetable { get; set; } = new byte[4]; //Пары на субботу
    }
}
