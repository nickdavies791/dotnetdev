using System;

namespace CSharp6
{
    public class Person
    {
        public string Forename { get; private set; }
        public string Surname { get; private set; }

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

        public string AllCaps()
        {
            Forename = Forename.ToUpper();
            Surname = Surname.ToUpper();

            return ToString();
        }
    }
}