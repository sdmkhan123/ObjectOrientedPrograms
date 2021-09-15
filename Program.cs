using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.IO;
namespace ObjectOrientedPrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WelCome to Object Oriented Programs");
            List<InventoryDetails> ListDetails = new List<InventoryDetails>();
            int inventoryGrandTotal = 0;
            Console.WriteLine("Number of Inventory ");
            int iteration = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < iteration; i++)
            {
                Console.WriteLine("Press 1 for Rice OR press 2 for Pulse OR press 3 for Wheats");
                int options = Convert.ToInt32(Console.ReadLine());
                switch (options)
                {
                    case 1:
                        Console.WriteLine("Enter the name of rice");
                        string riceName = Console.ReadLine();
                        Console.WriteLine("Enter the weight of rice");
                        int riceWeight = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the price of rice per kg");
                        int ricePrice = Convert.ToInt32(Console.ReadLine());
                        ListDetails.Add(new InventoryDetails()
                        {
                            name = riceName,
                            weight = riceWeight,
                            pricePerKg = ricePrice,
                            totalPriceOfRice = riceWeight * ricePrice
                        });
                        inventoryGrandTotal += riceWeight * ricePrice;
                        break;
                    case 2:
                        Console.WriteLine("Enter the name of Pulse");
                        string pulseName = Console.ReadLine();
                        Console.WriteLine("Enter the weight of Pulse");
                        int pulseWeight = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the price of Pulse per kg");
                        int pulsePrice = Convert.ToInt32(Console.ReadLine());
                        ListDetails.Add(new InventoryDetails()
                        {
                            name = pulseName,
                            weight = pulseWeight,
                            pricePerKg = pulsePrice,
                            totalPriceOfPulse = pulseWeight * pulsePrice
                        });
                        inventoryGrandTotal += pulseWeight * pulsePrice;
                        break;
                    case 3:
                        Console.WriteLine("Enter the name of wheats");
                        string wheatsmName = Console.ReadLine();
                        Console.WriteLine("Enter the weight of wheats");
                        int wheatsWeight = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the price of wheats per kg");
                        int wheatsPrice = Convert.ToInt32(Console.ReadLine());
                        ListDetails.Add(new InventoryDetails()
                        {
                            name = wheatsmName,
                            weight = wheatsWeight,
                            pricePerKg = wheatsPrice,
                            totalPriceOfWheats = wheatsWeight * wheatsPrice
                        });
                        break;
                        inventoryGrandTotal += wheatsWeight * wheatsPrice;
                    default:
                        Console.WriteLine("choose another option");
                        break;
                }
            }
            //List<InventoryDetails>[] listDetails = new List<InventoryDetails>[] { riceListDetails, pulseListDetails, wheatsListDetails };
            string inventoryResultJason = JsonConvert.SerializeObject(ListDetails);
            Console.WriteLine(inventoryResultJason);
            File.WriteAllText(@"inventoryJason.jason", inventoryResultJason);
            Console.WriteLine("Successfully data stored in Jason file");
            string file = File.ReadAllText(@"inventoryJason.jason");
            var data1 = JsonConvert.DeserializeObject<List<InventoryDetails>>(file);
            foreach (var i in data1)
            {
                Console.WriteLine(i.name);
            }
            Console.WriteLine("total inventoryGrandTotal " + inventoryGrandTotal);
        }
    }
}