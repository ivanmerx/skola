using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication1
{
    class Otazky
    {
        public string VytvorPriklad()
        {
            Random rnd = new Random();
            int prvnicislo = rnd.Next(1, 101); // creates a number between 1 and 100
            int druhycislo = rnd.Next(1, 101); // creates a number between 1 and 100
            List<string> operandy = new List<string>();
            operandy.Add("+");
            operandy.Add("-");
            operandy.Add("*");
            operandy.Add("/");
            int operand = rnd.Next(1,5);
            string otazka = prvnicislo + operandy[operand] + druhycislo;
            return otazka;
        }
        public void VypocitejPriklad()
        {

        }
    }
}
