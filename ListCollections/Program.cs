using System;
using System.Collections.Generic;

namespace ListCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = new List<string> { "Nick", "Ana", "Felipe" };
            
            names.Add("Maria");
            names.Add("Bill");
            names.Remove("Ana");
            foreach (var name in names)
            {
                Console.WriteLine($"Hello, {name.ToUpper()}");
            }

            Console.WriteLine($"My name is {names[0]}");
            Console.WriteLine($"I've added {names[2]} and {names[3]} to the list.");
            Console.WriteLine($"The list contains {names.Count} people.");
        }
    }
}
