using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using SQLitePCL;

namespace Databaze_Full
{
    public class Databaze
    {
        // SQLite connection
        private SQLiteAsyncConnection database;

        public Databaze(string dbPath)
        {
            database = new SQLiteAsyncConnection(dbPath);
            database.CreateTableAsync<Osoba>().Wait();
        }

        // Query
        public Task<List<Osoba>> GetItemsAsync()
        {
            return database.Table<Osoba>().ToListAsync();
        }
        public Task<List<Osoba>> ZiskatUzivatele(int id)
        {
            return database.QueryAsync<Osoba>("SELECT * FROM [Osoba] WHERE ID = " + id);
        }
        public Task<int> UlozitUzivatele(Osoba item)
        {
            return database.UpdateAsync(item);
        }
        // Query using SQL query string
        public Task<List<Osoba>> GetItemsNotDoneAsync()
        {
            return database.QueryAsync<Osoba>("SELECT * FROM [Osoba]");
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
