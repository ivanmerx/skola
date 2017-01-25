using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dracak.Kouzla
{
    class Trpaslik : IKouzlo
    {
        private int HodnotaUtoku = 30;
        private string Nazev = "Zničující útok";
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
