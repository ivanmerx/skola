using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dracak.Kouzla
{
    class Carodej : IKouzlo
    {
        private int HodnotaUtoku = 40;
        private string Nazev = "Dračí útok";
        private int PlusZivoty = 0;

        public int hodnotaUtoku
        {
            get
            {
                return HodnotaUtoku;
            }

            set
            {
                HodnotaUtoku = value;
            }
        }

        public string nazev
        {
            get
            {
                return Nazev;
            }

            set
            {
                Nazev = value;
            }
        }

        public int plusZivoty
        {
            get
            {
                return PlusZivoty;
            }

            set
            {
                PlusZivoty = value;
            }
        }
    }
}
