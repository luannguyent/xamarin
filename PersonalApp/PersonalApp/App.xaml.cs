using System;
using PersonalApp.Helpers;
using Xamarin.Forms;
using System.Collections.Generic;
using PersonalApp.Models;

namespace PersonalApp
{
    public partial class App : Application
    {
        public string IsFirstTime
        {
            get { return Settings.GeneralSettings; }
            set
            {
                if (Settings.GeneralSettings == value)
                    return;
                Settings.GeneralSettings = value;
                OnPropertyChanged();
            }
        }
        public App()
        {
            InitializeComponent();
            if(IsFirstTime == "yes")
            {
                List<TransactionType> transactionTypes = new List<TransactionType>()
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
                DataBaseHelper.Connection.InsertAllAsync(transactionTypes);
                IsFirstTime = "no";
            }
            if (Device.RuntimePlatform == Device.iOS)
                MainPage = new MainPage();
            else
                MainPage = new NavigationPage(new MainPage());
        }
    }
}