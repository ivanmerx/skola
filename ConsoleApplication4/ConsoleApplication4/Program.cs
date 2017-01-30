using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            Random gen = new Random();

            for (int i = 1; i < 5; i++)
            {
                int prob = gen.Next(100);
                Osoba osoba = new Osoba("lubos" + i, "novak" + i, prob < 20);
                Console.WriteLine(osoba.Jmeno + " " + osoba.Prijmeni + " " + osoba.Zije);
            }
        }
    }
}
