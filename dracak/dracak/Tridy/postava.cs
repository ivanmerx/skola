using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dracak
{
    public class postava
    {
        private string jmeno;
        private string rasa;
        private int zivoty = 100;
        IVybaveni interfaceVybaveni;
        IKouzlo interfaceKouzlo;
        private int xp;
        public int Xp
        {
            get
            {
                return xp;
            }

            set
            {
                xp = value;
            }
        }
        public IVybaveni vybaveni
        {
            get
            {
                return interfaceVybaveni;
            }
            set
            {
                interfaceVybaveni = value;
            }
        }
        public IKouzlo kouzlo
        {
            get
            {
                return interfaceKouzlo;
            }
            set
            {
                interfaceKouzlo = value;
            }
        }
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
        public string Rasa
        {
            get
            {
                return rasa;
            }

            set
            {
                rasa = value;
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
    }
}
