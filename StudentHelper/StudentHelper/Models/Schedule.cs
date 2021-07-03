using StudentHelper.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace StudentHelper.Models
{
    public class Schedule
    {
        public int Id { get; set; }
        public Subject Subject { get; set; }
        public int SubjectId { get; set; }
        public LessonType Type { get; set; }
        public string Classroom { get; set; }
    }
}
