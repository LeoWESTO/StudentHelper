using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace StudentHelper.Models
{
    public class Subject
    {
        public int Id { get; set; } //ID предмета
        public int TermId { get; set; } //ID семестра
        public Term Term { get; set; } //Объект семестра
        public ObservableCollection<Homework> Homeworks { get; set; }
        public string Title { get; set; } //Название предмета
        public string TeacherName { get; set; } //ФИО препода
        public bool IsExam { get; set; } //Экзамен?
        public byte[] Points { get; set; } //Массив баллов по аттестациям и экзаменам
    }
}
