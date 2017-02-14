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
        string pohlavi;
        public OsobyInformace(Osoba osoba, ListView listview)
        {
            InitializeComponent();
            this.osoba = osoba;
            this.listview = listview;
            label.Content = "Úprava zápisu v databázi s ID = " + osoba.ID;
            
            if(osoba.Pohlavi.Equals("Muž"))
            {
                radioButton1.IsChecked = true;
            }else
            {
                radioButton.IsChecked = true;
            }
            
            textBox.Text = osoba.Jmeno;
            textBox1.Text = osoba.Prijmeni;
            textBox2.Text = osoba.DatNar;
            //if(osoba.Jmeno != "")
            //{
            //    textBox.Text = osoba.Jmeno;
            //} 
            //if(osoba.Prijmeni != ""){

            //    textBox1.Text = osoba.Prijmeni;
            //} 
            //if(osoba.DatNar != "")
            //{
            //    textBox2.Text = osoba.DatNar;
            //} 
            //if(osoba.Pohlavi != "")
            //{
            //    //textBox3.Text = osoba.Pohlavi;
            //}
        }
        private void radioButton_Checked(object sender, RoutedEventArgs e)
        {
            this.pohlavi = (string)(sender as RadioButton).Content;
        }
        private void button_Click(object sender, RoutedEventArgs e)
        {
            int n;
            bool isNumeric = int.TryParse(textBox2.Text, out n);
            bool pomocna = true;
            if (! String.IsNullOrEmpty(textBox.Text))
            {
                osoba.Jmeno = textBox.Text;
            }
            else
            {
                MessageBox.Show("Zadejte jméno");
                pomocna = false;
            }
            if (! String.IsNullOrEmpty(textBox1.Text))
            {
                osoba.Prijmeni = textBox1.Text;
            }
            else
            {
                MessageBox.Show("Zadejte příjmení");
                pomocna = false;
            }
            if (! String.IsNullOrEmpty(textBox2.Text))
            {
                if (!isNumeric)
                {
                    MessageBox.Show("Do datNar zadejte číslo");
                    pomocna = false;
                }
                else
                {
                    osoba.DatNar = textBox2.Text;
                }
            }
            else
            {
                MessageBox.Show("Zadejte datNar");
                pomocna = false;
            }
            if (!String.IsNullOrEmpty(pohlavi))
            {
                osoba.Pohlavi = pohlavi;
            }
            else
            {
                MessageBox.Show("Vyberte pohlaví");
                pomocna = false;
            }
            //osoba.Pohlavi = textBox3.Text;
            if (pomocna)
            {
                MainWindow.Database.UlozitUzivatele(osoba);
                MainWindow.Database.GetItemsAsync();
                var itemsFromDb = MainWindow.Database.GetItemsNotDoneAsync().Result;
                foreach (Osoba osoba in itemsFromDb)
                {
                    Debug.WriteLine(osoba);
                }
                listview.ItemsSource = itemsFromDb;
            }else
            {
                MessageBox.Show("Zápis do databáze neproběhl");
            }
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
