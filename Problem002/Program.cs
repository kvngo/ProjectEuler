﻿//Each new term in the Fibonacci sequence is generated by adding the previous two terms. By starting with 1 and 2, the first 10 terms will be:
//1, 2, 3, 5, 8, 13, 21, 34, 55, 89, ...
//By considering the terms in the Fibonacci sequence whose values do not exceed four million, find the sum of the even-valued terms.

using System;
using System.Collections.Generic;

namespace Problem002
{
    class Program
    {
        static void Main(string[] args)
        {
            const int maxValue = 4000000; //max value of fibonacci seq. can't be > 4 million
            var fibonacciList = new List<int>();
            int fibonacciValueA = 1;
            int fibonacciValueB = 2;
            int fibonacciValueC = 0;
            
            //initialize the first 2 fibonacci values
            fibonacciList.Add(fibonacciValueA);
            fibonacciList.Add(fibonacciValueB);
            
            do
            {
                //update the next fibonacci value
                fibonacciValueC = fibonacciValueA + fibonacciValueB;
                
                if (fibonacciValueC < maxValue)
                {
                    fibonacciList.Add(fibonacciValueC);
                }

                //update the values
                fibonacciValueA = fibonacciValueB;
                fibonacciValueB = fibonacciValueC;
                
            
            } while (fibonacciValueC < maxValue);

            int sumEvenValues = 0;
            foreach (var number in fibonacciList)
            {
                if (number % 2 == 0)
                    sumEvenValues += number;
            }

            Console.WriteLine("Sum: " + sumEvenValues);

        }
    }
}
