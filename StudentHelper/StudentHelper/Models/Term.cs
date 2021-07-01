using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;

namespace StudentHelper.Models
{
    public class Term
    {
        public int Id { get; set; }
        public DateTime StartDate { get; set; } //Дата начала первой недели семестра
        public ObservableCollection<Subject> Subjects { get; set; }
        public ObservableCollection<Week> Weeks { get; set; }
        public Info Info { get; set; }
    }
}
