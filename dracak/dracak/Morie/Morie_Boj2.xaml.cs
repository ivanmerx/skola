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
using dracak.Kouzla;

namespace dracak.Morie
{
    /// <summary>
    /// Interaction logic for Morie_Boj2.xaml
    /// </summary>
    public partial class Morie_Boj2 : Page
    {
        prisera Prisera = new prisera("Balrog", new Pozemni());

        public Morie_Boj2()
        {
            InitializeComponent();
            int help = Prisera.typprisery.hodnotaUtoku;
            textBlock2.Text = Prisera.Nazev;
            textBlock.Text = App.hrac.Jmeno;
            textBlock1.Text = App.hrac.Zivoty.ToString();
            textBlock3.Text = Prisera.typprisery.zivoty.ToString();
            textBlock4.Text = "Hodnota útoku " + App.hrac.vybaveni.hodnotaUtoku;
            image1.Source = new BitmapImage(new Uri(@"pack://application:,,,/dracak;component/Obrazky/balrog.jpg"));
            if (App.hrac.Rasa == "Člověk")
            {
                App.hrac.kouzlo = new Clovek();
                button3.Content = App.hrac.kouzlo.nazev;
                image.Source = new BitmapImage(new Uri(@"pack://application:,,,/dracak;component/Obrazky/clovek.jpg"));
            }
            else if (App.hrac.Rasa == "Trpaslík")
            {
                App.hrac.kouzlo = new Trpaslik();
                button3.Content = App.hrac.kouzlo.nazev;
                image.Source = new BitmapImage(new Uri(@"pack://application:,,,/dracak;component/Obrazky/trpaslik.png"));
            }
            else if (App.hrac.Rasa == "Elf")
            {
                App.hrac.kouzlo = new Elf();
                button3.Content = App.hrac.kouzlo.nazev;
                image.Source = new BitmapImage(new Uri(@"pack://application:,,,/dracak;component/Obrazky/elf.jpg"));
            }
            else if (App.hrac.Rasa == "Čaroděj")
            {
                App.hrac.kouzlo = new Carodej();
                button3.Content = App.hrac.kouzlo.nazev;
                image.Source = new BitmapImage(new Uri(@"pack://application:,,,/dracak;component/Obrazky/carodej.jpg"));
            }
            else if (App.hrac.Rasa == "Hobit")
            {
                App.hrac.kouzlo = new Hobit();
                button3.Content = App.hrac.kouzlo.nazev;
                image.Source = new BitmapImage(new Uri(@"pack://application:,,,/dracak;component/Obrazky/hobit.jpg"));
            }
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            if (ProgressBar.Value <= 0)
            {
                App.Current.MainWindow.Content = new MainWindow();
            }
            else
            {
                ProgressBar.Value -= Prisera.typprisery.hodnotaUtoku;
                textBlock1.Text = (Int32.Parse(textBlock1.Text) - Prisera.typprisery.hodnotaUtoku).ToString();
            }
            if (ProgressBar2.Value <= 0)
            {
                App.Current.MainWindow.Content = new Morie5();
            }
            else
            {
                ProgressBar2.Value -= App.hrac.vybaveni.hodnotaUtoku;
                textBlock3.Text = (Int32.Parse(textBlock3.Text) - App.hrac.vybaveni.hodnotaUtoku).ToString();
            }
        }

        private void ProgressBar_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            ProgressBar.Value += Prisera.typprisery.hodnotaUtoku;
            textBlock1.Text = (Prisera.typprisery.hodnotaUtoku + App.hrac.vybaveni.hodnotaUtoku).ToString();
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            App.hrac.vybaveni.hodnotaUtoku += App.hrac.kouzlo.hodnotaUtoku;
            textBlock1.Text = (Int32.Parse(textBlock1.Text) + App.hrac.kouzlo.plusZivoty).ToString();
            ProgressBar.Value += App.hrac.kouzlo.plusZivoty;
            button3.IsEnabled = false;
            textBlock4.Text = "Hodnota útoku " + App.hrac.vybaveni.hodnotaUtoku;
            if (Int32.Parse(textBlock1.Text) >= 100)
            {
                ProgressBar.Value = 100;
                textBlock1.Text = 100.ToString();
            }
        }
    }
}
