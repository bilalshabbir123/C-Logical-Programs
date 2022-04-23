using System;
using System.Collections.Generic;

namespace ConsoleApp2
{
    // Fibonacci Series Program in C#
    public class Program
    { 
        static void Main(string[] args)
        {
            int firstNumber = 0, secondNumber = 1, nextNumber, numberofElements;
            Console.Write("Enter the number of Elements to Print :");
            numberofElements = int.Parse(Console.ReadLine());
            if (numberofElements<2)
            {
                Console.WriteLine("Please Enter a Number Greater than two");
            }
            else
            {
                // First print first and second number
                Console.Write(firstNumber+ " "+secondNumber+" ");

                //Starts the Loop from 2 because 0 and 1 are already printed

                for (int i = 2; i < numberofElements; i++)
                {
                    nextNumber = firstNumber + secondNumber;
                    Console.Write(nextNumber + "\n ");
                    firstNumber = secondNumber;
                    secondNumber = nextNumber;
                }
            }
            Console.WriteLine();
        }
    }
}

/*
*The Fibonacci series is nothing but a sequence of numbers.
*The numbers in this series are going to start with 0 and 1.
*The next number is the sum of the previous two numbers.
*
*       F(n)=F(n-1)+F(n-2)      --F(n) is the term number   --F(n-1) is the previous term    --F(n-2) is the term before that (n-2)
*Two approaches to print Fibonacci Series       
*
 */
