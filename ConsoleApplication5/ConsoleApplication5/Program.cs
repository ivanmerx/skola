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
            osoba.Jmeno = "Tomáš";
            osoba.Prijmeni = "Klokočka";
            osoba.PlaticiStrategie = new Sclenstvim();
            osoba.KoupitVec(1000);
            Console.WriteLine(osoba.Jmeno+ " " +osoba.Prijmeni+ " " +osoba.stavUctu + " " +osoba.Konecnacena);

            Osoba osoba2 = new Osoba();
            osoba2.stavUctu = 5000;
            osoba2.Jmeno = "Libor";
            osoba2.Prijmeni = "Dočkal";
            osoba2.PlaticiStrategie = new Bezclenstvi();
            osoba2.KoupitVec(1000);
            Console.WriteLine(osoba2.Jmeno + " " + osoba2.Prijmeni + " " + osoba2.stavUctu + " " + osoba2.Konecnacena);
        }
    }
}
