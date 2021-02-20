using System;

namespace ForLoopSample
{
    class Program
    {
        /// <summary>
        /// Sample code to illustrate use of a simple FOR loop.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            for (int i = 10; i < 15; i++)
            {
                Console.WriteLine("The value of i is " + i);
                if (i == 13)
                {
                    Console.WriteLine("The value of i is unlucky 13. Time for me to stop.");
                    break;
                }
            }
        }
    }
}
