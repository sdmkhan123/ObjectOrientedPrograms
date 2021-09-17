using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using System.IO;

namespace ObjectOrientedPrograms.StockAccountManagement
{
    public class Stock
    {
        //Read Json File 
        StockManagement manage = JsonConvert.DeserializeObject<StockManagement>(File.ReadAllText(@"F:\DotNetClass\ObjectOrientedPrograms\StockAccountManagement\StockDetails.json"));
        //Printing Stock Report
        public void Stock_Management()
        {
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("Dispaly the Stock Details");
            Console.WriteLine("******************************************************************************");
            foreach (StockManagement.StockRecord stock in manage.Stocks)
            {
                Console.WriteLine("Name of the stock :- " + stock.NameOfShare);
                Console.WriteLine("Total stocks of a company :- " + stock.NumberOfShare);
                Console.WriteLine("Stock Price :- " + stock.PriceOfShare + "\n");
            }
        }
        //Calculating each stock value
        public void CalculateEachStockValue()
        {
            double value = 0, price = 0;
            int numOfShare = 0;
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("Calculate each stock value");
            Console.WriteLine("******************************************************************************");
            for (int i = 0; i < manage.Stocks.Count; i++)
            {
                var jsonObject = manage.Stocks[i];
                price = jsonObject.PriceOfShare;
                numOfShare = jsonObject.NumberOfShare;
                value = price * numOfShare;
                Console.WriteLine("--> Value of the particular stock for " + jsonObject.NameOfShare + " is :- " + value);
            }
        }
        //Calculating total stock value
        public void CalculateTotalStockValue()
        {
            double value = 0, price = 0, totalValue = 0;
            int numOfShare = 0;
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("Calculate total stock value");
            Console.WriteLine("******************************************************************************");
            for (int i = 0; i < manage.Stocks.Count; i++)
            {
                var jsonObject = manage.Stocks[i];
                price = jsonObject.PriceOfShare;
                numOfShare = jsonObject.NumberOfShare;
                value = price * numOfShare;
                totalValue += value;
            }
            Console.WriteLine("==> Value of the Total stock is :- " + totalValue);
            Console.WriteLine("\n******************************************************************************");
        }
    }
}
