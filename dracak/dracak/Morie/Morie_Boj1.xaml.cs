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
            if(App.hrac.Rasa == "Člověk") {
                button3.Content = App.hrac.Rasa;
            }else if(App.hrac.Rasa == "Trpaslík"){

            }else if(App.hrac.Rasa == "Elf"){

            }else if(App.hrac.Rasa == "Čaroděj")
            {

            }else if(App.hrac.Rasa == "Hobit")
            {

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
