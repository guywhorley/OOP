using System;
using System.Collections.Generic;

namespace Acme.CMS.Entities
{
    /// <summary>
    /// Customer entity.
    /// </summary>
    public class Customer
    {
        /// <summary>
        /// Constructor.
        /// </summary>
        public Customer()
        {
            InstanceCount++;
        }

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="customerId"></param>
        public Customer(int customerId)
        {
            this.CustomerId = customerId;
        }

        /// <summary>
        /// Number of Customer instances.
        /// </summary>
        public static int InstanceCount { get; set; }

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