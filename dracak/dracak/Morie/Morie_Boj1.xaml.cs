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
    /// Interaction logic for Morie_Boj1.xaml
    /// </summary>
    public partial class Morie_Boj1 : Page
    {
        public Morie_Boj1()
        {
            InitializeComponent();
            prisera Prisera = new prisera("Goblin",new Pozemni());
            textBlock2.Text = Prisera.Nazev;
            textBlock.Text = App.hrac.Jmeno;
            textBlock1.Text = App.hrac.Zivoty.ToString();
            textBlock3.Text = Prisera.typprisery.zivoty.ToString();

            if (App.hrac.Rasa == "Člověk") {
                App.hrac.kouzlo = new Clovek();
                button3.Content = App.hrac.kouzlo.nazev;
            }else if(App.hrac.Rasa == "Trpaslík"){
                App.hrac.kouzlo = new Trpaslik();
                button3.Content = App.hrac.kouzlo.nazev;
            }
            else if(App.hrac.Rasa == "Elf"){
                App.hrac.kouzlo = new Elf();
                button3.Content = App.hrac.kouzlo.nazev;
            }
            else if(App.hrac.Rasa == "Čaroděj")
            {
                App.hrac.kouzlo = new Carodej();
                button3.Content = App.hrac.kouzlo.nazev;
            }
            else if(App.hrac.Rasa == "Hobit")
            {
                App.hrac.kouzlo = new Hobit();
                button3.Content = App.hrac.kouzlo.nazev;
            }
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ProgressBar_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

        }
    }
}
