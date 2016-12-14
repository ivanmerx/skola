using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Sclenstvim : PlaticiStrategie
    {
        double sleva = 0.75;
        public void Zaplat(Osoba osoba, int cena)
        {
            osoba.Konecnacena = osoba.stavUctu - Int32.Parse((cena*sleva).ToString());
        }
    }
}
