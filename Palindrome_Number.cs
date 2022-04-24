using System;
using System.Collections.Generic;

namespace ConsoleApp2
{
    // Check Number is Palindrome or not
    public class Program
    { 
        static void Main(string[] args)
        {
            Console.Write("Enter a Number To Check Palindrome: ");
            int number = int.Parse(Console.ReadLine());
            int remainder, sum = 0;
            int temp = number;
            while (number>0)
            {
                // Get the remainder by dividing the number with 10
                remainder = number % 10;
                //multiply the sum with 10 and then add the remainder
                sum = (sum * 10) + remainder;
                // Get the quotient by dividing the number with 10
                number = number / 10;
              
            }
            if (temp == sum)
            {
                Console.WriteLine($"Number {temp} is Palindrome. ");
            }
            else
            {
                Console.WriteLine($"Number {temp} is not Palindrome");
            }
            Console.WriteLine();
        }
    }
}

/*
 *Palindrome Number:
*A Palindrome number is a number that is going to be the same 
*after reversing the digits of that number. For example, 
*the numbers such as 121, 232, 12344321, 34543, 98789, etc. 
*are the palindrome numbers. 
*
*
*Algorithm to check Palindrome Number in C#:

First, get the number from the user which you want to check
Hold that number in a temporary variable
Reverse that number
Compare the temporary number with the reversed number
If both numbers are the same, then print it is a palindrome number else print it is not a palindrome number
*
*/
