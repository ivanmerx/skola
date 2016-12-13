using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Layouts
{
    class Osoba
    {
        private string jmeno;
        private int vek;
        private string prijmeni;
        private int telCislo;

        public string Jmeno
        {
            get { return jmeno; }
            set { jmeno = value; }
        }
        public int Vek
        {
            get { return vek; }
            set { vek = value; }
        }
        public string Prijmeni
        {
            get { return prijmeni; }
            set { prijmeni = value; }
        }
        public int TelCislo
        {
            get { return telCislo; }
            set { telCislo = value; }
        }
        public Osoba(string jmeno,string prijmeni,int vek,int telCislo)
        {
            this.jmeno = jmeno;
            this.prijmeni = prijmeni;
            this.vek = vek;
            this.telCislo = telCislo;
        }
        public string ZiskejJmeno => jmeno + " " + prijmeni;
        public string ZiskejVek => "Věk:" + vek;
        public override string ToString()
        {
            return jmeno + " " + prijmeni + " " + "Věk:"+vek + " " + "Telefonní číslo:"+telCislo;
        }
    }
}
