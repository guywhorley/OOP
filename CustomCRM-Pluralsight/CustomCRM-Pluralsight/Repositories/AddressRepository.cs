using System.Collections.Generic;
using Acme.BL.Entities;

namespace Acme.BL.Repositories
{
    public class AddressRepository
    {
        /// <summary>
        /// Save the Address.
        /// </summary>
        /// <returns></returns>
        public bool Save(Address address)
        {
            // setting true for testing
            var success = true;

            if (address.HasChanges && address.IsValid)
            {
                if (address.IsNew)
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
        /// Retrieve one address.
        /// </summary>
        /// <param name="addressId"></param>
        /// <returns></returns>
        public Address Retrieve(int addressId)
        {
            var address = new Address(addressId);

            //code that retrieves the defined addresses

            // for testing
            if (addressId != 1) return address;

            address.StreetLine1 = "123 4th Ave NE";
            address.City = "Testville";
            address.State = "Test";
            address.Country = "USA";
            address.PostalCode = "55555";
            address.AddressType = AddressType.Home;
            return address;
        }

        public IEnumerable<Address> RetrieveByCustomerId(int customerId)
        {
            // code that retrieves the defined addresses for the customer

            // for testing
            IEnumerable<Address> addressList = new List<Address>()
            {
                new Address(1)
                {
                    StreetLine1 = "North Plum St.",
                    City = "1Testville",
                    State = "1Test",
                    Country = "1USA",
                    PostalCode = "66666-7777",
                    AddressType = AddressType.Home

                },
                new Address(2)
                {
                    StreetLine1 = "777 5th Ave.",
                    City = "2Testville",
                    State = "2Test",
                    Country = "2USA",
                    PostalCode = "55555",
                    AddressType = AddressType.Work
                }
            };
            return addressList;
        }

        /// <summary>
        /// Retrieve all addresses.
        /// </summary>
        /// <returns></returns>
        public List<Address> Retrieve()
        {
            // code that returns the addresses

            // for testing
            return new List<Address>()
            {
                new Address(123),
                new Address(456),
                new Address(789)
            };
        }
    }
}
