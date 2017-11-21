using System;
using System.Collections.Generic;
using System.Text;
using SQLite.Net;
using SQLite.Net.Async;
using SQLite.Net.Interop;
using PersonalApp.Models;

namespace PersonalApp.DataAccess
{
    public class MoneyLoverConnection
    {
        readonly SQLiteAsyncConnection connection;
        public MoneyLoverConnection(string dbPath, ISQLitePlatform sqlitePlatform)
        {
            var connectionAsync = new Func<SQLiteConnectionWithLock>(() =>
                 new SQLiteConnectionWithLock
                     (
                         sqlitePlatform,
                         new SQLiteConnectionString(dbPath, false)
                     )
                 );
            connection = new SQLiteAsyncConnection(connectionAsync);

            //Create table
            connection.CreateTableAsync<TransactionItem>().Wait();
            connection.CreateTableAsync<TransactionType>().Wait();
        }

        public SQLiteAsyncConnection GetDatabaseInstance()
        {
            return connection;
        }
    }
}
