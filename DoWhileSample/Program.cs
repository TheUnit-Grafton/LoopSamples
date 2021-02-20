using System;

namespace DoWhileSample
{
    class Program
    {
        /// <summary>
        /// Sample code to illustrate use of a Do/While loop.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int i = 10;

            do
            {
                Console.WriteLine("The value of i is " + i);
                if (i == 13)
                {
                    Console.WriteLine("The value of i is unlucky 13. Time for me to stop.");
                    break;
                }
                i++;
            }
            while (i < 15);
        }
    }
}
