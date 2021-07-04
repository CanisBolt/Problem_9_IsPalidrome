using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_9_IsPalidrome
{
    class Palidrome
    {
        /* 
         * LeetCode Problem #9
         * Given an integer x, return true if x is palindrome integer.
         * An integer is a palindrome when it reads the same backward as forward. 
         * For example, 121 is palindrome while 123 is not.
        */
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number:");
            string strNumber = Console.ReadLine();

            for (int i = 0, j = strNumber.Length - 1; i < strNumber.Length && j > 0; i++, j--)
            {
                if (strNumber[i] == strNumber[j])
                {
                    continue;
                }
                else
                {
                    Console.WriteLine("Is not Palidrome");
                    Console.ReadKey();
                    return;
                }
            }

            Console.WriteLine("Is Palidrome");
            Console.ReadKey();
        }
    }
}
