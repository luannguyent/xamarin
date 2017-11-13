using SQLite.Net.Interop;
using System;
using System.Collections.Generic;
using System.Text;

namespace PersonalApp.LocalStorage
{
    public class IDatabase
    {
        ISQLitePlatform SqlitePlatform { get; }
        string Folder { get; }
    }
}
