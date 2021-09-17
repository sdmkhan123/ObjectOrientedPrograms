using ObjectOrientedPrograms.InventoryDetails;
using ObjectOrientedPrograms.InventoryManagementDetails;
using ObjectOrientedPrograms.StockAccountManagement;
using System;
using Newtonsoft.Json;
using System.IO;

namespace ObjectOrientedPrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcom to Object Oriented Programs");
            Console.WriteLine("*****************************************************************************");
            while (true)
            {
                Console.WriteLine("Choose An Option to Perform an Action :");
                Console.WriteLine("Press 1 : Json Inventory\nPress 2 : Json Inventory Management Details\nPress 3 : Stock Account Management\nPress 4 : Exit");
                Console.WriteLine("*****************************************************************************");
                int userOption = int.Parse(Console.ReadLine());
                switch (userOption)
                {
                    case 1:
                        Console.WriteLine("Display Json Inventory Details");
                        InventoryData obj = new InventoryData();
                        obj.Data();
                        break;
                    case 2:
                        Console.WriteLine("Display Json Inventory Management");
                        InventoryDatas a = new InventoryDatas();
                        a.Data();
                        break;
                    case 3:
                        Console.WriteLine("Display Stock Management\n");
                        Stock b = new Stock();
                        b.Stock_Management();
                        b.CalculateEachStockValue();
                        b.CalculateTotalStockValue();
                        break;
                    case 4:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Please Enter a valid Options:");
                        break;
                }
            }
        }
    }
}