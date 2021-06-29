using System;
using System.Collections.Generic;
using System.Text;

namespace StudentHelper.Models
{
    [Serializable]
    public class Subject
    {
        public string Title { get; set; } //Название предмета
        public string TeacherName { get; set; } //ФИО препода
        public bool IsExam { get; set; } //Экзамен?
        public byte[] Points { get; set; } //Массив баллов по аттестациям и экзаменам

        public Subject()
        {
            Points = new byte[5];
        }
    }
}
