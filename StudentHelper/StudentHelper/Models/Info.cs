using System;
using System.Collections.Generic;
using System.Text;

namespace StudentHelper.Models
{
    [Serializable]
    public class Info
    {
        public string Faculty { get; set; } //Факультет
        public string Cathedra { get; set; } //Кафедра
        public string Direction { get; set; } //Направление
        public string Speciality { get; set; } //Специальность
        public string Group { get; set; } //Группа
        public DateTime StartDate { get; set; } //Дата начала первой недели семестра
    }
}
