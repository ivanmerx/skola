using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dracak
{
    class Vzdusny : ITypPrisery
    {
        private int HodnotaUtoku = 30;
        private string Nazev = "Skřet";
        private int Zivoty = 60;

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

        public int zivoty
        {
            get
            {
                return Zivoty;
            }

            set
            {
                Zivoty = value;
            }
        }
    }
}
