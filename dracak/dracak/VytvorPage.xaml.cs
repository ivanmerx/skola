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
using dracak.Morie;
namespace dracak
{
    /// <summary>
    /// Interaction logic for VytvorPage.xaml
    /// </summary>

    public partial class VytvorPage : Page
    {
        private Page presmerovani;
        private Page presmerovani2;
        private string text1;
        private string texthlavni;
        private string nazevbuttonu;
        public string Text1
        {
            get
            {
                return text1;
            }
            set
            {
                text1 = value;
                pribeh.Text = text1;

            }
        }

        public Page Presmerovani
        {
            get
            {
                return presmerovani;
            }
            set
            {
                presmerovani = value;
            }
        }
        public Page Presmerovani2
        {
            get
            {
                return presmerovani2;
            }
            set
            {
                presmerovani2 = value;
            }
        }
        //Page nazev,string texthlavni, string text1,string nazevbuttonu

        public VytvorPage(string tlacitko1,string tlacitko2 = null) 
        {
            InitializeComponent();
            Button btn = new Button();
            btn.Content = tlacitko1;
            btn.Tag = 1;
            btn.Click += new RoutedEventHandler(button_Click);
            buttons.Children.Add(btn);
            if (tlacitko2 != null)
            {
                Button btn2 = new Button();
                btn2.Content = tlacitko2;
                btn2.Tag = 2;
                btn2.Click += new RoutedEventHandler(button_Click);
                Thickness margin = btn.Margin;
                margin.Left = 10;
                btn2.Margin = margin;
                buttons.Children.Add(btn2);
            }
            this.Background = new ImageBrush(new BitmapImage(new Uri(@"pack://application:,,,/dracak;component/Obrazky/moriesecond.png")));
            image.Source = new BitmapImage(new Uri(@"pack://application:,,,/dracak;component/Obrazky/papir.jpg"));
            //FontFamily="pack://application:,,,/Fonty/#Morris Roman"
        }



        private void button_Click(object sender, RoutedEventArgs e)
        {
            if (((Button)sender).Tag.ToString() == "1")
            {
                App.Current.MainWindow.Content = presmerovani;
            }
            else
            {
                App.Current.MainWindow.Content = presmerovani2;
            }
        }
    }
}
