using System;
using CSharp_LAB_5;

namespace WatercraftNamespace
{
    class Program
    {
        static void Main(string[] args)
        {
            WatercraftManager manager = new WatercraftManager();
            
            manager.AddWatercraft(new Watercraft("Ship1", "Ship", 1000));
            manager.AddWatercraft(new Watercraft("Barge1", "Barge", 500));
            manager.AddWatercraft(new Watercraft("Yacht1", "Yacht", 10));

           
            Console.WriteLine("Ship list:");
            var watercraftArray = manager.GetWatercraftArray();
            foreach (var watercraft in watercraftArray)
            {
                Console.WriteLine(watercraft);
            }
            
            manager.EditWatercraft(1, new Watercraft("Barge2", "Barge", 800));
            
            manager.RemoveWatercraft(0);

           
            Console.WriteLine("\nUpdated list of ships:");
            watercraftArray = manager.GetWatercraftArray();
            foreach (var watercraft in watercraftArray)
            {
                Console.WriteLine(watercraft);
            }

            Console.ReadLine();
        }
    }
}