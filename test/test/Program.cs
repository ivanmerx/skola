using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Zvire> zvirata = new List<Zvire>();
            Random rnd = new Random();
            bool zivot;
            int help=0;
            for (int i = 1; i < 5; i++)
            {
                int pomocna = rnd.Next(0, 100);
                if (pomocna % 2 == 0)
                {
                    zivot = false;
                }
                else
                {
                    zivot = true;
                }
                Zvire zvire = new Zvire("Doga"+i, zivot);
                zvire.Jmeno = "Tomas"+i;
                zvire.Velikost = 10+i;
                zvirata.Add(zvire);
                //Console.WriteLine(zvire.Jmeno + " " + zvire.Rasa + " " + zvire.Velikost + " " + zvire.Zije);
            }

            Zvire nejvetsi = zvirata.First();

            foreach (Zvire zvirataa in zvirata)
            {


                if(nejvetsi.Velikost < zvirataa.Velikost)
                {
                    nejvetsi = zvirataa;
                }



                Console.WriteLine("");
                Console.Write(zvirataa.Jmeno);
                Console.Write(" " + zvirataa.Rasa);
                Console.Write(" " + zvirataa.Velikost);
                Console.Write(" " + zvirataa.Zije);
                Console.WriteLine("");



                Console.WriteLine("Nejvetsi " + nejvetsi.Jmeno);
            }
        }
    }
}
