using System;
using System.Collections.Generic;

namespace ConsoleApp2
{ 
    //How to swap two strings without using third variable in C#
    public class Program
    { 
        static void Main(string[] args)
        {
            string name1 = "Bilal", name2 = "Shabbir";
            Console.WriteLine($"Before Swapping name1={name1},name2={name2}");
            // Step 1: append 2nd string with the 1st string
            name1 = name1 + name2;
            //Step2:  store initial string name1 in string name2
            name2 = name1.Substring(0, name1.Length - name2.Length);
            //Step3: store inital string name2 in string name1
            name1 = name1.Substring(name2.Length);
            Console.WriteLine($"After Swapping name1={name1},name2={name2}");
            Console.WriteLine();
            
        }
    }
}

/*
*String.Substring Method (startIndex): This Substring() method is
*used to extract a substring from the current instance of the 
*string.
*
*String.Substring Method (int startIndex, int length):
*This Substring() method is used to retrieve a substring that
*begins from the specified position described by parameter 
*“startIndex” and has a specified length. If the startIndex 
*is equal to the length of string and parameter length is zero,
*then it will return nothing as a substring.
 */
