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
        private int HodnotaUtoku = 10;
        public int hodnotaUtoku
        {
            get
            {
                return hodnotaUtoku;
            }

            set
            {
                hodnotaUtoku = value;
            }
        }

        public string nazev
        {
            get
            {
                return nazev;
            }

            set
            {
                nazev = value;
            }
        }
    }
}
