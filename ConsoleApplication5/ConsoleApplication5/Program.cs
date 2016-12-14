using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            Osoba osoba = new Osoba();
            osoba.stavUctu = 5000;
            osoba.PlaticiStrategie = new Sclenstvim();
            osoba.KoupitVec(1000);
            Console.WriteLine(osoba.stavUctu);
        }
    }
}
