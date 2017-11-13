using System;

namespace PersonalApp
{
    public class ItemDetailViewModel : BaseViewModel
    {
        public TransactionItem Item { get; set; }
        public ItemDetailViewModel(TransactionItem item = null)
        {
            //Title = item?.Text;
            Item = item;
        }
    }
}
