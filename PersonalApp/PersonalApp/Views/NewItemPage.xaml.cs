using PersonalApp.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
            TransactionTypes = new ObservableCollection<TransactionType>()
            {
                new TransactionType()
                {
                    Id = 1,
                    Name = "Food And Drink"
                },
                new TransactionType()
                {
                    Id = 2,
                    Name = "Payment"
                },
                new TransactionType()
                {
                    Id = 3,
                    Name = "Shopping"
                },
                new TransactionType()
                {
                    Id = 4,
                    Name = "Transport"
                },
                new TransactionType()
                {
                    Id = 5,
                    Name = "Salary"
                }
            };
            TransactionItem = new TransactionItem
            {
                Amount = 0.0,
                Description = "This is an item description."
            };

            BindingContext = this;
        }

        async void Save_Clicked(object sender, EventArgs e)
        {
            MessagingCenter.Send(this, "AddItem", TransactionItem);
            await Navigation.PopToRootAsync();
        }
    }
}
