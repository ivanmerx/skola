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
    /// Interakční logika pro InfoOsoby.xaml
    /// </summary>
    public partial class InfoOsoby : Page
    {
        public InfoOsoby()
        {
            InitializeComponent();
        }
        public InfoOsoby(Produkt vybranyprodukt)
        {
            InitializeComponent();
            textBlock.Text = "Kategorie: " + vybranyprodukt.kategorie;
            textBlock1.Text = "Výrobce: " + vybranyprodukt.vyrobce;
            textBlock2.Text = "Počet kusů na skladě : " + vybranyprodukt.mnozstvisklad;
        }
    }
}
