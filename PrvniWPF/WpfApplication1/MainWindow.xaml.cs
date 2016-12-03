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

namespace WpfApplication1
{
    /// <summary>
    /// Interakční logika pro MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int _noClicks;
        Otazky otazky = new Otazky();
        public MainWindow()
        {
            Random rnd = new Random();
            InitializeComponent();
            var prvnicislo = otazky.prvnicislo();
            var druhycislo = otazky.druhycislo();
            var operandy = otazky.operandy();
            textBlock2.Text = prvnicislo + operandy + druhycislo;
            int buttony = rnd.Next(1,2);
            if (buttony == 2)
            {
                button.Content = rnd.Next(1, 200);
                switch (operandy)
                {
                    case "+":
                        button2.Content = button.Content = prvnicislo + druhycislo;
                        break;
                    case "-":
                        button2.Content = button.Content = prvnicislo - druhycislo;
                        break;
                    case "*":
                        button2.Content = button.Content = prvnicislo * druhycislo;
                        break;
                    case "/":
                        button2.Content = button.Content = prvnicislo / druhycislo;
                        break;
                    default:
                        button2.Content = "Něco random";
                        break;

                }
            }else if(buttony == 1)
            {
                button2.Content = rnd.Next(1, 200);
                switch (operandy)
                {
                    case "+":
                        button.Content = button.Content = prvnicislo + druhycislo;
                        break;
                    case "-":
                        button.Content = button.Content = prvnicislo - druhycislo;
                        break;
                    case "*":
                        button.Content = button.Content = prvnicislo * druhycislo;
                        break;
                    case "/":
                        button.Content = button.Content = prvnicislo / druhycislo;
                        break;
                    default:
                        button.Content = "Něco random";
                        break;

                }
            }
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
        }
    }
}
