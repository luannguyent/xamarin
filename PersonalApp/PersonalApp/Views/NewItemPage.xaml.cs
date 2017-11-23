using PersonalApp.Helpers;
using PersonalApp.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using Xamarin.Forms;

namespace PersonalApp
{
    public partial class NewItemPage : ContentPage
    {
        public TransactionItem TransactionItem { get; set; }
        public ObservableCollection<TransactionType> TransactionTypes { get; set; }
        public NewItemPage()
        {
            InitializeComponent();
            InitializeData();
            BindingContext = this;
        }

        public void InitializeData()
        {
            try
            {
                //Load Transaction Type
                var transactionTypes = DataBaseHelper.Connection.Table<TransactionType>().ToListAsync().Result;
                TransactionTypes = new ObservableCollection<TransactionType>(transactionTypes);

                //Set default data
                TransactionItem = new TransactionItem
                {
                    Amount = 0.0,
                    Description = "This is an item description."
                };
            }
            catch(Exception ex)
            {
                Debug.WriteLine(ex);
            }
        }

        async void Save_Clicked(object sender, EventArgs e)
        {
            MessagingCenter.Send(this, "AddItem", TransactionItem);
            await Navigation.PopToRootAsync();
        }
    }
}
