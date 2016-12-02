using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //           string level1 = "kokos";,"kokos","ahoj","zalud","Console"
            string level2 = "nazdar";

            Random rnd = new Random();
            //vytvoreni pole se slovy na hádání
            string[] slova = { "bobr", "osa", "klepeto"/*,"vaha", "parasutista", "solidarita", "výtah", "balada", "sachta", "miminko","sklo", "melodie"*/};
            //Vybere random index z pole
            int slovaindex = rnd.Next(slova.Length);
            //ulozi slovo do promenne 
            string level1 = slova[slovaindex];
            //vyhra se zmeni na true pokud uhodne cele slovo
            bool vyhra = false;
            int zivoty = 4;
            //pocitani chyb
            int chyba = 0;
            //vypisovani levelu 
            int level = 1;
            int pocetPismen = 0;
            int numberOfLetters = level1.Length;

            //pole pro uhodnuta pismena
            List<string> uhodnutepole = new List<string>();

            //   Console.Write(numberOfLetters);
            Console.Clear();
            // Cyklus pro vypisovani, dokud neudělal 4 chyby a nebo nevyhral
            while (chyba < 4 && vyhra == false)
            {

                //         Console.WriteLine(vyhra);
                //       pocetPismen = 1;
                Console.WriteLine("Level:" + level);
                Console.WriteLine("Zadejte písmeno od a-z");
                pocetPismen = 0;
                //Cyklus na vypsani carek vcetne doplneni misto carky vhodne pismeno
                for (int i = 0; i < numberOfLetters; i++)
                {

                    bool carky = true;
                    foreach (string uhodnute in uhodnutepole)
                    {
                        if (uhodnute == level1[i].ToString())
                        {
                            Console.Write(level1[i]);
                            carky = false;
                            pocetPismen++;
                            //                       Console.WriteLine(pocetPismen + " " + numberOfLetters);
                            if (pocetPismen + 1 == numberOfLetters)
                            {
                                vyhra = true;
                                level++;
                            }

                        }
                    }
                    if (carky == true)
                    {
                        Console.Write("_ ");
                    }
                }
                Console.WriteLine(" ");

                //slovo ktere napise se vlozi do promenne
                Console.WriteLine(level1);
                string klobasa = Console.ReadLine();
                string slovo = "";
                //kontrola jestli je pismeno obsazeno ve slove
                if (level1.ToLower().Contains(klobasa))
                {
                    slovo += klobasa;
                    int position = level1.IndexOf(klobasa) + 1;
                    Console.WriteLine("Správně a písmeno <" + klobasa + "> se nachází na pozici " + position);
                    //         Console.WriteLine(level1.index(klobasa));
                    Console.Clear();
                    Console.WriteLine("Počet chyb " + chyba + " /4");
                    //kontrola jestli je v poli vubec nejake pismeno, aby jsme mohli kontrolovat jestli už tam není vložené
                    if (uhodnutepole.Count() != 0)
                    {
                        //kontrola jestli pismeno již není v poli
                        if (uhodnutepole.Contains(klobasa))
                        {
                            Console.WriteLine("Toto písmeno už je uhodnuté ");

                        }
                        else
                        {
                            uhodnutepole.Add(klobasa);
                            Console.WriteLine("Správně");
                            //                        Console.WriteLine(vyhra);

                        }
                    }
                    else
                    {
                        uhodnutepole.Add(klobasa);
                        Console.WriteLine("Správně");
                    }
                }
                else
                {
                    chyba++;
                    Console.WriteLine("Počet chyb " + chyba + "/4");
                }
                /*
                if (uhodnutepole.Count() == numberOfLetters)
                {
                    vyhra = true;
                }
                */
                //pokud je vice nebo rovno 4 chyb tak konec
                if (chyba == 4)
                {
                    Console.Clear();
                    Console.WriteLine("konec");
                }
                //pokud vyhral tak se vypise jestli chce pokracovat nebo ne
                else if (vyhra == true)
                {

                    Console.Clear();
                    Console.WriteLine(level1);
                    Console.WriteLine("Vyhra");
                    Console.WriteLine("<Chcete pokračovat stiskněte Y pokud ne stiskněte N>");
                    ConsoleKeyInfo keyinfo;
                    keyinfo = Console.ReadKey();
                    //kontrola vepsane klavesy
                    //pokud Y tak pokracuje
                    if (keyinfo.Key == ConsoleKey.Y)
                    {
                        Console.Clear();
                        chyba = 0;
                        uhodnutepole.Clear();
                        slovaindex = rnd.Next(slova.Length);
                        level1 = slova[slovaindex];
                        pocetPismen = 0;
                        numberOfLetters = level1.Length;
                        vyhra = false;
                        //         Console.WriteLine(vyhra);
                    }
                    //pokud N tak konci
                    else if (keyinfo.Key == ConsoleKey.N)
                    {
                        Console.Clear();
                        Console.Write(level1);
                        Console.WriteLine("Konec");
                    }
                }
            }
        }
    }
}