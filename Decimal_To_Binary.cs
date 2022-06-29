using System.Linq;
using System.Collections.Generic;
using System;
namespace ConsoleApp2
{
    public class Program
    { 
        static void Main(string[] args)
        {
            Console.Write("Enter the Decimal Number: ");
            int number = int.Parse(Console.ReadLine());
            int[] numberarray = new int[10];
            int i;
            for ( i = 0; number>0; i++)
            {
                numberarray[i] = number % 2;
                number = number / 2;
            }
            Console.Write("Binary Repreasentation of the given number :");
            for ( i = i-1; i >=0; i--)
            {
                Console.Write(numberarray[i]);
            }
            Console.WriteLine();
        }
    }
}
/*
 * 
 */
