using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HP_DataBase.Entity
{
    public class School
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        public List<Faculty> Faculties { get; set; } = new();
    }
}
