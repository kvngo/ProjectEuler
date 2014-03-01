//The sum of the squares of the first ten natural numbers is,
//1^2 + 2^2 + ... + 10^2 = 385
//
//The square of the sum of the first ten natural numbers is,
//(1 + 2 + ... + 10)^2 = 55^2 = 3025
//Hence the difference between the sum of the squares of the first ten natural numbers and the square of the sum is 3025 − 385 = 2640.
//
//Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.


using System;

namespace Problem004
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxValueNaturalNumbers  = 100;
            int differenceValue         = SquareOfSums(maxValueNaturalNumbers) - SumOfSquares(maxValueNaturalNumbers);
            Console.WriteLine("Difference between the sum of the suares\n" +
                              "and square of the sum for the first {0}\n" +
                              "numbers is: {1}\n\n", maxValueNaturalNumbers, differenceValue);
        }

        /// <summary>
        /// The sum of the squares of the first ten natural numbers is,
        /// 1^2 + 2^2 + ... + 10^2 = 385
        /// </summary>
        /// <param name="maxNaturalNumbers"></param>
        /// <returns></returns>
        static int SumOfSquares(int maxNaturalNumbers)
        {
            double sum = 0;
            for (int ii = 1; ii <= maxNaturalNumbers; ii++)
            {
                sum += Math.Pow(ii,2);
            }

            return Convert.ToInt32(sum);
        }

        /// <summary>
        /// The square of the sum of the first ten natural numbers is,
        /// (1 + 2 + ... + 10)^2 = 55^2 = 3025
        /// </summary>
        /// <param name="maxNaturalNumbers"></param>
        /// <returns></returns>
        static int SquareOfSums(int maxNaturalNumbers)
        {
            int sum         = 0;
            
            for (int ii = 1; ii <= maxNaturalNumbers; ii++)
            {
                sum += ii;
            }
            
            return Convert.ToInt32(Math.Pow(sum, 2));
        }
    }
}
