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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //dodělat příběh, aby to bylo delší a potom tam udělat lepší systém souboje a možná i lepší grafiku http://www.1001fonts.com/morris-roman-font.html#license
            //this.Background = new ImageBrush(new BitmapImage(new Uri(@"Obrazky/mainwindow.jpg")));
            this.Background =new ImageBrush(new BitmapImage(new Uri(@"pack://application:,,,/dracak;component/Obrazky/mainwindow.jpg")));

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {

            App.hrac.Jmeno = textBlock1.Text;
            this.Content = new VyberRasa();

        }
    }
}
