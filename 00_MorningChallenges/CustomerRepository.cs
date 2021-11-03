using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_MorningChallenges
{
    public class CustomerRepository
    {
        protected readonly List<Customer> _contentDirectory = new List<Customer>();

        // CRUD basic necessities of repository pattern

        public bool AddCustomerToDirectory(Customer customer)
        {
            foreach (Customer existingCustomer in _contentDirectory)
            {
                if (customer.Id == existingCustomer.Id)
                {
                    return false;
                }
            }
            int startingCount = _contentDirectory.Count;
            _contentDirectory.Add(customer);

            bool wasAdded = (_contentDirectory.Count > startingCount) ? true : false;
            return wasAdded;
        }

        // Read
        // Get all
        public List<Customer> GetCustomers()
        {
            return _contentDirectory;
        }

        // Get single
        public Customer GetCustomerById(int id)
        {
            foreach (Customer customer in _contentDirectory)
            {
                if (customer.Id == id)
                {
                    return customer;
                }
            }
            return null;
        }

        // Update
        public bool UpdateExistingCustomerById(int originalId, Customer newCustomer)
        {
            Customer oldCustomer = GetCustomerById(originalId);

            if (oldCustomer != null)
            {
                if (newCustomer.Id != oldCustomer.Id)
                {
                    foreach (Customer existingCustomer in _contentDirectory)
                    {
                        if (newCustomer.Id == existingCustomer.Id)
                            return false;
                    }
                }
                oldCustomer.Id = newCustomer.Id;
                oldCustomer.LastName = newCustomer.LastName;
                oldCustomer.EnrollmentDate = newCustomer.EnrollmentDate;
                oldCustomer.Age = newCustomer.Age;

                return true;
            }
            else
                return false;
        }

        // Delete
        public bool DeleteExistingCustomer(Customer existingCustomer)
        {
            bool deleteResult = _contentDirectory.Remove(existingCustomer);
            return deleteResult;
        }

        public void ThankYouNote()
        {
            foreach (Customer customer in _contentDirectory)
            {
                if (customer.YearsEnrolled > 5)
                {
                    Console.WriteLine("Thank you for being a gold member");
                }
                else if (customer.YearsEnrolled >= 1 && customer.YearsEnrolled <= 5)
                {
                    Console.WriteLine("Thank you for being a customer");
                }
                else
                    Console.WriteLine("Get rekt looser, it hasn't even been a year.");
            }
        }
    }
}
