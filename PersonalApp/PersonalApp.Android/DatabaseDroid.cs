using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using SQLite.Net.Interop;
using PersonalApp.LocalStorage;

namespace PersonalApp.Droid
{
    public class DatabaseDroid : IDatabase
    {
        public ISQLitePlatform SqlitePlatform
        {
            get
            {
                return new SQLite.Net.Platform.XamarinAndroid.SQLitePlatformAndroid();
            }
        }
        public string Folder
        {
            get
            {
                return System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            }
        }
    }
}