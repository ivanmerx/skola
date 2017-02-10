using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using SQLitePCL;
namespace Databaze_Full
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
            return ID + Jmeno + Prijmeni + DatNar + Pohlavi;
        }
    }
}
