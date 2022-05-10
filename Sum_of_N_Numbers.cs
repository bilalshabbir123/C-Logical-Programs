using System.Linq;
using System.Collections.Generic;
using System;

namespace ConsoleApp2
{
    public class Program
    { 
        static void Main(string[] args)
        {
            int number,sum=0;
            Console.Write("Please Enter a Number ");
            number = Convert.ToInt32(Console.ReadLine());
            if (number<0)
            {
                Console.Write("Please Enter the Number Greater than Zero");
            }
            else
            {
                for (int i = 0; i < number; i++)
                {
                    sum += i;
                }
                Console.Write("Sum of Natural is {0}",sum);
            }


            Console.WriteLine();
        }
    }
   
}

/*
 */
