﻿using System;
using System.Collections.Generic;

namespace ListCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = new List<string> { "Nick", "Ana", "Felipe" };

            foreach (var name in names)
            {
                Console.WriteLine($"Hello, {name.ToUpper()}");
            }
        }
    }
}
