using System;
using System.Collections.Generic;
using System.Text;

namespace StudentHelper.Models
{
    public enum LessonType
    {
        Lecture, Seminar, Lab
    }
    [Serializable]
    public class Homework
    {
        public Subject Subject { get; set; }    //По какому предмету дз
        public string Task { get; set; }        //Текст самого задания
        public bool IsComplited { get; set; }   //Сделано ли оно
        public LessonType Type { get; set; }    //На какое занятие делать дз
    }
}
