using System.Linq;
using System.Collections.Generic;
using System;

namespace ConsoleApp2
{
    public class Program
    { 
        static void Main(string[] args)
        {
            int year;
            Console.Write("Enter the Year: ");
            year = Convert.ToInt32(Console.ReadLine());
            if (year%400==0|| (year%4==0 && year%100 !=0))
            {
                Console.WriteLine("{0} is Leap Year", year);
            }
            else
            {
                Console.WriteLine("{0} is not a Leap Year", year);
            }

            Console.WriteLine();
        }
    }
   
}

/*
 */
