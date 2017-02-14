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
        string datNar1cast;
        string datNar2cast;
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
            textBox3.Text = osoba.DatNar.Substring(osoba.DatNar.Length - 4);
            textBox2.Text = osoba.DatNar.Substring(0, 6);
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
            bool pomocny = true;
            if (!String.IsNullOrEmpty(textBox.Text))
            {
                osoba.Jmeno = textBox.Text;
            }
            else
            {
                MessageBox.Show("Zadejte jméno");
                pomocny = false;
            }
            if (!String.IsNullOrEmpty(textBox1.Text))
            {
                osoba.Prijmeni = textBox1.Text;
            }
            else
            {
                MessageBox.Show("Zadejte příjmení");
                pomocny = false;
            }
            if (!String.IsNullOrEmpty(textBox2.Text))
            {
                if (!isNumeric)
                {
                    MessageBox.Show("Do datNar zadejte číslo");
                    pomocny = false;
                }
                else
                {
                    if (textBox2.Text.Length != 6)
                    {
                        MessageBox.Show("Špatný počet čísel v první části rodného čísla");
                        pomocny = false;
                    }
                    else
                    {
                        datNar1cast = textBox2.Text;
                    }
                }
            }
            else
            {
                MessageBox.Show("Zadejte datNar");
                pomocny = false;
            }
            if (String.IsNullOrEmpty(textBox3.Text))
            {
                MessageBox.Show("Zadejte za / čísla");
                pomocny = false;
            }
            else
            {
                if (!isNumeric)
                {
                    MessageBox.Show("Zadejte čísla");
                    pomocny = false;
                }
                else
                {
                    if (textBox3.Text.Length != 4)
                    {
                        MessageBox.Show("Špatný počet čísel ve druhé části rodného čísla");
                        pomocny = false;
                    }
                    else
                    {
                        datNar2cast = textBox3.Text;
                    }
                }
            }
            if (!String.IsNullOrEmpty(pohlavi))
            {
                osoba.Pohlavi = pohlavi;
            }
            else
            {
                pomocny = false;
                MessageBox.Show("Vyberte pohlaví");
            }
            //osoba.Pohlavi = textBox3.Text;
            if (pomocny)
            {
                osoba.DatNar = datNar1cast + "/" + datNar2cast;
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
