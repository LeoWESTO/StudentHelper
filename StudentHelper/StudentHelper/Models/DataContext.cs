using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentHelper.Models
{
    public class DataContext : DbContext
    {
        private readonly string PATH;

        public DbSet<Term> Terms { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Week> Weeks { get; set; }
        public DbSet<Homework> Homeworks { get; set; }
        public DbSet<Info> Infos { get; set; }
        public DbSet<Schedule> Schedules { get; set; }

        public DataContext(string path)
        {
            PATH = path;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Filename={PATH}");
        }
    }
}
