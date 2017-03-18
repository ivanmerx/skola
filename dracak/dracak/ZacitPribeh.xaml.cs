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
    /// Interakční logika pro ZacitPribeh.xaml
    /// </summary>
    public partial class ZacitPribeh : Page
    {
        public ZacitPribeh()
        {
            InitializeComponent();
            string textmorie1 = "Vypraveč: Nacházíš se v trpasličích dolech v Morii se společenstvem prstenu a nyní máš za úkol se probojovat ven z hory. Z temných chodeb Morie slyšíš zvuky skřetů. Přijde ti, že se skřeti přibližují";
            string textmorie2 = "Vypravěč: Vidíš jak za vámi běží skupinka skřetů, nyní máš na výběr běžet dál a snažit se jim utéct a nebo se jim postavíš čelem a pokusíš se je zničit.";
            string textmorie2_1 = "Vypravěč: Nyní vás skřeti zahnali do místnosti se zamčenými dveřmi, odraž zatím útok dvou skřetů, kteří se odvážili na vás zaútočit mezitím, co ostatní budou ničit dveře.";
            string textmorie3 = "Vypravěč: Výborně, porazil jsi skupinu skřetů!\nVypravěč: Už vidíš výlez z hory, ale v tom uslyšíš divné zvuky a pomalu ti dochází kdo to za tebou letí z hlubin hory.";
            string textmorie4 = "Vypraveč: Vidíš jak se začíná most pomalu bořit a tak rychle utíkáte ke konci.\nVypravěč: Most se zbořil, ale část ještě stále stojí, vidíš jak se před tebou objevilo mohutné stvoření zla z hory jménem Balrog!\nVypravěč: Hodláš s Balrogem bojovat, nebo se chceš pokusit utéct";
            string textmorie4_1 = "Vypraveč: Snažíš se utéct, most už pomalu končí a vidíš pomalu světlo z venku.\nVypravěč: Balrog tě svým mohutným bičem přitáhl zpátky a musíš se mu postavit čelem, jinak se ven z hory nedostaneš.";
            string textmorie5 = "Vypraveč: Výborně podařilo se ti porazit tuto nestvůru a tím jsi dokončil Epizodu 1 a nyní se můžeš vrhnout do druhé epizody kde se dostaneš do další z částí Pána Prstenů.";


            //App.Current.MainWindow.Content = new VytvorPage2(new VytvorPage(new Page(), "Epizoda 1\nMorie", textmorie2_1, "Zničit je!"), new VytvorBoj(new prisera("skret", new Pozemni()), new VytvorPage(new VytvorPage2(new Page(),new Page(),"Epizoda 1\nMorie",textmorie4,"Utéci","Bojovat"),"Epizoda 1\nMorie",textmorie3,"Rychle běžet přes most")), "Epizoda 1\nMorie", textmorie1, "Utéci", "Bojovat");

            Pribeh pribehy = new Pribeh();
            //VytvorPage pribeh2 = new VytvorPage();
            //pribeh2.Text1 = "lmao";
            VytvorPage morie1 = pribehy.Pridat(new VytvorPage("Jít dál"));
            VytvorPage morie2 = new VytvorPage("Utéci", "Bojovat");
            VytvorPage morie2_1 = new VytvorPage("Zničit je");
            VytvorPage morie3 = new VytvorPage("Rychle běžet přes most!");
            VytvorPage morie4 = new VytvorPage("Utéci", "Bojovat");
            VytvorPage morie4_1 = new VytvorPage("Bojovat!");
            VytvorPage morie5 = new VytvorPage("Pokračovat");


            morie1.Text1 = textmorie1;
            morie2.Text1 = textmorie2;
            morie2_1.Text1 = textmorie2_1;
            morie3.Text1 = textmorie3;
            morie4.Text1 = textmorie4;
            morie4_1.Text1 = textmorie4_1;
            morie5.Text1 = textmorie5;

            morie1.Presmerovani = morie2;
            morie2.Presmerovani = morie2_1;
            morie2.Presmerovani2 = new VytvorBoj(new prisera("skret", new Pozemni()), morie3);
            morie2_1.Presmerovani = new VytvorBoj(new prisera("skret", new Pozemni()), morie3);
            morie3.Presmerovani = morie4;
            morie4.Presmerovani = morie4_1;
            morie4.Presmerovani2 = new VytvorBoj(new prisera("skret", new Pozemni()), morie5);
            morie4_1.Presmerovani = new VytvorBoj(new prisera("skret", new Pozemni()), morie5);
            App.Current.MainWindow.Content = morie1;
        }
    }
}
