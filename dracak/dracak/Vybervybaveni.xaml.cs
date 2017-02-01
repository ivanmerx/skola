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
    /// Interaction logic for Startpribeh.xaml
    /// </summary>
    public partial class Vybervybaveni : Page
    {
        public Vybervybaveni()
        {
            InitializeComponent();
            textBlock.Text = "Vítej válečníku " + App.hrac.Jmeno + "\nVybral jsi si rasu " + App.hrac.Rasa + "\nNyní si vyber výzbroj";
            image1.Source = new BitmapImage(new Uri(@"pack://application:,,,/dracak;component/Obrazky/mec.jpg"));
            image2.Source = new BitmapImage(new Uri(@"pack://application:,,,/dracak;component/Obrazky/sekera.jpg"));
            image.Source = new BitmapImage(new Uri(@"pack://application:,,,/dracak;component/Obrazky/hul.jpg"));
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            string content = (sender as Button).Content.ToString();
            if (content == "Mec")
            {
                App.hrac.vybaveni = new Mec();
            }
            else if(content == "Sekera")
            {
                App.hrac.vybaveni = new Sekyra();
            }
            else if(content == "Hul")
            {
                App.hrac.vybaveni = new Hul();
            }
            string textmorie1 = "Vypraveč: Nacházíš se v trpasličích dolech v Morii se společenstvem prstenu a nyní máš za úkol se probojovat ven z hory.Vypravěč: Vidíš jak za vámi běží skupinka skřetů, nyní máš na výběr běžet dál a snažit se jim utéct a nebo se jim postavíš čelem a pokusíš se je zničit.";
            string textmorie2_1 = "Vypravěč: Nyní vás skřeti zahnali do místnosti se zamčenými dveřmi, odraž zatím útok dvou skřetů, kteří se odvážili na vás zaútočit mezitím, co ostatní budou ničit dveře.";
            string textmorie3 = "Vypravěč: Výborně, porazil jsi skupinu skřetů!\nVypravěč: Už vidíš výlez z hory, ale v tom uslyšíš divné zvuky a pomalu ti dochází kdo to za tebou letí z hlubin hory.";
            string textmorie4 = "Vypraveč: Vidíš jak se začíná most pomalu bořit a tak rychle utíkáte ke konci.\nVypravěč: Most se zbořil, ale část ještě stále stojí, vidíš jak se před tebou objevilo mohutné stvoření zla z hory jménem Balrog!\nVypravěč: Hodláš s Balrogem bojovat, nebo se chceš pokusit utéct";
            //App.Current.MainWindow.Content = new VytvorPage2(new VytvorPage(new Page(), "Epizoda 1\nMorie", textmorie2_1, "Zničit je!"), new VytvorBoj(new prisera("skret", new Pozemni()), new VytvorPage(new VytvorPage2(new Page(),new Page(),"Epizoda 1\nMorie",textmorie4,"Utéci","Bojovat"),"Epizoda 1\nMorie",textmorie3,"Rychle běžet přes most")), "Epizoda 1\nMorie", textmorie1, "Utéci", "Bojovat");

            Pribeh pribehy = new Pribeh();

            VytvorPage pribeh = pribehy.Pridat(new VytvorPage());
            pribeh.Text1 = "klobasa";

            VytvorPage2 pribeh2 = new VytvorPage2();
            pribeh2 = new VytvorPage2();
            pribeh2.Text1 = "lol";

            pribeh.Presmerovani = pribeh2;

            VytvorPage2 pribeh3 = new VytvorPage2();
            pribeh3 = new VytvorPage2();
            pribeh3.Text1 = "lol2";
            pribeh2.Presmerovani = pribeh3;
            pribeh2.Presmerovani2 = new Page();

            App.Current.MainWindow.Content = pribeh;
        }
    }
}
