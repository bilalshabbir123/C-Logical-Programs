using System;
using System.Collections.Generic;

namespace ConsoleApp2
{ 
    //How to swap two numbers without using third variable in C#
    public class Program
    { 
        static void Main(string[] args)
        {
            int number1 = 10, number2 = 20;
            Console.WriteLine($"Before Swaping number1={number1}, number2={number2}");
            number1 = number1 * number2;  //number1=200 --10*20
            number2 = number1/number2; //number2=10 --200/20
            number1 = number1 / number2; //number2=20 //200/10
            Console.WriteLine($"After Swapping Number1={number1}, Number2={number2}");
        }
    }
}

/*
*
 */
