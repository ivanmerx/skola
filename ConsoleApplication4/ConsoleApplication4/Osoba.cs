using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Osoba
    {
        private string jmeno;
        private string prijmeni;
        private string datNar;
        private bool zije;
        public string Jmeno
        {
            get { return jmeno; }
            set { jmeno = value; }
        }
        public string Prijmeni
        {
            get { return prijmeni; }
            set { prijmeni = value; }
        }
        public string datNarozeni
        {
            get { return datNar; }
            set { datNar = value; }
        }
        public bool Zije
        {
            get { return zije; }
            set { zije = value; }
        }
        public Osoba(string jmeno, string prijmeni, bool zije)// Konstruktor pro volání s jedním parametrem a to datového typu string
        {
            this.jmeno = jmeno;
            this.prijmeni = prijmeni;
            this.zije = zije;
             // Pokaždé, když je vytvořena instance třídy s jednou proměnnou datového typu string, zvýší se počet letadel o 1, tato proměnná je public a tak je možné sledovat kolik instancí třídy bylo v celém programu vytvořeno
        }
    }
}
