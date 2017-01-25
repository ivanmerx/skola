using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dracak
{
    class prisera
    {
        private string nazev;
        private int hodnotaUtoku;
        private int zivoty;
        ITypPrisery interfacetypprisery;

        public ITypPrisery typprisery
        {
            get
            {
                return interfacetypprisery;
            }
            set
            {
                interfacetypprisery = value;
            }
        }
        public string Nazev
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
        public int HodnotaUtoku
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
        public int Zivoty
        {
            get
            {
                return zivoty;
            }
            set
            {
                zivoty = value;
            }
        }
        public prisera(string nazev, ITypPrisery typprisery)
        {
            this.nazev = nazev;
            this.typprisery = typprisery;
        }
    }
}
