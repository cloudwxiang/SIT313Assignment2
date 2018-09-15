using Assignment2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.Data
{
    public class BookDataStore : MDataStore<Item>
    {
        List<Item> items;

        public BookDataStore()
        {
            items = new List<Item>();
            var mockItems = new List<Item>
            {
                new Item { Id = 1, Text = "Harry Potter", Description="This is a series of fantasy novels written by British author J. K. Rowling. " },
                new Item { Id = 2, Text = "Tuesdays with Morrie", Description="This is a memoir[1] by American writer Mitch Albom" },
                new Item { Id = 3, Text = "Sweetbitter", Description="This is an American drama television series, based on the novel of the same name by Stephanie Danler。" },
                new Item { Id = 4, Text = "Lord of the flies", Description="This is a 1954 novel by Nobel Prize–winning British author William Golding." },
                new Item { Id = 5, Text = "The Fault in Our Stars", Description="Published in January 2012, is the sixth novel by author John Green. " },
                new Item { Id = 6, Text = "To Kill a Mockingbird", Description="This is a novel by Harper Lee published in 1960. " },
                new Item { Id = 7, Text = "The Lord of the Rings ", Description="This is an epic high fantasy novel written by English author and scholar J. R. R. Tolkien. " },
                new Item { Id = 8, Text = "The Diary Of A Young Girl", Description=" also known as The Diary of Anne Frank, is a book of the writings from the Dutch language diary kept by Anne Frank while she was in hiding for two years with her family during the Nazi occupation of the Netherlands. " },
            };

            foreach (var item in mockItems)
            {
                items.Add(item);
            }
        }

        public async Task<bool> AddItemAsync(Item item)
        {
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateItemAsync(Item item)
        {
            var oldItem = items.Where((Item arg) => arg.Id == item.Id).FirstOrDefault();
            items.Remove(oldItem);
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteItemAsync(int id)
        {
            var oldItem = items.Where((Item arg) => arg.Id == id).FirstOrDefault();
            items.Remove(oldItem);

            return await Task.FromResult(true);
        }

        public async Task<Item> GetItemAsync(int id)
        {
            return await Task.FromResult(items.FirstOrDefault(s => s.Id == id));
        }

        public async Task<IEnumerable<Item>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(items);
        }
    }
}
