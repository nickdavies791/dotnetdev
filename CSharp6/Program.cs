using static System.Console;

namespace CSharp6
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person("Nick", "Ashley", "Davies");
            WriteLine($"{person.ToString()}");
            WriteLine($"{person.AllCaps()}");
            WriteLine($"{person}");
            WriteLine(person.GetAverageLengthOfFullName());
        }
    }
}
