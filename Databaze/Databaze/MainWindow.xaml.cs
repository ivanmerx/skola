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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var itemsFromDb = Database.GetItemsNotDoneAsync().Result;

            /*Osoba osoba = new Osoba();
            osoba.Jmeno = "klobasa";
            osoba.Prijmeni = "lmao";
            Database.SaveItemAsync(osoba);
            */
            foreach (Osoba todoItem in itemsFromDb)
            {
                Debug.WriteLine(todoItem);
            }



            //ItemsCount.Content = "Items in Database " + itemsFromDb.Count;
            OsobyInfo.ItemsSource = itemsFromDb;
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
        private void OsobyInfo_kliknuti(object sender, MouseButtonEventArgs e)
        {
            Osoba lmao = (((ListView)sender).SelectedItem as Osoba);
            frame.Navigate(new OsobyInformace(lmao, OsobyInfo));
            frame.NavigationUIVisibility = System.Windows.Navigation.NavigationUIVisibility.Hidden;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            frame.Navigate(new VytvorUzivatele(OsobyInfo));
            frame.NavigationUIVisibility = System.Windows.Navigation.NavigationUIVisibility.Hidden;
        }

    }
}