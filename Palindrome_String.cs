using System;
using System.Collections.Generic;

namespace ConsoleApp2
{
    // Check String is Palindrome or not
    public class Program
    { 
        static void Main(string[] args)
        {
            Console.Write("Enter a string to Check Palindrome : ");
            string name = Console.ReadLine();
            string reverse = string.Empty;

            for (int i = name.Length - 1; i >= 0; i--)
            {
                reverse += name[i];
            }

            if (name == reverse)
            {
                Console.WriteLine($"{name} is Palindrome.");
            }
            else
            {
                Console.WriteLine($"{name} is not Palindrome");
            }
            Console.WriteLine();
        }
    }
}

/*
 *In the following program, we take the string as an input
 *from the console. Then we reverse the string using for loop
 *and storing the reverse string value in the reverse variable.
 *Finally, we check whether the original and reverse values are
 *the same or not. If both are the same then the string is Palindrome 
 *else it is not Palindrome.
 */
