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
            string textmorie1 = "Vypravěč: Nacházíš se v trpasličích dolech v Morii se společenstvem prstenu a nyní máš za úkol se probojovat ven z hory. Z temných chodeb Morie slyšíš zvuky skřetů. Přijde ti, že se skřeti přibližují";
            string textmorie2 = "Vypravěč: Vidíš jak za vámi běží skupinka skřetů, nyní máš na výběr běžet dál a snažit se jim utéct a nebo se jim postavíš čelem a pokusíš se je zničit.";
            string textmorie2_1 = "Vypravěč: Nyní vás skřeti zahnali do místnosti se zamčenými dveřmi, odraž zatím útok dvou skřetů, kteří se odvážili na vás zaútočit mezitím, co ostatní budou ničit dveře.";
            string textmorie3 = "Vypravěč: Výborně, porazil jsi skupinu skřetů!\nVypravěč: Už vidíš výlez z hory, ale v tom uslyšíš divné zvuky a pomalu ti dochází kdo to za tebou letí z hlubin hory.";
            string textmorie4 = "Vypravěč: Vidíš jak se začíná most pomalu bořit a tak rychle utíkáte ke konci.\nVypravěč: Most se zbořil, ale část ještě stále stojí, vidíš jak se před tebou objevilo mohutné stvoření zla z hory jménem Balrog!\nVypravěč: Hodláš s Balrogem bojovat, nebo se chceš pokusit utéct";
            string textmorie4_1 = "Vypravěč: Snažíš se utéct, most už pomalu končí a vidíš pomalu světlo z venku.\nVypravěč: Balrog tě svým mohutným bičem přitáhl zpátky a musíš se mu postavit čelem, jinak se ven z hory nedostaneš.";
            string textmorie5 = "Vypravěč: Výborně podařilo se ti porazit tuto nestvůru a tím jsi dokončil Epizodu 1 a nyní se můžeš vrhnout do druhé epizody kde se dostaneš do další z částí Pána Prstenů.";

            string textmordor1 = "Vypravěč: Výborně, podařilo se ti dosáhnout takové úrovně, že se můžeš pokusit zničit Prsten Moci!\nNejdříve se ale musíš dostat do hory Osudu";
            string textmordor2 = "Jsi před vstupem do hory Osudu,ale najednou ti do cesty vstoupil mohutný skřet! Poraď si s ním!";
            string textmordor3 = "Výborně porazil jsi skřeta!\nNyní vidíš jak kousek od tebe bojuje voják s pěti skřety, pomůžeš mu ?";
            string textmordor4_1 = "Voják si se skřety poradil, pokračuj dále do hory Osudu";
            string textmordor5 = "Nyní už vidíš jak Frodo stojí nerozhodně u kraje, který ho dělí od propasti s lávou. Neví jestli má prsten zničit, nebo si ho nechat.";
            string textmordor6_1 = "Zničil jsi prsten, výborně!";
            string textmordor6_2 = "Zabil jsi Froda a nyní s prstenem vládneš Středozemi!";

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

            VytvorPage mordor1 = pribehy.Pridat(new VytvorPage("Jít dál"));
            VytvorPage mordor2 = new VytvorPage("Bojovat");
            VytvorPage mordor3 = new VytvorPage("Pomoci mu","Jít dále");
            VytvorPage mordor4_1 = new VytvorPage("Pokračovat!");
            VytvorPage mordor5 = new VytvorPage("Zničit Prsten", "Ukrást Prsten");
            VytvorPage mordor6_1 = new VytvorPage("Konec");
            VytvorPage mordor6_2 = new VytvorPage("Konec");


            morie1.Text1 = textmorie1;
            morie2.Text1 = textmorie2;
            morie2_1.Text1 = textmorie2_1;
            morie3.Text1 = textmorie3;
            morie4.Text1 = textmorie4;
            morie4_1.Text1 = textmorie4_1;
            morie5.Text1 = textmorie5;

            mordor1.Text2 = "Epizoda 2\nMordor";
            mordor2.Text2 = "Epizoda 2\nMordor";
            mordor3.Text2 = "Epizoda 2\nMordor";
            mordor4_1.Text2 = "Epizoda 2\nMordor";
            mordor5.Text2 = "Epizoda 2\nMordor";
            mordor6_1.Text2 = "Epizoda 2\nMordor";
            mordor6_2.Text2 = App.hrac.Xp.ToString();
            mordor1.Text1 = textmordor1;
            mordor2.Text1 = textmordor2;
            mordor3.Text1 = textmordor3;
            mordor4_1.Text1 = textmordor4_1;
            mordor5.Text1 = textmordor5;
            mordor6_1.Text1 = textmordor6_1;
            mordor6_2.Text1 = textmordor6_2;

            morie1.Presmerovani = morie2;
            morie2.Presmerovani = morie2_1;
            morie2.Presmerovani2 = new VytvorBoj(new prisera("Skřet", new Pozemni()), morie3, "skret.jpg","moria.jpg");
            morie2_1.Presmerovani = new VytvorBoj(new prisera("Skřet", new Pozemni()), morie3, "skret.jpg", "moria.jpg");
            morie3.Presmerovani = morie4;
            morie4.Presmerovani = morie4_1;
            morie4.Presmerovani2 = new VytvorBoj(new prisera("Balrog", new Pozemni()), morie5, "balrog.jpg", "moria.jpg");
            morie4_1.Presmerovani = new VytvorBoj(new prisera("Balrog", new Pozemni()), morie5, "balrog.jpg", "moria.jpg");

            if(App.hrac.Xp >= 120)
            {
                morie5.Presmerovani = mordor1;
            }
            else
            {
                morie5.Presmerovani = new Rozcestnik();
            }

            mordor1.Presmerovani = mordor2;
            mordor2.Presmerovani = new VytvorBoj(new prisera("Mohutný skřet", new Pozemni()), mordor3, "skret.jpg", "mordor.jpg");
            mordor3.Presmerovani = new VytvorBoj(new prisera("Skřet", new Pozemni()), mordor4_1, "skret.jpg", "mordor.jpg");
            mordor3.Presmerovani2 = mordor4_1;
            mordor4_1.Presmerovani = mordor5;
            mordor5.Presmerovani = mordor6_1;
            mordor5.Presmerovani2 = mordor6_2;
            App.Current.MainWindow.Content = morie1;
        }
    }
}
