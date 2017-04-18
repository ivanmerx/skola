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

namespace databaze_test_main
{
    /// <summary>
    /// Interakční logika pro PisnickyInfo.xaml
    /// </summary>
    public partial class PisnickyInfo : Page
    {
        Pisnicka vybranapisnicka;
        ListView pisnicky;
        bool vytvoritnovymain;
        public PisnickyInfo()
        {
            InitializeComponent();
        }
        public PisnickyInfo(Pisnicka vybranapisnicka, ListView pisnicky)
        {
            InitializeComponent();
            this.vybranapisnicka = vybranapisnicka;
            this.pisnicky = pisnicky;
            textBox.Text = vybranapisnicka.Nazev;
            textBox2.Text = vybranapisnicka.Interpret;
            textBox3.Text = vybranapisnicka.Delka.ToString();
            int vypocet = vybranapisnicka.Delka / 60;
            int vypocet2 = vybranapisnicka.Delka % 60;
            string vypocethotov = vypocet + ":" + vypocet2;
            textBox3.Text = vypocethotov.ToString();

        }
        public PisnickyInfo(bool vytvoritnovy, ListView pisnicky)
        {
            InitializeComponent();
            this.vytvoritnovymain = vytvoritnovy;
            this.pisnicky = pisnicky;
        }
        private void button_Click(object sender, RoutedEventArgs e)
        {
            if (vytvoritnovymain)
            {
                if (!String.IsNullOrEmpty(textBox.Text) && !String.IsNullOrEmpty(textBox2.Text) && !String.IsNullOrEmpty(textBox3.Text))
                {
                    int n;
                    bool isNumeric = int.TryParse(textBox3.Text, out n);
                    if (isNumeric)
                    {
                        Pisnicka vytvorenapisnicka = new Pisnicka();
                        vytvorenapisnicka.Nazev = textBox.Text;
                        vytvorenapisnicka.Interpret = textBox2.Text;

                        int vypocet = Int32.Parse(textBox3.Text) / 60;
                        int vypocet2 = Int32.Parse(textBox3.Text) % 60;
                        string vypocethotov = vypocet + ":" + vypocet2;
                        vytvorenapisnicka.Delka = Int32.Parse(textBox3.Text);

                        PisnickyZobrazeni.Database.VytvorPisnicku(vytvorenapisnicka);
                        PisnickyZobrazeni.Database.GetItemsAsync();
                        var itemsFromDb = PisnickyZobrazeni.Database.GetItemsNotDoneAsync().Result;
                        pisnicky.ItemsSource = itemsFromDb;
                        this.NavigationService.Navigate(new PisnickyZobrazeni());
                    }
                    else
                    {
                        MessageBox.Show("Zadejte číslo do délky");
                    }
                }
                else
                {
                    MessageBox.Show("Zadejte hodnoty");
                }
            }
            else
            {
                if (!String.IsNullOrEmpty(textBox.Text) && !String.IsNullOrEmpty(textBox2.Text) && !String.IsNullOrEmpty(textBox3.Text))
                {
                    int n;
                    bool isNumeric = int.TryParse(textBox3.Text, out n);
                    if (isNumeric)
                    {
                        vybranapisnicka.Nazev = textBox.Text;
                        vybranapisnicka.Interpret = textBox2.Text;
                        int vypocet = Int32.Parse(textBox3.Text) / 60;
                        int vypocet2 = Int32.Parse(textBox3.Text) % 60;
                        string vypocethotov = vypocet + ":" + vypocet2;
                        vybranapisnicka.Delka = Int32.Parse(textBox3.Text);
                        PisnickyZobrazeni.Database.SaveItemAsync(vybranapisnicka);
                        PisnickyZobrazeni.Database.GetItemsAsync();
                        var itemsFromDb = PisnickyZobrazeni.Database.GetItemsNotDoneAsync().Result;
                        pisnicky.ItemsSource = itemsFromDb;
                        this.NavigationService.Navigate(new PisnickyZobrazeni());
                    }
                    else
                    {
                        MessageBox.Show("Zadejte číslo do délky");
                    }
                }
                else
                {
                    MessageBox.Show("Zadejte všechny hodnoty");
                }
            }
        }
    }
}
