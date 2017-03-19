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
namespace dracak
{
    /// <summary>
    /// Interakční logika pro Arena.xaml
    /// </summary>
    public partial class Arena : Page
    {
        prisera prisera1 = new prisera("Skřet",new Pozemni());
        prisera prisera2 = new prisera("Skřet2", new Pozemni());
        prisera prisera3 = new prisera("Skřet3", new Pozemni());
        private prisera vygenerovanaprisera1;
        List<prisera> listpriser = new List<prisera>();
        public Arena()
        {
            InitializeComponent();
            prisera1.NazevObrazku = "skret";
            prisera2.NazevObrazku = "balrog";
            prisera3.NazevObrazku = "skret";
            listpriser.Add(prisera1);
            listpriser.Add(prisera2);
            listpriser.Add(prisera3);

            Random rnd = new Random();
            int r = rnd.Next(listpriser.Count);
            prisera vygenerovanaprisera = listpriser.ElementAt(r);
            this.vygenerovanaprisera1 = vygenerovanaprisera;
            xpprogress.Text = App.hrac.Xp + "/" + 120;
            ProgressBar3.Value += App.hrac.Xp;
            textBlock.Text = App.hrac.Jmeno;
            textBlock1.Text = App.hrac.Zivoty.ToString();
            textBlock4.Text = "Hodnota útoku " + App.hrac.vybaveni.hodnotaUtoku;
            textBlock2.Text = vygenerovanaprisera.Nazev;
            textBlock3.Text = vygenerovanaprisera.typprisery.zivoty.ToString();
            image1.Source = new BitmapImage(new Uri(@"pack://application:,,,/dracak;component/Obrazky/" + vygenerovanaprisera.NazevObrazku + ".jpg"));
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

        private void ProgressBar_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            if (App.hrac.Xp == 120)
            {
                new ZacitPribeh();
            }
            if (ProgressBar.Value <= 0)
            {
                App.Current.MainWindow.Content = new MainWindow();
            }
            else
            {
                ProgressBar.Value -= vygenerovanaprisera1.typprisery.hodnotaUtoku;
                textBlock1.Text = (Int32.Parse(textBlock1.Text) - vygenerovanaprisera1.typprisery.hodnotaUtoku).ToString();
            }
            if (ProgressBar2.Value <= 0)
            {
                App.hrac.Xp += 20;
                App.Current.MainWindow.Content = new Arena();
            }
            else
            {
                Random kostka = new Random();
                int random = kostka.Next(1, 100);
                if (random % 2 == 0)
                {
                    ProgressBar2.Value -= App.hrac.vybaveni.hodnotaUtoku;
                    textBlock3.Text = (Int32.Parse(textBlock3.Text) - (App.hrac.vybaveni.hodnotaUtoku + App.hrac.vybaveni.hodnotaUtoku / 100 * 110)).ToString();
                }
                else
                {
                    ProgressBar2.Value -= App.hrac.vybaveni.hodnotaUtoku;
                    textBlock3.Text = (Int32.Parse(textBlock3.Text) - App.hrac.vybaveni.hodnotaUtoku).ToString();
                }
            }
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            ProgressBar.Value += vygenerovanaprisera1.typprisery.hodnotaUtoku;
            textBlock1.Text = (vygenerovanaprisera1.typprisery.hodnotaUtoku + App.hrac.vybaveni.hodnotaUtoku).ToString();
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

        private void ProgressBar3_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

        }
    }
}
