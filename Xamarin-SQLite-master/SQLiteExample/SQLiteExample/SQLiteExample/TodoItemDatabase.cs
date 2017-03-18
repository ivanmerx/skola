using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SQLiteExample
{
  public  class TodoItemDatabase
    {
        private SQLiteAsyncConnection database;

        public TodoItemDatabase(string dbPath)
        {
            database = new SQLiteAsyncConnection(dbPath);
            database.CreateTableAsync<Osoba>().Wait();
        }


        public Task<List<Osoba>> GetItemsAsync()
        {
            return database.Table<Osoba>().ToListAsync();
        }

        public Task<List<Osoba>> GetItemsNotDoneAsync()
        {
            return database.QueryAsync<Osoba>("SELECT * FROM [TodoItem] WHERE [Done] = 0");
        }

        public Task<Osoba> GetItemAsync(int id)
        {
            return database.Table<Osoba>().Where(i => i.ID == id).FirstOrDefaultAsync();
        }

        public Task<int> SaveItemAsync(Osoba item)
        {
            if (item.ID != 0)
            {
                return database.UpdateAsync(item);
            }
            else
            {
                return database.InsertAsync(item);
            }
        }

        public Task<int> DeleteItemAsync(Osoba item)
        {
            return database.DeleteAsync(item);
        }
    }
}
