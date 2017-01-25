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
    /// Interaction logic for Morie5.xaml
    /// </summary>
    public partial class Morie5 : Page
    {
        public Morie5()
        {
            InitializeComponent();
            this.Background = new ImageBrush(new BitmapImage(new Uri(@"pack://application:,,,/dracak;component/Obrazky/moriemain.jpg")));
            image.Source = new BitmapImage(new Uri(@"pack://application:,,,/dracak;component/Obrazky/papir.jpg"));
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
