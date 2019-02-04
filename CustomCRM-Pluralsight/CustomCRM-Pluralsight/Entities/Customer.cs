using System.Collections.Generic;
using Acme.Common;

namespace Acme.BL.Entities
{
    /// <summary>
    /// Customer entity.
    /// </summary>
    public class Customer : EntityBase, ILoggable
    {
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
            InstanceCount++;
            this.CustomerId = customerId;
        }

        public override string ToString() => $"CustomerId:{CustomerId}, FullName:{FullName}";

        /// <summary>
        /// Log summary of customer.
        /// </summary>
        /// <returns></returns>
        public string Log(string message)
        {
            return $"{message}; {CustomerId}:{FullName} Email:{EmailAddress} Status:{EntityState.ToString()}";
        }

        /// <summary>
        /// Custom record state.
        /// </summary>
        public EntityStateOptions EntityState { get; set; }

        /// <summary>
        /// Customer type.
        /// </summary>
        public CustomerType CustomerType { get; set; }

        /// <summary>
        /// Number of Customer instances.
        /// </summary>
        public static int InstanceCount { get; set; }

        // Note: Example of composition i.e. "has a", in this case, Custom has a list of addresses
        /// <summary>
        /// List of customer's addresses.
        /// </summary>
        public List<Address> AddressList { get; set; } = new List<Address>();

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
        public override bool Validate() =>
            (!string.IsNullOrWhiteSpace(LastName) &&
             !string.IsNullOrWhiteSpace(EmailAddress));

    }
}