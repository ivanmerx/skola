using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using SQLite.Entity;

namespace SQLite
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            /*
            TodoItem item = new TodoItem();
            item.Name = "item";
            item.Text = "item text";
            item.Done = 0;
            */
            Osoba osoba = new Osoba();
            osoba.Jmeno = "klobasa";
            osoba.Prijmeni = "lmao";
            //Database.SaveItemAsync(osoba);


            ///   var itemsFromDb = Database.GetItemsAsync().Result;
            var itemsFromDb = Database.GetItemsNotDoneAsync().Result;

            Debug.WriteLine(itemsFromDb.Count);
            foreach (Osoba todoItem in itemsFromDb)
            {
                Debug.WriteLine(todoItem);
            }



            ItemsCount.Content = "Items in Database " + itemsFromDb.Count;
            ToDoItemsListView.ItemsSource = itemsFromDb;
        }

        private static TodoItemDatabase _database;

        public static TodoItemDatabase Database
        {
            get
            {
                if (_database == null)
                {
                     var fileHelper = new FileHelper();
                    _database = new TodoItemDatabase(fileHelper.GetLocalFilePath("TodoSQLite.db3"));
                }
                return _database;
            }
        }

        //private void button_Click(object sender, RoutedEventArgs e)
        //{
        //    Osoba osoba = new Osoba();
        //    //osoba.Jmeno = textBox1.Text;
        //    Database.SaveItemAsync(osoba);

        //    ///   var itemsFromDb = Database.GetItemsAsync().Result;
        //    var itemsFromDb = Database.GetItemsNotDoneAsync().Result;

        //    Debug.WriteLine(itemsFromDb.Count);
        //    foreach (Osoba todoItem in itemsFromDb)
        //    {
        //        Debug.WriteLine(todoItem);
        //    }

        //    ItemsCount.Content = "Items in Database " + itemsFromDb.Count;
        //    ToDoItemsListView.ItemsSource = itemsFromDb;

        //}
        private void ToDoItemsListView_kliknuti(object sender, MouseButtonEventArgs e)
        {
            //NavigationService ns = NavigationService.GetNavigationService(this);
            //ns.Navigate(new Page1());
            string lol = label.Content.ToString();
            //MessageBox.Show(ToDoItemsListView.Items[0].SubItem[1].ToString());
            int lmao = (((ListView)sender).SelectedItem as Osoba).ID;
            //string kk = ((ListView)sender).Items[0].SubItem[2].ToString();
            _mainFrame.Navigate(new Page1(lmao));
            //object item = ToDoItemsListView.SelectedItem;
            //string ID = (ToDoItemsListView.SelectedItems[0] as TextBlock).Text;
            //MessageBox.Show(ID);

        }
    }
}
