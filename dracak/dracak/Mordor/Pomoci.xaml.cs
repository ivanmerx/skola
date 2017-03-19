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

namespace dracak
{
    /// <summary>
    /// Interaction logic for Pomoci.xaml
    /// </summary>
    public partial class Pomoci : Page
    {
        prisera prisera = new prisera(" ", new Vzdusny());
        public Pomoci()
        {
            InitializeComponent();
            prisera.typprisery = new Pozemni();
            textBlock.Text = App.hrac.Rasa + " " + App.hrac.Jmeno + "\nHodnota útoku: " + App.hrac.vybaveni.hodnotaUtoku + "\nNázev zbraně: " + App.hrac.vybaveni.nazev;
            //textBlock2.Text = prisera.typprisery.nazev + "\nHodnota útoku: " + prisera.typprisery.hodnotaUtoku;
            textBlock1.Text = App.hrac.Zivoty.ToString();
            textBlock3.Text = prisera.typprisery.zivoty.ToString();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            if(ProgressBar.Value <= 0)
            {
                App.Current.MainWindow.Content = new MainWindow();
            }else
            {
                ProgressBar.Value -= prisera.typprisery.hodnotaUtoku;
                textBlock1.Text = (Int32.Parse(textBlock1.Text) - prisera.typprisery.hodnotaUtoku).ToString();
            }
            if(ProgressBar2.Value <= 0)
            {
                App.hrac.vybaveni.hodnotaUtoku += 10;
                App.Current.MainWindow.Content = new PoPrvnimBoji();
            }
            else
            {
                ProgressBar2.Value -= App.hrac.vybaveni.hodnotaUtoku;
                textBlock3.Text = (Int32.Parse(textBlock3.Text) - App.hrac.vybaveni.hodnotaUtoku).ToString();
            }
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ProgressBar_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

        }
    }
}
