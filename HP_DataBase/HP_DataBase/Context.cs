
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HP_DataBase.Entity;
using Microsoft.EntityFrameworkCore;

namespace HP_DataBase
{
    public class Context : DbContext
    {
        public DbSet<EducationObjekt> EducationObjekts { get; set; }
        public DbSet<Person> People { get; set; }
        public DbSet<Wand> Wands { get; set; }
        public DbSet<Faculty> Faculties { get; set; }
        public DbSet<School> Schools { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;DataBase=HP_DataBase;Username=postgres;Password=1234567");
        }
    }
}
