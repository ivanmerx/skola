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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            textBlock.Text=String.Empty;
            button.Visibility = Visibility.Hidden;
            TextBlock dynamicTextBox = new TextBlock();
            dynamicTextBox.Text = "Type Partnumber";
            Grid.SetRow(dynamicTextBox, 0);
            Grid.SetColumn(dynamicTextBox, 0);
            this.MainGrid.Children.Add(dynamicTextBox);
        }
    }
}
