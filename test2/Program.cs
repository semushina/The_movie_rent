using Movie_rent.Db;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace test2
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            MovieRentContext db = new MovieRentContext();
            foreach (client c in db.clients)
                Console.WriteLine("{0}.{1} - {2}", c.id, c.lname, c.fname);

            BindingList<client> cbl = db.clients.Local.ToBindingList();


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
