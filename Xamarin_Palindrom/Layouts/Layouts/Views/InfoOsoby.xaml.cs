using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Layouts.Views
{
    public partial class InfoOsoby : ContentPage
    {
        public InfoOsoby()
        {
            InitializeComponent();
        }

        public InfoOsoby(Osoba osoba)
        {
            InitializeComponent();
            jmeno.Text=osoba.Jmeno;
            prijmeni.Text = osoba.Prijmeni;
            Image.Source = "http://uppix.3dvf.com/images/tetescvfv.jpg";

        }
    }
}

