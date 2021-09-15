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
            List<InventoryDetails> listDetails = new List<InventoryDetails>();
            Console.WriteLine("Number of Inventory ");
            int iteration = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < iteration; i++)
            {
                Console.WriteLine("Enter the name of item");
                string itemName = Console.ReadLine();
                Console.WriteLine("Enter the weight of item");
                int itemWeight = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the price of item");
                int itemPrice = Convert.ToInt32(Console.ReadLine());
                listDetails.Add( new InventoryDetails()
                {
                    name = itemName,
                    weight = itemWeight,
                    price = itemPrice
                });
            }
            string inventoryResultJason = JsonConvert.SerializeObject(listDetails);
            //Console.WriteLine(inventoryResult);
            File.WriteAllText(@"inventoryJason.jason", inventoryResultJason);
            Console.WriteLine("Successfully data stored in Jason file");
            string file = File.ReadAllText(@"inventoryJason.jason");
            var data1 = JsonConvert.DeserializeObject<List<InventoryDetails>>(file);
            foreach (var i in data1)
            {
                Console.WriteLine(i.name);
            }
        }
    }
}
