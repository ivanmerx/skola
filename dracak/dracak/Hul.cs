using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dracak
{
    class Hul : IVybaveni
    {
        private string Nazev = "Hůl";
        private int HodnotaUtoku = 20;
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
    }
}
