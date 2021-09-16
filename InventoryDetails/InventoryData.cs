using Newtonsoft.Json;
using System.IO;
using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedPrograms.InventoryDetails
{
    public class InventoryData
    {
        public void Data()
        {
            //Add Details
            //Create List of type invetory which store the object of the class Inventory
            List<Inventory> inventoryList = new List<Inventory>();
            Console.WriteLine("Number of Inventory details ");
            int iteration = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < iteration; i++)
            {
                Console.WriteLine("Enter the name of item");
                string itemName = Console.ReadLine();
                Console.WriteLine("Enter the weight of item");
                int itemWeight = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the price of item");
                int itemPrice = Convert.ToInt32(Console.ReadLine());
                inventoryList.Add(new Inventory()
                {
                    Name = itemName,
                    Weight = itemWeight,
                    Price = itemPrice
                });
            }
            //WriteFile using Serialize JSON 
            string inventoryResultJason = JsonConvert.SerializeObject(inventoryList);
            Console.WriteLine(inventoryResultJason);
            File.WriteAllText(@"F:\DotNetClass\ObjectOrientedPrograms\InventoryDetails\InventoryDetails.json", inventoryResultJason);
            Console.WriteLine("Inventory Details Added SuccessFully in File.");
            // ReadFile using Deserialize Json
            string datafile = File.ReadAllText(@"F:\DotNetClass\ObjectOrientedPrograms\InventoryDetails\InventoryDetails.json");
            List<Inventory> returnDataObj = JsonConvert.DeserializeObject<List<Inventory>>(datafile);
            //Display JSON file Data
            foreach (var form in returnDataObj)
            {
                Console.WriteLine("Name : " + form.Name);
                Console.WriteLine("Weight : " + form.Weight);
                Console.WriteLine("Price : " + form.Price);
                //Calulation
                Console.WriteLine("Total Value of {0} =  {1}: ", form.Name, (form.Weight * form.Price));
            }
        }
    }
}