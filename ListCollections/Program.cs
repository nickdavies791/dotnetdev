using System;
using System.Collections.Generic;

namespace ListCollections
{
    class Program
    {
        static void ChangingLists()
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

        static void SortingAndSearchingLists()
        {
            var names = new List<string> { "Nick", "Ana", "Felipe" };

            var index = names.IndexOf("Felipe");
            if (index == -1)
            {
                Console.WriteLine($"If an item is not found, IndexOf is {index}");
            }
            else
            {
                Console.WriteLine($"{names[index]} is at index {index}");
            }

            names.Sort();

            foreach (var name in names)
            {
                Console.WriteLine($"Hello, {name.ToUpper()}");
            }
        }

        static void Main(string[] args)
        {
            // ChangingLists();
            SortingAndSearchingLists();
        }
    }
}
