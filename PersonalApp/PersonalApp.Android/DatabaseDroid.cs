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
using PersonalApp.DataAccess;
using PersonalApp.Droid;
using System.IO;

[assembly: Xamarin.Forms.Dependency(typeof(DatabaseDroid))]
namespace PersonalApp.Droid
{
    public class DatabaseDroid : IConnection
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
                var path = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal),"moneylover.db3");
                return path;
            }
        }
    }
}