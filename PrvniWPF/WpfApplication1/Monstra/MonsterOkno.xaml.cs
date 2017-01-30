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
        Bojovnik bojovnik = new Bojovnik();
        public MonsterOkno()
        {
            Krokodyl krokodyl = new Krokodyl();
            bojovnik.typBoje = new UtokPestmi();
            InitializeComponent();
            textBlock.Text = krokodyl.nazev;
            textBlock2.Text = bojovnik.name;
            textBlock3.Text = "Hodnota útoku je " + bojovnik.typBoje.hodnotaSily;
            //if
            if(ProgressBar.Value < 50)
            {
                bojovnik.typBoje = new UtokNohama();
                int promenna = bojovnik.typBoje.hodnotaSily;
            }

           // typBoje typ = new UtokNohama();
           /// typ.hodnotaSily;
        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            //ProgressBar2.Value--;
            int promenna = bojovnik.typBoje.hodnotaSily;
            ProgressBar.Value= ProgressBar2.Value - promenna;
            textBlock3.Text = "Hodnota útoku je " + bojovnik.typBoje.hodnotaSily;
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
