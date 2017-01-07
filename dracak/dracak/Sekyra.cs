using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dracak
{
    class Sekyra : IVybaveni
    {
        private string Nazev = "Sekyra";
        private int HodnotaUtoku = 10;
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
