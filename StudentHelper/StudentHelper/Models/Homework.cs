using System;
using System.Collections.Generic;
using System.Text;

namespace StudentHelper.Models
{
    public enum LessonType
    {
        Lecture, Seminar, Lab
    }
    public class Homework
    {
        public int Id { get; set; }
        public Subject Subject { get; set; }    //По какому предмету дз
        public int SubjectId { get; set; }
        public string Task { get; set; }        //Текст самого задания
        public bool IsComplited { get; set; }   //Сделано ли оно
        public LessonType Type { get; set; }    //На какое занятие делать дз
    }
}
