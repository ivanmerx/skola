using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Layouts.Views
{
    public partial class Page3 : ContentPage
    {
        public Page3()
        {
            InitializeComponent();
            List<Osoba> ListMain = new List<Osoba>();
            ListMain.Add(new Osoba("Jakub", "Březina", 68, 608450845));
            ListMain.Add(new Osoba("David", "Šourek", 15, 123456789));
            ListMain.Add(new Osoba("Standa", "Hulín", 69, 123456789));

            list2.ItemsSource = ListMain;

        }
        private void item(object sender, ItemTappedEventArgs e)
        {
            Navigation.PushAsync(new InfoOsoby(e.Item as Osoba));
        }
    }
}
