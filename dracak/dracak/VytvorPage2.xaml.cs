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
    /// Interaction logic for VytvorPage2.xaml
    /// </summary>
    public partial class VytvorPage2 : Page
    {
        private Page presmerovani;
        private Page presmerovani2;
        private string text1;
        private string texthlavni;
        private string nazevbuttonu;
        private string nazevbuttonu2;
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
        public VytvorPage2()
        {
            InitializeComponent();
            //this.nazevbuttonu2 = nazevbuttonu2;
            //button1.Content = nazevbuttonu2;
            //this.nazevbuttonu = nazevbuttonu;
            //this.nazev2 = nazev2;
            //this.texthlavni = texthlavni;
            //nadpis.Text = texthlavni;
            //this.text1 = text1;
            //pribeh.Text = text1;
            //this.nazev1 = nazev;
            //button.Content = nazevbuttonu;
            this.Background = new ImageBrush(new BitmapImage(new Uri(@"pack://application:,,,/dracak;component/Obrazky/moriesecond.png")));
            image.Source = new BitmapImage(new Uri(@"pack://application:,,,/dracak;component/Obrazky/papir.jpg"));
        }
        private void button_Click(object sender, RoutedEventArgs e)
        {
            App.Current.MainWindow.Content = presmerovani;
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            App.Current.MainWindow.Content = presmerovani2;
        }
    }
}
