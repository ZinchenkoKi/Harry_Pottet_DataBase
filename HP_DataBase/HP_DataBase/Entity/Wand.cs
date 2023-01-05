using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HP_DataBase.Entity
{
    public class Wand
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Material { get; set; }

        public int PersonId { get; set; }
        public Person? Person { get; set; }
    }
}
