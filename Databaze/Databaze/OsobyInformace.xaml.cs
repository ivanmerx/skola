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
        public OsobyInformace(Osoba osoba)
        {
            InitializeComponent();
            this.osoba = osoba;
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
            MessageBox.Show(osoba.ID.ToString());
        }
    }
}
