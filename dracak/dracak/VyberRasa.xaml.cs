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
    /// Interaction logic for Pribeh.xaml
    /// </summary>
    public partial class VyberRasa : Page
    {
        public VyberRasa()
        {
            InitializeComponent();
            TextBlock2.Text = "Vítej válečníku: " + App.hrac.Jmeno + "\nVyber si rasu";
            //this.Background = new ImageBrush(new BitmapImage(new Uri(@"https://s-media-cache-ak0.pinimg.com/originals/32/47/52/32475254b971f97e4c807265f8e5d4b6.jpg")));
            this.Background = new ImageBrush(new BitmapImage(new Uri(@"pack://application:,,,/dracak;component/Obrazky/vyberrasa.jpg")));
            image.Source = new BitmapImage(new Uri(@"pack://application:,,,/dracak;component/Obrazky/elf.jpg"));
            image4.Source = new BitmapImage(new Uri(@"pack://application:,,,/dracak;component/Obrazky/hobit.jpg"));
            image3.Source = new BitmapImage(new Uri(@"pack://application:,,,/dracak;component/Obrazky/trpaslik.png"));
            image2.Source = new BitmapImage(new Uri(@"pack://application:,,,/dracak;component/Obrazky/clovek.jpg"));
            image5.Source = new BitmapImage(new Uri(@"pack://application:,,,/dracak;component/Obrazky/carodej.jpg"));
        }

        private void checkBox_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
           // App.hrac.Rasa = (sender as Button).ToString();
            App.hrac.Rasa = (e.Source as Button).Content.ToString();
            string textmorie1 = "Vypraveč: Nacházíš se v trpasličích dolech v Morii se společenstvem prstenu a nyní máš za úkol se probojovat ven z hory.Vypravěč: Vidíš jak za vámi běží skupinka skřetů, nyní máš na výběr běžet dál a snažit se jim utéct a nebo se jim postavíš čelem a pokusíš se je zničit.";
            string textmorie2_1 = "Vypravěč: Nyní vás skřeti zahnali do místnosti se zamčenými dveřmi, odraž zatím útok dvou skřetů, kteří se odvážili na vás zaútočit mezitím, co ostatní budou ničit dveře.";
            App.Current.MainWindow.Content = new Vybervybaveni();
        }

    }
}
