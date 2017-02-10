using System;
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
    /// Interaction logic for VytvorUzivatele.xaml
    /// </summary>
    public partial class VytvorUzivatele : Page
    {
        ListView listview;
        public VytvorUzivatele(ListView listview)
        {
            InitializeComponent();
            this.listview = listview;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Osoba osoba2 = new Osoba();
            osoba2.Jmeno = textBox.Text;
            osoba2.Prijmeni = textBox1.Text;
            osoba2.DatNar = textBox2.Text;
            osoba2.Pohlavi = textBox3.Text;
            MainWindow.Database.VytvoritUzivatele(osoba2);
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
