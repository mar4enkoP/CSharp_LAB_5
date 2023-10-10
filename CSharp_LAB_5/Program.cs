using System;

namespace CSharp_LAB_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WatercraftManager watercraftManager = new WatercraftManager();

            Ship ship = new Ship("Ship", "Cargo Ship", 5000, "ManufacturerA", 2022, "Cargo", 30, 15);
            Barge barge = new Barge("Barge", "Cargo Barge", 3000, "ManufacturerB", 2021, 2000, "Coal", true);
            Yacht yacht = new Yacht("Yacht", "elite", 20, "ManufacturerC", 2023, 10, "John Doe", "BH1234");

            watercraftManager.AddWatercraft(ship);
            watercraftManager.AddWatercraft(barge);
            watercraftManager.AddWatercraft(yacht);

            Console.WriteLine("List of Watercrafts:");
            foreach (var watercraft in watercraftManager.GetWatercraftArray())
            {
                Console.WriteLine(watercraft);
            }

            Console.WriteLine("\nEditing the first watercraft:");
            Ship editedShip = new Ship("Edited Ship", "Cargo Ship", 6000, "ManufacturerX", 2021, "Cargo", 35, 20);
            watercraftManager.EditWatercraft(0, editedShip);
            Console.WriteLine(watercraftManager.GetWatercraftArray()[0]);

            Console.WriteLine("\nRemoving the second watercraft:");
            watercraftManager.RemoveWatercraft(1);
            foreach (var watercraft in watercraftManager.GetWatercraftArray())
            {
                Console.WriteLine(watercraft);
            }
        }
    }
}