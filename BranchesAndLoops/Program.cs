using System;

namespace BranchesAndLoops
{
    class Program
    {
        static void ExploreIfs()
        {
            int a = 5;
            int b = 2;

            if (a + b > 10)
            {
                Console.WriteLine("The answer is greater than 10.");                
            }
            else 
            {
                Console.WriteLine("The answer is smaller than 10.");
            }
        }

        static void ExploreWhile()
        {
            int counter = 0;

            while (counter < 10)
            {
                Console.WriteLine($"The counter is {counter}");
                counter++;
            }
        }

        static void ExploreDoWhile()
        {
            int counter = 0;

            do 
            {
                Console.WriteLine($"The counter is {counter}");
                counter++;
            }
            while (counter < 10);
        }

        static void ExploreFor()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"The counter is {i}");
            }
        }

        static void SumOfIntegersDivisibleBy3(int minNumber, int maxNumber)
        {
            int sumOfIntegers = 0;
            // Loop through numbers between minNumber and maxNumber
            for (int i = minNumber; i <= maxNumber; i++)
            {
                // If i is divisible by 3 then add i to the sumOfIntegers
                if (i % 3 == 0)
                {
                    sumOfIntegers += i;
                }
            }

            // Print the sum out with the minNumber and maxNumber values
            Console.WriteLine($"The sum of integers between {minNumber} and {maxNumber} divisible by 3 is {sumOfIntegers}");
        }

        static void Main(string[] args)
        {
            // ExploreIfs();
            // ExploreWhile();
            // ExploreDoWhile();
            // ExploreFor();
            SumOfIntegersDivisibleBy3(1, 20);
        }
    }
}
