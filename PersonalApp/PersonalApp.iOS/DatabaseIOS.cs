using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Foundation;
using UIKit;
using PersonalApp.DataAccess;
using SQLite.Net.Interop;

namespace PersonalApp.iOS
{
    public class DatabaseIOS : IConnection
    {
        public ISQLitePlatform SqlitePlatform
        {
            get
            {
                return new SQLite.Net.Platform.XamarinIOS.SQLitePlatformIOS();
            }
        }
        public string Folder
        {
            get
            {
                var docFolder = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
                return System.IO.Path.Combine(docFolder, "..", "Library");
            }
        }
    }
}