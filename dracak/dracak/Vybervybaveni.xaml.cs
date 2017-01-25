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
using dracak.Morie;
namespace dracak
{
    /// <summary>
    /// Interaction logic for Startpribeh.xaml
    /// </summary>
    public partial class Vybervybaveni : Page
    {
        public Vybervybaveni()
        {
            InitializeComponent();
            textBlock.Text = "Vítej válečníku " + App.hrac.Jmeno + "\nVybral jsi si rasu " + App.hrac.Rasa + "\nNyní si vyber výzbroj";
            image1.Source = new BitmapImage(new Uri(@"pack://application:,,,/dracak;component/Obrazky/mec.jpg"));
            image2.Source = new BitmapImage(new Uri(@"pack://application:,,,/dracak;component/Obrazky/sekera.jpg"));
            image.Source = new BitmapImage(new Uri(@"pack://application:,,,/dracak;component/Obrazky/hul.jpg"));
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            string content = (sender as Button).Content.ToString();
            if (content == "Mec")
            {
                App.hrac.vybaveni = new Mec();
            }
            else if(content == "Sekera")
            {
                App.hrac.vybaveni = new Sekyra();
            }
            else if(content == "Hul")
            {
                App.hrac.vybaveni = new Hul();
            }
            App.Current.MainWindow.Content = new Morie1();
        }
    }
}
