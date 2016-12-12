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
        }
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
    }
}
