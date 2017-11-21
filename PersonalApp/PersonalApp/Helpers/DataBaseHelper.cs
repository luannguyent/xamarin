using PersonalApp.DataAccess;
using SQLite.Net.Async;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace PersonalApp.Helpers
{
    public static class DataBaseHelper
    {
        private static SQLiteAsyncConnection _connection;
        public static SQLiteAsyncConnection Connection
        {
            get
            {
                if (_connection == null)
                {
                    IConnection connection = DependencyService.Get<IConnection>();
                    _connection = new MoneyLoverConnection(connection.Folder, connection.SqlitePlatform).GetDatabaseInstance();
                }
                return _connection;
            }
        }
    }
}
