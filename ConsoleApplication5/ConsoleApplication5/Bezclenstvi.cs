using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Bezclenstvi : PlaticiStrategie
    {
        public void Zaplat(Osoba osoba, int cena)
        {
            osoba.stavUctu -= cena;
        }
    }
}
