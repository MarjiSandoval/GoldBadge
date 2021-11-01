using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Classes
{
    public class Person
    {
        public Person()
        {
            Transport = new Vehicle();
        }
        public Person(string firstName, string lastName, DateTime dateOfBirth, Vehicle transport)
        {
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            Transport = transport;
        }
        public Person(string firstName, string lastName, DateTime dateOfBirth)
        {
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
        }


        //private backing field.
        private string _lastName;

        public string FirstName { get; private set; }


        //this is our full property 
        //this will use the private backing field
        public string LastName
        {
            get
            {
                return _lastName[0].ToString();
            }
            set
            {
                _lastName = value;
            }
        }

        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }

        public int Age
        {
            get
            {
                TimeSpan ageSpan = DateTime.Now - DateOfBirth;

                double totalAgeInYears = ageSpan.TotalDays / 365.25;
                Console.WriteLine($"totalAgeInYears: {totalAgeInYears}");

                Console.WriteLine($"yearsOfAge: {Math.Floor(totalAgeInYears)}");
                int yearsOfAge = Convert.ToInt32(Math.Floor(totalAgeInYears));

                return yearsOfAge;
            }
        }

        public DateTime DateOfBirth { get; set; }
        public Vehicle Transport { get; set; }
    }
}