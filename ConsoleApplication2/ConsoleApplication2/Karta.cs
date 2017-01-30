using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Karta
    {
        public enum Symboly { srdce, káry, kříže, piky };
        //       public enum HodnotyKaret { sedmi?ka, osmi?ka, dev?tka, des?tka, kluk, dama, kral, es??ko};
        private int hodnota;
        private string nazev;
        private int symbol;

        public int Hodnota
        {
            get { return hodnota; }
            set { hodnota = value; }
        }
        public string Nazev
        {
            get { return nazev; }
            set { nazev = value; }
        }
        public int Symbol
        {
            get { return symbol; }
            set { symbol = value; }
        }
        public Symboly symbolKaret()
        {
            return (Symboly)symbol;
        }
        /*
        public Hodnotykaret hodnotaKaret()
        {
            return (Hodnotykaret)hodnota;
        }
        */
    }
}