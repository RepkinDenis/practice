using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace App2
{
    public class AppRepository
    {
        SQLiteAsyncConnection database;

        public AppRepository(string databasePath)
        {
            database = new SQLiteAsyncConnection(databasePath);
        }

        public async Task CreateTable()
        {
            await database.CreateTableAsync<recommend>();
        }
        public async Task<List<recommend>> GetItemsAsync()
        {
            return await database.Table<recommend>().ToListAsync();

        }
        public async Task<recommend> GetItemAsync(int id)
        {
            return await database.GetAsync<recommend>(id);
        }
        public async Task<int> DeleteItemAsync(recommend item)
        {
            return await database.DeleteAsync(item);
        }
        public async Task<int> SaveItemAsync(recommend item)
        {
            if (item.recom_id != 0)
            {
                await database.UpdateAsync(item);
                return item.recom_id;
            }
            else
            {
                return await database.InsertAsync(item);
            }
        }
    }
}
