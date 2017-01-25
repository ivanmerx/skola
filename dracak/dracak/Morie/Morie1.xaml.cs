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
    /// Interaction logic for Morie1.xaml
    /// </summary>
    public partial class Morie1 : Page
    {
        public Morie1()
        {
            InitializeComponent();
            this.Background = new ImageBrush(new BitmapImage(new Uri(@"http://orig02.deviantart.net/c883/f/2014/308/c/3/mines_of_moria___lord_of_the_rings_tcg_by_jcbarquet-d859fti.jpg")));
            //
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            App.Current.MainWindow.Content = new Morie2_1();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
          //  App.Current.MainWindow.Content = new Morie2_2();
        }
    }
}
