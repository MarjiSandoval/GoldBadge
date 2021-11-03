using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace _00_MorningChallenges
{
    [TestClass]
    public class CustomerRepoTests
    {
        [TestMethod]
        public void CreateCustomer_ShouldAddCustomer()
        {
            Customer customer = new Customer(004, "Brown", 45, new DateTime(2000, 01, 01));

            CustomerRepository repo = new CustomerRepository();

            Assert.IsTrue(repo.AddCustomerToDirectory(customer));
        }

        private CustomerRepository _repo;
        private Customer _customer;

        [TestInitialize]
        public void Arrange()
        {
            _repo = new CustomerRepository();

            _customer = new Customer(004, "Brown", 45, new DateTime(2000, 01, 01));
            Customer customerOne = new Customer(002, "Scroggins", 67, new DateTime(2021, 04, 04));
            Customer customerTwo = new Customer(003, "Torr", 22, new DateTime(2019, 04, 08));

            _repo.AddCustomerToDirectory(_customer);
            _repo.AddCustomerToDirectory(customerOne);
            _repo.AddCustomerToDirectory(customerTwo);
        }

        [TestMethod]
        public void GetAll_ShouldReturnDirectory()
        {
            List<Customer> customers = _repo.GetCustomers();
            Assert.IsTrue(customers.Count > 1);
        }

        [TestMethod]
        public void GetCustomerById_ShouldReturnCustomer()
        {
            Customer fetchedCustomer = _repo.GetCustomerById(4);
            Assert.AreSame(_customer, fetchedCustomer);
        }

        [TestMethod]
        public void UpdateCustomer_ShouldAssignUpdatedValues()
        {
            Customer updatedCustomer = new Customer(004, "Brown", 57, new DateTime(2018, 03, 15));
            bool result = _repo.UpdateExistingCustomerById(4, updatedCustomer);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Delete_ShouldDelete()
        {
            Assert.IsTrue(_repo.DeleteExistingCustomer(_customer));
        }

        [TestMethod]
        public void ThankYou_ShouldThank()
        {
            _repo.ThankYouNote();
        }
    }
}
