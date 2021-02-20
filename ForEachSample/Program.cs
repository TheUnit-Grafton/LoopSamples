using System;

namespace ForEachSample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a string array and populate it with car makers
            string[] cars = { "Ford", "Holden", "Mazda", "Nissan", "BMW", "Kia" };

            foreach (string car in cars)
            {
                // All this loop does is display the makes of car to the screen
                Console.WriteLine(car);
            }
        }
    }
}
