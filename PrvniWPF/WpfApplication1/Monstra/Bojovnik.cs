using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication1.Monstra
{
    class Bojovnik
    {
        string nazev = "Bojovnik";
        public string sila
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public string hodnost
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        private typBoje interfaceTypBoje;
        public typBoje typBoje
        {
            get
            {
                return interfaceTypBoje;
            }

            set
            {
                interfaceTypBoje = value;
            }
        }

        public int zivoty
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public string name
        {
            get
            {
                return nazev;
            }

            set
            {
            }
        }

        public void sejmoutPriseru()
        {
            throw new NotImplementedException();
        }
    }
}
