using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HP_DataBase.Entity
{
    public class Person
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? SecondName { get; set; }
        public int Age { get; set; }

        public int FacultyId { get; set; }
        public Faculty? Faculty { get;set; }

        public Wand? Wand { get; set; }

        public List<EducationObjekt> EducationObjekts = new();
    }
}
