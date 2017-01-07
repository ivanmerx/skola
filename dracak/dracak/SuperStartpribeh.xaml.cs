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
    /// Interaction logic for SuperStartpribeh.xaml
    /// </summary>
    public partial class SuperStartpribeh : Page
    {
        public SuperStartpribeh()
        {
            InitializeComponent();
            App.hrac.vybaveni = new Mec();
            textBlock.Text = App.hrac.vybaveni.hodnotaUtoku.ToString();
        }
    }
}
