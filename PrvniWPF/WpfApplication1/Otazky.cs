using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication1
{
    class Otazky
    {
        Random rnd = new Random();
        public int prvnicislo()
        {
            int prvnicislo = rnd.Next(1, 101); // creates a number between 1 and 100
            return prvnicislo;
        }
        public int druhycislo()
        {
            int druhycislo = rnd.Next(1, 100); // creates a number between 1 and 100
            return druhycislo;
        }
        public string operandy()
        {
            List<string> operandy = new List<string>();
            operandy.Add("+");
            operandy.Add("-");
            operandy.Add("*");
            operandy.Add("/");
            int operand = rnd.Next(0, 4);
            return operandy[operand];
        }
    }
}
