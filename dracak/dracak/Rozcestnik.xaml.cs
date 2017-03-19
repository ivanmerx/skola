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
    /// Interakční logika pro Rozcestnik.xaml
    /// </summary>
    public partial class Rozcestnik : Page
    {
        public Rozcestnik()
        {
            InitializeComponent();
            //image.Source = new BitmapImage(new Uri(@"pack://application:,,,/dracak;component/Obrazky/rozcestnik.jpg"));
            this.Background = new ImageBrush(new BitmapImage(new Uri(@"pack://application:,,,/dracak;component/Obrazky/rozcestnik.jpg")));
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            new ZacitPribeh();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            App.Current.MainWindow.Content = new Arena();
        }
    }
}
