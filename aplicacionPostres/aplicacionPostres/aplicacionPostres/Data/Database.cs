using aplicacionPostres.Model;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace aplicacionPostres.Data
{
    public class Database
    {
        private readonly SQLiteAsyncConnection _database; //Conexión a la BD
        public Database(string dbPath)
        {
            //Creación de la tabla en la BD
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<Postres>();
        }
        //Métodos para la creación de un producto postre
        public Task<List<Postres>> GetPostresAsync()
        {
            return _database.Table<Postres>().ToListAsync();
        }
        public Task<int> SavePostreAsync(Postres postre)
        {
            return _database.InsertAsync(postre);
        }
        public Task<int> UpdatePostreAsync(Postres postre)
        {
            return _database.UpdateAsync(postre);
        }
        public Task<int> DeletePostreAsync(Postres postre)
        {
            return _database.DeleteAsync(postre);
        }
    }
}
