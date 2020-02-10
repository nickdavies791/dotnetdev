using static System.Console;
using System.Linq;

namespace CSharp6
{
    public class Person
    {
        public string Forename { get; } 
        public string MiddleName { get; } = "";
        public string Surname { get; } 

        /**
         * Constructor method.
         */
        public Person(string forename, string middlename, string surname)
        {
            Forename = forename;
            MiddleName = middlename;
            Surname = surname;
        }

        /**
         * Return full name when using ToString method.
         */
        public override string ToString() => $"{Forename} {MiddleName} {Surname}";

        /**
         * Returns full name in caps, modifying the original
         * property values and returning the result.
         */
        public string AllCaps() => ToString().ToUpper();

        /**
         * Returns the average length of the persons full name.
         * This uses LINQ to go through the words split by spaces and select the
         * length of each word. LINQ is imported into the class.
         */
        public double GetAverageLengthOfFullName()
        {
            var name = ToString();
            var wordLength = from word in name.Split(' ') select word.Length;
            var average = wordLength.Average();

            return average;
        }
    }
}