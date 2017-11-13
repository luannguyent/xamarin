using SQLite.Net.Attributes;
using System;

namespace PersonalApp
{
    public class TransactionItem
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Description { get; set; }

        public double Amount { get; set; }

        public int TransactionTypeId { get; set; }

        public DateTime TransactionDate { get; set; }
    }
}
