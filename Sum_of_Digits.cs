using System;
using System.Collections.Generic;

namespace ConsoleApp2
{
    // Sum of Digits
    public class Program
    { 
        static void Main(string[] args)
        {
            Console.Write("Please Enter a Number ");
            int number = int.Parse(Console.ReadLine());
            int sum = 0,remainder;
            while (number>0)
            {
                remainder = number % 10;
                sum = sum + remainder;
                number = number / 10;
            }
            Console.WriteLine($"Sum of Digits is: {sum}");
            Console.WriteLine();
        }
    }
}

/*
 *
 */
