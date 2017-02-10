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
using System.Diagnostics;
namespace Databaze_Full
{
    /// <summary>
    /// Interaction logic for OsobyInformace.xaml
    /// </summary>
    public partial class OsobyInformace : Page
    {
        private string id;
        Osoba osoba;
        ListView listview;
        public OsobyInformace(Osoba osoba, ListView listview)
        {
            InitializeComponent();
            this.osoba = osoba;
            this.listview = listview;
            label.Content = "Úprava zápisu v databázi s ID = " + osoba.ID;
            if(osoba.Jmeno != "")
            {
                textBox.Text = osoba.Jmeno;
            } 
            if(osoba.Prijmeni != ""){

                textBox1.Text = osoba.Prijmeni;
            } 
            if(osoba.DatNar != "")
            {
                textBox2.Text = osoba.DatNar;
            } 
            if(osoba.Pohlavi != "")
            {
                textBox3.Text = osoba.Pohlavi;
            }
        }
        private void button_Click(object sender, RoutedEventArgs e)
        {

            osoba.Jmeno = textBox.Text;
            osoba.Prijmeni = textBox1.Text;
            osoba.DatNar = textBox2.Text;
            osoba.Pohlavi = textBox3.Text;
            MainWindow.Database.UlozitUzivatele(osoba);
            MainWindow.Database.GetItemsAsync();
            var itemsFromDb = MainWindow.Database.GetItemsNotDoneAsync().Result;
            foreach (Osoba osoba in itemsFromDb)
            {
                Debug.WriteLine(osoba);
            }
            listview.ItemsSource = itemsFromDb;
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.Database.SmazatUzivatele(osoba);
            MainWindow.Database.GetItemsAsync();
            var itemsFromDb = MainWindow.Database.GetItemsNotDoneAsync().Result;
            foreach (Osoba osoba in itemsFromDb)
            {
                Debug.WriteLine(osoba);
            }
            listview.ItemsSource = itemsFromDb;
        }
    }
}
