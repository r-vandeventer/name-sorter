using System;
using System.Collections.Generic;
using System.Text;

namespace name_sorter.Models
{
    public class Name
    {
        public string FirstName;
        public string LastName;
        public string MiddleName;

        public Name()
        {

        }

        public Name (string firstName, string middleName, string lastName)
        {
            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastName;
        }

        //Split the text name into a first, middle, last name as a new Name object
        public Name SplitName(string name)
        {
            string[] names = name.Split(' ');

            FirstName = names[0];
            LastName = names[names.Length - 1];
            MiddleName = "";

            if (names.Length > 2) 
            {
                for (int i = 1; i < names.Length -1; i++)
                {
                    MiddleName = MiddleName + " " + names[i];
                }
            }

            return new Name(FirstName, MiddleName, LastName);
        }

        //Override ToString to print the names as one
        public override string ToString()
        {
            return String.Format("{0} {1} {2}", FirstName, MiddleName, LastName);
        }
    }
}
