using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Osoba
    {
        private string jmeno;
        private string prijmeni;
        private int stavuctu;
        private PlaticiStrategie platiciStrategie;
        public string Jmeno
        {
            get
            {
                return jmeno;
            }

            set
            {
                jmeno = value;
            }
        }

        public string Prijmeni
        {
            get
            {
                return prijmeni;
            }

            set
            {
                prijmeni = value;
            }
        }

        public int stavUctu
        {
            get
            {
                return stavuctu;
            }

            set
            {
                stavuctu = value;
            }
        }

        public PlaticiStrategie PlaticiStrategie
        {
            get
            {
                return platiciStrategie;
            }

            set
            {
                platiciStrategie = value;
            }
        }

        public void KoupitVec(int cena)
        {
            platiciStrategie.Zaplat(this,cena);
        }
    }
}
