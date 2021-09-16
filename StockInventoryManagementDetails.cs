using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedPrograms
{
    public class StockInventoryManagementDetails
    {
        public static List<Stock> stockListDetail = new List<Stock>();
        public static Dictionary<string, Stock> stockMapDetail = new Dictionary<string, Stock>();
        public static int totalPriceOfAllSharres = 0;
        public static void addStock()
        {
            Console.WriteLine("Enter the share Name of stock company ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter the price of each share of the stock company");
            int price = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the nummber of share of the stock company");
            int nummber = Convert.ToInt32(Console.ReadLine());
            if(!stockMapDetail.ContainsKey(name))
            {
                stockListDetail.Add(new Stock() {
                    shareName = name,
                    sharePrice = price,
                    numberOfShares = nummber,
                    totalAmountOfCompanyShare = nummber * price
                });
                stockMapDetail.Add(name, new Stock()
                {
                    sharePrice = price,
                    shareName = name,
                    numberOfShares = nummber,
                    totalAmountOfCompanyShare = nummber * price
                });
                totalPriceOfAllSharres += nummber * price;
            }
        }
        public static void computePriceofEachCompany()
        {
            for (int i= 0; i <stockListDetail.Count; i++)
            {
                Console.WriteLine("total share of stock company " + stockListDetail[i].shareName + " is " + stockListDetail[i].totalAmountOfCompanyShare);
            }
        }
        public static void getTotalShareOfAllStocks()
        {
            Console.WriteLine("total shrre price of all stock company is " + totalPriceOfAllSharres);
        }
    }
}
