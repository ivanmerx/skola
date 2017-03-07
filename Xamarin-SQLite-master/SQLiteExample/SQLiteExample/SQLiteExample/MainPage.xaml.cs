using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace SQLiteExample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            var dbConnection = App.Database;

            TodoItemDatabase todoItemDatabase = App.Database;
            Osoba item = new Osoba();
            item.Jmeno = "item";
            item.Prijmeni = "item text";
            App.Database.SaveItemAsync(item);


            var itemsFromDb = App.Database.GetItemsAsync().Result;
            
            Debug.WriteLine("                             ");
            Debug.WriteLine("                             ");
            Debug.WriteLine("                             ");

            Debug.WriteLine(itemsFromDb.Count);
            foreach (Osoba todoItem in itemsFromDb)
            {
                Debug.WriteLine(  todoItem );
            }

            Debug.WriteLine("                             ");
            Debug.WriteLine("                             ");
            Debug.WriteLine("                             ");


            //ItemsCount.Text = "Items in Database " + itemsFromDb.Count;
            //ToDoItemsListView.ItemsSource = itemsFromDb;

        }
        public void ButtonClick(Object sender, EventArgs e)
        {

        }
    }
}
