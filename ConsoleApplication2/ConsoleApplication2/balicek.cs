using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Balicek
    {

        public List<Karta> pole = new List<Karta>();
        public void vytvorbalicek()
        {
            int y = 0;
            for (int c = 0; c < 4; c++)
            {

                for (int i = 7; i < 11; i++)
                {
                    Karta karta = new Karta();
                    karta.Hodnota = i;
                    karta.Symbol = c;
                    karta.Nazev = i.ToString();

                    pole.Add(karta);

                }

                pole.Add(
                    new Karta
                    {
                        Hodnota = 1,
                        Nazev = "J",
                        Symbol = c
                    }
                );
                pole.Add(
                 new Karta
                 {
                     Hodnota = 1,
                     Nazev = "Q",
                     Symbol = c
                 }
             );
                pole.Add(
                 new Karta
                 {
                     Hodnota = 1,
                     Nazev = "K",
                     Symbol = c
                 }
             );
                pole.Add(
                 new Karta
                 {
                     Hodnota = 11,
                     Nazev = "A",
                     Symbol = c
                 }
             );


            }
            /*
            for (int z = 0; z < pole.Count(); z++)
            {
                Console.WriteLine(pole.Count());
            }
            *
            foreach(Karta prvek in pole)
            {
                Console.WriteLine(prvek.Nazev + " " + prvek.symbolKaret() + " " + prvek.Hodnota);
            }
            */
            //         Console.WriteLine(pole.Count());

        }


        public Karta vyberKartu(int minimum)
        {
            Random random = new Random();
            int x = random.Next(minimum, pole.Count());

            Karta o = pole.ElementAt(x); /*.Hodnota + " " + pole.ElementAt(x).Nazev + " " + pole.ElementAt(x).symbolKaret();*/
            pole.RemoveAt(x);
            return o;
        }
        public Karta protihracVyberKartu(int minimum)
        {

            Random random = new Random();
            int x = random.Next(minimum, pole.Count());
            Karta z = pole.ElementAt(x);/* pole.ElementAt(x).Hodnota + " " +/ pole.ElementAt(x).Nazev + " " + pole.ElementAt(x).symbolKaret();*/
            pole.RemoveAt(x);
            return z;
        }
    }
}