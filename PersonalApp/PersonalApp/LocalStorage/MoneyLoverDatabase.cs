using System;
using System.Collections.Generic;
using System.Text;
using SQLite.Net;
using SQLite.Net.Async;
using SQLite.Net.Interop;
using PersonalApp.Models;

namespace PersonalApp.LocalStorage
{
    public class MoneyLoverDatabase
    {
        readonly SQLiteAsyncConnection database;
        public MoneyLoverDatabase(string dbPath, ISQLitePlatform sqlitePlatform)
        {
            var connectionAsync = new Func<SQLiteConnectionWithLock>(() =>
                 new SQLiteConnectionWithLock
                     (
                         sqlitePlatform,
                         new SQLiteConnectionString(dbPath, false)
                     )
                 );
            database = new SQLiteAsyncConnection(connectionAsync);
            //Create table
            database.CreateTableAsync<TransactionItem>().Wait();
            database.CreateTableAsync<TransactionType>().Wait();
        }
    }
}
