using ProjetSecourisme.Models;
using SQLite;


namespace ProjetSecourisme.Data
{
    public class Database
    {
        private SQLiteAsyncConnection connection;

        public Database()
        {

        }

        private async Task Initialize()
        {
            if (connection is not null)
                return;

            connection = new(Constants.DatabasePath);

            await connection.CreateTableAsync<Login>();
         //   await connection.CreateTableAsync<SignupS>();

        }

        //public async Task<List<SignupS>> GetUserAsync()
        //{
        //    await Initialize();
        //    return await connection.Table<SignupS>().ToListAsync();

        //}
        public async Task<List<Login>> GetItemsAsync()
        {
            await Initialize();
            return await connection.Table<Login>().ToListAsync();

        }

        public async Task<int> SaveItemAsync(Login item)
        {
            await Initialize();

            if (item.Id != 0)
            {
                return await connection.UpdateAsync(item);
            }
            else
            {
                return await connection.InsertAsync(item);
            }
        }
        //public async Task<int> SaveUserAsync(SignupS item)
        //{
        //    await Initialize();

        //    if (item.Id_S != 0)
        //    {
        //        return await connection.UpdateAsync(item);
        //    }
        //    else
        //    {
        //        return await connection.InsertAsync(item);
        //    }
        //}

        public async Task<int> DeleteItemAsync(Login item)
        {
            await Initialize();
            return await connection.DeleteAsync(item);
        }

    }
}
