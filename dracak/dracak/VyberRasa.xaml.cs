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
    /// Interaction logic for Pribeh.xaml
    /// </summary>
    public partial class VyberRasa : Page
    {
        public VyberRasa()
        {
            InitializeComponent();
            TextBlock2.Text = "Vítej válečníku " + App.hrac.Jmeno + "\nVyber si rasu";
        }

        private void checkBox_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
           // App.hrac.Rasa = (sender as Button).ToString();
            App.hrac.Rasa = (e.Source as Button).Content.ToString();
            App.Current.MainWindow.Content = new Vybervybaveni();
        }

    }
}
