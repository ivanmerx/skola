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
        private string text1;
        private string texthlavni;
        private string nazevbuttonu;
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
        //Page nazev,string texthlavni, string text1,string nazevbuttonu
        public VytvorPage()
        {
            InitializeComponent();
            //this.nazevbuttonu= nazevbuttonu;
            //this.texthlavni = texthlavni;
            //nadpis.Text = texthlavni;
            //this.text1 = text1;
            //pribeh.Text = text1;
            //this.nazev = nazev;
            //button.Content = nazevbuttonu;
            this.Background = new ImageBrush(new BitmapImage(new Uri(@"pack://application:,,,/dracak;component/Obrazky/moriesecond.png")));
            image.Source = new BitmapImage(new Uri(@"pack://application:,,,/dracak;component/Obrazky/papir.jpg"));
            //FontFamily="pack://application:,,,/Fonty/#Morris Roman"
        }



        private void button_Click(object sender, RoutedEventArgs e)
        {
            App.Current.MainWindow.Content = presmerovani;
        }
    }
}
