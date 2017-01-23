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

namespace dracak.Morie
{
    /// <summary>
    /// Interaction logic for Morie2_1.xaml
    /// </summary>
    public partial class Morie2_1 : Page
    {
        public Morie2_1()
        {
            InitializeComponent();
            this.Background = new ImageBrush(new BitmapImage(new Uri(@"http://vignette1.wikia.nocookie.net/lotr/images/2/2e/Durin's_door.png/revision/latest?cb=20140113142736")));
        }
    }
}
