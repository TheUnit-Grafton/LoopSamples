﻿using System;

namespace WhileLoop
{
    class Program
    {
        /// <summary>
        /// Sample code illustrating the use of a WHILE loop
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int i = 10;

            while (i < 15)
            {
                Console.WriteLine("The value of i is " + i);
                if (i == 13)
                {
                    Console.WriteLine("The value of i is unlucky 13. Time for me to stop.");
                    break;
                }
                i++;
            }
        }
    }
}
