using System.Collections.Generic;
using System.Linq;
using Acme.BL.Entities;

namespace Acme.BL.Repositories
{
    /// <summary>
    /// Repository for customers.
    /// </summary>
    public class CustomerRepository
    {
        private AddressRepository m_addressRepository { get; set;}

        public CustomerRepository()
        {
            // has-a
            m_addressRepository = new AddressRepository();
        }

        /// <summary>
        /// Save the customer.
        /// </summary>
        /// <returns></returns>
        public bool Save(Customer customer)
        {
            // setting true for testing
            var success = true;

            if (customer.HasChanges && customer.IsValid)
            {
                if (customer.IsNew)
                {
                    // call an insert operation
                }
                else
                {
                    // call an update operation
                }
            }
            return success;
        }

        /// <summary>
        /// Retrieve one customer.
        /// </summary>
        /// <param name="customerId"></param>
        /// <returns></returns>
        public Customer Retrieve(int customerId)
        {
            Customer customer = new Customer(customerId);
            customer.AddressList = m_addressRepository.
                RetrieveByCustomerId(customerId).ToList(); // ToList converts the IEnumerable

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