using System;
using System.Collections.Generic;

namespace ConsoleApp2
{
    // Reverse a number
    public class Program
    { 
        static void Main(string[] args)
        {
            Console.Write("Enter a Number : ");
            int number = int.Parse(Console.ReadLine());
            int reminder, reverse = 0;
            while (number > 0)
            {
                //Get the remainder by dividing the number with 10  
                reminder = number % 10;
                //multiply the sum with 10 and then add the reminder
                reverse = (reverse * 10) + reminder;
                //Get the quotient by dividing the number with 10 
                number = number / 10;
            }
            Console.WriteLine($"The Reverse order is : {reverse}");
            Console.WriteLine();
        }
    }
}

/*
 *
 */
