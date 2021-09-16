using ObjectOrientedPrograms.InventoryDetails;
using System;
using Newtonsoft.Json;
using System.IO;

namespace ObjectOrientedPrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcom to Object Oriented Programs\n");
            while (true)
            {
                Console.WriteLine("\nChoose An Option to Perform an Action :");
                Console.WriteLine("Press 1 : Json Inventory\nPress 2 : Exit");
                Console.WriteLine("----------------------------------------");
                int userOption = int.Parse(Console.ReadLine());
                switch (userOption)
                {
                    case 1:
                        Console.WriteLine("Display Json Inventory Details\n");
                        InventoryData obj = new InventoryData();
                        obj.Data();
                        break;
                    case 2:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Please Enter a valid Options:\n");
                        break;
                }

            }
        }
    }
}