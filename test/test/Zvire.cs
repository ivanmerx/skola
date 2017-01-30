using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Zvire
    {
        private string jmeno;
        private int velikost;
        private string rasa;
        private bool zije;

        public string Jmeno
        {
            get { return jmeno; }
            set { jmeno = value; }
        }
        public int Velikost
        {
            get { return velikost; }
            set { velikost = value; }
        }
        public string Rasa
        {
            get { return rasa; }
            set { rasa = value; }
        }
        public bool Zije
        {
            get { return zije; }
            set { zije = value; }
        }

        public Zvire(string rasa,bool zije)
        {
            this.rasa = rasa;
            this.zije = zije;
        }
    }
}
