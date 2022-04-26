using System;
using System.Collections.Generic;

namespace ConsoleApp2
{
    public class Program
    { 
        static void Main(string[] args)
        {
            Console.Write("Enter The Start Number:  ");
            int startNumber = int.Parse(Console.ReadLine());
            Console.Write("Enter The End Number:  ");
            int endNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"The Prime Numbers between {startNumber} and {endNumber} are : ");

            for (int i = startNumber; i <= endNumber; i++)
            {
                int counter = 0;
                for (int j = 2; j <= i / 2; j++)
                {
                    if (i % j == 0)
                    {
                        counter++;
                        break;
                    }
                }
                if (counter == 0 && i != 1)
                {
                    Console.Write("{0} ", i);
                }
            }
            Console.WriteLine();
        }
    }
}

/*
 *
 */
