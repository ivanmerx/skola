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
using System.Windows.Shapes;

namespace WpfApplication1.Monstra
{
    /// <summary>
    /// Interakční logika pro MonsterOkno.xaml
    /// </summary>
    public partial class MonsterOkno : Window
    {
        public MonsterOkno()
        {
            Krokodyl krokodyl = new Krokodyl();
            Bojovnik bojovnik = new Bojovnik();
            bojovnik.typBoje = new UtokNohama();
            InitializeComponent();
            textBlock.Text = krokodyl.nazev;
            textBlock2.Text = bojovnik.name;
            textBlock3.Text = "Tvá hodnota útoku je" + bojovnik.typBoje.hodnotaSily;
            //if

            bojovnik.typBoje = new UtokNohama();
           // typBoje typ = new UtokNohama();
           /// typ.hodnotaSily;
        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            ProgressBar.Value--;
        }

        private void ProgressBar_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            ProgressBar2.Value--;
        }
    }
}
