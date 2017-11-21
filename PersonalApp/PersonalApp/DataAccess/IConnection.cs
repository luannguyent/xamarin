using SQLite.Net.Interop;
using System;
using System.Collections.Generic;
using System.Text;

namespace PersonalApp.DataAccess
{
    public interface IConnection
    {
        ISQLitePlatform SqlitePlatform { get; }
        string Folder { get; }
    }
}
