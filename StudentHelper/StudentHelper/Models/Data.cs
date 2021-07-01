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
            if (!_db.Database.EnsureCreated())
            {
                CurrentTerm = _db.Terms.ToArray()[0];
                return true;
            }
            else return false;
        }
    }
}
