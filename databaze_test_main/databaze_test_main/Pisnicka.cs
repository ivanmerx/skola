using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
namespace databaze_test_main
{
    public class Pisnicka
    {
        [PrimaryKey, AutoIncrement]

        public int ID { get; set; }
        public string Nazev { get; set; }
        public string Interpret { get; set; }
        private int Delka { get; set; }

    }
}
