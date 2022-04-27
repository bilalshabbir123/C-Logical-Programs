using System;
using System.Collections.Generic;

namespace ConsoleApp2
{
    // Factorial of a Number using For Recursive Function
    public class Program
    { 
       static public long RecursiveFactorial(int number)
        {
            if (number==1)
            {
                return 1;
            }
            else
            {
                return number * RecursiveFactorial(number - 1);
            }

        }
        static void Main(string[] args)
        {
            Console.Write("Please Enter a Number ");
            int number = int.Parse(Console.ReadLine());
            long Factorial = RecursiveFactorial(number);
            Console.WriteLine($"Factorial of a Number is:  {Factorial}");
            Console.WriteLine();
        }
    }
}

/*
 *
 */
