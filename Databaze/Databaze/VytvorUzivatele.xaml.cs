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
        string pohlavi;
        string datNar1cast;
        string datNar2cast;
        public VytvorUzivatele(ListView listview)
        {
            InitializeComponent();
            this.listview = listview;
        }
        private void radioButton_Checked(object sender, RoutedEventArgs e)
        {
            this.pohlavi = (string)(sender as RadioButton).Content;
        }
        private void button_Click(object sender, RoutedEventArgs e)
        {
            Osoba osoba2 = new Osoba();

            int n;
            bool isNumeric = int.TryParse(textBox2.Text, out n);
            bool pomocny = true;
            if (!String.IsNullOrEmpty(textBox.Text))
            {
                osoba2.Jmeno = textBox.Text;
            }
            else
            {
                MessageBox.Show("Zadejte jméno");
                pomocny = false;
            }
            if (!String.IsNullOrEmpty(textBox1.Text))
            {
                osoba2.Prijmeni = textBox1.Text;
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
            }else
            {
                if (!isNumeric)
                {
                    MessageBox.Show("Zadejte čísla");
                    pomocny = false;
                }else
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
                osoba2.Pohlavi = pohlavi;
            }
            else
            {
                pomocny = false;
                MessageBox.Show("Vyberte pohlaví");
            }
            /*
            osoba2.Jmeno = textBox.Text;
            osoba2.Prijmeni = textBox1.Text;
            osoba2.DatNar = textBox2.Text;
            osoba2.Pohlavi = pohlavi;
            */
            //osoba2.Pohlavi = textBox3.Text;
            if (pomocny)
            {
                osoba2.DatNar = datNar1cast+"/"+datNar2cast;
                osoba2.FirstTimestamp = DateTime.Now;
                MainWindow.Database.VytvoritUzivatele(osoba2);
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
    }
}
