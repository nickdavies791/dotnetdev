using static System.Console;

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
        public override string ToString() => Forename + " " + MiddleName + " " + Surname;

        /**
         * Returns full name in caps, modifying the original
         * property values and returning the result.
         */
        public string AllCaps() => ToString().ToUpper();
    }
}