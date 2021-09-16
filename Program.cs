using System;
namespace ObjectOrientedPrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Stock Report with total value of each Stock and the total value of Stock");
            //Console.WriteLine("press 1 for add N stocks OR 2 for computePriceofEachCompany OR 3 for getTotalShareOfAllStocks");
            // int options = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number of stock Company is present");
            int NumOfStockCompany = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < NumOfStockCompany; i++)
            {
                StockInventoryManagementDetails.addStock();
            }
            StockInventoryManagementDetails.computePriceofEachCompany();
           StockInventoryManagementDetails.getTotalShareOfAllStocks();
        }
    }
}