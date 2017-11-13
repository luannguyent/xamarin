using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace PersonalApp
{
    public class ItemsViewModel : BaseViewModel
    {
        public ObservableCollection<TransactionItem> Items { get; set; }
        public Command LoadItemsCommand { get; set; }

        public ItemsViewModel()
        {
            Title = "Browse";
            Items = new ObservableCollection<TransactionItem>();
            LoadItemsCommand = new Command(async () => await ExecuteLoadItemsCommand());

            MessagingCenter.Subscribe<NewItemPage, TransactionItem>(this, "AddItem", async (obj, item) =>
            {
                var _item = item as TransactionItem;
                Items.Add(_item);
                //await DataStore.AddItemAsync(_item);
            });
        }

        async Task ExecuteLoadItemsCommand()
        {
            if (IsBusy)
                return;

            IsBusy = true;

            try
            {
                Items.Clear();
                //var items = await DataStore.GetItemsAsync(true);
                //foreach (var item in items)
                //{
                //    Items.Add(item);
                //}
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                IsBusy = false;
            }
        }
    }
}
