using System;
using System.Collections.Generic;

namespace ConsoleApp2
{
    // Factorial of a Number using For loop
    public class Program
    { 
        static void Main(string[] args)
        {
            Console.Write("Enter a Number : ");
            int number = int.Parse(Console.ReadLine());
            int Factorial = 1;
            for (int i = 1; i <=number; i++)
            {
                Factorial = Factorial * i;
            }
            Console.Write($"Factorial of a Number is:  {Factorial}");
            Console.WriteLine();
        }
    }
}

/*
 *
 */
