using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Balicek balicek = new Balicek();
            List<Karta> kartyvruce = new List<Karta>();
            balicek.vytvorbalicek();
            int hodnoty = 0;
            int hodnotyprotihrac = 0;
            int liznutokaret = 1;
            int liznutokaretprotihrac = 1;
            bool prohra = false;
            bool prohraprotihrac = false;
            Karta z = balicek.protihracVyberKartu(0);
            Karta o = balicek.vyberKartu(0);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Máte tyto karty:");
            Console.ResetColor();
            Console.WriteLine(o.Nazev + " " + o.symbolKaret());
            hodnoty += o.Hodnota;
            hodnotyprotihrac += z.Hodnota;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Hodnota vašich karet je " + hodnoty);
            Console.ResetColor();
            kartyvruce.Add(o);
            Console.WriteLine("<Chcete pokračovat stiskněte Y pokud ne stiskněte N>");
            //     enum Karty {srdce, k?ry, k???e, piky };
            ConsoleKeyInfo keyinfo;
            do
            {
                z = balicek.protihracVyberKartu(0);
                o = balicek.vyberKartu(0);
                keyinfo = Console.ReadKey();
                //            Console.WriteLine(keyinfo.Key + " was pressed");
                if (keyinfo.Key == ConsoleKey.Y)
                {
                    Console.Clear();
                    liznutokaret++;
                    liznutokaretprotihrac++;
                    kartyvruce.Add(o);
                    hodnoty += o.Hodnota;
                    hodnotyprotihrac += z.Hodnota;
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Máte tyto karty:");
                    Console.ResetColor();
                    if (hodnoty > 21)
                    {
                        prohra = true;
                    }
                    if (hodnotyprotihrac > 21)
                    {
                        prohraprotihrac = true;
                    }
                    foreach (Karta karty in kartyvruce)
                    {
                        Console.WriteLine(karty.Nazev + " " + karty.symbolKaret());
                    }
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Hodnota va?šich karet je " + hodnoty);
                    Console.ResetColor();
                    /*
        //              Console.WriteLine("M?te tyto karty");
                    Console.WriteLine(o.Nazev + " " + o.symbolKaret());
                    hodnoty = hodnoty + o.Hodnota;
                    //                l += balicek.protihracVyberKartu(0);
                    */
                    Console.WriteLine("<Chcete pokračovat stiskněte Y pokud ne stiskněte N>");
                    if (balicek.pole.Count() == 0)
                    {
                        Console.Clear();
                        Console.WriteLine("Do?šly karty");
                    }
                }
                else if (keyinfo.Key == ConsoleKey.N)
                {
                    Console.Clear();
                    if (hodnoty > hodnotyprotihrac)
                    {
                        Console.Write("Hodnoty vašich karet: ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(hodnoty);
                        Console.ResetColor();
                        Console.WriteLine(" ");
                        Console.Write("Protihracovi hodnoty karet: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(hodnotyprotihrac);
                        Console.ResetColor();
                        Console.WriteLine(" ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Vyhráli jste!");
                        Console.ResetColor();
                    }
                    else if (hodnotyprotihrac > hodnoty)
                    {
                        Console.Write("Hodnoty vašich karet: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(hodnoty);
                        Console.ResetColor();
                        Console.WriteLine(" ");
                        Console.Write("Protihracovi hodnoty karet: ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(hodnotyprotihrac);
                        Console.ResetColor();
                        Console.WriteLine(" ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Prohráli jste! ");
                        Console.ResetColor();
                    }
                    else if (hodnotyprotihrac == hodnoty)
                    {
                        if (liznutokaret > liznutokaretprotihrac)
                        {
                            Console.Write("Hodnoty vašich karet: ");
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write(hodnoty);
                            Console.ResetColor();
                            Console.Write("byly stejné, bohužel jste si líznul ale více karet, takže jste prohrál");
                        }
                        else
                        {
                            Console.Write("Hodnoty vašich karet: ");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write(hodnoty);
                            Console.ResetColor();
                            Console.Write("byly stejné, ale protihráč si líznul více karet, takže jste vyhrál");
                        }
                    }
                }

                if (prohra == true)
                {
                    Console.Clear();
                    Console.WriteLine("Vaše hodnota karet přesáhla 21, takže jste prohrál");

                }
                else if (prohraprotihrac == true)
                {
                    Console.Clear();
                    Console.WriteLine("Protihráčova hodnota karet přesáhla 21, takže jste vyhrál");
                }
            }
            while (balicek.pole.Count() > 0 || prohra == false);
        }
    }
}