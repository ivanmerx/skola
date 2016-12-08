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
    /// 

    public partial class MainWindow : Window
    {
        private int _noClicks;
        Otazky otazky = new Otazky();
        decimal celkem;
        int level = 1;
        int zivoty = 10;
        public MainWindow()
        {
            InitializeComponent();
            ahoj();
        }
        public void ahoj()
        {
            Random rnd = new Random();
            textBlock4.Text = "Životy: " + zivoty.ToString();
            textBlock3.Text = "Úroveň: " + level.ToString();
            var prvnicislo = otazky.prvnicislo();
            var druhycislo = otazky.druhycislo();
            var operandy = otazky.operandy();
            textBlock2.Text = prvnicislo + operandy + druhycislo;
            int buttony = rnd.Next(1, 1000);
            //        textBlock1.Text = buttony.ToString();
            if (buttony % 2 == 0)
            {
                int druhybutton = 2;
                button.Content = rnd.Next(1, 200);
                switch (operandy)
                {
                    case "+":
                        button2.Content = prvnicislo + druhycislo;
                        celkem = prvnicislo + druhycislo;
                        break;
                    case "-":
                        button2.Content = prvnicislo - druhycislo;
                        celkem = prvnicislo - druhycislo;
                        break;
                    case "*":
                        button2.Content =prvnicislo * druhycislo;
                        celkem = prvnicislo * druhycislo;
                        break;
                    case "/":
                        button2.Content =prvnicislo / druhycislo;
                        celkem = prvnicislo / druhycislo;
                        break;
                    default:
                        button2.Content = "Něco random";
                        break;

                }
                button2.Content = celkem;
            }
            else if (buttony % 2 != 0)
            {
                int prvnibutton = 1;
                button2.Content = rnd.Next(1, 200);
                switch (operandy)
                {
                    case "+":
                        button.Content = prvnicislo + druhycislo;
                        celkem = prvnicislo + druhycislo;
                        break;
                    case "-":
                        button.Content = prvnicislo - druhycislo;
                        celkem = prvnicislo - druhycislo;
                        break;
                    case "*":
                        button.Content = prvnicislo * druhycislo;
                        celkem = prvnicislo * druhycislo;
                        break;
                    case "/":
                        button.Content =prvnicislo / druhycislo;
                        celkem = prvnicislo / druhycislo;
                        break;
                    default:
                        button.Content = "Něco random";
                        break;

                }
                button.Content = celkem;
            }
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            if (button.Content.ToString() == celkem.ToString())
            {
                ahoj();
                level++;

            }else
            {
                ahoj();
                zivoty--;
            }
                textBlock1.Text = celkem.ToString();
                textBlock4.Text = "Životy: " + zivoty.ToString();
                textBlock3.Text = "Úroveň: " + level.ToString();
        }
        private void Button_Click2(object sender, RoutedEventArgs e)
        {

            if (button2.Content.ToString() == celkem.ToString())
            {
                ahoj();
                level++;

            }
            else
            {
                ahoj();
                zivoty--;
            }
            textBlock1.Text = celkem.ToString();
            textBlock4.Text = "Životy: " + zivoty.ToString();
            textBlock3.Text = "Úroveň: " + level.ToString();
        }

    }
}
