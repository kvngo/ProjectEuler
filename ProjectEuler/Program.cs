/*
If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.
Find the sum of all the multiples of 3 or 5 below 1000.
Trick: numbers like 15 are multiples of 3 and 5 so they shouldn't be counted twice.
 * 
 * */


using System;
using System.Collections.Generic;

namespace ProjectEuler
{
    class Program
    {
        static void Main(string[] args)
        {
            const int maxValue = 1000;
            var numbersList = new HashSet<int>();
            int temp = 0;
            int total = 0;

            // add multiples of 3's below 1000
            temp = 3;
            while (temp < maxValue)
            {
                numbersList.Add(temp);
                temp+=3;
            }

            // add multiples of 5's below 1000
            temp = 5;
            while (temp < maxValue)
            {
                numbersList.Add(temp);
                temp += 5;
            }


            foreach (var num in numbersList)
                total += num;

            Console.WriteLine("Total: " + total);



        }
    }
}
