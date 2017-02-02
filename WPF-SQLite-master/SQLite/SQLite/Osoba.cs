using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLite
{
    public class Osoba
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Jmeno { get; set; }
        public string Prijmeni { get; set; }
        public string DatNar { get; set; }
        public string Pohlavi { get; set; }

        public int Done { get; set; }
        public Osoba()
        {
        }

        public override string ToString()
        {
            return "ID" + ID + " Jméno " + Jmeno + " Příjmení " + Prijmeni + " Datum narození " + DatNar + " Pohlaví " + Pohlavi;
        }
    }
}
