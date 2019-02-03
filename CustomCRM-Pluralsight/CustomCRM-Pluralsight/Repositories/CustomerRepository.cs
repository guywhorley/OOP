using System.Collections.Generic;
using Acme.CMS.Entities;

namespace Acme.CMS.Repositories
{
    /// <summary>
    /// Repository for customers.
    /// </summary>
    public class CustomerRepository
    {
        /// <summary>
        /// Save the customer.
        /// </summary>
        /// <returns></returns>
        public bool Save(Customer customer) => true;

        /// <summary>
        /// Retrieve one customer.
        /// </summary>
        /// <param name="customerId"></param>
        /// <returns></returns>
        public Customer Retrieve(int customerId)
        {
            var customer = new Customer(customerId);

            // temp hard-code values to return a populated customer.
            // this should come from a data store.
            if (customerId == 1)
            {
                customer.EmailAddress = "Testy@McTesterson.org";
                customer.FirstName = "Testy";
                customer.LastName = "McTesterson";
            }
            return customer;
        }

        /// <summary>
        /// Retrieve all customers.
        /// </summary>
        /// <returns></returns>
        public List<Customer> Retrieve()
        {
            // temp hard-code to return a list. Should come from data store.
            return new List<Customer>()
            {
                new Customer(123),
                new Customer(456),
                new Customer(789)
            };
        }


    }
}