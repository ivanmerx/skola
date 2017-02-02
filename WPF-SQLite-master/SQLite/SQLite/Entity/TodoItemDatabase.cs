using System.Collections.Generic;
using System.Threading.Tasks;

namespace SQLite.Entity
{
    public class TodoItemDatabase
    {
        // SQLite connection
        private SQLiteAsyncConnection database;

        public TodoItemDatabase(string dbPath)
        {
            database = new SQLiteAsyncConnection(dbPath);
            database.CreateTableAsync<Osoba>().Wait();        
        }

        // Query
        public Task<List<Osoba>> GetItemsAsync()
        {
            return database.Table<Osoba>().ToListAsync();
        }

        // Query using SQL query string
        public Task<List<Osoba>> GetItemsNotDoneAsync()
        {
            return database.QueryAsync<Osoba>("SELECT * FROM [Osoba]");
        }
        /*
        // Query using LINQ
        public Task<TodoItem> GetItemAsync(int id)
        {
            return database.Table<TodoItem>().Where(i => i.ID == id).FirstOrDefaultAsync();
        }
        */
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
