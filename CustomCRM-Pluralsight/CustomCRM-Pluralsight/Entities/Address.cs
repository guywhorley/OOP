using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acme.CMS.Entities
{
    /// <summary>
    /// Address class for all things addressy.
    /// </summary>
    public class Address
    {
        /// <summary>
        /// Constructor.
        /// </summary>
        public Address()
        {
        }

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="addressId"></param>
        public Address(int addressId)
        {
            this.AddressId = addressId;
        }

        /// <summary>
        /// Address Id.
        /// </summary>
        public int AddressId { get; private set; }

        /// <summary>
        /// Address Type.
        /// </summary>
        public int AddressType { get; set; }

        /// <summary>
        /// Address StreetLine 1.
        /// </summary>
        public string StreetLine1 { get; set; }

        /// <summary>
        /// Address StreetLine 2.
        /// </summary>
        public string  StreetLine2 { get; set; }

        /// <summary>
        /// Address City.
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// Address State.
        /// </summary>
        public string State { get; set; }

        /// <summary>
        /// Address zip code.
        /// </summary>
        public string  PostalCode { get; set; }

        /// <summary>
        /// Address Country.
        /// </summary>
        public string Country { get; set; }
    }
}
