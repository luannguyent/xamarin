using SQLite.Net.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace PersonalApp.Models
{
    public class TransactionType
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Name { get; set; }

        public string ParentType { get; set; }
    }
}
