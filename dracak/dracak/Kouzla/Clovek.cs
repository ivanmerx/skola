using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dracak.Kouzla
{
    class Clovek : IKouzlo
    {
        private int HodnotaUtoku = 0;
        private string Nazev = "Kouzelné léčení";
        private int PlusZivoty = 40;

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
