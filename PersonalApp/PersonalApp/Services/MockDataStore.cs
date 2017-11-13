using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//[assembly:Xamarin.Forms.Dependency(typeof(PersonalApp.MockDataStore))]
namespace PersonalApp
{
    //public class MockDataStore : IDataStore<TransactionItem>
    //{
    //    List<TransactionItem> items;

    //    public MockDataStore()
    //    {
    //        items = new List<TransactionItem>();
    //        var mockItems = new List<TransactionItem>
    //        {
    //            new TransactionItem { Id = 1, Description="This is an item description." },
    //            new TransactionItem { Id = 1, Description="This is an item description." },
    //            new TransactionItem { Id = 1, Description="This is an item description." },
    //            new TransactionItem { Id = 1, Description="This is an item description." },
    //            new TransactionItem { Id = 1, Description="This is an item description." },
    //            new TransactionItem { Id = 1, Description="This is an item description." },
    //        };

    //        foreach (var item in mockItems)
    //        {
    //            items.Add(item);
    //        }
    //    }

    //    public async Task<bool> AddItemAsync(TransactionItem item)
    //    {
    //        items.Add(item);

    //        return await Task.FromResult(true);
    //    }

    //    public async Task<bool> UpdateItemAsync(TransactionItem item)
    //    {
    //        var _item = items.Where((TransactionItem arg) => arg.Id == item.Id).FirstOrDefault();
    //        items.Remove(_item);
    //        items.Add(item);

    //        return await Task.FromResult(true);
    //    }

    //    public async Task<bool> DeleteItemAsync(string id)
    //    {
    //        var _item = items.Where((TransactionItem arg) => arg.Id == id).FirstOrDefault();
    //        items.Remove(_item);

    //        return await Task.FromResult(true);
    //    }

    //    public async Task<TransactionItem> GetItemAsync(string id)
    //    {
    //        return await Task.FromResult(items.FirstOrDefault(s => s.Id == id));
    //    }

    //    public async Task<IEnumerable<TransactionItem>> GetItemsAsync(bool forceRefresh = false)
    //    {
    //        return await Task.FromResult(items);
    //    }
    //}
}
