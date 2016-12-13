using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Layouts.Views
{
    public partial class Page3 : ContentPage
    {
        public Page3()
        {
            InitializeComponent();
           //soba osoba = new Osoba();
            /*
            osoba.Jmeno = "Tomáš";
            osoba.Prijmeni = "Klokočka";
            osoba.Vek = 12;
            osoba.TelCislo = 123456789;
            */
            List<Osoba> ListMain = new List<Osoba>();
            ListMain.Add(new Osoba("Tomáš", "Klokočka", 12, 123456789));
            ListMain.Add(new Osoba("Libor", "Tomana", 50, 123456789));
            ListMain.Add(new Osoba("Šimon", "Hladký", 9, 123456789));
            ListMain.Add(new Osoba("Ivan", "Autosalon", 5, 123456789));
            //list.ItemsSource = ListMain;
            list2.ItemsSource = ListMain;
        }
        /*
        private void ZmenaTextu(object sender, TextChangedEventArgs e)
        {
            Vysledek.Text = " ";
            Vysledek3.Text = " ";
            string Hodnota = e.NewTextValue.ToLower();
            int Pocitani = Hodnota.Length;
            string Opacne = "";

            if (Pocitani > 0)
            {
                for (int i = Hodnota.Length; i > 0; i--)
                {
                    Opacne += Hodnota[i - 1].ToString();
                }

                if (Hodnota == Opacne)
                {
                    Vysledek.Text = Hodnota;
                    Vysledek3.Text = "Ano jedná se o palindrom";
                }
                else
                {
                    Vysledek.Text = Hodnota;
                    Vysledek3.Text = "Nejedná se o palindrom";
                }
            }
        }
        */
    }
}
