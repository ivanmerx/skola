using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLiteExample
{
    public class Osoba
    {

        [PrimaryKey, AutoIncrement]
        public int ID
        {
            get;set;
        }
        public string Jmeno
        {
            get;set;
        }
        public string Prijmeni
        {
            get;set;
        }
        public int Vek
        {
            get;set;
        }
        public int TelCislo
        {
            get;set;
        }

    }
}
