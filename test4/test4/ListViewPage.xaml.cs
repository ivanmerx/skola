using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace test4
{
    /// <summary>
    /// Interakční logika pro ListViewPage.xaml
    /// </summary>
    public partial class ListViewPage : Page
    {
        public ListViewPage()
        {
            InitializeComponent();
            List<Produkt> listproduktu = new List<Produkt>();

            Produkt produkt1 = new Produkt();
            Produkt produkt2 = new Produkt();
            Produkt produkt3 = new Produkt();
            Produkt produkt4 = new Produkt();

            produkt1.nazev = "Auto";
            produkt1.cena = 500;
            produkt1.kategorie = "Hračky";
            produkt1.mnozstvisklad = 20;
            produkt1.vyrobce = "Hračkářství Žalud1";

            produkt2.nazev = "Tramvaj";
            produkt2.cena = 800;
            produkt2.kategorie = "Hračky";
            produkt2.mnozstvisklad = 10;
            produkt2.vyrobce = "Hračkářství Žalud2";

            produkt3.nazev = "Letadlo";
            produkt3.cena = 300;
            produkt3.kategorie = "Hračky";
            produkt3.mnozstvisklad = 5;
            produkt3.vyrobce = "Hračkářství Žalud3";

            produkt4.nazev = "Lokomotiva";
            produkt4.cena = 200;
            produkt4.kategorie = "Hračky";
            produkt4.mnozstvisklad = 12;
            produkt4.vyrobce = "Hračkářství Žalud4";

            listproduktu.Add(produkt1);
            listproduktu.Add(produkt2);
            listproduktu.Add(produkt3);
            listproduktu.Add(produkt4);

            listView.ItemsSource = listproduktu;
        }

        public void ZmenaSelectu(object sender, SelectionChangedEventArgs e)
        {
            Produkt vybranyprodukt = (Produkt)listView.SelectedItems[0];
            if (listView.SelectedItems.Count > 0)
            {
                this.NavigationService.Navigate(new InfoOsoby(vybranyprodukt));
            }
        }
    }
}
