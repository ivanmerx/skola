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
            telcislo.Text = osoba.ZiskejTelCislo;
            jmeno.Text=osoba.Jmeno;
            prijmeni.Text = osoba.Prijmeni;
            Image.Source = "http://uppix.3dvf.com/images/tetescvfv.jpg";



        }

        public void ButtonClick(Object sender, EventArgs e)
        {
            /*
            intent.button.Click += delegate {
                var uri = Android.Net.Uri.Parse("tel:1112223333");
                var intent = new Intent(Intent.ActionDial, uri);
                StartActivity(intent);
            };
            */
        }
    }
}

