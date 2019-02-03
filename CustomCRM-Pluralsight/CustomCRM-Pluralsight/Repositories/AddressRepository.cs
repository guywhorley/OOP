using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Acme.CMS.Entities;

namespace Acme.CMS.Repositories
{
    public class AddressRepository
    {
        /// <summary>
        /// Save the Address.
        /// </summary>
        /// <returns></returns>
        public bool Save(Address address) => true;

        /// <summary>
        /// Retrieve one customer.
        /// </summary>
        /// <param name="customerId"></param>
        /// <returns></returns>
        public Address Retrieve(int addressId)
        {
            var address = new Address(addressId);

            if (addressId == 1)
            {
                address.StreetLine1 = "123 4th Ave NE";
                address.City = "Testville";
                address.State = "Test";
                address.Country = "USA";
                address.PostalCode = "55555";
            }
            return address;
        }

        /// <summary>
        /// Retrieve all customers.
        /// </summary>
        /// <returns></returns>
        public List<Address> Retrieve()
        {
            return new List<Address>()
            {
                new Address(123),
                new Address(456),
                new Address(789)
            };
        }
    }
}
