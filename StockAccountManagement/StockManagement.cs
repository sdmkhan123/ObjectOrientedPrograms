using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using System.IO;

namespace ObjectOrientedPrograms.StockAccountManagement
{
    public class StockManagement
    {
        //List is Holding the value of Stocks
        public List<StockRecord> Stocks { get; set; }
        public class StockRecord
        {
            public string NameOfShare { get; set; }
            public int NumberOfShare { get; set; }
            public int PriceOfShare { get; set; }
            //Parameterized Constructor
            public StockRecord(string Name, int Numbers, int Price)
            {
                this.NameOfShare = Name;
                this.NumberOfShare = Numbers;
                this.PriceOfShare = Price;
            }
        }
    }
}