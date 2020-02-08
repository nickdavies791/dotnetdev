using System;

namespace NumbersInCSharp
{
    class Program
    {
        static void WorkingWithIntegers()
        {
            int a = 18;
            int b = 6;
            int c = a + b;

            Console.WriteLine(c);
        }

        static void Main(string[] args)
        {
            // WorkingWithIntegers();

            int a = 7;
            int b = 4;
            int c = 3;
            int d = (a + b) / c;
            int e = (a + b) % c;
            Console.WriteLine($"quotient: {d}");
            Console.WriteLine($"remainder: {e}");
            Console.WriteLine($"The range of integers is {int.MinValue} to {int.MaxValue+3}");
        }
    }
}
