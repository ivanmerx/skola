using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dracak
{
    class Mec : IVybaveni
    {
        private string Nazev = "Meč";
        private int HodnotaUtoku = 40;
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
