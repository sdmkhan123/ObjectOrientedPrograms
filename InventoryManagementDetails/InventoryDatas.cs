using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using System.IO;

namespace ObjectOrientedPrograms.InventoryManagementDetails
{
    class InventoryDatas
    {
        public void Data()
        {
            //Display Message
            Console.WriteLine("Welcome to JSON Inventory Data Management Details");
            Console.WriteLine("*****************************************************************************");
            //Display Messsages
            Console.WriteLine("Press 1 : Add Details In Inventory\nPress 2 : Display Inventory Details");
            Console.WriteLine("*****************************************************************************");
            int userOption = Convert.ToInt32(Console.ReadLine());
            switch (userOption)
            {
                case 1:
                    //Create List
                    List<Inventorys> inventoryList = new List<Inventorys>();
                    Console.WriteLine("Number of items want to be add ");
                    int numOfItems = Convert.ToInt32(Console.ReadLine());
                    for (int i = 0; i < numOfItems; i++)
                    {
                        Console.WriteLine("Enter the name of new itemName");
                        string itemName = Console.ReadLine();
                        Console.WriteLine("Enter the weight of itemWeight");
                        double itemWeight = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Enter the price of itemPrice per kg");
                        double itemPrice = Convert.ToDouble(Console.ReadLine());
                        inventoryList.Add(new Inventorys()
                        {
                            Name = itemName,
                            Weight = itemWeight,
                            Price = itemPrice
                        });
                    }
                    //Serialize JSON 
                    string jsonFileResult = JsonConvert.SerializeObject(inventoryList);
                    File.WriteAllText(@"F:\DotNetClass\ObjectOrientedPrograms\InventoryManagementDetails\InventoryDetails.json", jsonFileResult);
                    Console.WriteLine("Inventory Details Added SuccessFully in File.");
                    break;
                case 2:
                    //Display Messages
                    Console.WriteLine("Dispaly Inventory Items");
                    Console.WriteLine("*****************************************************************************");
                    //Deserialize Data of JSON file
                    string datafile = File.ReadAllText(@"F:\DotNetClass\ObjectOrientedPrograms\InventoryManagementDetails\InventoryDetails.json");
                    List<Inventorys> jsonFileData = JsonConvert.DeserializeObject<List<Inventorys>>(datafile);
                    //Display JSON file Data
                    foreach (var i in jsonFileData)
                    {
                        Console.WriteLine("Name : " + i.Name);
                        Console.WriteLine("Weight : " + i.Weight);
                        Console.WriteLine("Price : " + i.Price);
                        //Calulation
                        Console.WriteLine("Total Value of {0} =  {1}: ", i.Name, (i.Weight * i.Price));
                        Console.WriteLine("*****************************************************************************");
                    }
                    break;
                default:
                    Console.WriteLine("Please enter valid option");
                    break;
            }
        }
    }
}
