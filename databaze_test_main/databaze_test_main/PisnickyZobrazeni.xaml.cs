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
    /// Interakční logika pro PisnickyZobrazeni.xaml
    /// </summary>
    public partial class PisnickyZobrazeni : Page
    {
        public PisnickyZobrazeni()
        {
            InitializeComponent();
            var itemsFromDb = Database.GetItemsNotDoneAsync().Result;

            //Pisnicka pisnicka = new Pisnicka();
            //pisnicka.Nazev = "lol";
            //pisnicka.Interpret = "lol222";
            //pisnicka.Delka = 123;
            //Database.SaveItemAsync(pisnicka);

            //foreach (Pisnicka todoItem in itemsFromDb)
            //{
            //    Debug.WriteLine(todoItem);
            //}



            //ItemsCount.Content = "Items in Database " + itemsFromDb.Count;
            Pisnicky.ItemsSource = itemsFromDb;
        }
        public void ZmenaSelectu(object sender, SelectionChangedEventArgs e)
        {

            if (Pisnicky.SelectedItems.Count > 0)
            {
                Pisnicka vybranapisnicka = (Pisnicka)Pisnicky.SelectedItems[0];
                this.NavigationService.Navigate(new PisnickyInfo(vybranapisnicka, Pisnicky));
            }
        }
        private static Databaze _database;
        public static Databaze Database
        {
            get
            {
                if (_database == null)
                {
                    var fileHelper = new FileHelper();
                    _database = new Databaze(fileHelper.GetLocalFilePath("TodoSQLite.db3"));
                }
                return _database;
            }
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new PisnickyInfo(true, Pisnicky));
        }
    }
}
