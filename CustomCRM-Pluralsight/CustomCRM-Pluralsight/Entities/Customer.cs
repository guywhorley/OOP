using System;
using System.Collections.Generic;
using Acme.CMS.Repositories;

namespace Acme.CMS.Entities
{
    /// <summary>
    /// Customer entity.
    /// </summary>
    public class Customer
    {
        private AddressRepository m_addressRepository;

        /// <summary>
        /// Constructor.
        /// </summary>
        public Customer() : this(0) // Note: calls another constructor
        {
        }

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="customerId"></param>
        public Customer(int customerId)
        {
            m_addressRepository = new AddressRepository();
            InstanceCount++;
            this.CustomerId = customerId;
            AddressList = new List<Address>();
        }

        /// <summary>
        /// Number of Customer instances.
        /// </summary>
        public static int InstanceCount { get; set; }

        /// <summary>
        /// List of customer's addresses.
        /// </summary>
        public List<Address> AddressList { get; set; }

        /// <summary>
        /// First name.
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Last name.
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Full name.
        /// </summary>
        public string FullName => $"{FirstName} {LastName}".Trim();

        /// <summary>
        /// Email address.
        /// </summary>
        public string EmailAddress { get; set; }

        /// <summary>
        /// CustomerId.
        /// </summary>
        public int CustomerId { get; private set; }

        /// <summary>
        /// Validate that the Customer state is valid. The LastName and EmailAddress
        /// must be non-empty. (not null or whitespace)
        /// </summary>
        /// <returns></returns>
        public bool Validate() => (!string.IsNullOrWhiteSpace(LastName) && !string.IsNullOrWhiteSpace(EmailAddress));

    }
}