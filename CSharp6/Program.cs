using System;

namespace CSharp6
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person("Nick", "Davies");
            Console.WriteLine($"{person.ToString()}");
            Console.WriteLine($"{person.AllCaps()}");
            Console.WriteLine($"{person}");
        }
    }
}
