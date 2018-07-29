using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            MrDb db = new MrDb();

            films film = new films();
            film.name = "dsa";
            film.year = 4212;
            film.duration = 123;

            db.films.Add(film);
            db.SaveChanges();

            Console.ReadKey();
        }
    }
}
