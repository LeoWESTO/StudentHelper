using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace StudentHelper.Models
{
    public static class Data
    {
        public static Term CurrentTerm { get; set; }
        public static List<Term> Terms { get; private set; }
        public static List<Subject> Subjects { get; private set; }
        public static List<Week> Weeks { get; private set; }
        public static List<Homework> Homeworks { get; private set; }
        public static List<Info> Infos { get; private set; }
        public static List<Schedule> Schedules { get; private set; }

        private static DataContext _db;

        public static void Update()
        {
            _db.Update(CurrentTerm);
            _db.SaveChanges();
        }
        
        public static void Save(Term term)
        {
            _db.Add(term);
            _db.SaveChanges();
        }

        public static bool Load(string path)
        {
            _db = new DataContext(path);
            
            //_db.Database.EnsureDeleted(); //для дебага
            if (!_db.Database.EnsureCreated() && _db.Terms.Count() > 0)
            {
                Terms = _db.Terms.ToList();
                Subjects = _db.Subjects.ToList();
                Weeks = _db.Weeks.ToList();
                Homeworks = _db.Homeworks.ToList();
                Infos = _db.Infos.ToList();
                Schedules = _db.Schedules.ToList();
                CurrentTerm = Terms[0];

                return true;
            }
            else return false;
        }

        public static void Clear()
        {
            _db.Database.EnsureDeleted();
        }
    }
}
