using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
namespace databaze_test_main
{
    public class Databaze
    {
        private SQLiteAsyncConnection database;

        public Databaze(string dbPath)
        {
            database = new SQLiteAsyncConnection(dbPath);
            database.CreateTableAsync<Pisnicka>().Wait();
        }

        // Query
        public Task<List<Pisnicka>> GetItemsAsync()
        {
            return database.Table<Pisnicka>().ToListAsync();
        }
        public Task<List<Pisnicka>> ZiskatPisnicku(int id)
        {
            return database.QueryAsync<Pisnicka>("SELECT * FROM [Pisnicka] WHERE ID = " + id);
        }
        public Task<int> UlozitPisnicku(Pisnicka item)
        {
            return database.UpdateAsync(item);
        }
        public Task<int> SmazatPisnicku(Pisnicka item)
        {
            return database.DeleteAsync(item);
        }
        public Task<int> VytvorPisnicku(Pisnicka item)
        {
            return database.InsertAsync(item);

        }
       
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        // Query using SQL query string
        public Task<List<Pisnicka>> GetItemsNotDoneAsync()
        {
            return database.QueryAsync<Pisnicka>("SELECT * FROM [Pisnicka]");
        }

        public Task<int> SaveItemAsync(Pisnicka item)
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
        public Task<int> DeleteItemAsync(Pisnicka item)
        {
            return database.DeleteAsync(item);
        }
    }
}
