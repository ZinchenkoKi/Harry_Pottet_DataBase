using HP_DataBase.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.IO.Pipes;

namespace HP_DataBase
{
    public class Program
    {
        static void Main()
        {
            using (var reed = new Context())
            {
             

               var pers = reed.People.Include(f=>f.Faculty).ThenInclude(s=>s!.School).Include(w=>w.Wand).
                    ToList();

                foreach (var item in pers)
                {
                    Console.WriteLine(
                        $"Name {item.Name}-{item.SecondName} Age {item.Age}\n" +
                        $"{item.Faculty?.School?.Name} {item.Faculty?.Name} \n" +
                        $"Wand - {item.Wand?.Name} in {item.Wand?.Material} \n \n" +
                        $"**************************************\n");
                }


            }
        }
    }
}
