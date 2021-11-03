using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_MorningChallenges
{
    public class Customer
    {
        public Customer(){ }

        public Customer(int id, string lastName, int age, DateTime enrollment)
        {
            Id = id;
            LastName = lastName;
            Age = age;
            EnrollmentDate = enrollment;
        }

        public int Id { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public DateTime EnrollmentDate { get; set; }
        public int YearsEnrolled
        {

            get
            {
                TimeSpan enrolledSpan = DateTime.Now - EnrollmentDate;

                double totalEnrollmentInYears = enrolledSpan.TotalDays / 365.25;

                int yearsEnrolled = Convert.ToInt32(Math.Floor(totalEnrollmentInYears));

                return yearsEnrolled;
            }
        }
    }
}
