using System;

namespace CSharp6
{
    public class Person
    {
        public string Forename { get; } // Should not be able to modify
        public string Surname { get; } // Should not be able to modify

        /**
         * Constructor method.
         */
        public Person(string forename, string surname)
        {
            Forename = forename;
            Surname = surname;
        }

        /**
         * Return full name when using ToString method.
         */
        public override string ToString()
        {
            return Forename + " " + Surname;
        }

        /**
         * Returns full name in caps, modifying the original
         * property values and returning the result.
         */
        public string AllCaps()
        {
            Forename = Forename.ToUpper();
            Surname = Surname.ToUpper();

            return ToString();
        }
    }
}