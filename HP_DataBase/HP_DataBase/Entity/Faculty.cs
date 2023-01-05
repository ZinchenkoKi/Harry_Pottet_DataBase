using System;
using System.Collections.Generic;
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

        public List<Person> People = new();
    }
}
