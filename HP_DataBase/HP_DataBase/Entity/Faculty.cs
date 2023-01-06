using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HP_DataBase.Entity
{
    public class Faculty
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Founder { get; set; }
        public string? Element { get; set; }

        [ForeignKey (nameof(School))]
        public int ShoolNames { get; set; }
        public School? School { get; set; }

        public List<Person> People = new();
    }
}
