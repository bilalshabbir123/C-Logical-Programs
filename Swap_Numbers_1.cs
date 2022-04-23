using System;
using System.Collections.Generic;

namespace ConsoleApp2
{ 
    //How to swap two numbers using third variable in C#
    public class Program
    { 
        static void Main(string[] args)
        {
            int number1 = 10, number2 = 20, temp = 0;
            Console.WriteLine($"Before Swaping number1={number1}, number2={number2}");
            temp = number1;  //temp=10
            number1 = number2; //number1=20
            number2 = temp; //number2=10
            Console.WriteLine($"After Swapping Number1={number1}, Number2={number2}");
        }
    }
}

/*
*
 */
