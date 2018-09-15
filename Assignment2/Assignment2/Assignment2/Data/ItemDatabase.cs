using Assignment2.Models;
using SQLite;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;

namespace Assignment2.Data
{
    public class ItemDatabase
    {
        static object locker = new object();
        SQLiteConnection database;
        
        public ItemDatabase()
        {
            database = DependencyService.Get<ISQLite>().GetConnection();
            // create the tables
            database.CreateTable<Item>();
        }

        public IEnumerable<Item> GetItems()
        {
            lock (locker)
            {
                return (from i in database.Table<Item>() select i).ToList();
            }
        }

        public IEnumerable<Item> GetItemsNotDone()
        {
            lock (locker)
            {
                return database.Query<Item>("SELECT * FROM [TodoItem] WHERE [Done] = 0");
            }
        }

        public Item GetItem(int id)
        {
            lock (locker)
            {
                return database.Table<Item>().FirstOrDefault(x => x.Id == id);
            }
        }

        public int SaveItem(Item item)
        {
            lock (locker)
            {
                if (item.Id != 0)
                {
                    database.Update(item);
                    return item.Id;
                }
                else
                {
                    return database.Insert(item);
                }
            }
        }

        public int DeleteItem(int id)
        {
            lock (locker)
            {
                return database.Delete<Item>(id);
            }
        }
    }
}
