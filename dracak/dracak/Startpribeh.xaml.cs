﻿using System;
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
    /// Interaction logic for Startpribeh.xaml
    /// </summary>
    public partial class Startpribeh : Page
    {
        public Startpribeh()
        {
            InitializeComponent();
            textBlock.Text = "Vítej válečníku " + App.hrac.Jmeno + "\nVybral jsi si rasu " + App.hrac.Rasa + "\nNyní si vyber výzbroj";
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            App.Current.MainWindow.Content = new SuperStartpribeh();
        }
    }
}
